namespace QUANLYBANHANG.GUI.tabChucNang
{
    partial class ucTonKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucTonKho));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnIn = new DevExpress.XtraEditors.DropDownButton();
            this.btnXuat = new DevExpress.XtraEditors.SimpleButton();
            this.btnXem = new DevExpress.XtraEditors.SimpleButton();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.lkueKho = new DevExpress.XtraEditors.LookUpEdit();
            this.gcTonKho = new DevExpress.XtraGrid.GridControl();
            this.gvTonKho = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKhoHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonVi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhomHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConQuanLy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.saveFileDialogExcel = new System.Windows.Forms.SaveFileDialog();
            this.btnXemAll = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkueKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTonKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTonKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.lkueKho);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcTonKho);
            this.splitContainer1.Size = new System.Drawing.Size(785, 431);
            this.splitContainer1.SplitterDistance = 63;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.btnXemAll);
            this.panel1.Controls.Add(this.btnIn);
            this.panel1.Controls.Add(this.btnXuat);
            this.panel1.Controls.Add(this.btnXem);
            this.panel1.Controls.Add(this.separatorControl1);
            this.panel1.Location = new System.Drawing.Point(3, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 32);
            this.panel1.TabIndex = 2;
            // 
            // btnIn
            // 
            this.btnIn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.ImageOptions.Image")));
            this.btnIn.Location = new System.Drawing.Point(145, 3);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(65, 27);
            this.btnIn.TabIndex = 0;
            this.btnIn.Text = "In";
            // 
            // btnXuat
            // 
            this.btnXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXuat.ImageOptions.Image")));
            this.btnXuat.Location = new System.Drawing.Point(74, 3);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(65, 27);
            this.btnXuat.TabIndex = 1;
            this.btnXuat.Text = "Xuất";
            // 
            // btnXem
            // 
            this.btnXem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXem.ImageOptions.Image")));
            this.btnXem.Location = new System.Drawing.Point(3, 3);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(65, 27);
            this.btnXem.TabIndex = 1;
            this.btnXem.Text = "Xem";
            // 
            // separatorControl1
            // 
            this.separatorControl1.AutoSizeMode = true;
            this.separatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.separatorControl1.Location = new System.Drawing.Point(204, -5);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(20, 35);
            this.separatorControl1.TabIndex = 4;
            // 
            // lkueKho
            // 
            this.lkueKho.Location = new System.Drawing.Point(3, 3);
            this.lkueKho.Name = "lkueKho";
            this.lkueKho.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkueKho.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenKho", "Tên Kho"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaKho", "Mã Kho")});
            this.lkueKho.Properties.NullText = "[Tất Cả]";
            this.lkueKho.Size = new System.Drawing.Size(193, 20);
            this.lkueKho.TabIndex = 0;
            // 
            // gcTonKho
            // 
            this.gcTonKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcTonKho.Location = new System.Drawing.Point(0, 0);
            this.gcTonKho.MainView = this.gvTonKho;
            this.gcTonKho.Name = "gcTonKho";
            this.gcTonKho.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gcTonKho.Size = new System.Drawing.Size(785, 364);
            this.gcTonKho.TabIndex = 0;
            this.gcTonKho.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTonKho});
            // 
            // gvTonKho
            // 
            this.gvTonKho.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKhoHang,
            this.colMaHang,
            this.colTenHang,
            this.colDonVi,
            this.colSoLuong,
            this.colNhomHang,
            this.colConQuanLy});
            this.gvTonKho.GridControl = this.gcTonKho;
            this.gvTonKho.GroupCount = 1;
            this.gvTonKho.Name = "gvTonKho";
            this.gvTonKho.OptionsPrint.EnableAppearanceOddRow = true;
            this.gvTonKho.OptionsPrint.PrintPreview = true;
            this.gvTonKho.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colKhoHang, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colKhoHang
            // 
            this.colKhoHang.Caption = "Kho Hàng";
            this.colKhoHang.FieldName = "TenKho";
            this.colKhoHang.Name = "colKhoHang";
            this.colKhoHang.Visible = true;
            this.colKhoHang.VisibleIndex = 0;
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
            this.colSoLuong.Caption = "Số Lượng";
            this.colSoLuong.FieldName = "TonHienTai";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 3;
            // 
            // colNhomHang
            // 
            this.colNhomHang.Caption = "Nhóm Hàng";
            this.colNhomHang.FieldName = "TenNhomHang";
            this.colNhomHang.Name = "colNhomHang";
            this.colNhomHang.Visible = true;
            this.colNhomHang.VisibleIndex = 4;
            // 
            // colConQuanLy
            // 
            this.colConQuanLy.Caption = "Còn Quản Lý";
            this.colConQuanLy.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colConQuanLy.FieldName = "ConQuanLy";
            this.colConQuanLy.Name = "colConQuanLy";
            this.colConQuanLy.Visible = true;
            this.colConQuanLy.VisibleIndex = 5;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // btnXemAll
            // 
            this.btnXemAll.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnXemAll.Location = new System.Drawing.Point(261, 3);
            this.btnXemAll.Name = "btnXemAll";
            this.btnXemAll.Size = new System.Drawing.Size(98, 27);
            this.btnXemAll.TabIndex = 5;
            this.btnXemAll.Text = "Xem Tất Cả";
            // 
            // ucTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ucTonKho";
            this.Size = new System.Drawing.Size(785, 431);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkueKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTonKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTonKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.LookUpEdit lkueKho;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnXuat;
        private DevExpress.XtraEditors.SimpleButton btnXem;
        private DevExpress.XtraEditors.DropDownButton btnIn;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraGrid.GridControl gcTonKho;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTonKho;
        private DevExpress.XtraGrid.Columns.GridColumn colKhoHang;
        private DevExpress.XtraGrid.Columns.GridColumn colMaHang;
        private DevExpress.XtraGrid.Columns.GridColumn colTenHang;
        private DevExpress.XtraGrid.Columns.GridColumn colDonVi;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colNhomHang;
        private DevExpress.XtraGrid.Columns.GridColumn colConQuanLy;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private System.Windows.Forms.SaveFileDialog saveFileDialogExcel;
        private DevExpress.XtraEditors.SimpleButton btnXemAll;
    }
}
