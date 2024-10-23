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
    public partial class frmSuaSoDienThoai : Form
    {
        CONNECTION con = new CONNECTION();
        public frmSuaSoDienThoai()
        {
            InitializeComponent();
        }

        private void txtSdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                this.errorProvider1.SetError(txtSdt, "Chi cho phep nhap so");
            }
            else this.errorProvider1.Clear();
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

        private void frmSuaSoDienThoai_Load(object sender, EventArgs e)
        {
            loadLst();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            foreach (var i in lstSdt.Items)
            {
                if (i.ToString() == txtSdt.Text)
                {
                    MessageBox.Show("Số điện thoại đã tồn tại");
                    return;
                }
            }
            if (txtSdt.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Bạn chưa nhạp số điện thoại");
                return;
            }
            if (txtSdt.Text.Trim().Length < 10)
            {
                DialogResult r = MessageBox.Show("Bạn có chắc muốn thêm số điện thoại " + txtSdt.Text.Trim().Length.ToString() + " số?", "Cảnh báo", MessageBoxButtons.OKCancel);
                if (r != DialogResult.OK)
                {
                    MessageBox.Show("Thất bại");
                    return;
                }
            }
            string sql = "insert into KHACHHANG_SODIENTHOAI values ('" + CONNECTION.MaKhachHang + "', '" + txtSdt.Text + "')";
            string kq = con.TruyvanInsertDeleteUpdate(sql);
            MessageBox.Show(kq);
            loadLst();
            CONNECTION.SuaXong = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstSdt.Items.Count == 1)
            {
                MessageBox.Show("Bạn chỉ còn 1 sđt. \nNếu xóa sđt này sẽ không thể đăng nhập. \nHãy thêm sđt khác trước khi xóa sđt này.");
                return;
            }
            if (lstSdt.SelectedItems.Count>0)
            {
                DialogResult r = MessageBox.Show("Bạn có chắc muốn xóa số điện thoại " + lstSdt.SelectedItem.ToString() + " không?", "Cảnh báo", MessageBoxButtons.OKCancel);
                if (r != DialogResult.OK)
                {
                    MessageBox.Show("Thất bại");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn sđt để xóa");
                return;
            }
            string sql = "delete KHACHHANG_SODIENTHOAI where MaKhachHang = '"+CONNECTION.MaKhachHang+"' and SoDienThoai = '" + lstSdt.SelectedItem.ToString() + "'";
            string kq = con.TruyvanInsertDeleteUpdate(sql);
            MessageBox.Show(kq);
            lstSdt.Items.Remove(lstSdt.SelectedItem);
            CONNECTION.SuaXong = true;
        }
    }
}
