using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_Phi
    {
        dbNhaTroDataContext db;

        public DAO_Phi()
        {
            db = new dbNhaTroDataContext();
        }
        public List<Phi> LayDSPhi()
        {
            var phi = db.XemCacLoaiPhi();
            List<Phi> ds = new List<Phi>();
            foreach (var p in phi)
            {
                Phi ph = new Phi();
                ph.ID = p.ID;
                ph.TenPhi = p.TenPhi;
                ph.GiaTien = p.GiaTien;
                ds.Add(ph);
            }    
            return ds;
        }

        public void Them(Phi p)
        {
            try
            {
                var phi = db.ThemPhi(p.TenPhi, p.GiaTien);
            }
            catch (Exception)
            {

                throw new Exception("Không lấy được stored procedure");
            }
        }

        public void Xoa(int id)
        {
            try
            {
                var phi = db.XoaPhi(id);
            }
            catch (Exception)
            {

                throw new Exception("Không lấy được stored procedure");
            }
        }

        public bool Sua(Phi p)
        {
            try
            {
                var phi = db.SuaPhi(p.ID, p.TenPhi, p.GiaTien);
                return true;
            }
            catch (Exception)
            {
                throw new Exception("Không thể lấy stored procedure");
            }
        }

        public dynamic LayGia(int id)
        {
            try
            {
                dynamic gia = db.Phis.Where(s => s.ID == id);
                return gia;
            }
            catch (Exception)
            {

                throw new Exception("Không lấy được dữ liệu");
            }
        }
    }
}
