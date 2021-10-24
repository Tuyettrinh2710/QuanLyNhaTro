
namespace QLNhaTro
{
    partial class frmDSKhachThue
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btIN = new System.Windows.Forms.Button();
            this.dgvKhach = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbKhongCon = new System.Windows.Forms.RadioButton();
            this.rbDang = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhach)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 75);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(297, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH KHÁCH THUÊ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btIN);
            this.panel2.Controls.Add(this.dgvKhach);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(260, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 351);
            this.panel2.TabIndex = 1;
            // 
            // btIN
            // 
            this.btIN.Location = new System.Drawing.Point(522, 298);
            this.btIN.Name = "btIN";
            this.btIN.Size = new System.Drawing.Size(89, 37);
            this.btIN.TabIndex = 3;
            this.btIN.Text = "IN";
            this.btIN.UseVisualStyleBackColor = true;
            this.btIN.Click += new System.EventHandler(this.btIN_Click);
            // 
            // dgvKhach
            // 
            this.dgvKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhach.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvKhach.Location = new System.Drawing.Point(0, 0);
            this.dgvKhach.Name = "dgvKhach";
            this.dgvKhach.RowHeadersWidth = 51;
            this.dgvKhach.RowTemplate.Height = 24;
            this.dgvKhach.Size = new System.Drawing.Size(632, 279);
            this.dgvKhach.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Controls.Add(this.rbKhongCon);
            this.groupBox1.Controls.Add(this.rbDang);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 351);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lựa chọn";
            // 
            // rbKhongCon
            // 
            this.rbKhongCon.AutoSize = true;
            this.rbKhongCon.Location = new System.Drawing.Point(20, 104);
            this.rbKhongCon.Name = "rbKhongCon";
            this.rbKhongCon.Size = new System.Drawing.Size(196, 24);
            this.rbKhongCon.TabIndex = 1;
            this.rbKhongCon.Text = "Không còn thuê phòng";
            this.rbKhongCon.UseVisualStyleBackColor = true;
            this.rbKhongCon.CheckedChanged += new System.EventHandler(this.rbKhongCon_CheckedChanged);
            // 
            // rbDang
            // 
            this.rbDang.AutoSize = true;
            this.rbDang.Checked = true;
            this.rbDang.Location = new System.Drawing.Point(20, 51);
            this.rbDang.Name = "rbDang";
            this.rbDang.Size = new System.Drawing.Size(156, 24);
            this.rbDang.TabIndex = 0;
            this.rbDang.TabStop = true;
            this.rbDang.Text = "Đang thuê phòng";
            this.rbDang.UseVisualStyleBackColor = true;
            this.rbDang.CheckedChanged += new System.EventHandler(this.rbDang_CheckedChanged);
            // 
            // frmDSKhachThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(892, 426);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDSKhachThue";
            this.Text = "frmDSKhachThue";
            this.Load += new System.EventHandler(this.frmDSKhachThue_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvKhach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbKhongCon;
        private System.Windows.Forms.RadioButton rbDang;
        private System.Windows.Forms.Button btIN;
    }
}