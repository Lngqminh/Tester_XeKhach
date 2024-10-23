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
    public partial class frmDangNhap : Form
    {
        CONNECTION con = new CONNECTION();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsername.Text))
            {
                this.errorProvider1.SetError(txtUsername, "Vui lòng nhập username");
                lblErr.Text = "Chưa nhập username";
                return;
            }
            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                this.errorProvider1.SetError(txtPassword, "Vui lòng nhập username");
                lblErr.Text = "Chưa nhập password";
                return;
            }
            if(chkAdmin.Checked)
            {
                if(con.DangNhapAdmin(txtUsername.Text, txtPassword.Text))
                {
                    CONNECTION.TKadmin = txtUsername.Text;
                    Form homeadmin = new frmKhungHomeAdmin();
                    this.Hide();
                    homeadmin.Show();
                }
                else
                {
                    lblErr.Text = "Tài khoản không tồn tại";
                }
            }
            else
            {
                if (con.DangNhapKhachHang(txtUsername.Text, txtPassword.Text))
                {
                    Form homekh = new frmHomeKhachHang();
                    this.Hide();
                    homekh.Show();
                }
                else
                {
                    lblErr.Text = "Tài khoản không tồn tại";
                }
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim().Length > 0)
            {
                this.errorProvider1.Clear();
                lblErr.Text = "";
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim().Length > 0)
            {
                this.errorProvider1.Clear();
                lblErr.Text = "";
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            lblErr.Text = "";
        }

        private void lblChuaCoTaiKhoan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form dangky = new frmDangKy();
            dangky.Show();
        }

        private void lblQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form quen = new frmLayLaiMK();
            quen.ShowDialog();
        }
    }
}
