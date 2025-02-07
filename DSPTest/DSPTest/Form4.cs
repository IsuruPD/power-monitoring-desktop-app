using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DSPTest
{
    public partial class frmAnalyzer2 : Form
    {
        public frmAnalyzer2()
        {
            InitializeComponent();
            FetchData();
            TestPlotter();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void FetchData()
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=DSPTest;Integrated Security=True;";
            string query = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'tbl_customer_usage' AND COLUMN_NAME <> 'Time'";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        cmbBxCustomers.Items.Clear();

                        while (reader.Read())
                        {
                            cmbBxCustomers.Items.Add(reader["COLUMN_NAME"].ToString());
                        }
                    }
                }

                //cmbBxCustomers.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                //cmbBxCustomers.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Failed to load data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpldBack_Click(object sender, EventArgs e)
        {
            frmDashboard frmDashboard = new frmDashboard();
            frmDashboard.Show();
            this.Close();
        }

        private void btnCnsSearch_Click(object sender, EventArgs e)
        {
            if (cmbBxCustomers.SelectedIndex == -1)
            {
                MessageBox.Show("Select a customer first");
            }
            else
            {
                TestPlotter();
            }

        }

        private void TestPlotter()
        {
            try
            {
                // Clear existing series
                chart1.Series.Clear();

                // Create a new series for the test data
                var series = new System.Windows.Forms.DataVisualization.Charting.Series
                {
                    Name = "TestData",
                    IsVisibleInLegend = true,
                    ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
                };

                // Add sample data points
                series.Points.AddXY("08:00", 10);
                series.Points.AddXY("09:00", 15);
                series.Points.AddXY("10:00", 7);
                series.Points.AddXY("11:00", 12);
                series.Points.AddXY("12:00", 20);
                series.Points.AddXY("13:00", 8);

                // Add the series to the chart
                chart1.Series.Add(series);

                // Format the axes
                chart1.ChartAreas[0].AxisX.Title = "Time (Hours)";
                chart1.ChartAreas[0].AxisY.Title = "Power Consumption (kWh)";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Failed to plot test data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnUpldBack_Click_1(object sender, EventArgs e)
        {
            frmDashboard frmDashboard = new frmDashboard();
            frmDashboard.Show();
            this.Close();
        }

        private void btnCnsSearch_Click_1(object sender, EventArgs e)
        {

        }
    }
}
