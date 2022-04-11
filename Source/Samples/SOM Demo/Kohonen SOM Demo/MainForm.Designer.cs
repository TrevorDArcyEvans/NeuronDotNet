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

namespace NeuronDotNet.Samples.KohonenSomDemo
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblRadius = new System.Windows.Forms.Label();
            this.lblCycles = new System.Windows.Forms.Label();
            this.lblLearningRate = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoRectangularLattice = new System.Windows.Forms.RadioButton();
            this.rdoHexagonalLattice = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkCircularColumns = new System.Windows.Forms.CheckBox();
            this.chkCircularRows = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblSeparator2 = new System.Windows.Forms.Label();
            this.txtCycles = new System.Windows.Forms.TextBox();
            this.txtLearningRate = new System.Windows.Forms.TextBox();
            this.chkShowOnlyWinners = new System.Windows.Forms.CheckBox();
            this.chkShowConnections = new System.Windows.Forms.CheckBox();
            this.chkShowVisualization = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cboClustersCount = new System.Windows.Forms.ComboBox();
            this.cboNodesCount = new System.Windows.Forms.ComboBox();
            this.cboRadius = new System.Windows.Forms.ComboBox();
            this.btnGenerateSet = new System.Windows.Forms.Button();
            this.lblClustersCount = new System.Windows.Forms.Label();
            this.lblPointsCount = new System.Windows.Forms.Label();
            this.kohonenGraph = new ZedGraph.ZedGraphControl();
            this.trainingGraph = new ZedGraph.ZedGraphControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoMexicanHatFunction = new System.Windows.Forms.RadioButton();
            this.rdoGaussianFunction = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(6, 42);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(73, 13);
            this.lblHeight.TabIndex = 36;
            this.lblHeight.Text = "Layer Height :";
            this.lblHeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(6, 21);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(73, 13);
            this.lblWidth.TabIndex = 34;
            this.lblWidth.Text = "Layer Width  :";
            this.lblWidth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadius.Location = new System.Drawing.Point(7, 22);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(70, 13);
            this.lblRadius.TabIndex = 34;
            this.lblRadius.Text = "Cluster radius";
            this.lblRadius.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCycles
            // 
            this.lblCycles.AutoSize = true;
            this.lblCycles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCycles.Location = new System.Drawing.Point(9, 44);
            this.lblCycles.Name = "lblCycles";
            this.lblCycles.Size = new System.Drawing.Size(78, 13);
            this.lblCycles.TabIndex = 40;
            this.lblCycles.Text = "Training cycles";
            this.lblCycles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLearningRate
            // 
            this.lblLearningRate.AutoSize = true;
            this.lblLearningRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLearningRate.Location = new System.Drawing.Point(9, 22);
            this.lblLearningRate.Name = "lblLearningRate";
            this.lblLearningRate.Size = new System.Drawing.Size(69, 13);
            this.lblLearningRate.TabIndex = 38;
            this.lblLearningRate.Text = "Learning rate";
            this.lblLearningRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHeight);
            this.groupBox1.Controls.Add(this.lblHeight);
            this.groupBox1.Controls.Add(this.txtWidth);
            this.groupBox1.Controls.Add(this.lblWidth);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(187, 386);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kohonen Layer Size";
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.Location = new System.Drawing.Point(85, 39);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(49, 20);
            this.txtHeight.TabIndex = 37;
            this.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWidth
            // 
            this.txtWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWidth.Location = new System.Drawing.Point(85, 18);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(49, 20);
            this.txtWidth.TabIndex = 35;
            this.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoRectangularLattice);
            this.groupBox3.Controls.Add(this.rdoHexagonalLattice);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(336, 386);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(143, 65);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Neuron Lattice Topology";
            // 
            // rdoRectangularLattice
            // 
            this.rdoRectangularLattice.AutoSize = true;
            this.rdoRectangularLattice.Location = new System.Drawing.Point(8, 42);
            this.rdoRectangularLattice.Name = "rdoRectangularLattice";
            this.rdoRectangularLattice.Size = new System.Drawing.Size(118, 17);
            this.rdoRectangularLattice.TabIndex = 0;
            this.rdoRectangularLattice.Text = "Rectangular Lattice";
            this.rdoRectangularLattice.UseVisualStyleBackColor = true;
            // 
            // rdoHexagonalLattice
            // 
            this.rdoHexagonalLattice.AutoSize = true;
            this.rdoHexagonalLattice.Checked = true;
            this.rdoHexagonalLattice.Location = new System.Drawing.Point(8, 19);
            this.rdoHexagonalLattice.Name = "rdoHexagonalLattice";
            this.rdoHexagonalLattice.Size = new System.Drawing.Size(111, 17);
            this.rdoHexagonalLattice.TabIndex = 0;
            this.rdoHexagonalLattice.TabStop = true;
            this.rdoHexagonalLattice.Text = "Hexagonal Lattice";
            this.rdoHexagonalLattice.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkCircularColumns);
            this.groupBox4.Controls.Add(this.chkCircularRows);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(187, 457);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(143, 65);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Layer Shape";
            // 
            // chkCircularColumns
            // 
            this.chkCircularColumns.AutoSize = true;
            this.chkCircularColumns.Location = new System.Drawing.Point(8, 42);
            this.chkCircularColumns.Name = "chkCircularColumns";
            this.chkCircularColumns.Size = new System.Drawing.Size(126, 17);
            this.chkCircularColumns.TabIndex = 0;
            this.chkCircularColumns.Text = "Use Circular Columns";
            this.chkCircularColumns.UseVisualStyleBackColor = true;
            // 
            // chkCircularRows
            // 
            this.chkCircularRows.AutoSize = true;
            this.chkCircularRows.Location = new System.Drawing.Point(8, 19);
            this.chkCircularRows.Name = "chkCircularRows";
            this.chkCircularRows.Size = new System.Drawing.Size(113, 17);
            this.chkCircularRows.TabIndex = 0;
            this.chkCircularRows.Text = "Use Circular Rows";
            this.chkCircularRows.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.progressBar);
            this.groupBox6.Controls.Add(this.btnStop);
            this.groupBox6.Controls.Add(this.btnStart);
            this.groupBox6.Controls.Add(this.lblSeparator2);
            this.groupBox6.Controls.Add(this.txtCycles);
            this.groupBox6.Controls.Add(this.lblCycles);
            this.groupBox6.Controls.Add(this.txtLearningRate);
            this.groupBox6.Controls.Add(this.lblLearningRate);
            this.groupBox6.Controls.Add(this.chkShowOnlyWinners);
            this.groupBox6.Controls.Add(this.chkShowConnections);
            this.groupBox6.Controls.Add(this.chkShowVisualization);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(485, 386);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(285, 136);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Kohonen Learning";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(158, 100);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(117, 23);
            this.progressBar.TabIndex = 50;
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(12, 102);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(128, 27);
            this.btnStop.TabIndex = 49;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.StopLearning);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 69);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(128, 27);
            this.btnStart.TabIndex = 48;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.StartLearning);
            // 
            // lblSeparator2
            // 
            this.lblSeparator2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeparator2.Location = new System.Drawing.Point(150, 11);
            this.lblSeparator2.Name = "lblSeparator2";
            this.lblSeparator2.Size = new System.Drawing.Size(2, 119);
            this.lblSeparator2.TabIndex = 44;
            // 
            // txtCycles
            // 
            this.txtCycles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCycles.Location = new System.Drawing.Point(88, 41);
            this.txtCycles.Name = "txtCycles";
            this.txtCycles.Size = new System.Drawing.Size(52, 20);
            this.txtCycles.TabIndex = 43;
            this.txtCycles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLearningRate
            // 
            this.txtLearningRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLearningRate.Location = new System.Drawing.Point(88, 19);
            this.txtLearningRate.Name = "txtLearningRate";
            this.txtLearningRate.Size = new System.Drawing.Size(52, 20);
            this.txtLearningRate.TabIndex = 39;
            this.txtLearningRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkShowOnlyWinners
            // 
            this.chkShowOnlyWinners.AutoSize = true;
            this.chkShowOnlyWinners.Location = new System.Drawing.Point(161, 69);
            this.chkShowOnlyWinners.Name = "chkShowOnlyWinners";
            this.chkShowOnlyWinners.Size = new System.Drawing.Size(114, 17);
            this.chkShowOnlyWinners.TabIndex = 4;
            this.chkShowOnlyWinners.Text = "Show only winners";
            this.chkShowOnlyWinners.UseVisualStyleBackColor = true;
            this.chkShowOnlyWinners.CheckedChanged += new System.EventHandler(this.OnSettingsChanged);
            // 
            // chkShowConnections
            // 
            this.chkShowConnections.AutoSize = true;
            this.chkShowConnections.Checked = true;
            this.chkShowConnections.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowConnections.Location = new System.Drawing.Point(161, 46);
            this.chkShowConnections.Name = "chkShowConnections";
            this.chkShowConnections.Size = new System.Drawing.Size(115, 17);
            this.chkShowConnections.TabIndex = 5;
            this.chkShowConnections.Text = "Show Connections";
            this.chkShowConnections.UseVisualStyleBackColor = true;
            this.chkShowConnections.CheckedChanged += new System.EventHandler(this.OnSettingsChanged);
            // 
            // chkShowVisualization
            // 
            this.chkShowVisualization.AutoSize = true;
            this.chkShowVisualization.Checked = true;
            this.chkShowVisualization.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowVisualization.Location = new System.Drawing.Point(161, 23);
            this.chkShowVisualization.Name = "chkShowVisualization";
            this.chkShowVisualization.Size = new System.Drawing.Size(114, 17);
            this.chkShowVisualization.TabIndex = 3;
            this.chkShowVisualization.Text = "Show Visualization";
            this.chkShowVisualization.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cboClustersCount);
            this.groupBox5.Controls.Add(this.cboNodesCount);
            this.groupBox5.Controls.Add(this.cboRadius);
            this.groupBox5.Controls.Add(this.btnGenerateSet);
            this.groupBox5.Controls.Add(this.lblClustersCount);
            this.groupBox5.Controls.Add(this.lblPointsCount);
            this.groupBox5.Controls.Add(this.lblRadius);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(12, 386);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(169, 136);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Training Set Generation";
            // 
            // cboClustersCount
            // 
            this.cboClustersCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClustersCount.FormattingEnabled = true;
            this.cboClustersCount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cboClustersCount.Location = new System.Drawing.Point(99, 73);
            this.cboClustersCount.Name = "cboClustersCount";
            this.cboClustersCount.Size = new System.Drawing.Size(61, 21);
            this.cboClustersCount.TabIndex = 39;
            // 
            // cboNodesCount
            // 
            this.cboNodesCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNodesCount.FormattingEnabled = true;
            this.cboNodesCount.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cboNodesCount.Location = new System.Drawing.Point(99, 46);
            this.cboNodesCount.Name = "cboNodesCount";
            this.cboNodesCount.Size = new System.Drawing.Size(61, 21);
            this.cboNodesCount.TabIndex = 39;
            // 
            // cboRadius
            // 
            this.cboRadius.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRadius.FormattingEnabled = true;
            this.cboRadius.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50"});
            this.cboRadius.Location = new System.Drawing.Point(99, 19);
            this.cboRadius.Name = "cboRadius";
            this.cboRadius.Size = new System.Drawing.Size(61, 21);
            this.cboRadius.TabIndex = 39;
            // 
            // btnGenerateSet
            // 
            this.btnGenerateSet.Location = new System.Drawing.Point(10, 100);
            this.btnGenerateSet.Name = "btnGenerateSet";
            this.btnGenerateSet.Size = new System.Drawing.Size(150, 27);
            this.btnGenerateSet.TabIndex = 38;
            this.btnGenerateSet.Text = "Generate Random Set";
            this.btnGenerateSet.UseVisualStyleBackColor = true;
            this.btnGenerateSet.Click += new System.EventHandler(this.GenerateRandomSet);
            // 
            // lblClustersCount
            // 
            this.lblClustersCount.AutoSize = true;
            this.lblClustersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClustersCount.Location = new System.Drawing.Point(7, 76);
            this.lblClustersCount.Name = "lblClustersCount";
            this.lblClustersCount.Size = new System.Drawing.Size(72, 13);
            this.lblClustersCount.TabIndex = 36;
            this.lblClustersCount.Text = "No of clusters";
            this.lblClustersCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPointsCount
            // 
            this.lblPointsCount.AutoSize = true;
            this.lblPointsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPointsCount.Location = new System.Drawing.Point(7, 49);
            this.lblPointsCount.Name = "lblPointsCount";
            this.lblPointsCount.Size = new System.Drawing.Size(90, 13);
            this.lblPointsCount.TabIndex = 36;
            this.lblPointsCount.Text = "Nodes per cluster";
            this.lblPointsCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // kohonenGraph
            // 
            this.kohonenGraph.Location = new System.Drawing.Point(394, 12);
            this.kohonenGraph.Name = "kohonenGraph";
            this.kohonenGraph.ScrollGrace = 0;
            this.kohonenGraph.ScrollMaxX = 0;
            this.kohonenGraph.ScrollMaxY = 0;
            this.kohonenGraph.ScrollMaxY2 = 0;
            this.kohonenGraph.ScrollMinX = 0;
            this.kohonenGraph.ScrollMinY = 0;
            this.kohonenGraph.ScrollMinY2 = 0;
            this.kohonenGraph.Size = new System.Drawing.Size(376, 368);
            this.kohonenGraph.TabIndex = 5;
            // 
            // trainingGraph
            // 
            this.trainingGraph.Location = new System.Drawing.Point(12, 12);
            this.trainingGraph.Name = "trainingGraph";
            this.trainingGraph.ScrollGrace = 0;
            this.trainingGraph.ScrollMaxX = 0;
            this.trainingGraph.ScrollMaxY = 0;
            this.trainingGraph.ScrollMaxY2 = 0;
            this.trainingGraph.ScrollMinX = 0;
            this.trainingGraph.ScrollMinY = 0;
            this.trainingGraph.ScrollMinY2 = 0;
            this.trainingGraph.Size = new System.Drawing.Size(376, 368);
            this.trainingGraph.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoMexicanHatFunction);
            this.groupBox2.Controls.Add(this.rdoGaussianFunction);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(336, 457);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(143, 65);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Neighborhood Function";
            // 
            // rdoMexicanHatFunction
            // 
            this.rdoMexicanHatFunction.AutoSize = true;
            this.rdoMexicanHatFunction.Location = new System.Drawing.Point(8, 42);
            this.rdoMexicanHatFunction.Name = "rdoMexicanHatFunction";
            this.rdoMexicanHatFunction.Size = new System.Drawing.Size(129, 17);
            this.rdoMexicanHatFunction.TabIndex = 0;
            this.rdoMexicanHatFunction.Text = "Mexican Hat Function";
            this.rdoMexicanHatFunction.UseVisualStyleBackColor = true;
            // 
            // rdoGaussianFunction
            // 
            this.rdoGaussianFunction.AutoSize = true;
            this.rdoGaussianFunction.Checked = true;
            this.rdoGaussianFunction.Location = new System.Drawing.Point(8, 19);
            this.rdoGaussianFunction.Name = "rdoGaussianFunction";
            this.rdoGaussianFunction.Size = new System.Drawing.Size(113, 17);
            this.rdoGaussianFunction.TabIndex = 0;
            this.rdoGaussianFunction.TabStop = true;
            this.rdoGaussianFunction.Text = "Gaussian Function";
            this.rdoGaussianFunction.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 532);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.trainingGraph);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.kohonenGraph);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(790, 566);
            this.MinimumSize = new System.Drawing.Size(790, 566);
            this.Name = "MainForm";
            this.Text = "Kohonen Self-Organization Demo - NeuronDotNet";
            this.Load += new System.EventHandler(this.LoadForm);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdoHexagonalLattice;
        private System.Windows.Forms.RadioButton rdoRectangularLattice;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkCircularRows;
        private System.Windows.Forms.CheckBox chkCircularColumns;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnGenerateSet;
        private System.Windows.Forms.CheckBox chkShowOnlyWinners;
        private System.Windows.Forms.CheckBox chkShowConnections;
        private System.Windows.Forms.CheckBox chkShowVisualization;
        private System.Windows.Forms.TextBox txtCycles;
        private System.Windows.Forms.TextBox txtLearningRate;
        private System.Windows.Forms.Label lblSeparator2;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ProgressBar progressBar;
        private ZedGraph.ZedGraphControl kohonenGraph;
        private ZedGraph.ZedGraphControl trainingGraph;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.Label lblCycles;
        private System.Windows.Forms.Label lblLearningRate;
        private System.Windows.Forms.Label lblClustersCount;
        private System.Windows.Forms.Label lblPointsCount;
        private System.Windows.Forms.ComboBox cboNodesCount;
        private System.Windows.Forms.ComboBox cboRadius;
        private System.Windows.Forms.ComboBox cboClustersCount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoMexicanHatFunction;
        private System.Windows.Forms.RadioButton rdoGaussianFunction;
    }
}