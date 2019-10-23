using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Linq.SqlClient;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
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
            SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            System.Data.DataTable table = instance.GetDataSources();
            DataTable dataTable = cauhinh.GetServerName();
            cbb_SeverName.Items.Clear();
            foreach (System.Data.DataRow row in table.Rows)
            {
                foreach (System.Data.DataColumn col in table.Columns)
                {
                    cbb_SeverName.Items.Add(row[col]);
                }
            }
           
            //System.Windows.Forms.SystemInformation.ComputerName
            //System.Environment.GetEnvironmentVariable("COMPUTERNAME")
            //WindowsIdentity.GetCurrent().Name.ToString()
        }

        private void btn_Decline_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Accept_Click(object sender, EventArgs e)
        {
            if (cbb_SeverName.Text.Length > 0 && txt_Password.Text.Length > 0 && txt_UserName.Text.Length > 0 && cbb_Database.Text.Length > 0)
            {
                ChangeConnectionString(cbb_SeverName.Text, cbb_Database.Text, txt_UserName.Text, txt_Password.Text);
                this.Close();
            }
            else
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
        }
        public void ChangeConnectionString(string pServerName, string pDataBase, string pUser, string pPass)
        {
            string chuoi = "Data Source=" + pServerName + ";Initial Catalog=" + pDataBase + ";User ID=" + pUser + ";Password = " + pPass + "";
            SqlConnection sqlHelpers = new SqlConnection(chuoi);
            Configuration configuration =  ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.ConnectionStrings.ConnectionStrings["QuanLy_NhanSu.Properties.Settings.DA_WIN_NANGCAOConnectionString1"].ConnectionString = chuoi;
            configuration.ConnectionStrings.ConnectionStrings["QuanLy_NhanSu.Properties.Settings.DA_WIN_NANGCAOConnectionString1"].ProviderName = "System.Data.SqlClient";
            configuration.Save(ConfigurationSaveMode.Modified);

            //Properties.Settings.Default.DA_WIN_NANGCAOConnectionString1 = chuoi;
            //Properties.Settings.Default.Save();
        }



        private bool CheckedBeforSearchNameDB()
        {
            if (cbb_SeverName.Text.Length > 0 && txt_Password.Text.Length > 0 && txt_UserName.Text.Length > 0)
                return true;
            return false;
        }
        private void loadDatabase()
        {
            if (CheckedBeforSearchNameDB())
            {
                cbb_Database.Items.Clear();
                List<string> _list = cauhinh.GetDatabaseName(cbb_SeverName.Text, txt_UserName.Text, txt_Password.Text);
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


        private void cbb_SeverName_TextChanged(object sender, EventArgs e)
        {
            loadDatabase();
        }
        private void txt_UserName_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {
        }

        private void cbb_SeverName_SelectedValueChanged(object sender, EventArgs e)
        {
            loadDatabase();
        }
    }
}

