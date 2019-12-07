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
    public partial class UserControl_Dong_NhanVien : UserControl
    {
        public UserControl_Dong_NhanVien()
        {
            InitializeComponent();
        }
        public UserControl_Dong_NhanVien(string pMaUV, string pTenUV, string pNgayUV, string pSDTUV, string pEMailUV, string pChucVuUV, Image imageUV)
        {

            InitializeComponent();

            lbl_MaUngVienCtrl.Text = pMaUV.ToString();
            lbl_TenUngVien.Text = pTenUV.ToString();
            lbl_NgaySinh.Text = pNgayUV.ToString();
            lbl_SDT.Text = pSDTUV.ToString();
            lbl_Email.Text = pEMailUV.ToString();
            lbl_ChucVuUngTuyen.Text = pChucVuUV.ToString();
            pictureEdit_HinhAnh.Image = imageUV;
        }
        private void UserControl_Dong_NhanVien_Load(object sender, EventArgs e)
        {

        }

        private void lbl_TenUngVien_Click(object sender, EventArgs e)
        {

        }
        int flag = 0;
        private void pictureEdit_HinhAnh_MouseHover(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                this.BackColor = Color.White;
                flag = 1;
            }
        }

        private void lbl_SDT_MouseLeave(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                flag = 0;
                
                this.BackColor = Color.FromArgb(255, 255, 128);
            }
        }

        private void pictureEdit_HinhAnh_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lbl_SDT_MouseClick(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.controldongclickmaNV = this.lbl_MaUngVienCtrl.Text;
        }

        private void lbl_SDT_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            frm_SuaTTNhanVien frm = new frm_SuaTTNhanVien();
            Properties.Settings.Default.NhanVienClick = lbl_MaUngVienCtrl.Text.Trim().ToString();
            frm.ShowDialog();
        }
    }
}
