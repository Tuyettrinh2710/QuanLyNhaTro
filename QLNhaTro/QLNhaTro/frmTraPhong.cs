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
    public partial class frmTraPhong : Form
    {
        BUS_KhachHang busKhach;
        BUS_TraPhong busTra;
        BUS_ThuePhong busThue;
        BUS_Phong busPhong;
        string idKH = null;
        public frmTraPhong()
        {
            InitializeComponent();
            busKhach = new BUS_KhachHang();
            busTra = new BUS_TraPhong();
            busThue = new BUS_ThuePhong();
            busPhong = new BUS_Phong();
        }

        private void addForm(Form f)
        {
            this.pnlTraPhong.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.Text = f.Text;
            this.pnlTraPhong.Controls.Add(f);
            f.Show();
        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {
            var f = new frmThanhToanTP();
            addForm(f);
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvKhach.Rows.Count - 1)
            {
                idKH = dgvKhach.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbten.Text = dgvKhach.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbGioiTinh.Text = dgvKhach.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpNgaySinh.Value = (DateTime)dgvKhach.Rows[e.RowIndex].Cells[3].Value;
                tbSDT.Text = dgvKhach.Rows[e.RowIndex].Cells[4].Value.ToString();
                tbCMND.Text = dgvKhach.Rows[e.RowIndex].Cells[5].Value.ToString();
                tbQueQuan.Text = dgvKhach.Rows[e.RowIndex].Cells[6].Value.ToString();
                string tenPhong = dgvKhach.Rows[e.RowIndex].Cells[7].Value.ToString();
                int idPhong = busTra.LayMaPhongTheoTen(tenPhong);
                tbMaPhong.Text = idPhong.ToString();
                busThue.LayThongTinThue(idKH, idPhong, tbMaThue, tbTienCoc, dtpNgayThue);
            }
        }

        private void frmTraPhong_Load(object sender, EventArgs e)
        {
            busKhach.LayDSKhachHang(dgvKhach, "");
            dgvKhach.DefaultCellStyle.ForeColor = Color.Black;
            dgvKhach.Columns[1].Width = (int)(0.3 * dgvKhach.Width);
            dgvKhach.Columns[5].Width = (int)(0.12 * dgvKhach.Width);
        }

        private void tbTim_TextChanged(object sender, EventArgs e)
        {
            if (tbTim.Text == "")
            {
                busKhach.LayDSKhachHang(dgvKhach, "");
            }
            else
                busKhach.LayDSKhachHang(dgvKhach, tbTim.Text);
        }

        private void btTra_Click(object sender, EventArgs e)
        {
            string idThue = tbMaThue.Text;
            int idPhong = int.Parse(tbMaPhong.Text);
            DateTime ngayThue = dtpNgayThue.Value.Date;
            DateTime ngayTra = dtpNgayTra.Value.Date;
            if (idThue == null || idKH == null || idPhong == 0)
            {
                MessageBox.Show("Thông tin không hợp lệ. Trả phòng thất bại");
            }    
            else if (busTra.ThemTraPhong(idThue, idKH, idPhong, ngayThue, ngayTra))
            {
                int soNguoi = busPhong.LaySoNguoiTrongPhong(idPhong);
                busPhong.UpdateSoNguoi(idPhong, soNguoi - 1);
                busKhach.CapNhatMaPhongNULL(idKH);
            }
            else
                MessageBox.Show("Trả phòng thất bại");
        }
    }
}
