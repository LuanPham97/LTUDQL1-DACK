namespace QUANLYBANHANG.GUI.tabDanhMuc
{
    partial class ucKhoHang
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucKhoHang));
            this.gcKhoHang = new DevExpress.XtraGrid.GridControl();
            this.gvKhoHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLienHe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKyHieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConQuanLy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colFax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNQL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.rdmKhoHang = new DevExpress.XtraBars.Ribbon.RadialMenu(this.components);
            this.bbiThem = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSua = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDong = new DevExpress.XtraBars.BarButtonItem();
            this.bbiXoa = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gcKhoHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhoHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdmKhoHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcKhoHang
            // 
            this.gcKhoHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcKhoHang.Location = new System.Drawing.Point(0, 0);
            this.gcKhoHang.MainView = this.gvKhoHang;
            this.gcKhoHang.Name = "gcKhoHang";
            this.gcKhoHang.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gcKhoHang.Size = new System.Drawing.Size(920, 427);
            this.gcKhoHang.TabIndex = 0;
            this.gcKhoHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvKhoHang});
            // 
            // gvKhoHang
            // 
            this.gvKhoHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaKho,
            this.colTenKho,
            this.colLienHe,
            this.colDiaChi,
            this.colDienThoai,
            this.colKyHieu,
            this.colGhiChu,
            this.colConQuanLy,
            this.colFax,
            this.colEmail,
            this.colNQL});
            this.gvKhoHang.GridControl = this.gcKhoHang;
            this.gvKhoHang.Name = "gvKhoHang";
            // 
            // colMaKho
            // 
            this.colMaKho.Caption = "Mã";
            this.colMaKho.FieldName = "MaKho";
            this.colMaKho.Name = "colMaKho";
            this.colMaKho.Visible = true;
            this.colMaKho.VisibleIndex = 0;
            // 
            // colTenKho
            // 
            this.colTenKho.Caption = "Tên";
            this.colTenKho.FieldName = "TenKho";
            this.colTenKho.Name = "colTenKho";
            this.colTenKho.Visible = true;
            this.colTenKho.VisibleIndex = 1;
            // 
            // colLienHe
            // 
            this.colLienHe.Caption = "Liên Hệ";
            this.colLienHe.FieldName = "NguoiLienHe";
            this.colLienHe.Name = "colLienHe";
            this.colLienHe.Visible = true;
            this.colLienHe.VisibleIndex = 2;
            // 
            // colDiaChi
            // 
            this.colDiaChi.Caption = "Địa Chỉ";
            this.colDiaChi.FieldName = "DiaChi";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.Visible = true;
            this.colDiaChi.VisibleIndex = 3;
            // 
            // colDienThoai
            // 
            this.colDienThoai.Caption = "Điện Thoại";
            this.colDienThoai.FieldName = "DienThoai";
            this.colDienThoai.Name = "colDienThoai";
            this.colDienThoai.Visible = true;
            this.colDienThoai.VisibleIndex = 4;
            // 
            // colKyHieu
            // 
            this.colKyHieu.Caption = "Ký hiệu";
            this.colKyHieu.FieldName = "KyHieu";
            this.colKyHieu.Name = "colKyHieu";
            this.colKyHieu.Visible = true;
            this.colKyHieu.VisibleIndex = 5;
            // 
            // colGhiChu
            // 
            this.colGhiChu.Caption = "Ghi chú";
            this.colGhiChu.FieldName = "DienGiai";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 6;
            // 
            // colConQuanLy
            // 
            this.colConQuanLy.Caption = "Con Quản Lý";
            this.colConQuanLy.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colConQuanLy.FieldName = "ConQuanLy";
            this.colConQuanLy.Name = "colConQuanLy";
            this.colConQuanLy.Visible = true;
            this.colConQuanLy.VisibleIndex = 7;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // colFax
            // 
            this.colFax.Caption = "gridColumn1";
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            // 
            // colEmail
            // 
            this.colEmail.Caption = "gridColumn1";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            // 
            // colNQL
            // 
            this.colNQL.Caption = "gridColumn1";
            this.colNQL.FieldName = "NguoiQuanLy";
            this.colNQL.Name = "colNQL";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnXoa);
            this.splitContainer1.Panel1.Controls.Add(this.btnThem);
            this.splitContainer1.Panel1.Controls.Add(this.btnSua);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcKhoHang);
            this.splitContainer1.Size = new System.Drawing.Size(920, 479);
            this.splitContainer1.SplitterDistance = 48;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnXoa
            // 
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(130, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(38, 39);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            // 
            // btnThem
            // 
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(3, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(38, 39);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            // 
            // btnSua
            // 
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnSua.Location = new System.Drawing.Point(67, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(38, 39);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            // 
            // rdmKhoHang
            // 
            this.rdmKhoHang.AutoExpand = true;
            this.rdmKhoHang.InnerRadius = 0;
            this.rdmKhoHang.ItemAutoSize = DevExpress.XtraBars.Ribbon.RadialMenuItemAutoSize.Spring;
            this.rdmKhoHang.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiSua),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiDong),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiXoa)});
            this.rdmKhoHang.Manager = this.barManager1;
            this.rdmKhoHang.MenuRadius = 127;
            this.rdmKhoHang.Name = "rdmKhoHang";
            // 
            // bbiThem
            // 
            this.bbiThem.Caption = "Thêm";
            this.bbiThem.Id = 0;
            this.bbiThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiThem.ImageOptions.Image")));
            this.bbiThem.Name = "bbiThem";
            // 
            // bbiSua
            // 
            this.bbiSua.Caption = "Sửa";
            this.bbiSua.Id = 1;
            this.bbiSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiSua.ImageOptions.Image")));
            this.bbiSua.Name = "bbiSua";
            // 
            // bbiDong
            // 
            this.bbiDong.Caption = "Đóng";
            this.bbiDong.Id = 2;
            this.bbiDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiDong.ImageOptions.Image")));
            this.bbiDong.Name = "bbiDong";
            // 
            // bbiXoa
            // 
            this.bbiXoa.Caption = "Xóa";
            this.bbiXoa.Id = 3;
            this.bbiXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiXoa.ImageOptions.Image")));
            this.bbiXoa.Name = "bbiXoa";
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiThem,
            this.bbiSua,
            this.bbiDong,
            this.bbiXoa});
            this.barManager1.MaxItemId = 4;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(920, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 479);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(920, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 479);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(920, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 479);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thêm";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Sửa";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Đóng";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Xóa";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Thêm";
            this.barButtonItem5.Id = 0;
            this.barButtonItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.barButtonItem5.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.LargeImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Sửa";
            this.barButtonItem6.Id = 1;
            this.barButtonItem6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.Image")));
            this.barButtonItem6.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.LargeImage")));
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Đóng";
            this.barButtonItem7.Id = 2;
            this.barButtonItem7.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.Image")));
            this.barButtonItem7.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.LargeImage")));
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Xóa";
            this.barButtonItem8.Id = 3;
            this.barButtonItem8.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.Image")));
            this.barButtonItem8.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.LargeImage")));
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // ucKhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ucKhoHang";
            this.Size = new System.Drawing.Size(920, 479);
            ((System.ComponentModel.ISupportInitialize)(this.gcKhoHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhoHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rdmKhoHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcKhoHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gvKhoHang;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKho;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKho;
        private DevExpress.XtraGrid.Columns.GridColumn colLienHe;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn colKyHieu;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn colConQuanLy;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colFax;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colNQL;
        private DevExpress.XtraBars.Ribbon.RadialMenu rdmKhoHang;
        private DevExpress.XtraBars.BarButtonItem bbiThem;
        private DevExpress.XtraBars.BarButtonItem bbiSua;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bbiDong;
        private DevExpress.XtraBars.BarButtonItem bbiXoa;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
    }
}
