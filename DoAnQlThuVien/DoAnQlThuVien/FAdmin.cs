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
    public partial class FAdmin : Form
    {
        SqlConnection conn;
        string strConnect = "Data Source=VUNGUYEN;Initial Catalog=QLTV;Integrated Security=True";
        public FAdmin()
        {
            InitializeComponent();
            tbNgayDK.Text = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();

            conn = new SqlConnection(strConnect);
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mtxtAccout_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            tbNgayDK.ReadOnly= true;
        }

        private void btDangKy_Click(object sender, EventArgs e)
        {
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string tmpDate = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
            string query = "insert into DocGia values('"+txtMaDG.Text+"','"+txtHoTen.Text+"','"+tmpDate+"')";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            lvUser.Items.Clear();
            if(conn.State==ConnectionState.Closed)
                conn.Open();
            SqlCommand cmd = new SqlCommand("select * from DocGia", conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            int i = 0;
            while (rdr.Read())
            {
                ++i;
                DateTime tmp = rdr.GetDateTime(2);
                ListViewItem items = new ListViewItem(new[] { rdr["Mã bạn đọc"].ToString(), rdr["Họ Tên"].ToString(), tmp.Day.ToString()+"/"+tmp.Month.ToString()+"/"+tmp.Year.ToString() });
                lvUser.Items.Add(items);
                txtMaDG.Text = "DG"+(i + 1).ToString();
            }
            rdr.Close();

            if (conn.State == ConnectionState.Open)
                conn.Close();
        }
    }
}
