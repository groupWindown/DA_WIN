using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;
namespace QuanLy_NhanSu
{
    public partial class frm_QuanLyNghiViec : Form
    {
        BLL_Load bLL_Load = new BLL_Load();
        BLL_NhanVien bLL_NhanVien = new BLL_NhanVien();
        public frm_QuanLyNghiViec()
        {
            InitializeComponent();
        }

        private void qUANLYNGHIVIECBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

        }

        private void frm_QuanLyNghiViec_Load(object sender, EventArgs e)
        {
            lYDOTextEdit.Size = new Size(345, 200);
            mAQUANLYNGHIVIECTextEdit.Text = bLL_NhanVien.sinhtudongMaQLNV(0);
            mANVTextEdit.Text = Properties.Settings.Default.controldongclickmaNV;
            nGAYNGHIVIECDateEdit.DateTime = DateTime.Parse(DateTime.Now.ToShortDateString());
            nGAYQUYETDINHDateEdit.DateTime = DateTime.Parse(DateTime.Now.ToShortDateString());
            nGUOIKYTextEdit.Text = "";
            lYDOTextEdit.Text = "";
        }

        private void btn_SaThai_Click(object sender, EventArgs e)
        {
            if (mANVTextEdit.Text.Length > 0 && nGAYNGHIVIECDateEdit.DateTime != null && nGAYQUYETDINHDateEdit.DateTime != null && sOQUYETDINHSpinEdit.Text.Length > 0 && nGUOIKYTextEdit.Text.Length > 0 && lYDOTextEdit.Text.Length > 0 && mAQUANLYNGHIVIECTextEdit.Text.Length > 0)
            {
                //update tai khoan
                if (!bLL_NhanVien.BLL_KhoaTaiKhoan(mANVTextEdit.Text))
                {
                    MessageBox.Show("không có tài khoản để khóa");
                    return;
                }
                //update nhan vien
                if (!bLL_NhanVien.BLL_XoaNV(mANVTextEdit.Text))
                {
                    MessageBox.Show("lỗi không có nhân viên");
                    return;
                }
                //thêm thông tin quản lí nghĩ việc
                QUANLYNGHIVIEC qUANLYNGHIVIEC = new QUANLYNGHIVIEC();
                qUANLYNGHIVIEC.MANV = mANVTextEdit.Text;
                qUANLYNGHIVIEC.MAQUANLYNGHIVIEC = mAQUANLYNGHIVIECTextEdit.Text;
                qUANLYNGHIVIEC.NGAYNGHIVIEC = nGAYNGHIVIECDateEdit.DateTime;
                qUANLYNGHIVIEC.NGAYQUYETDINH = nGAYQUYETDINHDateEdit.DateTime;
                qUANLYNGHIVIEC.NGUOIKY = nGUOIKYTextEdit.Text;
                qUANLYNGHIVIEC.LYDO = lYDOTextEdit.Text;
                if (!bLL_NhanVien.ThemQuanLyNghiViec(qUANLYNGHIVIEC))
                {
                    MessageBox.Show("lỗi không thể cho nhân viên '"+ qUANLYNGHIVIEC.MANV + "'nghĩ việc");
                    return;
                }

                MessageBox.Show("Thành công");
                this.Close();
            }
        }

        private void frm_QuanLyNghiViec_FormClosed(object sender, FormClosedEventArgs e)
        {
            endform();
        }
        private void endform()
        {
            foreach (System.Windows.Forms.Control ctrl in Program.frmMain.Controls)
            {
                if (ctrl.GetType() == typeof(System.Windows.Forms.Panel))
                {
                    ctrl.Controls.Clear();
                    frm_TT_NhanVien frm = new frm_TT_NhanVien();
                    ctrl.Controls.Add(frm);
                }
            }
        }

    }
}
