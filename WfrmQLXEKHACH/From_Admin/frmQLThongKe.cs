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
    public partial class frmQLThongKe : Form
    {
        public frmQLThongKe()
        {
            InitializeComponent();
        }
        public Form activeform = null;
        public void KichHoatBtn(Control ctr)
        {
            btnVe.BackColor = btnTaiXe.BackColor = Color.DarkGreen;
            btnVe.ForeColor = btnTaiXe.ForeColor = Color.White;
            ctr.BackColor = Color.LightGreen;
            ctr.ForeColor = Color.OliveDrab;
        }
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
        private void btnTaiXe_Click(object sender, EventArgs e)
        {
            openCHildForm(new frmThongKeThongTinTaiXe());
            activeform = null;
            Control ctr = (Control)sender;
            KichHoatBtn(ctr);
        }

        private void frmQLThongKe_Load(object sender, EventArgs e)
        {
            openCHildForm(new frmThongKeThongTinTaiXe());
            activeform = null;
        }

        private void btnVe_Click(object sender, EventArgs e)
        {
            openCHildForm(new frmThongKeThongTinTaiXe());
            activeform = null;
            Control ctr = (Control)sender;
            KichHoatBtn(ctr);
        }
    }
}
