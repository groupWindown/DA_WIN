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
    public partial class frm_NhapLieu_TrinhDo : Form
    {
        public frm_NhapLieu_TrinhDo()
        {
            InitializeComponent();
        }

        private void frm_NhapLieu_TrinhDo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetQLNS.CHUYENMON' table. You can move, or remove it, as needed.
            this.cHUYENMONTableAdapter.Fill(this.dataSetQLNS.CHUYENMON);
            // TODO: This line of code loads data into the 'dataSetQLNS.TRINHDOTINHOC' table. You can move, or remove it, as needed.
            this.tRINHDOTINHOCTableAdapter.Fill(this.dataSetQLNS.TRINHDOTINHOC);
            // TODO: This line of code loads data into the 'dataSetQLNS.NGOAINGU' table. You can move, or remove it, as needed.
            this.nGOAINGUTableAdapter.Fill(this.dataSetQLNS.NGOAINGU);
            // TODO: This line of code loads data into the 'dataSetQLNS.TRINHDOHOCVAN' table. You can move, or remove it, as needed.
            this.tRINHDOHOCVANTableAdapter.Fill(this.dataSetQLNS.TRINHDOHOCVAN);

        }
    }
}
