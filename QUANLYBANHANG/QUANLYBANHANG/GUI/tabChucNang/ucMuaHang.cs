using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYBANHANG.DTO;
using QUANLYBANHANG.DAO;
using System.Data.SqlClient;
using QUANLYBANHANG.BUS;
using System.Drawing.Printing;
using QUANLYBANHANG.GUI.tabDanhMuc;

namespace QUANLYBANHANG.GUI.tabChucNang
{
    public partial class ucMuaHang : UserControl
    {
        //tạo event lưu nhật ký hệ thống
        public delegate void NhatKyHeThong(cNhatKyHeThong diary);
        public event NhatKyHeThong ThemNhatKyHeThong;

        // username
        string user;

        // tên chức năng hiện tại
        string TenChucNang = "Mua Hàng";

        NGHIEPVU_PHIEUNHAP nv_pn = new NGHIEPVU_PHIEUNHAP();
        NGHIEPVU_CT_PHIEUNHAP nv_ctpn = new NGHIEPVU_CT_PHIEUNHAP();
        NGHIEPVU_HANGHOA nv_hh = new NGHIEPVU_HANGHOA();

        //vị trí dòng, cột đang chọn
        int rowIndex = -1;
        int colIndex = -1;

        //tong tien thanh toan
        long ttthanhtoan = 0;

        //cờ trạng thái changing
        bool flagChanging = false;

        Bitmap bmp;

        public ucMuaHang(VaiTro_ChucNang vtpq, string un)
        {
            InitializeComponent();

            user = un;
            Load += UcMuaHang_Load;

            //button lkue
            lkueTenNCC.ButtonClick += LkueTenNCC_ButtonClick;

            //print 
            printDocument1.PrintPage += PrintDocument1_PrintPage;

            //sự kiện button
            btnTaoMoi.Click += BtnTaoMoi_Click;
            btnNapLai.Click += BtnNapLai_Click;
            btnHangHoa.Click += BtnHangHoa_Click;
            btnLuu.Click += BtnLuu_Click;
            btnKhachHang.Click += BtnKhachHang_Click;
            btnKhoHang.Click += BtnKhoHang_Click;
            //btnPhieuBanHang.Click += BtnPhieuBanHang_Click;

            //sự kiện tsmi
            tsmiXoa.Click += TsmiXoa_Click;
            tsmiXoaAll.Click += TsmiXoaAll_Click;
            tsmiNapLai.Click += BtnNapLai_Click;

            //sự kiện thay đổi dữ liệu khi chọn cb nhà cung cấp
            lkueMaNCC.EditValueChanged += LkueMaNCC_EditValueChanged;
            lkueTenNCC.EditValueChanged += LkueTenNCC_EditValueChanged;

            //sự kiện ô thay đổi dữ liệu khi người dùng chọn mã hoặc tên hàng
            gvPhieuNhap.CellValueChanged += GvPhieuNhap_CellValueChanged;
            gvPhieuNhap.CellEnter += GvPhieuNhap_CellEnter;
            gvPhieuNhap.KeyUp += GvPhieuNhap_KeyUp;
            gvPhieuNhap.CellMouseUp += GvPhieuNhap_CellMouseUp;

            //xử lý lỗi khi người dùng nhập liệu sai
            gvPhieuNhap.DataError += GvPhieuNhap_DataError;

            //sự kiện các txt phía dưới
            ceCK.EditValueChanging += CeCK_EditValueChanging;
            ceChietKhau.EditValueChanging += CeChietKhau_EditValueChanging;
            ceVAT.EditValueChanging += CeVAT_EditValueChanging;

            //phân quyền dựa vào bảng vai trò chức năng đã được gửi qua
            if (vtpq != null)
            {
                if (vtpq.Them == 0)
                {
                    btnLuu.Enabled = false;
                    tsmiLuuvaDong.Enabled = false;
                }
            }
        }

        private void LkueTenNCC_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmThemNhaCungCap ncc = new frmThemNhaCungCap();
            ncc.ThemThanhCong += NapDuLieu;
            ncc.ThemThanhCong += NhatKyThemNCC;
            ncc.ShowDialog();
            NapDuLieu();
        }

        private void BtnKhoHang_Click(object sender, EventArgs e)
        {
            frmThemSuaKhoHang frmkh = new frmThemSuaKhoHang();
            frmkh.ThemThanhCong += NapDuLieu;
            frmkh.ThemThanhCong += NhatKyThemKhoHang;
            frmkh.ShowDialog();
            NapDuLieu();
        }

