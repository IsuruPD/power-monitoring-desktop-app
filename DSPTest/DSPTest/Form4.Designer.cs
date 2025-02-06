namespace DSPTest
{
    partial class frmAnalyzer2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnalyzer2));
            btnCnsSearch = new Button();
            lblTitle = new Label();
            lblAnlzrCustomer = new Label();
            cmbBxCustomers = new ComboBox();
            btnUpldBack = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnUpldBack).BeginInit();
            SuspendLayout();
            // 
            // btnCnsSearch
            // 
            btnCnsSearch.Location = new Point(441, 109);
            btnCnsSearch.Name = "btnCnsSearch";
            btnCnsSearch.Size = new Size(94, 29);
            btnCnsSearch.TabIndex = 17;
            btnCnsSearch.Text = "Search";
            btnCnsSearch.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Forte", 18F, FontStyle.Italic);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.ImeMode = ImeMode.NoControl;
            lblTitle.Location = new Point(547, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(244, 32);
            lblTitle.TabIndex = 16;
            lblTitle.Text = "User Consumption";
            // 
            // lblAnlzrCustomer
            // 
            lblAnlzrCustomer.AutoSize = true;
            lblAnlzrCustomer.Location = new Point(21, 113);
            lblAnlzrCustomer.Name = "lblAnlzrCustomer";
            lblAnlzrCustomer.Size = new Size(82, 20);
            lblAnlzrCustomer.TabIndex = 15;
            lblAnlzrCustomer.Text = "Select User";
            // 
            // cmbBxCustomers
            // 
            cmbBxCustomers.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbBxCustomers.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbBxCustomers.FormattingEnabled = true;
            cmbBxCustomers.Location = new Point(128, 110);
            cmbBxCustomers.Name = "cmbBxCustomers";
            cmbBxCustomers.Size = new Size(274, 28);
            cmbBxCustomers.TabIndex = 14;
            // 
            // btnUpldBack
            // 
            btnUpldBack.Image = (Image)resources.GetObject("btnUpldBack.Image");
            btnUpldBack.ImeMode = ImeMode.NoControl;
            btnUpldBack.Location = new Point(1342, 22);
            btnUpldBack.Name = "btnUpldBack";
            btnUpldBack.Size = new Size(25, 25);
            btnUpldBack.SizeMode = PictureBoxSizeMode.Zoom;
            btnUpldBack.TabIndex = 18;
            btnUpldBack.TabStop = false;
            btnUpldBack.Click += btnUpldBack_Click_1;
            // 
            // frmAnalyzer2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1379, 616);
            Controls.Add(btnUpldBack);
            Controls.Add(btnCnsSearch);
            Controls.Add(lblTitle);
            Controls.Add(lblAnlzrCustomer);
            Controls.Add(cmbBxCustomers);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAnalyzer2";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)btnUpldBack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCnsSearch;
        private Label lblTitle;
        private Label lblAnlzrCustomer;
        private ComboBox cmbBxCustomers;

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private PictureBox btnUpldBack;
    }
}