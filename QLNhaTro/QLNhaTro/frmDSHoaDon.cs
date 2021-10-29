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
    public partial class frmDSHoaDon : Form
    {
        BUS_ThanhToan busThanhToan;
        public frmDSHoaDon()
        {
            InitializeComponent();
            busThanhToan = new BUS_ThanhToan();
        }

        private void frmDSHoaDon_Load(object sender, EventArgs e)
        {
            cbThang.SelectedIndex = 0;
            busThanhToan.LayDSHoaDon(dgvHoaDon, 0, dtpNam.Value.Year);
            dgvHoaDon.Columns[1].Width = (int)(0.2 * dgvHoaDon.Width);
            dgvHoaDon.Columns[3].Width = (int)(0.2 * dgvHoaDon.Width);
            dgvHoaDon.Columns[4].Width = (int)(0.2 * dgvHoaDon.Width);
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            busThanhToan.LayDSHoaDon(dgvHoaDon, cbThang.SelectedIndex, dtpNam.Value.Year);
        }

        private void btIn_Click(object sender, EventArgs e)
        {
            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            try
            {
                exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
                exSheet = exBook.Worksheets[1];
                // Định dạng chung
                exRange = exSheet.Cells[1, 1];
                exRange.Range["A1:Z300"].Font.Name = "Times new roman";
                exRange.Range["D2:J2"].Font.Size = 16;
                exRange.Range["D2:J2"].Font.Bold = true;
                exRange.Range["D2:J2"].Font.ColorIndex = 3; //Màu đỏ
                exRange.Range["D2:J2"].MergeCells = true;
                exRange.Range["D2:J2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["D2:J2"].Value = "DANH SÁCH HÓA ĐƠN";

                exRange.Range["B4:B4"].Font.Bold = true;
                exRange.Range["B4:B4"].Value = "Năm:";
                exRange.Range["C4:C4"].Value = dtpNam.Value.Year;
                exRange.Range["I4:I4"].Font.Bold = true;
                exRange.Range["I4:I4"].Value = "Tháng:";
                exRange.Range["J4:J4"].Value = cbThang.Text;

                //Tạo dòng tiêu đề bảng
                exRange.Range["A6:M6"].Font.Bold = true;
                exRange.Range["A6:M6"].Borders.LineStyle = true;
                exRange.Range["A6:M200"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["A6:A6"].Value = "ID";
                exRange.Range["B:B"].ColumnWidth = 20;
                exRange.Range["B6:B6"].Value = "Tên khách hàng";
                exRange.Range["C6:C6"].Value = "Tên phòng";
                exRange.Range["D:E"].ColumnWidth = 18;
                exRange.Range["D6:D6"].Value = "Ngày lập";
                exRange.Range["E6:E6"].Value = "Ngày thu";
                exRange.Range["F:M"].ColumnWidth = 12;
                exRange.Range["F6:F6"].Value = "Giá phòng";
                exRange.Range["G6:G6"].Value = "Số kí điện";
                exRange.Range["H6:H6"].Value = "Tiền điện";
                exRange.Range["I6:I6"].Value = "Số khối nước";
                exRange.Range["J6:J6"].Value = "Tiền điện";
                exRange.Range["K6:K6"].Value = "Tiền dịch vụ";
                exRange.Range["L6:L6"].Value = "Tổng tiền";
                exRange.Range["M6:M6"].Value = "Trạng thái";


                for (int i = 0; i < dgvHoaDon.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgvHoaDon.Columns.Count; j++)
                    {
                        exSheet.Cells[i + 7, j + 1].Borders.LineStyle = true;
                        if (j == 4)
                        {
                            if (dgvHoaDon.Rows[i].Cells[4].Value == null)
                                exSheet.Cells[i + 7, j + 1] = "0/0/0000";
                            else
                                exSheet.Cells[i + 7, j + 1] = dgvHoaDon.Rows[i].Cells[j].Value.ToString();
                        }
                        else
                        {
                            exSheet.Cells[i + 7, j + 1] = dgvHoaDon.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                }



                exSheet.Name = "Danh sách hóa đơn";
                exApp.Visible = true;
                exBook.Close();
                exApp.Quit();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                exBook = null;
                exSheet = null;
            }
        }
    }
}
