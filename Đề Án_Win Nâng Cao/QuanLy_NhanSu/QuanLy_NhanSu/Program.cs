using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_NhanSu
{
    public static class Program
    {

        public static frm_DangNhap frmDangNhap;
        public static frm_Main frmMain;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
       
        public static void Main()
        {
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_Main());
        }
        
    }
}
