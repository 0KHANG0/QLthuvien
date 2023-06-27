using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQlThuVien
{
    public partial class FDel : Form
    {
        SqlConnection connectDB;
        public FDel()
        {
            InitializeComponent();
            connectDB = new SqlConnection("Data Source=VUNGUYEN;Initial Catalog=QLTV;Integrated Security=True");
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaSach_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAcc_Click(object sender, EventArgs e)
        {
            try
            {
                if (connectDB.State == ConnectionState.Closed)
                {
                    connectDB.Open();
                }
                string deletestr = "delete Sach where [Mã sách]='" + txtMaSach.Text + "'";
                SqlCommand cmd = new SqlCommand(deletestr, connectDB);
                cmd.ExecuteNonQuery();
                if (connectDB.State == ConnectionState.Open)
                {
                    connectDB.Close();
                }
                MessageBox.Show("Thanh cong");
                txtMaSach.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show("That bai");
            }
        }
    }
}
