namespace QUANLYBANHANG.GUI.tabChucNang
{
    partial class ucThuTien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucThuTien));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gcChucNang = new DevExpress.XtraEditors.GroupControl();
            this.gcBangKe = new DevExpress.XtraEditors.GroupControl();
            this.btnDSPCongNo = new DevExpress.XtraEditors.SimpleButton();
            this.gcPhieuThu = new DevExpress.XtraEditors.GroupControl();
            this.btnDSPThu = new DevExpress.XtraEditors.SimpleButton();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bbiThem = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSua = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDong = new DevExpress.XtraBars.BarButtonItem();
            this.bbiXoa = new DevExpress.XtraBars.BarButtonItem();
            this.rdmThuTien = new DevExpress.XtraBars.Ribbon.RadialMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcChucNang)).BeginInit();
            this.gcChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcBangKe)).BeginInit();
            this.gcBangKe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhieuThu)).BeginInit();
            this.gcPhieuThu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdmThuTien)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gcChucNang);
            this.splitContainer1.Size = new System.Drawing.Size(1201, 551);
            this.splitContainer1.SplitterDistance = 185;
            this.splitContainer1.TabIndex = 0;
            // 
            // gcChucNang
            // 
            this.gcChucNang.Controls.Add(this.gcBangKe);
            this.gcChucNang.Controls.Add(this.gcPhieuThu);
            this.gcChucNang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcChucNang.Location = new System.Drawing.Point(0, 0);
            this.gcChucNang.Name = "gcChucNang";
            this.gcChucNang.Size = new System.Drawing.Size(185, 551);
            this.gcChucNang.TabIndex = 2;
            this.gcChucNang.Text = "Chức Năng";
            // 
            // gcBangKe
            // 
            this.gcBangKe.Controls.Add(this.btnDSPCongNo);
            this.gcBangKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcBangKe.Location = new System.Drawing.Point(2, 146);
            this.gcBangKe.Name = "gcBangKe";
            this.gcBangKe.Size = new System.Drawing.Size(181, 402);
            this.gcBangKe.TabIndex = 1;
            this.gcBangKe.Text = "Bảng Kê";
            // 
            // btnDSPCongNo
            // 
            this.btnDSPCongNo.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnDSPCongNo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDSPCongNo.ImageOptions.Image")));
            this.btnDSPCongNo.Location = new System.Drawing.Point(5, 41);
            this.btnDSPCongNo.Name = "btnDSPCongNo";
            this.btnDSPCongNo.Size = new System.Drawing.Size(179, 64);
            this.btnDSPCongNo.TabIndex = 0;
            this.btnDSPCongNo.Text = "Danh Sách Phiếu Công Nợ";
            // 
            // gcPhieuThu
            // 
            this.gcPhieuThu.Controls.Add(this.btnDSPThu);
            this.gcPhieuThu.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcPhieuThu.Location = new System.Drawing.Point(2, 20);
            this.gcPhieuThu.Name = "gcPhieuThu";
            this.gcPhieuThu.Size = new System.Drawing.Size(181, 126);
            this.gcPhieuThu.TabIndex = 0;
            this.gcPhieuThu.Text = "Phiếu Thu";
            // 
            // btnDSPThu
            // 
            this.btnDSPThu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnDSPThu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDSPThu.ImageOptions.Image")));
            this.btnDSPThu.Location = new System.Drawing.Point(5, 31);
            this.btnDSPThu.Name = "btnDSPThu";
            this.btnDSPThu.Size = new System.Drawing.Size(177, 75);
            this.btnDSPThu.TabIndex = 0;
            this.btnDSPThu.Text = "Danh Sách Phiếu Thu";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1201, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 551);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1201, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 551);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1201, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 551);
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
            // rdmThuTien
            // 
            this.rdmThuTien.InnerRadius = 0;
            this.rdmThuTien.ItemAutoSize = DevExpress.XtraBars.Ribbon.RadialMenuItemAutoSize.Spring;
            this.rdmThuTien.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiSua),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiDong),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiXoa)});
            this.rdmThuTien.Manager = this.barManager1;
            this.rdmThuTien.MenuRadius = 127;
            this.rdmThuTien.Name = "rdmThuTien";
            // 
            // ucThuTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ucThuTien";
            this.Size = new System.Drawing.Size(1201, 551);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcChucNang)).EndInit();
            this.gcChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcBangKe)).EndInit();
            this.gcBangKe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPhieuThu)).EndInit();
            this.gcPhieuThu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdmThuTien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.GroupControl gcChucNang;
        private DevExpress.XtraEditors.GroupControl gcBangKe;
        private DevExpress.XtraEditors.SimpleButton btnDSPCongNo;
        private DevExpress.XtraEditors.GroupControl gcPhieuThu;
        private DevExpress.XtraEditors.SimpleButton btnDSPThu;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bbiThem;
        private DevExpress.XtraBars.BarButtonItem bbiSua;
        private DevExpress.XtraBars.BarButtonItem bbiDong;
        private DevExpress.XtraBars.BarButtonItem bbiXoa;
        private DevExpress.XtraBars.Ribbon.RadialMenu rdmThuTien;
    }
}
