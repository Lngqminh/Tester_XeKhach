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
    public partial class frmSuaVeAdmin : Form
    {
        CONNECTION con = new CONNECTION();
        public frmSuaVeAdmin()
        {
            InitializeComponent();
        }

        private void frmSuaVeAdmin_Load(object sender, EventArgs e)
        {
            lblMain.Text = "SỬA THÔNG TIN VÉ " + CONNECTION.SuaVeAdmin;
            btnThongTinMaVe.Text = CONNECTION.SuaVeAdmin;
            btnThongTinVe.Text = con.XemThongTinVe(CONNECTION.SuaVeAdmin);
            txtDon.Text = con.LayDiemDon(CONNECTION.SuaVeAdmin);
            txtTra.Text = con.LayDiemTra(CONNECTION.SuaVeAdmin);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtDon.Text))
            {
                txtDon.Text = "Tại bến";
            }
            if (String.IsNullOrEmpty(txtTra.Text))
            {
                txtTra.Text = "Tại bến";
            }
            string sql = "update CHITIETVEXE set DiemDon = N'" + txtDon.Text + "', DiemTra = N'" + txtTra.Text+"' where MaVeXe = '"+CONNECTION.SuaVeAdmin+"'";
            string kq = con.TruyvanInsertDeleteUpdate(sql);
            MessageBox.Show(kq);
            CONNECTION.SuaXongV = true;
            this.Close();
        }
    }
}
