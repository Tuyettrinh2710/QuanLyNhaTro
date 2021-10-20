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
    public partial class frmDSKhachThue : Form
    {
        BUS_KhachHang busKhach;
        public frmDSKhachThue()
        {
            InitializeComponent();
            busKhach = new BUS_KhachHang();
        }

        private void rbDang_CheckedChanged(object sender, EventArgs e)
        {
            busKhach.LayDSKhachHang(dgvKhach, "");
        }

        private void rbKhongCon_CheckedChanged(object sender, EventArgs e)
        {
            busKhach.LayDSKhachKhongConThue(dgvKhach);
        }

        private void frmDSKhachThue_Load(object sender, EventArgs e)
        {
            busKhach.LayDSKhachHang(dgvKhach, "");
            dgvKhach.Columns[1].Width = (int)(0.3 * dgvKhach.Width);
            dgvKhach.Columns[5].Width = (int)(0.2 * dgvKhach.Width);
        }

        private void btIN_Click(object sender, EventArgs e)
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
                exRange.Range["B2:F2"].Font.Size = 16;
                exRange.Range["B2:F2"].Font.Bold = true;
                exRange.Range["B2:F2"].Font.ColorIndex = 3; //Màu đỏ
                exRange.Range["B2:F2"].MergeCells = true;
                exRange.Range["B2:F2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["B2:F2"].Value = "DANH SÁCH KHÁCH THUÊ";

                //Tạo dòng tiêu đề bảng
                exRange.Range["A4:H4"].Font.Bold = true;
                exRange.Range["A4:H4"].Borders.LineStyle = true;
                exRange.Range["A4:H20"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["A:A"].ColumnWidth = 12;
                exRange.Range["A4:A4"].Value = "ID";
                exRange.Range["B:B"].ColumnWidth = 20;
                exRange.Range["B4:B4"].Value = "Tên khách hàng";
                exRange.Range["C4:C4"].Value = "Giới tính";
                exRange.Range["D:D"].ColumnWidth = 18;
                exRange.Range["D4:D4"].Value = "Ngày sinh";
                exRange.Range["E:H"].ColumnWidth = 12;
                exRange.Range["E4:E4"].Value = "Số điện thoại";
                exRange.Range["F4:F4"].Value = "CMND";
                exRange.Range["G4:G4"].Value = "Quê quán";
                if (rbDang.Checked)
                {
                    exRange.Range["H4:H4"].Value = "Tên phòng";
                }
                else
                {
                    exRange.Range["H4:H4"].Borders.LineStyle = false;
                }    

                for (int i = 0; i < dgvKhach.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgvKhach.Columns.Count; j++)
                    {
                        exSheet.Cells[i + 5, j + 1].Borders.LineStyle = true;
                        exSheet.Cells[i + 5, j + 1] = dgvKhach.Rows[i].Cells[j].Value.ToString();
                        if (j == 0 || j == 3 || j == 4 || j == 5 || j == 7)
                        {
                            string so = string.Format("\'{0}", dgvKhach.Rows[i].Cells[j].Value.ToString());
                            exRange.Cells[i + 5, j + 1] = so;
                        }
                    }
                }



                exSheet.Name = "Danh sách khách thuê";
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
