using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace BUS
{
    public class BUS_Phi
    {
        DAO_Phi da;
        public BUS_Phi()
        {
            da = new DAO_Phi();
        }
        public void DSPhi(DataGridView dgv)
        {
            dgv.DataSource = da.LayDSPhi();
        }

        public void Sua(int id, string ten, decimal gia)
        {
            try
            {
                Phi p = new Phi();
                p.ID = id;
                p.TenPhi = ten;
                p.GiaTien = gia;
                if (da.Sua(p))
                {
                    string info = string.Format("Sửa phí có mã {0} thành công", p.ID);
                    MessageBox.Show(info);
                }
                else
                {
                    string info = string.Format("Sửa phí có mã {0} thất bại", p.ID);
                    MessageBox.Show(info);
                }
            }
            catch (Exception)
            {

                throw new Exception("Không thể lấy được dữ liệu");
            }
        }

        public decimal LayGia(int id)
        {
            decimal gia = 0;
            foreach (Phi p in da.LayGia(id))
                gia = (decimal)p.GiaTien;
            return gia;
        }
    }
}
