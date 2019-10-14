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
            LinQDataContext linQDataContext = new LinQDataContext();

            DataGridView nhomND = new DataGridView();

            var list =from danhSachNhom in linQDataContext.NGUOIDUNGNHOMNGUOIDUNGs
                       join taikhoan in linQDataContext.TAIKHOANs
                       on danhSachNhom.MANV equals taikhoan.MANV
                       where taikhoan.MANV == Properties.Settings.Default.user
                       select new { danhSachNhom.MANHOM };

            nhomND.DataSource=list;
            //foreach (string item in nhomND.DataSource)
            //{
            //    DataTable dsQuyen = NguoiDung.GetMaManHinh(item);
            //    foreach (DataRow mh in dsQuyen.Rows)
            //    {
            //        //FindMenuPhanQuyen(this.menuStrip1.Items,mh[0].ToString(), Convert.ToBoolean(mh[1].ToString()));
            //    }
            //}
        }
        private void FindMenuPhanQuyen(ToolStripItemCollection mnuItems, string pScreenName, bool pEnable)
        {
            foreach (ToolStripItem menu in mnuItems)
            {
                if (menu is ToolStripMenuItem &&
                ((ToolStripMenuItem)(menu)).DropDownItems.Count > 0)
                {
                    FindMenuPhanQuyen(((ToolStripMenuItem)(menu)).DropDownItems,
                    pScreenName, pEnable);
                    menu.Enabled =
                    CheckAllMenuChildVisible(((ToolStripMenuItem)(menu)).DropDownItems);
                    menu.Visible = menu.Enabled;
                }
                else if (string.Equals(pScreenName, menu.Tag))
                {
                    menu.Enabled = pEnable;
                    menu.Visible = pEnable;
                }
            }
        }
        private bool CheckAllMenuChildVisible(ToolStripItemCollection mnuItems)
        {
            foreach (ToolStripItem menuItem in mnuItems)
            {
                if (menuItem is ToolStripMenuItem && menuItem.Enabled)
                {
                    return true;
                }
                else if (menuItem is ToolStripSeparator)
                {
                    continue;
                }
            }
            return false;
        }

    }
}
