using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace BUS
{
    public class BUS_Phong
    {

        DAO_Phong da;
        public BUS_Phong()
        {
            da = new DAO_Phong();
        }

        public void LayDSPhong(DataGridView dgv)
        {
            dgv.DataSource = da.LayDSPhong();
        }

        public void ThemPhong(string ten, int idLoai, int toiDa, int hienTai)
        {
            Phong p = new Phong();
            p.TenPhong = ten;
            p.IDLoaiPhong = idLoai;
            p.SoNguoiToiDa = toiDa;
            p.SoNguoiHienTai = hienTai;
            if (da.ThemPhong(p) == true)
            {
                string s = string.Format("Thêm phòng có tên {0} thành công", ten);
                MessageBox.Show(s);
            }
            else
            {
                string s = string.Format("Thêm phòng có tên {0} thất bại", ten);
                MessageBox.Show(s);
            }
        }

        public void SuaPhong(int id, string ten, int idLoai, int toiDa, int hienTai)
        {
            Phong p = new Phong(); p.TenPhong = ten;
            p.ID = id;
            p.IDLoaiPhong = idLoai;
            p.SoNguoiToiDa = toiDa;
            p.SoNguoiHienTai = hienTai;
            if (da.SuaPhong(p) == true)
            {
                string s = string.Format("Sửa phòng có id {0} thành công", id);
                MessageBox.Show(s);
            }
            else
            {
                string s = string.Format("Sửa phòng có id {0} thất bại", id);
                MessageBox.Show(s);
            }
        }

        public void XoaPhong(int id)
        {
            if (da.XoaPhong(id) == true)
            {
                string s = string.Format("Xóa phòng có id {0} thành công", id);
                MessageBox.Show(s);
            }
            else
            {
                string s = string.Format("Xóa phòng có id {0} thất bại", id);
                MessageBox.Show(s);
            }
        }

        public void LayPhongTrong(ListView lv, int id)
        {
            foreach (Phong p in da.LayPhongTrongTheoLoai(id))
            {
                lv.Items.Add(new ListViewItem { ImageIndex = 0, Text = p.TenPhong });
            }    
        }
    }
}
