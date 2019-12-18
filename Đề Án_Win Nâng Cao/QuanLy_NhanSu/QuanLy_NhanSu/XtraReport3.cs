using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QuanLy_NhanSu
{
    public partial class XtraReport3 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport3(string tennv, string so, string chucvu, string loaihopdong, DateTime ngaybd, DateTime ngaykt, string luong)
        {
            InitializeComponent();
            this.RequestParameters = false;
            this.Parameters["TenNV"].Value = tennv;
            this.Parameters["So"].Value = so;
            this.Parameters["ChucVu"].Value = chucvu;
            this.Parameters["LoaiHopDong"].Value = loaihopdong;
            this.Parameters["NgayBD"].Value = ngaybd;
            this.Parameters["NgayKT"].Value = ngaykt;
            this.Parameters["Luong"].Value = luong;
            this.Parameters["Ngay"].Value = DateTime.Now.ToString("dd");
            this.Parameters["Thang"].Value = DateTime.Now.ToString("MM");
            this.Parameters["Nam"].Value = DateTime.Now.ToString("yyyy");

        }

    }
}
