
namespace QLNhaTro
{
    partial class frmTraPhong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbTim = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvKhach = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.tbCMND = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbQueQuan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbGioiTinh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMaPhong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpNgayThue = new System.Windows.Forms.DateTimePicker();
            this.tbTienCoc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbMaThue = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.btTra = new System.Windows.Forms.Button();
            this.pnlTraPhong = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhach)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlTraPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(382, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRẢ PHÒNG";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Controls.Add(this.tbTim);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.dgvKhach);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 210);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách khách hàng";
            // 
            // tbTim
            // 
            this.tbTim.Location = new System.Drawing.Point(228, 31);
            this.tbTim.Name = "tbTim";
            this.tbTim.Size = new System.Drawing.Size(296, 26);
            this.tbTim.TabIndex = 13;
            this.tbTim.TextChanged += new System.EventHandler(this.tbTim_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(41, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(167, 20);
            this.label13.TabIndex = 12;
            this.label13.Text = "Nhập tên khách thuê:";
            // 
            // dgvKhach
            // 
            this.dgvKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhach.Location = new System.Drawing.Point(6, 70);
            this.dgvKhach.Name = "dgvKhach";
            this.dgvKhach.RowHeadersWidth = 51;
            this.dgvKhach.RowTemplate.Height = 24;
            this.dgvKhach.Size = new System.Drawing.Size(561, 128);
            this.dgvKhach.TabIndex = 0;
            this.dgvKhach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox3.Controls.Add(this.dtpNgaySinh);
            this.groupBox3.Controls.Add(this.tbCMND);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tbSDT);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tbQueQuan);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tbGioiTinh);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tbten);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(3, 278);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(580, 138);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin khách hàng";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Enabled = false;
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(396, 27);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(178, 26);
            this.dtpNgaySinh.TabIndex = 24;
            // 
            // tbCMND
            // 
            this.tbCMND.Location = new System.Drawing.Point(101, 102);
            this.tbCMND.Name = "tbCMND";
            this.tbCMND.ReadOnly = true;
            this.tbCMND.Size = new System.Drawing.Size(178, 26);
            this.tbCMND.TabIndex = 11;
            this.tbCMND.Tag = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "CMND:";
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(395, 65);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.ReadOnly = true;
            this.tbSDT.Size = new System.Drawing.Size(178, 26);
            this.tbSDT.TabIndex = 9;
            this.tbSDT.Tag = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(300, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "SĐT:";
            // 
            // tbQueQuan
            // 
            this.tbQueQuan.Location = new System.Drawing.Point(395, 102);
            this.tbQueQuan.Name = "tbQueQuan";
            this.tbQueQuan.ReadOnly = true;
            this.tbQueQuan.Size = new System.Drawing.Size(178, 26);
            this.tbQueQuan.TabIndex = 7;
            this.tbQueQuan.Tag = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(300, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Quê quán:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(300, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày sinh:";
            // 
            // tbGioiTinh
            // 
            this.tbGioiTinh.Location = new System.Drawing.Point(101, 65);
            this.tbGioiTinh.Name = "tbGioiTinh";
            this.tbGioiTinh.ReadOnly = true;
            this.tbGioiTinh.Size = new System.Drawing.Size(178, 26);
            this.tbGioiTinh.TabIndex = 3;
            this.tbGioiTinh.Tag = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới tính:";
            // 
            // tbten
            // 
            this.tbten.Location = new System.Drawing.Point(101, 29);
            this.tbten.Name = "tbten";
            this.tbten.ReadOnly = true;
            this.tbten.Size = new System.Drawing.Size(178, 26);
            this.tbten.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên:";
            // 
            // tbMaPhong
            // 
            this.tbMaPhong.Location = new System.Drawing.Point(103, 160);
            this.tbMaPhong.Name = "tbMaPhong";
            this.tbMaPhong.ReadOnly = true;
            this.tbMaPhong.Size = new System.Drawing.Size(178, 26);
            this.tbMaPhong.TabIndex = 13;
            this.tbMaPhong.Tag = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(8, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Mã phòng:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox2.Controls.Add(this.dtpNgayThue);
            this.groupBox2.Controls.Add(this.tbMaPhong);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbTienCoc);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.tbMaThue);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(589, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 210);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin thuê";
            // 
            // dtpNgayThue
            // 
            this.dtpNgayThue.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayThue.Enabled = false;
            this.dtpNgayThue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayThue.Location = new System.Drawing.Point(103, 70);
            this.dtpNgayThue.Name = "dtpNgayThue";
            this.dtpNgayThue.Size = new System.Drawing.Size(178, 26);
            this.dtpNgayThue.TabIndex = 23;
            // 
            // tbTienCoc
            // 
            this.tbTienCoc.Location = new System.Drawing.Point(103, 116);
            this.tbTienCoc.Name = "tbTienCoc";
            this.tbTienCoc.ReadOnly = true;
            this.tbTienCoc.Size = new System.Drawing.Size(178, 26);
            this.tbTienCoc.TabIndex = 19;
            this.tbTienCoc.Tag = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(8, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Mã thuê:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(8, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Tiền cọc:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(9, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Ngày thuê:";
            // 
            // tbMaThue
            // 
            this.tbMaThue.Location = new System.Drawing.Point(103, 28);
            this.tbMaThue.Name = "tbMaThue";
            this.tbMaThue.ReadOnly = true;
            this.tbMaThue.Size = new System.Drawing.Size(178, 26);
            this.tbMaThue.TabIndex = 17;
            this.tbMaThue.Tag = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(598, 311);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Ngày trả:";
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayTra.Enabled = false;
            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTra.Location = new System.Drawing.Point(692, 306);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(178, 26);
            this.dtpNgayTra.TabIndex = 21;
            // 
            // btTra
            // 
            this.btTra.Location = new System.Drawing.Point(713, 369);
            this.btTra.Name = "btTra";
            this.btTra.Size = new System.Drawing.Size(105, 37);
            this.btTra.TabIndex = 22;
            this.btTra.Text = "Trả phòng";
            this.btTra.UseVisualStyleBackColor = true;
            this.btTra.Click += new System.EventHandler(this.btTra_Click);
            // 
            // pnlTraPhong
            // 
            this.pnlTraPhong.Controls.Add(this.label1);
            this.pnlTraPhong.Controls.Add(this.btTra);
            this.pnlTraPhong.Controls.Add(this.groupBox3);
            this.pnlTraPhong.Controls.Add(this.dtpNgayTra);
            this.pnlTraPhong.Controls.Add(this.groupBox2);
            this.pnlTraPhong.Controls.Add(this.label12);
            this.pnlTraPhong.Controls.Add(this.groupBox1);
            this.pnlTraPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTraPhong.Location = new System.Drawing.Point(0, 0);
            this.pnlTraPhong.Name = "pnlTraPhong";
            this.pnlTraPhong.Size = new System.Drawing.Size(892, 428);
            this.pnlTraPhong.TabIndex = 23;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmTraPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(892, 428);
            this.Controls.Add(this.pnlTraPhong);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTraPhong";
            this.Text = "frmTraPhong";
            this.Load += new System.EventHandler(this.frmTraPhong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhach)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlTraPhong.ResumeLayout(false);
            this.pnlTraPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvKhach;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbMaPhong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCMND;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbQueQuan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbGioiTinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbTienCoc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbMaThue;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.Button btTra;
        private System.Windows.Forms.Panel pnlTraPhong;
        private System.Windows.Forms.DateTimePicker dtpNgayThue;
        private System.Windows.Forms.TextBox tbTim;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}