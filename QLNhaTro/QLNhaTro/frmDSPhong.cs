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
    public partial class frmDSPhong : Form
    {
        BUS_Phong busPhong;
        public frmDSPhong()
        {
            InitializeComponent();
            busPhong = new BUS_Phong();
        }

        private void frmDSPhong_Load(object sender, EventArgs e)
        {
            busPhong.LayDSPhongTrong(dgvPhong);
            dgvPhong.Columns[3].Width = (int)(0.22 * dgvPhong.Width);
            dgvPhong.Columns[4].Width = (int)(0.22 * dgvPhong.Width);
        }

        private void rbTrong_CheckedChanged(object sender, EventArgs e)
        {
            busPhong.LayDSPhongTrong(dgvPhong);
        }

        private void rbDaThue_CheckedChanged(object sender, EventArgs e)
        {
            busPhong.LayDSPhongDaChoThue(dgvPhong);
        }
    }
}
