using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYBANHANG.BUS;
using QUANLYBANHANG.DTO;
using System.IO;
using System.Diagnostics;
using QUANLYBANHANG.DAO;

namespace QUANLYBANHANG.GUI.tabChucNang.TraTien
{
    public partial class ucDSCongNoTra : UserControl
    {
        public delegate void dDSCongNoTra();
        public event dDSCongNoTra KhoiDong;
        public event dDSCongNoTra Luu;
        public event dDSCongNoTra Xuat;

        // username
        string user;

        NGHIEPVU_PHIEUCHITIEN nv_pct = new NGHIEPVU_PHIEUCHITIEN();

        int CurRowIndex;

        public ucDSCongNoTra(VaiTro_ChucNang pqtt, string un)
        {
            InitializeComponent();

            user = un;

            Load += UcDSCongNoTra_Load;

            //button
            btnLapPhieuChi.Click += BtnLapPhieuChi_Click;
            btnXem.Click += BtnXem_Click;
            btnXuat.Click += BtnXuat_Click;


            // lấy chỉ số dòng hiện tại
            gvChiTien.FocusedRowChanged += GvChiTien_FocusedRowChanged;
            gvChiTien.DoubleClick += BtnLapPhieuChi_Click;
            gvChiTien.ShowingEditor += GvChiTien_ShowingEditor;

            //phân quyền dựa vào bảng vai trò chức năng đã được gửi qua
            if (pqtt != null)
            {
                if (pqtt.Them == 0)
                {
                    btnLapPhieuChi.Enabled = false;
                }
                if (pqtt.Xuat == 0)
                {
                    btnXuat.Enabled = false;
                }
            }
        }

        private void GvChiTien_ShowingEditor(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void GvChiTien_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            CurRowIndex = int.Parse(e.FocusedRowHandle.ToString());
        }

        private void BtnLapPhieuChi_Click(object sender, EventArgs e)
        {
            if (CurRowIndex >= 0)
            {
                PhieuChiTien pc = LayPhieuChi();

                frmLapPhieuChi lpc = new frmLapPhieuChi(pc);
                lpc.ThemThanhCong += Lpt_ThemThanhCong; ;
                lpc.ThemThanhCong += FillGridView;
                lpc.ShowDialog();
            }
        }

        private void UcDSCongNoTra_Load(object sender, EventArgs e)
        {
            deTuNgay.EditValue = null;
            deDenNgay.EditValue = null;
            KhoiDong();
            FillGridView();
        }

        private void BtnXuat_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            saveFileDialogExcel.Filter = "Microsoft Excel (2003)(*.xls)|*.xls|Microsoft Excel (2010) (*.xlsx)|*.xlsx |PDF File (*.pdf)|*.pdf";
            saveFileDialogExcel.Title = "Save as";
            saveFileDialogExcel.FileName = "document";

            DialogResult dr = saveFileDialogExcel.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string FilePath = saveFileDialogExcel.FileName;
                string fileExtension = new FileInfo(FilePath).Extension;

                switch (fileExtension)
                {
                    case ".xls":
                        gcPhieuChiTien.ExportToXls(FilePath);
                        break;
                    case ".xlsx":
                        gcPhieuChiTien.ExportToXlsx(FilePath);
                        break;
                    case ".pdf":
                        gcPhieuChiTien.ExportToPdf(FilePath);
                        break;
                    default:
                        break;
                }

                if (File.Exists(FilePath))
                {
                    Xuat();
                    if (MessageBox.Show("Bạn có muốn mở file lên không?", "Mở File Đã Xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            Process.Start(FilePath);
                        }
                        catch
                        {
                            MessageBox.Show("Không thể mở file");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("File chưa được lưu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnXem_Click(object sender, EventArgs e)
        {
            FillGridView();
        }

        private PhieuChiTien LayPhieuChi()
        {
            PhieuChiTien pc = new PhieuChiTien();

            pc.MaPhieuXuat = gvChiTien.GetRowCellValue(CurRowIndex, "MaPhieu").ToString();
            pc.MaNCC = gvChiTien.GetRowCellValue(CurRowIndex, "MaNCC").ToString();
            pc.SoTien = int.Parse(gvChiTien.GetRowCellValue(CurRowIndex, "TongTien").ToString());
            pc.ConNo = int.Parse(gvChiTien.GetRowCellValue(CurRowIndex, "ConLai").ToString());
            pc.NgayLap = DateTime.Now;
            pc.LyDo = "Chi tiền mua hàng";

            return pc;
        }
        

        private void FillGridView()
        {
            string adding = "";
            if (deTuNgay.EditValue != null && deDenNgay.EditValue != null)
            {
                adding = string.Format(" and pn.NgayLap >= '{0}' and pn.NgayLap <= '{1}'",
                    DateTime.Parse(deTuNgay.EditValue.ToString()).ToShortDateString(),
                    DateTime.Parse(deDenNgay.EditValue.ToString()).ToShortDateString());
            }

            string sql = "select pn.MaPhieu, pn.NgayLap, pn.MaNCC, ncc.TenNCC, pn.TongTien, pn.DaTra, pn.GhiChu " +
                "from PHIEU_NHAP pn, NHACUNGCAP ncc " +
                "where pn.MaNCC=ncc.MaNCC and pn.DieuKhoanThanhToan like N'%công n%' and pn.DaTra != pn.TongTien" + adding;

            DataTable dt = Execute.LayDuLieuBang(sql);
            gcPhieuChiTien.DataSource = dt;
            gvChiTien.ExpandAllGroups();
        }

        private void Lpt_ThemThanhCong()
        {
            Luu();
        }
    }
}
