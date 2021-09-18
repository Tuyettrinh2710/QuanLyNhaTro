﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_KhachHang
    {
        dbNhaTroDataContext db;
        public DAO_KhachHang()
        {
            db = new dbNhaTroDataContext();
        }

        public dynamic LayDSKhachHang(string ten)
        {
            try
            {
                dynamic ds = db.TimKH(ten);
                return ds;
            }
            catch (Exception)
            {

                throw new Exception("Không lấy được stored procedure");
            }
        }

        public bool ThemKH(KhachHang k)
        {
            try
            {
                var khach = db.ThemKH(k.ID, k.HoTen, k.GioiTinh, k.NgaySinh, k.Sdt, k.CMND, k.QueQuan);
                return true;
            }
            catch (Exception)
            {
                throw new Exception("Không lấy được stored procedure");
            }
        }

        //Kiểm tra id có trong bảng khách hàng
        public bool KiemTraIdKH(string id)
        {
            try
            {
                bool? kt = false;
                var kq = db.KTIdKhachHangToiTai(id, ref kt);
                return (bool)kt;
            }
            catch (Exception)
            {
                throw new Exception("Không lấy được stored procedure");
            }
        }

        public bool SuaKH(KhachHang k)
        {
            try
            {
                var khach = db.SuaKH(k.ID, k.HoTen, k.GioiTinh, k.NgaySinh, k.Sdt, k.CMND, k.QueQuan);
                return true;
            }
            catch (Exception)
            {
                throw new Exception("Không lấy được stored procedure");
            }
        }

        public bool XoaKH(string id)
        {
            try
            {
                var khach = db.XoaKH(id);
                return true;
            }
            catch (Exception)
            {
                throw new Exception("Không lấy được stored procedure");
            }
        }

        //kiểm tra khách hàng có trong bảng thuê phòng
        public bool KiemTraKH(string id)
        {
            try
            {
                bool? kq = false;
                var khach = db.KTKHTonTai(id, ref kq);
                return (bool)kq;
            }
            catch (Exception)
            {
                throw new Exception("Không lấy được stored procedure");
            }
        }

        //update mã phòng trong bảng khách hàng
        public bool CapNhatMaPhong(string id, int maPhong)
        {
            try
            {
                var khach = db.CapNhatMaPhongKH(id, maPhong);
                return true;
            }
            catch (Exception)
            {
                throw new Exception("Không lấy được stored procedure");
            }
        }

        //Kiểm tra khách hàng có trong bảng trả phòng
        public bool KiemTraKHCoTraPhong(string id)
        {
            try
            {
                bool? kq = false;
                var khach = db.KTKHCoTraPhong(id, ref kq);
                return (bool)kq;
            }
            catch (Exception)
            {
                throw new Exception("Không lấy được stored procedure");
            }
        }
    }
}
