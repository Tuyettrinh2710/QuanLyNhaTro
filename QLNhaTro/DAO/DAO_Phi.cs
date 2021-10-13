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

        public List<Phi> LayGia(int id)
        {
            try
            {
                List<Phi> gia = db.Phis.Where(s => s.ID == id).ToList();
                return gia;
            }
            catch (Exception)
            {

                throw new Exception("Không lấy được dữ liệu");
            }
        }
    }
}
