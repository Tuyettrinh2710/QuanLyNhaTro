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
    public partial class frmPhong : Form
    {

        BUS_Phong busPhong;
        BUS_LoaiPhong busLoaiPhong;
        public frmPhong()
        {
            InitializeComponent();
            busPhong = new BUS_Phong();
            busLoaiPhong = new BUS_LoaiPhong();
        }

        private void frmPhong_Load(object sender, EventArgs e)
        {

            frmLoad();
            tbPhong.Focus();
            busLoaiPhong.DSLoai(cbLoai);
        }

        void loadText()
        {
            tbMa.Text = "";
            tbPhong.Text = "";
            tbToiDa.Text = "";
            tbHienTai.Text = "";
            tbPhong.Focus();
        }

        void frmLoad()
        {
            busPhong.LayDSPhong(dgvPhong);
            dgvPhong.Columns[0].Width = (int)(0.2 * dgvPhong.Width);
            dgvPhong.Columns[1].Width = (int)(0.2 * dgvPhong.Width);
            dgvPhong.Columns[2].Width = (int)(0.2 * dgvPhong.Width);
            dgvPhong.Columns[3].Width = (int)(0.2 * dgvPhong.Width);
            dgvPhong.Columns[4].Width = (int)(0.2 * dgvPhong.Width);
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string ten = tbPhong.Text;
            string idLoai = cbLoai.SelectedValue.ToString();
            int toiDa = int.Parse(tbToiDa.Text);
            int hienTai = int.Parse(tbHienTai.Text);
            busPhong.ThemPhong(ten, int.Parse(idLoai), toiDa, hienTai);
            frmLoad();
            loadText();
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < dgvPhong.Rows.Count - 1)
            {
                tbMa.Text = dgvPhong.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbPhong.Text = dgvPhong.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbLoai.SelectedItem = dgvPhong.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbToiDa.Text = dgvPhong.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbHienTai.Text = dgvPhong.Rows[e.RowIndex].Cells[4].Value.ToString();
                tbHienTai.Enabled = true;
                tbHienTai.ReadOnly = false;
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbMa.Text);
            string ten = tbPhong.Text;
            string idLoai = cbLoai.SelectedValue.ToString();
            int toiDa = int.Parse(tbToiDa.Text);
            int hienTai = int.Parse(tbHienTai.Text);
            busPhong.SuaPhong(id, ten, int.Parse(idLoai), toiDa, hienTai);
            frmLoad();
            loadText();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            busPhong.XoaPhong(int.Parse(tbMa.Text));
            frmLoad();
            loadText();
        }
    }
}
