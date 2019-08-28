using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PawProject
{
    public partial class BarChartStats : Form
    {
        public BarChartStats(int m, int mSal, int f, int fSal)
        {
            InitializeComponent();

            chart.Series["Men"].Points.AddXY(1, mSal / m);
            chart.Series["Men"].ChartType = SeriesChartType.Column;
            chart.Series["Men"].Color = Color.Blue;

            chart.Series["Women"].Points.AddXY(1, fSal / f);
            chart.Series["Women"].ChartType = SeriesChartType.Column;
            chart.Series["Women"].Color = Color.DeepPink;

            tbEmployees.Text += "Total: " + (m + f) + " (" + m + " men / " + f + " women)";
            tbMen.Text += mSal / m;
            tbWomen.Text += fSal / f;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BarChartStats_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.B)
            {
                this.btnBack.PerformClick();
            }
        }
    }
}
