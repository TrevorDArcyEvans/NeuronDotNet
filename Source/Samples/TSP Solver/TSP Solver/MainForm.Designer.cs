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

namespace NeuronDotNet.Samples.TspSolver
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
            this.citiesGraph = new ZedGraph.ZedGraphControl();
            this.grpSales = new System.Windows.Forms.GroupBox();
            this.btnRandomize = new System.Windows.Forms.Button();
            this.txtCities = new System.Windows.Forms.TextBox();
            this.lblCities = new System.Windows.Forms.Label();
            this.grpTraining = new System.Windows.Forms.GroupBox();
            this.chkShowVisualization = new System.Windows.Forms.CheckBox();
            this.btnSolve = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtCycles = new System.Windows.Forms.TextBox();
            this.trainingProgressBar = new System.Windows.Forms.ProgressBar();
            this.lblTrainingCycles = new System.Windows.Forms.Label();
            this.grpSales.SuspendLayout();
            this.grpTraining.SuspendLayout();
            this.SuspendLayout();
            // 
            // citiesGraph
            // 
            this.citiesGraph.Location = new System.Drawing.Point(12, 12);
            this.citiesGraph.Name = "citiesGraph";
            this.citiesGraph.ScrollGrace = 0;
            this.citiesGraph.ScrollMaxX = 0;
            this.citiesGraph.ScrollMaxY = 0;
            this.citiesGraph.ScrollMaxY2 = 0;
            this.citiesGraph.ScrollMinX = 0;
            this.citiesGraph.ScrollMinY = 0;
            this.citiesGraph.ScrollMinY2 = 0;
            this.citiesGraph.Size = new System.Drawing.Size(524, 502);
            this.citiesGraph.TabIndex = 4;
            // 
            // grpSales
            // 
            this.grpSales.Controls.Add(this.btnRandomize);
            this.grpSales.Controls.Add(this.txtCities);
            this.grpSales.Controls.Add(this.lblCities);
            this.grpSales.Location = new System.Drawing.Point(542, 12);
            this.grpSales.Name = "grpSales";
            this.grpSales.Size = new System.Drawing.Size(153, 81);
            this.grpSales.TabIndex = 9;
            this.grpSales.TabStop = false;
            this.grpSales.Text = "Sales Map";
            // 
            // btnRandomize
            // 
            this.btnRandomize.Location = new System.Drawing.Point(11, 46);
            this.btnRandomize.Name = "btnRandomize";
            this.btnRandomize.Size = new System.Drawing.Size(133, 26);
            this.btnRandomize.TabIndex = 7;
            this.btnRandomize.Text = "Randomize Map";
            this.btnRandomize.UseVisualStyleBackColor = true;
            this.btnRandomize.Click += new System.EventHandler(this.Randomize);
            // 
            // txtCities
            // 
            this.txtCities.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCities.Location = new System.Drawing.Point(97, 20);
            this.txtCities.Name = "txtCities";
            this.txtCities.Size = new System.Drawing.Size(47, 20);
            this.txtCities.TabIndex = 6;
            this.txtCities.Text = "50";
            this.txtCities.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCities
            // 
            this.lblCities.AutoSize = true;
            this.lblCities.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCities.Location = new System.Drawing.Point(8, 23);
            this.lblCities.Name = "lblCities";
            this.lblCities.Size = new System.Drawing.Size(84, 13);
            this.lblCities.TabIndex = 5;
            this.lblCities.Text = "Number of Cities";
            // 
            // grpTraining
            // 
            this.grpTraining.Controls.Add(this.chkShowVisualization);
            this.grpTraining.Controls.Add(this.btnSolve);
            this.grpTraining.Controls.Add(this.btnStop);
            this.grpTraining.Controls.Add(this.txtCycles);
            this.grpTraining.Controls.Add(this.trainingProgressBar);
            this.grpTraining.Controls.Add(this.lblTrainingCycles);
            this.grpTraining.Location = new System.Drawing.Point(542, 340);
            this.grpTraining.Name = "grpTraining";
            this.grpTraining.Size = new System.Drawing.Size(153, 174);
            this.grpTraining.TabIndex = 10;
            this.grpTraining.TabStop = false;
            this.grpTraining.Text = "Kohonen Training";
            // 
            // chkShowVisualization
            // 
            this.chkShowVisualization.AutoSize = true;
            this.chkShowVisualization.Checked = true;
            this.chkShowVisualization.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowVisualization.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowVisualization.Location = new System.Drawing.Point(22, 50);
            this.chkShowVisualization.Name = "chkShowVisualization";
            this.chkShowVisualization.Size = new System.Drawing.Size(114, 17);
            this.chkShowVisualization.TabIndex = 10;
            this.chkShowVisualization.Text = "Show Visualization";
            this.chkShowVisualization.UseVisualStyleBackColor = true;
            this.chkShowVisualization.CheckedChanged += new System.EventHandler(this.ToggleVisualization);
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(11, 106);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(133, 26);
            this.btnSolve.TabIndex = 9;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.Solve);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(11, 138);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(133, 26);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.StopTraining);
            // 
            // txtCycles
            // 
            this.txtCycles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCycles.Location = new System.Drawing.Point(93, 21);
            this.txtCycles.Name = "txtCycles";
            this.txtCycles.Size = new System.Drawing.Size(51, 20);
            this.txtCycles.TabIndex = 6;
            this.txtCycles.Text = "1000";
            this.txtCycles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trainingProgressBar
            // 
            this.trainingProgressBar.Location = new System.Drawing.Point(11, 77);
            this.trainingProgressBar.Name = "trainingProgressBar";
            this.trainingProgressBar.Size = new System.Drawing.Size(133, 23);
            this.trainingProgressBar.TabIndex = 7;
            this.trainingProgressBar.Value = 100;
            // 
            // lblTrainingCycles
            // 
            this.lblTrainingCycles.AutoSize = true;
            this.lblTrainingCycles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainingCycles.Location = new System.Drawing.Point(8, 24);
            this.lblTrainingCycles.Name = "lblTrainingCycles";
            this.lblTrainingCycles.Size = new System.Drawing.Size(79, 13);
            this.lblTrainingCycles.TabIndex = 5;
            this.lblTrainingCycles.Text = "Training Cycles";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 526);
            this.Controls.Add(this.grpTraining);
            this.Controls.Add(this.grpSales);
            this.Controls.Add(this.citiesGraph);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Travelling Salesman Problem";
            this.Load += new System.EventHandler(this.LoadForm);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormClosing);
            this.grpSales.ResumeLayout(false);
            this.grpSales.PerformLayout();
            this.grpTraining.ResumeLayout(false);
            this.grpTraining.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ZedGraph.ZedGraphControl citiesGraph;
        private System.Windows.Forms.GroupBox grpSales;
        private System.Windows.Forms.TextBox txtCities;
        private System.Windows.Forms.Label lblCities;
        private System.Windows.Forms.GroupBox grpTraining;
        private System.Windows.Forms.TextBox txtCycles;
        private System.Windows.Forms.Label lblTrainingCycles;
        private System.Windows.Forms.ProgressBar trainingProgressBar;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnRandomize;
        private System.Windows.Forms.CheckBox chkShowVisualization;
    }
}

