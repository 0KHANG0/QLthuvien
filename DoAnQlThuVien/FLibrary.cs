using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace DoAnQlThuVien
{
    public partial class FLibrary : Form
    {
        public FLibrary()
        {
            InitializeComponent();
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            FLoanSlip fLoan = new FLoanSlip();
            fLoan.ShowDialog();
        }

        private void btnGiveBack_Click(object sender, EventArgs e)
        { 
            FGiveBack fgive = new FGiveBack();
            fgive.ShowDialog();
        }
    }
}
