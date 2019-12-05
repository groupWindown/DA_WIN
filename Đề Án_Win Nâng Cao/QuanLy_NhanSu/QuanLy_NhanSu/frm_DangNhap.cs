using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_NhanSu
{
    public partial class frm_DangNhap : Form
    {

        CAUHINH cauhinh = new CAUHINH();
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
                        if (cauhinh.Check_Config() == 0)
                        {
                            Properties.Settings.Default.user = txt_User.Text.ToUpper();
                            Properties.Settings.Default.pass = txt_Password.Text.ToUpper();
                            ProcessLogin();// Cấu hình phù hợp xử lý đăng nhập
                        }
                        if (cauhinh.Check_Config() == 1)
                        {
                            MessageBox.Show("Chuỗi cấu hình không tồn tại");// Xử lý cấu hình
                            ProcessConfig();
                        }
                        if (cauhinh.Check_Config() == 2)
                        {
                            MessageBox.Show("Chuỗi cấu hình không phù hợp");// Xử lý cấu hình
                            ProcessConfig();
                        }

                   
                        
                    }
                }
            }
        }
        //đúng chuổi cấu hình
        public void ProcessLogin()
        {
            int result;
            result = cauhinh.Check_User(txt_User.Text, txt_Password.Text);
            // Wrong username or pass
            if (result == 0)//không hợp lệ (Invalid)
            {
                MessageBox.Show("Sai " + label1.Text + " Hoặc " + label2.Text);
                return;
            }
            // Account had been disabled
            else if (result == -1)//bị khóa (Disabled)
            {
                MessageBox.Show("Tài khoản bị khóa");
                return;
            }
            // Account had been success
            if (Program.frmMain == null || Program.frmMain.IsDisposed)
            {
                Program.frmMain = new frm_Main();
            }
            this.Visible = false;
            txt_User.Clear();
            txt_Password.Clear();
            Program.frmMain.Show();
        }

        //sai chuổi câu hình, xử lý chuổi
        public void ProcessConfig()
        {
            this.Hide();
            frm_KetNoiCSDL frm = new frm_KetNoiCSDL();
            frm.ShowDialog();
            
        }

        private void txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)//phim enter
            {
                e.Handled = true;
                btn_DangNhap.PerformClick();
            }
        }
    }
}
