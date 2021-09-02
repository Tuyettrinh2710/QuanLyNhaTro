using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class LoaiPhong
    {
        private int id;
        private string tenLP;
        private int dienTich;

        public int Id { get => id; set => id = value; }
        public string TenLP { get => tenLP; set => tenLP = value; }
        public int DienTich { get => dienTich; set => dienTich = value; }
    }
}
