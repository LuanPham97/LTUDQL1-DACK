namespace QUANLYBANHANG.GUI.tabChucNang
{
    partial class ucNhatKyHeThong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucNhatKyHeThong));
            this.btnXem = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnXuat = new DevExpress.XtraEditors.SimpleButton();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnDoc = new DevExpress.XtraEditors.SimpleButton();
            this.gvNhatKy = new System.Windows.Forms.DataGridView();
            this.colNguoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMayTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChucNang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHanhDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhatKy)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXem
            // 
            this.btnXem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXem.ImageOptions.Image")));
            this.btnXem.Location = new System.Drawing.Point(3, 3);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(65, 27);
            this.btnXem.TabIndex = 8;
            this.btnXem.Text = "Xem";
            // 
            // btnLuu
            // 
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(78, 3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(117, 27);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu vào tập tin";
            // 
            // btnXuat
            // 
            this.btnXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXuat.ImageOptions.Image")));
            this.btnXuat.Location = new System.Drawing.Point(324, 3);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(65, 27);
            this.btnXuat.TabIndex = 7;
            this.btnXuat.Text = "Xuất";
            // 
            // btnDong
            // 
            this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.Image")));
            this.btnDong.Location = new System.Drawing.Point(395, 3);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(65, 27);
            this.btnDong.TabIndex = 7;
            this.btnDong.Text = "Đóng";
            // 
            // btnDoc
            // 
            this.btnDoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDoc.ImageOptions.Image")));
            this.btnDoc.Location = new System.Drawing.Point(201, 3);
            this.btnDoc.Name = "btnDoc";
            this.btnDoc.Size = new System.Drawing.Size(117, 27);
            this.btnDoc.TabIndex = 7;
            this.btnDoc.Text = "Đọc từ tập tin";
            // 
            // gvNhatKy
            // 
            this.gvNhatKy.AllowUserToAddRows = false;
            this.gvNhatKy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvNhatKy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvNhatKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvNhatKy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNguoiDung,
            this.colMayTinh,
            this.colThoiGian,
            this.colChucNang,
            this.colHanhDong});
            this.gvNhatKy.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.gvNhatKy.Location = new System.Drawing.Point(3, 36);
            this.gvNhatKy.Name = "gvNhatKy";
            this.gvNhatKy.Size = new System.Drawing.Size(1118, 478);
            this.gvNhatKy.TabIndex = 9;
            // 
            // colNguoiDung
            // 
            this.colNguoiDung.HeaderText = "Người Dùng";
            this.colNguoiDung.Name = "colNguoiDung";
            // 
            // colMayTinh
            // 
            this.colMayTinh.HeaderText = "Máy Tính";
            this.colMayTinh.Name = "colMayTinh";
            // 
            // colThoiGian
            // 
            this.colThoiGian.HeaderText = "Thời Gian";
            this.colThoiGian.Name = "colThoiGian";
            // 
            // colChucNang
            // 
            this.colChucNang.HeaderText = "Chức Năng";
            this.colChucNang.Name = "colChucNang";
            // 
            // colHanhDong
            // 
            this.colHanhDong.HeaderText = "Hành Động";
            this.colHanhDong.Name = "colHanhDong";
            // 
            // ucNhatKyHeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gvNhatKy);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.btnDoc);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXem);
            this.Name = "ucNhatKyHeThong";
            this.Size = new System.Drawing.Size(1124, 517);
            ((System.ComponentModel.ISupportInitialize)(this.gvNhatKy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnXem;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnXuat;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnDoc;
        private System.Windows.Forms.DataGridView gvNhatKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMayTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChucNang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHanhDong;
    }
}
