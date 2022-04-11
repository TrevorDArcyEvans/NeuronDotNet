/***********************************************************************************************
 COPYRIGHT 2008 Vijeth D

 This file is part of TSP Solver NeuronDotNet Sample.
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
using ZedGraph;

namespace NeuronDotNet.Samples.TspSolver
{
    public partial class MainForm : Form
    {
        private double[] xValues;
        private double[] yValues;
        private int citiesCount = 25;
        private int neuronCount = 50;
        private bool showVisualization = true;
        private int trainingCycles = 1000;
        private float cityWidth = 5f;
        private Color cityColor = Color.DarkGoldenrod;

        private static readonly Random randomGenerator = new Random();
        private TrainingSet trainingSet = null;
        private KohonenNetwork network = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Solve(object sender, EventArgs e)
        {
            try
            {
                this.trainingCycles = Math.Max(1, int.Parse(txtCycles.Text));
            }
            catch (Exception) { }
            finally
            {
                txtCycles.Text = trainingCycles.ToString();
            }
            SetEnablement(false);
            KohonenLayer inputLayer = new KohonenLayer(2);
            KohonenLayer outputLayer = new KohonenLayer(new Size(neuronCount, 1));
            outputLayer.IsRowCircular = true;

            KohonenConnector connector = new KohonenConnector(inputLayer, outputLayer);

            connector.Initializer = new RandomFunction(0, 100);
            network = new KohonenNetwork(inputLayer, outputLayer);
            network.SetLearningRate(0.3);

            int progress = 0;

            network.EndEpochEvent += new TrainingEpochEventHandler(
                delegate(object senderNetwork, TrainingEpochEventArgs args)
                {
                    trainingProgressBar.Value = ((progress++) * 100) / trainingCycles;
                    if (showVisualization) ShowMap();
                    Application.DoEvents();
                });
            network.Learn(trainingSet, trainingCycles);
            ShowMap();
            SetEnablement(true);
        }

        private void ShowMap()
        {
            if (network == null)
            {
                return;
            }
            double[] xVal = new double[neuronCount+1];
            double[] yVal = new double[neuronCount+1];
            for (int i = 0; i < neuronCount; i++)
            {
                IList<ISynapse> synapses = (network.OutputLayer as KohonenLayer)[i].SourceSynapses;
                xVal[i] = synapses[0].Weight;
                yVal[i] = synapses[1].Weight;
            }
            xVal[neuronCount] = xVal[0];
            yVal[neuronCount] = yVal[0];

            GraphPane pane = citiesGraph.GraphPane;
            pane.CurveList.Clear();

            LineItem lineItem = citiesGraph.GraphPane.AddCurve("", xValues, yValues, cityColor, SymbolType.Circle);
            lineItem.Line.IsVisible = false;
            lineItem.Symbol.Fill.Type = FillType.Solid;
            lineItem.Symbol.Size = cityWidth;

            lineItem = citiesGraph.GraphPane.AddCurve("", xVal, yVal, cityColor, SymbolType.None);
            citiesGraph.Refresh();
        }

        private void SetEnablement(bool enablement)
        {
            btnStop.Enabled = !enablement;
            btnSolve.Enabled = enablement;
            btnRandomize.Enabled = enablement;
            txtCities.Enabled = enablement;
            txtCycles.Enabled = enablement;
            trainingProgressBar.Value = 0;
        }

        private void Randomize(object sender, EventArgs e)
        {
            try
            {
                this.citiesCount = Math.Max(2, Math.Min(100, int.Parse(txtCities.Text)));
            }
            catch (Exception) { }
            finally
            {
                this.txtCities.Text = citiesCount.ToString();
            }

            neuronCount = 2 * citiesCount;

            xValues = new double[citiesCount];
            yValues = new double[citiesCount];

            trainingSet = new TrainingSet(2);
            for (int i = 0; i < citiesCount; i++)
            {
                xValues[i] = randomGenerator.Next(1, 99);
                yValues[i] = randomGenerator.Next(1, 99);
                trainingSet.Add(new TrainingSample(new double[] {xValues[i], yValues[i]}));
            }

            citiesGraph.GraphPane.CurveList.Clear();
            LineItem lineItem = citiesGraph.GraphPane.AddCurve("", xValues, yValues, cityColor, SymbolType.Circle);
            lineItem.Line.IsVisible = false;
            lineItem.Symbol.Fill.Type = FillType.Solid;
            lineItem.Symbol.Size = cityWidth;
            citiesGraph.Refresh();
        }

        private void LoadForm(object sender, EventArgs e)
        {
            GraphPane pane = citiesGraph.GraphPane;
            pane.XAxis.Title.IsVisible = false;
            pane.YAxis.Title.IsVisible = false;
            pane.Legend.IsVisible = false;
            pane.Chart.Fill = new Fill(Color.AntiqueWhite, Color.Honeydew, -45F);
            pane.CurveList.Clear();
            pane.XAxis.Scale.Min = 0;
            pane.XAxis.Scale.Max = 100;
            pane.YAxis.Scale.Min = 0;
            pane.YAxis.Scale.Max = 100;
            pane.Title.Text = "Sales Map";
            pane.XAxis.MajorTic.IsOutside = false;
            pane.XAxis.MinorTic.IsOutside = false;
            pane.YAxis.MajorTic.IsOutside = false;
            pane.YAxis.MinorTic.IsOutside = false;
            pane.XAxis.MajorGrid.IsVisible = true;
            pane.YAxis.MajorGrid.IsVisible = true;
            pane.XAxis.MajorGrid.Color = Color.LightGray;
            pane.YAxis.MajorGrid.Color = Color.LightGray;
            citiesGraph.AxisChange();
            Randomize(this, EventArgs.Empty);
            SetEnablement(true);
        }

        private void ToggleVisualization(object sender, EventArgs e)
        {
            this.showVisualization = chkShowVisualization.Checked;
        }

        private void StopTraining(object sender, EventArgs e)
        {
            if (network != null)
            {
                network.StopLearning();
                ShowMap();
            }
            SetEnablement(true);
        }

        private void MainFormClosing(object sender, FormClosingEventArgs e)
        {
            StopTraining(this, EventArgs.Empty);
        }
    }
}
