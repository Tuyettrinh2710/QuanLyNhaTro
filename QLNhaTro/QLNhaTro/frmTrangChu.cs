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
        public frmTrangChu()
        {
            InitializeComponent();
            busPhi = new BUS_Phi();
            busLoaiPhong = new BUS_LoaiPhong();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            busPhi.LayGia(cbDien, 1);
            busPhi.LayGia(cbNuoc, 2);
            busPhi.LayGia(cbDV, 3);
            busLoaiPhong.DSLoai(cbLoai);
        }
    }
}
