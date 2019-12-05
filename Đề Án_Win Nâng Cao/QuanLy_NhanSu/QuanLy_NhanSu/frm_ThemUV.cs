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
    public partial class frm_ThemUV : Form
    {
        public frm_ThemUV()
        {
            InitializeComponent();
        }

        private void hOSOTUYENDUNGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hOSOTUYENDUNGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetQLNS);

        }

        private void frm_ThemNV_TuUV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetQLNS.TONGIAO' table. You can move, or remove it, as needed.
            this.tONGIAOTableAdapter.Fill(this.dataSetQLNS.TONGIAO);
            // TODO: This line of code loads data into the 'dataSetQLNS.QUOCTICH' table. You can move, or remove it, as needed.
            this.qUOCTICHTableAdapter.Fill(this.dataSetQLNS.QUOCTICH);
            // TODO: This line of code loads data into the 'dataSetQLNS.DANTOC' table. You can move, or remove it, as needed.
            this.dANTOCTableAdapter.Fill(this.dataSetQLNS.DANTOC);
            // TODO: This line of code loads data into the 'dataSetQLNS.NGOAINGU' table. You can move, or remove it, as needed.
            this.nGOAINGUTableAdapter.Fill(this.dataSetQLNS.NGOAINGU);
            // TODO: This line of code loads data into the 'dataSetQLNS.CHUYENMON' table. You can move, or remove it, as needed.
            this.cHUYENMONTableAdapter.Fill(this.dataSetQLNS.CHUYENMON);
            // TODO: This line of code loads data into the 'dataSetQLNS.TRINHDOTINHOC' table. You can move, or remove it, as needed.
            this.tRINHDOTINHOCTableAdapter.Fill(this.dataSetQLNS.TRINHDOTINHOC);
            // TODO: This line of code loads data into the 'dataSetQLNS.TRINHDOHOCVAN' table. You can move, or remove it, as needed.
            this.tRINHDOHOCVANTableAdapter.Fill(this.dataSetQLNS.TRINHDOHOCVAN);
            // TODO: This line of code loads data into the 'dataSetQLNS.HOSOTUYENDUNG' table. You can move, or remove it, as needed.
            this.hOSOTUYENDUNGTableAdapter.Fill(this.dataSetQLNS.HOSOTUYENDUNG);
            // add in comboboxGioitinh
            cbo_GioiTinh.Items.Add("Nam");
            cbo_GioiTinh.Items.Add("Nữ");
            cbo_GioiTinh.SelectedIndex=0;

            mAUNGVIENTextEdit.Text = "";
            hOTENTextEdit.Text = "";
            cMNDTextEdit.Text = "";
            nOICAPTextEdit.Text = "";
            nGAYCAPDateEdit.Text = "";
            dANTOCComboBox.Text = "";
            tONGIAOComboBox.Text = "";
            qUOCTICHComboBox.Text = "";
            qUEQUANTextEdit.Text = "";
            nOISINHTextEdit.Text = "";
            dIACHITHUONGTRUTextEdit.Text = "";
            nOIOHIENTAITextEdit.Text = "";
            dIENTHOAITextEdit.Text = "";
            eMAILTextEdit.Text = "";
            tINHTRANGHONNHANTextEdit.Text = "";
            dIENUUTIENTextEdit.Text = "";
            tINHTRANGSUCKHOETextEdit.Text = "";
            vITRITUYENDUNGTextEdit.Text = "";
            hINHTHUCTUYENDUNGTextEdit.Text = "";
            tRINHDOHOCVANComboBox.Text = "";
            tRINHDOTINHOCComboBox.Text = "";
            nGAYCAPDateEdit.Text = "";
            nGAYSINHDateEdit.Text = "";
            nGAYTUYENDUNGDateEdit.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void hINHTHUCTUYENDUNGTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (qUOCTICHComboBox.SelectedValue != null && dANTOCComboBox.SelectedValue != null && tONGIAOComboBox.SelectedValue != null && tRINHDOTINHOCComboBox.SelectedValue != null && tRINHDOHOCVANComboBox.SelectedValue != null)
            {
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureEdit1.Image.Dispose();
                pictureEdit1.Image = null;
            }
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
