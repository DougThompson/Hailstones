namespace Hailstones
{
	partial class frmMain
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbxOut = new System.Windows.Forms.TextBox();
			this.btnCalc = new System.Windows.Forms.Button();
			this.tbxStart = new System.Windows.Forms.TextBox();
			this.tbxEnd = new System.Windows.Forms.TextBox();
			this.chtResults = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.tbxMaxValue = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.ddlPlotType = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.lblProgress = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.chtResults)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(437, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Start";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(437, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(26, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "End";
			// 
			// tbxOut
			// 
			this.tbxOut.Location = new System.Drawing.Point(12, 12);
			this.tbxOut.Multiline = true;
			this.tbxOut.Name = "tbxOut";
			this.tbxOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbxOut.Size = new System.Drawing.Size(411, 212);
			this.tbxOut.TabIndex = 4;
			// 
			// btnCalc
			// 
			this.btnCalc.Location = new System.Drawing.Point(440, 102);
			this.btnCalc.Name = "btnCalc";
			this.btnCalc.Size = new System.Drawing.Size(75, 23);
			this.btnCalc.TabIndex = 5;
			this.btnCalc.Text = "Calculate";
			this.btnCalc.UseVisualStyleBackColor = true;
			this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
			// 
			// tbxStart
			// 
			this.tbxStart.Location = new System.Drawing.Point(440, 33);
			this.tbxStart.Name = "tbxStart";
			this.tbxStart.Size = new System.Drawing.Size(100, 20);
			this.tbxStart.TabIndex = 6;
			this.tbxStart.Text = "1";
			this.tbxStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericKeyPress);
			this.tbxStart.Leave += new System.EventHandler(this.startOrEnd_Leave);
			// 
			// tbxEnd
			// 
			this.tbxEnd.Location = new System.Drawing.Point(440, 76);
			this.tbxEnd.Name = "tbxEnd";
			this.tbxEnd.Size = new System.Drawing.Size(100, 20);
			this.tbxEnd.TabIndex = 7;
			this.tbxEnd.Text = "2000";
			this.tbxEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericKeyPress);
			this.tbxEnd.Leave += new System.EventHandler(this.startOrEnd_Leave);
			// 
			// chtResults
			// 
			this.chtResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.chtResults.BorderlineColor = System.Drawing.Color.DimGray;
			this.chtResults.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			chartArea1.Name = "ChartArea1";
			this.chtResults.ChartAreas.Add(chartArea1);
			this.chtResults.Location = new System.Drawing.Point(12, 230);
			this.chtResults.Name = "chtResults";
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
			series1.MarkerSize = 3;
			series1.Name = "Series1";
			this.chtResults.Series.Add(series1);
			this.chtResults.Size = new System.Drawing.Size(966, 526);
			this.chtResults.TabIndex = 8;
			// 
			// tbxMaxValue
			// 
			this.tbxMaxValue.Location = new System.Drawing.Point(440, 155);
			this.tbxMaxValue.Name = "tbxMaxValue";
			this.tbxMaxValue.Size = new System.Drawing.Size(100, 20);
			this.tbxMaxValue.TabIndex = 10;
			this.tbxMaxValue.Text = "20000";
			this.tbxMaxValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericKeyPress);
			this.tbxMaxValue.Leave += new System.EventHandler(this.tbxMaxValue_Leave);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(437, 139);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(172, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "Max value to plot (-1 to ignore max)";
			// 
			// ddlPlotType
			// 
			this.ddlPlotType.FormattingEnabled = true;
			this.ddlPlotType.Items.AddRange(new object[] {
            "N vs Max Value",
            "N vs Trips"});
			this.ddlPlotType.Location = new System.Drawing.Point(440, 200);
			this.ddlPlotType.Name = "ddlPlotType";
			this.ddlPlotType.Size = new System.Drawing.Size(129, 21);
			this.ddlPlotType.TabIndex = 11;
			this.ddlPlotType.SelectedIndexChanged += new System.EventHandler(this.ddlPlotType_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(437, 179);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 13);
			this.label4.TabIndex = 12;
			this.label4.Text = "Plot Type";
			// 
			// lblProgress
			// 
			this.lblProgress.AutoSize = true;
			this.lblProgress.Location = new System.Drawing.Point(587, 203);
			this.lblProgress.Name = "lblProgress";
			this.lblProgress.Size = new System.Drawing.Size(0, 13);
			this.lblProgress.TabIndex = 13;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(990, 768);
			this.Controls.Add(this.lblProgress);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.ddlPlotType);
			this.Controls.Add(this.tbxMaxValue);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.chtResults);
			this.Controls.Add(this.tbxEnd);
			this.Controls.Add(this.tbxStart);
			this.Controls.Add(this.btnCalc);
			this.Controls.Add(this.tbxOut);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "3n+1 - Hailstone Sequence";
			((System.ComponentModel.ISupportInitialize)(this.chtResults)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbxOut;
		private System.Windows.Forms.Button btnCalc;
		private System.Windows.Forms.TextBox tbxStart;
		private System.Windows.Forms.TextBox tbxEnd;
		private System.Windows.Forms.DataVisualization.Charting.Chart chtResults;
		private System.Windows.Forms.TextBox tbxMaxValue;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox ddlPlotType;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblProgress;
	}
}

