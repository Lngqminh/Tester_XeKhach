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
    public partial class frmQLKhachHang : Form
    {
        CONNECTION con = new CONNECTION();
        SqlDataAdapter da;
        DataTable dt;
        SqlCommandBuilder sqlCommand;
        int flat;
        public frmQLKhachHang()
        {
            InitializeComponent();

        }

        private void frmQLKhachHang_Load(object sender, EventArgs e)
        {
            loadData();
        }

        void loadData()
        {
            string sql = "SELECT * FROM KHACHHANG";
            da = new SqlDataAdapter(sql, con.connection);
            dt = new DataTable();
            sqlCommand = new SqlCommandBuilder(da);
            da.InsertCommand = sqlCommand.GetInsertCommand();
            da.UpdateCommand = sqlCommand.GetUpdateCommand();
            da.DeleteCommand = sqlCommand.GetDeleteCommand();
            da.Fill(dt);
            dGV_QLKH.DataSource = null;
            dGV_QLKH.DataSource = dt;
            dGV_QLKH.ReadOnly = true;
        }

        private void dGV_QLKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CONNECTION.MaKhachHang = dGV_QLKH.SelectedRows[0].Cells[0].Value.ToString();
            Form a = new frmSuaKhachHang();
            a.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CONNECTION.SuaXongK)
            {
                loadData();
                CONNECTION.SuaXongK = false;
            }
        }

        
    }
}

