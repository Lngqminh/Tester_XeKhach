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
    public partial class frmQLVe : Form
    {
        CONNECTION con = new CONNECTION();
        public frmQLVe()
        {
            InitializeComponent();
        }
        void LoadVe()
        {
            dgvVeXe.DataSource = null;
            string sql = "select VEXE.MaVeXe, MaChuyenXe, TenKhachHang, MaGhe, DiemDon, DiemTra from VEXE join CHITIETVEXE on VEXE.MaVeXe=CHITIETVEXE.MaVeXe join KHACHHANG on VEXE.MaKhachHang=KHACHHANG.MaKhachHang";
            dgvVeXe.DataSource = con.LoadVeXe(sql);
        }
        void LoadVe(string dk)
        {
            dgvVeXe.DataSource = null;
            string sql = "select VEXE.MaVeXe, MaChuyenXe, TenKhachHang, MaGhe, DiemDon, DiemTra from VEXE join CHITIETVEXE on VEXE.MaVeXe=CHITIETVEXE.MaVeXe join KHACHHANG on VEXE.MaKhachHang=KHACHHANG.MaKhachHang where MaChuyenXe = '"+dk+"'";
            dgvVeXe.DataSource = con.LoadVeXe(sql);
        }


        private void frmQLVe_Load(object sender, EventArgs e)
        {
            cboMaTuyen.DataSource = con.LoadComboboxMaTuyen();
            cboMaTuyen.DisplayMember = "MaTuyenXe";
            cboMaTuyen.ValueMember = "MaTuyenXe";
            cboMaTuyen.SelectedIndex = 0;
            cboMaChuyen.DataSource = con.LoadComboboxMaChuyen(cboMaTuyen.SelectedValue.ToString());
            cboMaChuyen.DisplayMember = "MaChuyenXe";
            cboMaChuyen.ValueMember = "MaChuyenXe";
            LoadVe();
            LoadVe(cboMaChuyen.SelectedValue.ToString());
        }

        

        private void btnLoc_Click(object sender, EventArgs e)
        {
            btn_Sua.Enabled = btn_Xoa.Enabled = false;
            dgvVeXe.DataSource = null;
            LoadVe(cboMaChuyen.SelectedValue.ToString());
        }

        private void cboMaTuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboMaChuyen.DataSource = con.LoadComboboxMaChuyen(cboMaTuyen.SelectedValue.ToString());
            cboMaChuyen.DisplayMember = "MaChuyenXe";
            cboMaChuyen.ValueMember = "MaChuyenXe";
            if (cboMaChuyen.Items.Count > 0)
                cboMaChuyen.SelectedIndex = 0;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string machuyen = dgvVeXe.SelectedRows[0].Cells[0].Value.ToString();
            string sql = "delete CHITIETVEXE where MaVeXe = '" + machuyen + "' delete VEXE where MaVeXe = '" + machuyen + "'";
            string kq = con.TruyvanInsertDeleteUpdate(sql);
            CONNECTION.SuaXongV = true;
            MessageBox.Show(kq);

        }

        private void dgvVeXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Sua.Enabled = btn_Xoa.Enabled = true;
            CONNECTION.SuaVeAdmin = dgvVeXe.SelectedRows[0].Cells[0].Value.ToString();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(CONNECTION.SuaXongV)
            {
                LoadVe(cboMaChuyen.SelectedValue.ToString());
                CONNECTION.SuaXongV = false;
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            Form frm = new frmSuaVeAdmin();
            frm.ShowDialog();
        }
    }
}
