using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WfrmQLXEKHACH
{
    public partial class frmThongKeThongTinTaiXe : Form
    {

        CONNECTION con = new CONNECTION();
        SqlDataAdapter da;
        DataTable dt;
        int flat;
        public frmThongKeThongTinTaiXe()
        {
            InitializeComponent();

        }
        void loadData()
        {
            string sql = "SELECT * FROM TAIXE";
            da = new SqlDataAdapter(sql, con.connection);
            dt = new DataTable();
            da.Fill(dt);
            dgvTaiXe.DataSource = dt;
        }
        private void frmThongKeThongTinTaiXe_Load(object sender, EventArgs e)
        {
            loadData();
            lbSoLuong.Text = dt.Rows.Count.ToString();

        }

        private void dgvTaiXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CONNECTION.MaTaiXeThongKe = dgvTaiXe.SelectedRows[0].Cells[0].Value.ToString();
            Form frm = new frmThongTinTaiXe();
            frm.ShowDialog();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument1;
            printPreviewDialog.ShowDialog();
            this.loadData();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            DrawDataGridView(dgvTaiXe, e.Graphics, e.MarginBounds);
        }
        private void DrawDataGridView(DataGridView dgv, Graphics g, Rectangle bounds)
        {
            int height = dgv.ColumnHeadersHeight;

            foreach (DataGridViewRow row in dgv.Rows)
            {
                height += row.Height;
            }

            if (height > bounds.Height)
            {
                dgv.Height = bounds.Height;
            }
            else
            {
                dgv.Height = height;
            }

            Bitmap bmp = new Bitmap(dgv.Width, dgv.Height);
            dgv.DrawToBitmap(bmp, new Rectangle(0, 0, dgv.Width, dgv.Height));
            Brush brush = Brushes.Black;
            g.DrawImage(bmp, bounds.Location);
            
        }
      
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "TenTaiXe LIKE '%"+txtSearch.Text+"%'";
            dgvTaiXe.DataSource = dv.ToTable();
        }
    }
}
