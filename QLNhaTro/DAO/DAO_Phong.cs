using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_Phong
    {
        dbNhaTroDataContext db;
        public DAO_Phong()
        {
            db = new dbNhaTroDataContext();
        }

        public dynamic LayDSPhong()
        {
            try
            {
                dynamic ds = db.XemDSPhong();
                return ds;
            }
            catch (Exception)
            {

                throw new Exception("Không lấy được stored procedure");
            }
        }

        public bool ThemPhong(Phong p)
        {
            try
            {
                var phong = db.ThemPhong(p.TenPhong, p.IDLoaiPhong, p.SoNguoiToiDa, p.SoNguoiHienTai);
                return true;
            }
            catch (Exception)
            {
                throw new Exception("Không lấy được stored procedure");
            }
        }

        public bool SuaPhong(Phong p)
        {
            try
            {
                var phong = db.SuaPhong(p.ID, p.TenPhong, p.IDLoaiPhong, p.SoNguoiToiDa, p.SoNguoiHienTai);
                return true;
            }
            catch (Exception)
            {
                throw new Exception("Không lấy được stored procedure");
            }
        }

        public bool XoaPhong(int id)
        {
            try
            {
                var phong = db.XoaPhong(id);
                return true;
            }
            catch (Exception)
            {
                throw new Exception("Không lấy được stored procedure");
            }
        }

        public List<Phong> LayPhongTrongTheoLoai(int idLoai)
        {
            try
            {
                var phong = db.LayPhongTrongTheoLoai(idLoai);
                List<Phong> ds = new List<Phong>();
                foreach (var p in phong)
                {
                    Phong ph = new Phong();
                    ph.ID = p.ID;
                    ph.TenPhong = p.TenPhong;
                    ph.IDLoaiPhong = p.IDLoaiPhong;
                    ph.SoNguoiToiDa = p.SoNguoiToiDa;
                    ph.SoNguoiHienTai = p.SoNguoiHienTai;
                    ds.Add(ph);
                }
                return ds;
            }
            catch (Exception)
            {

                throw new Exception("Không lấy được stored procedure");
            }
        }

        //public bool KiemTraPhong(int id)
        //{
        //    try
        //    {
        //        bool? kq = false;
        //        var kt = db.KTPhongTonTai(id, ref kq);
        //        return (bool)kq;
        //    }
        //    catch (Exception)
        //    {

        //        throw new Exception("Không lấy được stored procedure");
        //    }
        //}

        public int LaySoNguoiTrongPhong(int id)
        {
            try
            {
                int? toiDa = 0, hienTai = 0;
                var soNguoi = db.LaySoNguoiHTVaTD(id, ref toiDa, ref hienTai);
                int soNguoiToiDa = (int)toiDa;
                int soNguoiHienTai = (int)hienTai;
                if ((soNguoiToiDa - soNguoiHienTai) > 0)
                    return soNguoiHienTai;
                else
                    return -1;
            }
            catch
            {
                throw new Exception("Không lấy được stored procedure");
            }
        }

        public bool UpdateSoNguoiHienTai(int id, int hienTai)
        {
            try
            {
                var phong = db.SuaSoNguoiHienTai(id, hienTai);
                return true;
            }
            catch (Exception)
            {
                throw new Exception("Không lấy được stored procedure");
            }
        }

        // Lấy phòng theo tên
        public List<Phong> LayPhongTheoTen(string ten)
        {
            try
            {
                
                var ph = db.LayPhongTheoTen(ten);
                List<Phong> ds = new List<Phong>();
                foreach (var p in ph)
                {
                    Phong phong = new Phong();
                    phong.ID = p.ID;
                    phong.TenPhong = p.TenPhong;
                    phong.IDLoaiPhong = p.IDLoaiPhong;
                    phong.SoNguoiToiDa = p.SoNguoiToiDa;
                    phong.SoNguoiHienTai = p.SoNguoiHienTai;
                    ds.Add(phong);
                }    
                return ds;
            }
            catch (Exception)
            {

                throw new Exception("Không lấy được stored procedure");
            }
        }

        // Lấy số người số người trong phòng
        public int LaySNTrongPhong(int id)
        {
            try
            {
                int? toiDa = 0, hienTai = 0;
                var soNguoi = db.LaySoNguoiHTVaTD(id, ref toiDa, ref hienTai);
                return (int)hienTai;
            }
            catch
            {
                throw new Exception("Không lấy được stored procedure");
            }
        }

        //Lấy danh sách phòng trống
        public dynamic LayDSPhongTrong()
        {
            try
            {
                dynamic ds = db.LayDSPhongTrong();
                return ds;
            }
            catch (Exception)
            {

                throw new Exception("Không lấy được stored procedure");
            }
        }

        //lấy danh sách phòng đã cho thuê
        public dynamic LayDSPhongDaChoThue()
        {
            try
            {
                dynamic ds = db.LayDSPhongDaChoThue();
                return ds;
            }
            catch (Exception)
            {

                throw new Exception("Không lấy được stored procedure");
            }
        }

        //Kiểm tra tên phòng tồn tại
        public bool KiemTraTenPhong(string ten)
        {
            try
            {
                bool? kq = false;
                var kt = db.KTTenPhongTonTai(ten, ref kq);
                return (bool)kq;
            }
            catch (Exception)
            {

                throw new Exception("Không lấy được stored procedure");
            }
        }
    }
}
