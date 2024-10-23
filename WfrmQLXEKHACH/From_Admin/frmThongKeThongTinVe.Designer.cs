namespace WfrmQLXEKHACH
{
    partial class frmThongKeThongTinVe
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
            this.dgvVeXe = new System.Windows.Forms.DataGridView();
            this.lbVe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeXe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVeXe
            // 
            this.dgvVeXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVeXe.Location = new System.Drawing.Point(12, 54);
            this.dgvVeXe.Name = "dgvVeXe";
            this.dgvVeXe.RowHeadersWidth = 51;
            this.dgvVeXe.RowTemplate.Height = 24;
            this.dgvVeXe.Size = new System.Drawing.Size(713, 274);
            this.dgvVeXe.TabIndex = 0;
            this.dgvVeXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVeXe_CellClick);
            // 
            // lbVe
            // 
            this.lbVe.AutoSize = true;
            this.lbVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVe.Location = new System.Drawing.Point(296, -1);
            this.lbVe.Name = "lbVe";
            this.lbVe.Size = new System.Drawing.Size(77, 52);
            this.lbVe.TabIndex = 1;
            this.lbVe.Text = "Vé";
            // 
            // frmThongKeThongTinVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 340);
            this.Controls.Add(this.lbVe);
            this.Controls.Add(this.dgvVeXe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThongKeThongTinVe";
            this.Text = "frmThongKeThongTinVe";
            this.Load += new System.EventHandler(this.frmThongKeThongTinVe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeXe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVeXe;
        private System.Windows.Forms.Label lbVe;
    }
}