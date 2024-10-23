
namespace WfrmQLXEKHACH
{
    partial class frmThanhToan
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_GiaTien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.LightGreen;
            this.btnOK.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(175, 297);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(125, 35);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "ThanhToanXong";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.Color.LightGreen;
            this.btnQuayLai.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnQuayLai.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnQuayLai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuayLai.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.Location = new System.Drawing.Point(56, 297);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(95, 35);
            this.btnQuayLai.TabIndex = 6;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.lbl_GiaTien);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnOK);
            this.panel2.Controls.Add(this.btnQuayLai);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(55, 28);
            this.panel2.MinimumSize = new System.Drawing.Size(323, 338);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 338);
            this.panel2.TabIndex = 5;
            // 
            // lbl_GiaTien
            // 
            this.lbl_GiaTien.AutoSize = true;
            this.lbl_GiaTien.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GiaTien.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_GiaTien.Location = new System.Drawing.Point(88, 56);
            this.lbl_GiaTien.Name = "lbl_GiaTien";
            this.lbl_GiaTien.Size = new System.Drawing.Size(154, 23);
            this.lbl_GiaTien.TabIndex = 10;
            this.lbl_GiaTien.Text = "1,000,000 VND";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(89, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "3SHOP: 0100100110";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(81, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "NGÂN HÀNG MBBANK";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WfrmQLXEKHACH.Properties.Resources.QR;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(96, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 140);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkGreen;
            this.label11.Location = new System.Drawing.Point(17, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(303, 27);
            this.label11.TabIndex = 0;
            this.label11.Text = "Quét mã QR để thanh toán";
            // 
            // frmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(428, 392);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(444, 431);
            this.Name = "frmThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThanhToan";
            this.Load += new System.EventHandler(this.frmThanhToan_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_GiaTien;
    }
}