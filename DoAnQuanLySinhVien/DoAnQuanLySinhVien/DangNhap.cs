using DevExpress.XtraEditors;
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

namespace DoAnQuanLySinhVien
{
    public partial class DangNhap : DevExpress.XtraEditors.XtraForm
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=CHUSYMINH\SQLEXPRESS;Initial Catalog=QuanLySinhVienDoAn;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM DangNhap WHERE TenDangNhap=@TenDangNhap AND MatKhau=@MatKhau";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TenDangNhap", tbDangNhap.Text);
            command.Parameters.AddWithValue("@MatKhau", tbMatKhau.Text);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                // Đăng nhập thành công
                MessageBox.Show("Đăng nhập thành công!");

                // Lấy ID của tài khoản đăng nhập thành công
                int loggedInUserID = reader.GetInt32(reader.GetOrdinal("ID"));

                // Hiển thị form CaNhan và truyền giá trị ID
                CaNhan caNhanForm = new CaNhan();
                caNhanForm.LoggedInUserID = loggedInUserID;
                caNhanForm.ShowDialog();
            }
            else
            {
                // Đăng nhập thất bại
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
            }

            connection.Close();

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}