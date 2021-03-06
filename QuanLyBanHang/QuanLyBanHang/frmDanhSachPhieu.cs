using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyBanHang
{
    public partial class frmDanhSachPhieu : Form
    {
        SqlConnection ketnoi = new SqlConnection();
        SqlCommand lenh = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        public frmDanhSachPhieu()
        {
            InitializeComponent();
            ketnoi.ConnectionString = Properties.Settings.Default.ChuoiKetNoi;
            ketnoi.Open();
            lenh.Connection = ketnoi;
        }

        void NapDanhSachPhieu()
        {
            lenh.CommandText = "Select * from XUATKHO";
            lenh.Parameters.Clear();
            da.SelectCommand = lenh;
            DataTable dt = new DataTable("DS");
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void frmDanhSachPhieu_Load(object sender, EventArgs e)
        {
            NapDanhSachPhieu();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                clsThuVien.SoPhieuXuat = dataGridView1.SelectedRows[0].Cells["SoPhieuX"].Value.ToString();
                Close();
            }
        }
    }
}
