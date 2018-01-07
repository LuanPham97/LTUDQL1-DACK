namespace QUANLYBANHANG.GUI.HeThong
{
    partial class frmThemSuaVaiTro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemSuaVaiTro));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.ckbKichHoat = new System.Windows.Forms.CheckBox();
            this.txtDienGiai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenVaiTro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaVaiTro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.tlQuyenHan = new DevExpress.XtraTreeList.TreeList();
            this.colTenChucNang = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colTatCa = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colTruyCap = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colThem = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colXoa = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colSua = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colInAn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colNhap = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colXuat = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.quanLyBanHang_DoAnDataSet1 = new QUANLYBANHANG.QuanLyBanHang_DoAnDataSet();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.chucnangTableAdapter1 = new QUANLYBANHANG.QuanLyBanHang_DoAnDataSetTableAdapters.CHUCNANGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlQuyenHan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHang_DoAnDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.ckbKichHoat);
            this.groupControl1.Controls.Add(this.txtDienGiai);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.txtTenVaiTro);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.txtMaVaiTro);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(911, 113);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin Vai Trò";
            // 
            // ckbKichHoat
            // 
            this.ckbKichHoat.AutoSize = true;
            this.ckbKichHoat.Checked = true;
            this.ckbKichHoat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbKichHoat.Location = new System.Drawing.Point(464, 70);
            this.ckbKichHoat.Name = "ckbKichHoat";
            this.ckbKichHoat.Size = new System.Drawing.Size(71, 17);
            this.ckbKichHoat.TabIndex = 2;
            this.ckbKichHoat.Text = "Kích Hoạt";
            this.ckbKichHoat.UseVisualStyleBackColor = true;
            // 
            // txtDienGiai
            // 
            this.txtDienGiai.Location = new System.Drawing.Point(464, 32);
            this.txtDienGiai.Name = "txtDienGiai";
            this.txtDienGiai.Size = new System.Drawing.Size(285, 21);
            this.txtDienGiai.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Diễn Giải";
            // 
            // txtTenVaiTro
            // 
            this.txtTenVaiTro.Location = new System.Drawing.Point(78, 66);
            this.txtTenVaiTro.Name = "txtTenVaiTro";
            this.txtTenVaiTro.Size = new System.Drawing.Size(289, 21);
            this.txtTenVaiTro.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên";
            // 
            // txtMaVaiTro
            // 
            this.txtMaVaiTro.Location = new System.Drawing.Point(78, 32);
            this.txtMaVaiTro.Name = "txtMaVaiTro";
            this.txtMaVaiTro.Size = new System.Drawing.Size(289, 21);
            this.txtMaVaiTro.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tlQuyenHan);
            this.groupBox1.Location = new System.Drawing.Point(0, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(911, 360);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quyền Hạn";
            // 
            // btnLuu
            // 
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(682, 460);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(93, 37);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            // 
            // btnDong
            // 
            this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.Image")));
            this.btnDong.Location = new System.Drawing.Point(806, 460);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(93, 37);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            // 
            // tlQuyenHan
            // 
            this.tlQuyenHan.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colTenChucNang,
            this.colTatCa,
            this.colTruyCap,
            this.colThem,
            this.colXoa,
            this.colSua,
            this.colInAn,
            this.colNhap,
            this.colXuat});
            this.tlQuyenHan.Cursor = System.Windows.Forms.Cursors.Default;
            this.tlQuyenHan.DataMember = "CHUCNANG";
            this.tlQuyenHan.DataSource = this.quanLyBanHang_DoAnDataSet1;
            this.tlQuyenHan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlQuyenHan.KeyFieldName = "MaChucNang";
            this.tlQuyenHan.Location = new System.Drawing.Point(3, 16);
            this.tlQuyenHan.Name = "tlQuyenHan";
            this.tlQuyenHan.ParentFieldName = "MaCha";
            this.tlQuyenHan.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.tlQuyenHan.Size = new System.Drawing.Size(905, 341);
            this.tlQuyenHan.TabIndex = 0;
            // 
            // colTenChucNang
            // 
            this.colTenChucNang.Caption = "Tên Chức Năng";
            this.colTenChucNang.FieldName = "TenChucNang";
            this.colTenChucNang.Name = "colTenChucNang";
            this.colTenChucNang.OptionsColumn.AllowEdit = false;
            this.colTenChucNang.Visible = true;
            this.colTenChucNang.VisibleIndex = 0;
            this.colTenChucNang.Width = 186;
            // 
            // colTatCa
            // 
            this.colTatCa.Caption = "Tất Cả";
            this.colTatCa.FieldName = "TatCa";
            this.colTatCa.Name = "colTatCa";
            this.colTatCa.Visible = true;
            this.colTatCa.VisibleIndex = 1;
            this.colTatCa.Width = 87;
            // 
            // colTruyCap
            // 
            this.colTruyCap.Caption = "Truy Cập";
            this.colTruyCap.FieldName = "TruyCap";
            this.colTruyCap.Name = "colTruyCap";
            this.colTruyCap.Visible = true;
            this.colTruyCap.VisibleIndex = 2;
            this.colTruyCap.Width = 87;
            // 
            // colThem
            // 
            this.colThem.Caption = "Thêm";
            this.colThem.FieldName = "Them";
            this.colThem.Name = "colThem";
            this.colThem.Visible = true;
            this.colThem.VisibleIndex = 3;
            this.colThem.Width = 87;
            // 
            // colXoa
            // 
            this.colXoa.Caption = "Xóa";
            this.colXoa.FieldName = "Xoa";
            this.colXoa.Name = "colXoa";
            this.colXoa.Visible = true;
            this.colXoa.VisibleIndex = 4;
            this.colXoa.Width = 86;
            // 
            // colSua
            // 
            this.colSua.Caption = "Sửa";
            this.colSua.FieldName = "Sua";
            this.colSua.Name = "colSua";
            this.colSua.Visible = true;
            this.colSua.VisibleIndex = 5;
            this.colSua.Width = 88;
            // 
            // colInAn
            // 
            this.colInAn.Caption = "In Ấn";
            this.colInAn.FieldName = "InAn";
            this.colInAn.Name = "colInAn";
            this.colInAn.Visible = true;
            this.colInAn.VisibleIndex = 6;
            this.colInAn.Width = 88;
            // 
            // colNhap
            // 
            this.colNhap.Caption = "Nhập";
            this.colNhap.FieldName = "Nhap";
            this.colNhap.Name = "colNhap";
            this.colNhap.Visible = true;
            this.colNhap.VisibleIndex = 7;
            this.colNhap.Width = 89;
            // 
            // colXuat
            // 
            this.colXuat.Caption = "Xuất";
            this.colXuat.FieldName = "Xuat";
            this.colXuat.Name = "colXuat";
            this.colXuat.Visible = true;
            this.colXuat.VisibleIndex = 8;
            this.colXuat.Width = 89;
            // 
            // quanLyBanHang_DoAnDataSet1
            // 
            this.quanLyBanHang_DoAnDataSet1.DataSetName = "QuanLyBanHang_DoAnDataSet";
            this.quanLyBanHang_DoAnDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // chucnangTableAdapter1
            // 
            this.chucnangTableAdapter1.ClearBeforeFill = true;
            // 
            // frmThemSuaVaiTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 502);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThemSuaVaiTro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Vai Trò";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tlQuyenHan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHang_DoAnDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.CheckBox ckbKichHoat;
        private System.Windows.Forms.TextBox txtDienGiai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenVaiTro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaVaiTro;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraTreeList.TreeList tlQuyenHan;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTenChucNang;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTatCa;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTruyCap;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colThem;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colXoa;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colSua;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colInAn;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colNhap;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colXuat;
        private QuanLyBanHang_DoAnDataSet quanLyBanHang_DoAnDataSet1;
        private QuanLyBanHang_DoAnDataSetTableAdapters.CHUCNANGTableAdapter chucnangTableAdapter1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnDong;
    }
}