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
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            btnDashClose.Cursor = Cursors.Hand;
            btnDashUpload.Cursor = Cursors.Hand;
            btnDashUsage.Cursor = Cursors.Hand;

            btnDashClose.MouseEnter += new EventHandler(btnDashClose_MouseEnter);
            btnDashClose.MouseLeave += new EventHandler(btnDashClose_MouseLeave);
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
            this.Hide();
        }

        private void btnDashUsage_Click(object sender, EventArgs e)
        {

        }
    }
}
