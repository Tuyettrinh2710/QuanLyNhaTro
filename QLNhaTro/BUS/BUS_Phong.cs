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

        //lấy phòng trống theo id loại phòng
        public void LayPhongTrong(ListView lv, int id)
        {
            foreach (Phong p in da.LayPhongTrongTheoLoai(id))
            {
                lv.Items.Add(new ListViewItem { ImageIndex = 0, Text = p.TenPhong });
            }    
        }

        //Kiểm tra phòng có nằm trong bảng dữ liệu khách hàng 
        //public bool KiemTraPhong(int id)
        //{
        //    if (da.KiemTraPhong(id) == true)
        //        return true;
        //    else
        //        return false;
        //}

        //lấy tên phòng hiển thị ra combobox
        //public void LayTenPhong(ComboBox cb)
        //{
        //    cb.DataSource = da.LayDSPhong();
        //    cb.DisplayMember = "TenPhong";
        //    cb.ValueMember = "ID";
        //}

        //Lấy số người còn trống trong phòng
        public int LaySoNguoiConTrong(int id)
        {
            int soNguoi = da.LaySoNguoiTrongPhong(id);
            return soNguoi;
        }

        // Update số người hiện tại trong phòng
        public void UpdateSoNguoi(int id, int soNguoi)
        {
            if(da.UpdateSoNguoiHienTai(id, soNguoi))
            {
                string s = string.Format("Phòng có id {0} có số người hiện tại của phòng là {1}", id, soNguoi);
                MessageBox.Show(s);
            }
            else
            {
                string s = string.Format("Update phòng có id {0} thất bại", id);
                MessageBox.Show(s);
            }
        }

        //Lấy id phòng theo tên
        public int LayIDPhong(string ten)
        {
            List<Phong> ds = da.LayPhongTheoTen(ten);
            int id = 0;
            foreach(Phong p in ds)
            {
                id = p.ID;
            }
            return id;
        }    

        //Lấy số người hiện tại trong phòng
        public int LaySoNguoiTrongPhong(int id)
        {
            int soNguoi = da.LaySNTrongPhong(id);
            return soNguoi;
        }

        //lấy danh sách phòng trống
        public void LayDSPhongTrong(DataGridView dgv)
        {
            dgv.DataSource = da.LayDSPhongTrong();
        }

        //lấy danh sách phòng đã thuê
        public void LayDSPhongDaChoThue(DataGridView dgv)
        {
            dgv.DataSource = da.LayDSPhongDaChoThue();
        }
    }
}
