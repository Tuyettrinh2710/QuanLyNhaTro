using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_ThuePhong
    {
        dbNhaTroDataContext db;
        public DAO_ThuePhong()
        {
            db = new dbNhaTroDataContext();
        }

        public string LayMa(string id)
        {
            string giaTri = null;
            var lay = db.LayMa(id, ref giaTri);
            int gia = int.Parse(giaTri);
            string ma = "";
            if (gia == 0)
            {
                ma = id + "00000001";
            }
            else
            {
                gia = gia + 1;
                if (gia < 10)
                    ma = string.Format("{0}0000000{1}", id, gia);
                else if (gia >= 10 && gia < 100)
                    ma = string.Format("{0}000000{1}", id, gia);
                else if (gia >= 100 && gia < 1000)
                    ma = string.Format("{0}00000{1}", id, gia);
                else if (gia >= 1000 && gia < 10000)
                    ma = string.Format("{0}0000{1}", id, gia);
                else if (gia >= 10000 && gia < 100000)
                    ma = string.Format("{0}000{1}", id, gia);
                else if (gia >= 100000 && gia < 1000000)
                    ma = string.Format("{0}00{1}", id, gia);
                else if (gia >= 1000000 && gia < 10000000)
                    ma = string.Format("{0}0{1}", id, gia);
                else
                    ma = id + gia;
            } 
            return ma;
        }
    }
}
