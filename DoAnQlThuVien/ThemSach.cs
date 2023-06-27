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
    public partial class ThemSach : Form
    {
        SqlConnection conn;
        string strConnect = "Data Source=VUNGUYEN;Initial Catalog=QLTV;Integrated Security=True";
        public ThemSach()
        {
            conn = new SqlConnection(strConnect);
            InitializeComponent();
        }

        private void ThemSach_Load(object sender, EventArgs e)
        {

            tbNgayNhapKho.Text = DateTime.Now.Day.ToString()+"/"+DateTime.Now.Month.ToString()+"/"+DateTime.Now.Year.ToString();
            
        }

        private void btThemSach_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                //Tạo mã sách
                string masachtmp = "";
                string[] tu = tbTenSach.Text.Split(' ');
                int len = tu.Length;
                for (int i = 0; i < len ; i++)
                {
                    masachtmp += tu[i].Substring(0, 1).ToUpper();
                }
                
                masachtmp += tbNamPhatHanh.Text + tbSoTrang.Text;
                string tmpDate = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();


                string insertString;
                insertString = "insert into Sach values ('"+masachtmp+"',N'" + tbTenSach.Text + "',N'" + tbTacGia.Text + "',N'" + tbTheLoai.Text + "',N'" + tbNXB.Text + "','" + tbGiaBan.Text + "','" + tbNamPhatHanh.Text + "','" + tbSoTrang.Text + "','" + tmpDate + "','" + tbtinhtrang.Text + "')";
                //insertString = "insert into SachVD values ('" + masachtmp + "',N'" + tbTenSach.Text +  "')";

                richTextBox1.Text = insertString;
                SqlCommand cmd = new SqlCommand(insertString, conn);
                cmd.ExecuteNonQuery();
                
                
                




                MessageBox.Show("Thêm sách thành công \n Mã sách: "+masachtmp);
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm sách thất bại");
            }
        }
    }

}
