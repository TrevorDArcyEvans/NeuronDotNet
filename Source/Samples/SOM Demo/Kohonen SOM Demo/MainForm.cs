/***********************************************************************************************
 COPYRIGHT 2008 Vijeth D

 This file is part of NeuronDotNet Kohonen SOM Demo.
 (Project Website : http://neurondotnet.freehostia.com)

 NeuronDotNet is a free software. You can redistribute it and/or modify it under the terms of
 the GNU General Public License as published by the Free Software Foundation, either version 3
 of the License, or (at your option) any later version.

 NeuronDotNet is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY;
 without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
 See the GNU General Public License for more details.

 You should have received a copy of the GNU General Public License along with NeuronDotNet.
 If not, see <http://www.gnu.org/licenses/>.

 ***********************************************************************************************/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using NeuronDotNet.Core;
using NeuronDotNet.Core.Initializers;
using NeuronDotNet.Core.SOM;
using NeuronDotNet.Core.SOM.NeighborhoodFunctions;
using ZedGraph;

namespace NeuronDotNet.Samples.KohonenSomDemo
{
    public partial class MainForm : Form
    {
        private int clusterRadius = 5;
        private int nodesCount = 7;
        private int clustersCount = 8;
        private int layerWidth = 12;
        private int layerHeight = 12;
        private int cycles = 500;
        private double learningRate = 0.2;

        private KohonenNetwork network;
        private readonly TrainingSet trainingSet = new TrainingSet(2);
        private static readonly Random randomGenerator = new Random();

        private static readonly Color activeColor = Color.DarkRed;
        private static readonly Color inactiveColor = Color.LightBlue;
        private static readonly Color connectionColor = Color.PeachPuff;
        
        private static readonly SymbolType neuronSymbolType = SymbolType.Circle;

        private bool[,] isWinner;
        private double[][] rowX;
        private double[][] rowY;
        private double[][] columnX;
        private double[][] columnY;
        private double[][] hexagonalX;
        private double[][] hexagonalY;

        public MainForm()
        {
            InitializeComponent();
        }

        private void LoadForm(object sender, EventArgs e)
        {
            cboRadius.Text = clusterRadius.ToString();
            cboNodesCount.Text = nodesCount.ToString();
            cboClustersCount.Text = clustersCount.ToString();
            txtWidth.Text = layerWidth.ToString();
            txtHeight.Text = layerHeight.ToString();
            txtCycles.Text = cycles.ToString();
            txtLearningRate.Text = learningRate.ToString();
            trainingGraph.GraphPane.Title.Text = "Training Set";
            kohonenGraph.GraphPane.Title.Text = "Kohonen Map Self-Organization";
            InitGraph(trainingGraph);
            InitGraph(kohonenGraph);
            trainingGraph.ZoomEvent += new ZedGraphControl.ZoomEventHandler(delegate(ZedGraphControl graph, ZoomState oldState, ZoomState newState)
            {
                newState.ApplyState(kohonenGraph.GraphPane);
                kohonenGraph.Refresh();
            });
            kohonenGraph.ZoomEvent += new ZedGraphControl.ZoomEventHandler(delegate(ZedGraphControl graph, ZoomState oldState, ZoomState newState)
            {
                newState.ApplyState(trainingGraph.GraphPane);
                trainingGraph.Refresh();
            });
            GenerateRandomSet(this, EventArgs.Empty);
        }

        private static void InitGraph(ZedGraphControl graph)
        {
            GraphPane pane = graph.GraphPane;
            pane.Chart.Fill = new Fill(Color.AntiqueWhite, Color.Honeydew, -45F);
            pane.Title.FontSpec.Size = 17;
            pane.XAxis.Title.IsVisible = false;
            pane.YAxis.Title.IsVisible = false;
            pane.Legend.IsVisible = false;
            pane.XAxis.MajorGrid.IsVisible = true;
            pane.YAxis.MajorGrid.IsVisible = true;
            pane.YAxis.MajorGrid.Color = Color.LightGray;
            pane.XAxis.MajorGrid.Color = Color.LightGray;
            pane.XAxis.Scale.Max = 100;
            pane.XAxis.Scale.Min = 0;
            pane.YAxis.Scale.Max = 100;
            pane.YAxis.Scale.Min = 0;
            pane.XAxis.MajorTic.IsOutside = false;
            pane.XAxis.MinorTic.IsOutside = false;
            pane.YAxis.MajorTic.IsOutside = false;
            pane.YAxis.MinorTic.IsOutside = false;
            pane.CurveList.Clear();
            pane.AxisChange();
        }

