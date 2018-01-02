namespace QUANLYBANHANG.GUI.tabDanhMuc
{
    partial class frmThemBoPhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemBoPhan));
            this.gcDonViTinh = new DevExpress.XtraEditors.GroupControl();
            this.cbConQuanLy = new System.Windows.Forms.CheckBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtTenBoPhan = new System.Windows.Forms.TextBox();
            this.txtMaBoPhan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcDonViTinh)).BeginInit();
            this.gcDonViTinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcDonViTinh
            // 
            this.gcDonViTinh.Controls.Add(this.cbConQuanLy);
            this.gcDonViTinh.Controls.Add(this.txtGhiChu);
            this.gcDonViTinh.Controls.Add(this.txtTenBoPhan);
            this.gcDonViTinh.Controls.Add(this.txtMaBoPhan);
            this.gcDonViTinh.Controls.Add(this.label3);
            this.gcDonViTinh.Controls.Add(this.label2);
            this.gcDonViTinh.Controls.Add(this.label1);
            this.gcDonViTinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcDonViTinh.Location = new System.Drawing.Point(0, 0);
            this.gcDonViTinh.Name = "gcDonViTinh";
            this.gcDonViTinh.Size = new System.Drawing.Size(306, 128);
            this.gcDonViTinh.TabIndex = 0;
            this.gcDonViTinh.Text = "Thông Tin";
            // 
            // cbConQuanLy
            // 
            this.cbConQuanLy.AutoSize = true;
            this.cbConQuanLy.Checked = true;
            this.cbConQuanLy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbConQuanLy.Location = new System.Drawing.Point(64, 106);
            this.cbConQuanLy.Name = "cbConQuanLy";
            this.cbConQuanLy.Size = new System.Drawing.Size(83, 17);
            this.cbConQuanLy.TabIndex = 3;
            this.cbConQuanLy.Text = "Còn quản lý";
            this.cbConQuanLy.UseVisualStyleBackColor = true;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(64, 78);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(227, 21);
            this.txtGhiChu.TabIndex = 2;
            // 
            // txtTenBoPhan
            // 
            this.txtTenBoPhan.Location = new System.Drawing.Point(64, 51);
            this.txtTenBoPhan.Name = "txtTenBoPhan";
            this.txtTenBoPhan.Size = new System.Drawing.Size(227, 21);
            this.txtTenBoPhan.TabIndex = 1;
            // 
            // txtMaBoPhan
            // 
            this.txtMaBoPhan.Location = new System.Drawing.Point(64, 24);
            this.txtMaBoPhan.Name = "txtMaBoPhan";
            this.txtMaBoPhan.Size = new System.Drawing.Size(227, 21);
            this.txtMaBoPhan.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ghi chú";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã";
            // 
            // btnDong
            // 
            this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.Image")));
            this.btnDong.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(209, 134);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(85, 23);
            this.btnDong.TabIndex = 2;
            this.btnDong.Text = "Đóng";
            // 
            // btnLuu
            // 
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(104, 134);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(85, 23);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            // 
            // frmThemBoPhan
            // 
            this.AcceptButton = this.btnLuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 163);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.gcDonViTinh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThemBoPhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThemBoPhan";
            ((System.ComponentModel.ISupportInitialize)(this.gcDonViTinh)).EndInit();
            this.gcDonViTinh.ResumeLayout(false);
            this.gcDonViTinh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcDonViTinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private System.Windows.Forms.CheckBox cbConQuanLy;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtTenBoPhan;
        private System.Windows.Forms.TextBox txtMaBoPhan;
    }
}