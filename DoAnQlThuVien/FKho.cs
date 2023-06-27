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
    public partial class FKho : Form
    {
        public FKho()
        {
            InitializeComponent();
            loadlistview();
        }
        SqlConnection connectDB = new SqlConnection("Data Source=VUNGUYEN;Initial Catalog=QLTV;Integrated Security=True");
        private void btnDel_Click(object sender, EventArgs e)
        {
            FDel f = new FDel();
            f.ShowDialog();
            loadlistview();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ThemSach f = new ThemSach();
            f.ShowDialog();
            loadlistview();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FEdit fEdit= new FEdit();
            fEdit.ShowDialog();
            loadlistview();
        }

        private void lvSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void loadlistview()
        {
            lvSach.Items.Clear();
            if (connectDB.State == ConnectionState.Closed)
            {
                connectDB.Open();
            }
            SqlCommand cmd = new SqlCommand("select * from Sach", connectDB);
            SqlDataReader rdr = cmd.ExecuteReader();
            int i = 0;
            while (rdr.Read())
            {
                ++i;
                DateTime tmp = new DateTime();
                //tmp = rdr["Ngày nhập kho"].ToString();
                tmp = rdr.GetDateTime(8);
                ListViewItem items = new ListViewItem(new[] { i.ToString(), rdr["Mã sách"].ToString(), rdr["Tên Sách"].ToString(), rdr["Tác Giả"].ToString(), rdr["Thể loại"].ToString(), rdr["Nhà xuất bản"].ToString(), rdr["Giá bán"].ToString(), rdr["Năm phát hành"].ToString(), rdr["Số trang"].ToString(), /*rdr["Ngày nhập kho"].ToString()*/tmp.Day.ToString() + "/" + tmp.Month.ToString() + "/" + tmp.Year.ToString(), rdr["Tình trạng sách"].ToString() });
                lvSach.Items.Add(items);
            }
            rdr.Close();
            if (connectDB.State == ConnectionState.Open)
            {
                connectDB.Close();
            }
        }
    }
}
