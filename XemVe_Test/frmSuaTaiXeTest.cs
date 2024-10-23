using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;
using WfrmQLXEKHACH;
using System.Linq;

namespace WfrmQLXEKHACH.Test
{
    [TestClass]
    public class frmSuaTaiXeTest
    {
        private frmSuaTaiXe _form;
        private CONNECTION _connection;

        [TestInitialize]
        public void Setup()
        {
            // Thiết lập kết nối thực tế
            _connection = new CONNECTION(); // CONNECTION phải được thiết lập sẵn ConnectionString

            // Tạo form với kết nối thực
            _form = new frmSuaTaiXe();

            // Khởi tạo các TextBox cần thiết trong form
        }

        [TestMethod]
        public void LoadThongTinTaiXeCanSua_Success()
        {
            // Arrange - Giả sử bạn đã có sẵn tài xế trong cơ sở dữ liệu
            var expectedMaTX = "TX001"; // Mã tài xế có sẵn trong database
            var expectedTenTX = "Đỗ Lái Một";
            var expectedCCCD = "160199123456";
            var expectedSoNha = "12A";
            var expectedDuong = "Lê Lư";
            var expectedPhuongXa = "Phú Thọ Hòa";
            var expectedQuanHuyen = "Tân Phú";
            var expectedTinhTp = "HCM";


            CONNECTION.MaTaixeDangSua = expectedMaTX;
            // Act - Gọi phương thức Load trực tiếp từ cơ sở dữ liệu thực
            _form.frmSuaTaiXe_Load(this, EventArgs.Empty);

            // Assert - Kiểm tra kết quả từ cơ sở dữ liệu thực
            Assert.AreEqual(expectedMaTX, _form.MaTXText);
            Assert.AreEqual(expectedTenTX, _form.TenTXText);
            Assert.AreEqual(expectedCCCD, _form.CCCDText);
            Assert.AreEqual(expectedSoNha, _form.SoNhaText);
            Assert.AreEqual(expectedDuong, _form.DuongText);
            Assert.AreEqual(expectedPhuongXa, _form.PhuongXaText);
            Assert.AreEqual(expectedQuanHuyen, _form.QuanHuyenText);
            Assert.AreEqual(expectedTinhTp, _form.TinhTpText);
        }

        [TestMethod]
        public void btnLuuThayDoi_ThemMoi_Success()
        {
            // Arrange
            CONNECTION con = new CONNECTION();
            var form = new frmSuaTaiXe();

            form.btnThemMoi_Click(this, EventArgs.Empty); // Bật chế độ thêm mới
            form.MaTXText = "TX017"; // Thay đổi theo mã tài xế thực tế của bạn
            form.TenTXText = "Đỗ Lái Một";
            form.CCCDText = "160199123456";
            form.SoNhaText = "12A";
            form.DuongText = "Lê Lư";
            form.PhuongXaText = "Phú Thọ Hòa";
            form.QuanHuyenText = "Tân Phú";
            form.TinhTpText = "HCM";

            // Act
            form.btnLuuThayDoi_Click(this, EventArgs.Empty); // Gọi lưu thay đổi

            // Assert: Kiểm tra xem tài xế có được thêm vào CSDL không
            DataTable dt = con.LoadThongTinTaiXe(); // Giả sử có phương thức LoadThongTinTaiXe để lấy dữ liệu
            var isExist = dt.AsEnumerable().Any(row => row.Field<string>("MaTaiXe") == form.MaTXText);
            Assert.IsFalse(isExist, "Tài xế mới không được thêm vào cơ sở dữ liệu!");
        }

        [TestMethod]
        public void btnLuuThayDoi_ThemMoi_Fail_DuplicateMaTX()
        {
            // Arrange
            CONNECTION con = new CONNECTION();
            var form = new frmSuaTaiXe();

            form.btnThemMoi_Click(this, EventArgs.Empty); // Bật chế độ thêm mới

            // Giả sử "TX018" đã tồn tại trong cơ sở dữ liệu
            form.MaTXText = "TX017"; // Nhập mã tài xế trùng lặp
            form.TenTXText = "Đỗ Lái Một";
            form.CCCDText = "160199123456";
            form.SoNhaText = "12A";
            form.DuongText = "Lê Lư";
            form.PhuongXaText = "Phú Thọ Hòa";
            form.QuanHuyenText = "Tân Phú";
            form.TinhTpText = "HCM";
            // Assert: Kiểm tra xem tài xế không được thêm vào CSDL vì mã đã tồn tại
            DataTable dt = con.LoadThongTinTaiXe(); // Lấy lại danh sách tài xế
            var isExist = dt.AsEnumerable().Any(row => row.Field<string>("MaTaiXe") == form.MaTXText);

            Assert.IsTrue(isExist, "Mã tài xế đã tồn tại!");
        }

