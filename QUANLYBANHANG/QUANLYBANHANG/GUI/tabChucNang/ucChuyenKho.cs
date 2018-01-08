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
using QUANLYBANHANG.BUS;
using QUANLYBANHANG.DAO;
using System.Data.SqlClient;
using System.Drawing.Printing;
using QUANLYBANHANG.GUI.tabDanhMuc;

namespace QUANLYBANHANG.GUI.tabChucNang
{
    public partial class ucChuyenKho : UserControl
    {
        //tạo event lưu nhật ký hệ thống
        public delegate void NhatKyHeThong(cNhatKyHeThong diary);
        public event NhatKyHeThong ThemNhatKyHeThong;

        // username
        string user;

        // tên chức năng hiện tại
        string TenChucNang = "Chuyển Kho";

        NGHIEPVU_PHIEUCHUYENKHO nv_pck = new NGHIEPVU_PHIEUCHUYENKHO();
        NGHIEPVU_CT_PHIEUCHUYENKHO nv_ctpc = new NGHIEPVU_CT_PHIEUCHUYENKHO();
        NGHIEPVU_HANGHOA nv_hh = new NGHIEPVU_HANGHOA();

        //vị trí dòng, cột đang chọn
        int rowIndex = -1;
        int colIndex = -1;

        Bitmap bmp;

        public ucChuyenKho(VaiTro_ChucNang pqck, string un)
        {
            InitializeComponent();

            user = un;

            Load += UcChuyenKho_Load;

            // button lkue
            lkueNguoiNhan.ButtonClick += LkueNguoiNhan_ButtonClick;

            //sự kiện button
            btnTaoMoi.Click += BtnTaoMoi_Click;
            btnNapLai.Click += BtnNapLai_Click;
            btnHangHoa.Click += BtnHangHoa_Click;
            btnLuu.Click += BtnLuu_Click;
            btnKhachHang.Click += BtnKhachHang_Click;
            btnKhoHang.Click += BtnKhoHang_Click;

            //sự kiện tsmi
            tsmiXoa.Click += TsmiXoa_Click;
            tsmiXoaAll.Click += TsmiXoaAll_Click;
            tsmiNapLai.Click += BtnNapLai_Click;

            //sự kiện ô thay đổi dữ liệu khi người dùng chọn mã hoặc tên hàng
            gvPhieuChuyenKho.CellValueChanged += GvPhieuChuyenKho_CellValueChanged;
            gvPhieuChuyenKho.CellEnter += GvPhieuChuyenKho_CellEnter;
            gvPhieuChuyenKho.KeyUp += GvPhieuChuyenKho_KeyUp;
            gvPhieuChuyenKho.CellMouseUp += GvPhieuChuyenKho_CellMouseUp;

            //xử lý lỗi khi người dùng nhập liệu sai
            gvPhieuChuyenKho.DataError += GvPhieuChuyenKho_DataError;

            //print 
            printDocument1.PrintPage += PrintDocument1_PrintPage;

            //phân quyền dựa vào bảng vai trò chức năng đã được gửi qua
            if (pqck != null)
            {
                if (pqck.Them == 0)
                {
                    btnLuu.Enabled = false;
                    tsmiLuuvaDong.Enabled = false;
                }
            }
        }

