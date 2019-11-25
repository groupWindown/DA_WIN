using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            // TODO: This line of code loads data into the 'dataSetQLNS.HOSOTUYENDUNG' table. You can move, or remove it, as needed.
            this.hOSOTUYENDUNGTableAdapter.Fill(this.dataSetQLNS.HOSOTUYENDUNG);
             // TODO: This line of code loads data into the 'dataSetQLNS.NGOAINGU' table. You can move, or remove it, as needed.
            this.nGOAINGUTableAdapter.Fill(this.dataSetQLNS.NGOAINGU);
            // TODO: This line of code loads data into the 'dataSetQLNS.CHUYENMON' table. You can move, or remove it, as needed.
            this.cHUYENMONTableAdapter.Fill(this.dataSetQLNS.CHUYENMON);
            // add in comboboxKetQuaTuyenDung
            cbo_KetQuaTuyenDung.Items.Add( "Đậu");
            cbo_KetQuaTuyenDung.Items.Add("Rớt");
            // add in comboboxGioitinh
            cbo_GioiTinh.Items.Add("Nam");
            cbo_GioiTinh.Items.Add("Nữ");
            LoadUV();
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
            mADANTOCTextEdit.Text= data.MADANTOC;
            mATONGIAOTextEdit.Text= data.MATONGIAO;
            nGAYCAPDateEdit.Text= data.NGAYCAP.ToString().Split(' ')[0].ToString();
            mAQUOCTICHTextEdit.Text = data.MAQUOCTICH;
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
          
        }

        private void cbo_KetQuaTuyenDung_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbo_KetQuaTuyenDung.SelectedValue !=null)
            {
                if(cbo_KetQuaTuyenDung.SelectedValue.ToString()=="Đậu")
                {
                    groupBox_ChiTietHopDong.Visible = false;
                }
                else
                {
                    groupBox_ChiTietHopDong.Visible = true;
                    txt_LuongThoaThuan.Text = null;
                    dateEdit_NgayBatDau = null;
                }
            }
        }
    }
}
