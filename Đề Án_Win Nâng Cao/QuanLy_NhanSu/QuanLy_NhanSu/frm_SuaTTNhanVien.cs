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
            this.nHANVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetQLNS);

        }

        private void frm_SuaTTNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetQLNS.CHITIETCHUYENMON' table. You can move, or remove it, as needed.
            this.cHITIETCHUYENMONTableAdapter.Fill(this.dataSetQLNS.CHITIETCHUYENMON);
            // TODO: This line of code loads data into the 'dataSetQLNS.CHITIETNGOAINGU' table. You can move, or remove it, as needed.
            this.cHITIETNGOAINGUTableAdapter.Fill(this.dataSetQLNS.CHITIETNGOAINGU);
            // TODO: This line of code loads data into the 'dataSetQLNS.CHUYENMON' table. You can move, or remove it, as needed.
            this.cHUYENMONTableAdapter.Fill(this.dataSetQLNS.CHUYENMON);
            // TODO: This line of code loads data into the 'dataSetQLNS.NGOAINGU' table. You can move, or remove it, as needed.
            this.nGOAINGUTableAdapter.Fill(this.dataSetQLNS.NGOAINGU);
            // TODO: This line of code loads data into the 'dataSetQLNS.TRINHDOHOCVAN' table. You can move, or remove it, as needed.
            this.tRINHDOHOCVANTableAdapter.Fill(this.dataSetQLNS.TRINHDOHOCVAN);
            // TODO: This line of code loads data into the 'dataSetQLNS.TRINHDOTINHOC' table. You can move, or remove it, as needed.
            this.tRINHDOTINHOCTableAdapter.Fill(this.dataSetQLNS.TRINHDOTINHOC);
            // TODO: This line of code loads data into the 'dataSetQLNS.QUOCTICH' table. You can move, or remove it, as needed.
            this.qUOCTICHTableAdapter.Fill(this.dataSetQLNS.QUOCTICH);
            // TODO: This line of code loads data into the 'dataSetQLNS.TONGIAO' table. You can move, or remove it, as needed.
            this.tONGIAOTableAdapter.Fill(this.dataSetQLNS.TONGIAO);
            // TODO: This line of code loads data into the 'dataSetQLNS.PHONGBAN' table. You can move, or remove it, as needed.
            this.pHONGBANTableAdapter.Fill(this.dataSetQLNS.PHONGBAN);
            // TODO: This line of code loads data into the 'dataSetQLNS.CHUCVU' table. You can move, or remove it, as needed.
            this.cHUCVUTableAdapter.Fill(this.dataSetQLNS.CHUCVU);
            // TODO: This line of code loads data into the 'dataSetQLNS.DANTOC' table. You can move, or remove it, as needed.
            this.dANTOCTableAdapter.Fill(this.dataSetQLNS.DANTOC);
            // TODO: This line of code loads data into the 'dataSetQLNS.HOSOTUYENDUNG' table. You can move, or remove it, as needed.
            this.hOSOTUYENDUNGTableAdapter.Fill(this.dataSetQLNS.HOSOTUYENDUNG);
            // TODO: This line of code loads data into the 'dataSetQLNS.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.dataSetQLNS.NHANVIEN);
            Load_CM_NN();
        }
        private void Load_CM_NN()
        {
            for (int i = 0; i < gridViewCM.DataRowCount; i++)
            {
                cHITIETCHUYENMONTableAdapter.Fill(dataSetQLNS.CHITIETCHUYENMON);
                DataSetQLNS.CHITIETCHUYENMONRow data = dataSetQLNS.CHITIETCHUYENMON.FindByMACHUYENMONMAUNGVIEN(gridViewCM.GetDataRow(i)["MACHUYENMON"].ToString().Trim(), txt_MaNV.Text.Trim());
                if (data != null)
                {
                    gridViewCM.SelectRow(i);
                }


            }
            for (int i = 0; i < gridViewNN.DataRowCount; i++)
            {
                cHITIETNGOAINGUTableAdapter.Fill(dataSetQLNS.CHITIETNGOAINGU);
                DataSetQLNS.CHITIETNGOAINGURow data = dataSetQLNS.CHITIETNGOAINGU.FindByMANGOAINGUMAUNGVIEN(gridViewNN.GetDataRow(i)["MANGOAINGU"].ToString(), txt_MaNV.Text.Trim());
                if (data != null)
                {
                    gridViewNN.SelectRow(i);
                }
            }
        }

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
