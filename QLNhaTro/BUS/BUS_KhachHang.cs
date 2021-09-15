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

        public void ThemKh(string id, string hoTen, string gioiTinh, DateTime ngaySinh, string sdt, string cmnd, string queQuan, int maPhong)
        {
            KhachHang k = new KhachHang();
            k.ID = id;
            k.HoTen = hoTen;
            k.GioiTinh = gioiTinh;
            k.NgaySinh = ngaySinh;
            k.Sdt = sdt;
            k.CMND = cmnd;
            k.QueQuan = queQuan;
            k.MaPhong = maPhong;
            if (da.ThemKH(k) == true)
            {
                string s = string.Format("Thêm khách hàng có tên {0} thành công", hoTen);
                MessageBox.Show(s);
            }   
            else
            {
                string s = string.Format("Thêm khách hàng có tên {0} thất bại", hoTen);
                MessageBox.Show(s);
            }
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
    }
}
