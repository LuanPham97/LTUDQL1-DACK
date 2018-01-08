namespace QUANLYBANHANG.GUI.tabChucNang
{
    partial class ucBaoCaoKhoHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucBaoCaoKhoHang));
            this.gcBCKhoHang = new DevExpress.XtraGrid.GridControl();
            this.gvBCKhoHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNhomHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonVi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colKhoMacDinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConQuanLy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.bbiThem = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSua = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDong = new DevExpress.XtraBars.BarButtonItem();
            this.bbiXoa = new DevExpress.XtraBars.BarButtonItem();
            this.bbiXuat = new DevExpress.XtraBars.BarButtonItem();
            this.bbiIn = new DevExpress.XtraBars.BarButtonItem();
            this.rdmBC = new DevExpress.XtraBars.Ribbon.RadialMenu(this.components);
            this.splitCCHangHoa = new DevExpress.XtraEditors.SplitContainerControl();
            this.btnIn = new DevExpress.XtraEditors.DropDownButton();
            this.btnXuat = new DevExpress.XtraEditors.SimpleButton();
            this.saveFileDialogExcel = new System.Windows.Forms.SaveFileDialog();
            this.btnRPTHH = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcBCKhoHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBCKhoHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdmBC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitCCHangHoa)).BeginInit();
            this.splitCCHangHoa.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcBCKhoHang
            // 
            this.gcBCKhoHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcBCKhoHang.Location = new System.Drawing.Point(0, 0);
            this.gcBCKhoHang.MainView = this.gvBCKhoHang;
            this.gcBCKhoHang.Name = "gcBCKhoHang";
            this.gcBCKhoHang.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemCalcEdit1,
            this.repositoryItemCalcEdit2});
            this.gcBCKhoHang.Size = new System.Drawing.Size(791, 440);
            this.gcBCKhoHang.TabIndex = 1;
            this.gcBCKhoHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBCKhoHang});
            // 
            // gvBCKhoHang
            // 
            this.gvBCKhoHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNhomHang,
            this.colMaHang,
            this.colTenHang,
            this.colDonVi,
            this.colSoLuong,
            this.colDonGia,
            this.colKhoMacDinh,
            this.colThanhTien,
            this.colConQuanLy});
            this.gvBCKhoHang.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvBCKhoHang.GridControl = this.gcBCKhoHang;
            this.gvBCKhoHang.GroupCount = 1;
            this.gvBCKhoHang.Name = "gvBCKhoHang";
            this.gvBCKhoHang.OptionsFind.FindDelay = 100;
            this.gvBCKhoHang.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colKhoMacDinh, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colNhomHang
            // 
            this.colNhomHang.Caption = "Nhóm Hàng";
            this.colNhomHang.FieldName = "TenNhomHang";
            this.colNhomHang.Name = "colNhomHang";
            this.colNhomHang.Visible = true;
            this.colNhomHang.VisibleIndex = 6;
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
            // colSoLuong
            // 
            this.colSoLuong.Caption = "Số Lượng";
            this.colSoLuong.ColumnEdit = this.repositoryItemCalcEdit2;
            this.colSoLuong.FieldName = "TonHienTai";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 3;
            // 
            // repositoryItemCalcEdit2
            // 
            this.repositoryItemCalcEdit2.AutoHeight = false;
            this.repositoryItemCalcEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEdit2.Name = "repositoryItemCalcEdit2";
            // 
            // colDonGia
            // 
            this.colDonGia.Caption = "Đơn Giá";
            this.colDonGia.ColumnEdit = this.repositoryItemCalcEdit1;
            this.colDonGia.FieldName = "GiaBanLe";
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.Visible = true;
            this.colDonGia.VisibleIndex = 4;
            // 
            // repositoryItemCalcEdit1
            // 
            this.repositoryItemCalcEdit1.AutoHeight = false;
            this.repositoryItemCalcEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEdit1.DisplayFormat.FormatString = "n0";
            this.repositoryItemCalcEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1";
            // 
            // colKhoMacDinh
            // 
            this.colKhoMacDinh.Caption = "Kho Hàng";
            this.colKhoMacDinh.FieldName = "TenKho";
            this.colKhoMacDinh.Name = "colKhoMacDinh";
            this.colKhoMacDinh.Visible = true;
            this.colKhoMacDinh.VisibleIndex = 9;
            // 
            // colThanhTien
            // 
            this.colThanhTien.Caption = "Thành Tiền";
            this.colThanhTien.ColumnEdit = this.repositoryItemCalcEdit1;
            this.colThanhTien.FieldName = "colThanhTien";
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.UnboundExpression = "[GiaBanLe] * [TonHienTai]";
            this.colThanhTien.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.colThanhTien.Visible = true;
            this.colThanhTien.VisibleIndex = 5;
            // 
            // colConQuanLy
            // 
            this.colConQuanLy.Caption = "Còn Quản Lý";
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
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(791, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 496);
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
            this.bbiXoa,
            this.bbiXuat,
            this.bbiIn});
            this.barManager1.MaxItemId = 6;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(791, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 496);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(791, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 496);
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
            // bbiXuat
            // 
            this.bbiXuat.Caption = "Xuất";
            this.bbiXuat.Id = 4;
            this.bbiXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiXuat.ImageOptions.Image")));
            this.bbiXuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiXuat.ImageOptions.LargeImage")));
            this.bbiXuat.Name = "bbiXuat";
            // 
            // bbiIn
            // 
            this.bbiIn.Caption = "In";
            this.bbiIn.Id = 5;
            this.bbiIn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiIn.ImageOptions.Image")));
            this.bbiIn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiIn.ImageOptions.LargeImage")));
            this.bbiIn.Name = "bbiIn";
            // 
            // rdmBC
            // 
            this.rdmBC.AutoExpand = true;
            this.rdmBC.InnerRadius = 0;
            this.rdmBC.ItemAutoSize = DevExpress.XtraBars.Ribbon.RadialMenuItemAutoSize.Spring;
            this.rdmBC.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiXuat),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiIn)});
            this.rdmBC.Manager = this.barManager1;
            this.rdmBC.MenuRadius = 130;
            this.rdmBC.Name = "rdmBC";
            // 
            // splitCCHangHoa
            // 
            this.splitCCHangHoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitCCHangHoa.Horizontal = false;
            this.splitCCHangHoa.IsSplitterFixed = true;
            this.splitCCHangHoa.Location = new System.Drawing.Point(0, 0);
            this.splitCCHangHoa.Name = "splitCCHangHoa";
            this.splitCCHangHoa.Panel1.Controls.Add(this.btnIn);
            this.splitCCHangHoa.Panel1.Controls.Add(this.btnRPTHH);
            this.splitCCHangHoa.Panel1.Controls.Add(this.btnXuat);
            this.splitCCHangHoa.Panel1.Text = "Panel1";
            this.splitCCHangHoa.Panel2.Controls.Add(this.gcBCKhoHang);
            this.splitCCHangHoa.Panel2.Text = "Panel2";
            this.splitCCHangHoa.Size = new System.Drawing.Size(791, 496);
            this.splitCCHangHoa.SplitterPosition = 51;
            this.splitCCHangHoa.TabIndex = 7;
            this.splitCCHangHoa.Text = "splitContainerControl1";
            // 
            // btnIn
            // 
            this.btnIn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.ImageOptions.Image")));
            this.btnIn.Location = new System.Drawing.Point(115, 12);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(65, 27);
            this.btnIn.TabIndex = 2;
            this.btnIn.Text = "In";
            // 
            // btnXuat
            // 
            this.btnXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXuat.ImageOptions.Image")));
            this.btnXuat.Location = new System.Drawing.Point(27, 12);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(65, 27);
            this.btnXuat.TabIndex = 3;
            this.btnXuat.Text = "Xuất";
            // 
            // btnRPTHH
            // 
            this.btnRPTHH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnRPTHH.Location = new System.Drawing.Point(240, 7);
            this.btnRPTHH.Name = "btnRPTHH";
            this.btnRPTHH.Size = new System.Drawing.Size(165, 38);
            this.btnRPTHH.TabIndex = 3;
            this.btnRPTHH.Text = "Xuất Báo Cáo Hàng Hóa";
            // 
            // ucBaoCaoKhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitCCHangHoa);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ucBaoCaoKhoHang";
            this.Size = new System.Drawing.Size(791, 496);
            ((System.ComponentModel.ISupportInitialize)(this.gcBCKhoHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBCKhoHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdmBC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitCCHangHoa)).EndInit();
            this.splitCCHangHoa.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcBCKhoHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBCKhoHang;
        private DevExpress.XtraGrid.Columns.GridColumn colNhomHang;
        private DevExpress.XtraGrid.Columns.GridColumn colMaHang;
        private DevExpress.XtraGrid.Columns.GridColumn colTenHang;
        private DevExpress.XtraGrid.Columns.GridColumn colDonVi;
        private DevExpress.XtraGrid.Columns.GridColumn colDonGia;
        private DevExpress.XtraGrid.Columns.GridColumn colKhoMacDinh;
        private DevExpress.XtraGrid.Columns.GridColumn colConQuanLy;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colThanhTien;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraEditors.SplitContainerControl splitCCHangHoa;
        private DevExpress.XtraBars.BarButtonItem bbiThem;
        private DevExpress.XtraBars.BarButtonItem bbiSua;
        private DevExpress.XtraBars.BarButtonItem bbiDong;
        private DevExpress.XtraBars.BarButtonItem bbiXoa;
        private DevExpress.XtraBars.Ribbon.RadialMenu rdmBC;
        private DevExpress.XtraEditors.DropDownButton btnIn;
        private DevExpress.XtraEditors.SimpleButton btnXuat;
        private DevExpress.XtraBars.BarButtonItem bbiXuat;
        private DevExpress.XtraBars.BarButtonItem bbiIn;
        private System.Windows.Forms.SaveFileDialog saveFileDialogExcel;
        private DevExpress.XtraEditors.SimpleButton btnRPTHH;
    }
}
