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
    public partial class frmQLTaiKhoan : Form
    {
        CONNECTION con = new CONNECTION();
        SqlDataAdapter da;
        DataTable dt;
        bool them, sua;
        public frmQLTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmQLTaiKhoan_Load(object sender, EventArgs e)
        {
            loadData();
            txt_Username.Enabled = txt_Pass.Enabled = false;
            btn_Them.Enabled = true;
            btn_Sua.Enabled = btn_Xoa.Enabled = btn_Luu.Enabled = false;
            them = sua = false;
        }

        void loadData()
        {
            string sql = "SELECT * FROM TK_ADMIN";
            da = new SqlDataAdapter(sql, con.connection);
            dt = new DataTable();
            da.Fill(dt);
            dGV_tkAdmin.DataSource = dt;
        }

        private void dGV_tkAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                txt_Username.Text = dGV_tkAdmin.Rows[index].Cells[0].Value.ToString();
                txt_Pass.Text = dGV_tkAdmin.Rows[index].Cells[1].Value.ToString();
            }
            btn_Them.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
            btn_Luu.Enabled = false;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            them = true;
            sua = false;
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_Luu.Enabled = true;
            txt_Username.Enabled = true;
            txt_Pass.Enabled = true;

            txt_Username.Clear();
            txt_Pass.Clear();
            txt_Username.Focus();
        }


        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if(them)
            {
                try
                {
                    if (String.IsNullOrEmpty(txt_Pass.Text) || String.IsNullOrEmpty(txt_Username.Text))
                    {
                        MessageBox.Show("Chưa nhập đầy đủ thông tin");
                        return;
                    }
                    if(con.ktTrungKhoa("TK_ADMIN", "username", txt_Username.Text))
                    {
                        MessageBox.Show("Uername đã tồn tại");
                        return;
                    }
                    if (con.connection.State == ConnectionState.Closed) con.connection.Open();
                    string sql = "INSERT INTO TK_ADMIN VALUES ('" + txt_Username.Text + "', '" + txt_Pass.Text + "')";
                    SqlCommand cmd = new SqlCommand(sql,con.connection);
                    cmd.ExecuteNonQuery();
                    if (con.connection.State == ConnectionState.Open) con.connection.Close();
                    MessageBox.Show("Bạn đã Thành Công!");
                    //txt_Username.Clear();
                    //txt_Pass.Clear();
                    //txt_Username.Focus();
                    loadData();
                    btn_Them.Enabled = true;
                    btn_Sua.Enabled = false;
                    btn_Xoa.Enabled = false;
                    btn_Luu.Enabled = false;
                }
                catch (Exception)
                {

                    MessageBox.Show("Them Thất Bại!");
                }
            }    
            else
            {
                try
                {
                    if (con.connection.State == ConnectionState.Closed) con.connection.Open();
                    if (String.IsNullOrEmpty(txt_Pass.Text))
                    {
                        MessageBox.Show("Password rỗng");
                        return;
                    }
                    string sql = "UPDATE TK_ADMIN SET MatKhau = '" + txt_Pass.Text + "' WHERE username = '" + txt_Username.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, con.connection);
                    cmd.ExecuteNonQuery();
                    if (con.connection.State == ConnectionState.Open) con.connection.Close();
                    MessageBox.Show("Bạn đã Thành Công!");
                    //txt_Username.Clear();
                    //txt_Pass.Clear();
                    //txt_Username.Focus();
                    loadData();
                    btn_Them.Enabled = true;
                    btn_Sua.Enabled = false;
                    btn_Xoa.Enabled = false;
                    btn_Luu.Enabled = false;
                }
                catch (Exception)
                {

                    MessageBox.Show("Bạn đã Thất Bại!");
                }
            }
            txt_Username.Clear();
            txt_Pass.Clear();
            txt_Pass.Enabled = txt_Username.Enabled = false;
            btn_Luu.Enabled = false;
            btn_Sua.Enabled = false;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            sua = true;
            them = false;
            txt_Username.Enabled = false;
            txt_Pass.Enabled = true;
            btn_Them.Enabled = true;
            btn_Luu.Enabled = true;
            btn_Xoa.Enabled = false;
            
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.connection.State == ConnectionState.Closed) con.connection.Open();
                string sql = "DELETE TK_ADMIN WHERE username = '" + txt_Username.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, con.connection);
                cmd.ExecuteNonQuery();
                if (con.connection.State == ConnectionState.Open) con.connection.Close();
                MessageBox.Show("Bạn đã Thành Công!");
                txt_Username.Clear();
                txt_Pass.Clear();
                txt_Username.Focus();
                loadData();

            }
            catch (Exception)
            {

                MessageBox.Show("Bạn đã Thất Bại!");
            }
            btn_Them.Enabled = true;
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_Luu.Enabled = false;
        }

    }
}
