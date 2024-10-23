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
    public partial class frmXacNhanThongTinVe : Form
    {
        CONNECTION con = new CONNECTION();
        public frmXacNhanThongTinVe()
        {
            InitializeComponent();
        }

        private void frmXacNhanThongTinVe_Load(object sender, EventArgs e)
        {
            List<string> lst = con.LoadXacNhanThongTinMuaVe();
            txt_Ten.Text = lst[0];
            txt_SoDienThoai.Text = lst[1];
            txt_Email.Text = lst[2];
            txt_Tuyen.Text = lst[3];
            txt_NgayDi.Text = lst[4];
            txt_GioDi.Text = lst[5];
            txtGioDen.Text = lst[6];
            txtGiaVe.Text = lst[7];
            string dsghe = "";
            CONNECTION.DsGheDangChon.ForEach(i => dsghe += ", " + i);
            txtdsGhe.Text = dsghe.Remove(0,1);
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_DiemDon.Text))
            {
                txt_DiemDon.Text = "Tại bến";
            }
            if (String.IsNullOrEmpty(txt_DiemTra.Text))
            {
                txt_DiemTra.Text = "Tại bến";
            }
            CONNECTION.DiemDon = txt_DiemDon.Text;
            CONNECTION.DiemTra = txt_DiemTra.Text;
            this.Close();
            Form tt = new frmThanhToan();
            tt.ShowDialog();
        }
    }
}
