namespace DSPTest
{
    partial class frmFileImporter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFileImporter));
            btnImport = new Button();
            lblImportCSV = new Label();
            lblTitle = new Label();
            lblFilePath = new Label();
            btnUpload = new Button();
            btnUpldBack = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnUpldBack).BeginInit();
            SuspendLayout();
            // 
            // btnImport
            // 
            resources.ApplyResources(btnImport, "btnImport");
            btnImport.Name = "btnImport";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // lblImportCSV
            // 
            resources.ApplyResources(lblImportCSV, "lblImportCSV");
            lblImportCSV.FlatStyle = FlatStyle.Flat;
            lblImportCSV.Name = "lblImportCSV";
            lblImportCSV.Click += label1_Click;
            // 
            // lblTitle
            // 
            resources.ApplyResources(lblTitle, "lblTitle");
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Name = "lblTitle";
            // 
            // lblFilePath
            // 
            resources.ApplyResources(lblFilePath, "lblFilePath");
            lblFilePath.Name = "lblFilePath";
            // 
            // btnUpload
            // 
            resources.ApplyResources(btnUpload, "btnUpload");
            btnUpload.Name = "btnUpload";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // btnUpldBack
            // 
            resources.ApplyResources(btnUpldBack, "btnUpldBack");
            btnUpldBack.Name = "btnUpldBack";
            btnUpldBack.TabStop = false;
            btnUpldBack.Click += btnUpldBack_Click;
            // 
            // frmFileImporter
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ControlBox = false;
            Controls.Add(btnUpldBack);
            Controls.Add(btnUpload);
            Controls.Add(lblFilePath);
            Controls.Add(lblTitle);
            Controls.Add(lblImportCSV);
            Controls.Add(btnImport);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmFileImporter";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)btnUpldBack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnImport;
        private Label lblImportCSV;
        private Label lblTitle;
        private Label lblFilePath;
        private Button btnUpload;
        private PictureBox btnUpldBack;
    }
}
