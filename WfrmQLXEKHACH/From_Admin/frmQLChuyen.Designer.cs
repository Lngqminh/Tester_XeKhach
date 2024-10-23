namespace WfrmQLXEKHACH
{
    partial class frmQLChuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLChuyen));
            this.label3 = new System.Windows.Forms.Label();
            this.dGV_QLCXE = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_Them = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_QLCXE)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(272, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "QUẢN LÍ CHUYẾN XE";
            // 
            // dGV_QLCXE
            // 
            this.dGV_QLCXE.AllowUserToAddRows = false;
            this.dGV_QLCXE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_QLCXE.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dGV_QLCXE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_QLCXE.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGV_QLCXE.Location = new System.Drawing.Point(12, 39);
            this.dGV_QLCXE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGV_QLCXE.Name = "dGV_QLCXE";
            this.dGV_QLCXE.ReadOnly = true;
            this.dGV_QLCXE.RowHeadersWidth = 51;
            this.dGV_QLCXE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_QLCXE.Size = new System.Drawing.Size(783, 309);
            this.dGV_QLCXE.TabIndex = 27;
            this.dGV_QLCXE.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_QLCXE_CellClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.LightGreen;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Them.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them.Image")));
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(346, 361);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(73, 30);
            this.btn_Them.TabIndex = 28;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // frmQLChuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(807, 414);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dGV_QLCXE);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(807, 414);
            this.MinimumSize = new System.Drawing.Size(807, 414);
            this.Name = "frmQLChuyen";
            this.Text = "frmQLChuyen";
            this.Load += new System.EventHandler(this.frmQLChuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_QLCXE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dGV_QLCXE;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_Them;
    }
}