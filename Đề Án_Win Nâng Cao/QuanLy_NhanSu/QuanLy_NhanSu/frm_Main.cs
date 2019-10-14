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

        private void panel1_Paint(object sender, PaintEventArgs e)
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

   

        public DataTable GetNhomNguoiDung(string str)
        {
            //using LinQ to get MaNhom
            LinQDataContext linQDataContext = new LinQDataContext();
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
            LinQDataContext linQDataContext = new LinQDataContext();
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
