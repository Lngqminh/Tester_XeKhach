namespace WfrmQLXEKHACH
{
    partial class frmQLXe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLXe));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboLoaixe = new System.Windows.Forms.ComboBox();
            this.txt_MaXe = new System.Windows.Forms.TextBox();
            this.txt_BienSoXe = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.dgvXe = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXe)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(301, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "QUẢN LÍ XE";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboLoaixe);
            this.groupBox3.Controls.Add(this.txt_MaXe);
            this.groupBox3.Controls.Add(this.txt_BienSoXe);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(262, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(532, 124);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin xe";
            // 
            // cboLoaixe
            // 
            this.cboLoaixe.FormattingEnabled = true;
            this.cboLoaixe.Location = new System.Drawing.Point(242, 76);
            this.cboLoaixe.Name = "cboLoaixe";
            this.cboLoaixe.Size = new System.Drawing.Size(111, 29);
            this.cboLoaixe.TabIndex = 2;
            // 
            // txt_MaXe
            // 
            this.txt_MaXe.Location = new System.Drawing.Point(74, 27);
            this.txt_MaXe.Name = "txt_MaXe";
            this.txt_MaXe.Size = new System.Drawing.Size(163, 28);
            this.txt_MaXe.TabIndex = 1;
            // 
            // txt_BienSoXe
            // 
            this.txt_BienSoXe.Location = new System.Drawing.Point(346, 27);
            this.txt_BienSoXe.Name = "txt_BienSoXe";
            this.txt_BienSoXe.Size = new System.Drawing.Size(163, 28);
            this.txt_BienSoXe.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(270, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Biển Số Xe:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(137, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Loại Xe:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(24, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "Mã Xe:";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_back.Image")));
            this.btn_back.Location = new System.Drawing.Point(1, -2);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(35, 34);
            this.btn_back.TabIndex = 44;
            this.btn_back.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_back.UseVisualStyleBackColor = false;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.LightGreen;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Xoa.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.Image")));
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(42, 73);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(73, 30);
            this.btn_Xoa.TabIndex = 5;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.LightGreen;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Them.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them.Image")));
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(42, 31);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(73, 30);
            this.btn_Them.TabIndex = 5;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.LightGreen;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Sua.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sua.Image")));
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.Location = new System.Drawing.Point(139, 31);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(66, 30);
            this.btn_Sua.TabIndex = 5;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Them);
            this.groupBox2.Controls.Add(this.btn_Sua);
            this.groupBox2.Controls.Add(this.btn_Luu);
            this.groupBox2.Controls.Add(this.btn_Xoa);
            this.groupBox2.Location = new System.Drawing.Point(12, 41);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(244, 124);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao Tác";
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.Color.LightGreen;
            this.btn_Luu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Luu.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Image = ((System.Drawing.Image)(resources.GetObject("btn_Luu.Image")));
            this.btn_Luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Luu.Location = new System.Drawing.Point(139, 73);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(66, 30);
            this.btn_Luu.TabIndex = 5;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // dgvXe
            // 
            this.dgvXe.AllowUserToAddRows = false;
            this.dgvXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvXe.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvXe.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvXe.Location = new System.Drawing.Point(12, 170);
            this.dgvXe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvXe.Name = "dgvXe";
            this.dgvXe.ReadOnly = true;
            this.dgvXe.RowHeadersWidth = 51;
            this.dgvXe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvXe.Size = new System.Drawing.Size(782, 230);
            this.dgvXe.TabIndex = 46;
            this.dgvXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvXe_CellClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmQLXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(807, 414);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvXe);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(807, 414);
            this.MinimumSize = new System.Drawing.Size(807, 414);
            this.Name = "frmQLXe";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmQLXe_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_BienSoXe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.DataGridView dgvXe;
        private System.Windows.Forms.TextBox txt_MaXe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboLoaixe;
        private System.Windows.Forms.Timer timer1;
    }
}