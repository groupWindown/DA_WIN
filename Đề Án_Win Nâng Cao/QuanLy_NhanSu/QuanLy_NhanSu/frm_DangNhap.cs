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
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
        }

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if(txt_User.Text.Length==0 && txt_Password.Text.Length==0)
            {
                MessageBox.Show("Chưa nhập tài khoản và mật khẩu, vui lòng nhập!");
            }
            else
            {
                if (txt_User.Text.Length == 0)
                {
                    MessageBox.Show("Chưa nhập tài khoản, vui lòng nhập!");
                }
                else
                {
                    if (txt_Password.Text.Length == 0)
                    {
                        MessageBox.Show("Chưa nhập mật khẩu, vui lòng nhập!");
                    }
                    else
                    {
                        frm_KetNoiCSDL frm = new frm_KetNoiCSDL();
                        frm.ShowDialog();



                    }
                }
            }
        }
    }
}
