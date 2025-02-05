namespace DSPTest
{
    partial class FileImporter
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnImport = new Button();
            lblImportCSV = new Label();
            lblTitle = new Label();
            lblFilePath = new Label();
            btnUpload = new Button();
            SuspendLayout();
            // 
            // btnImport
            // 
            btnImport.Location = new Point(334, 106);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(94, 29);
            btnImport.TabIndex = 0;
            btnImport.Text = "Browse";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // lblImportCSV
            // 
            lblImportCSV.AutoSize = true;
            lblImportCSV.FlatStyle = FlatStyle.Flat;
            lblImportCSV.Location = new Point(135, 110);
            lblImportCSV.Name = "lblImportCSV";
            lblImportCSV.Size = new Size(115, 20);
            lblImportCSV.TabIndex = 1;
            lblImportCSV.Text = "Import CSV files";
            lblImportCSV.Click += label1_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Forte", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(195, 36);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(188, 32);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "File Importer";
            // 
            // lblFilePath
            // 
            lblFilePath.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblFilePath.AutoSize = true;
            lblFilePath.Location = new Point(50, 212);
            lblFilePath.Name = "lblFilePath";
            lblFilePath.Size = new Size(0, 20);
            lblFilePath.TabIndex = 3;
            lblFilePath.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(462, 207);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(94, 29);
            btnUpload.TabIndex = 4;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // FileImporter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 249);
            Controls.Add(btnUpload);
            Controls.Add(lblFilePath);
            Controls.Add(lblTitle);
            Controls.Add(lblImportCSV);
            Controls.Add(btnImport);
            Name = "FileImporter";
            Text = "Import Files";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnImport;
        private Label lblImportCSV;
        private Label lblTitle;
        private Label lblFilePath;
        private Button btnUpload;
    }
}
