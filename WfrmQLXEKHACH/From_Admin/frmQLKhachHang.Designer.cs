namespace WfrmQLXEKHACH
{
    partial class frmQLKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.dGV_QLKH = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_QLKH)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(294, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "QUẢN LÍ KHÁCH HÀNG";
            // 
            // dGV_QLKH
            // 
            this.dGV_QLKH.AllowUserToAddRows = false;
            this.dGV_QLKH.AllowUserToOrderColumns = true;
            this.dGV_QLKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_QLKH.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGV_QLKH.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dGV_QLKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_QLKH.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGV_QLKH.GridColor = System.Drawing.Color.Indigo;
            this.dGV_QLKH.Location = new System.Drawing.Point(13, 34);
            this.dGV_QLKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGV_QLKH.MultiSelect = false;
            this.dGV_QLKH.Name = "dGV_QLKH";
            this.dGV_QLKH.ReadOnly = true;
            this.dGV_QLKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_QLKH.Size = new System.Drawing.Size(782, 364);
            this.dGV_QLKH.TabIndex = 10;
            this.dGV_QLKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_QLKH_CellClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmQLKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(807, 414);
            this.Controls.Add(this.dGV_QLKH);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(807, 414);
            this.MinimumSize = new System.Drawing.Size(807, 414);
            this.Name = "frmQLKhachHang";
            this.Text = "frmQLKhachHang";
            this.Load += new System.EventHandler(this.frmQLKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_QLKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dGV_QLKH;
        private System.Windows.Forms.Timer timer1;
    }
}