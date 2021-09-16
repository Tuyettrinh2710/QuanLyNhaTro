using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class BUS_ThuePhong
    {
        DAO_ThuePhong da;
        public BUS_ThuePhong()
        {
            da = new DAO_ThuePhong();
        }

        public string LayMa()
        {
            string ma = da.LayMa("TP");
            return ma;
        }
    }
}
