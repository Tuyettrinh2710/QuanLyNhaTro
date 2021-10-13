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
    public partial class frmThuePhong : Form
    {

        BUS_LoaiPhong busLoaiPhong;
        BUS_Phong busPhong;
        BUS_ThuePhong busThue;
        BUS_KhachHang busKH;
        public frmThuePhong()
        {
            InitializeComponent();
            busThue = new BUS_ThuePhong();
            busPhong = new BUS_Phong();
            busLoaiPhong = new BUS_LoaiPhong();
            busKH = new BUS_KhachHang();
        }

        private void frmThuePhong_Load(object sender, EventArgs e)
        {
            busLoaiPhong.DSLoai(cbLoai);
            tbTienCoc.Text = "0";
            string id = busThue.LayMa();
            if (busThue.KiemTraIDThue(id))
            {
                busThue.CapNhatMa(id);
                tbMaThue.Text = busThue.LayMa();
            }
            else
                tbMaThue.Text = busThue.LayMa();
        }

        void loadKH()
        {
            tbTen.Text = "";
            tbCMND.Text = "";
            tbSdt.Text = "";
            tbQueQuan.Text = "";
            cbGioiTinh.SelectedIndex = -1;
            dtpNgaySinh.Value = DateTime.Now;
        }

        void loadText()
        {
            loadKH();
            tbMaPhong.Text = "";
            tbPhong.Text = "";
            tbTienPhong.Text = "";
            tbTienCoc.Text = "0";
            tbMaThue.Text = busThue.LayMa();
        }

        void loadLV()
        {
            lvPhong.Items.Clear();
            string idLoai = cbLoai.SelectedValue.ToString();
            int id;
            bool kq = int.TryParse(idLoai, out id);
            busPhong.LayPhongTrong(lvPhong, id);
        }

        private void cbLoai_SelectedValueChanged(object sender, EventArgs e)
        {
            loadLV();
        }

        private void lvPhong_Click(object sender, EventArgs e)
        {
            string ten   = lvPhong.SelectedItems[0].Text;
            tbPhong.Text = ten;
            busThue.LayPhongTheoTen(ten, tbMaPhong, tbTienPhong);
        }

        private bool KiemTraControl()
        {
            DateTime dt = DateTime.Now;
            int demLoi = 0;
            if (tbMaPhong.Text == "" || tbTen.TextLength == 0 || tbSdt.TextLength == 0 || tbCMND.TextLength == 0
                || tbMaThue.Text == "" || tbTienCoc.Text == "")
                demLoi++;
            if ((dt.Year - dtpNgaySinh.Value.Year) < 18)
            {
                errorProvider1.SetError(dtpNgaySinh, "Khách thuê không đủ 18 tuổi");
                demLoi++;
            }
            if (cbGioiTinh.SelectedIndex == -1)
            {
                errorProvider1.SetError(cbGioiTinh, "Chưa chọn giới tính");
                demLoi++;
            }    
            if (demLoi > 0)
                return true; 
            return false;
        }

        private void ThuePhong(string hoTen)
        {
            DateTime dt = DateTime.Now;
            string id = tbMaThue.Text;
            string idKH = tbSdt.Text;
            DateTime ngayThue = dtpNgayThue.Value;
            Decimal tienCoc = Decimal.Parse(tbTienCoc.Text);
            int maPhong = int.Parse(tbMaPhong.Text);
            int soNguoi = busPhong.LaySoNguoiConTrong(maPhong);
            if (busThue.ThemThuePhong(id, idKH, maPhong, ngayThue, tienCoc))
            {
                string s = string.Format("Khách hàng {0} thuê phòng {1} thành công", hoTen, maPhong);
                MessageBox.Show(s);
                int tong = soNguoi + 1;
                busKH.CapNhatMaPhong(idKH, maPhong);
                busPhong.UpdateSoNguoi(maPhong, tong);
            }
            else
            {
                string s = string.Format("Khách hàng {0} thuê phòng {1} thất bại", hoTen, maPhong);
                MessageBox.Show(s);
            }
        }

        private void ThemNguoiThuePhong()
        {
            
            if (busKH.KiemTraIdKH(tbSdt.Text))
            {
                //string s = string.Format("Không thể thêm khách hàng vì id {0} đã tồn tại", tbSdt.Text);
                //MessageBox.Show(s);
                int? maPhongKH = busKH.LayMaPhongBangIDKH(tbSdt.Text);
                if (maPhongKH == null)
                    ThuePhong(tbTen.Text);
                else
                {
                    string s = string.Format("Khách thuê {0} chưa trả phòng đang thuê. Không thể thuê phòng", tbTen.Text);
                    MessageBox.Show(s);
                }
            }
            else
            {
                string hoTen = tbTen.Text;
                string gioiTinh = cbGioiTinh.Text;
                DateTime ngaySinh = dtpNgaySinh.Value.Date;
                string sdt = tbSdt.Text;
                string cmnd = tbCMND.Text;
                string queQuan = tbQueQuan.Text;
                if (busKH.ThemKh(sdt, hoTen, gioiTinh, ngaySinh, sdt, cmnd, queQuan))
                {
                    ThuePhong(hoTen);
                }
                else
                {
                    MessageBox.Show("Thuê phòng thất bại");
                }
            }
            loadLV();
        }

        private void btThemNguoi_Click(object sender, EventArgs e)
        {
            if (KiemTraControl())
            {
                MessageBox.Show("Nhập thiếu thông tin thuê phòng. Thuê phòng thất bại");
            }
            else
            {
                int maPhong = int.Parse(tbMaPhong.Text);
                int soNguoi = busPhong.LaySoNguoiConTrong(maPhong);
                if (soNguoi >= 0)
                {
                    ThemNguoiThuePhong();
                    loadKH();
                }
                else
                {
                    MessageBox.Show("Phòng đã đủ người không thể thêm");
                    busThue.CapNhatMa(tbMaThue.Text);
                    loadText();
                }
            }
        }

        private void tbCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbSdt_KeyPress(object sender, KeyPressEventArgs e)
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
                errorProvider1.SetError(tbTen, "Vui lòng không để trống họ tên");
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
                errorProvider1.SetError(tbQueQuan, "Vui lòng không để trống quê quán");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbQueQuan, null);
            }
        }

        private void tbSdt_Validating(object sender, CancelEventArgs e)
        {
            if (tbSdt.TextLength != 10)
            {
                e.Cancel = true;
                tbSdt.Focus();
                errorProvider1.SetError(tbSdt, "Vui lòng nhập đúng số số điện thoại");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbSdt, null);
            }
        }

        private void dtpNgaySinh_Validating(object sender, CancelEventArgs e)
        {
            DateTime dt = DateTime.Now;
            if ((dt.Year - dtpNgaySinh.Value.Year) < 18)
            {
                e.Cancel = true;
                dtpNgaySinh.Focus();
                errorProvider1.SetError(dtpNgaySinh, "Khách thuê không đủ tuổi");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(dtpNgaySinh, null);
            }
        }

        private void tbTienPhong_TextChanged(object sender, EventArgs e)
        {
            tbTienCoc.Text = tbTienPhong.Text;
        }

        private void btTaoMoi_Click(object sender, EventArgs e)
        {
            busThue.CapNhatMa(tbMaThue.Text);
            loadText();
        }
    }
}
