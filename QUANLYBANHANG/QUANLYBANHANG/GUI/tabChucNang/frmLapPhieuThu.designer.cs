namespace QUANLYBANHANG.GUI.tabChucNang
{
    partial class frmLapPhieuThu
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.deNgayLap = new DevExpress.XtraEditors.DateEdit();
            this.txtChungTu = new System.Windows.Forms.TextBox();
            this.lkueKhachHang = new DevExpress.XtraEditors.LookUpEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.rtbLyDo = new System.Windows.Forms.RichTextBox();
            this.lkueNhanVien = new DevExpress.XtraEditors.LookUpEdit();
            this.ceSoTienTra = new DevExpress.XtraEditors.CalcEdit();
            this.ceConNo = new DevExpress.XtraEditors.CalcEdit();
            this.ceSoTien = new DevExpress.XtraEditors.CalcEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnBoQua = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayLap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayLap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkueKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkueNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceSoTienTra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceConNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceSoTien.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.deNgayLap);
            this.groupControl1.Controls.Add(this.txtChungTu);
            this.groupControl1.Controls.Add(this.lkueKhachHang);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(641, 81);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông Tin";
            // 
            // deNgayLap
            // 
            this.deNgayLap.EditValue = null;
            this.deNgayLap.Location = new System.Drawing.Point(474, 26);
            this.deNgayLap.Name = "deNgayLap";
            this.deNgayLap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayLap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayLap.Properties.EditFormat.FormatString = "dd/MM/yy";
            this.deNgayLap.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deNgayLap.Size = new System.Drawing.Size(155, 20);
            this.deNgayLap.TabIndex = 6;
            // 
            // txtChungTu
            // 
            this.txtChungTu.Location = new System.Drawing.Point(104, 55);
            this.txtChungTu.Name = "txtChungTu";
            this.txtChungTu.ReadOnly = true;
            this.txtChungTu.Size = new System.Drawing.Size(196, 21);
            this.txtChungTu.TabIndex = 5;
            // 
            // lkueKhachHang
            // 
            this.lkueKhachHang.Location = new System.Drawing.Point(104, 26);
            this.lkueKhachHang.Name = "lkueKhachHang";
            this.lkueKhachHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkueKhachHang.Properties.ReadOnly = true;
            this.lkueKhachHang.Size = new System.Drawing.Size(326, 20);
            this.lkueKhachHang.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Theo Chứng Từ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khách Hàng";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.rtbLyDo);
            this.groupControl2.Controls.Add(this.lkueNhanVien);
            this.groupControl2.Controls.Add(this.ceSoTienTra);
            this.groupControl2.Controls.Add(this.ceConNo);
            this.groupControl2.Controls.Add(this.ceSoTien);
            this.groupControl2.Controls.Add(this.label10);
            this.groupControl2.Controls.Add(this.label9);
            this.groupControl2.Controls.Add(this.label7);
            this.groupControl2.Controls.Add(this.label6);
            this.groupControl2.Controls.Add(this.label5);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 81);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(641, 160);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Chi Tiết";
            // 
            // rtbLyDo
            // 
            this.rtbLyDo.Location = new System.Drawing.Point(358, 23);
            this.rtbLyDo.Name = "rtbLyDo";
            this.rtbLyDo.Size = new System.Drawing.Size(271, 91);
            this.rtbLyDo.TabIndex = 3;
            this.rtbLyDo.Text = "";
            // 
            // lkueNhanVien
            // 
            this.lkueNhanVien.Location = new System.Drawing.Point(104, 120);
            this.lkueNhanVien.Name = "lkueNhanVien";
            this.lkueNhanVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkueNhanVien.Size = new System.Drawing.Size(525, 20);
            this.lkueNhanVien.TabIndex = 2;
            // 
            // ceSoTienTra
            // 
            this.ceSoTienTra.Location = new System.Drawing.Point(104, 89);
            this.ceSoTienTra.Name = "ceSoTienTra";
            this.ceSoTienTra.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon;
            this.ceSoTienTra.Properties.Appearance.Options.UseBackColor = true;
            this.ceSoTienTra.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ceSoTienTra.Properties.DisplayFormat.FormatString = "n0";
            this.ceSoTienTra.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ceSoTienTra.Properties.Mask.EditMask = "n0";
            this.ceSoTienTra.Size = new System.Drawing.Size(208, 20);
            this.ceSoTienTra.TabIndex = 1;
            // 
            // ceConNo
            // 
            this.ceConNo.Location = new System.Drawing.Point(104, 60);
            this.ceConNo.Name = "ceConNo";
            this.ceConNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ceConNo.Properties.DisplayFormat.FormatString = "n0";
            this.ceConNo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ceConNo.Properties.ReadOnly = true;
            this.ceConNo.Size = new System.Drawing.Size(208, 20);
            this.ceConNo.TabIndex = 1;
            // 
            // ceSoTien
            // 
            this.ceSoTien.Location = new System.Drawing.Point(104, 28);
            this.ceSoTien.Name = "ceSoTien";
            this.ceSoTien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ceSoTien.Properties.DisplayFormat.FormatString = "n0";
            this.ceSoTien.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ceSoTien.Properties.ReadOnly = true;
            this.ceSoTien.Size = new System.Drawing.Size(208, 20);
            this.ceSoTien.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Nhân Viên";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Số Tiền Trả";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(318, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Lý Do";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Còn Nợ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số Tiền";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(439, 268);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            // 
            // btnBoQua
            // 
            this.btnBoQua.Location = new System.Drawing.Point(554, 268);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(75, 23);
            this.btnBoQua.TabIndex = 2;
            this.btnBoQua.Text = "Bỏ qua";
            // 
            // frmLapPhieuThu
            // 
            this.AcceptButton = this.btnLuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 299);
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLapPhieuThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu Thu Theo Chứng Từ";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayLap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayLap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkueKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkueNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceSoTienTra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceConNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceSoTien.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LookUpEdit lkueKhachHang;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LookUpEdit lkueNhanVien;
        private DevExpress.XtraEditors.CalcEdit ceSoTienTra;
        private DevExpress.XtraEditors.CalcEdit ceConNo;
        private DevExpress.XtraEditors.CalcEdit ceSoTien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnBoQua;
        private System.Windows.Forms.RichTextBox rtbLyDo;
        private System.Windows.Forms.TextBox txtChungTu;
        private DevExpress.XtraEditors.DateEdit deNgayLap;
    }
}