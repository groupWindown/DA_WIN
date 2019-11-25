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
        public UserControl_Dong_UngVien(string pMaUV, string pTenUV, string pNgayUV, string pSDTUV, string pEMailUV, string pChucVuUV)
        {

            InitializeComponent();

            lbl_MaUngVienCtrl.Text = pMaUV.ToString();
            lbl_TenUngVien.Text = pTenUV.ToString();
            lbl_NgaySinh.Text = pNgayUV.ToString();
            lbl_SDT.Text = pSDTUV.ToString();
            lbl_Email.Text = pEMailUV.ToString();
            lbl_ChucVuUngTuyen.Text = pChucVuUV.ToString();
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
