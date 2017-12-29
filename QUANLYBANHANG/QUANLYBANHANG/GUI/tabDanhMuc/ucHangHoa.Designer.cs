namespace QUANLYBANHANG.GUI
{
    partial class ucHangHoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucHangHoa));
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.splitCCHangHoa = new DevExpress.XtraEditors.SplitContainerControl();
            this.gcHangHoa = new DevExpress.XtraGrid.GridControl();
            this.gvHangHoa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNhomHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonVi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiaMua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiaBanSi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiaBanLe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTonToiThieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTinhChat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKhoMacDinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConQuanLy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colMaVachNSX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXuatXu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTonHienTai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhaCungCap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rdmHangHoa = new DevExpress.XtraBars.Ribbon.RadialMenu(this.components);
            this.bbiThem = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSua = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDong = new DevExpress.XtraBars.BarButtonItem();
            this.bbiXoa = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitCCHangHoa)).BeginInit();
            this.splitCCHangHoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdmHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(143, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(38, 39);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            // 
            // btnSua
            // 
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnSua.Location = new System.Drawing.Point(74, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(38, 39);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            // 
            // btnThem
            // 
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(10, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(38, 39);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            // 
            // splitCCHangHoa
            // 
            this.splitCCHangHoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitCCHangHoa.Horizontal = false;
            this.splitCCHangHoa.IsSplitterFixed = true;
            this.splitCCHangHoa.Location = new System.Drawing.Point(0, 0);
            this.splitCCHangHoa.Name = "splitCCHangHoa";
            this.splitCCHangHoa.Panel1.Controls.Add(this.btnXoa);
            this.splitCCHangHoa.Panel1.Controls.Add(this.btnSua);
            this.splitCCHangHoa.Panel1.Controls.Add(this.btnThem);
            this.splitCCHangHoa.Panel1.Text = "Panel1";
            this.splitCCHangHoa.Panel2.Controls.Add(this.gcHangHoa);
            this.splitCCHangHoa.Panel2.Text = "Panel2";
            this.splitCCHangHoa.Size = new System.Drawing.Size(777, 479);
            this.splitCCHangHoa.SplitterPosition = 51;
            this.splitCCHangHoa.TabIndex = 6;
            this.splitCCHangHoa.Text = "splitContainerControl1";
            // 
            // gcHangHoa
            // 
            this.gcHangHoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcHangHoa.Location = new System.Drawing.Point(0, 0);
            this.gcHangHoa.MainView = this.gvHangHoa;
            this.gcHangHoa.Name = "gcHangHoa";
            this.gcHangHoa.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gcHangHoa.Size = new System.Drawing.Size(777, 423);
            this.gcHangHoa.TabIndex = 0;
            this.gcHangHoa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHangHoa});
            // 
            // gvHangHoa
            // 
            this.gvHangHoa.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNhomHang,
            this.colMaHang,
            this.colTenHang,
            this.colDonVi,
            this.colGiaMua,
            this.colGiaBanSi,
            this.colGiaBanLe,
            this.colTonToiThieu,
            this.colTinhChat,
            this.colKhoMacDinh,
            this.colConQuanLy,
            this.colMaVachNSX,
            this.colXuatXu,
            this.colTonHienTai,
            this.colNhaCungCap});
            this.gvHangHoa.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvHangHoa.GridControl = this.gcHangHoa;
            this.gvHangHoa.GroupCount = 1;
            this.gvHangHoa.Name = "gvHangHoa";
            this.gvHangHoa.OptionsFind.AlwaysVisible = true;
            this.gvHangHoa.OptionsFind.FindDelay = 100;
            this.gvHangHoa.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNhomHang, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colNhomHang
            // 
            this.colNhomHang.Caption = "Nhóm Hàng";
            this.colNhomHang.FieldName = "TenNhomHang";
            this.colNhomHang.Name = "colNhomHang";
            this.colNhomHang.Visible = true;
            this.colNhomHang.VisibleIndex = 0;
            // 
            // colMaHang
            // 
            this.colMaHang.Caption = "Mã Hàng";
            this.colMaHang.FieldName = "MaHangHoa";
            this.colMaHang.Name = "colMaHang";
            this.colMaHang.Visible = true;
            this.colMaHang.VisibleIndex = 0;
            // 
            // colTenHang
            // 
            this.colTenHang.Caption = "Tên Hàng";
            this.colTenHang.FieldName = "TenHang";
            this.colTenHang.Name = "colTenHang";
            this.colTenHang.Visible = true;
            this.colTenHang.VisibleIndex = 1;
            // 
            // colDonVi
            // 
            this.colDonVi.Caption = "Đơn Vị";
            this.colDonVi.FieldName = "TenDVTinh";
            this.colDonVi.Name = "colDonVi";
            this.colDonVi.Visible = true;
            this.colDonVi.VisibleIndex = 2;
            // 
            // colGiaMua
            // 
            this.colGiaMua.Caption = "Giá Mua";
            this.colGiaMua.FieldName = "GiaMua";
            this.colGiaMua.Name = "colGiaMua";
            this.colGiaMua.Visible = true;
            this.colGiaMua.VisibleIndex = 3;
            // 
            // colGiaBanSi
            // 
            this.colGiaBanSi.Caption = "Giá Bán Sỉ";
            this.colGiaBanSi.FieldName = "GiaBanSi";
            this.colGiaBanSi.Name = "colGiaBanSi";
            this.colGiaBanSi.Visible = true;
            this.colGiaBanSi.VisibleIndex = 4;
            // 
            // colGiaBanLe
            // 
            this.colGiaBanLe.Caption = "Giá Bán Lẻ";
            this.colGiaBanLe.FieldName = "GiaBanLe";
            this.colGiaBanLe.Name = "colGiaBanLe";
            this.colGiaBanLe.Visible = true;
            this.colGiaBanLe.VisibleIndex = 5;
            // 
            // colTonToiThieu
            // 
            this.colTonToiThieu.Caption = "Tối Thiểu";
            this.colTonToiThieu.FieldName = "TonKhoToiThieu";
            this.colTonToiThieu.Name = "colTonToiThieu";
            this.colTonToiThieu.Visible = true;
            this.colTonToiThieu.VisibleIndex = 6;
            // 
            // colTinhChat
            // 
            this.colTinhChat.Caption = "Tính Chất";
            this.colTinhChat.FieldName = "LoaiHangHoa";
            this.colTinhChat.Name = "colTinhChat";
            this.colTinhChat.Visible = true;
            this.colTinhChat.VisibleIndex = 7;
            // 
            // colKhoMacDinh
            // 
            this.colKhoMacDinh.Caption = "Kho Mặc Định";
            this.colKhoMacDinh.FieldName = "TenKho";
            this.colKhoMacDinh.Name = "colKhoMacDinh";
            this.colKhoMacDinh.Visible = true;
            this.colKhoMacDinh.VisibleIndex = 8;
            // 
            // colConQuanLy
            // 
            this.colConQuanLy.Caption = "Còn Quản Lý";
            this.colConQuanLy.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colConQuanLy.FieldName = "ConQuanLy";
            this.colConQuanLy.Name = "colConQuanLy";
            this.colConQuanLy.Visible = true;
            this.colConQuanLy.VisibleIndex = 9;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // colMaVachNSX
            // 
            this.colMaVachNSX.Caption = "gridColumn1";
            this.colMaVachNSX.FieldName = "MaVachNSX";
            this.colMaVachNSX.Name = "colMaVachNSX";
            // 
            // colXuatXu
            // 
            this.colXuatXu.Caption = "gridColumn1";
            this.colXuatXu.FieldName = "XuatXu";
            this.colXuatXu.Name = "colXuatXu";
            // 
            // colTonHienTai
            // 
            this.colTonHienTai.Caption = "gridColumn1";
            this.colTonHienTai.FieldName = "TonHienTai";
            this.colTonHienTai.Name = "colTonHienTai";
            // 
            // colNhaCungCap
            // 
            this.colNhaCungCap.Caption = "gridColumn1";
            this.colNhaCungCap.FieldName = "NhaCungCap";
            this.colNhaCungCap.Name = "colNhaCungCap";
            // 
            // rdmHangHoa
            // 
            this.rdmHangHoa.InnerRadius = 0;
            this.rdmHangHoa.ItemAutoSize = DevExpress.XtraBars.Ribbon.RadialMenuItemAutoSize.Spring;
            this.rdmHangHoa.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiSua),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiDong),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiXoa)});
            this.rdmHangHoa.Manager = this.barManager1;
            this.rdmHangHoa.MenuRadius = 127;
            this.rdmHangHoa.Name = "rdmHangHoa";
            // 
            // bbiThem
            // 
            this.bbiThem.Caption = "Thêm";
            this.bbiThem.Id = 0;
            this.bbiThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiThem.ImageOptions.Image")));
            this.bbiThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiThem.ImageOptions.LargeImage")));
            this.bbiThem.Name = "bbiThem";
            // 
            // bbiSua
            // 
            this.bbiSua.Caption = "Sửa";
            this.bbiSua.Id = 1;
            this.bbiSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiSua.ImageOptions.Image")));
            this.bbiSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiSua.ImageOptions.LargeImage")));
            this.bbiSua.Name = "bbiSua";
            // 
            // bbiDong
            // 
            this.bbiDong.Caption = "Đóng";
            this.bbiDong.Id = 2;
            this.bbiDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiDong.ImageOptions.Image")));
            this.bbiDong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiDong.ImageOptions.LargeImage")));
            this.bbiDong.Name = "bbiDong";
            // 
            // bbiXoa
            // 
            this.bbiXoa.Caption = "Xóa";
            this.bbiXoa.Id = 3;
            this.bbiXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiXoa.ImageOptions.Image")));
            this.bbiXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiXoa.ImageOptions.LargeImage")));
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
            this.barDockControlTop.Size = new System.Drawing.Size(777, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 479);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(777, 0);
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
            this.barDockControlRight.Location = new System.Drawing.Point(777, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 479);
            // 
            // ucHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitCCHangHoa);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ucHangHoa";
            this.Size = new System.Drawing.Size(777, 479);
            ((System.ComponentModel.ISupportInitialize)(this.splitCCHangHoa)).EndInit();
            this.splitCCHangHoa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdmHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SplitContainerControl splitCCHangHoa;
        private DevExpress.XtraGrid.GridControl gcHangHoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHangHoa;
        private DevExpress.XtraGrid.Columns.GridColumn colNhomHang;
        private DevExpress.XtraGrid.Columns.GridColumn colMaHang;
        private DevExpress.XtraGrid.Columns.GridColumn colTenHang;
        private DevExpress.XtraGrid.Columns.GridColumn colDonVi;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaMua;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaBanSi;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaBanLe;
        private DevExpress.XtraGrid.Columns.GridColumn colTonToiThieu;
        private DevExpress.XtraGrid.Columns.GridColumn colTinhChat;
        private DevExpress.XtraGrid.Columns.GridColumn colKhoMacDinh;
        private DevExpress.XtraGrid.Columns.GridColumn colConQuanLy;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaVachNSX;
        private DevExpress.XtraGrid.Columns.GridColumn colXuatXu;
        private DevExpress.XtraGrid.Columns.GridColumn colTonHienTai;
        private DevExpress.XtraGrid.Columns.GridColumn colNhaCungCap;
        private DevExpress.XtraBars.Ribbon.RadialMenu rdmHangHoa;
        private DevExpress.XtraBars.BarButtonItem bbiThem;
        private DevExpress.XtraBars.BarButtonItem bbiSua;
        private DevExpress.XtraBars.BarButtonItem bbiDong;
        private DevExpress.XtraBars.BarButtonItem bbiXoa;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}
