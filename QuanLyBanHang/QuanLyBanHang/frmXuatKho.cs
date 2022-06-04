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
    public partial class frmXuatKho : Form
    {
        
        SqlConnection ketnoi = new SqlConnection();
        SqlCommand lenh = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dtPhieuXuat = new DataTable("XuatKho");
        int ViTri = -1;
        DataTable dtChiTiet = new DataTable("XuatKho_CT");

        SqlCommand lenh2 = new SqlCommand();
        SqlDataAdapter da2 = new SqlDataAdapter();
        public frmXuatKho()
        {
            InitializeComponent();
            ketnoi.ConnectionString = Properties.Settings.Default.ChuoiKetNoi;
            ketnoi.Open();
            lenh.Connection = ketnoi;
            lenh2.Connection = ketnoi;
        }
        void NapMaKH()
        {
            lenh2.CommandText = "Select MaKH,TenKH from KHACHHANG";
            lenh2.Parameters.Clear();
            da2.SelectCommand = lenh2;
            DataTable dt = new DataTable("KH");
            da2.Fill(dt);
            cboMaKH.DataSource = dt;
            cboMaKH.ValueMember = "MaKH";
            cboMaKH.DisplayMember = "TenKH";
        }

        void NapMaHang()
        {
            lenh2.CommandText = "Select MaHang,TenHang from HangHOA";
            lenh2.Parameters.Clear();
            da2.SelectCommand = lenh2;
            DataTable dt = new DataTable("HH");
            da2.Fill(dt);
            MaHang.DataSource = dt;
            MaHang.ValueMember = "MaHang";
            MaHang.DisplayMember = "TenHang";
        }

        void NapChiTietPhieuXuat(string spx)
        {
            NapMaHang();
            lenh.CommandText = "Select *,SLXuat*DGXuat as ThanhTien from XUATKHO_CT where SoPhieuX = @spx";
            lenh.Parameters.Clear();
            lenh.Parameters.AddWithValue("@spx", spx);
            da.SelectCommand = lenh;
            dtChiTiet.Clear();
            da.Fill(dtChiTiet);
            dataGridView1.DataSource = dtChiTiet;
            double tongtien = 0;
            for(int i=0;i<dtChiTiet.Rows.Count;i++)
            {
                double sl = Convert.ToDouble(dtChiTiet.Rows[i]["SLXuat"]);
                double dg = Convert.ToDouble(dtChiTiet.Rows[i]["DGXuat"]);
                tongtien += sl * dg;
            }
            txtTongTien.Text = tongtien.ToString();
        }

        void NapMotPhieuXuat(string spx)
        {
            lenh2.CommandText = "Select * from XUATKHO where SoPhieuX=@spx";
            lenh2.Parameters.Clear();
            lenh2.Parameters.AddWithValue("@spx", spx);
            da2.SelectCommand = lenh2;
            DataTable dt = new DataTable("MOTPHIEUXUAT");
            da2.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtSoPhieuX.Text = dt.Rows[0]["SoPhieuX"].ToString();
                txtNgayXuat.Value = Convert.ToDateTime(dt.Rows[0]["NgayXuat"]);
                cboMaKH.SelectedValue = dt.Rows[0]["MaKH"].ToString();
                txtLyDoXuat.Text = dt.Rows[0]["LyDoXuat"].ToString();
            }
        }

        void NapDanhSachPhieuXuat()
        {
            lenh2.CommandText = "Select * from XUATKHO";
            lenh2.Parameters.Clear();
            da2.SelectCommand = lenh2;
            dtPhieuXuat.Clear();
            da2.Fill(dtPhieuXuat);
        }

        void DiChuyenDenPhieu(int i)
        {
            txtSoPhieuX.Text = dtPhieuXuat.Rows[i]["SoPhieuX"].ToString();
            txtNgayXuat.Value = Convert.ToDateTime(dtPhieuXuat.Rows[i]["NgayXuat"]);
            cboMaKH.SelectedValue = dtPhieuXuat.Rows[i]["MaKH"].ToString();
            txtLyDoXuat.Text = dtPhieuXuat.Rows[i]["LyDoXuat"].ToString();
        }
        private void frmXuatKho_Load(object sender, EventArgs e)
        {
            NapMaKH();
            NapDanhSachPhieuXuat();
            if (dtPhieuXuat.Rows.Count > 0)
            {
                ViTri = 0;
                DiChuyenDenPhieu(ViTri);
                NapChiTietPhieuXuat(txtSoPhieuX.Text);
            }
        }

        private void btnDauTien_Click(object sender, EventArgs e)
        {
            if (dtPhieuXuat.Rows.Count > 0)
            {
                ViTri = 0;
                DiChuyenDenPhieu(ViTri);
                NapChiTietPhieuXuat(txtSoPhieuX.Text);
            }
        }

        private void btnCuoiCung_Click(object sender, EventArgs e)
        {
            if (ViTri < dtPhieuXuat.Rows.Count - 1)
            {
                ViTri = dtPhieuXuat.Rows.Count - 1;
                DiChuyenDenPhieu(ViTri);
                NapChiTietPhieuXuat(txtSoPhieuX.Text);
            }
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            if (ViTri > 0)
            {
                ViTri -= 1;
                DiChuyenDenPhieu(ViTri);
                NapChiTietPhieuXuat(txtSoPhieuX.Text);
            }
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            if (ViTri < dtPhieuXuat.Rows.Count - 1)
            {
                ViTri += 1;
                DiChuyenDenPhieu(ViTri);
                NapChiTietPhieuXuat(txtSoPhieuX.Text);
            }
        }

        private void btnChonPhieu_Click(object sender, EventArgs e)
        {
            frmDanhSachPhieu f = new frmDanhSachPhieu();
            f.ShowDialog();
            if (clsThuVien.SoPhieuXuat != "")
            {
                NapMotPhieuXuat(clsThuVien.SoPhieuXuat);
                NapChiTietPhieuXuat(clsThuVien.SoPhieuXuat);
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            lenh.CommandText = "Select XUATKHO.SoPhieuX,NgayXuat,XUATKHO.MaKH,XUATKHO_CT.MaHang,SLXuat,DGXuat,SLXuat*DGXuat as ThanhTien,HANGHOA.TenHang "
                + " From XUATKHO Inner Join XUATKHO_CT On XUATKHO.SoPhieuX=XUATKHO_CT.SoPhieuX"
                + " Inner Join HANGHOA On XUATKHO_CT.MaHang=HANGHOA.MaHang"
                + " Where XUATKHO_CT.SoPhieuX=@SoPhieuX";
            lenh.Parameters.Clear();
            lenh.Parameters.AddWithValue("@SoPhieuX", txtSoPhieuX.Text);
            da.SelectCommand = lenh;
            DataTable dt = new DataTable("InXuatKho");
            da.Fill(dt);
            rptXuatKho xuatkhoin = new rptXuatKho();
            xuatkhoin.SetDataSource(dt);
            frmInBaoCao f = new frmInBaoCao();
            f.crystalReportViewer1.ReportSource = xuatkhoin;
            f.ShowDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            lenh2.CommandText = "Insert into XUATKHO(SoPhieuX,NgayXuat,MaKH,LyDoXuat)"
    + " Values(@SoPhieuX,@NgayXuat,@MaKH,@LyDoXuat)";
            lenh2.Parameters.Clear();
            lenh2.Parameters.AddWithValue("@SoPhieuX", txtSoPhieuX.Text);
            lenh2.Parameters.AddWithValue("@NgayXuat", txtNgayXuat.Value);
            lenh2.Parameters.AddWithValue("@MaKH", cboMaKH.SelectedValue);
            lenh2.Parameters.AddWithValue("@LyDoXuat", txtLyDoXuat.Text);
            lenh2.ExecuteNonQuery();
            MessageBox.Show("Bạn vừa thêm mới một phiếu nhập kho");
            NapDanhSachPhieuXuat();
            NapChiTietPhieuXuat(txtSoPhieuX.Text);
        }

        private void dataGridView1_UserAddedRow_1(object sender, DataGridViewRowEventArgs e)
        {
            dataGridView1.Rows[e.Row.Index - 1].Cells["SoPhieuX"].Value = txtSoPhieuX.Text;
        }

        private void dataGridView1_RowValidated_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Tính thành tiền
                double sl = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells["SLXuat"].Value);
                double dg = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells["DGXuat"].Value);
                double tt = sl * dg;
                dataGridView1.Rows[e.RowIndex].Cells["ThanhTien"].Value = tt;
                //Cập nhật dữ liệu bảng XUATKHO_CT
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Update(dtChiTiet);
            }
            catch { }
        }
    }
}
