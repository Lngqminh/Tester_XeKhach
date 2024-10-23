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
    public partial class frmSuaVe : Form
    {
        CONNECTION con = new CONNECTION();
        public frmSuaVe()
        {
            InitializeComponent();
        }

        private void frmSuaVe_Load(object sender, EventArgs e)
        {
            lblThongTinVe.Text = CONNECTION.ThongTinVeDangChon;
            txtDiemDonMoi.Text = con.LayDiemDon(CONNECTION.VeDangChon);
            txtDiemTraMoi.Text = con.LayDiemTra(CONNECTION.VeDangChon);
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDiemDonMoi.Text))
            {
                txtDiemDonMoi.Text = "Tại bến";
            }
            if (String.IsNullOrEmpty(txtDiemTraMoi.Text))
            {
                txtDiemTraMoi.Text = "Tại bến";
            }
            string sql = "update CHITIETVEXE set DiemDon = N'"+txtDiemDonMoi.Text+"', DiemTra = N'"+txtDiemTraMoi.Text+"' where MaVeXe = '"+CONNECTION.VeDangChon+"'";
            string kq = con.TruyvanInsertDeleteUpdate(sql);
            MessageBox.Show(kq);
            CONNECTION.SuaXongV = true;
            this.Close();
        }
    }
}
