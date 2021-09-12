using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_KhachHang
    {
        dbNhaTroDataContext db;
        public DAO_KhachHang()
        {
            db = new dbNhaTroDataContext();
        }

        public dynamic LayDSKhachHang()
        {
            try
            {
                dynamic ds = db.XemKH();
                return ds;
            }
            catch (Exception)
            {

                throw new Exception("Không lấy được stored procedure");
            }
        }

        public bool ThemKH(KhachHang k)
        {
            try
            {
                var khach = db.ThemKH(k.ID, k.HoTen, k.GioiTinh, k.NgaySinh, k.Sdt, k.CMND, k.QueQuan, k.MaPhong);
                return true;
            }
            catch (Exception)
            {
                throw new Exception("Không lấy được stored procedure");
            }
        }

        //Kiểm tra id có trong bảng khách hàng
        public bool KiemTraIdKH(string id)
        {
            try
            {
                bool? kt = false;
                var kq = db.KTIdKhachHangToiTai(id, ref kt);
                return (bool)kt;
            }
            catch (Exception)
            {
                throw new Exception("Không lấy được stored procedure");
            }
        }
    }
}
