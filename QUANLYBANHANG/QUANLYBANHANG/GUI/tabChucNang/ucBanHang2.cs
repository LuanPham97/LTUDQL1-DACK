using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYBANHANG.DAO;
using QUANLYBANHANG.DTO;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using QUANLYBANHANG.BUS;
using System.Drawing.Printing;
using PagedList;
using QUANLYBANHANG.GUI.tabDanhMuc;

namespace QUANLYBANHANG.GUI
{
    public partial class ucBanHang2 : UserControl
    {
        //tạo event lưu nhật ký hệ thống
        public delegate void NhatKyHeThong(cNhatKyHeThong diary);
        public event NhatKyHeThong ThemNhatKyHeThong;

        // username
        string user;

        // tên chức năng hiện tại
        string TenChucNang = "Bán Hàng";

        NGHIEPVU_PHIEUXUAT nv_px = new NGHIEPVU_PHIEUXUAT();
        NGHIEPVU_CT_PHIEUXUAT nv_ctpx = new NGHIEPVU_CT_PHIEUXUAT();
        NGHIEPVU_HANGHOA nv_hh = new NGHIEPVU_HANGHOA();

        //vị trí dòng, cột đang chọn
        int rowIndex = -1;
        int colIndex = -1;

        //tong tien thanh toan
        long ttthanhtoan = 0;

        //cờ trạng thái changing
        bool flagChanging = false;

        Bitmap bmp;

        public ucBanHang2(VaiTro_ChucNang vtbh, string un)
        {
            InitializeComponent();

            user = un;

            Load += UcBanHang2_Load;

            // button lookupedit
            lkueTenKH.ButtonClick += LkueTenKH_ButtonClick;

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

            //sự kiện thay đổi dữ liệu khi chọn cb khách hàng
            lkueMaKH.EditValueChanged += LkueMaKH_EditValueChanged;
            lkueTenKH.EditValueChanged += LkueTenKH_EditValueChanged;

            //sự kiện ô thay đổi dữ liệu khi người dùng chọn mã hoặc tên hàng
            gvPhieuXuat.CellValueChanged += GvPhieuXuat_CellValueChanged;
            gvPhieuXuat.CellEnter += GvPhieuXuat_CellEnter;
            gvPhieuXuat.KeyUp += GvPhieuXuat_KeyUp;
            gvPhieuXuat.CellMouseUp += GvPhieuXuat_CellMouseUp;

            //xử lý lỗi khi người dùng nhập liệu sai
            gvPhieuXuat.DataError += GvPhieuXuat_DataError;

            //sự kiện các txt phía dưới
            ceCK.EditValueChanging += CeCK_EditValueChanging;
            ceChietKhau.EditValueChanging += CeChietKhau_EditValueChanging;
            ceVAT.EditValueChanging += CeVAT_EditValueChanging;

            //phân quyền dựa vào bảng vai trò chức năng đã được gửi qua
            if (vtbh != null)
            {
                if (vtbh.Them == 0)
                {
                    btnLuu.Enabled = false;
                    tsmiLuuvaDong.Enabled = false;
                }
            }
        }