        private void EnableControls(bool enabled)
        {
            cboRadius.Enabled = enabled;
            cboNodesCount.Enabled = enabled;
            cboClustersCount.Enabled = enabled;
            txtWidth.Enabled = enabled;
            txtHeight.Enabled = enabled;
            txtCycles.Enabled = enabled;
            txtLearningRate.Enabled = enabled;
            chkCircularColumns.Enabled = enabled;
            chkCircularRows.Enabled = enabled;
            rdoGaussianFunction.Enabled = enabled;
            rdoMexicanHatFunction.Enabled = enabled;
            rdoHexagonalLattice.Enabled = enabled;
            rdoRectangularLattice.Enabled = enabled;
            btnStart.Enabled = enabled;
            btnGenerateSet.Enabled = enabled;
            btnStop.Enabled = !enabled;
            progressBar.Value = 0;
        }

        private void UpdateData()
        {
            if (!int.TryParse(txtWidth.Text, out layerWidth)) { layerWidth = 12; }
            if (!int.TryParse(txtHeight.Text, out layerHeight)) { layerHeight = 12; }
            if (!int.TryParse(txtCycles.Text, out cycles)) { cycles = 1000; }
            if (!double.TryParse(txtLearningRate.Text, out learningRate)) { learningRate = 0.2; }

            layerHeight = Math.Max(1, layerHeight);
            layerWidth = Math.Max(1, layerWidth);
            cycles = Math.Max(1, cycles);
            learningRate = Math.Max(0, learningRate);

            txtLearningRate.Text = learningRate.ToString();
            txtWidth.Text = layerWidth.ToString();
            txtHeight.Text = layerHeight.ToString();
            txtCycles.Text = cycles.ToString();

            isWinner = new bool[layerWidth, layerHeight];
            rowX = new double[layerHeight][];
            rowY = new double[layerHeight][];
            columnX = new double[layerWidth][];
            columnY = new double[layerWidth][];
            hexagonalX = new double[layerWidth][];
            hexagonalY = new double[layerWidth][];

            int lengthOfRow = layerWidth;
            int lengthOfColumn = layerHeight;

            if (chkCircularRows.Checked) lengthOfRow++;
            if (chkCircularColumns.Checked) lengthOfColumn++;

            for (int i = 0; i < layerWidth; i++)
            {
                columnX[i] = new double[lengthOfColumn];
                columnY[i] = new double[lengthOfColumn];
                hexagonalX[i] = new double[lengthOfColumn];
                hexagonalY[i] = new double[lengthOfColumn];
            }

            for (int i = 0; i < layerHeight; i++)
            {
                rowX[i] = new double[lengthOfRow];
                rowY[i] = new double[lengthOfRow];
            }
        }

        private void GenerateRandomSet(object sender, EventArgs e)
        {
            clusterRadius = int.Parse(cboRadius.Text);
            nodesCount = int.Parse(cboNodesCount.Text);
            clustersCount = int.Parse(cboClustersCount.Text);

            trainingSet.Clear();
            int diameter = clusterRadius * 2;

            LineItem lineItem = new LineItem("Training Set");
            lineItem.Color = activeColor;
            lineItem.Line.IsVisible = false;
            lineItem.Symbol.Type = neuronSymbolType;
            lineItem.Symbol.Fill.Type = FillType.Solid;
            lineItem.Symbol.Size = 6f;
            lineItem.Symbol.IsAntiAlias = true;

            for (int i = 0; i < clustersCount; i++)
            {
                int xMid = randomGenerator.Next(Math.Min(10, clusterRadius), Math.Max(clusterRadius, 90));
                int yMid = randomGenerator.Next(Math.Min(10, clusterRadius), Math.Max(clusterRadius, 90));

                for (int j = 0; j < nodesCount;)
                {
                    int x = xMid + randomGenerator.Next(diameter) - clusterRadius;
                    int y = yMid + randomGenerator.Next(diameter) - clusterRadius;

                    if (x > 0 && y > 0 && x < 100 && y < 100)
                    {
                        trainingSet.Add(new TrainingSample(new double[] { x, y }));
                        lineItem.AddPoint(x, y);
                        j++;
                    }
                }
            }
            trainingGraph.GraphPane.CurveList.Clear();
            trainingGraph.GraphPane.CurveList.Add(lineItem);
            trainingGraph.Refresh();
        }

