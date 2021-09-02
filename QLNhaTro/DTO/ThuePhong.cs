using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class ThuePhong
    {
        private string id;
        private string id_KH;
        private int id_Phong;
        private DateTime ngayThue;
        private double tienCoc;

        public string Id { get => id; set => id = value; }
        public string Id_KH { get => id_KH; set => id_KH = value; }
        public int Id_Phong { get => id_Phong; set => id_Phong = value; }
        public DateTime NgayThue { get => ngayThue; set => ngayThue = value; }
        public double TienCoc { get => tienCoc; set => tienCoc = value; }
    }
}
