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
            busKH.LayDSKhachHang(dgvKhach);
            dgvKhach.Columns[1].Width = (int)(0.2 * dgvKhach.Width);
            dgvKhach.Columns[5].Width = (int)(0.12 * dgvKhach.Width);
        }
    }
}
