namespace QUANLYBANHANG.GUI.tabChucNang.TraTien
{
    partial class ucBangKePhieuChi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucBangKePhieuChi));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnXuat = new DevExpress.XtraEditors.SimpleButton();
            this.gcBangKeChiTien = new DevExpress.XtraGrid.GridControl();
            this.gvBangKeChiTien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colChungTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colConNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoTienTra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLyDo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaPhieuChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.saveFileDialogExcel = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcBangKeChiTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBangKeChiTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnXuat);
            this.groupControl1.Controls.Add(this.gcBangKeChiTien);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(983, 524);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Bảng Kê Phiếu Chi Tiền";
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
            // gcBangKeChiTien
            // 
            this.gcBangKeChiTien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcBangKeChiTien.Location = new System.Drawing.Point(0, 56);
            this.gcBangKeChiTien.MainView = this.gvBangKeChiTien;
            this.gcBangKeChiTien.Name = "gcBangKeChiTien";
            this.gcBangKeChiTien.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCalcEdit1});
            this.gcBangKeChiTien.Size = new System.Drawing.Size(983, 468);
            this.gcBangKeChiTien.TabIndex = 7;
            this.gcBangKeChiTien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBangKeChiTien});
            // 
            // gvBangKeChiTien
            // 
            this.gvBangKeChiTien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colChungTu,
            this.colNgay,
            this.colMaNCC,
            this.colTenNCC,
            this.colSoTien,
            this.colConNo,
            this.colSoTienTra,
            this.colLyDo,
            this.colMaPhieuChi,
            this.colMaNV});
            this.gvBangKeChiTien.GridControl = this.gcBangKeChiTien;
            this.gvBangKeChiTien.Name = "gvBangKeChiTien";
            // 
            // colChungTu
            // 
            this.colChungTu.Caption = "Chứng Từ";
            this.colChungTu.FieldName = "MaPhieuXuat";
            this.colChungTu.Name = "colChungTu";
            this.colChungTu.Visible = true;
            this.colChungTu.VisibleIndex = 1;
            this.colChungTu.Width = 90;
            // 
            // colNgay
            // 
            this.colNgay.Caption = "Ngày";
            this.colNgay.FieldName = "NgayLap";
            this.colNgay.Name = "colNgay";
            this.colNgay.Visible = true;
            this.colNgay.VisibleIndex = 2;
            this.colNgay.Width = 89;
            // 
            // colMaNCC
            // 
            this.colMaNCC.Caption = "Mã NCC";
            this.colMaNCC.FieldName = "MaNCC";
            this.colMaNCC.Name = "colMaNCC";
            this.colMaNCC.Visible = true;
            this.colMaNCC.VisibleIndex = 3;
            this.colMaNCC.Width = 89;
            // 
            // colTenNCC
            // 
            this.colTenNCC.Caption = "Nhà Cung Cấp";
            this.colTenNCC.FieldName = "TenNCC";
            this.colTenNCC.Name = "colTenNCC";
            this.colTenNCC.Visible = true;
            this.colTenNCC.VisibleIndex = 4;
            this.colTenNCC.Width = 92;
            // 
            // colSoTien
            // 
            this.colSoTien.Caption = "Số Tiền";
            this.colSoTien.ColumnEdit = this.repositoryItemCalcEdit1;
            this.colSoTien.FieldName = "SoTien";
            this.colSoTien.Name = "colSoTien";
            this.colSoTien.Visible = true;
            this.colSoTien.VisibleIndex = 5;
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
            this.colLyDo.VisibleIndex = 6;
            this.colLyDo.Width = 89;
            // 
            // colMaPhieuChi
            // 
            this.colMaPhieuChi.Caption = "Phiếu Chi";
            this.colMaPhieuChi.FieldName = "MaPhieuChi";
            this.colMaPhieuChi.Name = "colMaPhieuChi";
            this.colMaPhieuChi.Visible = true;
            this.colMaPhieuChi.VisibleIndex = 0;
            this.colMaPhieuChi.Width = 89;
            // 
            // colMaNV
            // 
            this.colMaNV.Caption = "MANV";
            this.colMaNV.FieldName = "MaNV";
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.Width = 95;
            // 
            // ucBangKePhieuChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "ucBangKePhieuChi";
            this.Size = new System.Drawing.Size(983, 524);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcBangKeChiTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBangKeChiTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnXuat;
        private DevExpress.XtraGrid.GridControl gcBangKeChiTien;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBangKeChiTien;
        private DevExpress.XtraGrid.Columns.GridColumn colChungTu;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNCC;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNCC;
        private DevExpress.XtraGrid.Columns.GridColumn colSoTien;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colConNo;
        private DevExpress.XtraGrid.Columns.GridColumn colSoTienTra;
        private DevExpress.XtraGrid.Columns.GridColumn colLyDo;
        private DevExpress.XtraGrid.Columns.GridColumn colMaPhieuChi;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNV;
        private System.Windows.Forms.SaveFileDialog saveFileDialogExcel;
    }
}
