﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WfrmQLXEKHACH
{
    public partial class frmHomeAdmin : Form
    {
        CONNECTION con = new CONNECTION();
        public frmHomeAdmin()
        {
            InitializeComponent();
            
        }

        private void frmHomeAdmin_Load(object sender, EventArgs e)
        {
            lb_TenSHOP.Text = CONNECTION.TKadmin.ToUpper();
        }
    }
}