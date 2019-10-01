using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_NhanSu
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //------------------------------------------
            frm_DangNhap frmDangNhap = new frm_DangNhap();
            frm_Main frmMain = new frm_Main();
            //------------------------------------------

            Application.Run(frmDangNhap);//dùng cái khác (new +tên form)
        }
    }
}
