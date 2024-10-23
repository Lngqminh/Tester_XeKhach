using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using System.Data; 
using WfrmQLXEKHACH;

namespace XemVe_Test
{
    [TestClass]
    public class NUnit_XemVe
    {
        frmHomeKhachHang form;
        CONNECTION connect;
        
        [TestInitialize]
        public void Setup()
        {
            // Khởi tạo form
            connect = new CONNECTION();
            form = new frmHomeKhachHang();
            form.con = connect;
            form.Show(); // Hiển thị form để đảm bảo mọi control được khởi tạo

            // Kiểm tra xem kết nối có thành công không
            try
            {
                form.con.connection.Open();
                form.con.connection.Close();
            }
            catch
            {
                Assert.Inconclusive("Không thể kết nối đến cơ sở dữ liệu.");
            }
        }

        [TestCleanup]
        public void Teardown()
        {
            // Đóng form sau mỗi test case
            form.Close();
        }
        [TestMethod]
        public void Test_XemVe_ChuyenTabXemVe()
        {
            // Gọi phương thức xemve để chuyển tab
            form.xemve();

            // Kiểm tra tab hiện tại có phải là tab Xem Vé không
            Assert.AreEqual("tab_XemVe", form.tab_Home.SelectedTab.Name);
        }

        [TestMethod]
        public void Test_LoadVe_LoadsDataIntoGridView()
        {
            // Gọi phương thức LoadVe để tải dữ liệu
            form.LoadVe(0);

            // Kiểm tra DataGridView không rỗng
            var gridView = (DataGridView)form.Controls["dGV_XemVe"];
            Assert.IsNotNull(gridView);
            Assert.IsTrue(gridView.Rows.Count > 0, "Không có vé nào được tải");
        }

        [TestMethod]
        public void Test_btn_TimKiem_Click_FillsDataGridView()
        {
            // Gọi phương thức tìm kiếm
            form.btn_TimKiem_Click(null, null);

            // Kiểm tra kết quả được tải vào dGV_DatVe
            var gridView = (DataGridView)form.Controls["dGV_DatVe"];
            Assert.IsTrue(gridView.Rows.Count > 0, "Không có chuyến xe nào được tìm thấy");
        }
    }
}
