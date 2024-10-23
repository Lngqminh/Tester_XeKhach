namespace WfrmQLXEKHACH
{
    partial class frmQLTaiXe
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
            this.label3 = new System.Windows.Forms.Label();
            this.dGV_QLTaiXe = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_QLTaiXe)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(289, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "QUẢN LÍ TÀI XẾ";
            // 
            // dGV_QLTaiXe
            // 
            this.dGV_QLTaiXe.AllowUserToAddRows = false;
            this.dGV_QLTaiXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_QLTaiXe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGV_QLTaiXe.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dGV_QLTaiXe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGV_QLTaiXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_QLTaiXe.DefaultCellStyle = dataGridViewCellStyle1;
            this.dGV_QLTaiXe.Location = new System.Drawing.Point(12, 40);
            this.dGV_QLTaiXe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGV_QLTaiXe.Name = "dGV_QLTaiXe";
            this.dGV_QLTaiXe.ReadOnly = true;
            this.dGV_QLTaiXe.RowHeadersWidth = 51;
            this.dGV_QLTaiXe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_QLTaiXe.Size = new System.Drawing.Size(782, 363);
            this.dGV_QLTaiXe.TabIndex = 17;
            this.dGV_QLTaiXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_QLTaiXe_CellClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmQLTaiXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(807, 414);
            this.Controls.Add(this.dGV_QLTaiXe);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(807, 414);
            this.MinimumSize = new System.Drawing.Size(807, 414);
            this.Name = "frmQLTaiXe";
            this.Text = "frmQLTaiXe";
            this.Load += new System.EventHandler(this.frmQLTaiXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_QLTaiXe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dGV_QLTaiXe;
        private System.Windows.Forms.Timer timer1;
    }
}