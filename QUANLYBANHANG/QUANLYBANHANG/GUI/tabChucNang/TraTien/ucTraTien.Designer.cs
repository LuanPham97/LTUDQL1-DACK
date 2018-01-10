namespace QUANLYBANHANG.GUI.tabChucNang.TraTien
{
    partial class ucTraTien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucTraTien));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gcChucNang = new DevExpress.XtraEditors.GroupControl();
            this.gcBangKe = new DevExpress.XtraEditors.GroupControl();
            this.btnDSPCongNo = new DevExpress.XtraEditors.SimpleButton();
            this.gcPhieuThu = new DevExpress.XtraEditors.GroupControl();
            this.btnDSPChi = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcChucNang)).BeginInit();
            this.gcChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcBangKe)).BeginInit();
            this.gcBangKe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhieuThu)).BeginInit();
            this.gcPhieuThu.SuspendLayout();
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
            this.splitContainer1.Size = new System.Drawing.Size(959, 524);
            this.splitContainer1.SplitterDistance = 195;
            this.splitContainer1.TabIndex = 4;
            // 
            // gcChucNang
            // 
            this.gcChucNang.Controls.Add(this.gcBangKe);
            this.gcChucNang.Controls.Add(this.gcPhieuThu);
            this.gcChucNang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcChucNang.Location = new System.Drawing.Point(0, 0);
            this.gcChucNang.Name = "gcChucNang";
            this.gcChucNang.Size = new System.Drawing.Size(195, 524);
            this.gcChucNang.TabIndex = 2;
            this.gcChucNang.Text = "Chức Năng";
            // 
            // gcBangKe
            // 
            this.gcBangKe.Controls.Add(this.btnDSPCongNo);
            this.gcBangKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcBangKe.Location = new System.Drawing.Point(2, 146);
            this.gcBangKe.Name = "gcBangKe";
            this.gcBangKe.Size = new System.Drawing.Size(191, 402);
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
            this.gcPhieuThu.Controls.Add(this.btnDSPChi);
            this.gcPhieuThu.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcPhieuThu.Location = new System.Drawing.Point(2, 20);
            this.gcPhieuThu.Name = "gcPhieuThu";
            this.gcPhieuThu.Size = new System.Drawing.Size(191, 126);
            this.gcPhieuThu.TabIndex = 0;
            this.gcPhieuThu.Text = "Phiếu Thu";
            // 
            // btnDSPChi
            // 
            this.btnDSPChi.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnDSPChi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDSPChi.ImageOptions.Image")));
            this.btnDSPChi.Location = new System.Drawing.Point(5, 31);
            this.btnDSPChi.Name = "btnDSPChi";
            this.btnDSPChi.Size = new System.Drawing.Size(177, 75);
            this.btnDSPChi.TabIndex = 0;
            this.btnDSPChi.Text = "Danh Sách Phiếu Chi";
            // 
            // ucTraTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ucTraTien";
            this.Size = new System.Drawing.Size(959, 524);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcChucNang)).EndInit();
            this.gcChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcBangKe)).EndInit();
            this.gcBangKe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPhieuThu)).EndInit();
            this.gcPhieuThu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.GroupControl gcChucNang;
        private DevExpress.XtraEditors.GroupControl gcBangKe;
        private DevExpress.XtraEditors.SimpleButton btnDSPCongNo;
        private DevExpress.XtraEditors.GroupControl gcPhieuThu;
        private DevExpress.XtraEditors.SimpleButton btnDSPChi;
    }
}
