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

namespace QLNhaTro
{
    public partial class frmDanhSachKH : Form
    {
        BUS_KhachHang busKH;
        public frmDanhSachKH()
        {
            InitializeComponent();
            busKH = new BUS_KhachHang();
        }

        private void frmDanhSachKH_Load(object sender, EventArgs e)
        {
            loadDGV();
        }

        void loadDGV()
        {
            busKH.LayDSKhachHang(dgvKhach, "");
            dgvKhach.Columns[1].Width = (int)(0.2 * dgvKhach.Width);
            dgvKhach.Columns[5].Width = (int)(0.12 * dgvKhach.Width);
        }

        private void tbTim_TextChanged(object sender, EventArgs e)
        {
            if (tbTim.Text == "")
            {
                busKH.LayDSKhachHang(dgvKhach, "");
            }    
            else
                busKH.LayDSKhachHang(dgvKhach, tbTim.Text);
        }

        private void dgvKhach_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                MessageBox.Show("Không thể sửa mã khách hàng");
            }
            else if (e.ColumnIndex == 7)
            {
                MessageBox.Show("Không thể sửa mã phòng");
            }
            else
            {
                string ma = dgvKhach.Rows[e.RowIndex].Cells[0].Value.ToString();
                string ten = dgvKhach.Rows[e.RowIndex].Cells[1].Value.ToString();
                string gioiTinh = dgvKhach.Rows[e.RowIndex].Cells[2].Value.ToString();
                DateTime ngay = (DateTime)dgvKhach.Rows[e.RowIndex].Cells[3].Value;
                string sdt = dgvKhach.Rows[e.RowIndex].Cells[4].Value.ToString();
                string cmnd = dgvKhach.Rows[e.RowIndex].Cells[5].Value.ToString();
                string queQuan = dgvKhach.Rows[e.RowIndex].Cells[6].Value.ToString();
                busKH.SuaKh(ma, ten, gioiTinh, ngay, sdt, cmnd, queQuan);
            }
            dgvKhach.Refresh();
            loadDGV();
        }
    }
}
