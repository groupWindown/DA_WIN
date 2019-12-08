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
            
        }

        private void btn_SaThai_Click(object sender, EventArgs e)
        {
            //update tai khoan
            if (!bLL_NhanVien.BLL_KhoaTaiKhoan(Properties.Settings.Default.controldongclickmaNV))
            {
                MessageBox.Show("không có tài khoản để khóa");
                return;
            }
            //update nhan vien
            if (!bLL_NhanVien.BLL_XoaNV(Properties.Settings.Default.controldongclickmaNV))
            {
                MessageBox.Show("lỗi không có nhân viên");
                return;
            }
            //thêm thông tin quản kí nghĩ việc

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
