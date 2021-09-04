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
            frmLoad();
        }

        void loadText()
        {
            tbMa.Text = "";
            tbTen.Text = "";
            tbGia.Text = "";
        }

        void frmLoad()
        {
            busPhi.DSPhi(dgvPhi);
            dgvPhi.Columns[0].Width = (int)(0.2 * dgvPhi.Width);
            dgvPhi.Columns[1].Width = (int)(0.4 * dgvPhi.Width);
            dgvPhi.Columns[2].Width = (int)(0.35 * dgvPhi.Width);
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            busPhi.Them(tbTen.Text, double.Parse(tbGia.Text));
            frmLoad();
            loadText();
        }

        private void dgvPhi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvPhi.Rows.Count)
            {
                tbMa.Text = dgvPhi.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbTen.Text = dgvPhi.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbGia.Text = dgvPhi.Rows[e.RowIndex].Cells[2].Value.ToString(); 
            }

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            busPhi.Sua(int.Parse(tbMa.Text), tbTen.Text, double.Parse(tbGia.Text));
            frmLoad();
            loadText();
        }

        private void btXoa_Click(object sender,EventArgs e)
        {
            busPhi.Xoa(int.Parse(tbMa.Text));
            frmLoad();
            loadText();
        }
    }
}
