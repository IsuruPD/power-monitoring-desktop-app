using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSPTest
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            btnDashUpload.ForeColor = Color.Black;

            lblDashTitle.Parent = panelBackground;
            lblDashTitle.BackColor = Color.Transparent;
            btnDashClose.ForeColor = Color.Transparent;
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            btnDashClose.Cursor = Cursors.Hand;
            btnDashUpload.Cursor = Cursors.Hand;

            btnDashClose.MouseEnter += new EventHandler(btnDashClose_MouseEnter);
            btnDashClose.MouseLeave += new EventHandler(btnDashClose_MouseLeave);


            btnDashUpload.MouseEnter += new EventHandler(btnDashUpload_MouseEnter);
            btnDashUpload.MouseLeave += new EventHandler(btnDashUpload_MouseLeave);
        }

        private void btnDashClose_MouseEnter(object sender, EventArgs e)
        {
            btnDashClose.Size = new Size(btnDashClose.Width + 2, btnDashClose.Height + 2);
            btnDashClose.Location = new Point(btnDashClose.Location.X - 1, btnDashClose.Location.Y - 1);
        }

        private void btnDashClose_MouseLeave(object sender, EventArgs e)
        {
            btnDashClose.Size = new Size(btnDashClose.Width - 2, btnDashClose.Height - 2);
            btnDashClose.Location = new Point(btnDashClose.Location.X + 1, btnDashClose.Location.Y + 1);
        }

        private void btnDashUpload_MouseEnter(object sender, EventArgs e)
        {
            int grow = 8;
            btnDashUpload.ForeColor = Color.White;
            btnDashUpload.Size = new Size(btnDashUpload.Width + grow, btnDashUpload.Height + grow);
            btnDashUpload.Location = new Point(btnDashUpload.Location.X - grow / 2, btnDashUpload.Location.Y - grow / 2);
        }

        private void btnDashUpload_MouseLeave(object sender, EventArgs e)
        {
            int shrink = 8;
            btnDashUpload.ForeColor = Color.Black;
            btnDashUpload.Size = new Size(btnDashUpload.Width - shrink, btnDashUpload.Height - shrink);
            btnDashUpload.Location = new Point(btnDashUpload.Location.X + shrink / 2, btnDashUpload.Location.Y + shrink / 2);
        }


        private void btnDashClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDashClose_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnDashUpload_Click(object sender, EventArgs e)
        {
            frmFileImporter frmFileImporter = new frmFileImporter();
            frmFileImporter.Show();
        }

        private void panelBackground_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
