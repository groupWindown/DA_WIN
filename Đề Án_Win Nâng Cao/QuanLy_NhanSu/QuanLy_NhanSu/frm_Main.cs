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
            // TODO: This line of code loads data into the 'dataSetQLNS.TAIKHOAN' table. You can move, or remove it, as needed.
            this.tAIKHOANTableAdapter.Fill(this.dataSetQLNS.TAIKHOAN);
            // TODO: This line of code loads data into the 'dataSetQLNS.PHANQUYEN' table. You can move, or remove it, as needed.
            this.pHANQUYENTableAdapter.Fill(this.dataSetQLNS.PHANQUYEN);
            // TODO: This line of code loads data into the 'dataSetQLNS.NHOMNGUOIDUNG' table. You can move, or remove it, as needed.
            this.nHOMNGUOIDUNGTableAdapter.Fill(this.dataSetQLNS.NHOMNGUOIDUNG);
            // TODO: This line of code loads data into the 'dataSetQLNS.NGUOIDUNGNHOMNGUOIDUNG' table. You can move, or remove it, as needed.
            this.nGUOIDUNGNHOMNGUOIDUNGTableAdapter.Fill(this.dataSetQLNS.NGUOIDUNGNHOMNGUOIDUNG);
            // TODO: This line of code loads data into the 'dataSetQLNS.MANHINH' table. You can move, or remove it, as needed.
            this.mANHINHTableAdapter.Fill(this.dataSetQLNS.MANHINH);
            // TODO: This line of code loads data into the 'dataSetQLNS.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.dataSetQLNS.NHANVIEN);
            //load screen 
            DataTable dt = GetNhomNguoiDung(Properties.Settings.Default.user.ToUpper());

            foreach (DataRow item in dt.Rows)
            {
                DataTable dsQuyen = GetMaManHinh(item[1].ToString());
                foreach (DataRow mh in dsQuyen.Rows)
                {
                    FindMenuPhanQuyen(this.ribbonPage_TacVu.Groups, mh[0].ToString(), Convert.ToBoolean(mh[2].ToString()));
                }
            }
         
            Background frm = new Background();
            panel_Main.Controls.Add(frm);

            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = ""; 
        }

   
        public DataTable GetNhomNguoiDung(string str)
        {
            DataTable dt= dataSetQLNS.NGUOIDUNGNHOMNGUOIDUNG;
            DataTable dtR = dt.Clone();
            foreach (DataRow dr in dt.Rows)
            {
                if(dr[0].ToString()==str)
                {
                    dtR.ImportRow(dr);
                }
            }
            return dtR;
         
        }

        
        public DataTable GetMaManHinh(string str)
        {
            DataTable dt = dataSetQLNS.PHANQUYEN;
            DataTable dtR = dt.Clone();
            foreach (DataRow dr in dt.Rows)
            {
                if (dr[1].ToString() == str)
                {
                    dtR.ImportRow(dr);
                }
            }
            return dtR;
            ////using LinQ to get MaManHinh

            //DataGridView nhomND = new DataGridView();

            //var list = (from nhomNguoiDung in linQDataContext.NHOMNGUOIDUNGs
            //           join phanQuyen in linQDataContext.PHANQUYENs
            //           on nhomNguoiDung.MANHOM equals phanQuyen.MANHOM
            //           where nhomNguoiDung.MANHOM == str
            //           select new { phanQuyen.MAMANHINH,
            //           phanQuyen.COQUYEN}).Distinct();

            //DataTable dt = new DataTable();
            //nhomND.DataSource = list;
            //dt = (DataTable)nhomND.DataSource;
            //return dt;
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
            frm_NhapLieu_KT_KL fr = new frm_NhapLieu_KT_KL();
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(fr);
        }

        private void barButtonItem_HoSoUngVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            //if (Program.frmTTUV == null || Program.frmTTUV.IsDisposed)
            //{
            //Program.frmTTUV = new frm_TT_UngVien();

            //}
            frm_TT_UngVien frm = new frm_TT_UngVien();
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(frm);
        }

        private void barButtonItem_HoSoNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_TT_NhanVien frm_TT_NhanVien = new frm_TT_NhanVien();
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(frm_TT_NhanVien);
        }

        private void barButtonItem_ChamCong_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_ChamCong frm_ChamCong = new frm_ChamCong();
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(frm_ChamCong);
        }

        private void barButtonItem_ThongKe_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_ThongKe frm_ThongKe = new frm_ThongKe();
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(frm_ThongKe);
        }

        private void barButtonItem_DoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_DoiMatKhau frm_DoiMatKhau = new frm_DoiMatKhau();
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(frm_DoiMatKhau);
        }

        private void barButtonItem_DangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
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

        private void panel_Main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ribbonControl_Main_Click(object sender, EventArgs e)
        {

        }

        private void nHANVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nHANVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetQLNS);

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
