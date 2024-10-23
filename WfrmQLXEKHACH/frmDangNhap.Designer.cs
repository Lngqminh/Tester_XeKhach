namespace WfrmQLXEKHACH
{
    partial class frmDangNhap
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
            this.lblDANGNHAP = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.chkAdmin = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblErr = new System.Windows.Forms.Label();
            this.lblQuenMatKhau = new System.Windows.Forms.LinkLabel();
            this.lblChuaCoTaiKhoan = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDANGNHAP
            // 
            this.lblDANGNHAP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDANGNHAP.AutoSize = true;
            this.lblDANGNHAP.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDANGNHAP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblDANGNHAP.Location = new System.Drawing.Point(219, 25);
            this.lblDANGNHAP.Name = "lblDANGNHAP";
            this.lblDANGNHAP.Size = new System.Drawing.Size(181, 33);
            this.lblDANGNHAP.TabIndex = 0;
            this.lblDANGNHAP.Text = "ĐĂNG NHẬP";
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUsername.Location = new System.Drawing.Point(126, 15);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(152, 24);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPassword.Location = new System.Drawing.Point(126, 45);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(152, 24);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDangNhap.BackColor = System.Drawing.Color.LightGreen;
            this.btnDangNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnDangNhap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDangNhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangNhap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDangNhap.Location = new System.Drawing.Point(36, 123);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(242, 43);
            this.btnDangNhap.TabIndex = 5;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // chkAdmin
            // 
            this.chkAdmin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkAdmin.AutoSize = true;
            this.chkAdmin.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkAdmin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.chkAdmin.Location = new System.Drawing.Point(54, 85);
            this.chkAdmin.Name = "chkAdmin";
            this.chkAdmin.Size = new System.Drawing.Size(210, 21);
            this.chkAdmin.TabIndex = 8;
            this.chkAdmin.Text = "Đăng nhập với tư cách Admin";
            this.chkAdmin.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblErr);
            this.panel1.Controls.Add(this.lblQuenMatKhau);
            this.panel1.Controls.Add(this.lblChuaCoTaiKhoan);
            this.panel1.Controls.Add(this.chkAdmin);
            this.panel1.Controls.Add(this.btnDangNhap);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Location = new System.Drawing.Point(157, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 246);
            this.panel1.TabIndex = 10;
            // 
            // lblErr
            // 
            this.lblErr.AutoSize = true;
            this.lblErr.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblErr.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErr.Location = new System.Drawing.Point(33, 169);
            this.lblErr.Name = "lblErr";
            this.lblErr.Size = new System.Drawing.Size(25, 17);
            this.lblErr.TabIndex = 13;
            this.lblErr.Text = "Lỗi";
            // 
            // lblQuenMatKhau
            // 
            this.lblQuenMatKhau.AutoSize = true;
            this.lblQuenMatKhau.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblQuenMatKhau.Location = new System.Drawing.Point(198, 214);
            this.lblQuenMatKhau.Name = "lblQuenMatKhau";
            this.lblQuenMatKhau.Size = new System.Drawing.Size(110, 17);
            this.lblQuenMatKhau.TabIndex = 12;
            this.lblQuenMatKhau.TabStop = true;
            this.lblQuenMatKhau.Text = "Quên mật khẩu?";
            this.lblQuenMatKhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblQuenMatKhau_LinkClicked);
            // 
            // lblChuaCoTaiKhoan
            // 
            this.lblChuaCoTaiKhoan.AutoSize = true;
            this.lblChuaCoTaiKhoan.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblChuaCoTaiKhoan.Location = new System.Drawing.Point(3, 214);
            this.lblChuaCoTaiKhoan.Name = "lblChuaCoTaiKhoan";
            this.lblChuaCoTaiKhoan.Size = new System.Drawing.Size(127, 17);
            this.lblChuaCoTaiKhoan.TabIndex = 11;
            this.lblChuaCoTaiKhoan.TabStop = true;
            this.lblChuaCoTaiKhoan.Text = "Chưa có tài khoản?";
            this.lblChuaCoTaiKhoan.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblChuaCoTaiKhoan_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.BackgroundImage = global::WfrmQLXEKHACH.Properties.Resources._3SHOP;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(213, 352);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 45);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmDangNhap
            // 
            this.AccessibleDescription = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDANGNHAP);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(650, 450);
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDANGNHAP;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.CheckBox chkAdmin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel lblQuenMatKhau;
        private System.Windows.Forms.LinkLabel lblChuaCoTaiKhoan;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblErr;
    }
}

