using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WfrmQLXEKHACH
{
    public partial class frmHomeKhachHang : Form
    {
        public CONNECTION con = new CONNECTION();
        bool DangSuaHoSo = false;
        int VeDangChon = -1;
        public frmHomeKhachHang()
        {
            InitializeComponent();
        }
        public void xemve()
        {
            tab_Home.SelectedTab = tab_XemVe;
        }
        public void LoadHoSo()
        {
            DataTable KH = con.LoadHoSoKhachHang();
            txt_Ten.Text = KH.Rows[0]["TenKhachHang"].ToString();
            txt_GioiTinh.Text = KH.Rows[0]["GioiTinh"].ToString();
            txt_Email.Text = KH.Rows[0]["Email"].ToString();
            txt_DiaChi.Text = KH.Rows[0]["SoNha"].ToString() + " " + KH.Rows[0]["Duong"].ToString() + ", " + KH.Rows[0]["PhuongXa"].ToString() + ", " + KH.Rows[0]["QuanHuyen"].ToString() + ", " + KH.Rows[0]["TinhThanhPho"].ToString();
            DataTable SDT = con.LoadSoDienThoaiKhachHang();
            string s = "";
            for (int i = 0; i < SDT.Rows.Count; i++)
            {
                s += ", " + SDT.Rows[i]["SoDienThoai"].ToString();
            }
            txt_Sdt.Text = s.Remove(0, 2);
        }
        public void LoadVe(int i)
        {
            DataTable ve = con.LoadVeCuaToi(i);
            ve.Columns.Add("GioDi");
            ve.Columns.Add("GioDen");
            foreach (DataRow item in ve.Rows)
            {
                item["NgayDi"] = item["NgayDi"] != DBNull.Value ? Convert.ToDateTime(item["NgayDi"]).ToShortDateString() : string.Empty;

                string giodi = item["ThoiGianXuatPhat"] != DBNull.Value ? Convert.ToDateTime(item["ThoiGianXuatPhat"]).ToShortTimeString() : string.Empty;
                string gioden = item["ThoiGianDenDuKien"] != DBNull.Value ? Convert.ToDateTime(item["ThoiGianDenDuKien"]).ToShortTimeString() : string.Empty;

                item["GioDi"] = giodi;
                item["GioDen"] = gioden;
            }

            ve.Columns.Remove("ThoiGianXuatPhat");
            ve.Columns.Remove("ThoiGianDenDuKien");
            dGV_XemVe.DataSource = ve;
        }


        private void frmHomeKhachHang_Load(object sender, EventArgs e)
        {
            cboDiemDi.DataSource = con.LoadComboboxDiemDi();
            cboDiemDi.ValueMember = "DiemDi";
            cboDiemDen.DataSource = con.LoadComboboxDiemDen();
            cboDiemDen.ValueMember = "DiemDen";
            dtpNgayDi.MinDate = DateTime.Now;
            LoadHoSo();
            cboLocVe.Items.Add("Tất cả");
            cboLocVe.Items.Add("Chưa sửa dụng");
            cboLocVe.Items.Add("Đã sử dụng");
            cboLocVe.SelectedIndex = 0;
            LoadVe(0);
            LoadChuyen();
        }
        public void TimChuyen()
        {
            string DiemDi = cboDiemDi.SelectedValue.ToString();
            string DiemDen = cboDiemDen.SelectedValue.ToString();
            string NgayDi = dtpNgayDi.Value.ToShortDateString();
            dGV_DatVe.AllowUserToAddRows = false;
            while (dGV_DatVe.Rows.Count > 0)
            {
                dGV_DatVe.Rows.RemoveAt(dGV_DatVe.Rows.Count - 1);
            }
            //dGV_DatVe.AllowUserToAddRows = true;
            dGV_DatVe.DataSource = con.TimChuyenXe(DiemDi, DiemDen, NgayDi);
            //dGV_DatVe.AllowUserToAddRows = false;
        }
        public void LoadChuyen()
        {
            dGV_DatVe.AllowUserToAddRows = false;
            while (dGV_DatVe.Rows.Count > 0)
            {
                dGV_DatVe.Rows.RemoveAt(dGV_DatVe.Rows.Count - 1);
            }
            //dGV_DatVe.AllowUserToAddRows = true;
            dGV_DatVe.DataSource = con.LoadChuyen();
            //dGV_DatVe.AllowUserToAddRows = false;
        }
        public void btn_TimKiem_Click(object sender, EventArgs e)
        {
            TimChuyen();
        }

        public void dGV_DatVe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                string chonchuyen = dGV_DatVe.Rows[index].Cells[0].Value.ToString();
                con.ChonChuyen(chonchuyen);
                int TongGhe = Convert.ToInt32(dGV_DatVe.Rows[index].Cells[6].Value);
                if (TongGhe == 8)
                {
                    Form from8 = new frmChonGhe_8();
                    from8.ShowDialog();
                }
                else
                {
                    Form from11 = new frmChonGhe_11();
                    from11.ShowDialog();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CONNECTION.ThanhToanXong)
            {
                tab_Home.SelectedTab = tab_XemVe;
                LoadVe(0);
                LoadChuyen();
                CONNECTION.VeDangChon = "";
                CONNECTION.ThanhToanXong = false;
            }
            if (CONNECTION.SuaXong)
            {
                CONNECTION.SuaXong = false; ;
                LoadHoSo();
                LoadVe(0);
            }
            if (CONNECTION.SuaXongV)
            {
                CONNECTION.SuaXongV = false; ;
                
                LoadVe(0);
            }
            if (lblSale.BackColor == Color.Red) lblSale.BackColor = Color.Yellow;
            else lblSale.BackColor = Color.Red;
            if (lblSale.ForeColor == Color.White) lblSale.ForeColor = Color.Red;
            else lblSale.ForeColor = Color.White;

            if (CONNECTION.VeDangChon.Length > 0)
            {
                btnThongTinMaVe.Text = CONNECTION.VeDangChon;
                btnHienThongTinVe.Text = con.XemThongTinVe(CONNECTION.VeDangChon);
                CONNECTION.ThongTinVeDangChon = con.XemThongTinVe(CONNECTION.VeDangChon);
            }
            else
            {
                btnThongTinMaVe.Text = "VÉ";
                btnHienThongTinVe.Text = "";
            }
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            CONNECTION.MaKhachHang = "";
            CONNECTION.ChuyenDangChon = "";
            CONNECTION.GheDangChon = "";
            CONNECTION.DiemDon = "";
            CONNECTION.DiemTra = "";
            CONNECTION.GiaVeDangChon = 0;
            CONNECTION.DsGheDangChon = new List<string>();
            Form dn = new frmDangNhap();
            dn.Show();
        }

        private void btnSuaTen_Click(object sender, EventArgs e)
        {
            if (!DangSuaHoSo)
            {
                DangSuaHoSo = true;
                btnSuaDiaChi.Enabled = btnSuaEmail.Enabled = btnSuaGioiTinh.Enabled = btnSuaSDT.Enabled = false;
                Control ctrl = (Control)sender;
                ctrl.Text = "Lưu";
                txt_Ten.ReadOnly = false;
                txt_Ten.BackColor = Color.White;
                txt_Ten.Focus();
            }
            else
            {
                DangSuaHoSo = false;
                Control ctrl = (Control)sender;
                ctrl.Text = "Sửa";
                txt_Ten.ReadOnly = true;
                txt_Ten.BackColor = SystemColors.ActiveCaption;
                string sql = "update KHACHHANG set TenKhachHang = N'"+txt_Ten.Text+"' where MaKhachHang = '"+CONNECTION.MaKhachHang+"'";
                string kq = con.TruyvanInsertDeleteUpdate(sql);
                MessageBox.Show(kq);
                btnSuaDiaChi.Enabled = btnSuaEmail.Enabled = btnSuaGioiTinh.Enabled = btnSuaSDT.Enabled = btnSuaTen.Enabled = true;
            }
        }

        private void btnSuaGioiTinh_Click(object sender, EventArgs e)
        {
            if (!DangSuaHoSo)
            {
                DangSuaHoSo = true;
                btnSuaDiaChi.Enabled = btnSuaEmail.Enabled = btnSuaSDT.Enabled = btnSuaTen.Enabled = false;
                Control ctrl = (Control)sender;
                ctrl.Text = "Lưu";
                txt_GioiTinh.ReadOnly = false;
                txt_GioiTinh.BackColor = Color.White;
                txt_GioiTinh.Focus();
            }
            else
            {
                DangSuaHoSo = false;
                Control ctrl = (Control)sender;
                ctrl.Text = "Sửa";
                txt_GioiTinh.ReadOnly = true;
                txt_GioiTinh.BackColor = SystemColors.ActiveCaption;
                if(String.Compare("Nam", txt_GioiTinh.Text) != 0 && String.Compare("nam", txt_GioiTinh.Text) != 0 && String.Compare("Nữ", txt_GioiTinh.Text) != 0 && String.Compare("nữ", txt_GioiTinh.Text) != 0)
                {
                    MessageBox.Show("Giới tính nhập Nam hoặc Nữ");
                    CONNECTION.SuaXong = true;
                    btnSuaDiaChi.Enabled = btnSuaEmail.Enabled = btnSuaGioiTinh.Enabled = btnSuaSDT.Enabled = btnSuaTen.Enabled = true;
                    return;
                }
                string sql = "update KHACHHANG set GioiTinh = N'" + txt_GioiTinh.Text + "' where MaKhachHang = '" + CONNECTION.MaKhachHang + "'";
                string kq = con.TruyvanInsertDeleteUpdate(sql);
                MessageBox.Show(kq);
                btnSuaDiaChi.Enabled = btnSuaEmail.Enabled = btnSuaGioiTinh.Enabled = btnSuaSDT.Enabled = btnSuaTen.Enabled = true;
            }
        }

        private void btnSuaEmail_Click(object sender, EventArgs e)
        {
            if (!DangSuaHoSo)
            {
                DangSuaHoSo = true;
                btnSuaDiaChi.Enabled = btnSuaGioiTinh.Enabled = btnSuaSDT.Enabled = btnSuaTen.Enabled = false;
                Control ctrl = (Control)sender;
                ctrl.Text = "Lưu";
                txt_Email.ReadOnly = false;
                txt_Email.BackColor = Color.White;
                txt_Email.Focus();
            }
            else
            {
                DangSuaHoSo = false;
                Control ctrl = (Control)sender;
                ctrl.Text = "Sửa";
                txt_Email.ReadOnly = true;
                txt_Email.BackColor = SystemColors.ActiveCaption;
                if (!txt_Email.Text.Contains("@"))
                {
                    MessageBox.Show("Email sai cú pháp");
                    CONNECTION.SuaXong = true;
                    btnSuaDiaChi.Enabled = btnSuaEmail.Enabled = btnSuaGioiTinh.Enabled = btnSuaSDT.Enabled = btnSuaTen.Enabled = true;
                    return;
                }
                string sql = "update KHACHHANG set Email = N'" + txt_Email.Text + "' where MaKhachHang = '" + CONNECTION.MaKhachHang + "'";
                string kq = con.TruyvanInsertDeleteUpdate(sql);
                MessageBox.Show(kq);
                btnSuaDiaChi.Enabled = btnSuaEmail.Enabled = btnSuaGioiTinh.Enabled = btnSuaSDT.Enabled = btnSuaTen.Enabled = true;
            }
        }

        private void btnSuaDiaChi_Click(object sender, EventArgs e)
        {
            Form suaDC = new frmSuaDiaChi();
            suaDC.ShowDialog();
        }

        private void btnSuaSDT_Click(object sender, EventArgs e)
        {
            Form suaSDT = new frmSuaSoDienThoai();
            suaSDT.ShowDialog();
        }

        private void cboLocVe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLocVe.SelectedIndex == 0) LoadVe(0);
            else if (cboLocVe.SelectedIndex == 1) LoadVe(1);
            else LoadVe(-1);
        }

        public void dGV_XemVe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int i = e.RowIndex;
                VeDangChon = i;
                //string s="";
                //s += dGV_XemVe.Rows[i].Cells["TenTuyenXe"].Value.ToString();
                //s += ", Ngày: " + dGV_XemVe.Rows[i].Cells["NgayDi"].Value.ToString();
                //s += "\nThời Gian: " + dGV_XemVe.Rows[i].Cells["GioDi"].Value.ToString();
                //s += " - " + dGV_XemVe.Rows[i].Cells["GioDen"].Value.ToString();
                //s += "\nĐiểm Đón: " + dGV_XemVe.Rows[i].Cells["DiemDon"].Value.ToString();
                //s += "; Điểm Trả: " + dGV_XemVe.Rows[i].Cells["DiemTra"].Value.ToString();
                //s += "\nTiền: " + dGV_XemVe.Rows[i].Cells["GiaTien"].Value.ToString();
                //s += ", TÌNH TRẠNG VÉ: " + dGV_XemVe.Rows[i].Cells["TinhTrang"].Value.ToString();
                string mave = dGV_XemVe.Rows[i].Cells["MaVeXe"].Value.ToString();
                CONNECTION.VeDangChon = mave;
                //CONNECTION.ThongTinVeDangChon = s;
            }
        }

        public void btn_Huy_Click(object sender, EventArgs e)
        {
            //int i = VeDangChon;
            //string s="";
            //s += dGV_XemVe.Rows[i].Cells["TenTuyenXe"].Value.ToString();
            //s += "\nNgày: " + dGV_XemVe.Rows[i].Cells["NgayDi"].Value.ToString();
            //s += "\nThời Gian: " + dGV_XemVe.Rows[i].Cells["GioDi"].Value.ToString();
            //s += " - " + dGV_XemVe.Rows[i].Cells["GioDen"].Value.ToString();
            //s += "\nĐiểm Đón: " + dGV_XemVe.Rows[i].Cells["DiemDon"].Value.ToString();
            //s += "\nĐiểm Trả: " + dGV_XemVe.Rows[i].Cells["DiemTra"].Value.ToString();
            //s += "\nTiền: " + dGV_XemVe.Rows[i].Cells["GiaTien"].Value.ToString();
            //s += "\nTÌNH TRẠNG VÉ: " + dGV_XemVe.Rows[i].Cells["TinhTrang"].Value.ToString();
            //string mave = dGV_XemVe.Rows[i].Cells["MaVeXe"].Value.ToString();
            //CONNECTION.VeDangChon = mave;
            //CONNECTION.ThongTinVeDangChon = s;
            string s = CONNECTION.VeDangChon;
            if (CONNECTION.VeDangChon == "")
            {
                MessageBox.Show("Chưa chọn vé.");
                return;
            }
            DialogResult r = MessageBox.Show("Bạn có muốn xóa vé: \n" + s, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (r == DialogResult.OK)
            {
                
                string sql = "delete CHITIETVEXE where MaVeXe='"+CONNECTION.VeDangChon+"' delete VEXE where MaVeXe = '"+CONNECTION.VeDangChon+"'";
                string kq = con.TruyvanInsertDeleteUpdate(sql);
                CONNECTION.SuaXong = true;
                CONNECTION.VeDangChon = "";
                LoadChuyen();
                MessageBox.Show(kq);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (dGV_XemVe.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Bạn chưa chọn vé để sửa");
                return;
            }
            Form sua = new frmSuaVe();
            sua.ShowDialog();
        }
    }
}
