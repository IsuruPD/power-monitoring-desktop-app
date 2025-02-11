using System.Data;
using System.Data.SqlClient;

namespace DSPTest
{
    public partial class frmFileImporter : Form
    {
        private string selectedFilePath = "";

        public frmFileImporter()
        {
            InitializeComponent();
            btnUpload.Enabled = false;
            btnUpldBack.Cursor = Cursors.Hand;

            btnUpldBack.MouseEnter += new EventHandler(btnUpldBack_MouseEnter);
            btnUpldBack.MouseLeave += new EventHandler(btnUpldBack_MouseLeave);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Select CSV File",
                Filter = "CSV files (*.csv)|*.csv",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = openFileDialog.FileName;
                lblFilePath.Text = $"Selected File: {selectedFilePath}";
                btnUpload.Enabled = true;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedFilePath))
            {
                MessageBox.Show("Please select a CSV file first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = "Server=DESKTOP-D81M7DI;Database=DSPTest;Integrated Security=True;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        using (StreamReader reader = new StreamReader(selectedFilePath))
                        {
                            string headerLine = reader.ReadLine();
                            string[] columnNames = headerLine.Split(',');

                            string columnList = string.Join(", ", columnNames.Select(name => $"[{name}]"));
                            string dataList = string.Join(", ", columnNames.Select(name => $"@{name}"));

                            string query = $"INSERT INTO tbl_customer_usage ({columnList}) VALUES ({dataList})";

                            using (SqlCommand cmd = new SqlCommand(query, conn, transaction))
                            {
                                while (!reader.EndOfStream)
                                {
                                    string line = reader.ReadLine();
                                    string[] values = line.Split(',');

                                    cmd.Parameters.Clear();

                                    for (int i = 0; i < columnNames.Length; i++)
                                    {
                                        object value = string.IsNullOrWhiteSpace(values[i])
                                            ? (object)DBNull.Value
                                            : (i == 0 ? DateTime.Parse(values[i]) : double.Parse(values[i]));

                                        cmd.Parameters.AddWithValue($"@{columnNames[i]}", value);
                                    }

                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }

                        transaction.Commit();
                    }
                }

                MessageBox.Show("Data uploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnUpload.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Upload Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpldBack_Click(object sender, EventArgs e)
        {
            frmDashboard frmDashboard = new frmDashboard();
            frmDashboard.Show();
            this.Close();
        }

        private void btnUpldBack_MouseEnter(object sender, EventArgs e)
        {
            btnUpldBack.Size = new Size(btnUpldBack.Width + 1, btnUpldBack.Height + 1);
            btnUpldBack.Location = new Point(btnUpldBack.Location.X - 1, btnUpldBack.Location.Y - 1);
        }

        private void btnUpldBack_MouseLeave(object sender, EventArgs e)
        {
            btnUpldBack.Size = new Size(btnUpldBack.Width - 1, btnUpldBack.Height - 1);
            btnUpldBack.Location = new Point(btnUpldBack.Location.X + 1, btnUpldBack.Location.Y + 1);
        }
    }
}
