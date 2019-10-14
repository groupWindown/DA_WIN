using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_NhanSu
{
    public static class NguoiDung
    {
        public static List<string> GetMaNhomNguoiDung(string maNguoiDung)
        {
            List<string> list = new List<string>();

            //SqlDataAdapter daUser = new SqlDataAdapter("", Properties.Settings.Default.DA_WIN_NANGCAOConnectionString);
            //DataTable dt = new DataTable();
            //daUser.Fill(dt);
            ////if (dt.Rows.Count == 0)
            return list;
        }
        public static DataTable GetMaManHinh(string item)
        {
            DataTable list = new DataTable();


            return list;
        }
    }
}
