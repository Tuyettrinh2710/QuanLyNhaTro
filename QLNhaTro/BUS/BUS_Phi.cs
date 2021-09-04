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

        public void Them(string ten, double gia)
        {
            try
            {
                Phi p = new Phi();
                p.TenPhi = ten;
                p.GiaTien = (decimal?)gia;
                da.Them(p);
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        public void Xoa(int id)
        {
            try
            {
                da.Xoa(id);
                MessageBox.Show("Xóa thành công");
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        public void Sua(int id, string ten, double gia)
        {
            try
            {
                Phi p = new Phi();
                p.ID = id;
                p.TenPhi = ten;
                p.GiaTien = (decimal?)gia;
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
    }
}
