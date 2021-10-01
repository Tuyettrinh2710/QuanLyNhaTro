using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace QLNhaTro
{
    public partial class frmTrangChu : Form
    {
        BUS_Phi busPhi;
        BUS_LoaiPhong busLoaiPhong;
        BUS_Phong busPhong;
        public frmTrangChu()
        {
            InitializeComponent();
            busPhi = new BUS_Phi();
            busLoaiPhong = new BUS_LoaiPhong();
            busPhong = new BUS_Phong();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            tbDien.Text = busPhi.LayGia(16).ToString();
            tbNuoc.Text = busPhi.LayGia(2).ToString();
            tbDV.Text = busPhi.LayGia(3).ToString();
            busLoaiPhong.DSLoai(cbLoai);
            //busLoaiPhong.LayGiaPhong(cbNho, 1);
            //busLoaiPhong.LayGiaPhong(cbVua, 2);
            //busLoaiPhong.LayGiaPhong(cbLon, 3);
            busLoaiPhong.LayGiaPhong(tbNho, 1);
            busLoaiPhong.LayGiaPhong(tbVua, 2);
            busLoaiPhong.LayGiaPhong(tbLon, 3);
        }

        private void cbLoai_SelectedValueChanged(object sender, EventArgs e)
        {
            lvPhong.Items.Clear();
            string idLoai = cbLoai.SelectedValue.ToString();
            int id;
            bool kq = int.TryParse(idLoai, out id);
            busPhong.LayPhongTrong(lvPhong, id);
        }
    }
}
