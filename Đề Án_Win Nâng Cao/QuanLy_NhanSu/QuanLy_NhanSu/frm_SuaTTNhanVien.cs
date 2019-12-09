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
        BLL_NhanVien bLL_NhanVien = new BLL_NhanVien();
        Trick st = new Trick();
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
            Load_CM_NN();
        }

        private void loadthongso()
        {
            dANTOCComboBox.DataSource = bLL_load.BLL_loadDanToc();
            dANTOCComboBox.ValueMember = "MADANTOC";
            dANTOCComboBox.DisplayMember = "TENDANTOC";
            pHONGBANComboBox.DataSource = bLL_load.BLL_loadPhongBan();
            pHONGBANComboBox.ValueMember = "MAPHONGBAN";
            pHONGBANComboBox.DisplayMember = "TENPHONGBAN";
            tONGIAOComboBox.DataSource = bLL_load.BLL_loadTonGiao();
            tONGIAOComboBox.ValueMember = "MATONGIAO";
            tONGIAOComboBox.DisplayMember = "TENTONGIAO";
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
     

            txt_MaNV.Text = Properties.Settings.Default.NhanVienClick;
            HOSOTUYENDUNG hOSOTUYENDUNG = bLL_load.BLL_loadHoSoTuyenDungUngVien(bLL_load.BLL_FindUngVienByMaNV(txt_MaNV.Text));
            NHANVIEN nv = bLL_load.BLL_loadThongTinNhanVien(txt_MaNV.Text);
            hOTENTextEdit.Text =hOSOTUYENDUNG.HOTEN;
            cbo_GioiTinh.Text =hOSOTUYENDUNG.GIOITINH;
            nGAYSINHDateEdit.DateTime =DateTime.Parse(hOSOTUYENDUNG.NGAYSINH.ToString());
            cMNDTextEdit.Text =hOSOTUYENDUNG.CMND;
            nGAYCAPDateEdit.DateTime = DateTime.Parse(hOSOTUYENDUNG.NGAYCAP.ToString());
            nOICAPTextEdit.Text =hOSOTUYENDUNG.NOICAP;
            dANTOCComboBox.SelectedValue =hOSOTUYENDUNG.MADANTOC;
            tONGIAOComboBox.SelectedValue = hOSOTUYENDUNG.MATONGIAO;
            qUOCTICHComboBox.SelectedValue = hOSOTUYENDUNG.MAQUOCTICH;
            qUEQUANTextEdit.Text =hOSOTUYENDUNG.QUEQUAN;
            nOISINHTextEdit.Text =hOSOTUYENDUNG.NOISINH;
            dIACHITHUONGTRUTextEdit.Text =hOSOTUYENDUNG.DIACHITHUONGTRU;
            nOIOHIENTAITextEdit.Text =hOSOTUYENDUNG.NOIOHIENTAI;
            dIENTHOAITextEdit.Text =hOSOTUYENDUNG.DIENTHOAI;
            eMAILTextEdit.Text =hOSOTUYENDUNG.EMAIL;
            dIENUUTIENTextEdit.Text =hOSOTUYENDUNG.DIENUUTIEN;
            pHONGBANComboBox.SelectedValue = nv.MAPHONGBAN;
            cHUCVUComboBox.SelectedValue = nv.MACHUCVU;
            tINHTRANGSUCKHOETextEdit.SelectedText = hOSOTUYENDUNG.TINHTRANGSUCKHOE;
            tINHTRANGHONNHANTextEdit.SelectedText = hOSOTUYENDUNG.TINHTRANGHONNHAN;
            nGAYTUYENDUNGDateEdit.DateTime = DateTime.Parse(hOSOTUYENDUNG.NGAYTUYENDUNG.ToString()) ;
            hINHTHUCTUYENDUNGTextEdit.Text = hOSOTUYENDUNG.HINHTHUCTUYENDUNG;
            pictureEdit1.Image = loadhinh(txt_MaNV.Text);
        }
        private Image loadhinh(string v)
        {
            try
            {
                byte[] kq = bLL_load.BLL_loadURLHinhAnh(v);
                if (kq != null)
                {
                    return st.byteArrayToImage(kq);
                }
                return null;
            }
            catch
            {
                return null;
            }
        }
        private void Load_CM_NN()
        {
            for (int i = 0; i < gridViewCM.DataRowCount; i++)
            {
                if (bLL_load.BLL_loadChiTietChuyenMon(txt_MaNV.Text.Trim(), gridViewCM.GetRowCellValue((i),"MACHUYENMON").ToString()) != null)
                {
                    gridViewCM.SelectRow(i);
                }
            }
            for (int i = 0; i < gridViewNN.DataRowCount; i++)
            {
                if (bLL_load.BLL_loadChiTietNgoaiNgu(txt_MaNV.Text.Trim(), gridViewNN.GetRowCellValue((i), "MANGOAINGU").ToString().Trim()) != null)
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
            if (qUOCTICHComboBox.SelectedValue != null && dANTOCComboBox.SelectedValue != null && tONGIAOComboBox.SelectedValue != null && tRINHDOTINHOCComboBox.SelectedValue != null && tRINHDOHOCVANComboBox.SelectedValue != null&& cHUCVUComboBox.SelectedValue != null && pHONGBANComboBox.SelectedValue != null)
            {
                //update chuyen mon
                for (int i = 0; i < gridViewCM.RowCount; i++)
                {
                    if (gridViewCM.IsRowSelected(i))
                    {
                        try
                        {
                            CHITIETCHUYENMON cHITIETCHUYENMON = new CHITIETCHUYENMON();
                            cHITIETCHUYENMON.MACHUYENMON = gridViewCM.GetRowCellValue(i, "MACHUYENMON").ToString();
                            cHITIETCHUYENMON.MAUNGVIEN = bLL_load.BLL_FindUngVienByMaNV(txt_MaNV.Text);
                            bLL_NhanVien.BLL_ThemChiTietChuyenMon(cHITIETCHUYENMON);
                        }
                        catch
                        { }
                    }
                    else
                    {
                        try
                        {
                            CHITIETCHUYENMON cHITIETCHUYENMON = new CHITIETCHUYENMON();
                            cHITIETCHUYENMON.MACHUYENMON = gridViewCM.GetRowCellValue(i, "MACHUYENMON").ToString();
                            cHITIETCHUYENMON.MAUNGVIEN = bLL_load.BLL_FindUngVienByMaNV(txt_MaNV.Text);
                            bLL_NhanVien.BLL_XoaChiTietChuyenMon(cHITIETCHUYENMON);
                        }
                        catch
                        { }
                    }
                }
                //luu hinh anh
                insertHinhAnh();
                //update du lieu cua ung vien
                 HOSOTUYENDUNG hOSOTUYENDUNG = new HOSOTUYENDUNG();
                hOSOTUYENDUNG.MAUNGVIEN = bLL_load.BLL_FindUngVienByMaNV(txt_MaNV.Text) ;
                hOSOTUYENDUNG.HOTEN = hOTENTextEdit.Text;
                hOSOTUYENDUNG.DIENTHOAI = dIENTHOAITextEdit.Text;
                hOSOTUYENDUNG.EMAIL = eMAILTextEdit.Text;
                hOSOTUYENDUNG.GIOITINH = cbo_GioiTinh.Text;
                hOSOTUYENDUNG.NGAYSINH = nGAYSINHDateEdit.DateTime;
                hOSOTUYENDUNG.NGAYCAP = nGAYCAPDateEdit.DateTime;
                hOSOTUYENDUNG.NGAYTUYENDUNG = nGAYTUYENDUNGDateEdit.DateTime;
                hOSOTUYENDUNG.NOICAP = nOICAPTextEdit.Text;
                hOSOTUYENDUNG.NOIOHIENTAI = nOIOHIENTAITextEdit.Text;
                hOSOTUYENDUNG.NOISINH = nOISINHTextEdit.Text;
                hOSOTUYENDUNG.QUEQUAN =qUEQUANTextEdit.Text;
                hOSOTUYENDUNG.TINHTRANGHONNHAN = tINHTRANGHONNHANTextEdit.Text;
                hOSOTUYENDUNG.TINHTRANGSUCKHOE = tINHTRANGSUCKHOETextEdit.Text;
                hOSOTUYENDUNG.MATRINHDOHOCVAN = tRINHDOHOCVANComboBox.SelectedValue.ToString();
                hOSOTUYENDUNG.MATRINHDOTINHOC = tRINHDOTINHOCComboBox.SelectedValue.ToString() ;
                hOSOTUYENDUNG.MADANTOC = dANTOCComboBox.SelectedValue.ToString();
                hOSOTUYENDUNG.MAQUOCTICH = qUOCTICHComboBox.SelectedValue.ToString();
                hOSOTUYENDUNG.MATONGIAO =tONGIAOComboBox.SelectedValue.ToString();
                hOSOTUYENDUNG.DIENUUTIEN = dIENUUTIENTextEdit.Text;
                hOSOTUYENDUNG.CMND = cMNDTextEdit.Text;
                hOSOTUYENDUNG.DIACHITHUONGTRU = dIACHITHUONGTRUTextEdit.Text;
                bLL_NhanVien.BLL_SuaHoSoNV(hOSOTUYENDUNG);
               
                //update ngoai ngu
                for (int i = 0; i < gridViewNN.RowCount; i++)
                {
                    if (gridViewNN.IsRowSelected(i))
                    {
                        try
                        {
                            CHITIETNGOAINGU cHITIETNGOAINGU = new CHITIETNGOAINGU();
                            cHITIETNGOAINGU.MANGOAINGU = gridViewNN.GetRowCellValue(i, "MANGOAINGU").ToString();
                            cHITIETNGOAINGU.MAUNGVIEN = bLL_load.BLL_FindUngVienByMaNV(txt_MaNV.Text);
                            bLL_NhanVien.BLL_ThemChiTietNgoaiNgu(cHITIETNGOAINGU);
                        }
                        catch
                        { }
                    }
                    else
                    {
                        try
                        {
                            CHITIETNGOAINGU cHITIETNGOAINGU = new CHITIETNGOAINGU();
                            cHITIETNGOAINGU.MANGOAINGU = gridViewNN.GetRowCellValue(i, "MANGOAINGU").ToString();
                            cHITIETNGOAINGU.MAUNGVIEN = bLL_load.BLL_FindUngVienByMaNV(txt_MaNV.Text);
                            bLL_NhanVien.BLL_XoaChiTietNgoaiNgu(cHITIETNGOAINGU);
                        }
                        catch
                        { }
                    }
                }
                //update nhanvien
                NHANVIEN nHANVIEN = new NHANVIEN();
                nHANVIEN.MANV = txt_MaNV.Text;
                nHANVIEN.HOTEN = hOTENTextEdit.Text;
                nHANVIEN.MACHUCVU = cHUCVUComboBox.SelectedValue.ToString();
                nHANVIEN.MAPHONGBAN = pHONGBANComboBox.SelectedValue.ToString();
                nHANVIEN.NGAYVAOLAM = nGAYTUYENDUNGDateEdit.DateTime;
                bLL_NhanVien.BLL_SuaNhanVien(nHANVIEN);
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ Trình độ Học Vấn,Tin học,Quốc tịch,Dân tộc,Tôn giáo");
            }
        }

        private void insertHinhAnh()
        {
            if (pictureEdit1.Image != null)
            {
                try
                {
                     HINHANH ha = new HINHANH();
                    ha.MAHINHANH = bLL_NhanVien.BLL_FindHinhAnhByMANV(txt_MaNV.Text);
                    ha.TENHINHANH = pictureEdit1.Text;
                    ha.URL = st.imageToByteArray(pictureEdit1.Image);
                    bLL_NhanVien.BLL_UpdateHinhAnh(ha);
                }
                catch
                {
                    try
                    {
                        HINHANH ha = new HINHANH();
                        ha.MAHINHANH = bLL_NhanVien.BLL_FindHinhAnhByMANV(txt_MaNV.Text);
                        ha.TENHINHANH = pictureEdit1.Text;
                        ha.URL = st.imageToByteArray(pictureEdit1.Image);
                        ha.MAUNGVIEN = bLL_load.BLL_FindUngVienByMaNV(txt_MaNV.Text);
                        bLL_NhanVien.BLL_InsertHinhAnh(ha);
                    }
                    catch
                    {

                    }
                }
            }
            else
            {
                try
                {
                     HINHANH ha = new HINHANH();
                    ha.MAHINHANH = bLL_NhanVien.BLL_FindHinhAnhByMANV(txt_MaNV.Text);
                    ha.TENHINHANH = pictureEdit1.Text;
                    ha.URL = null;
                    bLL_NhanVien.BLL_UpdateHinhAnh(ha);
                }
                catch
                {
                    try
                    {
                        HINHANH ha = new HINHANH();
                        ha.MAHINHANH = bLL_NhanVien.BLL_FindHinhAnhByMANV(txt_MaNV.Text);
                        ha.TENHINHANH = pictureEdit1.Text;
                        ha.URL = null;
                        ha.MAUNGVIEN = bLL_load.BLL_FindUngVienByMaNV(txt_MaNV.Text);
                        bLL_NhanVien.BLL_InsertHinhAnh(ha);
                    }
                    catch
                    {

                    }
                }
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
