using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using System.Data;
using WfrmQLXEKHACH;

namespace Tester
{
    [TestClass]
    public class NUnit_XemVe
    {
        frmHomeKhachHang form;
        CONNECTION conn;

        [TestInitialize]
        public void Setup()
        {
            // Khởi tạo kết nối nếu cần
            conn = new CONNECTION(); 

            // Khởi tạo form
            form = new frmHomeKhachHang();
            form.con = conn;
            form.Show(); 
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
    }
}
