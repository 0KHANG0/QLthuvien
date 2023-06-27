using QuanLyQuanCafe.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DoAnQlThuVien.DAO
{
    internal class accout
    {
        private static accout instance;
        public static accout Instance
        {
            get { if (instance == null) instance = new accout(); return instance; }
            private set { instance = value ; }
        }
        private accout() { }

        public bool login(string username, string password) {
            string query = "SELECT * FROM [dbo].[Admin] WHERE [Tên Đăng Nhập] = N'" + username + "' AND [Mật Khẩu] = N'" + password + "' ";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }
    }
}
