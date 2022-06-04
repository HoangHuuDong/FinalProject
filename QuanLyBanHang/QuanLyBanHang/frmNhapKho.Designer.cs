
namespace QuanLyBanHang
{
    partial class frmNhapKho
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
            this.label6 = new System.Windows.Forms.Label();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnChonPhieu = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCuoiCung = new System.Windows.Forms.Button();
            this.btnSau = new System.Windows.Forms.Button();
            this.btnTruoc = new System.Windows.Forms.Button();
            this.btnDauTien = new System.Windows.Forms.Button();
            this.txtLyDoNhap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoPhieuN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SoPhieuN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHang = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SLNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 585);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Design by Đông";
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(770, 28);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(127, 39);
            this.btnIn.TabIndex = 37;
            this.btnIn.Text = " In phiếu";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnChonPhieu
            // 
            this.btnChonPhieu.Location = new System.Drawing.Point(618, 28);
            this.btnChonPhieu.Name = "btnChonPhieu";
            this.btnChonPhieu.Size = new System.Drawing.Size(127, 39);
            this.btnChonPhieu.TabIndex = 36;
            this.btnChonPhieu.Text = "Chọn phiếu";
            this.btnChonPhieu.UseVisualStyleBackColor = true;
            this.btnChonPhieu.Click += new System.EventHandler(this.btnChonPhieu_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(928, 582);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(167, 26);
            this.txtTongTien.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(744, 585);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Tổng tiền phiếu nhập:";
            // 
            // btnCuoiCung
            // 
            this.btnCuoiCung.Location = new System.Drawing.Point(672, 280);
            this.btnCuoiCung.Name = "btnCuoiCung";
            this.btnCuoiCung.Size = new System.Drawing.Size(131, 33);
            this.btnCuoiCung.TabIndex = 32;
            this.btnCuoiCung.Text = "Cuối cùng";
            this.btnCuoiCung.UseVisualStyleBackColor = true;
            this.btnCuoiCung.Click += new System.EventHandler(this.btnCuoiCung_Click);
            // 
            // btnSau
            // 
            this.btnSau.Location = new System.Drawing.Point(511, 280);
            this.btnSau.Name = "btnSau";
            this.btnSau.Size = new System.Drawing.Size(125, 33);
            this.btnSau.TabIndex = 31;
            this.btnSau.Text = "Sau";
            this.btnSau.UseVisualStyleBackColor = true;
            this.btnSau.Click += new System.EventHandler(this.btnSau_Click);
            // 
            // btnTruoc
            // 
            this.btnTruoc.Location = new System.Drawing.Point(349, 280);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(124, 33);
            this.btnTruoc.TabIndex = 30;
            this.btnTruoc.Text = "Trước";
            this.btnTruoc.UseVisualStyleBackColor = true;
            this.btnTruoc.Click += new System.EventHandler(this.btnTruoc_Click);
            // 
            // btnDauTien
            // 
            this.btnDauTien.Location = new System.Drawing.Point(184, 280);
            this.btnDauTien.Name = "btnDauTien";
            this.btnDauTien.Size = new System.Drawing.Size(133, 33);
            this.btnDauTien.TabIndex = 29;
            this.btnDauTien.Text = "Đầu tiên";
            this.btnDauTien.UseVisualStyleBackColor = true;
            this.btnDauTien.Click += new System.EventHandler(this.btnDauTien_Click);
            // 
            // txtLyDoNhap
            // 
            this.txtLyDoNhap.Location = new System.Drawing.Point(249, 171);
            this.txtLyDoNhap.Multiline = true;
            this.txtLyDoNhap.Name = "txtLyDoNhap";
            this.txtLyDoNhap.Size = new System.Drawing.Size(697, 82);
            this.txtLyDoNhap.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Lý do nhập: ";
            // 
            // cboMaNV
            // 
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(249, 117);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(316, 28);
            this.cboMaNV.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Đơn vị cung cấp: ";
            // 
            // txtNgayNhap
            // 
            this.txtNgayNhap.CustomFormat = "dd/MM/yyyy";
            this.txtNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNgayNhap.Location = new System.Drawing.Point(249, 59);
            this.txtNgayNhap.Name = "txtNgayNhap";
            this.txtNgayNhap.Size = new System.Drawing.Size(149, 26);
            this.txtNgayNhap.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Ngày nhập: ";
            // 
            // txtSoPhieuN
            // 
            this.txtSoPhieuN.Location = new System.Drawing.Point(249, 4);
            this.txtSoPhieuN.Name = "txtSoPhieuN";
            this.txtSoPhieuN.Size = new System.Drawing.Size(100, 26);
            this.txtSoPhieuN.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Số phiếu nhập:";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(672, 101);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 44);
            this.btnThem.TabIndex = 40;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoPhieuN,
            this.STT,
            this.MaHang,
            this.SLNhap,
            this.DGNhap,
            this.ThanhTien});
            this.dataGridView1.Location = new System.Drawing.Point(16, 333);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1015, 243);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowValidated_1);
            this.dataGridView1.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserAddedRow_1);
            // 
            // SoPhieuN
            // 
            this.SoPhieuN.DataPropertyName = "SoPhieuN";
            this.SoPhieuN.HeaderText = "Số Phiếu Nhập";
            this.SoPhieuN.MinimumWidth = 8;
            this.SoPhieuN.Name = "SoPhieuN";
            this.SoPhieuN.Width = 150;
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "Số TT";
            this.STT.MinimumWidth = 8;
            this.STT.Name = "STT";
            this.STT.Width = 150;
            // 
            // MaHang
            // 
            this.MaHang.DataPropertyName = "MaHang";
            this.MaHang.HeaderText = "Mã Hàng";
            this.MaHang.MinimumWidth = 8;
            this.MaHang.Name = "MaHang";
            this.MaHang.Width = 200;
            // 
            // SLNhap
            // 
            this.SLNhap.DataPropertyName = "SLNhap";
            this.SLNhap.HeaderText = "Số Lượng";
            this.SLNhap.MinimumWidth = 8;
            this.SLNhap.Name = "SLNhap";
            this.SLNhap.Width = 150;
            // 
            // DGNhap
            // 
            this.DGNhap.DataPropertyName = "DGNhap";
            this.DGNhap.HeaderText = "Đơn Giá";
            this.DGNhap.MinimumWidth = 8;
            this.DGNhap.Name = "DGNhap";
            this.DGNhap.Width = 150;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.MinimumWidth = 8;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Width = 150;
            // 
            // frmNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 612);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnChonPhieu);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCuoiCung);
            this.Controls.Add(this.btnSau);
            this.Controls.Add(this.btnTruoc);
            this.Controls.Add(this.btnDauTien);
            this.Controls.Add(this.txtLyDoNhap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboMaNV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNgayNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoPhieuN);
            this.Controls.Add(this.label1);
            this.Name = "frmNhapKho";
            this.Text = "frmNhapKho";
            this.Load += new System.EventHandler(this.frmNhapKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnChonPhieu;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCuoiCung;
        private System.Windows.Forms.Button btnSau;
        private System.Windows.Forms.Button btnTruoc;
        private System.Windows.Forms.Button btnDauTien;
        private System.Windows.Forms.TextBox txtLyDoNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txtNgayNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoPhieuN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhieuN;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}