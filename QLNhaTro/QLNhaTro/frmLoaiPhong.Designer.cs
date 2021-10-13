
namespace QLNhaTro
{
    partial class frmLoaiPhong
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
            this.dgvLoai = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoai)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(301, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ LOẠI PHÒNG";
            // 
            // dgvLoai
            // 
            this.dgvLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoai.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLoai.Location = new System.Drawing.Point(0, 77);
            this.dgvLoai.Name = "dgvLoai";
            this.dgvLoai.RowHeadersWidth = 51;
            this.dgvLoai.RowTemplate.Height = 24;
            this.dgvLoai.Size = new System.Drawing.Size(892, 351);
            this.dgvLoai.TabIndex = 1;
            this.dgvLoai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoai_CellClick);
            this.dgvLoai.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoai_CellValueChanged);
            // 
            // frmLoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(892, 428);
            this.Controls.Add(this.dgvLoai);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLoaiPhong";
            this.Text = "frmLoaiPhong";
            this.Load += new System.EventHandler(this.frmLoaiPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLoai;
    }
}