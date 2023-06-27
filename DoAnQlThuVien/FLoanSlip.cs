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
    public partial class FLoanSlip : Form
    {
        public FLoanSlip()
        {
            InitializeComponent();
            mtxtNgayMuon.Text = DateTime.Now.ToString();
            mtxtNgayTra.Text = DateTime.Now.AddDays(+10).ToString();
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mtxtNgayMuon_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mtxtNgayMuon.ReadOnly = true;
        }
    }
}
