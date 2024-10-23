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
    public partial class frmSuaKhachHang : Form
    {
        CONNECTION con = new CONNECTION();
        public frmSuaKhachHang()
        {
            InitializeComponent();
        }

        private void frmSuaKhachHang_Load(object sender, EventArgs e)
        {
            lblMaKH.Text = CONNECTION.MaKhachHang;
            loadthongtin();
            loadLst();
        }
        void loadthongtin()
        {
            DataTable dtKH = con.LoadHoSoKhachHang();
            txtTenKH.Text = dtKH.Rows[0]["TenKhachHang"].ToString();
            txtGioiTinh.Text = dtKH.Rows[0]["GioiTinh"].ToString();
            txtEmail.Text = dtKH.Rows[0]["Email"].ToString();
            txtSoNha.Text = dtKH.Rows[0]["SoNha"].ToString();
            txtDuong.Text = dtKH.Rows[0]["Duong"].ToString();
            txtPhuongXa.Text = dtKH.Rows[0]["PhuongXa"].ToString();
            txtQuanHuyen.Text = dtKH.Rows[0]["QuanHuyen"].ToString();
            txtTinhTp.Text = dtKH.Rows[0]["TinhThanhPho"].ToString();
        }
        void loadLst()
        {
            lstSdt.Items.Clear();
            DataTable sdt = con.LoadSoDienThoaiKhachHang();
            for (int i = 0; i < sdt.Rows.Count; i++)
            {
                lstSdt.Items.Add(sdt.Rows[i]["SoDienThoai"].ToString());
            }
        }

        private void btnThemSdt_Click(object sender, EventArgs e)
        {
            if (txtSdt.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Chưa nhập số điện thoại");
                txtSdt.Focus();
                return;
            }
            else
            {
                lstSdt.Items.Add(txtSdt.Text);
                string sql = "insert into KHACHHANG_SODIENTHOAI values ('" + CONNECTION.MaKhachHang + "', '" + txtSdt.Text + "')";
                string kq = con.TruyvanInsertDeleteUpdate(sql);
                MessageBox.Show(kq);
                loadLst();
                txtSdt.Clear();
            }
        }

        private void btnXoaSdt_Click(object sender, EventArgs e)
        {
            if (lstSdt.Items.Count == 1)
            {
                MessageBox.Show("Khách hàng này chỉ còn 1 sđt. \nNếu xóa sđt này sẽ không thể đăng nhập. \nHãy thêm sđt khác trước khi xóa sđt này.");
                return;
            }
            if (lstSdt.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Chưa chọn số điện thoại");
                return;
            }
            else
            {
                string sql = "delete KHACHHANG_SODIENTHOAI where SoDienThoai = '" + lstSdt.SelectedItem.ToString() + "'";
                string kq = con.TruyvanInsertDeleteUpdate(sql);
                MessageBox.Show(kq);
                //lstSdt.Items.RemoveAt(lstSdt.SelectedIndex);
                loadLst();
            }
        }

        private void btnLuuThayDoi_Click(object sender, EventArgs e)
        {
            string sql = "update KHACHHANG set TenKhachHang = N'"+txtTenKH.Text+"', GioiTinh = N'"+txtGioiTinh.Text+"', Email = N'"+txtEmail.Text+"', SoNha = N'"+txtSoNha.Text+"', Duong = N'"+txtDuong.Text+"', PhuongXa = N'"+txtPhuongXa.Text+"', QuanHuyen = N'"+txtQuanHuyen.Text+"', TinhThanhPho = N'"+txtTinhTp.Text+"' where MaKhachHang = '"+CONNECTION.MaKhachHang+"'";
            string kq = con.TruyvanInsertDeleteUpdate(sql);
            MessageBox.Show(kq);
            loadthongtin();
            CONNECTION.SuaXongK = true;
            this.Close();
        }
    }
}
