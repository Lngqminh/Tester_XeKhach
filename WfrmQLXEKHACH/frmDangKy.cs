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
    public partial class frmDangKy : Form
    {
        CONNECTION con = new CONNECTION();
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void llbl_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form a = new frmDangNhap();
            a.Show();
        }

        private void llbl_DangNhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form a = new frmDangNhap();
            a.Show();
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSoDienThoai.Text))
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại");
                txtSoDienThoai.Focus();
                return;
            }
            if(String.IsNullOrEmpty(txtMatKhau.Text)||String.IsNullOrEmpty(txtXacNhanMatKhau.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu");
                txtMatKhau.Focus();
                return;
            }
            if (txtMatKhau.Text != txtXacNhanMatKhau.Text)
            {
                MessageBox.Show("Mật khẩu không khớp");
                txtMatKhau.Clear();
                txtXacNhanMatKhau.Clear();
                txtMatKhau.Focus();
                return;
            }
            if (con.ktTrungKhoa("KHACHHANG_SODIENTHOAI", "SoDienThoai", txtSoDienThoai.Text))
            {
                MessageBox.Show("Số điện thoại đã tồn tại");
                return;
            }
            string sql = "declare @mahientai varchar(5) select top 1 @mahientai = MaKhachHang from KHACHHANG order by MaKhachHang desc declare @slg int set @slg = right(@mahientai, 3) +1  declare @strslg varchar(3) = Convert(varchar(3), @slg) declare @makh varchar(5) set @makh = case len(@strslg) when 1 then 'KH00'+@strslg when 2 then 'KH0'+@strslg when 3 then 'KH'+@strslg end insert into KHACHHANG(MaKhachHang, TenKhachHang, GioiTinh) values (@makh, 'user', 'Nam') insert into TK_KHACHHANG values (@makh, '" + txtMatKhau.Text + "') insert into KHACHHANG_SODIENTHOAI values (@makh, '"+txtSoDienThoai.Text+"')";
            string kq = con.TruyvanInsertDeleteUpdate(sql);
            MessageBox.Show(kq);
            if (kq == "Thành công")
            {
                this.Close();
                Form dn = new frmDangNhap();
                dn.Show();
            }
        }

        private void txtXacNhanMatKhau_TextChanged(object sender, EventArgs e)
        {
            if (txtMatKhau.Text != txtXacNhanMatKhau.Text)
            {
                this.errorProvider1.SetError(txtXacNhanMatKhau, "Không khớp");
            }
            else this.errorProvider1.Clear();
        }
    }
}
