using System.Data;
using System.Data.SqlClient;

namespace DSPTest
{
    public partial class FileImporter : Form
    {
        private string selectedFilePath = "";

        public FileImporter()
        {
            InitializeComponent();
            btnUpload.Enabled = false;
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

            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=DSPTest;Integrated Security=True;";

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
                            string paramList = string.Join(", ", columnNames.Select(name => $"@{name}"));

                            string query = $"INSERT INTO tbl_customer_usage ({columnList}) VALUES ({paramList})";

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
    }
}
