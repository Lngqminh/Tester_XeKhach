using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;
using WfrmQLXEKHACH;

namespace Tester
{
    [TestClass]
    public class NUnit_TuyenXe
    {
        private frmQLTuyen frm;

        [TestInitialize]
        public void Setup()
        {
            CONNECTION.StrDATABASE = "Data Source=DESKTOP-NO8JHRO\\VINHYET;Initial Catalog=QLXEKHACH;Integrated Security=True";
            // Khởi tạo form trước mỗi test
            frm = new frmQLTuyen();
            frm.con = new CONNECTION();
            frm.Show(); // Hiển thị form nếu cần thiết
        }

        [TestCleanup]
        public void TearDown()
        {
            // Hủy form sau mỗi test để giải phóng tài nguyên
            frm.Close();
            frm.Dispose();
        }

        [TestMethod]
        public void ThemTuyenXe_InputValidData_AddsNewTuyenXeSuccessfully()
        {
            frm.btn_Them_Click(null, null); // Mở form nhập liệu

            // Arrange: Thiết lập dữ liệu đầu vào hợp lệ
            frm.txt_TenTX.Text = "Tuyến Test";
            frm.txt_DiemDi.Text = "Hà Nội";
            frm.txt_DiemDen.Text = "Hải Phòng";
            frm.txt_KhoangCach.Text = "120";

            int initialRowCount = frm.dGV_QLTX.Rows.Count;

            // Act: Gọi phương thức thêm tuyến xe

            frm.btn_Luu_Click(null, null);  // Lưu tuyến xe mới

            frm.loadData(); // Đảm bảo lưới dữ liệu cập nhật sau khi thêm

            // Assert: Kiểm tra xem tuyến xe có được thêm vào thành công không
            Assert.IsTrue(frm.dGV_QLTX.Rows.Count > initialRowCount, "Số lượng hàng không tăng sau khi thêm");
        }

        [TestMethod]
        public void ThemTuyenXe_MissingRequiredFields_DoesNotAddNewRow()
        {
            frm.btn_Them_Click(null, null);

            // Arrange: Thiết lập dữ liệu với trường tên tuyến xe bị thiếu
            frm.txt_TenTX.Text = "";
            frm.txt_DiemDi.Text = "Hà Nội";
            frm.txt_DiemDen.Text = "Hải Phòng";
            frm.txt_KhoangCach.Text = "120";

            int initialRowCount = frm.dGV_QLTX.Rows.Count;

            // Act: Gọi phương thức thêm tuyến xe

            frm.btn_Luu_Click(null, null);

            // Assert: Kiểm tra xem số lượng dòng trong DataGridView không thay đổi
            Assert.AreEqual(initialRowCount, frm.dGV_QLTX.Rows.Count);
        }

        [TestMethod]
        public void SuaTuyenXe_ValidUpdate_UpdatesSuccessfully()
        {
            // Arrange: Thiết lập dữ liệu cho tuyến xe đã tồn tại
            frm.dGV_QLTX.Rows[0].Cells[1].Value = "Tuyến 1"; // Chọn dòng cần sửa
            frm.txt_TenTX.Text = "Tuyến - Cập nhật";
            frm.txt_DiemDi.Text = "Đà nẵng";
            frm.txt_DiemDen.Text = "Đà Lạt";
            frm.txt_KhoangCach.Text = "140";

            // Act: Gọi phương thức sửa tuyến xe
            frm.btn_Sua_Click(null, null);
            frm.btn_Luu_Click(null, null);

            // Assert: Kiểm tra xem tuyến xe có được sửa thành công không
            Assert.IsTrue(HasTuyen("Tuyến - Cập nhật"));
        }

        [TestMethod]
        public void XoaTuyenXe_ValidDeletion_DeletesSuccessfully()
        {
            string tenTuyen = "Tuyến Test";

            // Tìm tuyến có tên "Tuyến Test" trong DataGridView
            bool found = false;
            foreach (DataGridViewRow row in frm.dGV_QLTX.Rows)
            {
                if (row.Cells[1].Value != null && row.Cells[1].Value.ToString() == tenTuyen)
                {
                    // Chọn dòng tuyến cần xóa
                    row.Selected = true;
                    frm.dGV_QLTX.CurrentCell = row.Cells[1]; // Đảm bảo rằng dòng này được chọn
                    found = true;
                    break;
                }
            }

            // Nếu không tìm thấy tuyến cần xóa, test sẽ fail
            Assert.IsTrue(found, $"Không tìm thấy tuyến {tenTuyen} để xóa.");

            // Act: Xóa tuyến xe
            frm.btn_Xoa_Click(null, null);

            // Load lại dữ liệu sau khi xóa
            frm.loadData(); // Đảm bảo dữ liệu được tải lại sau khi xóa

            // Assert: Kiểm tra xem tuyến xe đã được xóa chưa
            Assert.IsFalse(HasTuyen(tenTuyen), $"Tuyến {tenTuyen} chưa bị xóa.");
        }

        // Phương thức kiểm tra sự tồn tại của tuyến xe trong dữ liệu
        private bool HasTuyen(string tenTuyen)
        {
            frm.loadData(); // Load lại dữ liệu trước khi kiểm tra
            foreach (DataGridViewRow row in frm.dGV_QLTX.Rows)
            {
                if (row.Cells[1].Value != null && row.Cells[1].Value.ToString() == tenTuyen)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
