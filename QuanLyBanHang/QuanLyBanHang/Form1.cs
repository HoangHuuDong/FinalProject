using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void xuấtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXuatKho f = new frmXuatKho();
            f.Show();
        }

        private void nhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhapKho f1 = new frmNhapKho();
            f1.Show();
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoCaoDoanhThu f = new frmBaoCaoDoanhThu();
            f.Show();
        }
    }
}
