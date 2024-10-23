namespace WfrmQLXEKHACH
{
    partial class frmSuaSoDienThoai
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstSdt = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnHuy = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "SỬA SỐ ĐIỆN THOẠI";
            // 
            // lstSdt
            // 
            this.lstSdt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lstSdt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstSdt.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lstSdt.FormattingEnabled = true;
            this.lstSdt.ItemHeight = 23;
            this.lstSdt.Location = new System.Drawing.Point(129, 147);
            this.lstSdt.Name = "lstSdt";
            this.lstSdt.Size = new System.Drawing.Size(234, 163);
            this.lstSdt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập số điện thoại mới:";
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(78, 94);
            this.txtSdt.MaxLength = 10;
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(181, 24);
            this.txtSdt.TabIndex = 3;
            this.txtSdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSdt_KeyPress);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Location = new System.Drawing.Point(288, 94);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 24);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Location = new System.Drawing.Point(25, 147);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 84);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnHuy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuy.Location = new System.Drawing.Point(25, 243);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 84);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "TRỞ VỀ";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.txtSdt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lstSdt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(32, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 346);
            this.panel1.TabIndex = 7;
            // 
            // frmSuaSoDienThoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(445, 374);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSuaSoDienThoai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSuaSoDienThoai";
            this.Load += new System.EventHandler(this.frmSuaSoDienThoai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstSdt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Panel panel1;
    }
}