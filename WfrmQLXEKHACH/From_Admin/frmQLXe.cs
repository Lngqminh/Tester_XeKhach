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
    public partial class frmQLXe : Form
    {
        CONNECTION con = new CONNECTION();
        int flag = 0;
        public frmQLXe()
        {
            InitializeComponent();
        }
        void LoaddsXe()
        {
            dgvXe.DataSource = null;
            dgvXe.DataSource = con.Loadxe();
        }

        private void frmQLXe_Load(object sender, EventArgs e)
        {
            cboLoaixe.DataSource = con.LoadComboboxLoaiXe();
            cboLoaixe.DisplayMember = "TenLoaiXe";
            cboLoaixe.ValueMember = "MaLoaiXe";
            LoaddsXe();
            btn_Sua.Enabled = btn_Luu.Enabled = btn_Xoa.Enabled = false;
            txt_MaXe.Enabled = txt_BienSoXe.Enabled = false;
            cboLoaixe.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CONNECTION.SuaXongX)
            {
                LoaddsXe();
                CONNECTION.SuaXongX = false;
            }
        }

        private void dgvXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Xoa.Enabled = btn_Sua.Enabled = true;
            btn_Luu.Enabled = false;
            txt_BienSoXe.Enabled = txt_MaXe.Enabled = cboLoaixe.Enabled = false;
            txt_MaXe.Text = dgvXe.SelectedRows[0].Cells[0].Value.ToString();
            txt_BienSoXe.Text = dgvXe.SelectedRows[0].Cells[1].Value.ToString();
            cboLoaixe.SelectedValue = dgvXe.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            flag = 1;
            btn_Luu.Enabled = true;
            btn_Sua.Enabled = btn_Xoa.Enabled = false;
            txt_MaXe.Enabled = txt_BienSoXe.Enabled = cboLoaixe.Enabled = true;
            txt_MaXe.Clear();
            txt_MaXe.Focus();
            txt_BienSoXe.Clear();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            flag = 2;
            btn_Luu.Enabled = true;
            btn_Xoa.Enabled = false;
            txt_BienSoXe.Enabled = true;
            cboLoaixe.Enabled = true;
            txt_MaXe.Enabled = false;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string maxe = dgvXe.SelectedRows[0].Cells[0].Value.ToString();
            DialogResult r = MessageBox.Show("Bạn có muốn xóa xe " + maxe, "CẢNH BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (r == DialogResult.OK)
            {
                string sql = "delete XE where MaXe = '" + maxe + "'";
                string kq = con.TruyvanInsertDeleteUpdate(sql);
                MessageBox.Show(kq);
                CONNECTION.SuaXongX = true;
                txt_MaXe.Clear();
                txt_BienSoXe.Clear();
            }
            CONNECTION.SuaXongX = true;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                string sql = "insert into XE values ('" + txt_MaXe.Text + "', '" + txt_BienSoXe.Text + "', '" + cboLoaixe.SelectedValue.ToString() +"')";
                string kq = con.TruyvanInsertDeleteUpdate(sql);
                MessageBox.Show(kq);
                CONNECTION.SuaXongX = true;
                flag = 0;
            } else if (flag == 2)
            {
                string sql = "update XE set BienSoXe = '" + txt_BienSoXe.Text + "', MaLoaiXe = '" + cboLoaixe.SelectedValue.ToString() + "' where MaXe = '" + txt_MaXe.Text+"'";
                string kq = con.TruyvanInsertDeleteUpdate(sql);
                MessageBox.Show(kq);
                CONNECTION.SuaXongX = true;
                flag = 0;
            }
            btn_Xoa.Enabled = btn_Sua.Enabled = btn_Luu.Enabled = false;
            CONNECTION.SuaXongX = true;
        }
    }
}
