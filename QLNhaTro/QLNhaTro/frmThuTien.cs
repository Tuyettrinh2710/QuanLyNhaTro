using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace QLNhaTro
{
    public partial class frmThuTien : Form
    {
        BUS_ThanhToan busThanhToan;
        BUS_Phi busPhi;
        public frmThuTien()
        {
            InitializeComponent();
            busThanhToan = new BUS_ThanhToan();
            busPhi = new BUS_Phi();
        }

        private void frmThuTien_Load(object sender, EventArgs e)
        {
            busThanhToan.LayHoaDonChuaThu(dgvHoaDon);
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvHoaDon.Rows.Count - 1)
            {
                tbMaHD.Text = dgvHoaDon.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbTenPhong.Text = dgvHoaDon.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbTen.Text = dgvHoaDon.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpNgayLap.Value = (DateTime)dgvHoaDon.Rows[e.RowIndex].Cells[3].Value;
                tbTienPhong.Text = dgvHoaDon.Rows[e.RowIndex].Cells[4].Value.ToString();
                tbSKDien.Text = dgvHoaDon.Rows[e.RowIndex].Cells[5].Value.ToString();
                tbTienDien.Text = dgvHoaDon.Rows[e.RowIndex].Cells[6].Value.ToString();
                tbSKNuoc.Text = dgvHoaDon.Rows[e.RowIndex].Cells[7].Value.ToString();
                tbTienNuoc.Text = dgvHoaDon.Rows[e.RowIndex].Cells[8].Value.ToString();
                tbDichVu.Text = dgvHoaDon.Rows[e.RowIndex].Cells[9].Value.ToString();
                tbTongTien.Text = dgvHoaDon.Rows[e.RowIndex].Cells[10].Value.ToString();
            }
        }

        private void btIn_Click(object sender, EventArgs e)
        {
            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            //int hang = 0, cot = 0;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN THU TIỀN";
            //Thông tin hóa đơn
            exRange.Range["B4:F7"].Font.Size = 12;
            exRange.Range["B4:B4"].Value = "Ngày thu:";
            exRange.Range["D4:F4"].MergeCells = true;
            exRange.Range["D4:F4"].Value = dtpNgayThu.Value.ToString();

            exRange.Range["B5:B5"].Value = "Mã hóa đơn:";
            exRange.Range["D5:F5"].MergeCells = true;
            exRange.Range["D5:F5"].Value = tbMaHD.Text;

            exRange.Range["B6:B6"].Value = "Họ tên khách thuê:";
            exRange.Range["D6:F6"].MergeCells = true;
            exRange.Range["D6:F6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
            exRange.Range["D6:F6"].Value = tbTen.Text;

            exRange.Range["B7:B7"].Value = "Tên phòng:";
            exRange.Range["D7:F7"].MergeCells = true;
            exRange.Range["D7:F7"].Value = tbTenPhong.Text;

            //Tạo dòng tiêu đề bảng
            exRange.Range["B9:F13"].Borders.LineStyle = true;
            exRange.Range["B9:F9"].Font.Bold = true;
            exRange.Range["B9:F9"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C9:F9"].ColumnWidth = 12;
            exRange.Range["B9:B9"].Value = "STT";
            exRange.Range["C9:C9"].Value = "Tên phí";
            exRange.Range["D9:D9"].Value = "Số lượng";
            exRange.Range["E9:E9"].Value = "Giá tiền";
            exRange.Range["F9:F9"].Value = "Thành tiền";

            //thông tin tiền phòng
            exRange.Range["B10:B10"].Value = "1";
            exRange.Range["C10:C10"].Value = "Tiền phòng";
            exRange.Range["D10:D10"].Value = "1";
            exRange.Range["E10:E10"].Value = tbTienPhong.Text;
            exRange.Range["F10:F10"].Value = tbTienPhong.Text;

            //Tiền điện
            exRange.Range["B11:B11"].Value = "2";
            exRange.Range["C11:C11"].Value = "Tiền điện";
            exRange.Range["D11:D11"].Value = tbSKDien.Text;
            exRange.Range["E11:E11"].Value = busPhi.LayGia(16).ToString();
            exRange.Range["F11:F11"].Value = tbTienDien.Text;

            //Tiền nước
            exRange.Range["B12:B12"].Value = "3";
            exRange.Range["C12:C12"].Value = "Tiền nước";
            exRange.Range["D12:D12"].Value = tbSKNuoc.Text;
            exRange.Range["E12:E12"].Value = busPhi.LayGia(2).ToString();
            exRange.Range["F12:F12"].Value = tbTienNuoc.Text;

            //Tiền dịch vụ
            exRange.Range["B13:B13"].Value = "4";
            exRange.Range["C13:C13"].Value = "Tiền dịch vụ";
            exRange.Range["D13:D13"].Value = "1";
            exRange.Range["E13:E13"].Value = busPhi.LayGia(3).ToString();
            exRange.Range["F13:F13"].Value = tbDichVu.Text;

            //Tổng tiền
            exRange.Range["E14:F14"].Font.Bold = true;
            exRange.Range["E14:F14"].Value = "Tổng tiền:";
            exRange.Range["F14:F14"].Value = tbTongTien.Text;

            //cuối hóa đơn
            exRange.Range["E16:E16"].Font.Italic = true;
            exRange.Range["E16:F17"].Font.Size = 12;
            string ngay = string.Format("Ngày {0} tháng {1} năm {2}", dtpNgayThu.Value.Day, dtpNgayThu.Value.Month, dtpNgayThu.Value.Year);
            exRange.Range["E16:E16"].Value = ngay;
            exRange.Range["E17:F17"].MergeCells = true;
            exRange.Range["E17:F17"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["E17:E17"].Value = "Người thu tiền";

            exSheet.Name = "Hóa đơn nhập";
            exApp.Visible = true;

        }
    }
}
