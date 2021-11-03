using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace BUS
{
    public class BUS_ThuePhong
    {
        DAO_ThuePhong da;
        DAO_LoaiPhong daLoai;
        DAO_Phong daPhong;
        public BUS_ThuePhong()
        {
            da = new DAO_ThuePhong();
            daLoai = new DAO_LoaiPhong();
            daPhong = new DAO_Phong();
        }

        public string LayMa()
        {
            string ma = da.LayMa("TP");
            return ma;
        }

        public void LayPhongTheoTen(string ten, TextBox tbMa, TextBox tbGia)
        {
            List<Phong> ph = daPhong.LayPhongTheoTen(ten);
            foreach (Phong p in ph)
            {
                tbMa.Text = p.ID.ToString();
                List<LoaiPhong> l = daLoai.LayGia(p.IDLoaiPhong);
                foreach (LoaiPhong lp in l)
                    tbGia.Text = lp.GiaTien.ToString();
            }
        }

        public bool ThemThuePhong(string id, string idKH, int idPhong, DateTime dt, Decimal tien)
        {
            ThuePhong t = new ThuePhong();
            t.ID = id;
            t.ID_KH = idKH;
            t.ID_Phong = idPhong;
            t.NgayThue = dt;
            t.TienCoc = tien;
            if (da.ThemThuePhong(t))
                return true;
            return false;
        }

        public void CapNhatMa(string ma)
        {
            string id = ma.Substring(0,2);
            string giaTri = ma.Substring(2);
            da.CapNhatGTThamSo(id, giaTri);
        }

        public void LayThongTinThue(string idKH, int idPhong,TextBox tbMaThue, TextBox tbTienCoc, DateTimePicker dtp)
        {
            List<ThuePhong> ds = da.LayThongTinThuePhong(idKH, idPhong);
            foreach(ThuePhong t in ds)
            {
                tbMaThue.Text = t.ID;
                tbTienCoc.Text = t.TienCoc.ToString();
                dtp.Value = t.NgayThue.Value;
            }    
        }

        //kiểm tra id thuê
        public bool KiemTraIDThue(string id)
        {
            if (da.KiemTraIDThue(id))
                return true;
            return false;
        }

        //lấy danh sách thuê phòng theo tháng năm
        public void LayDSThuePhong(DataGridView dgv, int thang, int nam)
        {
            dgv.DataSource = da.LayDSThuePhong(thang, nam);
        }

        //kiểm tra id thuê phòng có tồn tại
        public bool KiemTraIDThuePhong(string idThue, string idKH)
        {
            if (da.KiemTraIDThuePhong(idThue, idKH))
                return true;
            return false;
        }
    }
}
