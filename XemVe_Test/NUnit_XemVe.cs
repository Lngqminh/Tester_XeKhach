using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WfrmQLXEKHACH;

namespace Tester
{
    [TestClass]
    public class NUnit_XemVe
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


        [TestCleanup] 
        public void Teardown()
        {
            form.Close();
        }

        [TestMethod]
        public void Test_XemVe_ChuyenTabXemVe()
        {
            form.xemve();
            Assert.AreEqual("tab_XemVe", form.tab_Home.SelectedTab.Name);
        }

        [TestMethod]
        public void Test_LoadVe_LoadsDataIntoGridView()
        {
            // Kiểm tra xem dGV_XemVe có được khởi tạo không
            var gridView = (DataGridView)form.Controls["dGV_XemVe"];
            Assert.IsNotNull(gridView, "dGV_XemVe không được tìm thấy.");

            // Gọi LoadVe để tải dữ liệu
            form.LoadVe(0);
            Assert.IsTrue(gridView.Rows.Count > 0, "Không có vé nào được tải");
        }

        [TestMethod]
        public void Test_XemVe_TabVeDaChon()
        {
            form.xemve(); // Chọn tab "XemVe"
            Assert.AreEqual(form.tab_Home.SelectedTab, form.tab_XemVe, "Tab 'XemVe' không được chọn.");
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
    }
}
