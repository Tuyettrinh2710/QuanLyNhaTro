
namespace QLNhaTro
{
    partial class frmCapNhatKH
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKH = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMa = new System.Windows.Forms.TextBox();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.tbCMND = new System.Windows.Forms.TextBox();
            this.tbQueQuan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSdt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btCSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbTim = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbMaPhong = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(305, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN KHÁCH THUÊ";
            // 
            // dgvKH
            // 
            this.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKH.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKH.Location = new System.Drawing.Point(5, 94);
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.RowHeadersWidth = 51;
            this.dgvKH.RowTemplate.Height = 24;
            this.dgvKH.Size = new System.Drawing.Size(420, 257);
            this.dgvKH.TabIndex = 1;
            this.dgvKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKH_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(31, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã khách thuê:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(31, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Họ tên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(31, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "CMND:";
            // 
            // tbMa
            // 
            this.tbMa.BackColor = System.Drawing.Color.White;
            this.tbMa.Enabled = false;
            this.tbMa.Location = new System.Drawing.Point(168, 22);
            this.tbMa.Name = "tbMa";
            this.tbMa.ReadOnly = true;
            this.tbMa.Size = new System.Drawing.Size(250, 26);
            this.tbMa.TabIndex = 5;
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(168, 58);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(250, 26);
            this.tbTen.TabIndex = 6;
            this.tbTen.Validating += new System.ComponentModel.CancelEventHandler(this.tbTen_Validating);
            // 
            // tbCMND
            // 
            this.tbCMND.Location = new System.Drawing.Point(168, 94);
            this.tbCMND.MaxLength = 12;
            this.tbCMND.Name = "tbCMND";
            this.tbCMND.Size = new System.Drawing.Size(250, 26);
            this.tbCMND.TabIndex = 7;
            this.tbCMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCMND_KeyPress);
            this.tbCMND.Validating += new System.ComponentModel.CancelEventHandler(this.tbCMND_Validating);
            // 
            // tbQueQuan
            // 
            this.tbQueQuan.Location = new System.Drawing.Point(168, 130);
            this.tbQueQuan.Name = "tbQueQuan";
            this.tbQueQuan.Size = new System.Drawing.Size(250, 26);
            this.tbQueQuan.TabIndex = 9;
            this.tbQueQuan.Validating += new System.ComponentModel.CancelEventHandler(this.tbQueQuan_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(31, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quê quán:";
            // 
            // tbSdt
            // 
            this.tbSdt.Location = new System.Drawing.Point(167, 201);
            this.tbSdt.MaxLength = 10;
            this.tbSdt.Name = "tbSdt";
            this.tbSdt.Size = new System.Drawing.Size(250, 26);
            this.tbSdt.TabIndex = 15;
            this.tbSdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSdt_KeyPress);
            this.tbSdt.Validating += new System.ComponentModel.CancelEventHandler(this.tbSdt_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(30, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Số điện thoại:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(30, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Ngày sinh:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(30, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Giới tính:";
            // 
            // btCSua
            // 
            this.btCSua.ForeColor = System.Drawing.Color.Black;
            this.btCSua.Location = new System.Drawing.Point(210, 313);
            this.btCSua.Name = "btCSua";
            this.btCSua.Size = new System.Drawing.Size(89, 37);
            this.btCSua.TabIndex = 19;
            this.btCSua.Text = "Sửa";
            this.btCSua.UseVisualStyleBackColor = true;
            this.btCSua.Click += new System.EventHandler(this.btCSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.ForeColor = System.Drawing.Color.Black;
            this.btXoa.Location = new System.Drawing.Point(328, 313);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(89, 37);
            this.btXoa.TabIndex = 20;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // dtpNgay
            // 
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgay.Location = new System.Drawing.Point(167, 165);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(250, 26);
            this.dtpNgay.TabIndex = 21;
            this.dtpNgay.Validating += new System.ComponentModel.CancelEventHandler(this.dtpNgay_Validating);
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinh.Location = new System.Drawing.Point(167, 237);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(250, 28);
            this.cbGioiTinh.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(31, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Mã phòng:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 71);
            this.panel1.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Controls.Add(this.tbMaPhong);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbMa);
            this.groupBox1.Controls.Add(this.cbGioiTinh);
            this.groupBox1.Controls.Add(this.tbTen);
            this.groupBox1.Controls.Add(this.dtpNgay);
            this.groupBox1.Controls.Add(this.tbCMND);
            this.groupBox1.Controls.Add(this.btXoa);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btCSua);
            this.groupBox1.Controls.Add(this.tbQueQuan);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbSdt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(451, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 357);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách thuê";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tbTim);
            this.groupBox2.Controls.Add(this.dgvKH);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(0, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 357);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách khách hàng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(6, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Nhập tên khách thuê:";
            // 
            // tbTim
            // 
            this.tbTim.BackColor = System.Drawing.Color.White;
            this.tbTim.Location = new System.Drawing.Point(175, 40);
            this.tbTim.Name = "tbTim";
            this.tbTim.Size = new System.Drawing.Size(250, 26);
            this.tbTim.TabIndex = 25;
            this.tbTim.TextChanged += new System.EventHandler(this.tbTim_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tbMaPhong
            // 
            this.tbMaPhong.BackColor = System.Drawing.Color.White;
            this.tbMaPhong.Enabled = false;
            this.tbMaPhong.Location = new System.Drawing.Point(168, 276);
            this.tbMaPhong.Name = "tbMaPhong";
            this.tbMaPhong.ReadOnly = true;
            this.tbMaPhong.Size = new System.Drawing.Size(250, 26);
            this.tbMaPhong.TabIndex = 24;
            // 
            // frmCapNhatKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(892, 428);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCapNhatKH";
            this.Text = "frmCapNhatKH";
            this.Load += new System.EventHandler(this.frmCapNhatKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMa;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.TextBox tbCMND;
        private System.Windows.Forms.TextBox tbQueQuan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSdt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btCSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbTim;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox tbMaPhong;
    }
}