using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WfrmQLXEKHACH;

namespace Tester
{
    [TestClass]
    public class NUnit_DatVe
    {
        private frmHomeKhachHang form;

        [TestInitialize]
        public void Setup()
        {
<<<<<<< Updated upstream
            // Thiết lập chuỗi kết nối
            CONNECTION.StrDATABASE = "Data Source=QuangMinh;Initial Catalog=QLXEKHACH;Integrated Security=True";

            form = new frmHomeKhachHang();
            form.con = new CONNECTION(); // Khởi tạo kết nối database cần thiết

            // Thêm dữ liệu mẫu vào cơ sở dữ liệu nếu cần thiết
            AddSampleData();
        }

        private void AddSampleData()
        {
            // Thêm dữ liệu mẫu vào các bảng cần thiết cho kiểm thử
            form.con.TruyvanInsertDeleteUpdate("INSERT INTO TUYENXE (MaTuyenXe, TenTuyenXe, DiemDi, DiemDen) VALUES ('T0001', 'Tuyến 1', 'Bình Thuận', 'TPHCM')");
            form.con.TruyvanInsertDeleteUpdate("INSERT INTO CHUYENXE (MaChuyenXe, MaTuyenXe, GiaTien, ThoiGianXuatPhat) VALUES ('C1011', 'T0001', 100000, '2024-10-25 08:00:00')");
            form.con.TruyvanInsertDeleteUpdate("INSERT INTO VEXE (MaVeXe, MaKhachHang, MaChuyenXe) VALUES ('V0001', 'KH001', 'C1011')");
            form.con.TruyvanInsertDeleteUpdate("INSERT INTO VEXE (MaVeXe, MaKhachHang, MaChuyenXe) VALUES ('V0002', 'KH002', 'C1011')");

            // Cần thêm dữ liệu vào combobox
            form.cboDiemDi.DataSource = new List<string> { "Bình Thuận" }; // Giả lập dữ liệu cho combobox
            form.cboDiemDen.DataSource = new List<string> { "TPHCM" }; // Giả lập dữ liệu cho combobox
        }
=======
            // Thiết lập chuỗi kết nối cho lớp CONNECTION
            CONNECTION.StrDATABASE = "Data Source=QuangMinh;Initial Catalog=QLXEKHACH;Integrated Security=True"; // Chuỗi kết nối thực tế của bạn

            // Khởi tạo form và đối tượng CONNECTION
            form = new frmHomeKhachHang();
            form.con = new CONNECTION();
        }

>>>>>>> Stashed changes

        [TestMethod]
        public void Test_TimChuyen()
        {
<<<<<<< Updated upstream
            // Giả lập dữ liệu cho combobox
            form.cboDiemDi.SelectedValue = "Bình Thuận"; // Giá trị này phải tồn tại trong cơ sở dữ liệu
            form.cboDiemDen.SelectedValue = "TPHCM"; // Giá trị này cũng phải tồn tại trong cơ sở dữ liệu
            form.dtpNgayDi.Value = DateTime.Now; // Ngày hiện tại

            // Gọi phương thức tìm chuyến
=======
            // Khởi tạo dữ liệu cho ComboBox
            form.cboDiemDi.DataSource = new[] { "Bình Thuận", "Ninh Thuận" };
            form.cboDiemDi.SelectedIndex = 0; // Chọn "Bình Thuận"

            form.cboDiemDen.DataSource = new[] { "TPHCM", "Đà Lạt" };
            form.cboDiemDen.SelectedIndex = 0; // Chọn "TPHCM"

            form.dtpNgayDi.Value = DateTime.Now;

            // Thực thi chức năng tìm kiếm
>>>>>>> Stashed changes
            form.TimChuyen();

            // Kiểm tra dữ liệu kết quả
            Assert.IsNotNull(form.dGV_DatVe.DataSource, "DataGridView không có dữ liệu sau khi tìm chuyến.");
            Assert.IsTrue(form.dGV_DatVe.Rows.Count > 0, "Không tìm thấy chuyến xe nào.");
        }

        [TestMethod]
        public void Test_LoadVe()
        {
            // Giả lập vé từ database
            int trangThaiVe = 0; // Tất cả vé
            form.LoadVe(trangThaiVe);

            // Kiểm tra dữ liệu kết quả
            Assert.IsNotNull(form.dGV_XemVe.DataSource, "DataGridView không có dữ liệu sau khi load vé.");
            Assert.IsTrue(form.dGV_XemVe.Rows.Count > 0, "Không có vé nào được hiển thị.");
        }

        [TestMethod]
        public void Test_CellClick_ChonVe()
        {
            // Giả lập dữ liệu cho DataGridView
            form.dGV_DatVe.DataSource = form.con.LoadChuyen(); // Giả lập dữ liệu các chuyến xe

<<<<<<< Updated upstream
            // Kiểm tra rằng DataGridView không rỗng
            Assert.IsNotNull(form.dGV_DatVe.DataSource, "DataGridView không có dữ liệu để chọn.");
            Assert.IsTrue(form.dGV_DatVe.Rows.Count > 0, "Không có chuyến nào để chọn.");
=======
            // Kiểm tra dữ liệu trước khi thực hiện click
            Assert.IsNotNull(form.dGV_DatVe.DataSource, "DataGridView không có dữ liệu để chọn chuyến.");
            Assert.IsTrue(form.dGV_DatVe.Rows.Count > 0, "Không có chuyến xe nào để chọn.");
>>>>>>> Stashed changes

            // Giả lập sự kiện chọn dòng trong DataGridView
            var args = new DataGridViewCellEventArgs(0, 0); // Giả lập click vào ô đầu tiên
            form.dGV_DatVe_CellClick(form.dGV_DatVe, args);

            // Kiểm tra kết quả sau khi chọn chuyến xe
<<<<<<< Updated upstream
            Assert.AreEqual(CONNECTION.ChuyenDangChon, form.dGV_DatVe.Rows[0].Cells[0].Value.ToString(), "Chuyến xe chọn không đúng.");
=======
            string expectedChuyen = form.dGV_DatVe.Rows[0].Cells[0].Value.ToString();
            Assert.AreEqual(CONNECTION.ChuyenDangChon, expectedChuyen, "Chuyến xe chọn không đúng.");
>>>>>>> Stashed changes
        }

        [TestCleanup]
        public void Cleanup()
        {
            // Đóng kết nối và dọn dẹp các đối tượng
            form.con.connection.Close();
            form.Dispose();
        }
    }
}
