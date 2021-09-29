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
    public partial class frmTinhTien : Form
    {
        BUS_ThanhToan busThanhToan;
        BUS_ThuePhong busThue;
        BUS_KhachHang busKhach;
        public frmTinhTien()
        {
            InitializeComponent();
            busThanhToan = new BUS_ThanhToan();
            busThue = new BUS_ThuePhong();
            busKhach = new BUS_KhachHang();
        }

        private void frmTinhTien_Load(object sender, EventArgs e)
        {
            busThanhToan.LayDSPhongChuaLapHoadon(lvPhong);
        }

        private void lvPhong_Click(object sender, EventArgs e)
        {
            string ten = lvPhong.SelectedItems[0].Text;
            busThue.LayPhongTheoTen(ten, tbMaPhong, tbTienPhong);
        }

        private void tbMaPhong_TextChanged(object sender, EventArgs e)
        {
            busKhach.LayKhachHangTheoPhong(cbSDT, int.Parse(tbMaPhong.Text));
        }

        private void cbSDT_SelectedValueChanged(object sender, EventArgs e)
        {
            busKhach.LayThongTinKH(cbSDT.SelectedValue.ToString(), tbTen, tbCMND, tbGioiTinh, dtpNgaySinh, tbDiaChi);
        }
    }
}
