using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaTro
{
    public partial class frmTraPhong : Form
    {
        public frmTraPhong()
        {
            InitializeComponent();
        }

        private void addForm(Form f)
        {
            this.pnlTraPhong.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.Text = f.Text;
            this.pnlTraPhong.Controls.Add(f);
            f.Show();
        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {
            var f = new frmThanhToanTP();
            addForm(f);
        }
    }
}
