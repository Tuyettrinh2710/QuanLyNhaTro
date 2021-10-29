
namespace QLNhaTro
{
    partial class frmDSHoaDon
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.btXem = new System.Windows.Forms.Button();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNam = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(296, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "DANH SÁCH HÓA ĐƠN";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHoaDon.Location = new System.Drawing.Point(0, 146);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.Size = new System.Drawing.Size(892, 280);
            this.dgvHoaDon.TabIndex = 24;
            // 
            // btXem
            // 
            this.btXem.Location = new System.Drawing.Point(599, 83);
            this.btXem.Name = "btXem";
            this.btXem.Size = new System.Drawing.Size(80, 35);
            this.btXem.TabIndex = 23;
            this.btXem.Text = "Xem";
            this.btXem.UseVisualStyleBackColor = true;
            this.btXem.Click += new System.EventHandler(this.btXem_Click);
            // 
            // cbThang
            // 
            this.cbThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Items.AddRange(new object[] {
            "Tất cả",
            "Tháng 1",
            "Tháng 2",
            "Tháng 3",
            "Tháng 4",
            "Tháng 5",
            "Tháng 6",
            "Tháng 7",
            "Tháng 8",
            "Tháng 9",
            "Tháng 10",
            "Tháng 11",
            "Tháng 12"});
            this.cbThang.Location = new System.Drawing.Point(378, 87);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(121, 28);
            this.cbThang.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tháng:";
            // 
            // dtpNam
            // 
            this.dtpNam.CustomFormat = "yyyy";
            this.dtpNam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNam.Location = new System.Drawing.Point(120, 85);
            this.dtpNam.Name = "dtpNam";
            this.dtpNam.ShowUpDown = true;
            this.dtpNam.Size = new System.Drawing.Size(82, 26);
            this.dtpNam.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Năm:";
            // 
            // btIn
            // 
            this.btIn.Location = new System.Drawing.Point(768, 83);
            this.btIn.Name = "btIn";
            this.btIn.Size = new System.Drawing.Size(80, 35);
            this.btIn.TabIndex = 25;
            this.btIn.Text = "IN";
            this.btIn.UseVisualStyleBackColor = true;
            this.btIn.Click += new System.EventHandler(this.btIn_Click);
            // 
            // frmDSHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(892, 426);
            this.Controls.Add(this.btIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.btXem);
            this.Controls.Add(this.cbThang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpNam);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDSHoaDon";
            this.Text = "frmDSHoaDon";
            this.Load += new System.EventHandler(this.frmDSHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Button btXem;
        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btIn;
    }
}