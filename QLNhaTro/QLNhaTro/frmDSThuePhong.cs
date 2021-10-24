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
    public partial class frmDSThuePhong : Form
    {
        BUS_ThuePhong busThue;
        public frmDSThuePhong()
        {
            InitializeComponent();
            busThue = new BUS_ThuePhong();
        }

        private void frmDSThuePhong_Load(object sender, EventArgs e)
        {
            cbThang.SelectedIndex = 0;
            busThue.LayDSThuePhong(dgvThue, 0, dtpNam.Value.Year);
            dgvThue.Columns[0].Width = (int)(0.15 * dgvThue.Width);
            dgvThue.Columns[1].Width = (int)(0.3 * dgvThue.Width);
            dgvThue.Columns[2].Width = (int)(0.15 * dgvThue.Width);
            dgvThue.Columns[3].Width = (int)(0.2 * dgvThue.Width);
            dgvThue.Columns[4].Width = (int)(0.15 * dgvThue.Width);
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            busThue.LayDSThuePhong(dgvThue, cbThang.SelectedIndex, dtpNam.Value.Year);
        }
    }
}
