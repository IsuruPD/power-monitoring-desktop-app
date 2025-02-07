using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DSPTest
{
    public partial class TestChart : Form
    {
        public TestChart()
        {
            InitializeComponent();
            TestPlotter();
        }

        private void TestPlotter()
        {
            try
            {
                chart1.Series.Clear(); // Clear old data

                if (chart1.ChartAreas.Count == 0)
                {
                    chart1.ChartAreas.Add(new ChartArea("Default"));
                }

                Series series = new Series
                {
                    Name = "TestData",
                    IsVisibleInLegend = true,
                    ChartType = SeriesChartType.Line
                };

                series.Points.AddXY("08:00", 10);
                series.Points.AddXY("09:00", 15);
                series.Points.AddXY("10:00", 7);
                series.Points.AddXY("11:00", 12);
                series.Points.AddXY("12:00", 20);
                series.Points.AddXY("13:00", 8);

                chart1.Series.Add(series);

                chart1.ChartAreas[0].AxisX.Title = "Time (Hours)";
                chart1.ChartAreas[0].AxisY.Title = "Power Consumption (kWh)";

                chart1.Invalidate(); // Redraw the chart
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Failed to plot test data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
