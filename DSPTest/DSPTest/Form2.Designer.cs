namespace DSPTest
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            lblDashTitle = new Label();
            btnDashUpload = new Button();
            btnDashUsage = new Button();
            pictureBox1 = new PictureBox();
            btnDashClose = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnDashClose).BeginInit();
            SuspendLayout();
            // 
            // lblDashTitle
            // 
            lblDashTitle.AutoSize = true;
            lblDashTitle.BackColor = Color.Transparent;
            lblDashTitle.FlatStyle = FlatStyle.Flat;
            lblDashTitle.Font = new Font("Segoe UI Emoji", 18F);
            lblDashTitle.ForeColor = Color.MidnightBlue;
            lblDashTitle.Location = new Point(261, 16);
            lblDashTitle.Name = "lblDashTitle";
            lblDashTitle.Size = new Size(343, 40);
            lblDashTitle.TabIndex = 0;
            lblDashTitle.Text = "Consumer Data Analyzer";
            lblDashTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDashUpload
            // 
            btnDashUpload.BackgroundImage = (Image)resources.GetObject("btnDashUpload.BackgroundImage");
            btnDashUpload.BackgroundImageLayout = ImageLayout.Stretch;
            btnDashUpload.FlatAppearance.BorderSize = 0;
            btnDashUpload.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnDashUpload.ForeColor = Color.Indigo;
            btnDashUpload.Location = new Point(878, 126);
            btnDashUpload.Name = "btnDashUpload";
            btnDashUpload.Size = new Size(329, 199);
            btnDashUpload.TabIndex = 1;
            btnDashUpload.Text = "Upload Records";
            btnDashUpload.TextAlign = ContentAlignment.BottomCenter;
            btnDashUpload.UseVisualStyleBackColor = true;
            btnDashUpload.Click += btnDashUpload_Click;
            // 
            // btnDashUsage
            // 
            btnDashUsage.BackgroundImage = (Image)resources.GetObject("btnDashUsage.BackgroundImage");
            btnDashUsage.BackgroundImageLayout = ImageLayout.Stretch;
            btnDashUsage.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnDashUsage.ForeColor = Color.Indigo;
            btnDashUsage.Location = new Point(876, 402);
            btnDashUsage.Name = "btnDashUsage";
            btnDashUsage.Size = new Size(329, 199);
            btnDashUsage.TabIndex = 1;
            btnDashUsage.Text = "Check Usage";
            btnDashUsage.TextAlign = ContentAlignment.BottomCenter;
            btnDashUsage.UseVisualStyleBackColor = true;
            btnDashUsage.Click += btnDashUsage_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-6, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(876, 670);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnDashClose
            // 
            btnDashClose.BackColor = Color.Transparent;
            btnDashClose.BackgroundImageLayout = ImageLayout.Center;
            btnDashClose.Image = (Image)resources.GetObject("btnDashClose.Image");
            btnDashClose.Location = new Point(1171, 16);
            btnDashClose.Name = "btnDashClose";
            btnDashClose.Size = new Size(36, 33);
            btnDashClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnDashClose.TabIndex = 3;
            btnDashClose.TabStop = false;
            btnDashClose.Click += btnDashClose_Click;
            btnDashClose.MouseHover += btnDashClose_MouseHover;
            // 
            // button1
            // 
            button1.Location = new Point(995, 66);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 649);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(btnDashClose);
            Controls.Add(lblDashTitle);
            Controls.Add(pictureBox1);
            Controls.Add(btnDashUsage);
            Controls.Add(btnDashUpload);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += frmDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnDashClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDashTitle;
        private Button btnDashUpload;
        private Button btnDashUsage;
        private PictureBox pictureBox1;
        private PictureBox btnDashClose;
        private Button button1;
    }
}