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
    public partial class frmLoaiPhong : Form
    {
        BUS_LoaiPhong busLoai;
        public frmLoaiPhong()
        {
            InitializeComponent();
            busLoai = new BUS_LoaiPhong();
        }

        private void frmLoaiPhong_Load(object sender, EventArgs e)
        {
            busLoai.LayDSLoaiPhong(dgvLoai);
            dgvLoai.Columns[0].Width = (int)(0.2 * dgvLoai.Width);
            dgvLoai.Columns[1].Width = (int)(0.4 * dgvLoai.Width);
            dgvLoai.Columns[2].Width = (int)(0.35 * dgvLoai.Width);
        }

        private void dgvLoai_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                MessageBox.Show("Không thể sửa mã loại phòng");
            }    
            else if (e.ColumnIndex == 1)
            {
                MessageBox.Show("không thẻ sửa tên loại");
            }  
            else
            {
                int ma = (int)dgvLoai.Rows[e.RowIndex].Cells[0].Value;
                string ten = dgvLoai.Rows[e.RowIndex].Cells[1].Value.ToString();
                decimal gia = (decimal)dgvLoai.Rows[e.RowIndex].Cells[2].Value;
                busLoai.SuaLoaiPhong(ma, ten, gia);
            }
            busLoai.LayDSLoaiPhong(dgvLoai);
        }

        private void dgvLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex >= 0 && e.RowIndex < dgvLoai.Rows.Count - 1))
            {
                MessageBox.Show("Không thể sửa ngoài bảng dữ liệu");
            }
        }
    }
}
