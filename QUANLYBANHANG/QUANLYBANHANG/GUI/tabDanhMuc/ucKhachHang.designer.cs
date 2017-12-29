namespace QUANLYBANHANG.GUI
{
    partial class ucKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucKhachHang));
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.gcKhachHang = new DevExpress.XtraGrid.GridControl();
            this.gvKhachHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNguoiLienHe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiDong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWebSite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaSoThue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoTaiKhoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNganHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConQuanLy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKhuVuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLaKhachLe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGioiHanNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoHienTai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChietKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccYahoo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccSkype = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnXoa);
            this.splitContainer1.Panel1.Controls.Add(this.btnSua);
            this.splitContainer1.Panel1.Controls.Add(this.btnThem);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcKhachHang);
            this.splitContainer1.Size = new System.Drawing.Size(864, 390);
            this.splitContainer1.SplitterDistance = 49;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnXoa
            // 
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(145, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(38, 39);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            // 
            // btnSua
            // 
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnSua.Location = new System.Drawing.Point(76, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(38, 39);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            // 
            // btnThem
            // 
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(12, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(38, 39);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            // 
            // gcKhachHang
            // 
            this.gcKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcKhachHang.Location = new System.Drawing.Point(0, 0);
            this.gcKhachHang.MainView = this.gvKhachHang;
            this.gcKhachHang.Name = "gcKhachHang";
            this.gcKhachHang.Size = new System.Drawing.Size(864, 337);
            this.gcKhachHang.TabIndex = 0;
            this.gcKhachHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvKhachHang});
            // 
            // gvKhachHang
            // 
            this.gvKhachHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaKH,
            this.colTenKH,
            this.colNguoiLienHe,
            this.colDiaChi,
            this.colDienThoai,
            this.colDiDong,
            this.colFax,
            this.colEmail,
            this.colWebSite,
            this.colMaSoThue,
            this.colSoTaiKhoan,
            this.colTenNganHang,
            this.colConQuanLy,
            this.colKhuVuc,
            this.colLaKhachLe,
            this.colGioiHanNo,
            this.colNoHienTai,
            this.colChietKhau,
            this.colAccYahoo,
            this.colAccSkype});
            this.gvKhachHang.CustomizationFormBounds = new System.Drawing.Rectangle(757, 381, 210, 172);
            this.gvKhachHang.GridControl = this.gcKhachHang;
            this.gvKhachHang.Name = "gvKhachHang";
            // 
            // colMaKH
            // 
            this.colMaKH.Caption = "Mã KH";
            this.colMaKH.FieldName = "MaKH";
            this.colMaKH.Name = "colMaKH";
            this.colMaKH.Visible = true;
            this.colMaKH.VisibleIndex = 1;
            this.colMaKH.Width = 70;
            // 
            // colTenKH
            // 
            this.colTenKH.Caption = "Tên Khách Hàng";
            this.colTenKH.FieldName = "TenKH";
            this.colTenKH.Name = "colTenKH";
            this.colTenKH.Visible = true;
            this.colTenKH.VisibleIndex = 2;
            this.colTenKH.Width = 88;
            // 
            // colNguoiLienHe
            // 
            this.colNguoiLienHe.Caption = "Người Liên Hệ";
            this.colNguoiLienHe.FieldName = "NguoiLienHe";
            this.colNguoiLienHe.Name = "colNguoiLienHe";
            this.colNguoiLienHe.Visible = true;
            this.colNguoiLienHe.VisibleIndex = 3;
            this.colNguoiLienHe.Width = 76;
            // 
            // colDiaChi
            // 
            this.colDiaChi.Caption = "Địa Chỉ";
            this.colDiaChi.FieldName = "DiaChi";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.Visible = true;
            this.colDiaChi.VisibleIndex = 4;
            this.colDiaChi.Width = 55;
            // 
            // colDienThoai
            // 
            this.colDienThoai.Caption = "Điện Thoại";
            this.colDienThoai.FieldName = "DienThoai";
            this.colDienThoai.Name = "colDienThoai";
            this.colDienThoai.Visible = true;
            this.colDienThoai.VisibleIndex = 5;
            this.colDienThoai.Width = 61;
            // 
            // colDiDong
            // 
            this.colDiDong.Caption = "Di Động";
            this.colDiDong.FieldName = "Moblie";
            this.colDiDong.Name = "colDiDong";
            this.colDiDong.Visible = true;
            this.colDiDong.VisibleIndex = 6;
            this.colDiDong.Width = 55;
            // 
            // colFax
            // 
            this.colFax.Caption = "Fax";
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            this.colFax.Visible = true;
            this.colFax.VisibleIndex = 7;
            this.colFax.Width = 55;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "Email";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 8;
            this.colEmail.Width = 55;
            // 
            // colWebSite
            // 
            this.colWebSite.Caption = "Website";
            this.colWebSite.FieldName = "Website";
            this.colWebSite.Name = "colWebSite";
            this.colWebSite.Visible = true;
            this.colWebSite.VisibleIndex = 9;
            this.colWebSite.Width = 49;
            // 
            // colMaSoThue
            // 
            this.colMaSoThue.Caption = "Mã Số Thuế";
            this.colMaSoThue.FieldName = "MaSoThue";
            this.colMaSoThue.Name = "colMaSoThue";
            this.colMaSoThue.Visible = true;
            this.colMaSoThue.VisibleIndex = 10;
            this.colMaSoThue.Width = 66;
            // 
            // colSoTaiKhoan
            // 
            this.colSoTaiKhoan.Caption = "Số Tài Khoản";
            this.colSoTaiKhoan.FieldName = "TaiKhoan";
            this.colSoTaiKhoan.Name = "colSoTaiKhoan";
            this.colSoTaiKhoan.Visible = true;
            this.colSoTaiKhoan.VisibleIndex = 11;
            this.colSoTaiKhoan.Width = 72;
            // 
            // colTenNganHang
            // 
            this.colTenNganHang.Caption = "Tên Ngân Hàng";
            this.colTenNganHang.FieldName = "NganHang";
            this.colTenNganHang.Name = "colTenNganHang";
            this.colTenNganHang.Visible = true;
            this.colTenNganHang.VisibleIndex = 12;
            this.colTenNganHang.Width = 84;
            // 
            // colConQuanLy
            // 
            this.colConQuanLy.Caption = "Còn Quản Lý";
            this.colConQuanLy.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colConQuanLy.FieldName = "ConQuanLy";
            this.colConQuanLy.Name = "colConQuanLy";
            this.colConQuanLy.Visible = true;
            this.colConQuanLy.VisibleIndex = 13;
            this.colConQuanLy.Width = 86;
            // 
            // colKhuVuc
            // 
            this.colKhuVuc.Caption = "Khu Vực";
            this.colKhuVuc.FieldName = "MaKhuVuc";
            this.colKhuVuc.Name = "colKhuVuc";
            this.colKhuVuc.Visible = true;
            this.colKhuVuc.VisibleIndex = 0;
            this.colKhuVuc.Width = 76;
            // 
            // colLaKhachLe
            // 
            this.colLaKhachLe.Caption = "Là Khách Lẻ";
            this.colLaKhachLe.FieldName = "LaKhachLe";
            this.colLaKhachLe.Name = "colLaKhachLe";
            // 
            // colGioiHanNo
            // 
            this.colGioiHanNo.Caption = "Giới Hạn Nợ";
            this.colGioiHanNo.FieldName = "GioiHanNo";
            this.colGioiHanNo.Name = "colGioiHanNo";
            this.colGioiHanNo.Width = 76;
            // 
            // colNoHienTai
            // 
            this.colNoHienTai.Caption = "Nợ Hiện Tại";
            this.colNoHienTai.FieldName = "NoHienTai";
            this.colNoHienTai.Name = "colNoHienTai";
            // 
            // colChietKhau
            // 
            this.colChietKhau.Caption = "Chiết Khấu";
            this.colChietKhau.FieldName = "ChietKhau";
            this.colChietKhau.Name = "colChietKhau";
            // 
            // colAccYahoo
            // 
            this.colAccYahoo.Caption = "Acc Yahoo";
            this.colAccYahoo.FieldName = "AccYahoo";
            this.colAccYahoo.Name = "colAccYahoo";
            // 
            // colAccSkype
            // 
            this.colAccSkype.Caption = "Acc Skype";
            this.colAccSkype.FieldName = "AccSkype";
            this.colAccSkype.Name = "colAccSkype";
            // 
            // ucKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ucKhachHang";
            this.Size = new System.Drawing.Size(864, 390);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraGrid.GridControl gcKhachHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gvKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKH;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKH;
        private DevExpress.XtraGrid.Columns.GridColumn colNguoiLienHe;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn colDiDong;
        private DevExpress.XtraGrid.Columns.GridColumn colFax;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colWebSite;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSoThue;
        private DevExpress.XtraGrid.Columns.GridColumn colSoTaiKhoan;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNganHang;
        private DevExpress.XtraGrid.Columns.GridColumn colConQuanLy;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colKhuVuc;
        private DevExpress.XtraGrid.Columns.GridColumn colLaKhachLe;
        private DevExpress.XtraGrid.Columns.GridColumn colGioiHanNo;
        private DevExpress.XtraGrid.Columns.GridColumn colNoHienTai;
        private DevExpress.XtraGrid.Columns.GridColumn colChietKhau;
        private DevExpress.XtraGrid.Columns.GridColumn colAccYahoo;
        private DevExpress.XtraGrid.Columns.GridColumn colAccSkype;

    }
}
