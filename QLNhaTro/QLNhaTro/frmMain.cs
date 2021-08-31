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
    public partial class frmMain : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public frmMain()
        {
            InitializeComponent();
        }

        private void ptbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ptbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ptbState_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                this.WindowState = FormWindowState.Maximized;
                ptbState.Image = Properties.Resources.max;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                ptbState.Image = Properties.Resources.nut2;
            }
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void addForm(Form f)
        {
            this.pnlContent.Controls.Clear();
            this.mnsMain.Show();
            f.TopLevel = false;
            f.AutoScroll = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.Text = f.Text;
            this.pnlContent.Controls.Add(f);
            f.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            var f = new frmTrangChu();
            addForm(f);
        }

        private void cậpNhậtKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmCapNhatKH();
            addForm(f);
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmTrangChu();
            addForm(f);
        }

        private void danhSáchKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmDanhSachKH();
            addForm(f);
        }

        private void loạiPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmLoaiPhong();
            addForm(f);
        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmPhong();
            addForm(f);
        }

        private void quảnLýCácLoạiPhíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmPhi();
            addForm(f);
        }

        private void thuêPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmThuePhong();
            addForm(f);
        }

        private void trảPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmTraPhong();
            addForm(f);
        }

        private void tínhTiềnPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmTinhTien();
            addForm(f);
        }

        private void thuTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmThuTien();
            addForm(f);
        }
    }
}
