
namespace QLNhaTro
{
    partial class frmDSKhachThueTrongPhong
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbTim = new System.Windows.Forms.TextBox();
            this.btIn = new System.Windows.Forms.Button();
            this.dgvKhach = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(226, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH KHÁCH TRONG PHÒNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập tên phòng:";
            // 
            // tbTim
            // 
            this.tbTim.Location = new System.Drawing.Point(360, 84);
            this.tbTim.Name = "tbTim";
            this.tbTim.Size = new System.Drawing.Size(221, 26);
            this.tbTim.TabIndex = 2;
            this.tbTim.TextChanged += new System.EventHandler(this.tbTim_TextChanged);
            // 
            // btIn
            // 
            this.btIn.Location = new System.Drawing.Point(640, 79);
            this.btIn.Name = "btIn";
            this.btIn.Size = new System.Drawing.Size(89, 37);
            this.btIn.TabIndex = 3;
            this.btIn.Text = "IN";
            this.btIn.UseVisualStyleBackColor = true;
            this.btIn.Click += new System.EventHandler(this.btIn_Click);
            // 
            // dgvKhach
            // 
            this.dgvKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvKhach.Location = new System.Drawing.Point(0, 151);
            this.dgvKhach.Name = "dgvKhach";
            this.dgvKhach.RowHeadersWidth = 51;
            this.dgvKhach.RowTemplate.Height = 24;
            this.dgvKhach.Size = new System.Drawing.Size(892, 275);
            this.dgvKhach.TabIndex = 4;
            // 
            // frmDSKhachThueTrongPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(892, 426);
            this.Controls.Add(this.dgvKhach);
            this.Controls.Add(this.btIn);
            this.Controls.Add(this.tbTim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDSKhachThueTrongPhong";
            this.Text = "frmDSKhachThueTrongPhong";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTim;
        private System.Windows.Forms.Button btIn;
        private System.Windows.Forms.DataGridView dgvKhach;
    }
}