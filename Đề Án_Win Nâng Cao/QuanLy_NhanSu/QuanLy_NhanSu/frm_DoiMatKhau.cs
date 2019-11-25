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
            txt_NhapLaiMatKhau.PasswordChar = '*';
            txt_NhapMatKhau.PasswordChar = '*';
        }

        private void btn_MatKhauMoi_Click(object sender, EventArgs e)
        {
            if (txt_NhapMatKhau.PasswordChar.ToString().CompareTo("*") == 0)
            {
                txt_NhapMatKhau.PasswordChar = '\0';
            }
            else
            {
                txt_NhapMatKhau.PasswordChar = '*';
            }
        }

        private void btn_DoiMatKhau_Click(object sender, EventArgs e)
        {
            DoiMatKhau();
        }

        private void DoiMatKhau()
        {
            if(txt_MK.Text.Length>0&& txt_NhapMatKhau.Text.Length>0&&txt_NhapLaiMatKhau.Text.Length>0)
            {
                if(txt_NhapLaiMatKhau.Text.Trim().ToString() == txt_NhapMatKhau.Text.Trim().ToString())
                {
                    try
                    {
                       
                        if (Properties.Settings.Default.pass.Trim().ToString() != txt_MK.Text.Trim().ToString())
                        {
                            MessageBox.Show("Sai mật khẩu");
                        }
                        else
                        {
                            tAIKHOANTableAdapter.Fill(dataSetQLNS.TAIKHOAN);
                            DataSetQLNS.TAIKHOANRow data = dataSetQLNS.TAIKHOAN.FindByMANV(Properties.Settings.Default.user);
                            data.MATKHAU = txt_NhapMatKhau.Text.Trim().ToString();
                            tAIKHOANTableAdapter.Update(this.dataSetQLNS.TAIKHOAN);
                            Properties.Settings.Default.pass = txt_NhapMatKhau.Text.Trim().ToString();
                            MessageBox.Show("Thành công");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Thất bại");
                    }

                }
                else
                {
                    txt_NhapMatKhau.Clear();
                    txt_NhapLaiMatKhau.Clear();
                    MessageBox.Show("Nhập lại MK mới");
                }
            }
            else
            {
                MessageBox.Show("Nhập thiếu dữ liệu");
            }
        }

        private void tAIKHOANBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tAIKHOANBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetQLNS);
        }
    }
}
