using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_NhanSu
{
    public partial class UserControl_Dong_UngVien : UserControl
    {
        public UserControl_Dong_UngVien()
        {
            InitializeComponent();
        }

        private void UserControl_Dong_UngVien_Load(object sender, EventArgs e)
        {

        }

        private void UserControl_Dong_UngVien_MouseClick(object sender, MouseEventArgs e)
        {
            frm_Sua_ThemMoiNV_UngVien frm = new frm_Sua_ThemMoiNV_UngVien();
            Properties.Settings.Default.UngVienClick = lbl_MaUngVienCtrl.Text.Trim().ToString();
            frm.ShowDialog();
        }
    }
}
