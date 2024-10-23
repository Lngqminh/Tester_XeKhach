using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;
using WfrmQLXEKHACH;
using System.Linq;
using System.Data.SqlClient;

namespace WfrmQLXEKHACH.Test
{
    [TestClass]
    public class frmSuachuyenXeTest
    {

        [TestInitialize]
        public void Setup()
        {

        }

        [TestMethod]
        public void Test_ThemChuyenXe_Success()
        {
            // Arrange
            CONNECTION con = new CONNECTION();
            //điều chỉnh điều kiện thêm mới
            CONNECTION.ThemMoi = 1;

            //tạo form và load form
            var form = new frmSuaChuyenXe();
            form.frmSuaChuyenXe_Load(null, EventArgs.Empty);

            //dữ liệu thêm mới
            form.Flat = 0;//điều kiện để thực hiện thêm mới
            form.MaTuyenXe = "T0003";  // Mã tuyến xe mẫu
            form.MaXe = "XE101";  // Mã xe mẫu
            form.MaChuyenXe = "C0002";  // Mã chuyến xe mới
            form.GiaTien = "500000";  // Giá vé mẫu
            form.SoGheTrong = "";
            form.ThoiGianDi = "01/01/2024 08:00";  // Thời gian đi
            form.ThoiGianDen = "01/01/2024 12:00";  // Thời gian đến

            // Act
            form.btn_Luu_Click(null, EventArgs.Empty);  // Thực hiện chức năng lưu (thêm mới)

            // Assert: Kiểm tra xem chuyến xe đã được thêm chưa

            string sql = "SELECT * FROM CHUYENXE WHERE MaChuyenXe = '" + form.MaChuyenXe + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con.connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Kiểm tra xem có dữ liệu trả về hay không
            Assert.IsTrue(dt.Rows.Count > 0, "Chuyến xe mới không được thêm vào cơ sở dữ liệu.");
        }

        [TestMethod]
        public void Test_SuaChuyenXe_Success()
        {
            // Arrange
            CONNECTION con = new CONNECTION();
            CONNECTION.ThemMoi = 1;
            CONNECTION.MaChuyenXeSua = "C0001";
            var form = new frmSuaChuyenXe();
            form.frmSuaChuyenXe_Load(null, EventArgs.Empty);

            form.Flat = 1;//điều kiện để thực hiện sửa
            form.MaTuyenXe = "T0003";  // Mã tuyến xe mẫu
            form.MaXe = "XE101";  // Mã xe mẫu
            form.MaChuyenXe = "C0001";  // Mã chuyến xe mới
            form.GiaTien = "600000";  // Giá vé mẫu
            form.SoGheTrong = "";
            form.ThoiGianDi = "01/01/2024 08:00";  // Thời gian đi
            form.ThoiGianDen = "01/01/2024 12:00";  // Thời gian đến

            // Act
            form.btn_Luu_Click(null, EventArgs.Empty);  // Thực hiện chức năng sửa

            // Assert: Kiểm tra xem chuyến xe đã được sửa chưa
            string sql = "SELECT * FROM CHUYENXE WHERE MaChuyenXe = '" + form.MaChuyenXe + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con.connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Kiểm tra nếu giá trị giá tiền đã được cập nhật thành công
            string giaTienMoi = dt.Rows[0]["GiaTien"].ToString();
            Assert.AreEqual("600000", giaTienMoi, "Chuyến xe không được sửa thành công.");
        }

        [TestMethod]
        public void Test_XoaChuyenXe_Success()
        {
            // Arrange
            CONNECTION con = new CONNECTION();
            var form = new frmSuaChuyenXe();

            form.MaChuyenXe = "C0002";  // Mã chuyến xe muốn xóa

            // Act
            form.btn_Xoa_Click(null, EventArgs.Empty);  // Thực hiện chức năng xóa

            // Assert: Kiểm tra xem chuyến xe đã được xóa chưa
            string sql = "SELECT * FROM CHUYENXE WHERE MaChuyenXe = 'CX001'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con.connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Kiểm tra nếu chuyến xe đã bị xóa
            Assert.IsTrue(dt.Rows.Count == 0, "Chuyến xe không được xóa thành công.");
        }

    }
}
