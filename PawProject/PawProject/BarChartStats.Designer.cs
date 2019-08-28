namespace PawProject
{
    partial class BarChartStats
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarChartStats));
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnBack = new System.Windows.Forms.Button();
            this.labelLetters = new System.Windows.Forms.Label();
            this.tbEmployees = new System.Windows.Forms.TextBox();
            this.labelEmployees = new System.Windows.Forms.Label();
            this.tbMen = new System.Windows.Forms.TextBox();
            this.tbWomen = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(17, 39);
            this.chart.Margin = new System.Windows.Forms.Padding(4);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Men";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Women";
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(428, 342);
            this.chart.TabIndex = 0;
            this.chart.Text = "Stats";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Location = new System.Drawing.Point(315, 320);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 28);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // labelLetters
            // 
            this.labelLetters.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelLetters.AutoSize = true;
            this.labelLetters.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelLetters.Location = new System.Drawing.Point(84, 39);
            this.labelLetters.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLetters.Name = "labelLetters";
            this.labelLetters.Size = new System.Drawing.Size(219, 17);
            this.labelLetters.TabIndex = 2;
            this.labelLetters.Text = "Average salary based on gender:";
            this.labelLetters.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbEmployees
            // 
            this.tbEmployees.BackColor = System.Drawing.SystemColors.Control;
            this.tbEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEmployees.Location = new System.Drawing.Point(171, 11);
            this.tbEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmployees.Name = "tbEmployees";
            this.tbEmployees.ReadOnly = true;
            this.tbEmployees.Size = new System.Drawing.Size(191, 15);
            this.tbEmployees.TabIndex = 3;
            // 
            // labelEmployees
            // 
            this.labelEmployees.AutoSize = true;
            this.labelEmployees.BackColor = System.Drawing.Color.Transparent;
            this.labelEmployees.Location = new System.Drawing.Point(13, 11);
            this.labelEmployees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmployees.Name = "labelEmployees";
            this.labelEmployees.Size = new System.Drawing.Size(150, 17);
            this.labelEmployees.TabIndex = 4;
            this.labelEmployees.Text = "Number of employees:";
            // 
            // tbMen
            // 
            this.tbMen.BackColor = System.Drawing.Color.Blue;
            this.tbMen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbMen.Location = new System.Drawing.Point(154, 306);
            this.tbMen.Margin = new System.Windows.Forms.Padding(4);
            this.tbMen.Name = "tbMen";
            this.tbMen.Size = new System.Drawing.Size(31, 15);
            this.tbMen.TabIndex = 5;
            // 
            // tbWomen
            // 
            this.tbWomen.BackColor = System.Drawing.Color.DeepPink;
            this.tbWomen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbWomen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbWomen.Location = new System.Drawing.Point(193, 306);
            this.tbWomen.Margin = new System.Windows.Forms.Padding(4);
            this.tbWomen.Name = "tbWomen";
            this.tbWomen.Size = new System.Drawing.Size(31, 15);
            this.tbWomen.TabIndex = 6;
            // 
            // BarChartStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 396);
            this.Controls.Add(this.tbWomen);
            this.Controls.Add(this.tbMen);
            this.Controls.Add(this.labelEmployees);
            this.Controls.Add(this.tbEmployees);
            this.Controls.Add(this.labelLetters);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.chart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BarChartStats";
            this.Text = "Statistics";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BarChartStats_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label labelLetters;
        private System.Windows.Forms.TextBox tbEmployees;
        private System.Windows.Forms.Label labelEmployees;
        private System.Windows.Forms.TextBox tbMen;
        private System.Windows.Forms.TextBox tbWomen;

    }
}