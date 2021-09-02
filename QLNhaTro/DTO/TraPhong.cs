using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class TraPhong
    {
        private string id_Thue;
        private string id_KH;
        private int id_Phong;
        private DateTime ngayThue;
        private DateTime ngayTra;

        public string Id_Thue { get => id_Thue; set => id_Thue = value; }
        public string Id_KH { get => id_KH; set => id_KH = value; }
        public int Id_Phong { get => id_Phong; set => id_Phong = value; }
        public DateTime NgayThue { get => ngayThue; set => ngayThue = value; }
        public DateTime NgayTra { get => ngayTra; set => ngayTra = value; }
    }
}
