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
            busLoai.LayDSLoaiPhong(dgvLoai);
            dgvLoai.Columns[0].Width = (int)(0.2 * dgvLoai.Width);
            dgvLoai.Columns[1].Width = (int)(0.4 * dgvLoai.Width);
            dgvLoai.Columns[2].Width = (int)(0.35 * dgvLoai.Width);
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            busLoai.ThemLoaiPhong(tbTen.Text, double.Parse(tbGia.Text));
            frmLoad();
            loadText();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            busLoai.SuaLoaiPhong(int.Parse(tbMa.Text), tbTen.Text, double.Parse(tbGia.Text));
            frmLoad();
            loadText();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            busLoai.XoaLoaiPhong(int.Parse(tbMa.Text));
            frmLoad();
            loadText();
        }

        private void dgvLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvLoai.Rows.Count - 1)
            {
                tbMa.Text = dgvLoai.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbTen.Text = dgvLoai.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbGia.Text = dgvLoai.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }
    }
}