        private void LkueNguoiNhan_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                frmThemNhanVien nv = new frmThemNhanVien();
                nv.ThemThanhCong += FillCbNhanVien;
                nv.ThemThanhCong += NhatKyThemNhanVien;
                nv.ShowDialog();
                NapDuLieu();
            }
        }

        private void BtnKhoHang_Click(object sender, EventArgs e)
        {
            frmThemSuaKhoHang frmkh = new frmThemSuaKhoHang();
            frmkh.ThemThanhCong += NapDuLieu;
            frmkh.ThemThanhCong += NhatKyThemKhoHang;
            frmkh.ShowDialog();
            NapDuLieu();
        }

        private void AddNhatKy(string hanhDong, string chucnang)
        {
            cNhatKyHeThong nk = new cNhatKyHeThong();
            nk.NguoiDung = user;
            nk.MayTinh = System.Environment.MachineName;
            nk.ThoiGian = DateTime.Now;
            nk.ChucNang = chucnang;
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

        private void NhatKyThemNhanVien()
        {
            AddNhatKy("Thêm", "Nhân Viên");
        }

        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (gvPhieuChuyenKho.Rows.Count <= 1)
            {
                MessageBox.Show("Dữ liệu trống, không thể lưu");
                return;
            }
            if (lkueNguoiChuyen.EditValue == null)
            {
                MessageBox.Show("Vui lòng chọn Người nhận");
                return;
            }
            if (lkueKhoNhan.EditValue == null)
            {
                MessageBox.Show("Chưa chọn Kho Nhận");
                return;
            }
            PhieuChuyenKho pck = new PhieuChuyenKho();
            pck.MaPhieuChuyen = txtMaPhieu.Text;
            pck.KhoXuatHang = lkueKhoXuat.EditValue.ToString();
            pck.KhoNhanHang = lkueKhoNhan.EditValue.ToString();
            pck.NVChuyen = lkueNguoiChuyen.EditValue.ToString();
            pck.NVNhan = lkueNguoiNhan.EditValue.ToString();
            pck.NgayLap = DateTime.Parse(deNgayLap.EditValue.ToString());
            pck.GhiChu = rtxtGhiChu.Text;
            pck.PhieuChuyenTay = txtPhieuChuyenTay.Text;

            List<CT_PhieuChuyenKho> lstCT_PCK = new List<CT_PhieuChuyenKho>();

            for (int i = 0; i < gvPhieuChuyenKho.Rows.Count - 1; i++)
            {
                CT_PhieuChuyenKho ct_pck = new CT_PhieuChuyenKho();
                ct_pck.MaPhieuChuyen = pck.MaPhieuChuyen;
                ct_pck.MaHang = gvPhieuChuyenKho.Rows[i].Cells["colMaHang"].Value.ToString();
                ct_pck.SoLuong = int.Parse(gvPhieuChuyenKho.Rows[i].Cells["colSoLuong"].Value.ToString());

                lstCT_PCK.Add(ct_pck);
            }
            nv_pck.ThemPhieuChuyenKho(pck);

            foreach (CT_PhieuChuyenKho ct in lstCT_PCK)
            {
                nv_ctpc.ThemCTPhieuChuyen(ct);
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

        private void PrintPreview()
        {
            int height = gvPhieuChuyenKho.Height;
            gvPhieuChuyenKho.Height = gvPhieuChuyenKho.RowCount * gvPhieuChuyenKho.RowTemplate.Height * 2;
            bmp = new Bitmap(gvPhieuChuyenKho.Width, gvPhieuChuyenKho.Height);
            gvPhieuChuyenKho.DrawToBitmap(bmp, new Rectangle(0, 0, gvPhieuChuyenKho.Width, gvPhieuChuyenKho.Height));
            gvPhieuChuyenKho.Height = height;
            printPreviewDialog1.ShowDialog();
        }

        private void GvPhieuChuyenKho_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Lỗi nhập liệu", "Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void GvPhieuChuyenKho_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                rowIndex = e.RowIndex;
                colIndex = e.ColumnIndex;

                if (gvPhieuChuyenKho.Rows[rowIndex] != null)
                    gvPhieuChuyenKho.CurrentCell = gvPhieuChuyenKho.Rows[rowIndex].Cells[colIndex];
            }
        }

        private void GvPhieuChuyenKho_KeyUp(object sender, KeyEventArgs e)
        {
            if (colIndex == 0 || colIndex == 1)
            {
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                {
                    int row = e.KeyCode == Keys.Enter ? rowIndex - 1 : rowIndex;

                    gvPhieuChuyenKho.CurrentCell = gvPhieuChuyenKho.Rows[row].Cells["colSoLuong"];
                }
            }

            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    gvPhieuChuyenKho.CurrentCell = gvPhieuChuyenKho.Rows[rowIndex].Cells[0];
                }
            }
        }

        private void GvPhieuChuyenKho_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            colIndex = e.ColumnIndex;
        }

        private void GvPhieuChuyenKho_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex;

            //cột tên hàng hoặc mã hàng
            if (col == 0 || col == 1)
            {
                string mahang = col == 1 ? gvPhieuChuyenKho.Rows[e.RowIndex].Cells["colMaHang"].Value.ToString() :
                    gvPhieuChuyenKho.Rows[e.RowIndex].Cells["colTenHang"].Value.ToString();

                string tendonvi = null;
                long dongia = 0;
                int slTon = 0;
                LayThongTinHangHoa(mahang, ref tendonvi, ref dongia, ref slTon);

                if (col == 1)
                    gvPhieuChuyenKho.Rows[e.RowIndex].Cells["colTenHang"].Value = mahang;
                else
                    gvPhieuChuyenKho.Rows[e.RowIndex].Cells["colMaHang"].Value = mahang;

                gvPhieuChuyenKho.Rows[e.RowIndex].Cells["colDonVi"].Value = tendonvi;
                gvPhieuChuyenKho.Rows[e.RowIndex].Cells["colSoLuong"].Value = (long)1;
            }
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

        private void TsmiXoaAll_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Xóa Tất Cả ?", "Phiếu Chuyển Kho", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                gvPhieuChuyenKho.Rows.Clear();
        }

        private void TsmiXoa_Click(object sender, EventArgs e)
        {
            if (rowIndex != gvPhieuChuyenKho.Rows.Count - 1 && rowIndex != -1)
            {
                DialogResult dr = MessageBox.Show("Chắc chắn XÓA ?", "Phiếu Chuyển Kho", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                    gvPhieuChuyenKho.Rows.RemoveAt(rowIndex);
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

        private void UcChuyenKho_Load(object sender, EventArgs e)
        {
            AddNhatKy("Xem", TenChucNang);
            NapDuLieu();
            ResetForm();
        }

        private void NapDuLieu()
        {
            FillCbKho();
            FillCbNhanVien();
            FillDeNgayLap();

            txtMaPhieu.Text = Execute.GenerateMa("sp_LayMaPhieuChuyenKho");
            txtMaPhieu.ReadOnly = true;
            FillGridView();
            gvPhieuChuyenKho.ContextMenuStrip = ctmsPhieuChuyenKho;
            gvPhieuChuyenKho.AllowUserToDeleteRows = true;
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
        }

        private void FillDeNgayLap()
        {
            deNgayLap.EditValue = DateTime.Now;
        }

        private void FillCbNhanVien()
        {
            string sql = "select TenNhanVien, MaNhanVien from NHANVIEN";
            DataTable dt = Execute.LayDuLieuBang(sql);

            //cb nv xuat
            lkueNguoiChuyen.Properties.DataSource = dt;
            lkueNguoiChuyen.Properties.ValueMember = "MaNhanVien";
            lkueNguoiChuyen.Properties.DisplayMember = "TenNhanVien";

            //cb nv nhan
            lkueNguoiNhan.Properties.DataSource = dt;
            lkueNguoiNhan.Properties.ValueMember = "MaNhanVien";
            lkueNguoiNhan.Properties.DisplayMember = "TenNhanVien";
        }

        private void FillCbKho()
        {
            string sql = "select TenKho, MaKho from KHOHANG";
            DataTable dt = Execute.LayDuLieuBang(sql);

            //cb kho xuat
            lkueKhoXuat.Properties.DataSource = dt;
            lkueKhoXuat.Properties.ValueMember = "MaKho";
            lkueKhoXuat.Properties.DisplayMember = "TenKho";

            //cb kho nhan
            lkueKhoNhan.Properties.DataSource = dt;
            lkueKhoNhan.Properties.ValueMember = "MaKho";
            lkueKhoNhan.Properties.DisplayMember = "TenKho";
        }

        private void ResetForm()
        {
            lkueKhoXuat.ItemIndex = 0; ;
            lkueKhoNhan.EditValue = null;
            rtxtGhiChu.Text = "";
            lkueNguoiChuyen.ItemIndex = 0;
            lkueNguoiNhan.EditValue = null;
            txtPhieuChuyenTay.Text = "";
            FillDeNgayLap();

            gvPhieuChuyenKho.Rows.Clear();
        }
    }
}
