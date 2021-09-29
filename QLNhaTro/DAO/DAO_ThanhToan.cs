using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_ThanhToan
    {
        dbNhaTroDataContext db;
        public DAO_ThanhToan()
        {
            db = new dbNhaTroDataContext();
        }

        public List<Phong> LayDSPhongChuaLapHoaDon()
        {
            DateTime thangNam = DateTime.Now;
            var phong = db.LayDSPhongChuaLapHoaDon(thangNam.Year.ToString(), thangNam.Month.ToString());
            List<Phong> ds = new List<Phong>();
            foreach(var p in phong)
            {
                Phong ph = new Phong();
                ph.ID = p.ID;
                ph.TenPhong = p.TenPhong;
                ph.IDLoaiPhong = p.IDLoaiPhong;
                ph.SoNguoiToiDa = p.SoNguoiToiDa;
                ph.SoNguoiHienTai = p.SoNguoiHienTai;
                ds.Add(ph);
            }
            return ds;
        }
    }
}
