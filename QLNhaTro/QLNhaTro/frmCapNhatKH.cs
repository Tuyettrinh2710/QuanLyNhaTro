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
            busKH.LayDSKhachHang(dgvKH);
            dgvKH.Columns[1].Width = (int)(0.2 * dgvKH.Width);
            dgvKH.Columns[5].Width = (int)(0.12 * dgvKH.Width);
        }

        void loadText()
        {
            tbMa.Text = "";
            tbTen.Text = "";
            tbQueQuan.Text = "";
            tbSdt.Text =  "";
            dtpNgay.Value = DateTime.Today;
            cbGioiTinh.SelectedIndex = -1;

        }    

        private void btThem_Click(object sender, EventArgs e)
        {
            int maPhong = int.Parse(cbMaPhong.SelectedValue.ToString());
            int soNguoi = busPhong.LaySoNguoiConTrong(maPhong);
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
                    string gioiTinh = cbGioiTinh.SelectedText;
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
        }
    }
}