        private void LkueTenKH_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 0)
            {
                frmThemSuaKhachHang frmkh = new frmThemSuaKhachHang();
                frmkh.ThemThanhCong += NapDuLieu;
                frmkh.ThemThanhCong += NhatKyThemKhachHang;
                frmkh.ShowDialog();
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

        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        //private void BtnPhieuBanHang_Click(object sender, EventArgs e)
        //{

        //}

        private void BtnKhachHang_Click(object sender, EventArgs e)
        {
            frmThemSuaKhachHang frmkh = new frmThemSuaKhachHang();
            frmkh.ThemThanhCong += NapDuLieu;
            frmkh.ThemThanhCong += NhatKyThemKhachHang;
            frmkh.ShowDialog();
            NapDuLieu();
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (gvPhieuXuat.Rows.Count <= 1)
            {
                MessageBox.Show("Dữ liệu trống, không thể lưu");
            }
            else if (lkueMaKH.EditValue == null)
            {
                MessageBox.Show("Vui lòng chọn Khách Hàng");
            }
            else
            {
                bool CanInsert = true;

                PhieuXuat px = new PhieuXuat();
                px.MaPhieu = txtMaPhieu.Text;
                px.MaKH = lkueMaKH.EditValue.ToString();
                px.NgayLap = DateTime.Parse(deNgayLap.EditValue.ToString());
                px.GhiChu = rtxtGhiChu.Text;
                px.SoHoaDonVAT = txtSoHDVAT.Text;
                px.MaNVLap = lkueMaNV.EditValue.ToString();
                px.SoPhieuNhapTay = txtSoPhieuNhapTay.Text;
                px.MaKhoXuat = lkueKho.EditValue.ToString();
                px.DieuKhoanThanhToan = cbDKTT.Text;
                px.HinhThucThanhToan = cbHTTT.Text;
                px.HanThanhToan = DateTime.Parse(deHanThanhToan.EditValue.ToString());
                px.NgayGiao = DateTime.Parse(deNgayGiao.EditValue.ToString());
                px.DaTra = 0;
                px.TongTien = int.Parse(nmrThanhTien.Value.ToString());


                List<CT_PhieuXuat> lstCT_PX = new List<CT_PhieuXuat>();

                for (int i = 0; i < gvPhieuXuat.Rows.Count - 1; i++)
                {
                    CT_PhieuXuat ctpx = new CT_PhieuXuat();
                    ctpx.MaPhieuXuat = px.MaPhieu;
                    ctpx.MaHang = gvPhieuXuat.Rows[i].Cells["colMaHang"].Value.ToString();
                    ctpx.SoLuong = int.Parse(gvPhieuXuat.Rows[i].Cells["colSoLuong"].Value.ToString());
                    ctpx.DonGia = int.Parse(gvPhieuXuat.Rows[i].Cells["colDonGia"].Value.ToString());
                    ctpx.ThanhTien = int.Parse(gvPhieuXuat.Rows[i].Cells["colThanhTien"].Value.ToString());
                    //chiếu khấu lưu theo số phần trăm
                    ctpx.ChietKhau = int.Parse(gvPhieuXuat.Rows[i].Cells["colCK"].Value.ToString());
                    ctpx.ThanhToan = int.Parse(gvPhieuXuat.Rows[i].Cells["colThanhToan"].Value.ToString());

                    int slton = int.Parse(gvPhieuXuat.Rows[i].Cells["colSLTon"].Value.ToString());
                    int tonSau = slton - int.Parse(gvPhieuXuat.Rows[i].Cells["colSoLuong"].Value.ToString());
                    if (tonSau < 0)
                    {
                        string tenHang = gvPhieuXuat.Rows[i].Cells["colTenHang"].FormattedValue.ToString();
                        DialogResult dr = MessageBox.Show(string.Format("Mặt hàng '{0}' đã xuất quá số lượng tồn\nSố lượng tồn hiện tại là {1}\nNếu thực hiện sẽ dẫn đến tồn kho bị âm\nBạn có chắc chắn muốn thực hiện công việc này không ?", tenHang, slton), "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dr == DialogResult.Yes)
                        {
                            lstCT_PX.Add(ctpx);
                        }
                        else
                        {
                            CanInsert = false;
                            break;
                        }
                    }
                    else
                    {
                        lstCT_PX.Add(ctpx);
                    }
                }

                if (CanInsert == true)
                {
                    nv_px.ThemPhieuXuat(px);

                    foreach (CT_PhieuXuat ct in lstCT_PX)
                    {
                        nv_ctpx.ThemCTPhieuXuat(ct);

                        nv_hh.CapNhatSlTon(ct.MaHang, ct.SoLuong, 0);
                    }

                    AddNhatKy("Thêm", TenChucNang);
                    MessageBox.Show("Thêm thành công");
                }

                if(cbInSauKhiLuu.Checked)
                {
                    //print preview
                    AddNhatKy("In", TenChucNang);
                    PrintPreview();
                }
            }
        }

        private void PrintPreview()
        {
            int height = gvPhieuXuat.Height;
            gvPhieuXuat.Height = gvPhieuXuat.RowCount * gvPhieuXuat.RowTemplate.Height * 2;
            bmp = new Bitmap(gvPhieuXuat.Width, gvPhieuXuat.Height);
            gvPhieuXuat.DrawToBitmap(bmp, new Rectangle(0, 0, gvPhieuXuat.Width, gvPhieuXuat.Height));
            gvPhieuXuat.Height = height;
            printPreviewDialog1.ShowDialog();
        }

        private void TsmiXoaAll_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Xóa Tất Cả ?", "Phiếu Xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                nmrThanhTien.Value = 0;
                gvPhieuXuat.Rows.Clear();
            }
        }

