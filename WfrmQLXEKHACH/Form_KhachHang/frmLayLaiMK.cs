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
    public partial class frmLayLaiMK : Form
    {
        CONNECTION con = new CONNECTION();
        public frmLayLaiMK()
        {
            InitializeComponent();
        }

        private void llbl_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form a = new frmDangNhap();
            this.Hide();
            a.Show();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                this.errorProvider1.SetError(txtSdt, "Only Number");
            }
            else this.errorProvider1.Clear();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtSdt.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập số điện thoại");
                return;
            }
            MessageBox.Show("Mật khẩu đã gửi về điện thoại của bạn. Mật khẩu là: "+con.LayLaiMatKhau(txtSdt.Text));
            this.Close();
        }

        private void frmLayLaiMK_Load(object sender, EventArgs e)
        {
            txtSdt.Focus();
        }
    }
}
