using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace BUS
{
    public class BUS_ThanhToan
    {
        DAO_ThanhToan da;
        public BUS_ThanhToan()
        {
            da = new DAO_ThanhToan();
        }

        public void LayDSPhongChuaLapHoadon(ListView lv)
        {
            foreach (Phong p in da.LayDSPhongChuaLapHoaDon())
            {
                lv.Items.Add(new ListViewItem { ImageIndex = 0, Text = p.TenPhong });
            }    
        }
    }
}
