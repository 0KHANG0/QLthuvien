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
    public partial class FEdit : Form
    {
        SqlConnection connectDB;
        public FEdit()
        {
            InitializeComponent();
            connectDB = new SqlConnection("Data Source=VUNGUYEN;Initial Catalog=QLTV;Integrated Security=True");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (connectDB.State == ConnectionState.Closed)
                {
                    connectDB.Open();
                }
                string editstr = "update Sach set [Tình trạng sách]='" + txtSoLuong.Text + "' where [Mã sách]='" + txtMaSach.Text + "'";
                SqlCommand cmd = new SqlCommand(editstr, connectDB);
                cmd.ExecuteNonQuery();
                if (connectDB.State == ConnectionState.Open)
                {
                    connectDB.Close();
                }
                MessageBox.Show("Thanh cong");
                txtMaSach.Clear();
                txtSoLuong.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("That bai");
            }
        }
    }
}
