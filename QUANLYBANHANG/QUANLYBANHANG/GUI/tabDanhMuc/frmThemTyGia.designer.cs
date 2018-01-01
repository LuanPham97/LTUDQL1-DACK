namespace QUANLYBANHANG.GUI.tabDanhMuc
{
    partial class frmThemTyGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemTyGia));
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gcDonViTinh = new DevExpress.XtraEditors.GroupControl();
            this.ceTyGiaQuyDoi = new DevExpress.XtraEditors.CalcEdit();
            this.cbConQuanLy = new System.Windows.Forms.CheckBox();
            this.txtMaTyGia = new System.Windows.Forms.TextBox();
            this.txtTenTyGia = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gcDonViTinh)).BeginInit();
            this.gcDonViTinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceTyGiaQuyDoi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDong
            // 
            this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.Image")));
            this.btnDong.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(214, 135);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(85, 23);
            this.btnDong.TabIndex = 2;
            this.btnDong.Text = "Đóng";
            // 
            // btnLuu
            // 
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(106, 135);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(85, 23);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tỷ giá quy đổi";
            // 
            // gcDonViTinh
            // 
            this.gcDonViTinh.Controls.Add(this.ceTyGiaQuyDoi);
            this.gcDonViTinh.Controls.Add(this.cbConQuanLy);
            this.gcDonViTinh.Controls.Add(this.txtMaTyGia);
            this.gcDonViTinh.Controls.Add(this.txtTenTyGia);
            this.gcDonViTinh.Controls.Add(this.label3);
            this.gcDonViTinh.Controls.Add(this.label2);
            this.gcDonViTinh.Controls.Add(this.label1);
            this.gcDonViTinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcDonViTinh.Location = new System.Drawing.Point(0, 0);
            this.gcDonViTinh.Name = "gcDonViTinh";
            this.gcDonViTinh.Size = new System.Drawing.Size(311, 128);
            this.gcDonViTinh.TabIndex = 0;
            this.gcDonViTinh.Text = "Thông Tin";
            // 
            // ceTyGiaQuyDoi
            // 
            this.ceTyGiaQuyDoi.Location = new System.Drawing.Point(85, 80);
            this.ceTyGiaQuyDoi.Name = "ceTyGiaQuyDoi";
            this.ceTyGiaQuyDoi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ceTyGiaQuyDoi.Properties.DisplayFormat.FormatString = "n0";
            this.ceTyGiaQuyDoi.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ceTyGiaQuyDoi.Properties.Mask.EditMask = "n0";
            this.ceTyGiaQuyDoi.Properties.Name = "ceTyGiaQuyDoi";
            this.ceTyGiaQuyDoi.Size = new System.Drawing.Size(206, 20);
            this.ceTyGiaQuyDoi.TabIndex = 2;
            // 
            // cbConQuanLy
            // 
            this.cbConQuanLy.AutoSize = true;
            this.cbConQuanLy.Checked = true;
            this.cbConQuanLy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbConQuanLy.Location = new System.Drawing.Point(85, 106);
            this.cbConQuanLy.Name = "cbConQuanLy";
            this.cbConQuanLy.Size = new System.Drawing.Size(83, 17);
            this.cbConQuanLy.TabIndex = 3;
            this.cbConQuanLy.Text = "Còn quản lý";
            this.cbConQuanLy.UseVisualStyleBackColor = true;
            // 
            // txtMaTyGia
            // 
            this.txtMaTyGia.Location = new System.Drawing.Point(85, 24);
            this.txtMaTyGia.Name = "txtMaTyGia";
            this.txtMaTyGia.Size = new System.Drawing.Size(206, 21);
            this.txtMaTyGia.TabIndex = 0;
            // 
            // txtTenTyGia
            // 
            this.txtTenTyGia.Location = new System.Drawing.Point(85, 51);
            this.txtTenTyGia.Name = "txtTenTyGia";
            this.txtTenTyGia.Size = new System.Drawing.Size(206, 21);
            this.txtTenTyGia.TabIndex = 1;
            // 
            // frmThemTyGia
            // 
            this.AcceptButton = this.btnLuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 170);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.gcDonViTinh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThemTyGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThemTyGia";
            ((System.ComponentModel.ISupportInitialize)(this.gcDonViTinh)).EndInit();
            this.gcDonViTinh.ResumeLayout(false);
            this.gcDonViTinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceTyGiaQuyDoi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.GroupControl gcDonViTinh;
        private System.Windows.Forms.CheckBox cbConQuanLy;
        private System.Windows.Forms.TextBox txtMaTyGia;
        private System.Windows.Forms.TextBox txtTenTyGia;
        private DevExpress.XtraEditors.CalcEdit ceTyGiaQuyDoi;

    }
}