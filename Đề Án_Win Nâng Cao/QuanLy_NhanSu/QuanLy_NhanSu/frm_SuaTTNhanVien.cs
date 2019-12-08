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
            //load các combobox,girdcontrol
            loadthongso();
            //load chitietchuyenmon,ngoaingu
            //Load_CM_NN();
        }

        private void loadthongso()
        {
            dANTOCComboBox.DataSource = bLL_load.BLL_loadDanToc();
            dANTOCComboBox.ValueMember = "MADANTOC";
            dANTOCComboBox.DisplayMember = "TENDANTOC";
            pHONGBANComboBox.DataSource = bLL_load.BLL_loadPhongBan();
            pHONGBANComboBox.ValueMember = "MAPHONGBAN";
            pHONGBANComboBox.DisplayMember = "TENPHONGBAN";
            qUOCTICHComboBox.DataSource = bLL_load.BLL_loadPhongBan();
            qUOCTICHComboBox.ValueMember = "MAQUOCTICH";
            qUOCTICHComboBox.DisplayMember = "TENQUOCTICH";
            cHUCVUComboBox.DataSource = bLL_load.BLL_loadChucVu();
            cHUCVUComboBox.ValueMember = "MACHUCVU";
            cHUCVUComboBox.DisplayMember = "TENCHUCVU";
            qUOCTICHComboBox.DataSource = bLL_load.BLL_loadQuocTich();
            qUOCTICHComboBox.ValueMember = "MAQUOCTICH";
            qUOCTICHComboBox.DisplayMember = "TENQUOCTICH";
            tRINHDOHOCVANComboBox.DataSource = bLL_load.BLL_loadTrinhDoHocVan();
            tRINHDOHOCVANComboBox.ValueMember = "MATRINHDOHOCVAN";
            tRINHDOHOCVANComboBox.DisplayMember = "TENTRINHDOHOCVAN";
            tRINHDOTINHOCComboBox.DataSource = bLL_load.BLL_loadTrinhDoTinHoc();
            tRINHDOTINHOCComboBox.ValueMember = "MATRINHDOTINHOC";
            tRINHDOTINHOCComboBox.DisplayMember = "TENTRINHDOTINHOC";
            gridControlCM.DataSource = bLL_load.BLL_loadChuyenMon();
            gridControlNN.DataSource = bLL_load.BLL_loadNgoaiNgu();
            // add in comboboxGioitinh
            cbo_GioiTinh.Items.Add("Nam");
            cbo_GioiTinh.Items.Add("Nữ");
            cbo_GioiTinh.SelectedIndex = 0;
            // add in comboboxtinhtrang
            cbo_TinhTrang.Items.Add("Đang làm");
            cbo_TinhTrang.Items.Add("Nghỉ làm");
            cbo_TinhTrang.SelectedIndex = 0;

            txt_MaNV.Text = Properties.Settings.Default.NhanVienClick;
        }

        private void Load_CM_NN()
        {
            for (int i = 0; i < gridViewCM.DataRowCount; i++)
            {
                
                string a = gridViewCM.GetDataRow(i)[0].ToString();
                if (bLL_load.BLL_loadChiTietChuyenMon(txt_MaNV.Text.Trim(), a) != null)
                {
                    gridViewCM.SelectRow(i);
                }
            }
            for (int i = 0; i < gridViewNN.DataRowCount; i++)
            {
                if (bLL_load.BLL_loadChiTietChuyenMon(txt_MaNV.Text.Trim(), gridViewNN.GetDataRow(i)["MANGOAINGU"].ToString().Trim()) != null)
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

        private void btn_Sua_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
