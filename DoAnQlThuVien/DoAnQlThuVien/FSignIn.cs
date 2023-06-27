using DoAnQlThuVien.DAO;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DoAnQlThuVien
{
    public partial class FSignIn : Form
    {
        SqlConnection conn;
        public static string UserName = "";
        public FSignIn()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=VUNGUYEN;Initial Catalog=QLTV;Integrated Security=True"); 
        }
        
        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            if(cbShow.Checked) {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }

        bool login(string username,string password)
        {
            return accout.Instance.login(username, password);

        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPass.Text;
            if(login(username, password))
            {
                this.Hide();
                FUser fUser = new FUser();
                fUser.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}