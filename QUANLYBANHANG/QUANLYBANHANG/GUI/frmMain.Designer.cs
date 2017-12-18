﻿namespace QUANLYBANHANG
{
    partial class frmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.rbcMain = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnHangHoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhanQuyen = new DevExpress.XtraBars.BarButtonItem();
            this.rbpHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgBaoMat = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpDanhMuc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgKhoHang = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpChucNang = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpTroGiup = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pnMain = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.rbcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.SuspendLayout();
            // 
            // rbcMain
            // 
            this.rbcMain.ExpandCollapseItem.Id = 0;
            this.rbcMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rbcMain.ExpandCollapseItem,
            this.btnHangHoa,
            this.btnPhanQuyen});
            this.rbcMain.Location = new System.Drawing.Point(0, 0);
            this.rbcMain.MaxItemId = 6;
            this.rbcMain.Name = "rbcMain";
            this.rbcMain.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbpHeThong,
            this.rbpDanhMuc,
            this.rbpChucNang,
            this.rbpTroGiup});
            this.rbcMain.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.rbcMain.Size = new System.Drawing.Size(828, 143);
            // 
            // btnHangHoa
            // 
            this.btnHangHoa.Caption = "Hàng Hóa";
            this.btnHangHoa.Id = 1;
            this.btnHangHoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHangHoa.ImageOptions.Image")));
            this.btnHangHoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHangHoa.ImageOptions.LargeImage")));
            this.btnHangHoa.Name = "btnHangHoa";
            // 
            // btnPhanQuyen
            // 
            this.btnPhanQuyen.Caption = "Phân Quyền";
            this.btnPhanQuyen.Id = 4;
            this.btnPhanQuyen.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhanQuyen.ImageOptions.Image")));
            this.btnPhanQuyen.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhanQuyen.ImageOptions.LargeImage")));
            this.btnPhanQuyen.Name = "btnPhanQuyen";
            // 
            // rbpHeThong
            // 
            this.rbpHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgBaoMat});
            this.rbpHeThong.Name = "rbpHeThong";
            this.rbpHeThong.Text = "Hệ Thống";
            // 
            // rpgBaoMat
            // 
            this.rpgBaoMat.ItemLinks.Add(this.btnPhanQuyen);
            this.rpgBaoMat.Name = "rpgBaoMat";
            this.rpgBaoMat.Text = "Bảo Mật";
            // 
            // rbpDanhMuc
            // 
            this.rbpDanhMuc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgKhoHang});
            this.rbpDanhMuc.Name = "rbpDanhMuc";
            this.rbpDanhMuc.Text = "Danh Mục";
            // 
            // rpgKhoHang
            // 
            this.rpgKhoHang.ItemLinks.Add(this.btnHangHoa);
            this.rpgKhoHang.Name = "rpgKhoHang";
            this.rpgKhoHang.Text = "Kho Hàng";
            // 
            // rbpChucNang
            // 
            this.rbpChucNang.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.rbpChucNang.Name = "rbpChucNang";
            this.rbpChucNang.Text = "Chức Năng";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // rbpTroGiup
            // 
            this.rbpTroGiup.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.rbpTroGiup.Name = "rbpTroGiup";
            this.rbpTroGiup.Text = "Trợ Giúp";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // pnMain
            // 
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 143);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(828, 384);
            this.pnMain.TabIndex = 5;
            // 
            // frmMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 527);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.rbcMain);
            this.Name = "frmMain";
            this.Ribbon = this.rbcMain;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHẦN MỀM QUẢN LÝ BÁN HÀNG";
            ((System.ComponentModel.ISupportInitialize)(this.rbcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl rbcMain;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgBaoMat;
        private DevExpress.XtraBars.BarButtonItem btnHangHoa;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpDanhMuc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgKhoHang;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpChucNang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpTroGiup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraEditors.PanelControl pnMain;
        private DevExpress.XtraBars.BarButtonItem btnPhanQuyen;
    }
}
