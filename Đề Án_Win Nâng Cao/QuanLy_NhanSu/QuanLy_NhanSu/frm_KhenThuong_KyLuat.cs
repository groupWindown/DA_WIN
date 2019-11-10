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
    public partial class frm_KhenThuong_KyLuat : UserControl
    {
        public frm_KhenThuong_KyLuat()
        {
            InitializeComponent();
        }

        private void pHONGBANBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pHONGBANBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetQLNS);

        }

        private void frm_KhenThuong_KyLuat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetQLNS.PHONGBAN' table. You can move, or remove it, as needed.
            this.pHONGBANTableAdapter.Fill(this.dataSetQLNS.PHONGBAN);

        }

        private void editFormUserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
