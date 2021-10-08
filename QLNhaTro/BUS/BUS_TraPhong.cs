using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class BUS_TraPhong
    {
        DAO_Phong daPhong;
        DAO_TraPhong da;
        public BUS_TraPhong()
        {
            daPhong = new DAO_Phong();
            da = new DAO_TraPhong();
        }

        public int LayMaPhongTheoTen(string tenPhong)
        {
            int ma = 0;
            List<Phong> ds = daPhong.LayPhongTheoTen(tenPhong);
            foreach(Phong p in ds)
            {
                ma = p.ID;
            }
            return ma;
        }

        public bool ThemTraPhong(string idThue, string idkH, int idPhong, DateTime ngayThue, DateTime ngayTra)
        {
            TraPhong t = new TraPhong();
            t.ID_Thue = idThue;
            t.ID_KH = idkH;
            t.ID_Phong = idPhong;
            t.NgayThue = ngayThue;
            t.NgayTra = ngayTra;
            if (da.ThemTraPhong(t))
                return true;
            return false;
        }
    }
}
