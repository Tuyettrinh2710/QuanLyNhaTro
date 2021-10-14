using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace BUS
{
    public class BUS_KhachHang
    {
        DAO_KhachHang da;
        public BUS_KhachHang()
        {
            da = new DAO_KhachHang();
        }

        public void LayDSKhachHang(DataGridView dgv, string ten)
        {
            dgv.DataSource = da.LayDSKhachHang(ten);
        }

        public bool ThemKh(string id, string hoTen, string gioiTinh, DateTime ngaySinh, string sdt, string cmnd, string queQuan)
        {
            KhachHang k = new KhachHang();
            k.ID = id;
            k.HoTen = hoTen;
            k.GioiTinh = gioiTinh;
            k.NgaySinh = ngaySinh;
            k.Sdt = sdt;
            k.CMND = cmnd;
            k.QueQuan = queQuan;
            if (da.ThemKH(k))
                return true;
            return false;
        }

        // kiểm tra id khách hàng có tồn tại
        public bool KiemTraIdKH(string id)
        {
            if (da.KiemTraIdKH(id))
                return true;
            return false;
        }

        public void SuaKh(string id, string hoTen, string gioiTinh, DateTime ngaySinh, string sdt, string cmnd, string queQuan)
        {
            KhachHang k = new KhachHang();
            k.ID = id;
            k.HoTen = hoTen;
            k.GioiTinh = gioiTinh;
            k.NgaySinh = ngaySinh;
            k.Sdt = sdt;
            k.CMND = cmnd;
            k.QueQuan = queQuan;
            if (da.SuaKH(k) == true)
            {
                string s = string.Format("Sửa khách hàng có id {0} thành công", id);
                MessageBox.Show(s);
            }
            else
            {
                string s = string.Format("Sửa khách hàng có id {0} thất bại", id);
                MessageBox.Show(s);
            }
        }

        //lấy mã phòng từ id khách thuê
        public int? LayMaPhongBangIDKH(string id)
        {
            int? maPhong = 0;
            List<KhachHang> ds = da.LayThongTinKH(id);
            foreach (KhachHang k in ds)
            {
                maPhong = (int?)k.MaPhong;
            }
            return maPhong;
        }

        //Cập nhập mã phòng cho khách hàng
        public void CapNhatMaPhong(string id, int maPhong)
        {
            if (da.CapNhatMaPhong(id, maPhong) == true)
            {
                string s = string.Format("Cập nhật mã phòng {0} cho khách hàng có id {1} thành công", maPhong, id);
                MessageBox.Show(s);
            }
            else
            {
                string s = string.Format("Cập nhật mã phòng {0} cho khách hàng có id {1} thất bại", maPhong, id);
                MessageBox.Show(s);
            }
        }

        //Lấy danh sách khách hàng theo mã phòng
        public void LayKhachHangTheoPhong(ComboBox cb, int idPhong)
        {
            cb.DataSource = da.LayDSKhachTheoIDPhong(idPhong);
            cb.DisplayMember = "ID";
            cb.ValueMember = "ID";
        }

        //Lấy thông tin khách hàng hiện lên textbox
        public void LayThongTinKH(string id, TextBox tbTen, TextBox tbCmnd, TextBox gt, DateTimePicker ngay, TextBox que)
        {
            List<KhachHang> ds = da.LayThongTinKH(id);
            foreach (KhachHang k in ds)
            {
                tbTen.Text = k.HoTen;
                tbCmnd.Text = k.CMND;
                gt.Text = k.GioiTinh;
                ngay.Value = (DateTime)k.NgaySinh;
                que.Text = k.QueQuan;
            }
        }

        //Cập nhật mã phòng null cho khách hàng
        public void CapNhatMaPhongNULL(string id)
        {
            if (da.CapNhatMaPhongNULL(id) == true)
            {
                string s = string.Format("Khách hàng có id {0} đã được cập nhật mã phòng có giá trị null thành công", id);
                MessageBox.Show(s);
            }
            else
            {
                string s = string.Format("Khách hàng có id {0} đã được cập nhật mã phòng có giá trị null thất bại", id);
                MessageBox.Show(s);
            }
        }

        // lấy ds khách trong phòng hiện lên DatagridView
        public void LayDSKHTrongPhong(DataGridView dgv, int idPhong)
        {
            dgv.DataSource = da.LayDSKhachTheoIDPhong(idPhong);
        }
    }
}
