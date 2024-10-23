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
    public partial class frmKhungHomeAdmin : Form
    {
        public frmKhungHomeAdmin()
        {
            InitializeComponent();
        }
        public Form activeform = null;
        public void openCHildForm(Form childform)
        {
            if (activeform != null)
            {
                activeform.Close();
            }
            else
            {
                activeform = childform;
                childform.TopLevel = false;
                childform.FormBorderStyle = FormBorderStyle.None;
                childform.Dock = DockStyle.Fill;
                panel1.Controls.Add(childform);
                panel1.Tag = childform;
                childform.BringToFront();
                childform.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm dd/mm/yyyy");
        }

        private void lblDangXuat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form dangnhap = new frmDangNhap();
            this.Hide();
            dangnhap.Show();
        }

        public void KichHoatBtn(Control ctr)
        {
            btnHome.BackColor = btnQLTaiKhoan.BackColor = btnQLKH.BackColor = btnQLTX.BackColor = btnQLTuyen.BackColor = btnQLChuyen.BackColor = btnQLVe.BackColor = btnQLXe.BackColor = btnThongKe.BackColor = Color.DarkGreen;
            btnHome.ForeColor = btnQLTaiKhoan.ForeColor = btnQLKH.ForeColor = btnQLTX.ForeColor = btnQLTuyen.ForeColor = btnQLChuyen.ForeColor = btnQLVe.ForeColor = btnQLXe.ForeColor = btnThongKe.ForeColor = Color.White;
            ctr.BackColor = Color.LightGreen;
            ctr.ForeColor = Color.OliveDrab;
        } 

        private void btnHome_Click(object sender, EventArgs e)
        {
            openCHildForm(new frmHomeAdmin());
            activeform = null;
            Control ctr = (Control)sender;
            KichHoatBtn(ctr);
        }

        private void frmHomeAdmin_Load(object sender, EventArgs e)
        {
            openCHildForm(new frmHomeAdmin());
            activeform = null;
        }

        private void btnQLTaiKhoan_Click(object sender, EventArgs e)
        {
            openCHildForm(new frmQLTaiKhoan());
            activeform = null;
            Control ctr = (Control)sender;
            KichHoatBtn(ctr);
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            openCHildForm(new frmQLKhachHang());
            activeform = null;
            Control ctr = (Control)sender;
            KichHoatBtn(ctr);
        }

        private void btnQLTX_Click(object sender, EventArgs e)
        {
            openCHildForm(new frmQLTaiXe());
            activeform = null;
            Control ctr = (Control)sender;
            KichHoatBtn(ctr);
        }

        private void btnQLTuyen_Click(object sender, EventArgs e)
        {
            openCHildForm(new frmQLTuyen());
            activeform = null;
            Control ctr = (Control)sender;
            KichHoatBtn(ctr);
        }

        private void btnQLChuyen_Click(object sender, EventArgs e)
        {
            openCHildForm(new frmQLChuyen());
            activeform = null;
            Control ctr = (Control)sender;
            KichHoatBtn(ctr);
        }

        private void btnQLVe_Click(object sender, EventArgs e)
        {
            openCHildForm(new frmQLVe());
            activeform = null;
            Control ctr = (Control)sender;
            KichHoatBtn(ctr);
        }

        private void btnQLXe_Click(object sender, EventArgs e)
        {
            openCHildForm(new frmQLXe());
            activeform = null;
            Control ctr = (Control)sender;
            KichHoatBtn(ctr);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            openCHildForm(new frmQLThongKe());
            activeform = null;
            Control ctr = (Control)sender;
            KichHoatBtn(ctr);
        }

    }
}
