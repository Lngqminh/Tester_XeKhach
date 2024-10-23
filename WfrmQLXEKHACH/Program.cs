using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Threading;

/*
            con.connection.Open();
            con.connection.Close();
            if (con.connection.State == ConnectionState.Closed) con.connection.Open();
            if (con.connection.State == ConnectionState.Open) con.connection.Close();
 
 */

namespace WfrmQLXEKHACH
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmAboutUs());
        }
    }
    public class CONNECTION
    {
        public SqlConnection connection;
        public DataSet ds;
        public DataTable dt;
        public static string StrDATABASE;
        public static string TKadmin;
        public static string MaKhachHang, ChuyenDangChon, GheDangChon;
        public static int GiaVeDangChon;
        public static List<string> DsGheDangChon = new List<string>();
        public static string DiemDon, DiemTra;
        public static bool ThanhToanXong = false;
        public static bool SuaXong = false;
        public static bool SuaXongC = false;
        public static bool SuaXongV = false;
        public static bool SuaXongK = false;
        public static bool SuaXongT = false;
        public static bool SuaXongX = false;
        public static string VeDangChon = "", ThongTinVeDangChon;
        public static string MaChuyenXeSua = "";
        public static int ThemMoi;
        public static string SuaVeAdmin;
        public static string MaTaixeDangSua;
        public static string MaTaiXeThongKe;
        public CONNECTION()
        {
            connection = new SqlConnection(StrDATABASE);
            ds = new DataSet();
        }
        public void ChonChuyen(string Chuyen)
        {
            ChuyenDangChon = Chuyen;
            if (connection.State == ConnectionState.Closed) connection.Open();
            string sql = "select GiaTien from CHUYENXE where MaChuyenXe = '" + ChuyenDangChon + "'";
            SqlCommand cmd = new SqlCommand(sql, connection);
            GiaVeDangChon = Convert.ToInt32(cmd.ExecuteScalar());
            if (connection.State == ConnectionState.Open) connection.Close();
        }
        public string TruyvanInsertDeleteUpdate(string truyvan)
        {
            try
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                SqlCommand cmd = new SqlCommand(truyvan, connection);
                cmd.ExecuteNonQuery();
                if (connection.State == ConnectionState.Open) connection.Close();
                return "Thành công";
            }
            catch
            {
                return "Thất bại";
            }
        }
        public bool ktTrungKhoa(string table, string thuoctinh, string giatri)
        {
            try
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                string sql = "select count(*) from " + table + " where " + thuoctinh + " = N'" + giatri + "'";
                SqlCommand cmd = new SqlCommand(sql, connection);
                int dem = (int)cmd.ExecuteScalar();
                if (connection.State == ConnectionState.Open) connection.Close();
                if (dem > 0)
                    return true;
                else return false;
            }
            catch
            {
                return true;
            }
        }
        public bool DangNhapAdmin(string username, string MatKhau)
        {
            try
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                string sql = "select MatKhau from TK_ADMIN where username = '" + username + "'";
                SqlCommand cmd = new SqlCommand(sql, connection);
                string mk = cmd.ExecuteScalar().ToString();
                if (connection.State == ConnectionState.Open) connection.Close();
                if (mk == MatKhau)
                {
                    TKadmin = username;
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool DangNhapKhachHang(string sdt, string MatKhau)
        {
            try
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                string sql = "select MaKhachHang from KHACHHANG_SODIENTHOAI where SoDienThoai = '" + sdt + "'";
                SqlCommand cmd = new SqlCommand(sql, connection);
                string MaKH = cmd.ExecuteScalar().ToString();
                string sql2 = "select MatKhau from TK_KHACHHANG where MaKhachHang = '" + MaKH + "'";
                cmd = new SqlCommand(sql2, connection);
                string pass = cmd.ExecuteScalar().ToString();
                if (connection.State == ConnectionState.Open) connection.Close();
                if (pass == MatKhau)
                {
                    MaKhachHang = MaKH;
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        public DataTable LoadComboboxDiemDi()
        {
            ds = new DataSet();
            if (connection.State == ConnectionState.Closed) connection.Open();
            string sql = "select distinct DiemDi from TUYENXE";
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            da.Fill(ds, "DiemDi");
            if (connection.State == ConnectionState.Open) connection.Close();
            return ds.Tables["DiemDi"];
        }
        public DataTable LoadComboboxDiemDen()
        {
            ds = new DataSet();
            if (connection.State == ConnectionState.Closed) connection.Open();
            string sql = "select distinct DiemDen from TUYENXE";
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            da.Fill(ds, "DiemDen");
            if (connection.State == ConnectionState.Open) connection.Close();
            return ds.Tables["DiemDen"];
        }
        public DataTable LoadComboboxTuyenXe()
        {
            ds = new DataSet();
            if (connection.State == ConnectionState.Closed) connection.Open();
            string sql = "select distinct MaTuyenXe from TUYENXE";
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            da.Fill(ds, "MaTuyenXe");
            if (connection.State == ConnectionState.Open) connection.Close();
            return ds.Tables["MaTuyenXe"];
        }
        public DataTable LoadComboboxMaXe()
        {
            ds = new DataSet();
            if (connection.State == ConnectionState.Closed) connection.Open();
            string sql = "select distinct MaXe from XE";
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            da.Fill(ds, "MaXe");
            if (connection.State == ConnectionState.Open) connection.Close();
            return ds.Tables["MaXe"];
        }
        public DataTable LoadComboboxMaTuyen()
        {
            ds = new DataSet();
            if (connection.State == ConnectionState.Closed) connection.Open();
            string sql = "select distinct MaTuyenXe from TUYENXE";
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            da.Fill(ds, "MaTuyenXe");
            if (connection.State == ConnectionState.Open) connection.Close();
            return ds.Tables["MaTuyenXe"];
        }
        public DataTable LoadComboboxMaChuyen()
        {
            ds = new DataSet();
            if (connection.State == ConnectionState.Closed) connection.Open();
            string sql = "select distinct MaChuyenXe from CHUYENXE";
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            da.Fill(ds, "MaChuyenXe");
            if (connection.State == ConnectionState.Open) connection.Close();
            return ds.Tables["MaChuyenXe"];
        }
        public DataTable LoadComboboxMaChuyen(string MaTuyenXe)
        {
            ds = new DataSet();
            if (connection.State == ConnectionState.Closed) connection.Open();
            string sql = "select distinct MaChuyenXe from CHUYENXE where MaTuyenXe = '"+MaTuyenXe+"'";
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            da.Fill(ds, "MaChuyenXe");
            if (connection.State == ConnectionState.Open) connection.Close();
            return ds.Tables["MaChuyenXe"];
        }
        public DataTable Loadxe()
        {
            ds = new DataSet();
            if (connection.State == ConnectionState.Closed) connection.Open();
            string sql = "select * from XE";
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            da.Fill(ds, "Xe");
            if (connection.State == ConnectionState.Open) connection.Close();
            return ds.Tables["Xe"];
        }
        public DataTable LoadComboboxLoaiXe()
        {
            ds = new DataSet();
            if (connection.State == ConnectionState.Closed) connection.Open();
            string sql = "select distinct MaLoaiXe, TenLoaiXe from LOAIXE";
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            da.Fill(ds, "MaLoaiXe");
            if (connection.State == ConnectionState.Open) connection.Close();
            return ds.Tables["MaLoaiXe"];
        }
        public DataTable LoadVeXe(string sql)
        {
            ds = new DataSet();
            if (connection.State == ConnectionState.Closed) connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            da.Fill(ds, "VeXe");
            if (connection.State == ConnectionState.Open) connection.Close();
            return ds.Tables["VeXe"];
        }
        public DataTable LoadHoSoKhachHang()
        {
            ds = new DataSet();
            if (connection.State == ConnectionState.Closed) connection.Open();
            string sql = "select * from KHACHHANG where MaKhachHang = '" + MaKhachHang + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            da.Fill(ds, "KhachHang");
            if (connection.State == ConnectionState.Open) connection.Close();
            return ds.Tables["KhachHang"];
        }
        public DataTable LoadThongTinTaiXe()
        {
            ds = new DataSet();
            if (connection.State == ConnectionState.Closed) connection.Open();
            string sql = "select * from TAIXE where MaTaiXe = '" + MaTaixeDangSua + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            da.Fill(ds, "TaiXe");
            if (connection.State == ConnectionState.Open) connection.Close();
            return ds.Tables["TaiXe"];
        }
        public DataTable LoadThongTinTaiXeThongKe()
        {
            ds = new DataSet();
            if (connection.State == ConnectionState.Closed) connection.Open();
            string sql = "select * from TAIXE where MaTaiXe = '" + MaTaiXeThongKe + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            da.Fill(ds, "TaiXe");
            if (connection.State == ConnectionState.Open) connection.Close();
            return ds.Tables["TaiXe"];
        }
        public DataTable LoadSoDienThoaiKhachHang()
        {
            ds = new DataSet();
            if (connection.State == ConnectionState.Closed) connection.Open();
            string sql = "select * from KHACHHANG_SODIENTHOAI where MaKhachHang = '" + MaKhachHang + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            da.Fill(ds, "KhachHang_SoDienThoai");
            if (connection.State == ConnectionState.Open) connection.Close();
            return ds.Tables["KhachHang_SoDienThoai"];
        }
        public DataTable TimChuyenXe(string DiemDi, string DiemDen, string NgayDi)
        {
            ds = new DataSet();
            if (connection.State == ConnectionState.Closed) connection.Open();
            string sql = String.Format("set dateformat dmy select MaChuyenXe, TenTuyenXe, DiemDi, DiemDen, ThoiGianXuatPhat, SoGheTrong, SucChuaVe, GiaTien, LoaiGhe from CHUYENXE, TUYENXE, XE, LOAIXE where CHUYENXE.MaTuyenXe = TUYENXE.MaTuyenXe and CHUYENXE.MaXe = XE.MaXe and XE.MaLoaiXe = LOAIXE.MaLoaiXe and DiemDi = N'{0}' and DiemDen = N'{1}' and year(ThoiGianXuatPhat) = year('{2}') and month(ThoiGianXuatPhat) = month('{2}') and day(ThoiGianXuatPhat) = day('{2}')", DiemDi, DiemDen, NgayDi);
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            da.Fill(ds, "TimChuyen");
            if (connection.State == ConnectionState.Open) connection.Close();
            return ds.Tables["TimChuyen"];
        }
        public DataTable LoadChuyen()
        {
            ds = new DataSet();
            if (connection.State == ConnectionState.Closed) connection.Open();
            string sqlreset = "update CHUYENXE set SoGheTrong = (select SucChuaVe from LOAIXE, XE where LOAIXE.MaLoaiXe=XE.MaLoaiXe and XE.MaXe = CHUYENXE.MaXe) where SoGheTrong is null";
            SqlCommand cmd = new SqlCommand(sqlreset, connection);
            cmd.ExecuteNonQuery();
            string sql = String.Format("set dateformat dmy select MaChuyenXe, TenTuyenXe, DiemDi, DiemDen, ThoiGianXuatPhat, SoGheTrong, SucChuaVe, GiaTien, LoaiGhe from CHUYENXE, TUYENXE, XE, LOAIXE where CHUYENXE.MaTuyenXe = TUYENXE.MaTuyenXe and CHUYENXE.MaXe = XE.MaXe and XE.MaLoaiXe = LOAIXE.MaLoaiXe ");
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            da.Fill(ds, "TimChuyen");
            if (connection.State == ConnectionState.Open) connection.Close();
            return ds.Tables["TimChuyen"];
        }
        public List<string> DuyetSoDoGhe()
        {
            ds = new DataSet();
            List<string> ghe = new List<string>();
            if (connection.State == ConnectionState.Closed) connection.Open();
            string sql = String.Format("select MaGhe from VEXE, CHITIETVEXE where VEXE.MaVeXe=CHITIETVEXE.MaVeXe and MaChuyenXe = '{0}'", ChuyenDangChon);
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                ghe.Add(rdr["MaGhe"].ToString());
            }
            rdr.Close();
            if (connection.State == ConnectionState.Open) connection.Close();
            DsGheDangChon = new List<string>();
            return ghe;
        }
        public List<string> LoadXacNhanThongTinMuaVe()
        {
            ds = new DataSet();
            List<string> lst = new List<string>();
            string item;
            if (connection.State == ConnectionState.Closed) connection.Open();
            string sql = "select TenKhachHang from KHACHHANG where MaKhachHang = '" + MaKhachHang + "'";
            SqlCommand cmd = new SqlCommand(sql, connection);
            item = cmd.ExecuteScalar().ToString();
            lst.Add(item);
            sql = "select SoDienThoai from KHACHHANG_SODIENTHOAI where MaKhachHang = '" + MaKhachHang + "'";
            cmd = new SqlCommand(sql, connection);
            SqlDataReader rdr = cmd.ExecuteReader();
            string sdt = "";
            while (rdr.Read())
            {
                sdt += ", " + rdr["SoDienThoai"].ToString();
            }
            lst.Add(sdt.Remove(0, 1));
            rdr.Close();
            sql = "select Email from KHACHHANG where MaKhachHang = '" + MaKhachHang + "'";
            cmd = new SqlCommand(sql, connection);
            item = cmd.ExecuteScalar().ToString();
            lst.Add(item);
            sql = "select TenTuyenXe from CHUYENXE, TUYENXE where CHUYENXE.MaTuyenXe=TUYENXE.MaTuyenXe and MaChuyenXe = '" + ChuyenDangChon + "'";
            cmd = new SqlCommand(sql, connection);
            item = cmd.ExecuteScalar().ToString();
            lst.Add(item);
            sql = "select ThoiGianXuatPhat from CHUYENXE where MaChuyenXe = '" + ChuyenDangChon + "'";
            cmd = new SqlCommand(sql, connection);
            DateTime date = Convert.ToDateTime(cmd.ExecuteScalar());
            item = date.ToShortDateString();
            lst.Add(item);
            item = date.ToShortTimeString();
            lst.Add(item);
            sql = "select ThoiGianDenDuKien from CHUYENXE where MaChuyenXe = '" + ChuyenDangChon + "'";
            cmd = new SqlCommand(sql, connection);
            date = Convert.ToDateTime(cmd.ExecuteScalar());
            item = date.ToShortTimeString();
            lst.Add(item);
            int tien = GiaVeDangChon * DsGheDangChon.Count();   
            item = tien.ToString();
            lst.Add(item);
            if (connection.State == ConnectionState.Open) connection.Close();
            return lst;
        }
        public void DatVe()
        {
            foreach (var i in DsGheDangChon)
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                string sql = "declare @mahientai varchar(5) select top 1 @mahientai = MaVeXe from VEXE order by MaVeXe desc declare @slg int set @slg = SUBSTRING(@mahientai, 2, 4) +1 declare @Maslg varchar(5) = Convert(varchar(5), @slg) declare @MaVe varchar(5) set @MaVe = case len(@Maslg) when 1 then 'V000'+@Maslg when 2 then 'V00'+@Maslg when 3 then 'V0'+@Maslg when 4 then 'V'+@Maslg else @Maslg end insert into VEXE values (@MaVe, '" + MaKhachHang + "', '" + ChuyenDangChon + "') insert into CHITIETVEXE values (@MaVe, '" + i + "', N'" + DiemDon + "', N'" + DiemTra + "', GETDATE())";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                if (connection.State == ConnectionState.Open) connection.Close();
            }
        }
        public string LayLaiMatKhau(string sdt)
        {
            try
            {
                string sql = "select MatKhau from TK_KHACHHANG t, KHACHHANG_SODIENTHOAI s where t.MaKhachHang=s.MaKhachHang and SoDienThoai='" + sdt + "'";
                if (connection.State == ConnectionState.Closed) connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                string mk = cmd.ExecuteScalar().ToString();
                if (connection.State == ConnectionState.Open) connection.Close();
                return mk;
            }
            catch
            {
                return "Không tìm thấy. Hãy chọn mục <<Chưa có tài khoản>>";
            }
        }
        public DataTable LoadVeCuaToi(int i)
        {
            ds = new DataSet();
            if (connection.State == ConnectionState.Closed) connection.Open();
            string sql;
            if (i < 0)
                sql = "select v.MaVeXe, case when ThoiGianXuatPhat<getdate() then N'Hết hạn' else N'Còn hạn' end 'TinhTrang', ThoiGianXuatPhat as NgayDi, TenTuyenXe, MaGhe, LoaiGhe, ThoiGianXuatPhat, DiemDon, ThoiGianDenDuKien, DiemTra, GiaTien, BienSoXe from VEXE v, CHUYENXE c, TUYENXE t, CHITIETVEXE ct, XE x, LOAIXE l where v.MaChuyenXe=c.MaChuyenXe and c.MaTuyenXe=t.MaTuyenXe and v.MaVeXe=ct.MaVeXe and c.MaXe=x.MaXe and x.MaLoaiXe=l.MaLoaiXe and MaKhachHang='" + MaKhachHang + "' and ThoiGianXuatPhat<getdate()";
            else if (i > 0)
                sql = "select v.MaVeXe, case when ThoiGianXuatPhat<getdate() then N'Hết hạn' else N'Còn hạn' end 'TinhTrang', ThoiGianXuatPhat as NgayDi, TenTuyenXe, MaGhe, LoaiGhe, ThoiGianXuatPhat, DiemDon, ThoiGianDenDuKien, DiemTra, GiaTien, BienSoXe from VEXE v, CHUYENXE c, TUYENXE t, CHITIETVEXE ct, XE x, LOAIXE l where v.MaChuyenXe=c.MaChuyenXe and c.MaTuyenXe=t.MaTuyenXe and v.MaVeXe=ct.MaVeXe and c.MaXe=x.MaXe and x.MaLoaiXe=l.MaLoaiXe and MaKhachHang='" + MaKhachHang + "' and ThoiGianXuatPhat>getdate()";
            else
                sql = "select v.MaVeXe, case when ThoiGianXuatPhat<getdate() then N'Hết hạn' else N'Còn hạn' end 'TinhTrang', ThoiGianXuatPhat as NgayDi, TenTuyenXe, MaGhe, LoaiGhe, ThoiGianXuatPhat, DiemDon, ThoiGianDenDuKien, DiemTra, GiaTien, BienSoXe from VEXE v, CHUYENXE c, TUYENXE t, CHITIETVEXE ct, XE x, LOAIXE l where v.MaChuyenXe=c.MaChuyenXe and c.MaTuyenXe=t.MaTuyenXe and v.MaVeXe=ct.MaVeXe and c.MaXe=x.MaXe and x.MaLoaiXe=l.MaLoaiXe and MaKhachHang='" + MaKhachHang + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            da.Fill(ds, "VeCuaToi");
            if (connection.State == ConnectionState.Open) connection.Close();
            return ds.Tables["VeCuaToi"];
        }
        public string XemThongTinVe(string mave)
        {
            try
            {
                string kq = "";
                string sql = "select TenTuyenXe, MaGhe, DiemDon, DiemTra, GiaTien, ThoiGianXuatPhat, ThoiGianDenDuKien from CHITIETVEXE ct, VEXE v, CHUYENXE c, TUYENXE t where ct.MaVeXe=v.MaVeXe and v.MaChuyenXe = c.MaChuyenXe and c.MaTuyenXe = t.MaTuyenXe and v.MaVeXe = '" + mave + "'";
                if (connection.State == ConnectionState.Closed) connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    kq += rdr["TenTuyenXe"].ToString() + " Ngày: " + Convert.ToDateTime(rdr["ThoiGianXuatPhat"]).ToShortDateString();
                    kq += "\nThời gian: " + Convert.ToDateTime(rdr["ThoiGianXuatPhat"]).ToShortTimeString();
                    kq += " - " + Convert.ToDateTime(rdr["ThoiGianDenDuKien"]).ToShortTimeString();
                    kq += "\nGhế: " + rdr["MaGhe"].ToString() + " - Giá:" + rdr["GiaTien"].ToString();
                    kq += "\nĐiểm đón: " + rdr["DiemDon"].ToString() + " - Điểm trả: " + rdr["DiemTra"].ToString();
                }
                rdr.Close();
                if (connection.State == ConnectionState.Open) connection.Close();
                return kq;
            }
            catch
            {
                return "...";
            }
        }
        public string LayDiemDon(string mave)
        {
            string kq;
            string sql = "select DiemDon from CHITIETVEXE where MaVeXe = '" + mave + "'";
            if (connection.State == ConnectionState.Closed) connection.Open();
            SqlCommand cmd = new SqlCommand(sql, connection);
            kq = cmd.ExecuteScalar().ToString();
            if (connection.State == ConnectionState.Open) connection.Close();
            return kq;
        }
        public string LayDiemTra(string mave)
        {
            string kq;
            string sql = "select DiemTra from CHITIETVEXE where MaVeXe = '" + mave + "'";
            if (connection.State == ConnectionState.Closed) connection.Open();
            SqlCommand cmd = new SqlCommand(sql, connection);
            kq = cmd.ExecuteScalar().ToString();
            if (connection.State == ConnectionState.Open) connection.Close();
            return kq;
        }


    }

}
