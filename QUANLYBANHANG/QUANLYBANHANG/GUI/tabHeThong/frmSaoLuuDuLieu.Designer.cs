namespace QUANLYBANHANG.GUI.tabHeThong
{
    partial class frmSaoLuuDuLieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaoLuuDuLieu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenTapTin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDuongDan = new System.Windows.Forms.TextBox();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnThucHien = new DevExpress.XtraEditors.SimpleButton();
            this.btnOpenFile = new DevExpress.XtraEditors.SimpleButton();
            this.fbdSaoLuu = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(107, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sao lưu dự phòng dữ liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên tập tin";
            // 
            // txtTenTapTin
            // 
            this.txtTenTapTin.Location = new System.Drawing.Point(100, 70);
            this.txtTenTapTin.Name = "txtTenTapTin";
            this.txtTenTapTin.Size = new System.Drawing.Size(250, 20);
            this.txtTenTapTin.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Đường dẫn";
            // 
            // txtDuongDan
            // 
            this.txtDuongDan.Location = new System.Drawing.Point(100, 101);
            this.txtDuongDan.Name = "txtDuongDan";
            this.txtDuongDan.Size = new System.Drawing.Size(250, 20);
            this.txtDuongDan.TabIndex = 4;
            // 
            // btnDong
            // 
            this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnDong.Location = new System.Drawing.Point(259, 139);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(91, 35);
            this.btnDong.TabIndex = 6;
            this.btnDong.Text = "Đóng";
            // 
            // btnThucHien
            // 
            this.btnThucHien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDongY.ImageOptions.Image")));
            this.btnThucHien.Location = new System.Drawing.Point(143, 139);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(91, 35);
            this.btnThucHien.TabIndex = 5;
            this.btnThucHien.Text = "Thực Hiện";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnOpenFile.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnOpenFile.Location = new System.Drawing.Point(312, 101);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(38, 20);
            this.btnOpenFile.TabIndex = 7;
            // 
            // frmSaoLuuDuLieu
            // 
            this.AcceptButton = this.btnThucHien;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 186);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.txtDuongDan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenTapTin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSaoLuuDuLieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sao Lưu Dữ Liệu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenTapTin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDuongDan;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnThucHien;
        private DevExpress.XtraEditors.SimpleButton btnOpenFile;
        private System.Windows.Forms.FolderBrowserDialog fbdSaoLuu;
    }
}