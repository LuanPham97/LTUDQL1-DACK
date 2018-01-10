namespace QUANLYBANHANG.GUI.tabChucNang
{
    partial class ucDSCongNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDSCongNo));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gcPhieuThuTien = new DevExpress.XtraGrid.GridControl();
            this.gvThuTien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colChungTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaKh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colDaTra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConLai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDienGiai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXuat = new DevExpress.XtraEditors.SimpleButton();
            this.btnLapPhieuThu = new DevExpress.XtraEditors.SimpleButton();
            this.btnXem = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deTuNgay = new DevExpress.XtraEditors.DateEdit();
            this.deDenNgay = new DevExpress.XtraEditors.DateEdit();
            this.saveFileDialogExcel = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhieuThuTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThuTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTuNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTuNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDenNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDenNgay.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.deDenNgay);
            this.groupControl1.Controls.Add(this.deTuNgay);
            this.groupControl1.Controls.Add(this.gcPhieuThuTien);
            this.groupControl1.Controls.Add(this.btnXuat);
            this.groupControl1.Controls.Add(this.btnLapPhieuThu);
            this.groupControl1.Controls.Add(this.btnXem);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(860, 520);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Danh Sách Công Nợ Chi Tiết";
            // 
            // gcPhieuThuTien
            // 
            this.gcPhieuThuTien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcPhieuThuTien.Location = new System.Drawing.Point(2, 51);
            this.gcPhieuThuTien.MainView = this.gvThuTien;
            this.gcPhieuThuTien.Name = "gcPhieuThuTien";
            this.gcPhieuThuTien.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCalcEdit1});
            this.gcPhieuThuTien.Size = new System.Drawing.Size(856, 467);
            this.gcPhieuThuTien.TabIndex = 6;
            this.gcPhieuThuTien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvThuTien});
            // 
            // gvThuTien
            // 
            this.gvThuTien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colChungTu,
            this.colNgay,
            this.colMaKh,
            this.colKhachHang,
            this.colSoTien,
            this.colDaTra,
            this.colConLai,
            this.colDienGiai});
            this.gvThuTien.GridControl = this.gcPhieuThuTien;
            this.gvThuTien.GroupCount = 1;
            this.gvThuTien.Name = "gvThuTien";
            this.gvThuTien.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colKhachHang, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colChungTu
            // 
            this.colChungTu.Caption = "Chứng Từ";
            this.colChungTu.FieldName = "MaPhieu";
            this.colChungTu.Name = "colChungTu";
            this.colChungTu.Visible = true;
            this.colChungTu.VisibleIndex = 0;
            // 
            // colNgay
            // 
            this.colNgay.Caption = "Ngày";
            this.colNgay.FieldName = "NgayLap";
            this.colNgay.Name = "colNgay";
            this.colNgay.Visible = true;
            this.colNgay.VisibleIndex = 1;
            // 
            // colMaKh
            // 
            this.colMaKh.Caption = "Mã KH";
            this.colMaKh.FieldName = "MaKH";
            this.colMaKh.Name = "colMaKh";
            this.colMaKh.Visible = true;
            this.colMaKh.VisibleIndex = 2;
            // 
            // colKhachHang
            // 
            this.colKhachHang.Caption = "Khách Hàng";
            this.colKhachHang.FieldName = "TenKH";
            this.colKhachHang.Name = "colKhachHang";
            this.colKhachHang.Visible = true;
            this.colKhachHang.VisibleIndex = 3;
            // 
            // colSoTien
            // 
            this.colSoTien.Caption = "Số Tiền";
            this.colSoTien.ColumnEdit = this.repositoryItemCalcEdit1;
            this.colSoTien.FieldName = "TongTien";
            this.colSoTien.Name = "colSoTien";
            this.colSoTien.Visible = true;
            this.colSoTien.VisibleIndex = 3;
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
            // colDaTra
            // 
            this.colDaTra.Caption = "Đã Trả";
            this.colDaTra.ColumnEdit = this.repositoryItemCalcEdit1;
            this.colDaTra.FieldName = "DaTra";
            this.colDaTra.Name = "colDaTra";
            this.colDaTra.Visible = true;
            this.colDaTra.VisibleIndex = 4;
            // 
            // colConLai
            // 
            this.colConLai.Caption = "Còn Lại";
            this.colConLai.ColumnEdit = this.repositoryItemCalcEdit1;
            this.colConLai.FieldName = "ConLai";
            this.colConLai.Name = "colConLai";
            this.colConLai.UnboundExpression = "[TongTien] - [DaTra]";
            this.colConLai.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.colConLai.Visible = true;
            this.colConLai.VisibleIndex = 5;
            // 
            // colDienGiai
            // 
            this.colDienGiai.Caption = "Diễn Giải";
            this.colDienGiai.FieldName = "GhiChu";
            this.colDienGiai.Name = "colDienGiai";
            this.colDienGiai.Visible = true;
            this.colDienGiai.VisibleIndex = 6;
            // 
            // btnXuat
            // 
            this.btnXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXuat.ImageOptions.Image")));
            this.btnXuat.Location = new System.Drawing.Point(515, 22);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(75, 23);
            this.btnXuat.TabIndex = 5;
            this.btnXuat.Text = "Xuất";
            // 
            // btnLapPhieuThu
            // 
            this.btnLapPhieuThu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLapPhieuThu.ImageOptions.Image")));
            this.btnLapPhieuThu.Location = new System.Drawing.Point(404, 22);
            this.btnLapPhieuThu.Name = "btnLapPhieuThu";
            this.btnLapPhieuThu.Size = new System.Drawing.Size(105, 23);
            this.btnLapPhieuThu.TabIndex = 5;
            this.btnLapPhieuThu.Text = "Lập phiếu thu";
            // 
            // btnXem
            // 
            this.btnXem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXem.ImageOptions.Image")));
            this.btnXem.Location = new System.Drawing.Point(323, 22);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 5;
            this.btnXem.Text = "Xem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ";
            // 
            // deTuNgay
            // 
            this.deTuNgay.EditValue = null;
            this.deTuNgay.Location = new System.Drawing.Point(41, 25);
            this.deTuNgay.Name = "deTuNgay";
            this.deTuNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deTuNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deTuNgay.Properties.EditFormat.FormatString = "dd/MM/yy";
            this.deTuNgay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deTuNgay.Size = new System.Drawing.Size(107, 20);
            this.deTuNgay.TabIndex = 7;
            // 
            // deDenNgay
            // 
            this.deDenNgay.EditValue = null;
            this.deDenNgay.Location = new System.Drawing.Point(187, 25);
            this.deDenNgay.Name = "deDenNgay";
            this.deDenNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDenNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDenNgay.Properties.EditFormat.FormatString = "dd/MM/yy";
            this.deDenNgay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deDenNgay.Size = new System.Drawing.Size(107, 20);
            this.deDenNgay.TabIndex = 7;
            // 
            // ucDSCongNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "ucDSCongNo";
            this.Size = new System.Drawing.Size(860, 520);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhieuThuTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThuTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTuNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTuNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDenNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDenNgay.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gcPhieuThuTien;
        private DevExpress.XtraGrid.Views.Grid.GridView gvThuTien;
        private DevExpress.XtraGrid.Columns.GridColumn colChungTu;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKh;
        private DevExpress.XtraGrid.Columns.GridColumn colKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn colSoTien;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colDaTra;
        private DevExpress.XtraGrid.Columns.GridColumn colConLai;
        private DevExpress.XtraGrid.Columns.GridColumn colDienGiai;
        private DevExpress.XtraEditors.SimpleButton btnXuat;
        private DevExpress.XtraEditors.SimpleButton btnLapPhieuThu;
        private DevExpress.XtraEditors.SimpleButton btnXem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit deDenNgay;
        private DevExpress.XtraEditors.DateEdit deTuNgay;
        private System.Windows.Forms.SaveFileDialog saveFileDialogExcel;
    }
}
