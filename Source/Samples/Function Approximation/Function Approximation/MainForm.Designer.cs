/***********************************************************************************************
 COPYRIGHT 2008 Vijeth D

 This file is part of Function Approximation NeuronDotNet Sample.
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

namespace NeuronDotNet.Samples.FunctionApproximation
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("1");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("2");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("3");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("4");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("5");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("6");
            this.columnY = new System.Windows.Forms.ColumnHeader();
            this.columnX = new System.Windows.Forms.ColumnHeader();
            this.functionGraph = new ZedGraph.ZedGraphControl();
            this.listData = new System.Windows.Forms.ListView();
            this.grpSettings = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.trainingProgressBar = new System.Windows.Forms.ProgressBar();
            this.txtNeuronCount = new System.Windows.Forms.TextBox();
            this.lblNeuronCount = new System.Windows.Forms.Label();
            this.txtLearningRate = new System.Windows.Forms.TextBox();
            this.lblLearningRate = new System.Windows.Forms.Label();
            this.lblSeparator2 = new System.Windows.Forms.Label();
            this.lblSeparator1 = new System.Windows.Forms.Label();
            this.txtCycles = new System.Windows.Forms.TextBox();
            this.lblCycles = new System.Windows.Forms.Label();
            this.grpSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnY
            // 
            this.columnY.Text = "Y";
            this.columnY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnY.Width = 154;
            // 
            // columnX
            // 
            this.columnX.Text = "X";
            this.columnX.Width = 30;
            // 
            // functionGraph
            // 
            this.functionGraph.Location = new System.Drawing.Point(12, 12);
            this.functionGraph.Name = "functionGraph";
            this.functionGraph.ScrollGrace = 0;
            this.functionGraph.ScrollMaxX = 0;
            this.functionGraph.ScrollMaxY = 0;
            this.functionGraph.ScrollMaxY2 = 0;
            this.functionGraph.ScrollMinX = 0;
            this.functionGraph.ScrollMinY = 0;
            this.functionGraph.ScrollMinY2 = 0;
            this.functionGraph.Size = new System.Drawing.Size(567, 507);
            this.functionGraph.TabIndex = 0;
            this.functionGraph.PointEditEvent += new ZedGraph.ZedGraphControl.PointEditHandler(this.OnPointEdit);
            // 
            // listData
            // 
            this.listData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnX,
            this.columnY});
            this.listData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listData.FullRowSelect = true;
            this.listData.GridLines = true;
            this.listData.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.listData.Location = new System.Drawing.Point(585, 12);
            this.listData.MultiSelect = false;
            this.listData.Name = "listData";
            this.listData.Scrollable = false;
            this.listData.ShowGroups = false;
            this.listData.Size = new System.Drawing.Size(185, 107);
            this.listData.TabIndex = 1;
            this.listData.UseCompatibleStateImageBehavior = false;
            this.listData.View = System.Windows.Forms.View.Details;
            // 
            // grpSettings
            // 
            this.grpSettings.Controls.Add(this.btnStop);
            this.grpSettings.Controls.Add(this.btnStart);
            this.grpSettings.Controls.Add(this.trainingProgressBar);
            this.grpSettings.Controls.Add(this.txtNeuronCount);
            this.grpSettings.Controls.Add(this.lblNeuronCount);
            this.grpSettings.Controls.Add(this.txtLearningRate);
            this.grpSettings.Controls.Add(this.lblLearningRate);
            this.grpSettings.Controls.Add(this.lblSeparator2);
            this.grpSettings.Controls.Add(this.lblSeparator1);
            this.grpSettings.Controls.Add(this.txtCycles);
            this.grpSettings.Controls.Add(this.lblCycles);
            this.grpSettings.Location = new System.Drawing.Point(585, 336);
            this.grpSettings.Name = "grpSettings";
            this.grpSettings.Size = new System.Drawing.Size(185, 183);
            this.grpSettings.TabIndex = 2;
            this.grpSettings.TabStop = false;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(95, 148);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(80, 26);
            this.btnStop.TabIndex = 39;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.StopLearning);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(9, 148);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(80, 26);
            this.btnStart.TabIndex = 39;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.Start);
            // 
            // trainingProgressBar
            // 
            this.trainingProgressBar.Location = new System.Drawing.Point(9, 119);
            this.trainingProgressBar.Name = "trainingProgressBar";
            this.trainingProgressBar.Size = new System.Drawing.Size(166, 23);
            this.trainingProgressBar.TabIndex = 37;
            // 
            // txtNeuronCount
            // 
            this.txtNeuronCount.Location = new System.Drawing.Point(124, 45);
            this.txtNeuronCount.Name = "txtNeuronCount";
            this.txtNeuronCount.Size = new System.Drawing.Size(51, 20);
            this.txtNeuronCount.TabIndex = 33;
            // 
            // lblNeuronCount
            // 
            this.lblNeuronCount.Location = new System.Drawing.Point(6, 48);
            this.lblNeuronCount.Name = "lblNeuronCount";
            this.lblNeuronCount.Size = new System.Drawing.Size(115, 15);
            this.lblNeuronCount.TabIndex = 32;
            this.lblNeuronCount.Text = "Hidden Neuron Count";
            // 
            // txtLearningRate
            // 
            this.txtLearningRate.Location = new System.Drawing.Point(124, 19);
            this.txtLearningRate.Name = "txtLearningRate";
            this.txtLearningRate.Size = new System.Drawing.Size(51, 20);
            this.txtLearningRate.TabIndex = 27;
            // 
            // lblLearningRate
            // 
            this.lblLearningRate.Location = new System.Drawing.Point(6, 22);
            this.lblLearningRate.Name = "lblLearningRate";
            this.lblLearningRate.Size = new System.Drawing.Size(78, 14);
            this.lblLearningRate.TabIndex = 26;
            this.lblLearningRate.Text = "Learning rate";
            // 
            // lblSeparator2
            // 
            this.lblSeparator2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeparator2.Location = new System.Drawing.Point(6, 109);
            this.lblSeparator2.Name = "lblSeparator2";
            this.lblSeparator2.Size = new System.Drawing.Size(173, 2);
            this.lblSeparator2.TabIndex = 36;
            // 
            // lblSeparator1
            // 
            this.lblSeparator1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeparator1.Location = new System.Drawing.Point(6, 74);
            this.lblSeparator1.Name = "lblSeparator1";
            this.lblSeparator1.Size = new System.Drawing.Size(173, 2);
            this.lblSeparator1.TabIndex = 36;
            // 
            // txtCycles
            // 
            this.txtCycles.Location = new System.Drawing.Point(124, 82);
            this.txtCycles.Name = "txtCycles";
            this.txtCycles.Size = new System.Drawing.Size(51, 20);
            this.txtCycles.TabIndex = 35;
            // 
            // lblCycles
            // 
            this.lblCycles.Location = new System.Drawing.Point(6, 85);
            this.lblCycles.Name = "lblCycles";
            this.lblCycles.Size = new System.Drawing.Size(91, 16);
            this.lblCycles.TabIndex = 34;
            this.lblCycles.Text = "Training Cycles";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 531);
            this.Controls.Add(this.grpSettings);
            this.Controls.Add(this.listData);
            this.Controls.Add(this.functionGraph);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(790, 565);
            this.MinimumSize = new System.Drawing.Size(790, 565);
            this.Name = "MainForm";
            this.Text = "Function Approximation - NeuronDotNet Sample";
            this.Load += new System.EventHandler(this.LoadForm);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormClosing);
            this.grpSettings.ResumeLayout(false);
            this.grpSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ZedGraph.ZedGraphControl functionGraph;
        private System.Windows.Forms.ListView listData;
        private System.Windows.Forms.GroupBox grpSettings;
        private System.Windows.Forms.TextBox txtNeuronCount;
        private System.Windows.Forms.Label lblNeuronCount;
        private System.Windows.Forms.TextBox txtLearningRate;
        private System.Windows.Forms.Label lblLearningRate;
        private System.Windows.Forms.Label lblSeparator1;
        private System.Windows.Forms.TextBox txtCycles;
        private System.Windows.Forms.Label lblCycles;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ProgressBar trainingProgressBar;
        private System.Windows.Forms.Label lblSeparator2;
        private System.Windows.Forms.ColumnHeader columnY;
        private System.Windows.Forms.ColumnHeader columnX;
    }
}

