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
            btnDashClose = new PictureBox();
            panelBackground = new Panel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)btnDashClose).BeginInit();
            panelBackground.SuspendLayout();
            panel1.SuspendLayout();
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
            lblDashTitle.Size = new Size(353, 40);
            lblDashTitle.TabIndex = 0;
            lblDashTitle.Text = "Consumer Data Uploader";
            lblDashTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDashUpload
            // 
            btnDashUpload.BackgroundImage = (Image)resources.GetObject("btnDashUpload.BackgroundImage");
            btnDashUpload.BackgroundImageLayout = ImageLayout.Zoom;
            btnDashUpload.FlatAppearance.BorderSize = 0;
            btnDashUpload.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashUpload.ForeColor = Color.White;
            btnDashUpload.Location = new Point(-81, -28);
            btnDashUpload.Name = "btnDashUpload";
            btnDashUpload.Size = new Size(574, 704);
            btnDashUpload.TabIndex = 1;
            btnDashUpload.Text = "Add Records";
            btnDashUpload.UseVisualStyleBackColor = true;
            btnDashUpload.Click += btnDashUpload_Click;
            // 
            // btnDashClose
            // 
            btnDashClose.BackColor = Color.Transparent;
            btnDashClose.BackgroundImageLayout = ImageLayout.Center;
            btnDashClose.Image = (Image)resources.GetObject("btnDashClose.Image");
            btnDashClose.Location = new Point(20, 15);
            btnDashClose.Name = "btnDashClose";
            btnDashClose.Size = new Size(36, 33);
            btnDashClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnDashClose.TabIndex = 3;
            btnDashClose.TabStop = false;
            btnDashClose.Click += btnDashClose_Click;
            btnDashClose.MouseHover += btnDashClose_MouseHover;
            // 
            // panelBackground
            // 
            panelBackground.BackgroundImage = (Image)resources.GetObject("panelBackground.BackgroundImage");
            panelBackground.BackgroundImageLayout = ImageLayout.Stretch;
            panelBackground.Controls.Add(btnDashClose);
            panelBackground.Location = new Point(-8, -3);
            panelBackground.Name = "panelBackground";
            panelBackground.Size = new Size(816, 664);
            panelBackground.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDashUpload);
            panel1.Location = new Point(803, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(432, 664);
            panel1.TabIndex = 5;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 649);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(lblDashTitle);
            Controls.Add(panelBackground);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += frmDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)btnDashClose).EndInit();
            panelBackground.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDashTitle;
        private Button btnDashUpload;
        private PictureBox btnDashClose;
        private Panel panelBackground;
        private Panel panel1;
    }
}