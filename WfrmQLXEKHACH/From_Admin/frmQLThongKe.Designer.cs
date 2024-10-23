namespace WfrmQLXEKHACH
{
    partial class frmQLThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLThongKe));
            this.label3 = new System.Windows.Forms.Label();
            this.btnTaiXe = new System.Windows.Forms.Button();
            this.btnVe = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(655, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "THỐNG KÊ";
            // 
            // btnTaiXe
            // 
            this.btnTaiXe.BackColor = System.Drawing.Color.DarkGreen;
            this.btnTaiXe.FlatAppearance.BorderSize = 0;
            this.btnTaiXe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiXe.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTaiXe.ForeColor = System.Drawing.Color.Honeydew;
            this.btnTaiXe.Location = new System.Drawing.Point(24, 4);
            this.btnTaiXe.Margin = new System.Windows.Forms.Padding(0);
            this.btnTaiXe.Name = "btnTaiXe";
            this.btnTaiXe.Size = new System.Drawing.Size(169, 42);
            this.btnTaiXe.TabIndex = 9;
            this.btnTaiXe.Text = "Tài Xế";
            this.btnTaiXe.UseVisualStyleBackColor = false;
            this.btnTaiXe.Click += new System.EventHandler(this.btnTaiXe_Click);
            // 
            // btnVe
            // 
            this.btnVe.BackColor = System.Drawing.Color.DarkGreen;
            this.btnVe.Enabled = false;
            this.btnVe.FlatAppearance.BorderSize = 0;
            this.btnVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVe.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnVe.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnVe.Location = new System.Drawing.Point(193, 4);
            this.btnVe.Margin = new System.Windows.Forms.Padding(0);
            this.btnVe.Name = "btnVe";
            this.btnVe.Size = new System.Drawing.Size(152, 42);
            this.btnVe.TabIndex = 10;
            this.btnVe.Text = "Vé";
            this.btnVe.UseVisualStyleBackColor = false;
            this.btnVe.Click += new System.EventHandler(this.btnVe_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(24, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 340);
            this.panel1.TabIndex = 11;
            // 
            // frmQLThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(807, 414);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVe);
            this.Controls.Add(this.btnTaiXe);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(807, 414);
            this.MinimumSize = new System.Drawing.Size(807, 414);
            this.Name = "frmQLThongKe";
            this.Text = "frmQLThongKe";
            this.Load += new System.EventHandler(this.frmQLThongKe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTaiXe;
        private System.Windows.Forms.Button btnVe;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Panel panel1;
    }
}