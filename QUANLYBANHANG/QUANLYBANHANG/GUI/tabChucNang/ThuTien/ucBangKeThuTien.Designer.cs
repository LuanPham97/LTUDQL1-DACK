namespace QUANLYBANHANG.GUI.tabChucNang
{
    partial class ucBangKeThuTien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucBangKeThuTien));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnXuat = new DevExpress.XtraEditors.SimpleButton();
            this.gcBangKeThuTien = new DevExpress.XtraGrid.GridControl();
            this.gvBangKeThuTien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colChungTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaKh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colConNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoTienTra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLyDo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaPhieuThu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.saveFileDialogExcel = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcBangKeThuTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBangKeThuTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnXuat);
            this.groupControl1.Controls.Add(this.gcBangKeThuTien);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(918, 494);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Bảng Kê Phiếu Thu Tiền";
            // 
            // btnXuat
            // 
            this.btnXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXuat.ImageOptions.Image")));
            this.btnXuat.Location = new System.Drawing.Point(14, 27);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(75, 23);
            this.btnXuat.TabIndex = 8;
            this.btnXuat.Text = "Xuất";
            // 
            // gcBangKeThuTien
            // 
            this.gcBangKeThuTien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcBangKeThuTien.Location = new System.Drawing.Point(0, 56);
            this.gcBangKeThuTien.MainView = this.gvBangKeThuTien;
            this.gcBangKeThuTien.Name = "gcBangKeThuTien";
            this.gcBangKeThuTien.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCalcEdit1});
            this.gcBangKeThuTien.Size = new System.Drawing.Size(918, 438);
            this.gcBangKeThuTien.TabIndex = 7;
            this.gcBangKeThuTien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBangKeThuTien});
            // 
            // gvBangKeThuTien
            // 
            this.gvBangKeThuTien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colChungTu,
            this.colNgay,
            this.colMaKh,
            this.colKhachHang,
            this.colSoTien,
            this.colConNo,
            this.colSoTienTra,
            this.colLyDo,
            this.colMaPhieuThu,
            this.colMaNV});
            this.gvBangKeThuTien.GridControl = this.gcBangKeThuTien;
            this.gvBangKeThuTien.GroupCount = 1;
            this.gvBangKeThuTien.Name = "gvBangKeThuTien";
            this.gvBangKeThuTien.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colKhachHang, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colChungTu
            // 
            this.colChungTu.Caption = "Chứng Từ";
            this.colChungTu.FieldName = "MaPhieuXuat";
            this.colChungTu.Name = "colChungTu";
            this.colChungTu.Visible = true;
            this.colChungTu.VisibleIndex = 2;
            this.colChungTu.Width = 90;
            // 
            // colNgay
            // 
            this.colNgay.Caption = "Ngày";
            this.colNgay.FieldName = "NgayLap";
            this.colNgay.Name = "colNgay";
            this.colNgay.Visible = true;
            this.colNgay.VisibleIndex = 1;
            this.colNgay.Width = 89;
            // 
            // colMaKh
            // 
            this.colMaKh.Caption = "Mã KH";
            this.colMaKh.FieldName = "MaKH";
            this.colMaKh.Name = "colMaKh";
            this.colMaKh.Visible = true;
            this.colMaKh.VisibleIndex = 3;
            this.colMaKh.Width = 89;
            // 
            // colKhachHang
            // 
            this.colKhachHang.Caption = "Khách Hàng";
            this.colKhachHang.FieldName = "TenKH";
            this.colKhachHang.Name = "colKhachHang";
            this.colKhachHang.Visible = true;
            this.colKhachHang.VisibleIndex = 1;
            this.colKhachHang.Width = 92;
            // 
            // colSoTien
            // 
            this.colSoTien.Caption = "Số Tiền";
            this.colSoTien.ColumnEdit = this.repositoryItemCalcEdit1;
            this.colSoTien.FieldName = "SoTien";
            this.colSoTien.Name = "colSoTien";
            this.colSoTien.Visible = true;
            this.colSoTien.VisibleIndex = 4;
            this.colSoTien.Width = 89;
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
            // colConNo
            // 
            this.colConNo.Caption = "Còn Nợ";
            this.colConNo.ColumnEdit = this.repositoryItemCalcEdit1;
            this.colConNo.FieldName = "ConNo";
            this.colConNo.Name = "colConNo";
            this.colConNo.Width = 89;
            // 
            // colSoTienTra
            // 
            this.colSoTienTra.Caption = "Số Tiền Trả";
            this.colSoTienTra.ColumnEdit = this.repositoryItemCalcEdit1;
            this.colSoTienTra.FieldName = "SoTienTra";
            this.colSoTienTra.Name = "colSoTienTra";
            this.colSoTienTra.Width = 89;
            // 
            // colLyDo
            // 
            this.colLyDo.Caption = "Ghi Chú";
            this.colLyDo.FieldName = "LyDo";
            this.colLyDo.Name = "colLyDo";
            this.colLyDo.Visible = true;
            this.colLyDo.VisibleIndex = 5;
            this.colLyDo.Width = 89;
            // 
            // colMaPhieuThu
            // 
            this.colMaPhieuThu.Caption = "Phiếu Thu";
            this.colMaPhieuThu.FieldName = "MaPhieuThu";
            this.colMaPhieuThu.Name = "colMaPhieuThu";
            this.colMaPhieuThu.Visible = true;
            this.colMaPhieuThu.VisibleIndex = 0;
            this.colMaPhieuThu.Width = 89;
            // 
            // colMaNV
            // 
            this.colMaNV.Caption = "MANV";
            this.colMaNV.FieldName = "MaNV";
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.Width = 95;
            // 
            // ucBangKeThuTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "ucBangKeThuTien";
            this.Size = new System.Drawing.Size(918, 494);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcBangKeThuTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBangKeThuTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gcBangKeThuTien;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBangKeThuTien;
        private DevExpress.XtraGrid.Columns.GridColumn colChungTu;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKh;
        private DevExpress.XtraGrid.Columns.GridColumn colKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn colSoTien;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colConNo;
        private DevExpress.XtraGrid.Columns.GridColumn colSoTienTra;
        private DevExpress.XtraGrid.Columns.GridColumn colLyDo;
        private DevExpress.XtraEditors.SimpleButton btnXuat;
        private DevExpress.XtraGrid.Columns.GridColumn colMaPhieuThu;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNV;
        private System.Windows.Forms.SaveFileDialog saveFileDialogExcel;
    }
}
