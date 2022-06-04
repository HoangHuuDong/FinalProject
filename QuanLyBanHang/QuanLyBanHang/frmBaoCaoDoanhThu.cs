using CrystalDecisions.CrystalReports.Engine;
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
    public partial class frmBaoCaoDoanhThu : Form
    {
        QuanLyBanHangEntities db = new QuanLyBanHangEntities();
        class NXT
        {
            public string MaHang { get; set; }
            public string TenHang { get; set; }
            public int SLNhap { get; set; }
            public int SLXuat { get; set; }
            public int DGNhap { get; set; }
            public int DGXuat { get; set; }
            public double DoanhThu { get; set; }

        }
        public frmBaoCaoDoanhThu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime td = dtThoiDiem.Value;
            var hop = db.NHAPKHO_CT.Where(nk => nk.NHAPKHO.NgayNhap <= td )
                .Select(nk => new NXT { MaHang = nk.MaHang, TenHang = nk.HANGHOA.TenHang,DoanhThu=-nk.DGNhap*nk.SLNhap,SLNhap=nk.SLNhap })
                .Union
                (
                db.XUATKHO_CT.Where(xk => xk.XUATKHO.NgayXuat <= td)
                .Select(xk => new NXT { MaHang = xk.MaHang, TenHang = xk.HANGHOA.TenHang,DoanhThu=xk.DGXuat*xk.SLXuat,SLNhap=-xk.SLXuat })
                );
            var kq = hop.GroupBy(t => new { t.MaHang, t.TenHang })
                .Select(t => new { t.Key.MaHang, t.Key.TenHang,SLNhap=t.Sum(tt=>tt.SLNhap),DoanhThu = t.Sum(tt=>tt.DoanhThu) }).ToList();
            rptDoanhThu r = new rptDoanhThu();
            TextObject txtTD = r.Section1.ReportObjects["txtThoiDiem"] as TextObject;
            r.SetDataSource(kq);
            frmInDoanhThu f = new frmInDoanhThu();
            f.crystalReportViewer1.ReportSource = r;
            f.ShowDialog();
        }
    }
}
