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
    public partial class frmQLChuyen : Form
    {
        CONNECTION con = new CONNECTION();
        SqlDataAdapter da;
        DataTable dt;
        int flat;

        public frmQLChuyen()
        {
            InitializeComponent();
        }

        private void frmQLChuyen_Load(object sender, EventArgs e)
        {
            loadData();
        }

        void loadData()
        {
            string sql = "SELECT * FROM CHUYENXE";
            da = new SqlDataAdapter(sql, con.connection);
            dt = new DataTable();
            da.Fill(dt);
            dGV_QLCXE.DataSource = dt;
        }

        private void dGV_QLCXE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                string MaTX = dGV_QLCXE.Rows[index].Cells[0].Value.ToString();
                CONNECTION.MaChuyenXeSua = MaTX;
                CONNECTION.ThemMoi = 0;
                frmSuaChuyenXe SuaChuyenXe = new frmSuaChuyenXe();
                SuaChuyenXe.ShowDialog();
                

            }    
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            CONNECTION.ThemMoi = 1;
            frmSuaChuyenXe SuaChuyenXe = new frmSuaChuyenXe();
            SuaChuyenXe.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CONNECTION.SuaXongC)
            {
                loadData();
                CONNECTION.SuaXongC = false;
            }
        }

        
    }
}
