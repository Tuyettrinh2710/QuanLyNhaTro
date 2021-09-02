using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class HoaDon
    {
        private int id;
        private string id_KH;
        private int id_Phong;
        private DateTime ngayLap;
        private DateTime ngayThu;
        private double giaPhong;
        private int skDien;
        private double tienDien;
        private int skNuoc;
        private double tienNuoc;
        private double tienDV;
        private double tonTien;
        private string trangThai;

        public int Id { get => id; set => id = value; }
        public string Id_KH { get => id_KH; set => id_KH = value; }
        public int Id_Phong { get => id_Phong; set => id_Phong = value; }
        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
        public DateTime NgayThu { get => ngayThu; set => ngayThu = value; }
        public double GiaPhong { get => giaPhong; set => giaPhong = value; }
        public int SkDien { get => skDien; set => skDien = value; }
        public double TienDien { get => tienDien; set => tienDien = value; }
        public int SkNuoc { get => skNuoc; set => skNuoc = value; }
        public double TienNuoc { get => tienNuoc; set => tienNuoc = value; }
        public double TienDV { get => tienDV; set => tienDV = value; }
        public double TonTien { get => tonTien; set => tonTien = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
    }
}
