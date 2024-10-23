using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WfrmQLXEKHACH
{
    public partial class frmThongTinTaiXe : Form
    {
        CONNECTION con = new CONNECTION();
        bool kiemtra = false;
        public frmThongTinTaiXe()
        {
            InitializeComponent();
        }

        private void frmThongTinTaiXe_Load(object sender, EventArgs e)
        {
            DataTable dt = con.LoadThongTinTaiXeThongKe();
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
        private void InThongTin()
        {
            try
            {
                string downloadFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";
                string filePath = Path.Combine(downloadFolderPath, "ThongTinTaiXe.pdf");
                PrintDocument printDocument = new PrintDocument();
                printDocument.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
                printDocument.PrinterSettings.PrintToFile = true;
                printDocument.PrinterSettings.PrintFileName = filePath;
                printDocument.Print();
                kiemtra = true;
                if (File.Exists(filePath))
                {
                    using (FileStream fs = new FileStream(filePath, FileMode.Create))
                    {
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi!"+ex.Message);
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Brush brush = Brushes.Black;
            //logo
            Image image = global::WfrmQLXEKHACH.Properties.Resources._3SHOP;
            e.Graphics.DrawImage(image, new Point((e.PageBounds.Width - image.Width) / 2, 15));
            //Header
            string txtHeader = "THÔNG TIN NHÂN VIÊN: "+txtTenTX.Text+"";
            Font frontHeader = new Font("Arial", 28, FontStyle.Bold);
            e.Graphics.DrawString(txtHeader, frontHeader, brush, new Point(centerRow(e, txtHeader, frontHeader), 160));

            //Content

            string txtMTX = "Mã tài xế: "+txtMaTX.Text;
            Font frontMTX = new Font("Arial", 24, FontStyle.Bold);
            e.Graphics.DrawString(txtMTX, frontMTX, brush, new Point(20, 200));
            string txtTTX = "Tên tài xế: "+ txtTenTX.Text;
            Font frontTTX = new Font("Arial", 24, FontStyle.Bold);
            e.Graphics.DrawString(txtTTX, frontTTX, brush, new Point(20, 250));
            string txtcccd = "Số CCCD: "+ txtCCCD.Text;
            Font frontcccd = new Font("Arial", 24, FontStyle.Bold);
            e.Graphics.DrawString(txtcccd, frontcccd, brush, new Point(20, 300));
            string txtsonha = "Địa chỉ: "+txtSoNha.Text;
            Font frontsonha = new Font("Arial", 24, FontStyle.Bold);
            e.Graphics.DrawString(txtsonha, frontsonha, brush, new Point(20, 350));
            string txtduong = "Đường: "+ txtDuong.Text;
            Font frontduong = new Font("Arial", 24, FontStyle.Bold);
            e.Graphics.DrawString(txtduong, frontduong, brush, new Point(20, 400));
            string txtquanhuyen = "Quận/ Huyện: "+txtQuanHuyen.Text;
            Font frontquanhuyen = new Font("Arial", 24, FontStyle.Bold);
            e.Graphics.DrawString(txtquanhuyen, frontquanhuyen, brush, new Point(20, 450));
            string txttinhtp = "Tỉnh/ Thành Phố: "+txtTinhTp.Text;
            Font fronttinhtp = new Font("Arial", 24, FontStyle.Bold);
            e.Graphics.DrawString(txttinhtp, fronttinhtp, brush, new Point(20, 500));
            string ngayhientai = DateTime.Now.ToString("dd/MM/yyyy");
            string txtGioXuatphieu = "Thời gian in phiếu: "+ngayhientai;
            Font frontGioXuatphieu = new Font("Arial", 12, FontStyle.Regular|FontStyle.Italic);
            e.Graphics.DrawString(txtGioXuatphieu, frontGioXuatphieu, brush, new Point(10, 550));

        }
        private int centerRow(System.Drawing.Printing.PrintPageEventArgs e, string text, Font font)
        {
            int width = e.PageBounds.Width;
            int textWidth = (int)e.Graphics.MeasureString(text, font).Width;
            return (width - textWidth) / 2;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            InThongTin();
            if(kiemtra == true)
            {
                MessageBox.Show("Thực hiện xong!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }
    }
}
