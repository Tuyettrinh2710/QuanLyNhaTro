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


        public bool ThemThuePhong(ThuePhong t)
        {
            try
            {
                db.ThemThuePhong(t.ID, t.ID_KH, t.ID_Phong, t.NgayThue, t.TienCoc);
                return true;
            }
            catch (Exception)
            {

                throw new Exception("Không lấy được stored procedure");
            }
        }

        public void CapNhatGTThamSo(string id, string giaTri)
        {
            try
            {
                db.CapNhatThamSo(id, giaTri);
            }
            catch (Exception)
            {

                throw new Exception("Không lấy được stored procedure");
            }
            
        }

        public List<ThuePhong> LayThongTinThuePhong(string maKH, int idPhong)
        {
            List<ThuePhong> ds = db.ThuePhongs.Where(s => s.ID_KH == maKH && s.ID_Phong == idPhong).ToList();
            return ds;
        }

        //Kiểm tra id có chưa
        public bool KiemTraIDThue(string id)
        {
            try
            {
                bool? kq = false;
                var ketQua = db.KiemTraIDThue(id, ref kq);
                return (bool)kq;
            }
            catch (Exception)
            {

                throw new Exception("Không lấy được stored procdure");
            }
        }

        //lấy dánh sách thuê phòng theo năm tháng
        public dynamic LayDSThuePhong(int thang, int nam)
        {
            try
            {
                dynamic ds = db.LayDSThuePhong(thang, nam);
                return ds;
            }
            catch (Exception)
            {

                throw new Exception("Không lấy được stored procdure");
            }
        }

        //Kiểm tra id thuê phòng có tồn tại
        public bool KiemTraIDThuePhong(string idThue, string idKH)
        {
            try
            {
                bool? kq = false;
                var kt = db.KTIDThue(idThue, idKH, ref kq);
                return (bool)kq;
            }
            catch (Exception)
            {

                throw new Exception("Không lấy được stored procdure");
            }
        }

        //Kiểm tra phòng có trong bảng thuê phòng
        public bool KiemTraIDPhongTrongThue(int id)
        {
            try
            {
                bool? kq = false;
                var kt = db.KTIDPhongTrongThue(id, ref kq);
                return (bool)kq;
            }
            catch (Exception)
            {

                throw new Exception("Không lấy được stored procdure");
            }
        }
    }
}
