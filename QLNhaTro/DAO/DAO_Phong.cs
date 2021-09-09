using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_Phong
    {
        dbNhaTroDataContext db;
        public DAO_Phong()
        {
            db = new dbNhaTroDataContext();
        }

        public dynamic LayDSPhong()
        {
            try
            {
                dynamic ds = db.XemDSPhong();
                return ds;
            }
            catch (Exception)
            {

                throw new Exception("Không lấy được stored procedure");
            }
        }

        public bool ThemPhong(Phong p)
        {
            try
            {
                var phong = db.ThemPhong(p.TenPhong, p.IDLoaiPhong, p.SoNguoiToiDa, p.SoNguoiHienTai);
                return true;
            }
            catch (Exception)
            {
                throw new Exception("Không lấy được stored procedure");
            }
        }

        public bool SuaPhong(Phong p)
        {
            try
            {
                var phong = db.SuaPhong(p.ID, p.TenPhong, p.IDLoaiPhong, p.SoNguoiToiDa, p.SoNguoiHienTai);
                return true;
            }
            catch (Exception)
            {
                throw new Exception("Không lấy được stored procedure");
            }
        }

        public bool XoaPhong(int id)
        {
            try
            {
                var phong = db.XoaPhong(id);
                return true;
            }
            catch (Exception)
            {
                throw new Exception("Không lấy được stored procedure");
            }
        }

        public List<Phong> LayPhongTrongTheoLoai(int idLoai)
        {
            var phong = db.LayPhongTrongTheoLoai(idLoai);
            List<Phong> ds = new List<Phong>();
            foreach (var p in phong)
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
