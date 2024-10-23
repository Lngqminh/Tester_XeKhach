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
    public partial class frmSuaDiaChi : Form
    {
        CONNECTION con = new CONNECTION();
        public frmSuaDiaChi()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = String.Format("update KHACHHANG set SoNha = N'{0}', Duong = N'{1}', PhuongXa = N'{2}', QuanHuyen = N'{3}', TinhThanhPho = N'{4}' where MaKhachHang = '{5}'", txtSoNha.Text, txtDuong.Text, txtPhuongXa.Text, txtQuanHuyen.Text, txtTinhThanhPho.Text, CONNECTION.MaKhachHang);
            string kq = con.TruyvanInsertDeleteUpdate(sql);
            CONNECTION.SuaXong = true;
            MessageBox.Show(kq);
            this.Close();
        }

        private void frmSuaDiaChi_Load(object sender, EventArgs e)
        {
            DataTable KH = con.LoadHoSoKhachHang();
            txtSoNha.Text = KH.Rows[0]["SoNha"].ToString();
            txtDuong.Text = KH.Rows[0]["Duong"].ToString();
            txtPhuongXa.Text = KH.Rows[0]["PhuongXa"].ToString();
            txtQuanHuyen.Text = KH.Rows[0]["QuanHuyen"].ToString();
            txtTinhThanhPho.Text = KH.Rows[0]["TinhThanhPho"].ToString();
        }
    }
}
