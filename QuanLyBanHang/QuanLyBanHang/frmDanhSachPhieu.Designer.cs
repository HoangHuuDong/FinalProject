
namespace QuanLyBanHang
{
    partial class frmDanhSachPhieu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SoPhieuX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LyDoXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoPhieuX,
            this.MaKH,
            this.NgayXuat,
            this.LyDoXuat});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1100, 548);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // SoPhieuX
            // 
            this.SoPhieuX.DataPropertyName = "SoPhieuX";
            this.SoPhieuX.HeaderText = "Số Phiếu X";
            this.SoPhieuX.MinimumWidth = 8;
            this.SoPhieuX.Name = "SoPhieuX";
            this.SoPhieuX.ReadOnly = true;
            this.SoPhieuX.Width = 150;
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã KH";
            this.MaKH.MinimumWidth = 8;
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            this.MaKH.Width = 150;
            // 
            // NgayXuat
            // 
            this.NgayXuat.DataPropertyName = "NgayXuat";
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            this.NgayXuat.DefaultCellStyle = dataGridViewCellStyle3;
            this.NgayXuat.HeaderText = "Ngày xuất";
            this.NgayXuat.MinimumWidth = 8;
            this.NgayXuat.Name = "NgayXuat";
            this.NgayXuat.ReadOnly = true;
            this.NgayXuat.Width = 150;
            // 
            // LyDoXuat
            // 
            this.LyDoXuat.DataPropertyName = "LyDoXuat";
            this.LyDoXuat.HeaderText = "Lý do xuất";
            this.LyDoXuat.MinimumWidth = 8;
            this.LyDoXuat.Name = "LyDoXuat";
            this.LyDoXuat.ReadOnly = true;
            this.LyDoXuat.Width = 150;
            // 
            // frmDanhSachPhieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 548);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmDanhSachPhieu";
            this.Text = "frmDanhSachPhieu";
            this.Load += new System.EventHandler(this.frmDanhSachPhieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhieuX;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn LyDoXuat;
    }
}