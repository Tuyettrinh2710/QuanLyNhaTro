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
    public partial class frmPhi : Form
    {
        BUS_Phi busPhi;
        public frmPhi()
        {
            InitializeComponent();
            busPhi = new BUS_Phi();
        }

        private void frmPhi_Load(object sender, EventArgs e)
        {
            busPhi.DSPhi(dgvPhi);
            dgvPhi.Columns[0].Width = (int)(0.2 * dgvPhi.Width);
            dgvPhi.Columns[1].Width = (int)(0.4 * dgvPhi.Width);
            dgvPhi.Columns[2].Width = (int)(0.35 * dgvPhi.Width);
        }

        private void dgvPhi_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                MessageBox.Show("Không thể sửa mã phí");
            }
            else if (e.ColumnIndex == 1)
            {
                MessageBox.Show("Không thể sửa tên phí");
            }
            else if (dgvPhi.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
            {
                MessageBox.Show("Dữ liệu trống. Sửa thất bại");
            }
            else
            {
                int ma = (int) dgvPhi.Rows[e.RowIndex].Cells[0].Value;
                string ten = dgvPhi.Rows[e.RowIndex].Cells[1].Value.ToString();
                decimal gia = (decimal) dgvPhi.Rows[e.RowIndex].Cells[2].Value;
                busPhi.Sua(ma, ten, gia);
            }
            busPhi.DSPhi(dgvPhi);
        }
    }
}
