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
    public partial class frm_SuaTTNhanVien : Form
    {
        public frm_SuaTTNhanVien()
        {
            InitializeComponent();
        }

        private void nHANVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

        }

        private void frm_SuaTTNhanVien_Load(object sender, EventArgs e)
        {

           // Load_CM_NN();
        }
        //private void Load_CM_NN()
        //{
        //    for (int i = 0; i < gridViewCM.DataRowCount; i++)
        //    {
        //        cHITIETCHUYENMONTableAdapter.Fill(dataSetQLNS.CHITIETCHUYENMON);
        //        DataSetQLNS.CHITIETCHUYENMONRow data = dataSetQLNS.CHITIETCHUYENMON.FindByMACHUYENMONMAUNGVIEN(gridViewCM.GetDataRow(i)["MACHUYENMON"].ToString().Trim(), txt_MaNV.Text.Trim());
        //        if (data != null)
        //        {
        //            gridViewCM.SelectRow(i);
        //        }


        //    }
        //    for (int i = 0; i < gridViewNN.DataRowCount; i++)
        //    {
        //        cHITIETNGOAINGUTableAdapter.Fill(dataSetQLNS.CHITIETNGOAINGU);
        //        DataSetQLNS.CHITIETNGOAINGURow data = dataSetQLNS.CHITIETNGOAINGU.FindByMANGOAINGUMAUNGVIEN(gridViewNN.GetDataRow(i)["MANGOAINGU"].ToString(), txt_MaNV.Text.Trim());
        //        if (data != null)
        //        {
        //            gridViewNN.SelectRow(i);
        //        }
        //    }
        //}

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureEdit1.Image != null && pictureEdit1 != null)
            {
                pictureEdit1.Image.Dispose();
                pictureEdit1.Image = null;
            }
        }
    }
}
