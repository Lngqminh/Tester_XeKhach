namespace WfrmQLXEKHACH
{
    partial class frmQLVe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLVe));
            this.label3 = new System.Windows.Forms.Label();
            this.cboMaChuyen = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvVeXe = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboMaTuyen = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btnLoc = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeXe)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(312, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "QUAN LÍ VÉ";
            // 
            // cboMaChuyen
            // 
            this.cboMaChuyen.FormattingEnabled = true;
            this.cboMaChuyen.Location = new System.Drawing.Point(359, 27);
            this.cboMaChuyen.Name = "cboMaChuyen";
            this.cboMaChuyen.Size = new System.Drawing.Size(170, 29);
            this.cboMaChuyen.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(264, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã Chuyến Xe:";
            // 
            // dgvVeXe
            // 
            this.dgvVeXe.AllowUserToAddRows = false;
            this.dgvVeXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVeXe.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvVeXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVeXe.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVeXe.Location = new System.Drawing.Point(12, 120);
            this.dgvVeXe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvVeXe.Name = "dgvVeXe";
            this.dgvVeXe.ReadOnly = true;
            this.dgvVeXe.RowHeadersWidth = 51;
            this.dgvVeXe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVeXe.Size = new System.Drawing.Size(766, 282);
            this.dgvVeXe.TabIndex = 34;
            this.dgvVeXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVeXe_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Sua);
            this.groupBox2.Controls.Add(this.btn_Xoa);
            this.groupBox2.Location = new System.Drawing.Point(634, 41);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(153, 75);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao Tác";
            // 
            // cboMaTuyen
            // 
            this.cboMaTuyen.FormattingEnabled = true;
            this.cboMaTuyen.Location = new System.Drawing.Point(96, 27);
            this.cboMaTuyen.Name = "cboMaTuyen";
            this.cboMaTuyen.Size = new System.Drawing.Size(162, 29);
            this.cboMaTuyen.TabIndex = 4;
            this.cboMaTuyen.SelectedIndexChanged += new System.EventHandler(this.cboMaTuyen_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(11, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "Mã Tuyến Xe:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLoc);
            this.groupBox3.Controls.Add(this.cboMaChuyen);
            this.groupBox3.Controls.Add(this.cboMaTuyen);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(12, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(616, 75);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lọc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(272, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(292, 29);
            this.label6.TabIndex = 29;
            this.label6.Text = "QUẢN LÍ VÉ XE ĐÃ ĐẶT";
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
            this.btn_back.TabIndex = 45;
            this.btn_back.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_back.UseVisualStyleBackColor = false;
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.LightGreen;
            this.btn_Sua.Enabled = false;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Sua.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sua.Image")));
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.Location = new System.Drawing.Point(6, 25);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(66, 30);
            this.btn_Sua.TabIndex = 5;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.Color.LightGreen;
            this.btnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoc.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.Image = ((System.Drawing.Image)(resources.GetObject("btnLoc.Image")));
            this.btnLoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoc.Location = new System.Drawing.Point(535, 27);
            this.btnLoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(63, 30);
            this.btnLoc.TabIndex = 6;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoc.UseVisualStyleBackColor = false;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.LightGreen;
            this.btn_Xoa.Enabled = false;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Xoa.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.Image")));
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(78, 25);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(65, 30);
            this.btn_Xoa.TabIndex = 5;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmQLVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(807, 414);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dgvVeXe);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(807, 414);
            this.MinimumSize = new System.Drawing.Size(807, 414);
            this.Name = "frmQLVe";
            this.Text = "frmQLVe";
            this.Load += new System.EventHandler(this.frmQLVe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeXe)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboMaChuyen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvVeXe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.ComboBox cboMaTuyen;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Timer timer1;
    }
}