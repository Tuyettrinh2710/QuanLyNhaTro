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
    public partial class frmCapNhatKH : Form
    {
        BUS_KhachHang busKH;
        BUS_Phong busPhong;
        public frmCapNhatKH()
        {
            InitializeComponent();
            busKH = new BUS_KhachHang();
            busPhong = new BUS_Phong();
        }

        private void frmCapNhatKH_Load(object sender, EventArgs e)
        {
            frmLoad();
            busPhong.LayTenPhong(cbMaPhong);
        }

        void frmLoad()
        {
            busKH.LayDSKhachHang(dgvKH, "");
            dgvKH.Columns[1].Width = (int)(0.4 * dgvKH.Width);
            dgvKH.DefaultCellStyle.ForeColor = Color.Black;
        }

        void loadText()
        {
            tbMa.Text = "";
            tbTen.Text = "";
            tbQueQuan.Text = "";
            tbSdt.Text =  "";
            dtpNgay.Value = DateTime.Today;
            cbGioiTinh.SelectedIndex = -1;
            tbCMND.Text = "";
        }    

        private void btThem_Click(object sender, EventArgs e)
        {
            int maPhong = int.Parse(cbMaPhong.SelectedValue.ToString());
            int soNguoi = busPhong.LaySoNguoiConTrong(maPhong);
            if (tbTen.TextLength == 0 || tbSdt.TextLength == 0 || tbCMND.TextLength == 0)
            {
                MessageBox.Show("Nhập thiếu thông tin khách thuê. Thêm thất bại");
            }    
            else
                if (soNguoi >= 0)
                {
                    if (busKH.KiemTraIdKH(tbSdt.Text))
                    {
                        string s = string.Format("Không thể thêm khách hàng vì id {0} đã tồn tại", tbSdt.Text);
                        MessageBox.Show(s);
                    }
                    else
                    {
                        string hoTen = tbTen.Text;
                        string gioiTinh = cbGioiTinh.Text;
                        DateTime ngaySinh = dtpNgay.Value;
                        string sdt = tbSdt.Text;
                        string cmnd = tbCMND.Text;
                        string queQua = tbQueQuan.Text;
                        busKH.ThemKh(sdt, hoTen, gioiTinh, ngaySinh, sdt, cmnd, queQua, maPhong);
                        int tong = soNguoi + 1;
                        busPhong.UpdateSoNguoi(maPhong, tong);

                    }
                }
                else
                    MessageBox.Show("Phòng đã đủ người không thể thêm");
            frmLoad();
            loadText();
        }

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvKH.Rows.Count - 1)
            {
                tbMa.Text = dgvKH.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbTen.Text = dgvKH.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbGioiTinh.Text = dgvKH.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpNgay.Text = dgvKH.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbSdt.Text = dgvKH.Rows[e.RowIndex].Cells[4].Value.ToString();
                tbCMND.Text = dgvKH.Rows[e.RowIndex].Cells[5].Value.ToString();
                tbQueQuan.Text = dgvKH.Rows[e.RowIndex].Cells[6].Value.ToString();
                cbMaPhong.Text = dgvKH.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
        }

        private void tbTim_TextChanged(object sender, EventArgs e)
        {
            try
            {
                busKH.LayDSKhachHang(dgvKH, tbTim.Text);
                dgvKH.Columns[1].Width = (int)(0.4 * dgvKH.Width);
            }
            catch (Exception)
            {
                throw new Exception("Không lấy được danh sách khách hàng");
            }
        }

        private void btCSua_Click(object sender, EventArgs e)
        {
            if (tbMa.TextLength != 0)
            {
                string id = tbMa.Text;
                string hoTen = tbTen.Text;
                string gioiTinh = cbGioiTinh.Text;
                DateTime ngaySinh = dtpNgay.Value;
                string sdt = tbSdt.Text;
                string cmnd = tbCMND.Text;
                string queQua = tbQueQuan.Text;
                busKH.SuaKh(id, hoTen, gioiTinh, ngaySinh, sdt, cmnd, queQua);
                frmLoad();
                loadText();
            }
            else
                MessageBox.Show("Mã khách thuê rỗng. Sửa thất bại");
        }

        private void tbSdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbTen_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbTen.Text))
            {
                e.Cancel = true;
                tbTen.Focus();
                errorProvider1.SetError(tbTen, "Vui lòng không để tróng họ tên");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbTen, null);
            }
        }

        private void tbCMND_Validating(object sender, CancelEventArgs e)
        {
            if (tbCMND.TextLength != 12)
            {
                e.Cancel = true;
                tbCMND.Focus();
                errorProvider1.SetError(tbCMND, "Vui lòng nhập đúng số CMND");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbCMND, null);
            }
        }

        private void tbQueQuan_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbQueQuan.Text))
            {
                e.Cancel = true;
                tbQueQuan.Focus();
                errorProvider1.SetError(tbQueQuan, "Vui lòng không để tróng họ tên");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbQueQuan, null);
            }
        }

        private void dtpNgay_Validating(object sender, CancelEventArgs e)
        {
            DateTime dt = DateTime.Now;
            if ((dt.Year - dtpNgay.Value.Year) < 18)
            {
                e.Cancel = true;
                dtpNgay.Focus();
                errorProvider1.SetError(dtpNgay, "Vui lòng không để tróng họ tên");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(dtpNgay, null);
            }
        }

        private void tbSdt_Validating(object sender, CancelEventArgs e)
        {
            if (tbSdt.TextLength != 10)
            {
                e.Cancel = true;
                tbSdt.Focus();
                errorProvider1.SetError(tbSdt, "Vui lòng nhập đúng số CMND");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbSdt, null);
            }
        }
    }
}
