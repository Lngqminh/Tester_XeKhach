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
    public partial class frmThongKeThongTinVe : Form
    {
        CONNECTION con = new CONNECTION();
        public frmThongKeThongTinVe()
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
            string sql = "select VEXE.MaVeXe, MaChuyenXe, TenKhachHang, MaGhe, DiemDon, DiemTra from VEXE join CHITIETVEXE on VEXE.MaVeXe=CHITIETVEXE.MaVeXe join KHACHHANG on VEXE.MaKhachHang=KHACHHANG.MaKhachHang where MaChuyenXe = '" + dk + "'";
            dgvVeXe.DataSource = con.LoadVeXe(sql);
        }

        private void frmThongKeThongTinVe_Load(object sender, EventArgs e)
        {
            LoadVe();
        }

        private void dgvVeXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
