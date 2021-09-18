﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_LoaiPhong
    {
        dbNhaTroDataContext db;
        public DAO_LoaiPhong()
        {
            db = new dbNhaTroDataContext();
        }

        public dynamic LayDSLoaiPhong()
        {
            dynamic ds = db.LayDSLoaiPhong();
            return ds;
        }

        public bool ThemLoaiPhong(LoaiPhong lp)
        {
            try
            {
                var loaiPhong = db.ThemLP(lp.TenLP, lp.GiaTien);
                return true;
            }
            catch (Exception)
            { 
                throw new Exception("Không lấy được stored procedure");
            }
        }

        public bool SuaLoaiPhong(LoaiPhong lp)
        {
            try
            {
                var loaiPhong = db.SuaLP(lp.ID, lp.TenLP, lp.GiaTien);
                return true;
            }
            catch (Exception)
            {
                throw new Exception("Không lấy được stored procedure");
            }
        }

        public bool XoaLoaiPhong(int id)
        {
            try
            {
                var loaiPhong = db.XoaLP(id);
                return true;
            }
            catch (Exception)
            {
                throw new Exception("Không lấy được stored procedure");
            }
        }

        //public dynamic LayGiaPhong(int id)
        //{
        //    try
        //    {
        //        dynamic gia = db.LoaiPhongs.Where(s => s.ID == id);
        //        return gia;
        //    }
        //    catch (Exception)
        //    {

        //        throw new Exception("Không lấy được stored procedure");
        //    }
        //}

        //lấy giá phòng kiểu dữ liệu List<>
        public List<LoaiPhong> LayGia(int id)
        {
            try
            {
                List<LoaiPhong> gia = db.LoaiPhongs.Where(s => s.ID == id).ToList<LoaiPhong>();
                return gia;
            }
            catch (Exception)
            {

                throw new Exception("Không lấy được dữ liệu");
            }
        }

        //kiểm tra loại phòng có trong phòng
        public bool KiemTraLP(int id)
        {
            try
            {
                bool? kq = false;
                var loai = db.KTLoaiTonTai(id, ref kq);
                return (bool)kq;
            }
            catch (Exception)
            {

                throw new Exception("Không lấy được stored procedure");
            }
        }
    }
}
