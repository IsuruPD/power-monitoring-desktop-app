namespace DSPTest
{
    partial class frmAnalyzer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnalyzer));
            btnUpldBack = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            cmbBxCustomers = new ComboBox();
            lblAnlzrCustomer = new Label();
            lblTitle = new Label();
            btnCnsSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)btnUpldBack).BeginInit();
            SuspendLayout();
            // 
            // btnUpldBack
            // 
            btnUpldBack.Image = (Image)resources.GetObject("btnUpldBack.Image");
            btnUpldBack.ImeMode = ImeMode.NoControl;
            btnUpldBack.Location = new Point(1387, 12);
            btnUpldBack.Name = "btnUpldBack";
            btnUpldBack.Size = new Size(25, 25);
            btnUpldBack.SizeMode = PictureBoxSizeMode.Zoom;
            btnUpldBack.TabIndex = 6;
            btnUpldBack.TabStop = false;
            btnUpldBack.Click += btnUpldBack_Click;
            // 
            // cmbBxCustomers
            // 
            cmbBxCustomers.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbBxCustomers.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbBxCustomers.FormattingEnabled = true;
            cmbBxCustomers.Location = new Point(190, 120);
            cmbBxCustomers.Name = "cmbBxCustomers";
            cmbBxCustomers.Size = new Size(274, 28);
            cmbBxCustomers.TabIndex = 8;
            // 
            // lblAnlzrCustomer
            // 
            lblAnlzrCustomer.AutoSize = true;
            lblAnlzrCustomer.Location = new Point(83, 123);
            lblAnlzrCustomer.Name = "lblAnlzrCustomer";
            lblAnlzrCustomer.Size = new Size(82, 20);
            lblAnlzrCustomer.TabIndex = 9;
            lblAnlzrCustomer.Text = "Select User";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Forte", 18F, FontStyle.Italic);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.ImeMode = ImeMode.NoControl;
            lblTitle.Location = new Point(609, 32);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(244, 32);
            lblTitle.TabIndex = 12;
            lblTitle.Text = "User Consumption";
            // 
            // btnCnsSearch
            // 
            btnCnsSearch.Location = new Point(503, 119);
            btnCnsSearch.Name = "btnCnsSearch";
            btnCnsSearch.Size = new Size(94, 29);
            btnCnsSearch.TabIndex = 13;
            btnCnsSearch.Text = "Search";
            btnCnsSearch.UseVisualStyleBackColor = true;
            btnCnsSearch.Click += btnCnsSearch_Click;
            // 
            // frmAnalyzer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1424, 706);
            Controls.Add(btnCnsSearch);
            Controls.Add(lblTitle);
            Controls.Add(lblAnlzrCustomer);
            Controls.Add(cmbBxCustomers);
            Controls.Add(btnUpldBack);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAnalyzer";
            Text = "Form3";
            Load += frmAnalyzer_Load;
            ((System.ComponentModel.ISupportInitialize)btnUpldBack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btnUpldBack;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox cmbBxCustomers;
        private Label lblAnlzrCustomer;
        private Label lblTitle;
        private Button btnCnsSearch;
    }
}