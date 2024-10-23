namespace WfrmQLXEKHACH
{
    partial class frmHomeAdmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_TenSHOP = new System.Windows.Forms.Label();
            this.pic_Avatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(276, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "XIN CHÀO ";
            // 
            // lb_TenSHOP
            // 
            this.lb_TenSHOP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_TenSHOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenSHOP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lb_TenSHOP.Location = new System.Drawing.Point(12, 119);
            this.lb_TenSHOP.Name = "lb_TenSHOP";
            this.lb_TenSHOP.Size = new System.Drawing.Size(783, 55);
            this.lb_TenSHOP.TabIndex = 1;
            this.lb_TenSHOP.Text = "...SHOP";
            this.lb_TenSHOP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_Avatar
            // 
            this.pic_Avatar.BackgroundImage = global::WfrmQLXEKHACH.Properties.Resources._3SHOP;
            this.pic_Avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic_Avatar.Location = new System.Drawing.Point(306, 228);
            this.pic_Avatar.Name = "pic_Avatar";
            this.pic_Avatar.Size = new System.Drawing.Size(192, 93);
            this.pic_Avatar.TabIndex = 2;
            this.pic_Avatar.TabStop = false;
            // 
            // frmHomeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(807, 414);
            this.Controls.Add(this.pic_Avatar);
            this.Controls.Add(this.lb_TenSHOP);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(807, 414);
            this.MinimumSize = new System.Drawing.Size(807, 414);
            this.Name = "frmHomeAdmin";
            this.Text = "frmHomeAdmin";
            this.Load += new System.EventHandler(this.frmHomeAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_TenSHOP;
        private System.Windows.Forms.PictureBox pic_Avatar;
    }
}