
namespace WfrmQLXEKHACH
{
    partial class frmLayLaiMK
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
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.llbl_Back = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSdt
            // 
            this.txtSdt.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSdt.Location = new System.Drawing.Point(208, 181);
            this.txtSdt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSdt.Multiline = true;
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(317, 37);
            this.txtSdt.TabIndex = 12;
            this.txtSdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.LightGreen;
            this.btnTim.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Magenta;
            this.btnTim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTim.Location = new System.Drawing.Point(208, 249);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(319, 57);
            this.btnTim.TabIndex = 11;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // llbl_Back
            // 
            this.llbl_Back.AutoSize = true;
            this.llbl_Back.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbl_Back.LinkColor = System.Drawing.Color.Black;
            this.llbl_Back.Location = new System.Drawing.Point(23, 26);
            this.llbl_Back.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llbl_Back.Name = "llbl_Back";
            this.llbl_Back.Size = new System.Drawing.Size(70, 21);
            this.llbl_Back.TabIndex = 10;
            this.llbl_Back.TabStop = true;
            this.llbl_Back.Text = "Quay lại";
            this.llbl_Back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_Back_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(144, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nhập số điện thoại:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(200, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 41);
            this.label1.TabIndex = 8;
            this.label1.Text = "Lấy Lại Mật Khẩu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WfrmQLXEKHACH.Properties.Resources._3SHOP_preview_rev_1;
            this.pictureBox1.Location = new System.Drawing.Point(27, 377);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 55);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtSdt);
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Controls.Add(this.llbl_Back);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(85, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 463);
            this.panel1.TabIndex = 16;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmLayLaiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(845, 506);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(861, 543);
            this.Name = "frmLayLaiMK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lấy Lại Mật Khẩu";
            this.Load += new System.EventHandler(this.frmLayLaiMK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.LinkLabel llbl_Back;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}