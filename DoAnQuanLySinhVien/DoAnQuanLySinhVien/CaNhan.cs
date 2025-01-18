using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQuanLySinhVien
{
    public partial class CaNhan : DevExpress.XtraEditors.XtraForm
    {
        public int LoggedInUserID { get; set; }
        public CaNhan()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void CaNhan_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=CHUSYMINH\SQLEXPRESS;Initial Catalog=QuanLySinhVienDoAn;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM DangNhap WHERE ID=@LoggedInUserID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LoggedInUserID", LoggedInUserID);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                // Lấy thông tin tài khoản từ cơ sở dữ liệu
                string tenDangNhap = reader["TenDangNhap"].ToString();
                string matKhau = reader["MatKhau"].ToString();
                string hoTen = reader["HoTen"].ToString();
                string queQuan = reader["QueQuan"].ToString();
                string gioiTinh = reader["GioiTinh"].ToString();
                string sdt = reader["SDT"].ToString();
                string email = reader["Email"].ToString();
                string quyenTruyCap = reader["QuyenTruyCap"].ToString();

                // Hiển thị thông tin lên các TextBox hoặc các điều khiển khác trên form
                txtTenDangNhap.Text = tenDangNhap;
                txtMatKhau.Text = matKhau;
                txtHoTen.Text = hoTen;
                txtQueQuan.Text = queQuan;
                txtGioiTinh.Text = gioiTinh;
                txtSDT.Text = sdt;
                txtEmail.Text = email;
                txtQuyenTruyCap.Text = quyenTruyCap;

                // Đóng kết nối đến cơ sở dữ liệu
                connection.Close();
            }
            else
            {
                // Xử lý trường hợp không tìm thấy thông tin tài khoản
                MessageBox.Show("Không tìm thấy thông tin tài khoản.");
                connection.Close();
                this.Close();
            }
        }

    

    private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.gif)|*.jpg;*.jpeg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            { 
               
                string imagePath = openFileDialog.FileName;

                pictureBox1.Image = Image.FromFile(imagePath);
            }
        }

        private void btnHinhAnh_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                // Biến đổi hình ảnh thành mảng byte
                byte[] imageData;
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox1.Image.Save(ms, ImageFormat.Jpeg); // Thay đổi định dạng nếu cần
                    imageData = ms.ToArray();
                }

                // Lưu mảng byte imageData vào cơ sở dữ liệu
                // Thực hiện truy vấn cập nhật cơ sở dữ liệu với thông tin hình ảnh mới
                // ...

                MessageBox.Show("Hình ảnh đã được cập nhật thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hình ảnh trước khi cập nhật.");
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQueQuan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGioiTinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuyenTruyCap_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}