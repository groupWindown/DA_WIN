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
    public partial class frm_NhapLieu_KT_KL : Form
    {
        public frm_NhapLieu_KT_KL()
        {
            InitializeComponent();
        }

        private void frm_NhapLieu_KT_KL_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetQLNS.DAOTAO' table. You can move, or remove it, as needed.
            this.dAOTAOTableAdapter.Fill(this.dataSetQLNS.DAOTAO);
            // TODO: This line of code loads data into the 'dataSetQLNS.DS_KYLUAT' table. You can move, or remove it, as needed.
            this.dS_KYLUATTableAdapter.Fill(this.dataSetQLNS.DS_KYLUAT);
            // TODO: This line of code loads data into the 'dataSetQLNS.LOAIKHENTHUONG' table. You can move, or remove it, as needed.
            this.lOAIKHENTHUONGTableAdapter.Fill(this.dataSetQLNS.LOAIKHENTHUONG);

        }
    }
}
