using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class KhachHang
    {
        private string id;
        private string hoTen;
        private string gioiTinh;
        private DateTime ngaySinh;
        private string sdt;
        private string cmnd;
        private string queQuan;
        private int maPhong;

        public string Id { get => id; set => id = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string QueQuan { get => queQuan; set => queQuan = value; }
        public int MaPhong { get => maPhong; set => maPhong = value; }
    }
}
