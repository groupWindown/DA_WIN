using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace QuanLy_NhanSu
{
    public partial class frm_Sua_ThemMoiNV_UngVien : Form
    {
        public frm_Sua_ThemMoiNV_UngVien()
        {
            InitializeComponent();
        }

        private void frm_Sua_ThemMoiNV_UngVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetQLNS.QUOCTICH' table. You can move, or remove it, as needed.
            this.qUOCTICHTableAdapter.Fill(this.dataSetQLNS.QUOCTICH);
            // TODO: This line of code loads data into the 'dataSetQLNS.DANTOC' table. You can move, or remove it, as needed.
            this.dANTOCTableAdapter.Fill(this.dataSetQLNS.DANTOC);
            // TODO: This line of code loads data into the 'dataSetQLNS.TONGIAO' table. You can move, or remove it, as needed.
            this.tONGIAOTableAdapter.Fill(this.dataSetQLNS.TONGIAO);
            // TODO: This line of code loads data into the 'dataSetQLNS.HINHANH' table. You can move, or remove it, as needed.
            this.hINHANHTableAdapter.Fill(this.dataSetQLNS.HINHANH);
            // TODO: This line of code loads data into the 'dataSetQLNS.HOSOTUYENDUNG' table. You can move, or remove it, as needed.
            this.hOSOTUYENDUNGTableAdapter.Fill(this.dataSetQLNS.HOSOTUYENDUNG);
             // TODO: This line of code loads data into the 'dataSetQLNS.NGOAINGU' table. You can move, or remove it, as needed.
            this.nGOAINGUTableAdapter.Fill(this.dataSetQLNS.NGOAINGU);
            // TODO: This line of code loads data into the 'dataSetQLNS.CHUYENMON' table. You can move, or remove it, as needed.
            this.cHUYENMONTableAdapter.Fill(this.dataSetQLNS.CHUYENMON);
            // add in comboboxKetQuaTuyenDung
            cbo_KetQuaTuyenDung.Items.Add( "Đậu");
            cbo_KetQuaTuyenDung.Items.Add("Rớt");
            cbo_KetQuaTuyenDung.SelectedIndex = 0;
            // add in comboboxGioitinh
            cbo_GioiTinh.Items.Add("Nam");
            cbo_GioiTinh.Items.Add("Nữ");
            LoadUV();
            Load_CM_NN();
        }

        private void Load_CM_NN()
        {
            findCM(mAUNGVIENTextEdit.Text);
            findNN(mAUNGVIENTextEdit.Text);
        }

        private List<string> findNN(string text)
        {
            try
            {
                List<string> lststring = new List<string>();
                DataTable data = dataSetQLNS.NGOAINGU;
                foreach (DataRow rows in data.Rows)
                {
                    if (rows["MAUNGVIEN"].ToString() == text)
                    {
                        lststring.Add(rows["MANGOAINGU"].ToString());
                    }
                }
                return lststring;
            }
            catch
            {
                return null;
            }
        }

        private List<string> findCM(string text)
        {
            try
            {
                List<string> lststring = new List<string>();
                DataTable data = dataSetQLNS.CHUYENMON;
                foreach (DataRow rows in data.Rows)
                {
                    if (rows["MAUNGVIEN"].ToString() == text)
                    {
                        lststring.Add(rows["MANGOAINGU"].ToString());
                    }
                }
                return lststring;
            }
            catch
            {
                return null;
            }
        }

        private void LoadUV()
        {
            hOSOTUYENDUNGTableAdapter.Fill(dataSetQLNS.HOSOTUYENDUNG);

            DataSetQLNS.HOSOTUYENDUNGRow data = dataSetQLNS.HOSOTUYENDUNG.FindByMAUNGVIEN(Properties.Settings.Default.UngVienClick);
            mAUNGVIENTextEdit.Text= data.MAUNGVIEN;
            hOTENTextEdit.Text= data.HOTEN;
            cbo_GioiTinh.Text= data.GIOITINH;
            nGAYSINHDateEdit.Text = data.NGAYSINH.ToString().Split(' ')[0].ToString() ;
            cMNDTextEdit.Text= data.CMND;
            nGAYCAPDateEdit.Text= data.NGAYCAP.ToString().Split(' ')[0].ToString();
            nOICAPTextEdit.Text= data.NOICAP;
            dANTOCComboBox.ValueMember = "MADANTOC";
            dANTOCComboBox.Text= data.MADANTOC;
            tONGIAOComboBox.ValueMember = "MATONGIAO";
            tONGIAOComboBox.Text= data.MATONGIAO;
            nGAYCAPDateEdit.Text= data.NGAYCAP.ToString().Split(' ')[0].ToString();
            qUOCTICHComboBox.ValueMember = "MAQUOCTICH";
            qUOCTICHComboBox.Text = data.MAQUOCTICH;
            qUEQUANTextEdit.Text = data.QUEQUAN;
            nOISINHTextEdit.Text = data.NOISINH;
            dIACHITHUONGTRUTextEdit.Text = data.DIACHITHUONGTRU;
            nOIOHIENTAITextEdit.Text = data.NOIOHIENTAI;
            dIENTHOAITextEdit.Text = data.DIENTHOAI;
            eMAILTextEdit.Text = data.EMAIL;
            tINHTRANGHONNHANTextEdit.Text = data.TINHTRANGHONNHAN;
            dIENUUTIENTextEdit.Text = data.DIENUUTIEN;
            tINHTRANGSUCKHOETextEdit.Text = data.TINHTRANGSUCKHOE;
            nGAYTUYENDUNGDateEdit.Text = data.NGAYTUYENDUNG.ToString().Split(' ')[0].ToString();
            vITRITUYENDUNGTextEdit.Text = data.VITRITUYENDUNG;
            hINHTHUCTUYENDUNGTextEdit.Text = data.HINHTHUCTUYENDUNG;
            mATRINHDOHOCVANTextEdit.Text = data.MATRINHDOHOCVAN;
            mATRINHDOTINHOCTextEdit.Text = data.MATRINHDOTINHOC;

            hINHANHTableAdapter.Fill(dataSetQLNS.HINHANH);

            loadhinh(mAUNGVIENTextEdit.Text);
        }

        private string loadhinh(string v)
        {

            try
            {
                DataSetQLNS.HINHANHDataTable data = dataSetQLNS.HINHANH;
                foreach(DataSetQLNS.HINHANHRow rows in data.Rows)
                {
                    if(rows.MAUNGVIEN.ToString()==v)
                    {
                        pictureEdit_hinhUV.Image = byteArrayToImage(rows.URL.ToArray());
                    }
                }
                return null;

            }
            catch
            {
                return null;
            }
        }
        //ảnh -> byte[]
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        //byte[] -> ảnh
        public System.Drawing.Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            System.Drawing.Image returnImage = System.Drawing.Image.FromStream(ms);
            return returnImage;
        }


        private void cbo_KetQuaTuyenDung_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbo_KetQuaTuyenDung.Text !=null)
            {
                if(cbo_KetQuaTuyenDung.Text=="Đậu")
                {
                    groupBox_ChiTietHopDong.Visible = true;
                }
                else
                {
                    groupBox_ChiTietHopDong.Visible = false;
                    txt_LuongThoaThuan.Text = null;
                    dateEdit_NgayBatDau = null;
                }
            }
        }

      

        private void pictureEdit_hinhUV_Click(object sender, EventArgs e)
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
                pictureEdit_hinhUV.Image = image;
            }catch
            {    }
        }
    }
}
