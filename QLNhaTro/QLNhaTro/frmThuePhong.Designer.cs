
namespace QLNhaTro
{
    partial class frmThuePhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThuePhong));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbLoai = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lvPhong = new System.Windows.Forms.ListView();
            this.imgIcon = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.tbQueQuan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCMND = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSdt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbTienPhong = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbPhong = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbMaPhong = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbMaThue = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpNgayThue = new System.Windows.Forms.DateTimePicker();
            this.btThemNguoi = new System.Windows.Forms.Button();
            this.btTaoMoi = new System.Windows.Forms.Button();
            this.tbTienCoc = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(392, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "THUÊ PHÒNG";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Controls.Add(this.cbLoai);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lvPhong);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(1, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 370);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phòng trống";
            // 
            // cbLoai
            // 
            this.cbLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoai.FormattingEnabled = true;
            this.cbLoai.Location = new System.Drawing.Point(146, 29);
            this.cbLoai.Name = "cbLoai";
            this.cbLoai.Size = new System.Drawing.Size(121, 28);
            this.cbLoai.TabIndex = 2;
            this.cbLoai.SelectedValueChanged += new System.EventHandler(this.cbLoai_SelectedValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(8, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Loại phòng:";
            // 
            // lvPhong
            // 
            this.lvPhong.HideSelection = false;
            this.lvPhong.LargeImageList = this.imgIcon;
            this.lvPhong.Location = new System.Drawing.Point(6, 58);
            this.lvPhong.Name = "lvPhong";
            this.lvPhong.Size = new System.Drawing.Size(262, 306);
            this.lvPhong.TabIndex = 0;
            this.lvPhong.UseCompatibleStateImageBehavior = false;
            this.lvPhong.Click += new System.EventHandler(this.lvPhong_Click);
            // 
            // imgIcon
            // 
            this.imgIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgIcon.ImageStream")));
            this.imgIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.imgIcon.Images.SetKeyName(0, "house.png");
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox2.Controls.Add(this.cbGioiTinh);
            this.groupBox2.Controls.Add(this.dtpNgaySinh);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tbQueQuan);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbCMND);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbSdt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbTen);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(292, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(595, 136);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khách thuê";
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinh.Location = new System.Drawing.Point(391, 24);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(191, 28);
            this.cbGioiTinh.TabIndex = 27;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(391, 60);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(191, 26);
            this.dtpNgaySinh.TabIndex = 26;
            this.dtpNgaySinh.Validating += new System.ComponentModel.CancelEventHandler(this.dtpNgaySinh_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(6, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 20);
            this.label9.TabIndex = 12;
            // 
            // tbQueQuan
            // 
            this.tbQueQuan.Location = new System.Drawing.Point(91, 92);
            this.tbQueQuan.Name = "tbQueQuan";
            this.tbQueQuan.Size = new System.Drawing.Size(191, 26);
            this.tbQueQuan.TabIndex = 11;
            this.tbQueQuan.Validating += new System.ComponentModel.CancelEventHandler(this.tbQueQuan_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Quê quán:";
            // 
            // tbCMND
            // 
            this.tbCMND.Location = new System.Drawing.Point(91, 60);
            this.tbCMND.MaxLength = 12;
            this.tbCMND.Name = "tbCMND";
            this.tbCMND.Size = new System.Drawing.Size(191, 26);
            this.tbCMND.TabIndex = 9;
            this.tbCMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCMND_KeyPress);
            this.tbCMND.Validating += new System.ComponentModel.CancelEventHandler(this.tbCMND_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "CMND:";
            // 
            // tbSdt
            // 
            this.tbSdt.Location = new System.Drawing.Point(391, 92);
            this.tbSdt.MaxLength = 10;
            this.tbSdt.Name = "tbSdt";
            this.tbSdt.Size = new System.Drawing.Size(191, 26);
            this.tbSdt.TabIndex = 7;
            this.tbSdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSdt_KeyPress);
            this.tbSdt.Validating += new System.ComponentModel.CancelEventHandler(this.tbSdt_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(297, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "SĐT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(297, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(297, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới tính:";
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(91, 28);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(191, 26);
            this.tbTen.TabIndex = 1;
            this.tbTen.Validating += new System.ComponentModel.CancelEventHandler(this.tbTen_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox3.Controls.Add(this.tbTienPhong);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.tbPhong);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.tbMaPhong);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(292, 208);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(595, 79);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin phòng";
            // 
            // tbTienPhong
            // 
            this.tbTienPhong.Location = new System.Drawing.Point(466, 29);
            this.tbTienPhong.Name = "tbTienPhong";
            this.tbTienPhong.ReadOnly = true;
            this.tbTienPhong.Size = new System.Drawing.Size(121, 26);
            this.tbTienPhong.TabIndex = 21;
            this.tbTienPhong.TextChanged += new System.EventHandler(this.tbTienPhong_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(394, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Giá tiền:";
            // 
            // tbPhong
            // 
            this.tbPhong.Location = new System.Drawing.Point(267, 29);
            this.tbPhong.Name = "tbPhong";
            this.tbPhong.ReadOnly = true;
            this.tbPhong.Size = new System.Drawing.Size(121, 26);
            this.tbPhong.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(176, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Tên phòng";
            // 
            // tbMaPhong
            // 
            this.tbMaPhong.Location = new System.Drawing.Point(49, 29);
            this.tbMaPhong.Name = "tbMaPhong";
            this.tbMaPhong.ReadOnly = true;
            this.tbMaPhong.Size = new System.Drawing.Size(121, 26);
            this.tbMaPhong.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(6, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Mã:";
            // 
            // tbMaThue
            // 
            this.tbMaThue.Location = new System.Drawing.Point(418, 309);
            this.tbMaThue.Name = "tbMaThue";
            this.tbMaThue.ReadOnly = true;
            this.tbMaThue.Size = new System.Drawing.Size(163, 26);
            this.tbMaThue.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(290, 312);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 20);
            this.label13.TabIndex = 22;
            this.label13.Text = "Mã thuê phòng";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(290, 345);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 20);
            this.label14.TabIndex = 24;
            this.label14.Text = "Ngày thuê:";
            // 
            // dtpNgayThue
            // 
            this.dtpNgayThue.Enabled = false;
            this.dtpNgayThue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayThue.Location = new System.Drawing.Point(418, 344);
            this.dtpNgayThue.Name = "dtpNgayThue";
            this.dtpNgayThue.Size = new System.Drawing.Size(163, 26);
            this.dtpNgayThue.TabIndex = 25;
            // 
            // btThemNguoi
            // 
            this.btThemNguoi.Location = new System.Drawing.Point(757, 309);
            this.btThemNguoi.Name = "btThemNguoi";
            this.btThemNguoi.Size = new System.Drawing.Size(117, 37);
            this.btThemNguoi.TabIndex = 26;
            this.btThemNguoi.Text = "Thêm người";
            this.btThemNguoi.UseVisualStyleBackColor = true;
            this.btThemNguoi.Click += new System.EventHandler(this.btThemNguoi_Click);
            // 
            // btTaoMoi
            // 
            this.btTaoMoi.Location = new System.Drawing.Point(757, 368);
            this.btTaoMoi.Name = "btTaoMoi";
            this.btTaoMoi.Size = new System.Drawing.Size(117, 37);
            this.btTaoMoi.TabIndex = 27;
            this.btTaoMoi.Text = "Tạo mới";
            this.btTaoMoi.UseVisualStyleBackColor = true;
            this.btTaoMoi.Click += new System.EventHandler(this.btTaoMoi_Click);
            // 
            // tbTienCoc
            // 
            this.tbTienCoc.Location = new System.Drawing.Point(418, 379);
            this.tbTienCoc.Name = "tbTienCoc";
            this.tbTienCoc.Size = new System.Drawing.Size(163, 26);
            this.tbTienCoc.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(290, 382);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 20);
            this.label15.TabIndex = 29;
            this.label15.Text = "Tiền coc:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(892, 428);
            this.Controls.Add(this.tbTienCoc);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btTaoMoi);
            this.Controls.Add(this.btThemNguoi);
            this.Controls.Add(this.dtpNgayThue);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tbMaThue);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThuePhong";
            this.Text = "frmThuePhong";
            this.Load += new System.EventHandler(this.frmThuePhong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvPhong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbQueQuan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCMND;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSdt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbLoai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbTienPhong;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbPhong;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbMaPhong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox tbMaThue;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpNgayThue;
        private System.Windows.Forms.Button btThemNguoi;
        private System.Windows.Forms.Button btTaoMoi;
        private System.Windows.Forms.TextBox tbTienCoc;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ImageList imgIcon;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}