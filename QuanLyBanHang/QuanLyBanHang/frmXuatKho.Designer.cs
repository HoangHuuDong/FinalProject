
namespace QuanLyBanHang
{
    partial class frmXuatKho
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
            this.txtSoPhieuX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNgayXuat = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cboMaKH = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLyDoXuat = new System.Windows.Forms.TextBox();
            this.btnDauTien = new System.Windows.Forms.Button();
            this.btnTruoc = new System.Windows.Forms.Button();
            this.btnSau = new System.Windows.Forms.Button();
            this.btnCuoiCung = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SoPhieuX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHang = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SLXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnChonPhieu = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số phiếu xuất:";
            // 
            // txtSoPhieuX
            // 
            this.txtSoPhieuX.Location = new System.Drawing.Point(275, 8);
            this.txtSoPhieuX.Name = "txtSoPhieuX";
            this.txtSoPhieuX.Size = new System.Drawing.Size(100, 26);
            this.txtSoPhieuX.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày xuất: ";
            // 
            // txtNgayXuat
            // 
            this.txtNgayXuat.CustomFormat = "dd/MM/yyyy";
            this.txtNgayXuat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNgayXuat.Location = new System.Drawing.Point(275, 63);
            this.txtNgayXuat.Name = "txtNgayXuat";
            this.txtNgayXuat.Size = new System.Drawing.Size(149, 26);
            this.txtNgayXuat.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Khách hàng: ";
            // 
            // cboMaKH
            // 
            this.cboMaKH.FormattingEnabled = true;
            this.cboMaKH.Location = new System.Drawing.Point(275, 121);
            this.cboMaKH.Name = "cboMaKH";
            this.cboMaKH.Size = new System.Drawing.Size(316, 28);
            this.cboMaKH.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lý do xuất: ";
            // 
            // txtLyDoXuat
            // 
            this.txtLyDoXuat.Location = new System.Drawing.Point(275, 175);
            this.txtLyDoXuat.Multiline = true;
            this.txtLyDoXuat.Name = "txtLyDoXuat";
            this.txtLyDoXuat.Size = new System.Drawing.Size(697, 82);
            this.txtLyDoXuat.TabIndex = 7;
            // 
            // btnDauTien
            // 
            this.btnDauTien.Location = new System.Drawing.Point(210, 284);
            this.btnDauTien.Name = "btnDauTien";
            this.btnDauTien.Size = new System.Drawing.Size(133, 33);
            this.btnDauTien.TabIndex = 8;
            this.btnDauTien.Text = "Đầu tiên";
            this.btnDauTien.UseVisualStyleBackColor = true;
            this.btnDauTien.Click += new System.EventHandler(this.btnDauTien_Click);
            // 
            // btnTruoc
            // 
            this.btnTruoc.Location = new System.Drawing.Point(375, 284);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(124, 33);
            this.btnTruoc.TabIndex = 9;
            this.btnTruoc.Text = "Trước";
            this.btnTruoc.UseVisualStyleBackColor = true;
            this.btnTruoc.Click += new System.EventHandler(this.btnTruoc_Click);
            // 
            // btnSau
            // 
            this.btnSau.Location = new System.Drawing.Point(537, 284);
            this.btnSau.Name = "btnSau";
            this.btnSau.Size = new System.Drawing.Size(125, 33);
            this.btnSau.TabIndex = 10;
            this.btnSau.Text = "Sau";
            this.btnSau.UseVisualStyleBackColor = true;
            this.btnSau.Click += new System.EventHandler(this.btnSau_Click);
            // 
            // btnCuoiCung
            // 
            this.btnCuoiCung.Location = new System.Drawing.Point(698, 284);
            this.btnCuoiCung.Name = "btnCuoiCung";
            this.btnCuoiCung.Size = new System.Drawing.Size(131, 33);
            this.btnCuoiCung.TabIndex = 11;
            this.btnCuoiCung.Text = "Cuối cùng";
            this.btnCuoiCung.UseVisualStyleBackColor = true;
            this.btnCuoiCung.Click += new System.EventHandler(this.btnCuoiCung_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoPhieuX,
            this.STT,
            this.MaHang,
            this.SLXuat,
            this.DGXuat,
            this.ThanhTien});
            this.dataGridView1.Location = new System.Drawing.Point(39, 357);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1014, 209);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowValidated_1);
            this.dataGridView1.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserAddedRow_1);
            // 
            // SoPhieuX
            // 
            this.SoPhieuX.DataPropertyName = "SoPhieuX";
            this.SoPhieuX.HeaderText = "Số phiếu xuất";
            this.SoPhieuX.MinimumWidth = 8;
            this.SoPhieuX.Name = "SoPhieuX";
            this.SoPhieuX.Width = 150;
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
            // SLXuat
            // 
            this.SLXuat.DataPropertyName = "SLXuat";
            this.SLXuat.HeaderText = "Số lượng bán";
            this.SLXuat.MinimumWidth = 8;
            this.SLXuat.Name = "SLXuat";
            this.SLXuat.Width = 150;
            // 
            // DGXuat
            // 
            this.DGXuat.DataPropertyName = "DGXuat";
            this.DGXuat.HeaderText = "Đơn giá";
            this.DGXuat.MinimumWidth = 8;
            this.DGXuat.Name = "DGXuat";
            this.DGXuat.Width = 150;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.MinimumWidth = 8;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Width = 150;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(792, 589);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tổng tiền phiếu xuất:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(954, 586);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(167, 26);
            this.txtTongTien.TabIndex = 17;
            // 
            // btnChonPhieu
            // 
            this.btnChonPhieu.Location = new System.Drawing.Point(644, 32);
            this.btnChonPhieu.Name = "btnChonPhieu";
            this.btnChonPhieu.Size = new System.Drawing.Size(127, 39);
            this.btnChonPhieu.TabIndex = 18;
            this.btnChonPhieu.Text = "Chọn phiếu";
            this.btnChonPhieu.UseVisualStyleBackColor = true;
            this.btnChonPhieu.Click += new System.EventHandler(this.btnChonPhieu_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(796, 32);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(127, 39);
            this.btnIn.TabIndex = 19;
            this.btnIn.Text = " In phiếu";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 592);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Design by Đông";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(732, 105);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 44);
            this.btnThem.TabIndex = 41;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmXuatKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 618);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnChonPhieu);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCuoiCung);
            this.Controls.Add(this.btnSau);
            this.Controls.Add(this.btnTruoc);
            this.Controls.Add(this.btnDauTien);
            this.Controls.Add(this.txtLyDoXuat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboMaKH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNgayXuat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoPhieuX);
            this.Controls.Add(this.label1);
            this.Name = "frmXuatKho";
            this.Text = "frmXuatKho";
            this.Load += new System.EventHandler(this.frmXuatKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoPhieuX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtNgayXuat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboMaKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLyDoXuat;
        private System.Windows.Forms.Button btnDauTien;
        private System.Windows.Forms.Button btnTruoc;
        private System.Windows.Forms.Button btnSau;
        private System.Windows.Forms.Button btnCuoiCung;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhieuX;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnChonPhieu;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThem;
    }
}