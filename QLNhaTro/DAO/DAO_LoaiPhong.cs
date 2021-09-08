using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_LoaiPhong
    {
        dbNhaTroDataContext db;
        public DAO_LoaiPhong()
        {
            db = new dbNhaTroDataContext();
        }

        public dynamic LayDSLoaiPhong()
        {
            dynamic ds = db.LayDSLoaiPhong();
            return ds;
        }

        public bool ThemLoaiPhong(LoaiPhong lp)
        {
            try
            {
                var loaiPhong = db.ThemLP(lp.TenLP, lp.DienTich);
                return true;
            }
            catch (Exception)
            { 
                throw new Exception("Không lấy được stored procedure");
            }
        }

        public bool SuaLoaiPhong(LoaiPhong lp)
        {
            try
            {
                var loaiPhong = db.SuaLP(lp.ID, lp.TenLP, lp.DienTich);
                return true;
            }
            catch (Exception)
            {
                throw new Exception("Không lấy được stored procedure");
            }
        }

        public bool XoaLoaiPhong(int id)
        {
            try
            {
                var loaiPhong = db.XoaLP(id);
                return true;
            }
            catch (Exception)
            {
                throw new Exception("Không lấy được stored procedure");
            }
        }
    }
}