        private void GvPhieuXuat_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex < 0 || e.ColumnIndex < 0)
                    return;

                rowIndex = e.RowIndex;
                colIndex = e.ColumnIndex;

                if (gvPhieuXuat.Rows[rowIndex] != null)
                    gvPhieuXuat.CurrentCell = gvPhieuXuat.Rows[rowIndex].Cells[colIndex];
            }
        }

        private void TsmiXoa_Click(object sender, EventArgs e)
        {
            if (rowIndex != gvPhieuXuat.Rows.Count - 1 && rowIndex != -1)
            {
                DialogResult dr = MessageBox.Show("Chắc chắn XÓA ?", "Phiếu Xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int tt = int.Parse(gvPhieuXuat.Rows[rowIndex].Cells["colThanhTien"].Value.ToString());
                    nmrThanhTien.Value = nmrThanhTien.Value - tt;
                    gvPhieuXuat.Rows.RemoveAt(rowIndex);
                }
            }
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

                FillnmrThanhTien();
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

                FillnmrThanhTien();
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

                FillnmrThanhTien();
                flagChanging = false;
            }
        }

        private void FillnmrThanhTien()
        {
            nmrThanhTien.Value = ttthanhtoan - ceChietKhau.Value + ceVATM.Value;
        }

        //tính tổng tiền thanh toán
        private void TinhTongTienThanhToan()
        {
            long kq = 0;
            for (int i = 0; i < gvPhieuXuat.Rows.Count; i++)
            {
                if(gvPhieuXuat.Rows[i].Cells["colThanhToan"].Value != null)
                    kq += (long)gvPhieuXuat.Rows[i].Cells["colThanhToan"].Value;
            }

            ttthanhtoan = kq;
        }

        private void GvPhieuXuat_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Lỗi nhập liệu", "Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void GvPhieuXuat_KeyUp(object sender, KeyEventArgs e)
        {
            if (colIndex == 0 || colIndex == 1)
            {
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                {
                    int row = e.KeyCode == Keys.Enter ? rowIndex - 1 : rowIndex;

                    gvPhieuXuat.CurrentCell = gvPhieuXuat.Rows[row].Cells["colSoLuong"];
                }
            }

            else if (colIndex >= 3)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    gvPhieuXuat.CurrentCell = gvPhieuXuat.Rows[rowIndex].Cells[0];
                }
            }
        }

        private void GvPhieuXuat_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            colIndex = e.ColumnIndex;
        }

        private void GvPhieuXuat_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex;

            //cột tên hàng hoặc mã hàng
            if (col == 0 || col == 1)
            {
                string mahang = col == 1 ? gvPhieuXuat.Rows[e.RowIndex].Cells["colMaHang"].Value.ToString() :
                    gvPhieuXuat.Rows[e.RowIndex].Cells["colTenHang"].Value.ToString();

                string tendonvi = null;
                long dongia = 0;
                int slTon = 0;
                LayThongTinHangHoa(mahang, ref tendonvi, ref dongia, ref slTon);

                if (col == 1)
                    gvPhieuXuat.Rows[e.RowIndex].Cells["colTenHang"].Value = mahang;
                else
                    gvPhieuXuat.Rows[e.RowIndex].Cells["colMaHang"].Value = mahang;

                gvPhieuXuat.Rows[e.RowIndex].Cells["colDonVi"].Value = tendonvi;
                gvPhieuXuat.Rows[e.RowIndex].Cells["colSoLuong"].Value = (long)1;
                gvPhieuXuat.Rows[e.RowIndex].Cells["colDonGia"].Value = dongia;
                gvPhieuXuat.Rows[e.RowIndex].Cells["colThanhTien"].Value = dongia;
                gvPhieuXuat.Rows[e.RowIndex].Cells["colCK"].Value = (long)0;
                gvPhieuXuat.Rows[e.RowIndex].Cells["colChietKhau"].Value = (long)0;
                gvPhieuXuat.Rows[e.RowIndex].Cells["colThanhToan"].Value = dongia;
                gvPhieuXuat.Rows[e.RowIndex].Cells["colSLTon"].Value = slTon;
            }


            // if thay đổi value của 1 trong các cột phía sau thì tính lại thành tiền và thanh toán
            else if (col >= 3 && col != 8)
            {
                if (col == 6 && gvPhieuXuat.Rows[e.RowIndex].Cells["colCK"].Value != null)
                {
                    long ck = (long)gvPhieuXuat.Rows[e.RowIndex].Cells["colCK"].Value;
                    if (ck > 100)
                        gvPhieuXuat.Rows[e.RowIndex].Cells["colCK"].Value = 100;
                    else if (ck < 0)
                        gvPhieuXuat.Rows[e.RowIndex].Cells["colCK"].Value = 0;
                }

                //tính thành tiền
                long thanhtien = 0;
                if(gvPhieuXuat.Rows[e.RowIndex].Cells["colSoLuong"].Value!=null && gvPhieuXuat.Rows[e.RowIndex].Cells["colDonGia"].Value != null)
                {
                    thanhtien = long.Parse(gvPhieuXuat.Rows[e.RowIndex].Cells["colSoLuong"].Value.ToString()) * long.Parse(gvPhieuXuat.Rows[e.RowIndex].Cells["colDonGia"].Value.ToString());
                }
                gvPhieuXuat.Rows[e.RowIndex].Cells["colThanhTien"].Value = thanhtien;

                // tính giá tiền chiết khấu
                long chietKhau = 0;
                if (gvPhieuXuat.Rows[e.RowIndex].Cells["colCK"].Value != null)
                {
                    chietKhau = (long.Parse(gvPhieuXuat.Rows[e.RowIndex].Cells["colThanhTien"].Value.ToString()) * long.Parse(gvPhieuXuat.Rows[e.RowIndex].Cells["colCK"].Value.ToString())) / 100;
                }
                gvPhieuXuat.Rows[e.RowIndex].Cells["colChietKhau"].Value = chietKhau;

                // tính thanh toán
                long thanhtoan = 0;
                thanhtoan = long.Parse(gvPhieuXuat.Rows[e.RowIndex].Cells["colThanhTien"].Value.ToString()) - long.Parse(gvPhieuXuat.Rows[e.RowIndex].Cells["colChietKhau"].Value.ToString());
                gvPhieuXuat.Rows[e.RowIndex].Cells["colThanhToan"].Value = thanhtoan;
            }

            //thanh toan
            else if (col == 8)
            {
                TinhTongTienThanhToan();
                FillnmrThanhTien();
            }
        }

        private void LayThongTinHangHoa(string mahang, ref string tdv, ref long dg, ref int slTon)
        {
            string sql = "sp_LayThongTinHangHoa";

            Provider p = new Provider();
            p.Connect();

            SqlParameter tendv = new SqlParameter("@tendv", SqlDbType.NVarChar, 50);
            tendv.Direction = ParameterDirection.Output;
            SqlParameter dongia = new SqlParameter("@dongia", SqlDbType.Int);
            dongia.Direction = ParameterDirection.Output;
            SqlParameter slton = new SqlParameter("@slTon", SqlDbType.Int);
            slton.Direction = ParameterDirection.Output;

            p.ExecuteNonQuery(CommandType.StoredProcedure, sql,
                new SqlParameter { ParameterName = "@mahh", Value = mahang }, tendv, dongia, slton);

            tdv = tendv.Value.ToString();
            dg = long.Parse(dongia.Value.ToString());
            slTon = int.Parse(slton.Value.ToString());

            p.Disconnect();
        }

        private void LkueTenKH_EditValueChanged(object sender, EventArgs e)
        {
            lkueMaKH.EditValue = lkueTenKH.EditValue;
            FilltxtKhachHang(lkueMaKH.EditValue.ToString());
        }

        private void LkueMaKH_EditValueChanged(object sender, EventArgs e)
        {
            lkueTenKH.EditValue = lkueMaKH.EditValue;
            FilltxtKhachHang(lkueTenKH.EditValue.ToString());
        }

        private void FilltxtKhachHang(string makh)
        {
            string sql = "sp_LayThongTinKhachHang";

            Provider p = new Provider();
            p.Connect();

            SqlParameter diachi = new SqlParameter("@diachi", SqlDbType.NVarChar, 100);
            diachi.Direction = ParameterDirection.Output;
            SqlParameter dt = new SqlParameter("@dt", SqlDbType.VarChar, 13);
            dt.Direction = ParameterDirection.Output;

            p.ExecuteNonQuery(CommandType.StoredProcedure, sql, diachi, dt,
                new SqlParameter { ParameterName = "@makh", Value = makh });

            txtDiaChi.Text = diachi.Value.ToString();
            txtSDT.Text = dt.Value.ToString();

            p.Disconnect();
        }

        private void UcBanHang2_Load(object sender, EventArgs e)
        {
            AddNhatKy("Xem", TenChucNang);

            NapDuLieu();
            ResetForm();

            FillCbDKTT();//điều khoản thanh toán
            FillCbHTTT();//hình thức thanh toán

            // format 1000 separator
            gvPhieuXuat.Columns["colThanhToan"].DefaultCellStyle.Format = "#,###";
            gvPhieuXuat.Columns["colChietKhau"].DefaultCellStyle.Format = "#,###";
            gvPhieuXuat.Columns["colThanhTien"].DefaultCellStyle.Format = "#,###";
            gvPhieuXuat.Columns["colDonGia"].DefaultCellStyle.Format = "#,###";
        }

        private void NapDuLieu()
        {
            FillThongTinKhachHang();
            FillCbNhanVien();
            FillCbKhoXuat();
            FillDateEdit();
            
            txtMaPhieu.Text = GenerateMaPhieu();
            txtMaPhieu.ReadOnly = true;
            FillGridView();
            gvPhieuXuat.ContextMenuStrip = ctmsPhieuXuat;
            gvPhieuXuat.AllowUserToDeleteRows = true;
        }

        //reset form
        private void ResetForm()
        {
            lkueMaKH.ItemIndex = -1;
            lkueTenKH.ItemIndex = -1;
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
            nmrThanhTien.Value = 0;

            gvPhieuXuat.Rows.Clear();
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
            colChietKhau.ValueType = typeof(long);
            colCK.ValueType = typeof(long);
            colThanhToan.ValueType = typeof(long);
        }

        private string GenerateMaPhieu()
        {
            string sql = "sp_LayMaPhieuXuat";

            Provider p = new Provider();
            p.Connect();

            SqlParameter ma = new SqlParameter("@kq", SqlDbType.VarChar, 10);
            ma.Direction = ParameterDirection.Output;

            p.ExecuteNonQuery(CommandType.StoredProcedure, sql, ma);

            p.Disconnect();

            return ma.Value.ToString();
        }

        private void FillCbDKTT()
        {
            string[] dktt = { "Công Nợ", "Thanh toán ngay" };

            cbDKTT.Items.AddRange(dktt);
            cbDKTT.SelectedIndex = 0;
        }

        private void FillCbHTTT()
        {
            string[] httt = { "Tiền Mặt", "Chuyển Khoản" };

            cbHTTT.Items.AddRange(httt);
            cbHTTT.SelectedIndex = 0;
        }

        private void FillCbNhanVien()
        {
            string sql = "select MaNhanVien, TenNhanVien from NHANVIEN";
            DataTable dt = Execute.LayDuLieuBang(sql);

            lkueMaNV.Properties.DataSource = dt;
            lkueMaNV.Properties.ValueMember = "MaNhanVien";
            lkueMaNV.Properties.DisplayMember = "TenNhanVien";
        }

        private void FillThongTinKhachHang()
        {
            string sql = "select MaKH, TenKH from KHACH_HANG";
            DataTable dt = Execute.LayDuLieuBang(sql);

            //cb mã kh
            lkueMaKH.Properties.DataSource = dt;
            lkueMaKH.Properties.ValueMember = "MaKH";
            lkueMaKH.Properties.DisplayMember = "MaKH";

            //cb tên kh
            lkueTenKH.Properties.DataSource = dt;
            lkueTenKH.Properties.ValueMember = "MaKH";
            lkueTenKH.Properties.DisplayMember = "TenKH";
        }

        private void FillCbKhoXuat()
        {
            string sql = "select MaKho, TenKho from KHOHANG";
            DataTable dt = Execute.LayDuLieuBang(sql);

            lkueKho.Properties.DataSource = dt;
            lkueKho.Properties.ValueMember = "MaKho";
            lkueKho.Properties.DisplayMember = "TenKho";
        }

        private void FillDateEdit()
        {
            deNgayLap.EditValue = DateTime.Now;
            deNgayGiao.EditValue = DateTime.Now;
            deHanThanhToan.EditValue = DateTime.Now;
        }
    }
}
