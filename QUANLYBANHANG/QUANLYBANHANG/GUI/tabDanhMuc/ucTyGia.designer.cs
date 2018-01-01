namespace QUANLYBANHANG.GUI.tabDanhMuc
{
    partial class ucTyGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucTyGia));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.gcTyGia = new DevExpress.XtraGrid.GridControl();
            this.gvTyGia = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaTyGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenTyGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTyGiaQuyDoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConQuanLy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bbiThem = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSua = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDong = new DevExpress.XtraBars.BarButtonItem();
            this.bbiXoa = new DevExpress.XtraBars.BarButtonItem();
            this.rdmTyGia = new DevExpress.XtraBars.Ribbon.RadialMenu(this.components);
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTyGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTyGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdmTyGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            this.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.gcTyGia);
            this.splitContainer1.Size = new System.Drawing.Size(771, 411);
            this.splitContainer1.SplitterDistance = 47;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnXoa
            // 
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(130, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(38, 39);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            // 
            // btnThem
            // 
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(3, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(38, 39);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            // 
            // btnSua
            // 
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnSua.Location = new System.Drawing.Point(67, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(38, 39);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            // 
            // gcTyGia
            // 
            this.gcTyGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcTyGia.Location = new System.Drawing.Point(0, 0);
            this.gcTyGia.MainView = this.gvTyGia;
            this.gcTyGia.Name = "gcTyGia";
            this.gcTyGia.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemCalcEdit1});
            this.gcTyGia.Size = new System.Drawing.Size(771, 360);
            this.gcTyGia.TabIndex = 0;
            this.gcTyGia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTyGia});
            // 
            // gvTyGia
            // 
            this.gvTyGia.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaTyGia,
            this.colTenTyGia,
            this.colTyGiaQuyDoi,
            this.colConQuanLy});
            this.gvTyGia.GridControl = this.gcTyGia;
            this.gvTyGia.Name = "gvTyGia";
            // 
            // colMaTyGia
            // 
            this.colMaTyGia.Caption = "Mã";
            this.colMaTyGia.FieldName = "MaTyGia";
            this.colMaTyGia.Name = "colMaTyGia";
            this.colMaTyGia.Visible = true;
            this.colMaTyGia.VisibleIndex = 0;
            // 
            // colTenTyGia
            // 
            this.colTenTyGia.Caption = "Tên";
            this.colTenTyGia.FieldName = "TenTyGia";
            this.colTenTyGia.Name = "colTenTyGia";
            this.colTenTyGia.Visible = true;
            this.colTenTyGia.VisibleIndex = 1;
            // 
            // colTyGiaQuyDoi
            // 
            this.colTyGiaQuyDoi.Caption = "Tỷ giá quy đổi";
            this.colTyGiaQuyDoi.ColumnEdit = this.repositoryItemCalcEdit1;
            this.colTyGiaQuyDoi.FieldName = "TyGiaQuyDoi";
            this.colTyGiaQuyDoi.Name = "colTyGiaQuyDoi";
            this.colTyGiaQuyDoi.Visible = true;
            this.colTyGiaQuyDoi.VisibleIndex = 2;
            // 
            // colConQuanLy
            // 
            this.colConQuanLy.Caption = "Còn Quản Lý";
            this.colConQuanLy.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colConQuanLy.FieldName = "ConQuanLy";
            this.colConQuanLy.Name = "colConQuanLy";
            this.colConQuanLy.Visible = true;
            this.colConQuanLy.VisibleIndex = 3;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
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
            this.barDockControlTop.Size = new System.Drawing.Size(771, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 411);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(771, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 411);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(771, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 411);
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
            // rdmTyGia
            // 
            this.rdmTyGia.AutoExpand = true;
            this.rdmTyGia.InnerRadius = 0;
            this.rdmTyGia.ItemAutoSize = DevExpress.XtraBars.Ribbon.RadialMenuItemAutoSize.Spring;
            this.rdmTyGia.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiSua),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiDong),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiXoa)});
            this.rdmTyGia.Manager = this.barManager1;
            this.rdmTyGia.MenuRadius = 127;
            this.rdmTyGia.Name = "rdmTyGia";
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
            // ucTyGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ucTyGia";
            this.Size = new System.Drawing.Size(771, 411);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcTyGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTyGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdmTyGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl gcTyGia;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTyGia;
        private DevExpress.XtraGrid.Columns.GridColumn colMaTyGia;
        private DevExpress.XtraGrid.Columns.GridColumn colTenTyGia;
        private DevExpress.XtraGrid.Columns.GridColumn colTyGiaQuyDoi;
        private DevExpress.XtraGrid.Columns.GridColumn colConQuanLy;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bbiThem;
        private DevExpress.XtraBars.BarButtonItem bbiSua;
        private DevExpress.XtraBars.BarButtonItem bbiDong;
        private DevExpress.XtraBars.BarButtonItem bbiXoa;
        private DevExpress.XtraBars.Ribbon.RadialMenu rdmTyGia;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
    }
}
