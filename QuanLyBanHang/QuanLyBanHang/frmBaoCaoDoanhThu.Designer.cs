
namespace QuanLyBanHang
{
    partial class frmBaoCaoDoanhThu
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
            this.dtThoiDiem = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn thời điểm báo cáo:";
            // 
            // dtThoiDiem
            // 
            this.dtThoiDiem.CustomFormat = "dd/MM/yyyy";
            this.dtThoiDiem.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtThoiDiem.Location = new System.Drawing.Point(440, 62);
            this.dtThoiDiem.Name = "dtThoiDiem";
            this.dtThoiDiem.Size = new System.Drawing.Size(200, 26);
            this.dtThoiDiem.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(448, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 63);
            this.button1.TabIndex = 2;
            this.button1.Text = "Xem báo cáo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmBaoCaoDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 608);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtThoiDiem);
            this.Controls.Add(this.label1);
            this.Name = "frmBaoCaoDoanhThu";
            this.Text = "frmBaoCaoDoanhThu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtThoiDiem;
        private System.Windows.Forms.Button button1;
    }
}