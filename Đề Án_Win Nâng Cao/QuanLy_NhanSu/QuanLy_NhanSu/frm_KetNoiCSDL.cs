using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_NhanSu
{
    public partial class frm_KetNoiCSDL : Form
    {
        public frm_KetNoiCSDL()
        {
            InitializeComponent();
        }

        private void frm_KetNoiCSDL_Load(object sender, EventArgs e)
        {
            
        }
        public int Check_Config()
        {
            if (Properties.Settings.Default.DA_WIN_NANGCAOConnectionString == string.Empty)
                return 1;// Chuỗi cấu hình không tồn tại
            SqlConnection _Sqlconn = new SqlConnection(Properties.Settings.Default.DA_WIN_NANGCAOConnectionString);
            try
            {
                if (_Sqlconn.State == System.Data.ConnectionState.Closed)
                    _Sqlconn.Open();
                return 0;// Kết nối thành công chuỗi cấu hình hợp lệ
            }
            catch
            {
                return 2;// Chuỗi không phù hợp
            }
        }
    }
}
