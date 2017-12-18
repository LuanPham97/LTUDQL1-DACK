namespace QUANLYBANHANG.GUI
{
    partial class ucPhanQuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPhanQuyen));
            this.splitPhanQuyen = new DevExpress.XtraCharts.Wizard.SplitContainerControlWin64();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemNguoiDung = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemVaiTro = new DevExpress.XtraEditors.SimpleButton();
            this.tlBPQ = new DevExpress.XtraTreeList.TreeList();
            this.colTenChucNang = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colTatCa = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colTruyCap = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colThem = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colXoa = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colSua = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colInAn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colNhap = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colXuat = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gcdsUser = new DevExpress.XtraGrid.GridControl();
            this.gvDsUser = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenDangNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVaiTro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDienGiai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConQuanLy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tvVaiTroNguoiDung = new System.Windows.Forms.TreeView();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.ctmsPhanQuyen = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiThemVT = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiThemND = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSua = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDong = new System.Windows.Forms.ToolStripMenuItem();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitPhanQuyen)).BeginInit();
            this.splitPhanQuyen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlBPQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcdsUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDsUser)).BeginInit();
            this.ctmsPhanQuyen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitPhanQuyen
            // 
            this.splitPhanQuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitPhanQuyen.Horizontal = false;
            this.splitPhanQuyen.Location = new System.Drawing.Point(0, 0);
            this.splitPhanQuyen.Name = "splitPhanQuyen";
            this.splitPhanQuyen.Panel1.Controls.Add(this.separatorControl1);
            this.splitPhanQuyen.Panel1.Controls.Add(this.btnXoa);
            this.splitPhanQuyen.Panel1.Controls.Add(this.btnSua);
            this.splitPhanQuyen.Panel1.Controls.Add(this.btnThemNguoiDung);
            this.splitPhanQuyen.Panel1.Controls.Add(this.btnThemVaiTro);
            this.splitPhanQuyen.Panel1.Text = "Panel1";
            this.splitPhanQuyen.Panel2.Controls.Add(this.tlBPQ);
            this.splitPhanQuyen.Panel2.Controls.Add(this.gcdsUser);
            this.splitPhanQuyen.Panel2.Controls.Add(this.tvVaiTroNguoiDung);
            this.splitPhanQuyen.Panel2.Text = "Panel2";
            this.splitPhanQuyen.Size = new System.Drawing.Size(794, 516);
            this.splitPhanQuyen.SplitterPosition = 27;
            this.splitPhanQuyen.TabIndex = 0;
            this.splitPhanQuyen.Text = "splitContainerControlWin641";
            // 
            // btnXoa
            // 
            this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(325, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(53, 27);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            // 
            // btnSua
            // 
            this.btnSua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(249, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(57, 27);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            // 
            // btnThemNguoiDung
            // 
            this.btnThemNguoiDung.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnThemNguoiDung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemNguoiDung.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNguoiDung.ImageOptions.Image")));
            this.btnThemNguoiDung.Location = new System.Drawing.Point(102, 3);
            this.btnThemNguoiDung.Name = "btnThemNguoiDung";
            this.btnThemNguoiDung.Size = new System.Drawing.Size(116, 27);
            this.btnThemNguoiDung.TabIndex = 1;
            this.btnThemNguoiDung.Text = "Thêm Người Dùng";
            // 
            // btnThemVaiTro
            // 
            this.btnThemVaiTro.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnThemVaiTro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemVaiTro.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemVaiTro.ImageOptions.Image")));
            this.btnThemVaiTro.Location = new System.Drawing.Point(3, 3);
            this.btnThemVaiTro.Name = "btnThemVaiTro";
            this.btnThemVaiTro.Size = new System.Drawing.Size(93, 27);
            this.btnThemVaiTro.TabIndex = 0;
            this.btnThemVaiTro.Text = "Thêm Vai Trò";
            // 
            // tlBPQ
            // 
            this.tlBPQ.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colTenChucNang,
            this.colTatCa,
            this.colTruyCap,
            this.colThem,
            this.colXoa,
            this.colSua,
            this.colInAn,
            this.colNhap,
            this.colXuat});
            this.tlBPQ.Cursor = System.Windows.Forms.Cursors.Default;
            this.tlBPQ.DataMember = "FillBPQ";
            this.tlBPQ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlBPQ.Location = new System.Drawing.Point(184, 145);
            this.tlBPQ.Name = "tlBPQ";
            this.tlBPQ.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.tlBPQ.Size = new System.Drawing.Size(610, 339);
            this.tlBPQ.TabIndex = 2;
            // 
            // colTenChucNang
            // 
            this.colTenChucNang.Caption = "Tên Chức Năng";
            this.colTenChucNang.FieldName = "TenChucNang";
            this.colTenChucNang.Name = "colTenChucNang";
            this.colTenChucNang.Visible = true;
            this.colTenChucNang.VisibleIndex = 0;
            this.colTenChucNang.Width = 97;
            // 
            // colTatCa
            // 
            this.colTatCa.Caption = "Tất Cả";
            this.colTatCa.FieldName = "TatCa";
            this.colTatCa.Name = "colTatCa";
            this.colTatCa.Visible = true;
            this.colTatCa.VisibleIndex = 1;
            this.colTatCa.Width = 61;
            // 
            // colTruyCap
            // 
            this.colTruyCap.Caption = "Truy Cập";
            this.colTruyCap.FieldName = "TruyCap";
            this.colTruyCap.Name = "colTruyCap";
            this.colTruyCap.Visible = true;
            this.colTruyCap.VisibleIndex = 2;
            this.colTruyCap.Width = 62;
            // 
            // colThem
            // 
            this.colThem.Caption = "Thêm";
            this.colThem.FieldName = "Them";
            this.colThem.Name = "colThem";
            this.colThem.Visible = true;
            this.colThem.VisibleIndex = 3;
            this.colThem.Width = 62;
            // 
            // colXoa
            // 
            this.colXoa.Caption = "Xóa";
            this.colXoa.FieldName = "Xoa";
            this.colXoa.Name = "colXoa";
            this.colXoa.Visible = true;
            this.colXoa.VisibleIndex = 4;
            this.colXoa.Width = 62;
            // 
            // colSua
            // 
            this.colSua.Caption = "Sửa";
            this.colSua.FieldName = "Sua";
            this.colSua.Name = "colSua";
            this.colSua.Visible = true;
            this.colSua.VisibleIndex = 5;
            this.colSua.Width = 62;
            // 
            // colInAn
            // 
            this.colInAn.Caption = "In Ấn";
            this.colInAn.FieldName = "InAn";
            this.colInAn.Name = "colInAn";
            this.colInAn.Visible = true;
            this.colInAn.VisibleIndex = 6;
            this.colInAn.Width = 62;
            // 
            // colNhap
            // 
            this.colNhap.Caption = "Nhập";
            this.colNhap.FieldName = "Nhap";
            this.colNhap.Name = "colNhap";
            this.colNhap.Visible = true;
            this.colNhap.VisibleIndex = 7;
            this.colNhap.Width = 62;
            // 
            // colXuat
            // 
            this.colXuat.Caption = "Xuất";
            this.colXuat.FieldName = "Xuat";
            this.colXuat.Name = "colXuat";
            this.colXuat.Visible = true;
            this.colXuat.VisibleIndex = 8;
            this.colXuat.Width = 62;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueChecked = 1;
            this.repositoryItemCheckEdit1.ValueUnchecked = 0;
            // 
            // gcdsUser
            // 
            this.gcdsUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcdsUser.Location = new System.Drawing.Point(184, 0);
            this.gcdsUser.MainView = this.gvDsUser;
            this.gcdsUser.Name = "gcdsUser";
            this.gcdsUser.Size = new System.Drawing.Size(610, 145);
            this.gcdsUser.TabIndex = 1;
            this.gcdsUser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDsUser});
            // 
            // gvDsUser
            // 
            this.gvDsUser.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenDangNhap,
            this.colVaiTro,
            this.colDienGiai,
            this.colConQuanLy});
            this.gvDsUser.GridControl = this.gcdsUser;
            this.gvDsUser.Name = "gvDsUser";
            // 
            // colTenDangNhap
            // 
            this.colTenDangNhap.Caption = "Tên Đăng Nhập";
            this.colTenDangNhap.FieldName = "TenDangNhap";
            this.colTenDangNhap.Name = "colTenDangNhap";
            this.colTenDangNhap.Visible = true;
            this.colTenDangNhap.VisibleIndex = 0;
            // 
            // colVaiTro
            // 
            this.colVaiTro.Caption = "Vai Trò";
            this.colVaiTro.FieldName = "TenVaiTro";
            this.colVaiTro.Name = "colVaiTro";
            this.colVaiTro.Visible = true;
            this.colVaiTro.VisibleIndex = 1;
            // 
            // colDienGiai
            // 
            this.colDienGiai.Caption = "Diễn Giải";
            this.colDienGiai.FieldName = "DienGiai";
            this.colDienGiai.Name = "colDienGiai";
            this.colDienGiai.Visible = true;
            this.colDienGiai.VisibleIndex = 2;
            // 
            // colConQuanLy
            // 
            this.colConQuanLy.Caption = "Còn Quản Lý";
            this.colConQuanLy.FieldName = "ConQuanLy";
            this.colConQuanLy.Name = "colConQuanLy";
            this.colConQuanLy.Visible = true;
            this.colConQuanLy.VisibleIndex = 3;
            // 
            // tvVaiTroNguoiDung
            // 
            this.tvVaiTroNguoiDung.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvVaiTroNguoiDung.Location = new System.Drawing.Point(0, 0);
            this.tvVaiTroNguoiDung.Name = "tvVaiTroNguoiDung";
            this.tvVaiTroNguoiDung.Size = new System.Drawing.Size(184, 484);
            this.tvVaiTroNguoiDung.TabIndex = 0;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.Name = "sqlDataSource1";
            // 
            // ctmsPhanQuyen
            // 
            this.ctmsPhanQuyen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiThemVT,
            this.tsmiThemND,
            this.toolStripSeparator1,
            this.tsmiSua,
            this.tsmiXoa,
            this.tsmiDong});
            this.ctmsPhanQuyen.Name = "ctmsPhanQuyen";
            this.ctmsPhanQuyen.Size = new System.Drawing.Size(174, 120);
            // 
            // tsmiThemVT
            // 
            this.tsmiThemVT.Image = ((System.Drawing.Image)(resources.GetObject("tsmiThemVT.Image")));
            this.tsmiThemVT.Name = "tsmiThemVT";
            this.tsmiThemVT.Size = new System.Drawing.Size(173, 22);
            this.tsmiThemVT.Text = "Thêm Vai Trò";
            // 
            // tsmiThemND
            // 
            this.tsmiThemND.Image = ((System.Drawing.Image)(resources.GetObject("tsmiThemND.Image")));
            this.tsmiThemND.Name = "tsmiThemND";
            this.tsmiThemND.Size = new System.Drawing.Size(173, 22);
            this.tsmiThemND.Text = "Thêm Người Dùng";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(170, 6);
            // 
            // tsmiSua
            // 
            this.tsmiSua.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSua.Image")));
            this.tsmiSua.Name = "tsmiSua";
            this.tsmiSua.Size = new System.Drawing.Size(173, 22);
            this.tsmiSua.Text = "Sửa";
            // 
            // tsmiXoa
            // 
            this.tsmiXoa.Image = ((System.Drawing.Image)(resources.GetObject("tsmiXoa.Image")));
            this.tsmiXoa.Name = "tsmiXoa";
            this.tsmiXoa.Size = new System.Drawing.Size(173, 22);
            this.tsmiXoa.Text = "Xóa";
            // 
            // tsmiDong
            // 
            this.tsmiDong.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDong.Image")));
            this.tsmiDong.Name = "tsmiDong";
            this.tsmiDong.Size = new System.Drawing.Size(173, 22);
            this.tsmiDong.Text = "Đóng";
            // 
            // separatorControl1
            // 
            this.separatorControl1.AutoSizeMode = true;
            this.separatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.separatorControl1.Location = new System.Drawing.Point(223, -5);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(20, 35);
            this.separatorControl1.TabIndex = 3;
            // 
            // ucPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitPhanQuyen);
            this.Name = "ucPhanQuyen";
            this.Size = new System.Drawing.Size(794, 516);
            ((System.ComponentModel.ISupportInitialize)(this.splitPhanQuyen)).EndInit();
            this.splitPhanQuyen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tlBPQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcdsUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDsUser)).EndInit();
            this.ctmsPhanQuyen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.Wizard.SplitContainerControlWin64 splitPhanQuyen;
        private DevExpress.XtraEditors.SimpleButton btnThemVaiTro;
        private DevExpress.XtraEditors.SimpleButton btnThemNguoiDung;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private System.Windows.Forms.TreeView tvVaiTroNguoiDung;
        private DevExpress.XtraGrid.GridControl gcdsUser;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDsUser;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDangNhap;
        private DevExpress.XtraGrid.Columns.GridColumn colVaiTro;
        private DevExpress.XtraGrid.Columns.GridColumn colDienGiai;
        private DevExpress.XtraGrid.Columns.GridColumn colConQuanLy;
        private DevExpress.XtraTreeList.TreeList tlBPQ;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTenChucNang;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTatCa;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTruyCap;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colThem;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colXoa;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colSua;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colInAn;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colNhap;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colXuat;
        private System.Windows.Forms.ContextMenuStrip ctmsPhanQuyen;
        private System.Windows.Forms.ToolStripMenuItem tsmiThemVT;
        private System.Windows.Forms.ToolStripMenuItem tsmiThemND;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSua;
        private System.Windows.Forms.ToolStripMenuItem tsmiXoa;
        private System.Windows.Forms.ToolStripMenuItem tsmiDong;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
    }
}
