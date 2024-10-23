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
    public partial class frmQLTaiXe : Form
    {
        CONNECTION con = new CONNECTION();
        SqlDataAdapter da;
        DataTable dt;
        int flat;
        public frmQLTaiXe()
        {
            InitializeComponent();
            
        }

        private void frmQLTaiXe_Load(object sender, EventArgs e)
        {
            loadData();
        }

        void loadData()
        {
            string sql = "SELECT * FROM TAIXE";
            da = new SqlDataAdapter(sql, con.connection);
            dt = new DataTable();
            da.Fill(dt);
            dGV_QLTaiXe.DataSource = dt;
        }

        private void dGV_QLTaiXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CONNECTION.MaTaixeDangSua = dGV_QLTaiXe.SelectedRows[0].Cells[0].Value.ToString();
            Form frm = new frmSuaTaiXe();
            frm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CONNECTION.SuaXongT)
            {
                dGV_QLTaiXe.DataSource = null;
                loadData();
                CONNECTION.SuaXongT = false;
            }
        }
    }
}
