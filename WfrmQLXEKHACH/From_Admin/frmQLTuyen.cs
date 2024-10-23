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
    public partial class frmQLTuyen : Form
    {
        CONNECTION con = new CONNECTION();
        SqlDataAdapter da;
        DataTable dt;
        int flat;

        public frmQLTuyen()
        {
            InitializeComponent();
        }

        private void frmQLTuyen_Load(object sender, EventArgs e)
        {
            loadData();
        }

        void loadData()
        {
            string sql = "SELECT * FROM TUYENXE";
            da = new SqlDataAdapter(sql, con.connection);
            dt = new DataTable();
            da.Fill(dt);
            dGV_QLTX.DataSource = dt;

        }

        void clearData()
        {
            txt_TenTX.Clear();
            txt_DiemDi.Clear();
            txt_DiemDen.Clear();
            txt_KhoangCach.Clear();

        }

        private void dGV_QLTX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0)
            {
                int index = e.RowIndex;
                string MaTX = dGV_QLTX.Rows[index].Cells[0].Value.ToString();
                txt_TenTX.Text = dGV_QLTX.Rows[index].Cells[1].Value.ToString();
                txt_DiemDi.Text = dGV_QLTX.Rows[index].Cells[2].Value.ToString();
                txt_DiemDen.Text = dGV_QLTX.Rows[index].Cells[3].Value.ToString();
                txt_KhoangCach.Text = dGV_QLTX.Rows[index].Cells[4].Value.ToString();
            }

            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
            btn_Luu.Enabled = false;
            
            txt_TenTX.Enabled = false;
            txt_DiemDi.Enabled = false;
            txt_DiemDen.Enabled = false;
            txt_KhoangCach.Enabled = false;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            btn_Luu.Enabled = true;
            txt_TenTX.Enabled = true;
            txt_DiemDi.Enabled = true;
            txt_DiemDen.Enabled = true;
            txt_KhoangCach.Enabled = true;
            flat = 0;
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            clearData();

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            txt_TenTX.Enabled = true;
            txt_DiemDi.Enabled = true;
            txt_DiemDen.Enabled = true;
            txt_KhoangCach.Enabled = true;
            btn_Luu.Enabled = true;
            btn_Xoa.Enabled = false;
            flat = 1;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string LayMaTX = "SELECT MaTuyenXe FROM TUYENXE ORDER BY MaTuyenXe DESC";
            da = new SqlDataAdapter(LayMaTX, con.connection);
            dt = new DataTable();
            da.Fill(dt);
            string s = dt.Rows[0]["MaTuyenXe"].ToString();
            int num = int.Parse(s.Substring(3)) + 1;
            string MaTX = "T000" + num.ToString();

            if(flat == 0)
            {
                try
                {
                    if (con.connection.State == ConnectionState.Closed)
                        con.connection.Open();
                    if(String.IsNullOrEmpty(txt_TenTX.Text)||String.IsNullOrEmpty(txt_DiemDi.Text) || String.IsNullOrEmpty(txt_DiemDen.Text) || String.IsNullOrEmpty(txt_KhoangCach.Text))
                    {
                        MessageBox.Show("Vui lòng nhập đủ thông tin");
                        return;
                    }
                    string sql = "INSERT INTO TUYENXE VALUES ('" + MaTX + "',N'" + txt_TenTX.Text + "' ,N'" + txt_DiemDi.Text + "', N'" + txt_DiemDen.Text + "', '" + txt_KhoangCach.Text + "')";
                    SqlCommand cmd = new SqlCommand(sql, con.connection);
                    cmd.ExecuteNonQuery();
                    if (con.connection.State == ConnectionState.Open)
                        con.connection.Close();
                    MessageBox.Show("Bạn đã Thành Công!");
                    clearData();
                    loadData();
                    btn_Luu.Enabled = false;
                    btn_Sua.Enabled = false;
                    btn_Xoa.Enabled = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Bạn đã Thất Bại!");
                }
            }

            int index = dGV_QLTX.CurrentRow.Index;
            string MaTX2 = dGV_QLTX.Rows[index].Cells[0].Value.ToString();
            
            if(flat == 1)
            {
                try
                {
                    if (con.connection.State == ConnectionState.Closed)
                        con.connection.Open();
                    string sql = "UPDATE TUYENXE SET TenTuyenXe = N'" + txt_TenTX.Text + "' , DiemDi = N'" + txt_DiemDi.Text + "', DiemDen = N'" + txt_DiemDen.Text + "', KhoangCach = '" + txt_KhoangCach.Text + "' WHERE MaTuyenXe = '"+MaTX2+"'";
                    SqlCommand cmd = new SqlCommand(sql, con.connection);
                    cmd.ExecuteNonQuery();
                    if (con.connection.State == ConnectionState.Open)
                        con.connection.Close();
                    MessageBox.Show("Bạn đã Thành Công!");
                    clearData();
                    loadData();
                    btn_Luu.Enabled = false;
                    btn_Sua.Enabled = false;
                    btn_Xoa.Enabled = false;

                }
                catch (Exception)
                {
                    MessageBox.Show("Bạn đã Thất Bại!");
                }
            }    

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            int index = dGV_QLTX.CurrentRow.Index;
            string MaTX2 = dGV_QLTX.Rows[index].Cells[0].Value.ToString();

            try
            {
                if (con.connection.State == ConnectionState.Closed)
                    con.connection.Open();
                string sql = "DELETE TUYENXE WHERE MaTuyenXe = '" + MaTX2 + "'";
                SqlCommand cmd = new SqlCommand(sql, con.connection);
                cmd.ExecuteNonQuery();
                if (con.connection.State == ConnectionState.Open)
                    con.connection.Close();
                MessageBox.Show("Bạn đã Thành Công!");
                clearData();
                loadData();
                btn_Sua.Enabled = false;
                btn_Xoa.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn đã Thất Bại!");
            }
        }

    }
}
