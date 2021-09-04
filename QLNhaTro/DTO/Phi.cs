using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Phi
    {
        private int id;
        private string tenPhi;
        private double giaTien;

        public int Id { get => id; set => id = value; }
        public string TenPhi { get => tenPhi; set => tenPhi = value; }
        public double GiaTien { get => giaTien; set => giaTien = value; }
    }
}
