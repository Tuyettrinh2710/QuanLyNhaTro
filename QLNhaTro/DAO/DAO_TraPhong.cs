using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_TraPhong
    {
        dbNhaTroDataContext db;
        public DAO_TraPhong()
        {
            db = new dbNhaTroDataContext();
        }

        public bool ThemTraPhong(TraPhong tr)
        {
            try
            {
                db.ThemTraPhong(tr.ID_Thue, tr.ID_KH, tr.ID_Phong, tr.NgayThue, tr.NgayTra);
                return true;
            }
            catch (Exception)
            {

                throw new Exception("Không lấy được stored prceodure");
            }
        }

        public dynamic LayDSTraPhong(int thang, int nam)
        {
            try
            {
                dynamic ds = db.LayDSTraPhong(thang, nam);
                return ds;
            }
            catch (Exception)
            {

                throw new Exception("Không lấy được stored prceodure");
            }
        }
    }
}
