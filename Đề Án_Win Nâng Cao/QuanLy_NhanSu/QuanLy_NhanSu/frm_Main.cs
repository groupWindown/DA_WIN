using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
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
    public partial class frm_Main : Form
    {
        
        public frm_Main()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void barCheckItem1_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barEditItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

      

        private void frm_Main_Load(object sender, EventArgs e)
        {
            ////load screen 
            //DataTable dt = GetNhomNguoiDung(Properties.Settings.Default.user);

            //foreach (DataRow item in dt.Rows)
            //{
            //    DataTable dsQuyen = GetMaManHinh(item[0].ToString());
            //    foreach (DataRow mh in dsQuyen.Rows)
            //    {
            //        FindMenuPhanQuyen(this.ribbonPage_TacVu.Groups, mh[0].ToString(), Convert.ToBoolean(mh[1].ToString()));
            //    }
            //}





        }

   
        LinQDataContext linQDataContext = new LinQDataContext();
        public DataTable GetNhomNguoiDung(string str)
        {
            //using LinQ to get MaNhom
            
            DataGridView nhomND = new DataGridView();

            var list = (from danhSachNhom in linQDataContext.NGUOIDUNGNHOMNGUOIDUNGs
                       join taikhoan in linQDataContext.TAIKHOANs
                       on danhSachNhom.MANV equals taikhoan.MANV
                       where taikhoan.MANV == str
                       select new { danhSachNhom.MANHOM }).Distinct();

            DataTable dt = new DataTable();
            nhomND.DataSource = list;
            dt = (DataTable)nhomND.DataSource;

            return dt;
        }

        
        public DataTable GetMaManHinh(string str)
        {
            //using LinQ to get MaManHinh
           
            DataGridView nhomND = new DataGridView();

            var list = (from nhomNguoiDung in linQDataContext.NHOMNGUOIDUNGs
                       join phanQuyen in linQDataContext.PHANQUYENs
                       on nhomNguoiDung.MANHOM equals phanQuyen.MANHOM
                       where nhomNguoiDung.MANHOM == str
                       select new { phanQuyen.MAMANHINH }).Distinct();

            DataTable dt = new DataTable();
            nhomND.DataSource = list;
            dt = (DataTable)nhomND.DataSource;
            return dt;
        }


        private void FindMenuPhanQuyen(RibbonPageGroupCollection mnuItems, string pScreenName, bool pEnable)
        {
            foreach (RibbonPageGroup menu in mnuItems)
            {
                if (string.Equals(pScreenName, menu.Tag))
                {
                    menu.Enabled = pEnable;
                    menu.Visible = pEnable;
                }
            }
        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_NhapLieu frm = new frm_NhapLieu();
            panel_Main.Controls.Add(frm);
        }

        private void barButtonItem_HoSoUngVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_TT_UngVien frm_TT_UngVien = new frm_TT_UngVien();
            panel_Main.Controls.Add(frm_TT_UngVien);
        }

        private void barButtonItem_HoSoNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_TT_NhanVien frm_TT_NhanVien = new frm_TT_NhanVien();
            panel_Main.Controls.Add(frm_TT_NhanVien);
        }

        private void barButtonItem_ChamCong_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_ChamCong frm_ChamCong = new frm_ChamCong();
            panel_Main.Controls.Add(frm_ChamCong);
        }

        private void barButtonItem_ThongKe_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_ThongKe frm_ThongKe = new frm_ThongKe();
            panel_Main.Controls.Add(frm_ThongKe);
        }

        private void barButtonItem_DoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_DoiMatKhau frm_DoiMatKhau = new frm_DoiMatKhau();
            panel_Main.Controls.Add(frm_DoiMatKhau);
        }

        private void barButtonItem_DangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Application.Exit();
        }

        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Đăng xuất", "Exit!!!!!!!!!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)==DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void frm_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.frmDangNhap.Show();
        }
        //private bool CheckAllMenuChildVisible(RibbonPageGroupCollection mnuItems)
        //{
        //    foreach (RibbonPageGroup menuItem in mnuItems)
        //    {
        //        if (menuItem is RibbonPageGroup && menuItem.Enabled)
        //        {
        //            return true;
        //        }
        //        else if (menuItem is RibbonPageGroup)
        //        {
        //            continue;
        //        }
        //    }
        //    return false;
        //}

    }
}
