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
using QUANLYBANHANG.DAO;
using System.IO;
using System.Diagnostics;

namespace QUANLYBANHANG.GUI.tabChucNang
{
    public partial class ucDSCongNo : UserControl
    {
        public delegate void dDSCongNo();
        public event dDSCongNo KhoiDong;
        public event dDSCongNo Luu;
        public event dDSCongNo Xuat;

        // username
        string user;

        NGHIEPVU_PHIEUTHUTIEN nv_pt = new NGHIEPVU_PHIEUTHUTIEN();

        int CurRowIndex;

        public ucDSCongNo(VaiTro_ChucNang pqtt, string un)
        {
            InitializeComponent();

            user = un;

            Load += UcDSCongNo_Load1;

            //button
            btnLapPhieuThu.Click += BtnLapPhieuThu_Click;
            btnXem.Click += BtnXem_Click;
            btnXuat.Click += BtnXuat_Click;
            

            // lấy chỉ số dòng hiện tại
            gvThuTien.FocusedRowChanged += GvThuTien_FocusedRowChanged;
            gvThuTien.DoubleClick += BtnLapPhieuThu_Click;
            gvThuTien.ShowingEditor += GvThuTien_ShowingEditor;

            //phân quyền dựa vào bảng vai trò chức năng đã được gửi qua
            if (pqtt != null)
            {
                if (pqtt.Them == 0)
                {
                    btnLapPhieuThu.Enabled = false;
                }
                if (pqtt.Xuat == 0)
                {
                    btnXuat.Enabled = false;
                }
            }
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
                        gcPhieuThuTien.ExportToXls(FilePath);
                        break;
                    case ".xlsx":
                        gcPhieuThuTien.ExportToXlsx(FilePath);
                        break;
                    case ".pdf":
                        gcPhieuThuTien.ExportToPdf(FilePath);
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

        private void UcDSCongNo_Load1(object sender, EventArgs e)
        {
            deTuNgay.EditValue = null;
            deDenNgay.EditValue = null;
            KhoiDong();
            FillGridView();
        }

        private PhieuThuTien LayPhieuThu()
        {
            PhieuThuTien pt = new PhieuThuTien();

            pt.MaPhieuXuat = gvThuTien.GetRowCellValue(CurRowIndex, "MaPhieu").ToString();
            pt.MaKH = gvThuTien.GetRowCellValue(CurRowIndex, "MaKH").ToString();
            pt.SoTien = int.Parse(gvThuTien.GetRowCellValue(CurRowIndex, "TongTien").ToString());
            pt.ConNo = int.Parse(gvThuTien.GetRowCellValue(CurRowIndex, "ConLai").ToString());
            pt.NgayLap = DateTime.Now;
            pt.LyDo = "Thu tiền khách hàng";

            return pt;
        }

        private void GvThuTien_ShowingEditor(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void GvThuTien_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            CurRowIndex = int.Parse(e.FocusedRowHandle.ToString());
        }

        private void FillGridView()
        {
            string adding = "";
            if(deTuNgay.EditValue!=null && deDenNgay.EditValue != null)
            {
                adding = string.Format(" and px.NgayLap >= '{0}' and px.NgayLap <= '{1}'",
                    DateTime.Parse(deTuNgay.EditValue.ToString()).ToShortDateString(), 
                    DateTime.Parse(deDenNgay.EditValue.ToString()).ToShortDateString());
            }

            string sql = "select px.MaPhieu, px.NgayLap, px.MaKH, kh.TenKH, px.TongTien, px.DaTra, px.GhiChu " +
                "from PHIEU_XUAT px, KHACH_HANG kh " +
                "where px.MaKH=kh.MaKH and px.DieuKhoanThanhToan like N'%công n%' and px.DaTra != px.TongTien" + adding;

            DataTable dt = Execute.LayDuLieuBang(sql);
            gcPhieuThuTien.DataSource = dt;
            gvThuTien.ExpandAllGroups();
        }

        private void BtnLapPhieuThu_Click(object sender, EventArgs e)
        {
            if (CurRowIndex >= 0)
            {
                PhieuThuTien pt = LayPhieuThu();

                frmLapPhieuThu lpt = new frmLapPhieuThu(pt);
                lpt.ThemThanhCong += Lpt_ThemThanhCong;
                lpt.ThemThanhCong += FillGridView;
                lpt.ShowDialog();
            }
        }

        private void Lpt_ThemThanhCong()
        {
            Luu();
        }
    }
}
