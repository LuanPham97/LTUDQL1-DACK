namespace QUANLYBANHANG.GUI
{
    partial class ucTongTien
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
            this.ckeInSauKhiLuu = new DevExpress.XtraEditors.CheckEdit();
            this.txtChietKhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVAT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ckeInSauKhiLuu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ckeInSauKhiLuu
            // 
            this.ckeInSauKhiLuu.Location = new System.Drawing.Point(16, 12);
            this.ckeInSauKhiLuu.Name = "ckeInSauKhiLuu";
            this.ckeInSauKhiLuu.Properties.Caption = "In Sau Khi Lưu";
            this.ckeInSauKhiLuu.Size = new System.Drawing.Size(91, 19);
            this.ckeInSauKhiLuu.TabIndex = 0;
            // 
            // txtChietKhau
            // 
            this.txtChietKhau.Location = new System.Drawing.Point(253, 11);
            this.txtChietKhau.Name = "txtChietKhau";
            this.txtChietKhau.Size = new System.Drawing.Size(79, 20);
            this.txtChietKhau.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chiết Khấu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "VAT";
            // 
            // txtVAT
            // 
            this.txtVAT.Location = new System.Drawing.Point(395, 11);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.Size = new System.Drawing.Size(82, 20);
            this.txtVAT.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(578, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Thành Tiền";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(646, 11);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(126, 20);
            this.txtThanhTien.TabIndex = 6;
            // 
            // ucTongTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVAT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtChietKhau);
            this.Controls.Add(this.ckeInSauKhiLuu);
            this.Name = "ucTongTien";
            this.Size = new System.Drawing.Size(775, 41);
            ((System.ComponentModel.ISupportInitialize)(this.ckeInSauKhiLuu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit ckeInSauKhiLuu;
        private System.Windows.Forms.TextBox txtChietKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVAT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtThanhTien;
    }
}