        private void AddNhatKy(string hanhDong, string cn)
        {
            cNhatKyHeThong nk = new cNhatKyHeThong();
            nk.NguoiDung = user;
            nk.MayTinh = System.Environment.MachineName;
            nk.ThoiGian = DateTime.Now;
            nk.ChucNang = cn;
            nk.HanhDong = hanhDong;

            ThemNhatKyHeThong(nk);
        }

        private void NhatKyThemHangHoa()
        {
            AddNhatKy("Thêm", "Hàng Hóa");
        }

        private void NhatKyThemKhachHang()
        {
            AddNhatKy("Thêm", "Khách Hàng");
        }

        private void NhatKyThemKhoHang()
        {
            AddNhatKy("Thêm", "Kho Hàng");
        }

        private void NhatKyThemNCC()
        {
            AddNhatKy("Thêm", "Nhà Cung Cấp");
        }

        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (gvPhieuNhap.Rows.Count <= 1)
            {
                MessageBox.Show("Dữ liệu trống, không thể lưu");
            }
            else if (lkueMaNCC.EditValue == null)
            {
                MessageBox.Show("Vui lòng chọn Khách Hàng");
            }
            else
            {
                PhieuNhap pn = new PhieuNhap();
                pn.MaPhieu = txtMaPhieu.Text;
                pn.MaNCC = lkueMaNCC.EditValue.ToString();
                pn.NgayLap = DateTime.Parse(deNgayLap.EditValue.ToString());
                pn.GhiChu = rtxtGhiChu.Text;
                pn.SoHoaDonVAT = txtSoHDVAT.Text;
                pn.MaNVLap = lkueMaNV.EditValue.ToString();
                pn.SoPhieuNhapTay = txtSoPhieuNhapTay.Text;
                pn.MaKhoNhap = lkueKho.EditValue.ToString();
                pn.DieuKhoanThanhToan = cbDKTT.Text;
                pn.HinhThucThanhToan = cbHTTT.Text;
                pn.HanThanhToan = DateTime.Parse(deHanThanhToan.EditValue.ToString());
                pn.DaTra = 0;
                pn.TongTien = int.Parse(nmrThanhToan.Value.ToString());


                List<CT_PhieuNhap> lstCT_PN = new List<CT_PhieuNhap>();

                for (int i = 0; i < gvPhieuNhap.Rows.Count - 1; i++)
                {
                    CT_PhieuNhap ctpn = new CT_PhieuNhap();
                    ctpn.MaPhieuNhap = pn.MaPhieu;
                    ctpn.MaHang = gvPhieuNhap.Rows[i].Cells["colMaHang"].Value.ToString();
                    ctpn.SoLuong = int.Parse(gvPhieuNhap.Rows[i].Cells["colSoLuong"].Value.ToString());
                    ctpn.DonGia = int.Parse(gvPhieuNhap.Rows[i].Cells["colDonGia"].Value.ToString());
                    ctpn.ThanhTien = int.Parse(gvPhieuNhap.Rows[i].Cells["colThanhTien"].Value.ToString());
                    ctpn.GhiChu= gvPhieuNhap.Rows[i].Cells["colGhiChu"].Value.ToString();


                    lstCT_PN.Add(ctpn);
                }
                nv_pn.ThemPhieuNhap(pn);

                foreach (CT_PhieuNhap ct in lstCT_PN)
                {
                    nv_ctpn.ThemCTPhieuNhap(ct);

                    nv_hh.CapNhatSlTon(ct.MaHang, ct.SoLuong, 1);
                }

                AddNhatKy("Thêm", TenChucNang);
                MessageBox.Show("Thêm thành công");

                if (cbInSauKhiLuu.Checked)
                {
                    //print preview
                    AddNhatKy("In", TenChucNang);
                    PrintPreview();
                }
            }
        }

        private void PrintPreview()
        {
            int height = gvPhieuNhap.Height;
            gvPhieuNhap.Height = gvPhieuNhap.RowCount * gvPhieuNhap.RowTemplate.Height * 2;
            bmp = new Bitmap(gvPhieuNhap.Width, gvPhieuNhap.Height);
            gvPhieuNhap.DrawToBitmap(bmp, new Rectangle(0, 0, gvPhieuNhap.Width, gvPhieuNhap.Height));
            gvPhieuNhap.Height = height;
            printPreviewDialog1.ShowDialog();
        }

        private void TsmiXoaAll_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Xóa Tất Cả ?", "Phiếu Xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                nmrThanhToan.Value = 0;
                gvPhieuNhap.Rows.Clear();
            }
        }

        private void TsmiXoa_Click(object sender, EventArgs e)
        {
            if (rowIndex != gvPhieuNhap.Rows.Count - 1 && rowIndex != -1)
            {
                DialogResult dr = MessageBox.Show("Chắc chắn XÓA ?", "Phiếu Xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int tt = int.Parse(gvPhieuNhap.Rows[rowIndex].Cells["colThanhTien"].Value.ToString());
                    nmrThanhToan.Value = nmrThanhToan.Value - tt;
                    gvPhieuNhap.Rows.RemoveAt(rowIndex);
                }
            }
        }

        private void BtnKhachHang_Click(object sender, EventArgs e)
        {
            frmThemSuaKhachHang frmkh = new frmThemSuaKhachHang();
            frmkh.ThemThanhCong += NapDuLieu;
            frmkh.ThemThanhCong += NhatKyThemKhachHang;
            frmkh.ShowDialog();
            NapDuLieu();
        }

        private void BtnHangHoa_Click(object sender, EventArgs e)
        {
            frmThemSuaHangHoa frmhh = new frmThemSuaHangHoa();
            frmhh.ThemThanhCong += NapDuLieu;
            frmhh.ThemThanhCong += NhatKyThemHangHoa;
            frmhh.ShowDialog();
        }

        private void BtnNapLai_Click(object sender, EventArgs e)
        {
            NapDuLieu();
        }

        private void BtnTaoMoi_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            lkueMaNCC.ItemIndex = -1;
            lkueTenNCC.ItemIndex = -1;
            lkueMaNV.ItemIndex = 0;
            lkueKho.ItemIndex = 0;
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            rtxtGhiChu.Text = "";
            txtSoHDVAT.Text = "";
            txtSoPhieuNhapTay.Text = "";
            ceCK.Value = 0;
            ceChietKhau.Value = 0;
            ceVAT.Value = 0;
            ceVATM.Value = 0;
            nmrThanhToan.Value = 0;

            gvPhieuNhap.Rows.Clear();
        }

        private void CeVAT_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (!flagChanging)
            {
                flagChanging = true;
                if (!string.IsNullOrEmpty(e.NewValue.ToString()))
                {
                    decimal temp;
                    if (!decimal.TryParse(e.NewValue.ToString(), out temp))
                        temp = 0;
                    ceVATM.Value = (temp * ttthanhtoan) / 100;
                }
                else
                {
                    ceVATM.Value = 0;
                }

                FillnmrThanhToan();
                flagChanging = false;
            }
        }

        private void CeChietKhau_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (!flagChanging)
            {
                flagChanging = true;
                if (!string.IsNullOrEmpty(e.NewValue.ToString()))
                {
                    decimal temp;
                    if (!decimal.TryParse(e.NewValue.ToString(), out temp))
                        temp = 0;
                    ceCK.Value = (temp * 100) / ttthanhtoan;
                }
                else
                {
                    ceCK.Value = 0;
                }

                FillnmrThanhToan();
                flagChanging = false;
            }
        }

        private void CeCK_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (!flagChanging)
            {
                flagChanging = true;
                if (!string.IsNullOrEmpty(e.NewValue.ToString()))
                {
                    decimal temp;
                    if (!decimal.TryParse(e.NewValue.ToString(), out temp))
                        temp = 0;
                    ceChietKhau.Value = (temp * ttthanhtoan) / 100;
                }
                else
                {
                    ceChietKhau.Value = 0;
                }

                FillnmrThanhToan();
                flagChanging = false;
            }
        }

        private void FillnmrThanhToan()
        {
            nmrThanhToan.Value = ttthanhtoan - ceChietKhau.Value + ceVATM.Value;
        }

        private void GvPhieuNhap_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Lỗi nhập liệu", "Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void GvPhieuNhap_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex < 0 || e.ColumnIndex < 0)
                    return;

                rowIndex = e.RowIndex;
                colIndex = e.ColumnIndex;

                if (gvPhieuNhap.Rows[rowIndex] != null)
                    gvPhieuNhap.CurrentCell = gvPhieuNhap.Rows[rowIndex].Cells[colIndex];
            }
        }

        private void GvPhieuNhap_KeyUp(object sender, KeyEventArgs e)
        {
            if (colIndex == 0 || colIndex == 1)
            {
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                {
                    int row = e.KeyCode == Keys.Enter ? rowIndex - 1 : rowIndex;

                    gvPhieuNhap.CurrentCell = gvPhieuNhap.Rows[row].Cells["colSoLuong"];
                }
            }

            else if (colIndex >= 3)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    gvPhieuNhap.CurrentCell = gvPhieuNhap.Rows[rowIndex].Cells[0];
                }
            }
        }

        private void GvPhieuNhap_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            colIndex = e.ColumnIndex;
        }

        private void GvPhieuNhap_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex;

            //cột tên hàng hoặc mã hàng
            if (col == 0 || col == 1)
            {
                string mahang = col == 1 ? gvPhieuNhap.Rows[e.RowIndex].Cells["colMaHang"].Value.ToString() :
                    gvPhieuNhap.Rows[e.RowIndex].Cells["colTenHang"].Value.ToString();

                string tendonvi = null;
                long dongia = 0;
                int slTon = 0;
                LayThongTinHangHoa(mahang, ref tendonvi, ref dongia, ref slTon);

                if (col == 1)
                    gvPhieuNhap.Rows[e.RowIndex].Cells["colTenHang"].Value = mahang;
                else
                    gvPhieuNhap.Rows[e.RowIndex].Cells["colMaHang"].Value = mahang;

                gvPhieuNhap.Rows[e.RowIndex].Cells["colDonVi"].Value = tendonvi;
                gvPhieuNhap.Rows[e.RowIndex].Cells["colSoLuong"].Value = (long)1;
                gvPhieuNhap.Rows[e.RowIndex].Cells["colDonGia"].Value = dongia;
                gvPhieuNhap.Rows[e.RowIndex].Cells["colThanhTien"].Value = dongia;
                gvPhieuNhap.Rows[e.RowIndex].Cells["colGhiChu"].Value = "";
            }


            // if thay đổi value của 1 trong các cột phía sau thì tính lại thành tiền và thanh toán
            else if (col == 3 || col == 4)
            {
                //tính thành tiền
                long thanhtien = 0;
                if (gvPhieuNhap.Rows[e.RowIndex].Cells["colSoLuong"].Value != null && gvPhieuNhap.Rows[e.RowIndex].Cells["colDonGia"].Value != null)
                {
                    thanhtien = long.Parse(gvPhieuNhap.Rows[e.RowIndex].Cells["colSoLuong"].Value.ToString()) 
                        * long.Parse(gvPhieuNhap.Rows[e.RowIndex].Cells["colDonGia"].Value.ToString());
                }
                gvPhieuNhap.Rows[e.RowIndex].Cells["colThanhTien"].Value = thanhtien;


                // tính tổng tiền thanh toán và fill nmr thanh toan
                TinhTongTienThanhToan();
                FillnmrThanhToan();
            }
        }

        //tính tổng tiền thanh toán
        private void TinhTongTienThanhToan()
        {
            long kq = 0;
            for (int i = 0; i < gvPhieuNhap.Rows.Count; i++)
            {
                if (gvPhieuNhap.Rows[i].Cells["colThanhTien"].Value != null)
                    kq += (long)gvPhieuNhap.Rows[i].Cells["colThanhTien"].Value;
            }

            ttthanhtoan = kq;
        }

        private void LayThongTinHangHoa(string mahang, ref string tendonvi, ref long dongia, ref int slTon)
        {
            string sql = "sp_LayThongTinHangHoa";

            Provider p = new Provider();
            p.Connect();

            SqlParameter tendv = new SqlParameter("@tendv", SqlDbType.NVarChar, 50);
            tendv.Direction = ParameterDirection.Output;
            SqlParameter dg = new SqlParameter("@dongia", SqlDbType.Int);
            dg.Direction = ParameterDirection.Output;
            SqlParameter slton = new SqlParameter("@slTon", SqlDbType.Int);
            slton.Direction = ParameterDirection.Output;

            p.ExecuteNonQuery(CommandType.StoredProcedure, sql,
                new SqlParameter { ParameterName = "@mahh", Value = mahang }, tendv, dg, slton);

            tendonvi = tendv.Value.ToString();
            dongia = long.Parse(dg.Value.ToString());
            slTon = int.Parse(slton.Value.ToString());

            p.Disconnect();
        }

        private void LkueTenNCC_EditValueChanged(object sender, EventArgs e)
        {
            lkueMaNCC.EditValue = lkueTenNCC.EditValue;
            FilltxtNhaCungCap(lkueTenNCC.EditValue.ToString());
        }

        private void LkueMaNCC_EditValueChanged(object sender, EventArgs e)
        {
            lkueTenNCC.EditValue = lkueMaNCC.EditValue;
            FilltxtNhaCungCap(lkueMaNCC.EditValue.ToString());
        }

        private void FilltxtNhaCungCap(string mancc)
        {
            string sql = "sp_LayThongTinNCC";

            Provider p = new Provider();
            p.Connect();

            SqlParameter diachi = new SqlParameter("@diachi", SqlDbType.NVarChar, 100);
            diachi.Direction = ParameterDirection.Output;
            SqlParameter dt = new SqlParameter("@dt", SqlDbType.VarChar, 13);
            dt.Direction = ParameterDirection.Output;

            p.ExecuteNonQuery(CommandType.StoredProcedure, sql, diachi, dt,
                new SqlParameter { ParameterName = "@mancc", Value = mancc });

            txtDiaChi.Text = diachi.Value.ToString();
            txtSDT.Text = dt.Value.ToString();

            p.Disconnect();
        }

        private void UcMuaHang_Load(object sender, EventArgs e)
        {
            AddNhatKy("Xem",TenChucNang);
            NapDuLieu();
            ResetForm();
            FillCbDKTT();//điều khoản thanh toán
            FillCbHTTT();//hình thức thanh toán

            // format 1000 separator
            gvPhieuNhap.Columns["colThanhTien"].DefaultCellStyle.Format = "#,###";
            gvPhieuNhap.Columns["colDonGia"].DefaultCellStyle.Format = "#,###";
        }

        private void NapDuLieu()
        {
            FillCbNCC();
            FillCbNV();
            FillCbKho();
            FillDateEdit();
                
            txtMaPhieu.Text = GenerateMaPhieu();
            txtMaPhieu.ReadOnly = true;
            FillGridView();
            gvPhieuNhap.ContextMenuStrip = ctmsPhieuNhap;
            gvPhieuNhap.AllowUserToDeleteRows = true;
        }

        private void FillCbNCC()
        {
            string sql = "select MaNCC, TenNCC from NHACUNGCAP";
            DataTable dt = Execute.LayDuLieuBang(sql);

            //cb mã kh
            lkueMaNCC.Properties.DataSource = dt;
            lkueMaNCC.Properties.ValueMember = "MaNCC";
            lkueMaNCC.Properties.DisplayMember = "MaNCC";

            //cb tên kh
            lkueTenNCC.Properties.DataSource = dt;
            lkueTenNCC.Properties.ValueMember = "MaNCC";
            lkueTenNCC.Properties.DisplayMember = "TenNCC";
        }

        private void FillCbNV()
        {
            string sql = "select MaNhanVien, TenNhanVien from NHANVIEN";
            DataTable dt = Execute.LayDuLieuBang(sql);

            lkueMaNV.Properties.DataSource = dt;
            lkueMaNV.Properties.ValueMember = "MaNhanVien";
            lkueMaNV.Properties.DisplayMember = "TenNhanVien";
        }

        private void FillDateEdit()
        {
            deNgayLap.EditValue = DateTime.Now;
            deHanThanhToan.EditValue = DateTime.Now;
        }

        private void FillCbKho()
        {
            string sql = "select MaKho, TenKho from KHOHANG";
            DataTable dt = Execute.LayDuLieuBang(sql);

            lkueKho.Properties.DataSource = dt;
            lkueKho.Properties.ValueMember = "MaKho";
            lkueKho.Properties.DisplayMember = "TenKho";
        }

        private void FillCbDKTT()
        {
            string[] dktt = { "Công Nợ", "Thanh toán ngay" };

            cbDKTT.Properties.Items.AddRange(dktt);
            cbDKTT.SelectedIndex = 0;
        }

        private void FillCbHTTT()
        {
            string[] httt = { "Tiền Mặt", "Chuyển Khoản" };

            cbHTTT.Properties.Items.AddRange(httt);
            cbHTTT.SelectedIndex = 0;
        }

        private string GenerateMaPhieu()
        {
            return Execute.GenerateMa("sp_LayMaPhieuNhap");
        }

        private void FillGridView()
        {
            string sql;
            DataTable dt = null;

            sql = "select MaHangHoa, TenHang from HANGHOA";
            dt = Execute.LayDuLieuBang(sql);

            //fill cb ma hang
            colMaHang.DataSource = dt;
            colMaHang.ValueMember = "MaHangHoa";
            colMaHang.DisplayMember = "MaHangHoa";
            //fill cb ten hang
            colTenHang.DataSource = dt;
            colTenHang.ValueMember = "MaHangHoa";
            colTenHang.DisplayMember = "TenHang";

            //đổi kiểu dữ liệu cho các cột số
            colSoLuong.ValueType = typeof(long);
            colDonGia.ValueType = typeof(long);
            colThanhTien.ValueType = typeof(long);
        }
    }
}
