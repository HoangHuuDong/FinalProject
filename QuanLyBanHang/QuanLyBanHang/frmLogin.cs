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
    public partial class frmLogin : Form
    {
        SqlConnection ketnoi = new SqlConnection();
        SqlCommand lenh = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public frmLogin()
        {
            InitializeComponent();
            ketnoi.ConnectionString = Properties.Settings.Default.ChuoiKetNoi;
            ketnoi.Open();
            lenh.Connection = ketnoi;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lenh.CommandText = "Select * from LOGIN where Username=@username and Password=@password";
            lenh.Parameters.Clear();
            lenh.Parameters.AddWithValue("@username", txtTaiKhoan.Text);
            lenh.Parameters.AddWithValue("@password", txtMatKhau.Text);
            da.SelectCommand = lenh;
            dt.Clear();
            da.Fill(dt);
            if (dt.Rows.Count>0)
            {
                MessageBox.Show("Đăng nhập thành công");
                this.Hide();
                Form1 fl = new Form1();
                fl.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }
    }
}
