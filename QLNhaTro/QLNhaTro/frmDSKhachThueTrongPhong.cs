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
    public partial class frmDSKhachThueTrongPhong : Form
    {
        BUS_Phong busphong;
        BUS_KhachHang busKhach;
        public frmDSKhachThueTrongPhong()
        {
            InitializeComponent();
            busphong = new BUS_Phong();
            busKhach = new BUS_KhachHang();
        }

        private void tbTim_TextChanged(object sender, EventArgs e)
        {
            if (tbTim.Text == "")
            {
                dgvKhach.DataSource = null;
            }
            else
            {
                int id = busphong.LayIDPhong(tbTim.Text);
                busKhach.LayDSKHTrongPhong(dgvKhach, id);
                dgvKhach.Columns[1].Width = (int)(0.2 * dgvKhach.Width);
                dgvKhach.Columns[5].Width = (int)(0.12 * dgvKhach.Width);
            }
        }

        private void btIn_Click(object sender, EventArgs e)
        {
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; 
            COMExcel.Worksheet exSheet; 
            COMExcel.Range exRange;
            try
            {
                exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
                exSheet = exBook.Worksheets[1];
                //Định dạng chung
                exRange = exSheet.Cells[1, 1];
                exRange.Range["A1:Z300"].Font.Name = "Times new roman";
                exRange.Range["B2:G2"].Font.Size = 16;
                exRange.Range["B2:G2"].Font.Bold = true;
                exRange.Range["B2:G2"].Font.ColorIndex = 3; //Màu đỏ
                exRange.Range["B2:G2"].MergeCells = true;
                exRange.Range["B2:G2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                string tieuDe = string.Format("DANH SÁCH KHÁCH PHÒNG {0}", tbTim.Text);
                exRange.Range["B2:G2"].Value = tieuDe;

                //Tạo dòng tiêu đề bảng
                exRange.Range["A4:H4"].Font.Bold = true;
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
                exRange.Range["H4:H4"].Value = "Tên phòng";

                for (int i = 0; i < dgvKhach.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgvKhach.Columns.Count; j++)
                    {
                        exSheet.Cells[i + 5, j + 1] = dgvKhach.Rows[i].Cells[j].Value.ToString();
                        if (j == 0|| j == 3 || j == 4 || j == 5 || j == 7)
                        {
                            string so = string.Format("\'{0}", dgvKhach.Rows[i].Cells[j].Value.ToString());
                            exRange.Cells[i + 5, j + 1] = so;
                        }
                    }    
                }    

                //đóng file
                exSheet.Name = "Danh sách khách";
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
