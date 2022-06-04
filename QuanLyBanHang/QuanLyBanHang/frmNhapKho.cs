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
    public partial class frmNhapKho : Form
    {
        SqlConnection ketnoi = new SqlConnection();
        SqlCommand lenh = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dtPhieuNhap = new DataTable("NhapKho");
        int ViTri = -1;
        DataTable dtChiTiet = new DataTable("NhapKho_CT");

        SqlCommand lenh2 = new SqlCommand();
        SqlDataAdapter da2 = new SqlDataAdapter();
        public frmNhapKho()
        {
            InitializeComponent();
            ketnoi.ConnectionString = Properties.Settings.Default.ChuoiKetNoi;
            ketnoi.Open();
            lenh.Connection = ketnoi;
            lenh2.Connection = ketnoi;
        }

        void NapMaNV()
        {
            lenh2.CommandText = "Select MaKH,TenKH from KHACHHANG";
            lenh2.Parameters.Clear();
            da2.SelectCommand = lenh2;
            DataTable dt = new DataTable("KH");
            da2.Fill(dt);
            cboMaNV.DataSource = dt;
            cboMaNV.ValueMember = "MaKH";
            cboMaNV.DisplayMember = "TenKH";
        }

        void NapMaHang()
        {
            lenh2.CommandText = "Select MaHang,TenHang from HANGHOA";
            lenh2.Parameters.Clear();
            da2.SelectCommand = lenh2;
            DataTable dt = new DataTable("HH");
            da2.Fill(dt);
            MaHang.DataSource = dt;
            MaHang.ValueMember = "MaHang";
            MaHang.DisplayMember = "TenHang";
        }

        void NapChiTietPhieuNhap(string spn)
        {
            NapMaHang();
            lenh.CommandText = "Select *,SLNhap*DGNhap as ThanhTien from NHAPKHO_CT where SoPhieuN = @spn";
            lenh.Parameters.Clear();
            lenh.Parameters.AddWithValue("@spn", spn);
            da.SelectCommand = lenh;
            dtChiTiet.Clear();
            da.Fill(dtChiTiet);
            dataGridView1.DataSource = dtChiTiet;
            double tongtien = 0;
            for (int i = 0; i < dtChiTiet.Rows.Count; i++)
            {
                double sl = Convert.ToDouble(dtChiTiet.Rows[i]["SLNhap"]);
                double dg = Convert.ToDouble(dtChiTiet.Rows[i]["DGNhap"]);
                tongtien += sl * dg;
            }
            txtTongTien.Text = tongtien.ToString();
        }

        void NapMotPhieuNhap(string spn)
        {
            lenh2.CommandText = "Select * from NHAPKHO where SoPhieuN=@spn";
            lenh2.Parameters.Clear();
            lenh2.Parameters.AddWithValue("@spn", spn);
            da2.SelectCommand = lenh2;
            DataTable dt = new DataTable("MOTPHIEUNHAP");
            da2.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtSoPhieuN.Text = dt.Rows[0]["SoPhieuN"].ToString();
                txtNgayNhap.Value = Convert.ToDateTime(dt.Rows[0]["NgayNhap"]);
                cboMaNV.SelectedValue = dt.Rows[0]["MaNV"].ToString();
                txtLyDoNhap.Text = dt.Rows[0]["LyDoNhap"].ToString();
            }
        }

        void NapDanhSachPhieuNhap()
        {
            lenh2.CommandText = "Select * from NHAPKHO";
            lenh2.Parameters.Clear();
            da2.SelectCommand = lenh2;
            dtPhieuNhap.Clear();
            da2.Fill(dtPhieuNhap);
        }

        void DiChuyenDenPhieu(int i)
        {
            txtSoPhieuN.Text = dtPhieuNhap.Rows[i]["SoPhieuN"].ToString();
            txtNgayNhap.Value = Convert.ToDateTime(dtPhieuNhap.Rows[i]["NgayNhap"]);
            cboMaNV.SelectedValue = dtPhieuNhap.Rows[i]["MaNV"].ToString();
            txtLyDoNhap.Text = dtPhieuNhap.Rows[i]["LyDoNhap"].ToString();
        }

        private void frmNhapKho_Load(object sender, EventArgs e)
        {
            NapMaNV();
            NapDanhSachPhieuNhap();
            if (dtPhieuNhap.Rows.Count > 0)
            {
                ViTri = 0;
                DiChuyenDenPhieu(ViTri);
                NapChiTietPhieuNhap(txtSoPhieuN.Text);
            }
        }

        private void btnDauTien_Click(object sender, EventArgs e)
        {
            if (dtPhieuNhap.Rows.Count > 0)
            {
                ViTri = 0;
                DiChuyenDenPhieu(ViTri);
                NapChiTietPhieuNhap(txtSoPhieuN.Text);
            }
        }

        private void btnCuoiCung_Click(object sender, EventArgs e)
        {
            if (ViTri < dtPhieuNhap.Rows.Count - 1)
            {
                ViTri = dtPhieuNhap.Rows.Count - 1;
                DiChuyenDenPhieu(ViTri);
                NapChiTietPhieuNhap(txtSoPhieuN.Text);
            }
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            if (ViTri > 0)
            {
                ViTri -= 1;
                DiChuyenDenPhieu(ViTri);
                NapChiTietPhieuNhap(txtSoPhieuN.Text);
            }
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            if (ViTri < dtPhieuNhap.Rows.Count - 1)
            {
                ViTri += 1;
                DiChuyenDenPhieu(ViTri);
                NapChiTietPhieuNhap(txtSoPhieuN.Text);
            }
        }

        private void btnChonPhieu_Click(object sender, EventArgs e)
        {
            frmDanhSachPhieuNhap f = new frmDanhSachPhieuNhap();
            f.ShowDialog();
            if (clsThuVien.SoPhieuNhap != "")
            {
                NapMotPhieuNhap(clsThuVien.SoPhieuNhap);
                NapChiTietPhieuNhap(clsThuVien.SoPhieuNhap);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            lenh2.CommandText = "Insert into NHAPKHO(SoPhieuN,NgayNhap,MaNV,LyDoNhap)"
                + " Values(@SoPhieuN,@NgayNhap,@MaNV,@LyDoNhap)";
            lenh2.Parameters.Clear();
            lenh2.Parameters.AddWithValue("@SoPhieuN", txtSoPhieuN.Text);
            lenh2.Parameters.AddWithValue("@NgayNhap", txtNgayNhap.Value);
            lenh2.Parameters.AddWithValue("@MaNV", cboMaNV.SelectedValue);
            lenh2.Parameters.AddWithValue("@LyDoNhap", txtLyDoNhap.Text);
            lenh2.ExecuteNonQuery();
            MessageBox.Show("Bạn vừa thêm mới một phiếu nhập kho");
            NapDanhSachPhieuNhap();
            NapChiTietPhieuNhap(txtSoPhieuN.Text);
        }

        private void dataGridView1_UserAddedRow_1(object sender, DataGridViewRowEventArgs e)
        {
            dataGridView1.Rows[e.Row.Index - 1].Cells["SoPhieuN"].Value = txtSoPhieuN.Text;
        }

        private void dataGridView1_RowValidated_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                double sl = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells["SLNhap"].Value);
                double dg = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells["DGNhap"].Value);
                double tt = sl * dg;
                dataGridView1.Rows[e.RowIndex].Cells["ThanhTien"].Value = tt;

                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Update(dtChiTiet);
            }
            catch { }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            lenh.CommandText = "Select NHAPKHO.SoPhieuN,NgayNhap,NHAPKHO.MaNV,NHAPKHO_CT.MaHang,SLNhap,DGNhap,SLNhap*DGNhap as ThanhTien,HANGHOA.TenHang "
    + " From NHAPKHO Inner Join NHAPKHO_CT On NHAPKHO.SoPhieuN=NHAPKHO_CT.SoPhieuN"
    + " Inner Join HANGHOA On NHAPKHO_CT.MaHang=HANGHOA.MaHang"
    + " Where NHAPKHO_CT.SoPhieuN=@SoPhieuN";
            lenh.Parameters.Clear();
            lenh.Parameters.AddWithValue("@SoPhieuN", txtSoPhieuN.Text);
            da.SelectCommand = lenh;
            DataTable dt = new DataTable("InNhapKho");
            da.Fill(dt);
            rptNhapKho nhapkhoin = new rptNhapKho();
            nhapkhoin.SetDataSource(dt);
            frmInNhapKho f = new frmInNhapKho();
            f.crystalReportViewer1.ReportSource = nhapkhoin;
            f.ShowDialog();
        }
    }
}
