
namespace QLNhaTro
{
    partial class frmTinhTien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTinhTien));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvPhong = new System.Windows.Forms.ListView();
            this.imgIcon = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbSDT = new System.Windows.Forms.ComboBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCMND = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMaPhong = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbDichVu = new System.Windows.Forms.TextBox();
            this.tbTienNuoc = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbTienDien = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbSKDien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbSKNuoc = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbTienPhong = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbTongTien = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btLuu = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
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
            this.label1.Location = new System.Drawing.Point(370, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "LẬP HÓA ĐƠN";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Controls.Add(this.lvPhong);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(868, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phòng chưa lập hóa đơn";
            // 
            // lvPhong
            // 
            this.lvPhong.HideSelection = false;
            this.lvPhong.LargeImageList = this.imgIcon;
            this.lvPhong.Location = new System.Drawing.Point(6, 25);
            this.lvPhong.Name = "lvPhong";
            this.lvPhong.Size = new System.Drawing.Size(856, 69);
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
            this.groupBox2.Controls.Add(this.cbSDT);
            this.groupBox2.Controls.Add(this.dtpNgaySinh);
            this.groupBox2.Controls.Add(this.tbDiaChi);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbTen);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbCMND);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 208);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khách thuê";
            // 
            // cbSDT
            // 
            this.cbSDT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSDT.FormattingEnabled = true;
            this.cbSDT.Location = new System.Drawing.Point(139, 23);
            this.cbSDT.Name = "cbSDT";
            this.cbSDT.Size = new System.Drawing.Size(191, 28);
            this.cbSDT.TabIndex = 27;
            this.cbSDT.SelectedValueChanged += new System.EventHandler(this.cbSDT_SelectedValueChanged);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(139, 144);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(191, 26);
            this.dtpNgaySinh.TabIndex = 26;
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Location = new System.Drawing.Point(139, 173);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(191, 26);
            this.tbDiaChi.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(40, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Quê quán:";
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(139, 54);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(191, 26);
            this.tbTen.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(40, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "CMND:";
            // 
            // tbCMND
            // 
            this.tbCMND.Location = new System.Drawing.Point(139, 83);
            this.tbCMND.Name = "tbCMND";
            this.tbCMND.Size = new System.Drawing.Size(191, 26);
            this.tbCMND.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(40, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "SĐT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(40, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(40, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(40, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên:";
            // 
            // tbMaPhong
            // 
            this.tbMaPhong.Location = new System.Drawing.Point(109, 389);
            this.tbMaPhong.Name = "tbMaPhong";
            this.tbMaPhong.ReadOnly = true;
            this.tbMaPhong.Size = new System.Drawing.Size(75, 26);
            this.tbMaPhong.TabIndex = 28;
            this.tbMaPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbMaPhong.TextChanged += new System.EventHandler(this.tbMaPhong_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(10, 392);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 20);
            this.label16.TabIndex = 27;
            this.label16.Text = "Mã Phòng:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox3.Controls.Add(this.tbDichVu);
            this.groupBox3.Controls.Add(this.tbTienNuoc);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.tbTienDien);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.tbSKDien);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.tbSKNuoc);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.tbTienPhong);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(438, 165);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(442, 208);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Phí sử dụng";
            // 
            // tbDichVu
            // 
            this.tbDichVu.Location = new System.Drawing.Point(298, 170);
            this.tbDichVu.Name = "tbDichVu";
            this.tbDichVu.ReadOnly = true;
            this.tbDichVu.Size = new System.Drawing.Size(120, 26);
            this.tbDichVu.TabIndex = 16;
            this.tbDichVu.Text = "0";
            this.tbDichVu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbTienNuoc
            // 
            this.tbTienNuoc.Location = new System.Drawing.Point(298, 140);
            this.tbTienNuoc.Name = "tbTienNuoc";
            this.tbTienNuoc.ReadOnly = true;
            this.tbTienNuoc.Size = new System.Drawing.Size(120, 26);
            this.tbTienNuoc.TabIndex = 15;
            this.tbTienNuoc.Text = "0";
            this.tbTienNuoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbTienNuoc.TextChanged += new System.EventHandler(this.tbTienNuoc_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(197, 143);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 20);
            this.label15.TabIndex = 14;
            this.label15.Text = "Thành tiền:";
            // 
            // tbTienDien
            // 
            this.tbTienDien.Location = new System.Drawing.Point(298, 80);
            this.tbTienDien.Name = "tbTienDien";
            this.tbTienDien.ReadOnly = true;
            this.tbTienDien.Size = new System.Drawing.Size(120, 26);
            this.tbTienDien.TabIndex = 13;
            this.tbTienDien.Text = "0";
            this.tbTienDien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbTienDien.TextChanged += new System.EventHandler(this.tbTienDien_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(197, 83);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 20);
            this.label14.TabIndex = 12;
            this.label14.Text = "Thành tiền:";
            // 
            // tbSKDien
            // 
            this.tbSKDien.Location = new System.Drawing.Point(132, 80);
            this.tbSKDien.Name = "tbSKDien";
            this.tbSKDien.Size = new System.Drawing.Size(53, 26);
            this.tbSKDien.TabIndex = 11;
            this.tbSKDien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbSKDien.TextChanged += new System.EventHandler(this.tbSKDien_TextChanged);
            this.tbSKDien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSKDien_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(34, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Số kí điện:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(21, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tiền điện:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(21, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Tiền dịch vụ:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(34, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "Số kí nước:";
            // 
            // tbSKNuoc
            // 
            this.tbSKNuoc.Location = new System.Drawing.Point(132, 140);
            this.tbSKNuoc.Name = "tbSKNuoc";
            this.tbSKNuoc.Size = new System.Drawing.Size(53, 26);
            this.tbSKNuoc.TabIndex = 3;
            this.tbSKNuoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbSKNuoc.TextChanged += new System.EventHandler(this.tbSKNuoc_TextChanged);
            this.tbSKNuoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSKNuoc_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(21, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Tiền nước:";
            // 
            // tbTienPhong
            // 
            this.tbTienPhong.Location = new System.Drawing.Point(298, 22);
            this.tbTienPhong.Name = "tbTienPhong";
            this.tbTienPhong.ReadOnly = true;
            this.tbTienPhong.Size = new System.Drawing.Size(120, 26);
            this.tbTienPhong.TabIndex = 1;
            this.tbTienPhong.Text = "0";
            this.tbTienPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbTienPhong.TextChanged += new System.EventHandler(this.tbTienPhong_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(21, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Tiền phòng:";
            // 
            // tbTongTien
            // 
            this.tbTongTien.Location = new System.Drawing.Point(604, 389);
            this.tbTongTien.Name = "tbTongTien";
            this.tbTongTien.Size = new System.Drawing.Size(139, 26);
            this.tbTongTien.TabIndex = 28;
            this.tbTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(505, 392);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 20);
            this.label17.TabIndex = 27;
            this.label17.Text = "Tổng tiền:";
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(785, 384);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(89, 37);
            this.btLuu.TabIndex = 29;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(229, 392);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 20);
            this.label18.TabIndex = 30;
            this.label18.Text = "Ngày lập:";
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayLap.Enabled = false;
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLap.Location = new System.Drawing.Point(309, 389);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(154, 26);
            this.dtpNgayLap.TabIndex = 31;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinh.Location = new System.Drawing.Point(139, 112);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(191, 28);
            this.cbGioiTinh.TabIndex = 28;
            // 
            // frmTinhTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(892, 428);
            this.Controls.Add(this.dtpNgayLap);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.tbMaPhong);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.tbTongTien);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTinhTien";
            this.Text = "frmTinhTien";
            this.Load += new System.EventHandler(this.frmTinhTien_Load);
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCMND;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbSKDien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbSKNuoc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbTienPhong;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbDichVu;
        private System.Windows.Forms.TextBox tbTienNuoc;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbTienDien;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbTongTien;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.ImageList imgIcon;
        private System.Windows.Forms.TextBox tbMaPhong;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.ComboBox cbSDT;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cbGioiTinh;
    }
}