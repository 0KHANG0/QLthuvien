using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQlThuVien
{
    public partial class FUser : Form
    {
        public FUser()
        {
            InitializeComponent();
        }
        private Form currentFormChild;

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Panel_body.Controls.Add(childForm);
            Panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnLibrary_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FLibrary());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FAdmin());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FQLPhieuMuon());
        }

        private void btnKhoSach_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FKho());
        }
    }
}
