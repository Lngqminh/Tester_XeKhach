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
    public partial class frmSuaTaiXe : Form
    {
        CONNECTION con = new CONNECTION();
        bool them = false;
        public frmSuaTaiXe()
        {
            InitializeComponent();
        }
        public string MaTXText
        {
            get { return txtMaTX.Text; }
            set { txtMaTX.Text = value; }
        }

        public string TenTXText
        {
            get { return txtTenTX.Text; }
            set { txtTenTX.Text = value; }
        }

        public string CCCDText
        {
            get { return txtCCCD.Text; }
            set { txtCCCD.Text = value; }
        }

        public string SoNhaText
        {
            get { return txtSoNha.Text; }
            set { txtSoNha.Text = value; }
        }

        public string DuongText
        {
            get { return txtDuong.Text; }
            set { txtDuong.Text = value; }
        }

        public string PhuongXaText
        {
            get { return txtPhuongXa.Text; }
            set { txtPhuongXa.Text = value; }
        }

        public string QuanHuyenText
        {
            get { return txtQuanHuyen.Text; }
            set { txtQuanHuyen.Text = value; }
        }

        public string TinhTpText
        {
            get { return txtTinhTp.Text; }
            set { txtTinhTp.Text = value; }
        }
        public void frmSuaTaiXe_Load(object sender, EventArgs e)
        {
            DataTable dt = con.LoadThongTinTaiXe();
            txtMaTX.Enabled = false;
            txtMaTX.Text = dt.Rows[0][0].ToString();
            txtTenTX.Text = dt.Rows[0][1].ToString();
            txtCCCD.Text = dt.Rows[0][2].ToString();
            txtSoNha.Text = dt.Rows[0][3].ToString();
            txtDuong.Text = dt.Rows[0][4].ToString();
            txtPhuongXa.Text = dt.Rows[0][5].ToString();
            txtQuanHuyen.Text = dt.Rows[0][6].ToString();
            txtTinhTp.Text = dt.Rows[0][7].ToString();
        }

        public void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete TAIXE where MaTaiXe = '" + CONNECTION.MaTaixeDangSua + "'";
            string kq = con.TruyvanInsertDeleteUpdate(sql);
            MessageBox.Show(kq);
            CONNECTION.SuaXongT = true;
            this.Close();
        }

        public void btnThemMoi_Click(object sender, EventArgs e)
        {
            txtMaTX.Enabled = true;
            them = true;
            txtMaTX.Clear();
            txtTenTX.Clear();
            txtCCCD.Clear();
            txtSoNha.Clear();
            txtDuong.Clear();
            txtPhuongXa.Clear();
            txtQuanHuyen.Clear();
            txtTinhTp.Clear();
        }

        public void btnLuuThayDoi_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMaTX.Text) || String.IsNullOrEmpty(txtTenTX.Text))
            {
                MessageBox.Show("Mã và tên không thể bỏ trống");
                return;
            }
            if (them)
            {
                if(con.ktTrungKhoa("TAIXE", "MaTaiXe", txtMaTX.Text))
                {
                    MessageBox.Show("Mã tài xế đã tồn tại");
                    return;
                }
                string sql = "insert into TAIXE values ('"+txtMaTX.Text+ "', N'" + txtTenTX.Text + "', '" + txtCCCD.Text + "', N'" + txtSoNha.Text + "', N'" + txtDuong.Text + "', N'" + txtPhuongXa.Text + "', N'" + txtQuanHuyen.Text + "', N'" + txtTinhTp.Text + "')";
                string kq = con.TruyvanInsertDeleteUpdate(sql);
                MessageBox.Show(kq);
                CONNECTION.SuaXongT = true;
                this.Close();
                return;
            } else
            {
                string sql = "update TAIXE set TenTaiXe = N'" + txtTenTX.Text + "', CCCD = '" + txtCCCD.Text + "', SoNha = N'" + txtSoNha.Text + "', Duong = N'" + txtDuong.Text + "', PhuongXa = N'" + txtPhuongXa.Text + "', QuanHuyen = N'" + txtQuanHuyen.Text + "', TinhThanhPho = N'" + txtTinhTp.Text + "' where MaTaiXe = '" + CONNECTION.MaTaixeDangSua + "'";
                string kq = con.TruyvanInsertDeleteUpdate(sql);
                MessageBox.Show(kq);
                CONNECTION.SuaXongT = true;
                this.Close();
                return;
            }
        }
    }
}
