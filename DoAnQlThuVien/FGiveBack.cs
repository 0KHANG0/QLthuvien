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
    public partial class FGiveBack : Form
    {
        public FGiveBack()
        {
            InitializeComponent();
            mtxtNgayTra.Text = DateTime.Now.ToString();
        }

        private void mtxtNgayTra_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mtxtNgayTra.ReadOnly = true;
        }
    }
}
