namespace QUANLYBANHANG.GUI
{
    partial class frmThemSuaHangHoa
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions4 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemSuaHangHoa));
            this.label1 = new System.Windows.Forms.Label();
            this.cbLoaiHH = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lkueKhoMacDinh = new DevExpress.XtraEditors.LookUpEdit();
            this.lkuePhanLoai = new DevExpress.XtraEditors.LookUpEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.txtMaVachNSX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lkueDonVi = new DevExpress.XtraEditors.LookUpEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.txtXuatXu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nmrTonKhoToiThieu = new System.Windows.Forms.NumericUpDown();
            this.nmrTonKhoHienTai = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.piceHinhAnh = new DevExpress.XtraEditors.PictureEdit();
            this.lkueNCC = new DevExpress.XtraEditors.LookUpEdit();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.checkBConQuanLy = new DevExpress.XtraEditors.CheckEdit();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.nmrGiaMua = new DevExpress.XtraEditors.CalcEdit();
            this.nmrGiaBanSi = new DevExpress.XtraEditors.CalcEdit();
            this.nmrGiaBanLe = new DevExpress.XtraEditors.CalcEdit();
            ((System.ComponentModel.ISupportInitialize)(this.lkueKhoMacDinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuePhanLoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkueDonVi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrTonKhoToiThieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrTonKhoHienTai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piceHinhAnh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkueNCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBConQuanLy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrGiaMua.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrGiaBanSi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrGiaBanLe.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại Hàng Hóa (*)";
            // 
            // cbLoaiHH
            // 
            this.cbLoaiHH.FormattingEnabled = true;
            this.cbLoaiHH.Location = new System.Drawing.Point(116, 10);
            this.cbLoaiHH.Name = "cbLoaiHH";
            this.cbLoaiHH.Size = new System.Drawing.Size(162, 21);
            this.cbLoaiHH.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kho Mặc Định (*)";
            // 
            // lkueKhoMacDinh
            // 
            this.lkueKhoMacDinh.Location = new System.Drawing.Point(406, 11);
            this.lkueKhoMacDinh.Name = "lkueKhoMacDinh";
            this.lkueKhoMacDinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), "Thêm Kho")});
            this.lkueKhoMacDinh.Size = new System.Drawing.Size(141, 20);
            this.lkueKhoMacDinh.TabIndex = 1;
            // 
            // lkuePhanLoai
            // 
            this.lkuePhanLoai.Location = new System.Drawing.Point(116, 73);
            this.lkuePhanLoai.Name = "lkuePhanLoai";
            this.lkuePhanLoai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), "Thêm Phân Loại")});
            this.lkuePhanLoai.Size = new System.Drawing.Size(429, 20);
            this.lkuePhanLoai.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phân Loại (*)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã Hàng (*)";
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(116, 99);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(162, 20);
            this.txtMaHang.TabIndex = 3;
            // 
            // txtMaVachNSX
            // 
            this.txtMaVachNSX.Location = new System.Drawing.Point(406, 99);
            this.txtMaVachNSX.Name = "txtMaVachNSX";
            this.txtMaVachNSX.Size = new System.Drawing.Size(139, 20);
            this.txtMaVachNSX.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mã Vạch NSX";
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(116, 125);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(364, 20);
            this.txtTenHang.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tên Hàng (*)";
            // 
            // lkueDonVi
            // 
            this.lkueDonVi.Location = new System.Drawing.Point(116, 151);
            this.lkueDonVi.Name = "lkueDonVi";
            this.lkueDonVi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), "Thêm Đơn Vị")});
            this.lkueDonVi.Size = new System.Drawing.Size(162, 20);
            this.lkueDonVi.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Đơn Vị (*)";
            // 
            // txtXuatXu
            // 
            this.txtXuatXu.Location = new System.Drawing.Point(116, 177);
            this.txtXuatXu.Name = "txtXuatXu";
            this.txtXuatXu.Size = new System.Drawing.Size(162, 20);
            this.txtXuatXu.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Xuất Xứ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Tồn Kho Tối Thiểu";
            // 
            // nmrTonKhoToiThieu
            // 
            this.nmrTonKhoToiThieu.Location = new System.Drawing.Point(116, 206);
            this.nmrTonKhoToiThieu.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nmrTonKhoToiThieu.Name = "nmrTonKhoToiThieu";
            this.nmrTonKhoToiThieu.Size = new System.Drawing.Size(162, 20);
            this.nmrTonKhoToiThieu.TabIndex = 8;
            // 
            // nmrTonKhoHienTai
            // 
            this.nmrTonKhoHienTai.Location = new System.Drawing.Point(116, 232);
            this.nmrTonKhoHienTai.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nmrTonKhoHienTai.Name = "nmrTonKhoHienTai";
            this.nmrTonKhoHienTai.Size = new System.Drawing.Size(162, 20);
            this.nmrTonKhoHienTai.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Tồn Kho Hiện Tại";
            // 
            // piceHinhAnh
            // 
            this.piceHinhAnh.Cursor = System.Windows.Forms.Cursors.Default;
            this.piceHinhAnh.Location = new System.Drawing.Point(302, 151);
            this.piceHinhAnh.Name = "piceHinhAnh";
            this.piceHinhAnh.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.piceHinhAnh.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.piceHinhAnh.Properties.ZoomAccelerationFactor = 1D;
            this.piceHinhAnh.Size = new System.Drawing.Size(245, 134);
            this.piceHinhAnh.TabIndex = 10;
            // 
            // lkueNCC
            // 
            this.lkueNCC.Location = new System.Drawing.Point(116, 338);
            this.lkueNCC.Name = "lkueNCC";
            this.lkueNCC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", -1, true, true, false, editorButtonImageOptions4, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), "Thêm NCC")});
            this.lkueNCC.Size = new System.Drawing.Size(431, 20);
            this.lkueNCC.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 341);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Nhà Cung Cấp";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 366);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Giá Mua";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(325, 366);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Giá Bán Lẻ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 392);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Giá Bán Sỉ";
            // 
            // btnLuu
            // 
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(321, 436);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(101, 23);
            this.btnLuu.TabIndex = 15;
            this.btnLuu.Text = "Lưu";
            // 
            // checkBConQuanLy
            // 
            this.checkBConQuanLy.Location = new System.Drawing.Point(328, 389);
            this.checkBConQuanLy.Name = "checkBConQuanLy";
            this.checkBConQuanLy.Properties.Caption = "Còn Quản Lý";
            this.checkBConQuanLy.Size = new System.Drawing.Size(94, 19);
            this.checkBConQuanLy.TabIndex = 34;
            // 
            // btnDong
            // 
            this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.Image")));
            this.btnDong.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(443, 436);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(101, 23);
            this.btnDong.TabIndex = 16;
            this.btnDong.Text = "Đóng";
            // 
            // nmrGiaMua
            // 
            this.nmrGiaMua.Location = new System.Drawing.Point(116, 361);
            this.nmrGiaMua.Name = "nmrGiaMua";
            this.nmrGiaMua.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nmrGiaMua.Properties.DisplayFormat.FormatString = "n0";
            this.nmrGiaMua.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.nmrGiaMua.Properties.Mask.EditMask = "n0";
            this.nmrGiaMua.Properties.NullText = "0";
            this.nmrGiaMua.Size = new System.Drawing.Size(162, 20);
            this.nmrGiaMua.TabIndex = 35;
            // 
            // nmrGiaBanSi
            // 
            this.nmrGiaBanSi.Location = new System.Drawing.Point(116, 389);
            this.nmrGiaBanSi.Name = "nmrGiaBanSi";
            this.nmrGiaBanSi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nmrGiaBanSi.Size = new System.Drawing.Size(162, 20);
            this.nmrGiaBanSi.TabIndex = 36;
            // 
            // nmrGiaBanLe
            // 
            this.nmrGiaBanLe.Location = new System.Drawing.Point(385, 361);
            this.nmrGiaBanLe.Name = "nmrGiaBanLe";
            this.nmrGiaBanLe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nmrGiaBanLe.Size = new System.Drawing.Size(162, 20);
            this.nmrGiaBanLe.TabIndex = 37;
            // 
            // frmThemSuaHangHoa
            // 
            this.AcceptButton = this.btnLuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 471);
            this.Controls.Add(this.nmrGiaBanLe);
            this.Controls.Add(this.nmrGiaBanSi);
            this.Controls.Add(this.nmrGiaMua);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.checkBConQuanLy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lkueNCC);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.piceHinhAnh);
            this.Controls.Add(this.nmrTonKhoHienTai);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nmrTonKhoToiThieu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtXuatXu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lkueDonVi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTenHang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMaVachNSX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMaHang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lkuePhanLoai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lkueKhoMacDinh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbLoaiHH);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThemSuaHangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThemHangHoa";
            ((System.ComponentModel.ISupportInitialize)(this.lkueKhoMacDinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuePhanLoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkueDonVi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrTonKhoToiThieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrTonKhoHienTai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piceHinhAnh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkueNCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBConQuanLy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrGiaMua.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrGiaBanSi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrGiaBanLe.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLoaiHH;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.LookUpEdit lkueKhoMacDinh;
        private DevExpress.XtraEditors.LookUpEdit lkuePhanLoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.TextBox txtMaVachNSX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.LookUpEdit lkueDonVi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtXuatXu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nmrTonKhoToiThieu;
        private System.Windows.Forms.NumericUpDown nmrTonKhoHienTai;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.PictureEdit piceHinhAnh;
        private DevExpress.XtraEditors.LookUpEdit lkueNCC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.CheckEdit checkBConQuanLy;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.CalcEdit nmrGiaMua;
        private DevExpress.XtraEditors.CalcEdit nmrGiaBanSi;
        private DevExpress.XtraEditors.CalcEdit nmrGiaBanLe;
    }
}