using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WfrmQLXEKHACH
{
    public partial class frmSuaChuyenXe : Form
    {
        CONNECTION con = new CONNECTION();
        int flat;
        public frmSuaChuyenXe()
        {
            InitializeComponent();
        }

        private void frmSuaChuyenXe_Load(object sender, EventArgs e)
        {
            cboMaTuyenXe.DataSource = con.LoadComboboxTuyenXe();
            cboMaTuyenXe.DisplayMember = "MaTuyenXe";
            cboMaTuyenXe.ValueMember = "MaTuyenXe";

            cboMaXe.DataSource = con.LoadComboboxMaXe();
            cboMaXe.DisplayMember = "MaXe";
            cboMaXe.ValueMember = "MaXe";
            if (CONNECTION.ThemMoi == 1)
            {
                flat = 0;
                txt_MaCXe.Enabled = true;
                cboMaTuyenXe.Enabled = true;
                txt_GiaTien.Enabled = true;
                mTX_ThoiGianDen.Enabled = true;
                mTX_ThoiGianDi.Enabled = true;
                cboMaXe.Enabled = true;

                txt_GiaTien.Clear();
                txt_MaCXe.Clear();
                mTX_ThoiGianDen.Clear();
                mTX_ThoiGianDi.Clear();

                btn_Luu.Enabled = true;
                btn_Sua.Enabled = false;
                btn_Xoa.Enabled = false;

                lb_TenCXe.Text = "THÊM MỚI CHUYẾN XE";

            }

            else
            {
                flat = 1;
                
                LoadData();
            }    

        }

        void LoadData()
        {
            string sql = "SELECT * FROM CHUYENXE WHERE MaChuyenXe = '" + CONNECTION.MaChuyenXeSua + "' ";
            SqlDataAdapter da = new SqlDataAdapter(sql, con.connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cboMaTuyenXe.SelectedValue = dt.Rows[0]["MaTuyenXe"].ToString();
            txt_MaCXe.Text = dt.Rows[0]["MaChuyenXe"].ToString();
            cboMaXe.SelectedValue = dt.Rows[0]["MaXe"].ToString();
            string format2 = dt.Rows[0]["ThoiGianXuatPhat"].ToString();
            mTX_ThoiGianDi.Text = DateTime.Parse(format2).ToString("dd/MM/yyyy hh:mm");
            string format = dt.Rows[0]["ThoiGianDenDuKien"].ToString();
            mTX_ThoiGianDen.Text = DateTime.Parse(format).ToString("dd/MM/yyyy hh:mm");
            txt_GiaTien.Text = dt.Rows[0]["GiaTien"].ToString();
            txt_SoGheTrong.Text = dt.Rows[0]["SoGheTrong"].ToString();
            lb_TenCXe.Text = "Thông tin chuyến " + txt_MaCXe.Text;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if(flat == 0)
            {
                try
                {
                    if (con.connection.State == ConnectionState.Closed)
                        con.connection.Open();
                    string sqll = "select SucChuaVe from XE, LOAIXE where  XE.MaLoaiXe = LOAIXE.MaLoaiXe and XE.MaXe='" + cboMaXe.SelectedValue + "' ";
                    SqlCommand cmdd = new SqlCommand(sqll, con.connection);
                    string succhua = cmdd.ExecuteScalar().ToString();
                    string sql = "SET DATEFORMAT dmy INSERT INTO CHUYENXE(MaChuyenXe,MaTuyenXe,MaXe,GiaTien,ThoiGianXuatPhat,ThoiGianDenDuKien, SoGheTrong) VALUES" +
                        " ('"+txt_MaCXe.Text+"','"+cboMaTuyenXe.SelectedValue+"','"+cboMaXe.SelectedValue+"','"+txt_GiaTien.Text+"','"+mTX_ThoiGianDi.Text+"','"+mTX_ThoiGianDen.Text+"', "+succhua+")";
                    SqlCommand cmd = new SqlCommand(sql, con.connection);
                    cmd.ExecuteNonQuery();
                    if (con.connection.State == ConnectionState.Open)
                        con.connection.Close();
                    MessageBox.Show("Bạn đã Thành Công!");
                    //txt_GiaTien.Clear();
                    //txt_MaCXe.Clear();
                    //mTX_ThoiGianDen.Clear();
                    //mTX_ThoiGianDi.Clear();

                    //btn_Luu.Enabled = false;
                    //btn_Sua.Enabled = false;
                    //btn_Xoa.Enabled = false;

                    //LoadData();
                    CONNECTION.SuaXongC = true;
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bạn đã Thất Bại!");
                }
            } else
            {
                string sql = "set dateformat dmy update CHUYENXE set MaTuyenXe = '"+cboMaTuyenXe.SelectedValue+"', MaXe = '"+cboMaXe.SelectedValue+"', GiaTien = "+txt_GiaTien.Text+", ThoiGianXuatPhat = '"+mTX_ThoiGianDi.Text+"', ThoiGianDenDuKien = '"+mTX_ThoiGianDen.Text+"' where MaChuyenXe = '"+txt_MaCXe.Text+"'";
                string kq = con.TruyvanInsertDeleteUpdate(sql);
                MessageBox.Show(kq);
                CONNECTION.SuaXongC = true;
                this.Close();
            }
                
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            flat = 1;
            btn_Luu.Enabled = true;
            btn_Xoa.Enabled = false;

            txt_GiaTien.Enabled = true;
            mTX_ThoiGianDen.Enabled = true;
            mTX_ThoiGianDi.Enabled = true;
            cboMaXe.Enabled = true;
            cboMaTuyenXe.Enabled = true;

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = "delete CHUYENXE where MaChuyenXe = '"+txt_MaCXe.Text+"'";
            string kq = con.TruyvanInsertDeleteUpdate(sql);
            MessageBox.Show(kq);
            CONNECTION.SuaXongC = true;
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
