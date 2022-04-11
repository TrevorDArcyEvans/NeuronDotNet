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

namespace NeuronDotNet.Samples.XorSample
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
            this.lblSSE = new System.Windows.Forms.Label();
            this.lblNeuronCount = new System.Windows.Forms.Label();
            this.lblLearningRate = new System.Windows.Forms.Label();
            this.lblSeparator2 = new System.Windows.Forms.Label();
            this.lblCycles = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listTrainingSet = new System.Windows.Forms.ListBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblSeparator1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.txtTestInput = new System.Windows.Forms.MaskedTextBox();
            this.lblTestOutput = new System.Windows.Forms.Label();
            this.errorGraph = new ZedGraph.ZedGraphControl();
            this.lblTrainErrorVal = new System.Windows.Forms.Label();
            this.grpSettings = new System.Windows.Forms.GroupBox();
            this.btnTrain = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.txtNeuronCount = new System.Windows.Forms.TextBox();
            this.txtLearningRate = new System.Windows.Forms.TextBox();
            this.txtCycles = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.grpSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSSE
            // 
            this.lblSSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSSE.Location = new System.Drawing.Point(6, 287);
            this.lblSSE.Name = "lblSSE";
            this.lblSSE.Size = new System.Drawing.Size(102, 14);
            this.lblSSE.TabIndex = 8;
            this.lblSSE.Text = "Sum Squared Error :";
            this.lblSSE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNeuronCount
            // 
            this.lblNeuronCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNeuronCount.Location = new System.Drawing.Point(6, 137);
            this.lblNeuronCount.Name = "lblNeuronCount";
            this.lblNeuronCount.Size = new System.Drawing.Size(115, 14);
            this.lblNeuronCount.TabIndex = 32;
            this.lblNeuronCount.Text = "Hidden Neuron Count";
            this.lblNeuronCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLearningRate
            // 
            this.lblLearningRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLearningRate.Location = new System.Drawing.Point(6, 108);
            this.lblLearningRate.Name = "lblLearningRate";
            this.lblLearningRate.Size = new System.Drawing.Size(78, 14);
            this.lblLearningRate.TabIndex = 26;
            this.lblLearningRate.Text = "Learning rate";
            this.lblLearningRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSeparator2
            // 
            this.lblSeparator2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeparator2.Location = new System.Drawing.Point(6, 209);
            this.lblSeparator2.Name = "lblSeparator2";
            this.lblSeparator2.Size = new System.Drawing.Size(173, 2);
            this.lblSeparator2.TabIndex = 36;
            // 
            // lblCycles
            // 
            this.lblCycles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCycles.Location = new System.Drawing.Point(6, 181);
            this.lblCycles.Name = "lblCycles";
            this.lblCycles.Size = new System.Drawing.Size(91, 14);
            this.lblCycles.TabIndex = 34;
            this.lblCycles.Text = "Training Cycles";
            this.lblCycles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(6, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 2);
            this.label1.TabIndex = 36;
            // 
            // listTrainingSet
            // 
            this.listTrainingSet.BackColor = System.Drawing.SystemColors.Control;
            this.listTrainingSet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listTrainingSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listTrainingSet.FormattingEnabled = true;
            this.listTrainingSet.ItemHeight = 15;
            this.listTrainingSet.Items.AddRange(new object[] {
            "    { 0.00, 0.00 }   =   { 0.00 }",
            "    { 0.00, 1.00 }   =   { 1.00 }",
            "    { 1.00, 0.00 }   =   { 1.00 }",
            "    { 1.00, 1.00 }   =   { 0.00 }"});
            this.listTrainingSet.Location = new System.Drawing.Point(9, 22);
            this.listTrainingSet.Name = "listTrainingSet";
            this.listTrainingSet.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listTrainingSet.Size = new System.Drawing.Size(166, 60);
            this.listTrainingSet.TabIndex = 40;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput.Location = new System.Drawing.Point(6, 32);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(65, 13);
            this.lblInput.TabIndex = 50;
            this.lblInput.Text = "Input Vector";
            this.lblInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutput
            // 
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(9, 92);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(82, 14);
            this.lblOutput.TabIndex = 49;
            this.lblOutput.Text = "Output Vector :";
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeparator1
            // 
            this.lblSeparator1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeparator1.Location = new System.Drawing.Point(6, 166);
            this.lblSeparator1.Name = "lblSeparator1";
            this.lblSeparator1.Size = new System.Drawing.Size(173, 2);
            this.lblSeparator1.TabIndex = 36;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTest);
            this.groupBox1.Controls.Add(this.lblInput);
            this.groupBox1.Controls.Add(this.txtTestInput);
            this.groupBox1.Controls.Add(this.lblOutput);
            this.groupBox1.Controls.Add(this.lblTestOutput);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 335);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Testing Phase";
            // 
            // btnTest
            // 
            this.btnTest.Enabled = false;
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Location = new System.Drawing.Point(9, 56);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(166, 27);
            this.btnTest.TabIndex = 51;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.Test);
            // 
            // txtTestInput
            // 
            this.txtTestInput.Enabled = false;
            this.txtTestInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTestInput.Location = new System.Drawing.Point(76, 29);
            this.txtTestInput.Mask = "{ 0.00, 0.00 }";
            this.txtTestInput.Name = "txtTestInput";
            this.txtTestInput.PromptChar = ' ';
            this.txtTestInput.Size = new System.Drawing.Size(98, 20);
            this.txtTestInput.TabIndex = 48;
            this.txtTestInput.Text = "000100";
            this.txtTestInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTestOutput
            // 
            this.lblTestOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestOutput.Location = new System.Drawing.Point(9, 116);
            this.lblTestOutput.Name = "lblTestOutput";
            this.lblTestOutput.Size = new System.Drawing.Size(165, 14);
            this.lblTestOutput.TabIndex = 47;
            this.lblTestOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorGraph
            // 
            this.errorGraph.Location = new System.Drawing.Point(208, 12);
            this.errorGraph.Name = "errorGraph";
            this.errorGraph.ScrollGrace = 0;
            this.errorGraph.ScrollMaxX = 0;
            this.errorGraph.ScrollMaxY = 0;
            this.errorGraph.ScrollMaxY2 = 0;
            this.errorGraph.ScrollMinX = 0;
            this.errorGraph.ScrollMinY = 0;
            this.errorGraph.ScrollMinY2 = 0;
            this.errorGraph.Size = new System.Drawing.Size(562, 466);
            this.errorGraph.TabIndex = 1;
            // 
            // lblTrainErrorVal
            // 
            this.lblTrainErrorVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainErrorVal.Location = new System.Drawing.Point(121, 287);
            this.lblTrainErrorVal.Name = "lblTrainErrorVal";
            this.lblTrainErrorVal.Size = new System.Drawing.Size(54, 14);
            this.lblTrainErrorVal.TabIndex = 8;
            this.lblTrainErrorVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpSettings
            // 
            this.grpSettings.Controls.Add(this.listTrainingSet);
            this.grpSettings.Controls.Add(this.btnTrain);
            this.grpSettings.Controls.Add(this.progressBar);
            this.grpSettings.Controls.Add(this.lblTrainErrorVal);
            this.grpSettings.Controls.Add(this.txtNeuronCount);
            this.grpSettings.Controls.Add(this.lblSSE);
            this.grpSettings.Controls.Add(this.lblNeuronCount);
            this.grpSettings.Controls.Add(this.txtLearningRate);
            this.grpSettings.Controls.Add(this.lblLearningRate);
            this.grpSettings.Controls.Add(this.lblSeparator2);
            this.grpSettings.Controls.Add(this.label1);
            this.grpSettings.Controls.Add(this.lblSeparator1);
            this.grpSettings.Controls.Add(this.txtCycles);
            this.grpSettings.Controls.Add(this.lblCycles);
            this.grpSettings.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSettings.Location = new System.Drawing.Point(12, 12);
            this.grpSettings.Name = "grpSettings";
            this.grpSettings.Size = new System.Drawing.Size(185, 314);
            this.grpSettings.TabIndex = 3;
            this.grpSettings.TabStop = false;
            this.grpSettings.Text = "Training Phase";
            // 
            // btnTrain
            // 
            this.btnTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrain.Location = new System.Drawing.Point(9, 253);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(166, 27);
            this.btnTrain.TabIndex = 39;
            this.btnTrain.Text = "Train";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.Train);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(9, 219);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(165, 27);
            this.progressBar.TabIndex = 37;
            // 
            // txtNeuronCount
            // 
            this.txtNeuronCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNeuronCount.Location = new System.Drawing.Point(124, 135);
            this.txtNeuronCount.Name = "txtNeuronCount";
            this.txtNeuronCount.Size = new System.Drawing.Size(51, 20);
            this.txtNeuronCount.TabIndex = 33;
            // 
            // txtLearningRate
            // 
            this.txtLearningRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLearningRate.Location = new System.Drawing.Point(124, 106);
            this.txtLearningRate.Name = "txtLearningRate";
            this.txtLearningRate.Size = new System.Drawing.Size(51, 20);
            this.txtLearningRate.TabIndex = 27;
            // 
            // txtCycles
            // 
            this.txtCycles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCycles.Location = new System.Drawing.Point(124, 179);
            this.txtCycles.Name = "txtCycles";
            this.txtCycles.Size = new System.Drawing.Size(51, 20);
            this.txtCycles.TabIndex = 35;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 489);
            this.Controls.Add(this.grpSettings);
            this.Controls.Add(this.errorGraph);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(790, 523);
            this.MinimumSize = new System.Drawing.Size(790, 523);
            this.Name = "MainForm";
            this.Text = "XOR Sample - NeuronDotNet";
            this.Load += new System.EventHandler(this.LoadForm);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpSettings.ResumeLayout(false);
            this.grpSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private ZedGraph.ZedGraphControl errorGraph;
        private System.Windows.Forms.Label lblTrainErrorVal;
        private System.Windows.Forms.GroupBox grpSettings;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox txtNeuronCount;
        private System.Windows.Forms.TextBox txtLearningRate;
        private System.Windows.Forms.TextBox txtCycles;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.MaskedTextBox txtTestInput;
        private System.Windows.Forms.Label lblTestOutput;
        private System.Windows.Forms.Label lblSSE;
        private System.Windows.Forms.Label lblNeuronCount;
        private System.Windows.Forms.Label lblLearningRate;
        private System.Windows.Forms.Label lblSeparator2;
        private System.Windows.Forms.Label lblCycles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listTrainingSet;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblSeparator1;
    }
}

