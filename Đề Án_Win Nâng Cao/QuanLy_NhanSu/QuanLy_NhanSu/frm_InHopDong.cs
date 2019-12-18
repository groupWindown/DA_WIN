using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_NhanSu
{
    public partial class frm_InHopDong : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frm_InHopDong(string tennv, string so, string chucvu, string loaihopdong, DateTime ngaybd, DateTime ngaykt, string luong)
        {
            InitializeComponent();
            XtraReport3 x = new XtraReport3( tennv,  so,  chucvu,  loaihopdong,  ngaybd,  ngaykt,  luong);
            documentViewer1.DocumentSource = x;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
  
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        
        }
    }
}
