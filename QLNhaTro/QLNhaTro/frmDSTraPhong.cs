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
    public partial class frmDSTraPhong : Form
    {
        BUS_TraPhong busTra;
        public frmDSTraPhong()
        {
            InitializeComponent();
            busTra = new BUS_TraPhong();
        }

        private void frmDSTraPhong_Load(object sender, EventArgs e)
        {
            cbThang.SelectedIndex = 0;
            busTra.LayDSTraPhong(dgvTra, 0, dtpNam.Value.Year);
            dgvTra.Columns[0].Width = (int)(0.15 * dgvTra.Width);
            dgvTra.Columns[1].Width = (int)(0.3 * dgvTra.Width);
            dgvTra.Columns[2].Width = (int)(0.15 * dgvTra.Width);
            dgvTra.Columns[3].Width = (int)(0.2 * dgvTra.Width);
            dgvTra.Columns[4].Width = (int)(0.15 * dgvTra.Width);
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            busTra.LayDSTraPhong(dgvTra, cbThang.SelectedIndex, dtpNam.Value.Year);
        }
    }
}