        private void StartLearning(object sender, EventArgs e)
        {
            EnableControls(false);
            UpdateData();

            int learningRadius = Math.Max(layerWidth, layerHeight) / 2;

            INeighborhoodFunction neighborhoodFunction = rdoGaussianFunction.Checked
                ? new GaussianFunction(learningRadius) as INeighborhoodFunction
                : new MexicanHatFunction(learningRadius) as INeighborhoodFunction;

            LatticeTopology topology = rdoHexagonalLattice.Checked
                ? LatticeTopology.Hexagonal
                : LatticeTopology.Rectangular;

            KohonenLayer inputLayer = new KohonenLayer(2);
            KohonenLayer outputLayer = new KohonenLayer(new Size(layerWidth, layerHeight), neighborhoodFunction, topology);
            KohonenConnector connector = new KohonenConnector(inputLayer, outputLayer);

            connector.Initializer = new RandomFunction(0, 100);
            outputLayer.SetLearningRate(learningRate, 0.05d);
            outputLayer.IsRowCircular = chkCircularRows.Checked;
            outputLayer.IsColumnCircular = chkCircularColumns.Checked;
            network = new KohonenNetwork(inputLayer, outputLayer);

            int progress = 1;
            network.BeginEpochEvent += new TrainingEpochEventHandler(
                delegate(object senderNetwork, TrainingEpochEventArgs args)
                {
                    if(chkShowVisualization.Checked) ShowMap();
                    Array.Clear(isWinner, 0, layerHeight * layerWidth);
                });

            network.EndSampleEvent += new TrainingSampleEventHandler(
                delegate(object senderNetwork, TrainingSampleEventArgs args)
                {
                    isWinner[network.Winner.Coordinate.X, network.Winner.Coordinate.Y] = true;
                });

            network.EndEpochEvent += new TrainingEpochEventHandler(
                delegate(object senderNetwork, TrainingEpochEventArgs args)
                {
                    progressBar.Value = ((progress++) * 100) / cycles;
                    Application.DoEvents();
                });

            network.Learn(trainingSet, cycles);
            ShowMap();
            EnableControls(true);
        }

        private void ShowMap()
        {
            if (network == null) { return; }

            int iPrev = layerWidth - 1;
            for (int i = 0; i < layerWidth; i++)
            {
                for (int j = 0; j < layerHeight; j++)
                {
                    IList<ISynapse> synapses = (network.OutputLayer as KohonenLayer)[i, j].SourceSynapses;
                    double x = synapses[0].Weight;
                    double y = synapses[1].Weight;

                    rowX[j][i] = x;
                    rowY[j][i] = y;
                    columnX[i][j] = x;
                    columnY[i][j] = y;

                    if (j % 2 == 1)
                    {
                        hexagonalX[i][j] = x;
                        hexagonalY[i][j] = y;
                    }
                    else
                    {
                        hexagonalX[iPrev][j] = x;
                        hexagonalY[iPrev][j] = y;
                    }
                }
                iPrev = i;
            }

            if (chkCircularRows.Checked)
            {
                for (int i = 0; i < layerHeight; i++)
                {
                    rowX[i][layerWidth] = rowX[i][0];
                    rowY[i][layerWidth] = rowY[i][0];
                }
            }

            if (chkCircularColumns.Checked)
            {
                for (int i = 0; i < layerWidth; i++)
                {
                    columnX[i][layerHeight] = columnX[i][0];
                    columnY[i][layerHeight] = columnY[i][0];
                    hexagonalX[i][layerHeight] = hexagonalX[i][0];
                    hexagonalY[i][layerHeight] = hexagonalY[i][0];
                }
            }

            GraphPane pane = kohonenGraph.GraphPane;
            pane.CurveList.Clear();
            for (int i = 0; i < layerWidth; i++)
            {
                for (int j = 0; j < layerHeight; j++)
                {
                    if (isWinner[i, j] || !chkShowOnlyWinners.Checked)
                    {
                        LineItem curve = pane.AddCurve("", new double[] { columnX[i][j] }, new double[] { columnY[i][j] }, connectionColor, neuronSymbolType);
                        curve.Symbol.Fill.Type = FillType.Solid;
                        curve.Symbol.Size = 8f;
                        curve.Symbol.Fill.Color = isWinner[i, j] ? activeColor: inactiveColor;
                        curve.Line.IsAntiAlias = true;
                        curve.Symbol.IsAntiAlias = true;
                    }
                }
            }

            if (chkShowConnections.Checked)
            {
                for (int i = 0; i < layerHeight; i++)
                {
                    pane.AddCurve("", rowX[i], rowY[i], connectionColor, SymbolType.None).Line.IsAntiAlias = true;
                }
                for (int i = 0; i < layerWidth; i++)
                {
                    pane.AddCurve("", columnX[i], columnY[i], connectionColor, SymbolType.None).Line.IsAntiAlias = true;
                }
                if (rdoHexagonalLattice.Checked)
                {
                    for (int i = 0; i < layerWidth - 1; i++)
                    {
                        pane.AddCurve("", hexagonalX[i], hexagonalY[i], connectionColor, SymbolType.None).Line.IsAntiAlias = true;
                    }
                    if (chkCircularRows.Checked)
                    {
                        pane.AddCurve("", hexagonalX[layerWidth - 1], hexagonalY[layerWidth - 1], connectionColor, SymbolType.None).Line.IsAntiAlias = true;
                    }
                }
            }
            kohonenGraph.Refresh();
        }

        private void OnSettingsChanged(object sender, EventArgs e)
        {
            ShowMap();
        }

        private void StopLearning(object sender, EventArgs e)
        {
            if (network != null)
            {
                network.StopLearning();
            }
        }
    }
}
