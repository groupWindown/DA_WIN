using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_NhanSu
{
    public partial class frm_ThemUV : Form
    {
        Trick st = new Trick();
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
            // TODO: This line of code loads data into the 'dataSetQLNS.CHITIETNGOAINGU' table. You can move, or remove it, as needed.
            this.cHITIETNGOAINGUTableAdapter.Fill(this.dataSetQLNS.CHITIETNGOAINGU);
            // TODO: This line of code loads data into the 'dataSetQLNS.CHITIETCHUYENMON' table. You can move, or remove it, as needed.
            this.cHITIETCHUYENMONTableAdapter.Fill(this.dataSetQLNS.CHITIETCHUYENMON);
            // TODO: This line of code loads data into the 'dataSetQLNS.HINHANH' table. You can move, or remove it, as needed.
            this.hINHANHTableAdapter.Fill(this.dataSetQLNS.HINHANH);
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

            mAUNGVIENTextEdit.Text = sinhtudongMaUV(0);
            hOTENTextEdit.Text = "";
            cMNDTextEdit.Text = "";
            nOICAPTextEdit.Text = "";
            nGAYCAPDateEdit.Text = "";
            dANTOCComboBox.SelectedItem = null;
            tONGIAOComboBox.SelectedItem = null;
            qUOCTICHComboBox.SelectedItem = null;
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
            tRINHDOHOCVANComboBox.SelectedItem = null;
            tRINHDOTINHOCComboBox.SelectedItem = null;
            nGAYCAPDateEdit.Text = "";
            nGAYSINHDateEdit.Text = "";
            nGAYTUYENDUNGDateEdit.Text = "";
            

        }
        //tự sinh Mã Ứng Viên
        private string sinhtudongMaUV(int num)
        {
            int number = dataSetQLNS.HOSOTUYENDUNG.Count + 1+num;
            int value = number;
            int strick = 1;
            while (number < 9999)
            {
                number = value + strick;
                strick *= 10;
            }
            string str= "HSTD" + number.ToString().Substring(1, 4);
            if (dataSetQLNS.HINHANH.FindByMAHINHANH(str) != null)
            {
                return sinhtudongMaUV(++num);
            }
            else
            {
                return str;
            }
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void hINHTHUCTUYENDUNGTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (vITRITUYENDUNGTextEdit.Text.Length>0&&hOTENTextEdit.Text.Length>0&&qUOCTICHComboBox.SelectedValue != null && dANTOCComboBox.SelectedValue != null && tONGIAOComboBox.SelectedValue!=null && tRINHDOTINHOCComboBox.SelectedValue != null && tRINHDOHOCVANComboBox.SelectedValue != null)
            {
                
                insertUV();
                for (int i = 0; i < gridViewCM.RowCount; i++)
                {
                    if (gridViewCM.IsRowSelected(i))
                    {
                        try
                        {
                            cHITIETCHUYENMONTableAdapter.Insert(gridViewCM.GetRowCellValue(i, "MACHUYENMON").ToString(), mAUNGVIENTextEdit.Text);
                        }
                        catch { }
                    }
                }
                for (int i = 0; i < gridViewNN.RowCount; i++)
                {
                    if (gridViewNN.IsRowSelected(i))
                    {
                        try
                        {
                            cHITIETNGOAINGUTableAdapter.Insert(gridViewNN.GetRowCellValue(i, "MANGOAINGU").ToString(), mAUNGVIENTextEdit.Text);
                        }
                        catch { }
                    }
                }
                insertHinhAnh();
                MessageBox.Show("Thành công"); 
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui long nhập đủ tên,vitrituyendung,quốc tich, dân tộc, tôn giáo, trình độ học vấn, tin học");
            }
        }

        private void insertUV()
        {
            try
            {
                hOSOTUYENDUNGTableAdapter.Insert(mAUNGVIENTextEdit.Text, dANTOCComboBox.SelectedValue.ToString(), tONGIAOComboBox.SelectedValue.ToString(), qUOCTICHComboBox.SelectedValue.ToString(), hOTENTextEdit.Text, cbo_GioiTinh.Text, nGAYSINHDateEdit.DateTime, nOISINHTextEdit.Text, cMNDTextEdit.Text, nGAYCAPDateEdit.DateTime, nOICAPTextEdit.Text, qUEQUANTextEdit.Text, dIACHITHUONGTRUTextEdit.Text, nOIOHIENTAITextEdit.Text, dIENTHOAITextEdit.Text, eMAILTextEdit.Text, tINHTRANGHONNHANTextEdit.Text, dIENTHOAITextEdit.Text, tINHTRANGSUCKHOETextEdit.Text, nGAYTUYENDUNGDateEdit.DateTime, hINHTHUCTUYENDUNGTextEdit.Text, vITRITUYENDUNGTextEdit.Text, tRINHDOHOCVANComboBox.SelectedValue.ToString(), tRINHDOTINHOCComboBox.SelectedValue.ToString());
                
            }
            catch
            {
                MessageBox.Show("thất bại");
            }
        }
        private void insertHinhAnh()
        {
            if (pictureEdit1.Image != null)
            {
                try
                {
                    hINHANHTableAdapter.Insert(sinhtudongMaHA(0), pictureEdit1.Name, mAUNGVIENTextEdit.Text, st.imageToByteArray(pictureEdit1.Image));
                }
                catch
                {

                }
            }
            else
            {

            }
        }

        //tự sinh Mã Hình ảnh
        private string sinhtudongMaHA(int num)
        {
            int number = dataSetQLNS.HINHANH.Count + 1 + num;
            int value = number;
            int strick = 1;
            while (number < 999999)
            {
                number = value + strick;
                strick *= 10;
            }
            string str = "HA" + number.ToString().Substring(1, 6);
            if (dataSetQLNS.HINHANH.FindByMAHINHANH(str) != null)
            {
                return sinhtudongMaHA(++num);
            }
            else
            {
                return str;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureEdit1.Image != null&& pictureEdit1 != null)
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

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void frm_ThemUV_FormClosed(object sender, FormClosedEventArgs e)
        {
            endform();
        }

        private void endform()
        {
            foreach (System.Windows.Forms.Control ctrl in Program.frmMain.Controls)
            {
                if (ctrl.GetType() == typeof(System.Windows.Forms.Panel))
                {
                    ctrl.Controls.Clear();
                    frm_TT_UngVien frm = new frm_TT_UngVien();
                    ctrl.Controls.Add(frm);

                }
            }
        }
    }
}
