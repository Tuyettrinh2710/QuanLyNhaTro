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
            lv.Items.Clear();
            foreach (Phong p in da.LayDSPhongChuaLapHoaDon())
            {
                lv.Items.Add(new ListViewItem { ImageIndex = 0, Text = p.TenPhong });
            }    
        }

        public void ThemHoaDon(string idKH, int idPhong, DateTime ngayLay, decimal tienPhong, int skDien, decimal tiendien, int sKNuoc, decimal tienNuoc, decimal tiendv, decimal tong)
        {
            HoaDon h = new HoaDon();
            h.ID_KH = idKH;
            h.ID_Phong = idPhong;
            h.NgayLap = ngayLay;
            h.GiaPhong = tienPhong;
            h.SkDien = skDien;
            h.TienDien = tiendien;
            h.SkNuoc = sKNuoc;
            h.TienNuoc = tienNuoc;
            h.TienDV = tiendv;
            h.TongTien = tong;
            if (da.ThemHoaDon(h))
            {
                string s = string.Format("Lập hóa đơn cho phòng có id {0} thành công", idPhong);
                MessageBox.Show(s);
            }    
            else
            {
                string s = string.Format("Lập hóa đơn cho phòng có id {0} thất bại", idPhong);
                MessageBox.Show(s);
            }    
        }

        public void LayHoaDonChuaThu(DataGridView dgv)
        {
            dgv.DataSource = da.LayDSHDChuaThu();
        }
    }
}
