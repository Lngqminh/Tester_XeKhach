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
    public partial class frmThanhToan : Form
    {
        CONNECTION con = new CONNECTION();
        public frmThanhToan()
        {
            InitializeComponent();
        }

        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            lbl_GiaTien.Text = String.Format("{0:#,##0} VND",(CONNECTION.GiaVeDangChon * CONNECTION.DsGheDangChon.Count()).ToString());
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            con.DatVe();
            CONNECTION.ThanhToanXong = true;
            this.Close();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
