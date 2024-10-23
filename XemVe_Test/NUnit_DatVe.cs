using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WfrmQLXEKHACH;

namespace Tester
{
    [TestClass]
    public class frmHomeKhachHangTests
    {
        frmHomeKhachHang form;
        frmDangNhap formDN;
        CONNECTION conn;

        [TestInitialize]
        public void Setup()
        {
            // Khởi tạo kết nối và form
            conn = new CONNECTION();
            form = new frmHomeKhachHang();
            form.con = conn;
            form.Show();

            // Khởi tạo form đăng nhập
            formDN = new frmDangNhap();

            // Thực hiện đăng nhập
            PerformLogin();
        }

        private void PerformLogin()
        {
            // Giả lập nhập thông tin đăng nhập
            string username = "0582879834"; // Thay thế bằng username hợp lệ
            string password = "123"; // Thay thế bằng password hợp lệ

            formDN.txtUsername.Text = username;
            formDN.txtPassword.Text = password;

            // Giả lập nhấn nút đăng nhập
            formDN.btnDangNhap_Click(null, null);

            // Kiểm tra xem đã đăng nhập thành công chưa
            Assert.IsTrue(form.Visible, "Đăng nhập không thành công.");
        }

        [TestMethod]
        public void Test_DatabaseConnection()
        {
            try
            {
                CONNECTION.StrDATABASE = "Data Source=QuangMinh;Initial Catalog=QLXEKHACH;Integrated Security=True";
                conn = new CONNECTION();
                conn.connection.Open();
                Assert.AreEqual(ConnectionState.Open, conn.connection.State, "Kết nối đến cơ sở dữ liệu không thành công.");
            }
            catch (Exception ex)
            {
                Assert.Fail("Lỗi kết nối: " + ex.Message);
            }
            finally
            {
                if (conn.connection.State == ConnectionState.Open)
                {
                    conn.connection.Close();
                }
            }
        }

        [TestMethod]
        public void Test_LoadHoSo()
        {
            // Arrange
            frmHomeKhachHang form = new frmHomeKhachHang();

            // Act
            form.LoadHoSo();

            // Assert
            Assert.IsFalse(string.IsNullOrEmpty(form.txt_Ten.Text), "Tên không được trống.");
            Assert.IsFalse(string.IsNullOrEmpty(form.txt_GioiTinh.Text), "Giới tính không được trống.");
            Assert.IsFalse(string.IsNullOrEmpty(form.txt_DiaChi.Text), "Địa chỉ không được trống.");
        }


        [TestMethod]
        public void Test_LoadVe()
        {
            int index = 2; // Ví dụ chỉ số vé
            form.LoadVe(index); // Gọi phương thức để tải vé

            // Kiểm tra xem DataGridView có dữ liệu không
            Assert.IsNotNull(form.dGV_XemVe.DataSource, "DataSource không được null.");
            Assert.IsTrue(((DataTable)form.dGV_XemVe.DataSource).Rows.Count > 0, "Không có vé nào được tải.");
        }

        [TestMethod]
        public void Test_TimChuyen()
        {
            // Thiết lập giá trị cho các trường cần thiết
            form.cboDiemDi.SelectedValue = "Bình Thuận";
            form.cboDiemDen.SelectedValue = "TPHCM";
            form.dtpNgayDi.Value = new DateTime(2024, 10, 25);

            // Gọi phương thức để tìm chuyến
            form.TimChuyen();

            // Kiểm tra xem DataGridView có dữ liệu không
            Assert.IsNotNull(form.dGV_DatVe.DataSource, "DataSource không được null.");
            Assert.IsTrue(((DataTable)form.dGV_DatVe.DataSource).Rows.Count > 0, "Không có chuyến nào được tìm thấy.");
        }

        [TestMethod]
        public void Test_btn_Huy_Click()
        {
            // Giả định rằng một vé đã được chọn
            CONNECTION.VeDangChon = "V0034";

            // Gọi phương thức hủy
            form.btn_Huy_Click(null, null);

            // Kiểm tra rằng VéDangChon đã được hủy
            Assert.AreEqual("", CONNECTION.VeDangChon, "Vé không được hủy thành công.");
        }

        [TestCleanup]
        public void Cleanup()
        {
            form.Close(); // Đóng form sau khi hoàn tất kiểm thử
        }
    }
}
