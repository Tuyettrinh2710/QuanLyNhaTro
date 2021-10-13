using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace BUS
{
    public class BUS_LoaiPhong
    {
        DAO_LoaiPhong da;
        public BUS_LoaiPhong()
        {
            da = new DAO_LoaiPhong();
        }

        public void LayDSLoaiPhong(DataGridView dgv)
        {
            dgv.DataSource = da.LayDSLoaiPhong();
        }

        public void SuaLoaiPhong(int id, string ten, decimal gia)
        {
            LoaiPhong lp = new LoaiPhong();
            lp.ID = id;
            lp.TenLP = ten;
            lp.GiaTien = gia;
            if (da.SuaLoaiPhong(lp) == true)
            {
                string s = string.Format("Sửa loại phòng có id {0} thành công", id);
                MessageBox.Show(s);
            }
            else
            {
                string s = string.Format("Sửa loại phòng có id {0} thất bại", id);
                MessageBox.Show(s);
            }
        }

        public void DSLoai(ComboBox cb)
        {
            cb.DataSource = da.LayDSLoaiPhong();
            cb.DisplayMember = "TenLP";
            cb.ValueMember = "ID";
        }

        //public void LayGiaPhong(ComboBox cb, int id)
        //{
        //    cb.DataSource = da.LayGiaPhong(id);
        //    cb.DisplayMember = "GiaTien";
        //    cb.ValueMember = "ID";
        //}

        public void LayGiaPhong(TextBox tb, int id)
        {
            List<LoaiPhong> l = da.LayGia(id);
            foreach (LoaiPhong lp in l)
                tb.Text = lp.GiaTien.ToString();
        }
    }
}
