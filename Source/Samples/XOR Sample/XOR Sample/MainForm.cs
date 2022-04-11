/***********************************************************************************************
COPYRIGHT 2008 Vijeth D

This file is part of NeuronDotNet XOR Sample.
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
using System.Drawing;
using System.Windows.Forms;
using NeuronDotNet.Core;
using NeuronDotNet.Core.Backpropagation;
using ZedGraph;

namespace NeuronDotNet.Samples.XorSample
{
	public partial class MainForm : Form
	{
		private BackpropagationNetwork xorNetwork;
		private double[] errorList;
		private int cycles = 5000;
		private int neuronCount = 3;
		private double learningRate = 0.25d;

		public MainForm()
		{
			InitializeComponent();
		}

		private void Train(object sender, EventArgs e)
		{
			EnableControls(false);
			if (!int.TryParse(txtCycles.Text.Trim(), out cycles)) { cycles = 5000; }
			if (!double.TryParse(txtLearningRate.Text.Trim(), out learningRate)) { learningRate = 0.25d; }
			if (!int.TryParse(txtNeuronCount.Text.Trim(), out neuronCount)) { neuronCount = 3; }

			if (cycles < 1) { cycles = 1; }
			if (learningRate < 0.01) { learningRate = 0.01; }
			if (neuronCount < 1) { neuronCount = 1; }

			txtNeuronCount.Text = neuronCount.ToString();
			txtCycles.Text = cycles.ToString();
			txtLearningRate.Text = learningRate.ToString();

			errorList = new double[cycles];
			InitGraph();

			LinearLayer inputLayer = new LinearLayer(2);
			SigmoidLayer hiddenLayer = new SigmoidLayer(neuronCount);
			SigmoidLayer outputLayer = new SigmoidLayer(1);
			new BackpropagationConnector(inputLayer, hiddenLayer);
			new BackpropagationConnector(hiddenLayer, outputLayer);
			xorNetwork = new BackpropagationNetwork(inputLayer, outputLayer);
			xorNetwork.SetLearningRate(learningRate);

			TrainingSet trainingSet = new TrainingSet(2, 1);
			trainingSet.Add(new TrainingSample(new double[2] { 0d, 0d }, new double[1] { 0d }));
			trainingSet.Add(new TrainingSample(new double[2] { 0d, 1d }, new double[1] { 1d }));
			trainingSet.Add(new TrainingSample(new double[2] { 1d, 0d }, new double[1] { 1d }));
			trainingSet.Add(new TrainingSample(new double[2] { 1d, 1d }, new double[1] { 0d }));

			double max = 0d;

            xorNetwork.EndEpochEvent +=
            delegate(object network, TrainingEpochEventArgs args)
            {
                errorList[args.TrainingIteration] = xorNetwork.MeanSquaredError;
                max = Math.Max(max, xorNetwork.MeanSquaredError);
                progressBar.Value = (int)(args.TrainingIteration * 100d / cycles);
            };

			xorNetwork.Learn(trainingSet, cycles);
			double[] indices = new double[cycles];
			for (int i = 0; i < cycles; i++) { indices[i] = i; }

			lblTrainErrorVal.Text = xorNetwork.MeanSquaredError.ToString("0.000000");

			LineItem errorCurve = new LineItem("Error Dynamics", indices, errorList, Color.Tomato, SymbolType.None, 1.5f);
			errorGraph.GraphPane.YAxis.Scale.Max = max;
			errorGraph.GraphPane.CurveList.Add(errorCurve);
			errorGraph.Invalidate();
			EnableControls(true);
		}

		private void EnableControls(bool enabled)
		{
			btnTrain.Enabled = enabled;
			txtCycles.Enabled = enabled;
			txtNeuronCount.Enabled = enabled;
			txtLearningRate.Enabled = enabled;
			progressBar.Value = 0;
			btnTest.Enabled = enabled;
			txtTestInput.Enabled = enabled;
		}

		private void LoadForm(object sender, EventArgs e)
		{
			InitGraph();
			txtCycles.Text = cycles.ToString();
			txtLearningRate.Text = learningRate.ToString();
			txtNeuronCount.Text = neuronCount.ToString();
		}

		private void InitGraph()
		{
			GraphPane pane = errorGraph.GraphPane;
			pane.Chart.Fill = new Fill(Color.AntiqueWhite, Color.Honeydew, -45F);
			pane.Title.Text = "Back Propagation Training - Error Graph";
			pane.XAxis.Title.Text = "Training Iteration";
			pane.YAxis.Title.Text = "Sum Squared Error";
			pane.XAxis.MajorGrid.IsVisible = true;
			pane.YAxis.MajorGrid.IsVisible = true;
            pane.YAxis.MajorGrid.Color = Color.LightGray;
            pane.XAxis.MajorGrid.Color = Color.LightGray;
			pane.XAxis.Scale.Max = cycles;
			pane.XAxis.Scale.Min = 0;
			pane.YAxis.Scale.Min = 0;
			pane.CurveList.Clear();
			pane.Legend.IsVisible = false;
			pane.AxisChange();
			errorGraph.Invalidate();
		}

		private void Test(object sender, EventArgs e)
		{
			if (xorNetwork != null)
			{
				lblTestOutput.Text = xorNetwork.Run(
				new double[] {double.Parse(txtTestInput.Text.Substring(2,4)),
					double.Parse(txtTestInput.Text.Substring(8,4))})[0].ToString("0.000000");
			}
		}
	}
}
