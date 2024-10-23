namespace WfrmQLXEKHACH
{
    partial class frmQLTaiKhoan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLTaiKhoan));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dGV_tkAdmin = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_tkAdmin)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Pass);
            this.groupBox1.Controls.Add(this.txt_Username);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 154);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Admin";
            // 
            // txt_Pass
            // 
            this.txt_Pass.Enabled = false;
            this.txt_Pass.Location = new System.Drawing.Point(99, 99);
            this.txt_Pass.Multiline = true;
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(213, 22);
            this.txt_Pass.TabIndex = 2;
            // 
            // txt_Username
            // 
            this.txt_Username.Enabled = false;
            this.txt_Username.Location = new System.Drawing.Point(99, 40);
            this.txt_Username.Multiline = true;
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(213, 22);
            this.txt_Username.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username: ";
            // 
            // dGV_tkAdmin
            // 
            this.dGV_tkAdmin.AllowUserToAddRows = false;
            this.dGV_tkAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_tkAdmin.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dGV_tkAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGV_tkAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_tkAdmin.DefaultCellStyle = dataGridViewCellStyle1;
            this.dGV_tkAdmin.GridColor = System.Drawing.Color.DarkGreen;
            this.dGV_tkAdmin.Location = new System.Drawing.Point(392, 169);
            this.dGV_tkAdmin.MultiSelect = false;
            this.dGV_tkAdmin.Name = "dGV_tkAdmin";
            this.dGV_tkAdmin.ReadOnly = true;
            this.dGV_tkAdmin.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dGV_tkAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_tkAdmin.Size = new System.Drawing.Size(361, 184);
            this.dGV_tkAdmin.TabIndex = 8;
            this.dGV_tkAdmin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_tkAdmin_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(277, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "TÀI KHOẢN ADMIN";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Them);
            this.groupBox2.Controls.Add(this.btn_Sua);
            this.groupBox2.Controls.Add(this.btn_Luu);
            this.groupBox2.Controls.Add(this.btn_Xoa);
            this.groupBox2.Location = new System.Drawing.Point(386, 73);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(367, 75);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao Tác";
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.LightGreen;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Them.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them.Image")));
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(6, 31);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(73, 30);
            this.btn_Them.TabIndex = 3;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.LightGreen;
            this.btn_Sua.Enabled = false;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Sua.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sua.Image")));
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.Location = new System.Drawing.Point(198, 31);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(66, 30);
            this.btn_Sua.TabIndex = 5;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.Color.LightGreen;
            this.btn_Luu.Enabled = false;
            this.btn_Luu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Luu.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Image = ((System.Drawing.Image)(resources.GetObject("btn_Luu.Image")));
            this.btn_Luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Luu.Location = new System.Drawing.Point(295, 31);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(63, 30);
            this.btn_Luu.TabIndex = 6;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.LightGreen;
            this.btn_Xoa.Enabled = false;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Xoa.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.Image")));
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(103, 31);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(65, 30);
            this.btn_Xoa.TabIndex = 4;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // frmQLTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(791, 375);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dGV_tkAdmin);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(807, 414);
            this.MinimumSize = new System.Drawing.Size(807, 414);
            this.Name = "frmQLTaiKhoan";
            this.Text = "frmQLTK";
            this.Load += new System.EventHandler(this.frmQLTaiKhoan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_tkAdmin)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGV_tkAdmin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Xoa;
    }
}