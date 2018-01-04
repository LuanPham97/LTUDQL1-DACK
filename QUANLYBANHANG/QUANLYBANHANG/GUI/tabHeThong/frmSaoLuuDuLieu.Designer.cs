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
            this.lblSaoLuu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenTapTin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDuongDan = new System.Windows.Forms.TextBox();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnThucHien = new DevExpress.XtraEditors.SimpleButton();
            this.btnOpenFile = new DevExpress.XtraEditors.SimpleButton();
            this.fbdSaoLuu = new System.Windows.Forms.FolderBrowserDialog();
            this.cbGhiDe = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblSaoLuu
            // 
            this.lblSaoLuu.AutoSize = true;
            this.lblSaoLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaoLuu.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSaoLuu.Location = new System.Drawing.Point(102, 22);
            this.lblSaoLuu.Name = "lblSaoLuu";
            this.lblSaoLuu.Size = new System.Drawing.Size(247, 24);
            this.lblSaoLuu.TabIndex = 0;
            this.lblSaoLuu.Text = "Sao lưu dự phòng dữ liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên tập tin (.bak)";
            // 
            // txtTenTapTin
            // 
            this.txtTenTapTin.Location = new System.Drawing.Point(106, 70);
            this.txtTenTapTin.Name = "txtTenTapTin";
            this.txtTenTapTin.Size = new System.Drawing.Size(285, 20);
            this.txtTenTapTin.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Đường dẫn";
            // 
            // txtDuongDan
            // 
            this.txtDuongDan.Location = new System.Drawing.Point(106, 102);
            this.txtDuongDan.Name = "txtDuongDan";
            this.txtDuongDan.Size = new System.Drawing.Size(285, 20);
            this.txtDuongDan.TabIndex = 4;
            // 
            // btnDong
            // 
            this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.Image")));
            this.btnDong.Location = new System.Drawing.Point(300, 166);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(91, 35);
            this.btnDong.TabIndex = 6;
            this.btnDong.Text = "Đóng";
            // 
            // btnThucHien
            // 
            this.btnThucHien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThucHien.ImageOptions.Image")));
            this.btnThucHien.Location = new System.Drawing.Point(184, 166);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(91, 35);
            this.btnThucHien.TabIndex = 5;
            this.btnThucHien.Text = "Thực Hiện";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenFile.ImageOptions.Image")));
            this.btnOpenFile.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnOpenFile.Location = new System.Drawing.Point(347, 102);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(44, 20);
            this.btnOpenFile.TabIndex = 7;
            // 
            // cbGhiDe
            // 
            this.cbGhiDe.AutoSize = true;
            this.cbGhiDe.Checked = true;
            this.cbGhiDe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbGhiDe.Enabled = false;
            this.cbGhiDe.Location = new System.Drawing.Point(106, 128);
            this.cbGhiDe.Name = "cbGhiDe";
            this.cbGhiDe.Size = new System.Drawing.Size(105, 17);
            this.cbGhiDe.TabIndex = 8;
            this.cbGhiDe.Text = "Ghi đè tập tin cũ";
            this.cbGhiDe.UseVisualStyleBackColor = true;
            // 
            // frmSaoLuuDuLieu
            // 
            this.AcceptButton = this.btnThucHien;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 217);
            this.Controls.Add(this.cbGhiDe);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.txtDuongDan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenTapTin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSaoLuu);
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

        private System.Windows.Forms.Label lblSaoLuu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenTapTin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDuongDan;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnThucHien;
        private DevExpress.XtraEditors.SimpleButton btnOpenFile;
        private System.Windows.Forms.FolderBrowserDialog fbdSaoLuu;
        private System.Windows.Forms.CheckBox cbGhiDe;
    }
}