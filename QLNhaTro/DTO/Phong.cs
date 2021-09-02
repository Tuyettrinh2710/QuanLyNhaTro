using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class Phong
    {
        private int id;
        private string tenPhong;
        private int idLoaiPhong;
        private int soNguoiToiDa;
        private int soNguoiHienTai;
        private double tienPhong;

        public int Id { get => id; set => id = value; }
        public string TenPhong { get => tenPhong; set => tenPhong = value; }
        public int IdLoaiPhong { get => idLoaiPhong; set => idLoaiPhong = value; }
        public int SoNguoiToiDa { get => soNguoiToiDa; set => soNguoiToiDa = value; }
        public int SoNguoiHienTai { get => soNguoiHienTai; set => soNguoiHienTai = value; }
        public double TienPhong { get => tienPhong; set => tienPhong = value; }
    }
}
