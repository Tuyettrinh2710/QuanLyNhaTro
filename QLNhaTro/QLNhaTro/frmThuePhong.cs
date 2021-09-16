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
    public partial class frmThuePhong : Form
    {

        BUS_LoaiPhong busLoaiPhong;
        BUS_Phong busPhong;
        BUS_ThuePhong busThue;
        public frmThuePhong()
        {
            InitializeComponent();
            busThue = new BUS_ThuePhong();
            busPhong = new BUS_Phong();
            busLoaiPhong = new BUS_LoaiPhong();
        }

        private void frmThuePhong_Load(object sender, EventArgs e)
        {
            tbMaThue.Text = busThue.LayMa();
            busLoaiPhong.DSLoai(cbLoai);
        }

        private void cbLoai_SelectedValueChanged(object sender, EventArgs e)
        {
            lvPhong.Items.Clear();
            string idLoai = cbLoai.SelectedValue.ToString();
            int id;
            bool kq = int.TryParse(idLoai, out id);
            busPhong.LayPhongTrong(lvPhong, id);
        }

        private void lvPhong_Click(object sender, EventArgs e)
        {
            tbPhong.Text = lvPhong.SelectedItems[0].Text;
        }
    }
}