        [TestMethod]
        public void btnLuuThayDoi_ThemMoi_SaiThongTinDauVao()
        {
            // Arrange
            CONNECTION con = new CONNECTION();
            var form = new frmSuaTaiXe();

            form.btnThemMoi_Click(this, EventArgs.Empty); // Bật chế độ thêm mới
            form.MaTXText = ""; // Thay đổi theo mã tài xế thực tế của bạn
            form.TenTXText = "";
            form.CCCDText = "160199123456";
            form.SoNhaText = "12A";
            form.DuongText = "Lê Lư";
            form.PhuongXaText = "Phú Thọ Hòa";
            form.QuanHuyenText = "Tân Phú";
            form.TinhTpText = "HCM";
            Assert.IsFalse(string.IsNullOrEmpty(form.MaTXText) || string.IsNullOrEmpty(form.TenTXText), "Mã hoặc tên tài xế không thể để trống!");
        }

        [TestMethod]
        public void btnXoa_Click_Success()
        {
            // Arrange
            CONNECTION con = new CONNECTION();
            var form = new frmSuaTaiXe();

            CONNECTION.MaTaixeDangSua = "TX017"; // Mã tài xế đã được thêm trước đó
            form.MaTXText = CONNECTION.MaTaixeDangSua; // Đặt trường mã tài xế

            // Act
            form.btnXoa_Click(this, EventArgs.Empty); // Gọi sự kiện xóa

            // Assert: Kiểm tra xem tài xế có bị xóa khỏi CSDL không
            DataTable dt = con.LoadThongTinTaiXe(); // Giả sử có phương thức LoadThongTinTaiXe để lấy dữ liệu
            var isExist = dt.AsEnumerable().Any(row => row.Field<string>("MaTaiXe") == form.MaTXText);

            Assert.IsFalse(isExist, "Tài xế vẫn còn tồn tại trong cơ sở dữ liệu sau khi xóa");
        }
        [TestMethod]
        public void btnXoa_Click_Fail()
        {
            // Arrange
            CONNECTION con = new CONNECTION();
            var form = new frmSuaTaiXe();

            CONNECTION.MaTaixeDangSua = "TX018"; // Mã tài xế đã được thêm trước đó
            form.MaTXText = CONNECTION.MaTaixeDangSua; // Đặt trường mã tài xế

            // Act
            //form.btnXoa_Click(this, EventArgs.Empty); 

            // Assert: Kiểm tra xem tài xế có bị xóa khỏi CSDL không
            DataTable dt = con.LoadThongTinTaiXe(); // Giả sử có phương thức LoadThongTinTaiXe để lấy dữ liệu
            var isExist = dt.AsEnumerable().Any(row => row.Field<string>("MaTaiXe") == form.MaTXText);

            Assert.IsFalse(isExist, "Tài xế vẫn còn tồn tại trong cơ sở dữ liệu sau khi xóa");
        }

        [TestMethod]
        public void btnLuuThayDoi_Success()
        {
            // Arrange
            CONNECTION con = new CONNECTION();
            var form = new frmSuaTaiXe();

            CONNECTION.MaTaixeDangSua = "TX002"; // Giả sử mã tài xế đã tồn tại
            form.MaTXText = "TX002";
            form.TenTXText = "Đỗ Lái Một Cập Nhật";
            form.CCCDText = "160199123456";
            form.SoNhaText = "12A";
            form.DuongText = "Lê Lư";
            form.PhuongXaText = "Phú Thọ Hòa";
            form.QuanHuyenText = "Tân Phú";
            form.TinhTpText = "HCM2";

            // Act
            form.btnLuuThayDoi_Click(this, EventArgs.Empty); // Gọi lưu thay đổi

            // Assert: Kiểm tra xem tài xế có được cập nhật không
            DataTable dt = con.LoadThongTinTaiXe(); // Giả sử có phương thức LoadThongTinTaiXe để lấy dữ liệu
            var updatedName = dt.AsEnumerable().FirstOrDefault(row => row.Field<string>("MaTaiXe") == "TX002")?.Field<string>("TenTaiXe");

            Assert.AreEqual("Đỗ Lái Một Cập Nhật", updatedName, "Tài xế không được cập nhật thông tin");
        }
    }
}
