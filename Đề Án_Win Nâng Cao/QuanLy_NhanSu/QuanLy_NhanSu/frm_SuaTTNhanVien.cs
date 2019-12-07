using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
namespace QuanLy_NhanSu
{
    public partial class frm_SuaTTNhanVien : Form
    {
        BLL_Load bLL_load = new BLL_Load();
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
            dANTOCComboBox.DataSource= bLL_load.BLL_loadDanToc();
            dANTOCComboBox.ValueMember = "MADANTOC";
            dANTOCComboBox.DisplayMember = "TENDANTOC";
            Load_CM_NN();
        }
        private void Load_CM_NN()
        {


            for (int i = 0; i < gridViewCM.DataRowCount; i++)
            {
                //        cHITIETCHUYENMONTableAdapter.Fill(dataSetQLNS.CHITIETCHUYENMON);
                //        DataSetQLNS.CHITIETCHUYENMONRow data = dataSetQLNS.CHITIETCHUYENMON.FindByMACHUYENMONMAUNGVIEN(gridViewCM.GetDataRow(i)["MACHUYENMON"].ToString().Trim(), txt_MaNV.Text.Trim());
                //if (data != null)
                //{
                //    gridViewCM.SelectRow(i);
                //}


            }
            //    for (int i = 0; i < gridViewNN.DataRowCount; i++)
            //    {
            //        cHITIETNGOAINGUTableAdapter.Fill(dataSetQLNS.CHITIETNGOAINGU);
            //        DataSetQLNS.CHITIETNGOAINGURow data = dataSetQLNS.CHITIETNGOAINGU.FindByMANGOAINGUMAUNGVIEN(gridViewNN.GetDataRow(i)["MANGOAINGU"].ToString(), txt_MaNV.Text.Trim());
            //        if (data != null)
            //        {
            //            gridViewNN.SelectRow(i);
            //        }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureEdit1.Image != null && pictureEdit1 != null)
            {
                pictureEdit1.Image.Dispose();
                pictureEdit1.Image = null;
            }
        }

        private void frm_SuaTTNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            refreshPanel();
        }
        private void refreshPanel()
        {
            foreach (System.Windows.Forms.Control ctrl in Program.frmMain.Controls)
            {
                if (ctrl.GetType() == typeof(System.Windows.Forms.Panel))
                {
                    ctrl.Controls.Clear();
                    frm_TT_NhanVien frm = new frm_TT_NhanVien();
                    ctrl.Controls.Add(frm);

                }
            }
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            try
            {
                xtraOpenFileDialog1.ShowDialog();
                xtraOpenFileDialog1.Filter = "JPG FILE (*.jpg)|*.jpg|All files (*.*)|*.*";
                string file = xtraOpenFileDialog1.FileName;
                if (string.IsNullOrEmpty(file))
                {
                    return;
                }
                System.Drawing.Image image = System.Drawing.Image.FromFile(file);
                pictureEdit1.Image = image;
            }
            catch
            { }
        }
    }
}
