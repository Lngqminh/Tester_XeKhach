using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WfrmQLXEKHACH
{
    public partial class frmAboutUs : Form
    {
        Random rand = new Random();
        int number = 0;
        Color[] color = { Color.Navy, Color.SteelBlue, Color.DodgerBlue, Color.MidnightBlue, Color.DarkBlue, Color.MediumBlue, Color.Blue, Color.RoyalBlue, Color.CornflowerBlue, Color.Indigo };
        public frmAboutUs()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            number = rand.Next(0, 9);
            btnStart.BackColor = color[number];
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDuongDan.Text))
            {
                MessageBox.Show("Không có database để chạy phần mềm");
                txtDuongDan.Focus();
            }
            else
            {
                try
                {
                    CONNECTION.StrDATABASE = txtDuongDan.Text;
                    CONNECTION con = new CONNECTION();
                    if (con.connection.State == ConnectionState.Closed) con.connection.Open();
                    string sql = "select count(*) from KHACHHANG";
                    SqlCommand cmd = new SqlCommand(sql, con.connection);
                    int dem = (int)cmd.ExecuteScalar();
                    if (con.connection.State == ConnectionState.Open) con.connection.Close();
                    this.Hide();
                    Form DangNhap = new frmDangNhap();
                    DangNhap.Show();
                }
                catch
                {
                    MessageBox.Show("Database chạy không được");
                    txtDuongDan.Focus();
                }
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmAboutUs_Load(object sender, EventArgs e)
        {
            txtDuongDan.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDuongDan.Text = "Data Source=baono1111;Initial Catalog=QLXEKHACH;Integrated Security=True";
        }
    }
}
