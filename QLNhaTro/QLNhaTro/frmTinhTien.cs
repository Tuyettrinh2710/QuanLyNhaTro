using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace QLNhaTro
{
    public partial class frmTinhTien : Form
    {
        BUS_ThanhToan busThanhToan;
        BUS_ThuePhong busThue;
        BUS_KhachHang busKhach;
        BUS_Phi busPhi;
        CultureInfo culture;
        public frmTinhTien()
        {
            InitializeComponent();
            busThanhToan = new BUS_ThanhToan();
            busThue = new BUS_ThuePhong();
            busKhach = new BUS_KhachHang();
            busPhi = new BUS_Phi();
            culture = new System.Globalization.CultureInfo("vi-VN");
        }

        private bool KiemTraThongTin()
        {
            int countErr = 0;
            if (cbSDT.SelectedIndex == -1)
            {
                errorProvider1.SetError(cbSDT, "Không có id khách thuê");
                countErr++;
            }
            if (tbMaPhong.Text == "")
            {
                errorProvider1.SetError(tbMaPhong, "Không để mã phòng trống");
                countErr++;
            }
            if (tbTienPhong.Text == "")
            {
                errorProvider1.SetError(tbTienPhong, "Không để trống tiền phòng");
                countErr++;
            }
            if (tbSKDien.Text == "")
            {
                errorProvider1.SetError(tbSKDien, "Không để trống kí điện");
                countErr++;
            }
            if (tbSKNuoc.Text == "")
            {
                errorProvider1.SetError(tbSKNuoc, "Không để trống kí nước");
                countErr++;
            }
            if (tbTienDien.Text == "")
            {
                errorProvider1.SetError(tbTienDien, "Không để trống tiền điện");
                countErr++;
            }
            if (tbTienNuoc.Text == "")
            {
                errorProvider1.SetError(tbTienNuoc, "Không để trống tiền nước");
                countErr++;
            }
            if (tbDichVu.Text == "")
            {
                errorProvider1.SetError(tbDichVu, "Không để trống tiền dịch vụ");
                countErr++;
            }
            if (tbTongTien.Text == "")
            {
                errorProvider1.SetError(tbTongTien, "Không để trống tổng tiền");
                countErr++;
            }

            if (countErr > 0)
                return true;
            return false;
        }

        void loadText()
        {
            cbSDT.SelectedIndex = -1;
            tbMaPhong.Text = "";
            tbDiaChi.Text = "";
            tbCMND.Text = "";
            tbDichVu.Text = busPhi.LayGia(3).ToString();
            cbGioiTinh.SelectedIndex = -1;
            tbSKDien.Text = "";
            tbSKNuoc.Text = "";
            tbTen.Text = "";
            tbTienDien.Text = "0";
            tbTienNuoc.Text = "0";
            tbTienPhong.Text = "0";
            tbTongTien.Text = "0";
            dtpNgaySinh.Value = DateTime.Now;
            busThanhToan.LayDSPhongChuaLapHoadon(lvPhong);
            errorProvider1.Clear();
        }

        private void frmTinhTien_Load(object sender, EventArgs e)
        {
            busThanhToan.LayDSPhongChuaLapHoadon(lvPhong);
            tbDichVu.Text = string.Format( culture, "{0:#,##0}", busPhi.LayGia(3));
        }

        private void lvPhong_Click(object sender, EventArgs e)
        {
            string ten = lvPhong.SelectedItems[0].Text;
            busThue.LayPhongTheoTen(ten, tbMaPhong, tbTienPhong);
        }

        private void tbMaPhong_TextChanged(object sender, EventArgs e)
        {
            if (tbMaPhong.Text == "")
                tbMaPhong.Text = "";
            else
                busKhach.LayKhachHangTheoPhong(cbSDT, int.Parse(tbMaPhong.Text));
        }

        private void cbSDT_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbSDT.SelectedIndex == -1)
                cbSDT.SelectedIndex = -1;
            else
                busKhach.LayThongTinKH(cbSDT.SelectedValue.ToString(), tbTen, tbCMND, cbGioiTinh, dtpNgaySinh, tbDiaChi);
        }

        private void tongTienPhong()
        {
            if (tbTienDien.Text == "" && tbTienPhong.Text == "" && tbTienNuoc.Text == "")
            {
                tbTongTien.Text = busPhi.LayGia(3).ToString();
            }
            else if(tbTienDien.Text == "" && tbTienPhong.Text == "" )
            {
                decimal tienNuoc = decimal.Parse(tbTienNuoc.Text) + busPhi.LayGia(3); 
                tbTongTien.Text = tienNuoc.ToString();
            }
            else if (tbTienDien.Text == "" && tbTienNuoc.Text == "")
            {
                decimal tienPhong = decimal.Parse(tbTienPhong.Text) + busPhi.LayGia(3);
                tbTongTien.Text = tienPhong.ToString();
            }
            else if (tbTienPhong.Text == "" && tbTienNuoc.Text == "")
            {
                decimal tienDien = decimal.Parse(tbTienDien.Text) + busPhi.LayGia(3);
                tbTongTien.Text = tienDien.ToString();
            }
            else
            {
                decimal tienDV = busPhi.LayGia(3);
                decimal tienDien = decimal.Parse(tbTienDien.Text);
                decimal tienNuoc = decimal.Parse(tbTienNuoc.Text);
                decimal tienPhong = decimal.Parse(tbTienPhong.Text);
                decimal tongTien = tienDien + tienDV + tienNuoc + tienPhong;
                tbTongTien.Text = tongTien.ToString();
            }    
            
        }

        private void tbTienPhong_TextChanged(object sender, EventArgs e)
        {
            if (tbTienPhong.Text == "")
            {
                decimal tienDV = busPhi.LayGia(3);
                decimal tienDien = decimal.Parse(tbTienDien.Text);
                decimal tienNuoc = decimal.Parse(tbTienNuoc.Text);
                decimal tongTien = tienDien + tienDV + tienNuoc;
                tbTongTien.Text = tongTien.ToString();
            }    
            else
            {
                tongTienPhong();
            }    
        }

        private void tbSKDien_TextChanged(object sender, EventArgs e)
        {
            if (tbSKDien.Text == "")
            {
                tbTienDien.Text = "0";
            }
            else
            {
                int soKi = int.Parse(tbSKDien.Text);
                decimal tienDien = soKi * busPhi.LayGia(16);
                tbTienDien.Text = tienDien.ToString();
            }    
        }

        private void tbSKDien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbTienDien_TextChanged(object sender, EventArgs e)
        {
            if (tbTienDien.Text == "")
            {
                decimal tienDV = busPhi.LayGia(3);
                decimal tienPhong = decimal.Parse(tbTienPhong.Text);
                decimal tienNuoc = decimal.Parse(tbTienNuoc.Text);
                decimal tongTien = tienPhong + tienDV + tienNuoc;
                tbTongTien.Text = tongTien.ToString();
            }
            else
            {
                tongTienPhong();
            }
        }

        private void tbSKNuoc_TextChanged(object sender, EventArgs e)
        {
            if (tbSKNuoc.Text == "")
            {
                tbTienNuoc.Text = "0";
            }
            else
            {
                int soKi = int.Parse(tbSKNuoc.Text);
                decimal tienNuoc = soKi * busPhi.LayGia(2);
                tbTienNuoc.Text = tienNuoc.ToString();
            }
        }

        private void tbSKNuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbTienNuoc_TextChanged(object sender, EventArgs e)
        {
            if (tbTienNuoc.Text == "")
            {
                decimal tienDV = busPhi.LayGia(3);
                decimal tienPhong = decimal.Parse(tbTienPhong.Text);
                decimal tienDien = decimal.Parse(tbTienDien.Text);
                decimal tongTien = tienPhong + tienDV + tienDien;
                tbTongTien.Text = tongTien.ToString();
            }
            else
            {
                tongTienPhong();
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTin())
            {
                MessageBox.Show("Nhập thiếu thông tin không thể lưu hóa đơn");
            }    
            else
            {
                string idKH = cbSDT.SelectedValue.ToString();
                int maPhong = int.Parse(tbMaPhong.Text);
                decimal tienDV = busPhi.LayGia(3);
                int skDien = int.Parse(tbSKDien.Text);
                int skNuoc = int.Parse(tbSKNuoc.Text);
                decimal tienDien = decimal.Parse(tbTienDien.Text);
                decimal tienNuoc = decimal.Parse(tbTienNuoc.Text);
                decimal tienPhong = decimal.Parse(tbTienPhong.Text);
                decimal tongTien = decimal.Parse(tbTongTien.Text);

                busThanhToan.ThemHoaDon(idKH, maPhong, dtpNgayLap.Value, tienPhong, skDien, tienDien, skNuoc, tienNuoc, tienDV, tongTien);
                loadText();
            }    
        }
    }
}
