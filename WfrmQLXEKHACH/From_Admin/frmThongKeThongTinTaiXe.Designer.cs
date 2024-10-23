namespace WfrmQLXEKHACH
{
    partial class frmThongKeThongTinTaiXe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKeThongTinTaiXe));
            this.dgvTaiXe = new System.Windows.Forms.DataGridView();
            this.lbTaiXe = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSoLuong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiXe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTaiXe
            // 
            this.dgvTaiXe.AllowUserToAddRows = false;
            this.dgvTaiXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaiXe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTaiXe.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvTaiXe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTaiXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiXe.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvTaiXe.Location = new System.Drawing.Point(33, 42);
            this.dgvTaiXe.Name = "dgvTaiXe";
            this.dgvTaiXe.ReadOnly = true;
            this.dgvTaiXe.RowHeadersWidth = 51;
            this.dgvTaiXe.RowTemplate.Height = 24;
            this.dgvTaiXe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTaiXe.Size = new System.Drawing.Size(797, 274);
            this.dgvTaiXe.TabIndex = 0;
            this.dgvTaiXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiXe_CellClick);
            // 
            // lbTaiXe
            // 
            this.lbTaiXe.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaiXe.ForeColor = System.Drawing.Color.White;
            this.lbTaiXe.Location = new System.Drawing.Point(403, 3);
            this.lbTaiXe.Name = "lbTaiXe";
            this.lbTaiXe.Size = new System.Drawing.Size(104, 36);
            this.lbTaiXe.TabIndex = 1;
            this.lbTaiXe.Text = "Tài Xế";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(685, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(145, 36);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "In ALL";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(111, 6);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(227, 30);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(31, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tìm Tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(682, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Số lượng:";
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSoLuong.Location = new System.Drawing.Point(748, 319);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(28, 16);
            this.lbSoLuong.TabIndex = 7;
            this.lbSoLuong.Text = "       ";
            // 
            // frmThongKeThongTinTaiXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(873, 340);
            this.Controls.Add(this.lbSoLuong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lbTaiXe);
            this.Controls.Add(this.dgvTaiXe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmThongKeThongTinTaiXe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmThongKeThongTinTaiXe";
            this.Load += new System.EventHandler(this.frmThongKeThongTinTaiXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiXe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTaiXe;
        private System.Windows.Forms.Label lbTaiXe;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSoLuong;
    }
}