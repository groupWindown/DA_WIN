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
    public partial class frm_DoiMatKhau : UserControl
    {
        public frm_DoiMatKhau()
        {
            InitializeComponent();
            txt_NhapLaiMatKhau.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_NhapLaiMatKhau.PasswordChar.ToString().CompareTo("*") == 0)
            {
                txt_NhapLaiMatKhau.PasswordChar = '\0';
            }
            else
            {
                txt_NhapLaiMatKhau.PasswordChar = '*';
            }
        }

        private void frm_DoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void btn_MatKhauMoi_Click(object sender, EventArgs e)
        {

        }
    }
}
