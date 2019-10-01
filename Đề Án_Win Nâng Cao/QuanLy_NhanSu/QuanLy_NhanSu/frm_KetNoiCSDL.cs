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
        CAUHINH cauhinh = new CAUHINH();
        public frm_KetNoiCSDL()
        {
            InitializeComponent();
        }

        private void frm_KetNoiCSDL_Load(object sender, EventArgs e)
        {
            DataTable dataTable= cauhinh.GetServerName();
            cbb_SeverName.Items.Clear();
            foreach (System.Data.DataRow row in dataTable.Rows)
            {
                foreach (System.Data.DataColumn col in dataTable.Columns)
                {
                    cbb_SeverName.Items.Add(row[col]);
                }
            }
        }
      

        private void btn_Decline_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Accept_Click(object sender, EventArgs e)
        {
            string bien = "Vui lòng điền ";
            if (cbb_SeverName.Text.Length == 0)
                bien += "SeverName ";
            if (txt_Password.Text.Length == 0)
                bien += "Password ";
            if (txt_UserName.Text.Length == 0)
                bien += "UserName ";
            if (cbb_Database.Text.Length == 0)
                bien += "DataBase ";
            MessageBox.Show(bien);
        }

        private void cbb_SeverName_TextChanged(object sender, EventArgs e)
        {
            if (CheckedBeforSearchNameDB())
            {
                cbb_Database.Items.Clear();
                List<string> _list = cauhinh.GetDatabaseName(cbb_SeverName.Text,txt_UserName.Text, txt_Password.Text);
                if (_list == null)
                {
                    return;
                }
                foreach (string item in _list)
                {
                    cbb_Database.Items.Add(item);
                }
            }
        }
        private bool CheckedBeforSearchNameDB()
        {
            if (cbb_SeverName.Text.Length > 0 && txt_Password.Text.Length > 0 && txt_UserName.Text.Length > 0)
                return true;
            return false;
        }
    }
}
