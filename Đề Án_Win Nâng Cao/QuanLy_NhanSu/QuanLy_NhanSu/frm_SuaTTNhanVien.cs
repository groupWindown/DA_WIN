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
                
                if (bLL_load.BLL_loadChiTietChuyenMon(txt_MaNV.Text.Trim(), gridViewCM.GetRowCellValue((i),"MACHUYENMON").ToString()) != null)
                {
                    gridViewCM.SelectRow(i);
                }
            }
            for (int i = 0; i < gridViewNN.DataRowCount; i++)
            {
                if (bLL_load.BLL_loadChiTietChuyenMon(txt_MaNV.Text.Trim(), gridViewNN.GetRowCellValue((i), "MANGOAINGU").ToString().Trim()) != null)
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
            if (qUOCTICHComboBox.SelectedValue != null && dANTOCComboBox.SelectedValue != null && tONGIAOComboBox.SelectedValue != null && tRINHDOTINHOCComboBox.SelectedValue != null && tRINHDOHOCVANComboBox.SelectedValue != null)
            {
                //luu hinh anh
                insertHinhAnh();
                //update du lieu cua ung vien
               // hOSOTUYENDUNGTableAdapter.Update(mAUNGVIENTextEdit.Text, dANTOCComboBox.SelectedValue.ToString(), tONGIAOComboBox.SelectedValue.ToString(), qUOCTICHComboBox.SelectedValue.ToString(), hOTENTextEdit.Text, cbo_GioiTinh.Text, nGAYSINHDateEdit.DateTime, nOISINHTextEdit.Text, cMNDTextEdit.Text, nGAYCAPDateEdit.DateTime, nOICAPTextEdit.Text, qUEQUANTextEdit.Text, dIACHITHUONGTRUTextEdit.Text, nOIOHIENTAITextEdit.Text, dIENTHOAITextEdit.Text, eMAILTextEdit.Text, tINHTRANGHONNHANTextEdit.Text, dIENUUTIENTextEdit.Text, tINHTRANGSUCKHOETextEdit.Text, nGAYTUYENDUNGDateEdit.DateTime, hINHTHUCTUYENDUNGTextEdit.Text, vITRITUYENDUNGTextEdit.Text, tRINHDOHOCVANComboBox.Text, tRINHDOTINHOCComboBox.Text, mAUNGVIENTextEdit.Text, dANTOCComboBox.SelectedValue.ToString(), tONGIAOComboBox.SelectedValue.ToString(), qUOCTICHComboBox.SelectedValue.ToString(), hOTENTextEdit.Text, cbo_GioiTinh.Text, nGAYSINHDateEdit.DateTime, nOISINHTextEdit.Text, cMNDTextEdit.Text, nGAYCAPDateEdit.DateTime, nOICAPTextEdit.Text, qUEQUANTextEdit.Text, dIACHITHUONGTRUTextEdit.Text, nOIOHIENTAITextEdit.Text, dIENTHOAITextEdit.Text, eMAILTextEdit.Text, tINHTRANGHONNHANTextEdit.Text, dIENUUTIENTextEdit.Text, tINHTRANGSUCKHOETextEdit.Text, nGAYTUYENDUNGDateEdit.DateTime, hINHTHUCTUYENDUNGTextEdit.Text, vITRITUYENDUNGTextEdit.Text, tRINHDOHOCVANComboBox.Text, tRINHDOTINHOCComboBox.Text);
                //update chuyen mon
                for (int i = 0; i < gridViewCM.RowCount; i++)
                {
                    if (gridViewCM.IsRowSelected(i))
                    {
                        try
                        {
                           // cHITIETCHUYENMONTableAdapter.Insert(gridView1.GetRowCellValue(i, "MACHUYENMON").ToString(), mAUNGVIENTextEdit.Text);
                        }
                        catch
                        {
                            //cHITIETCHUYENMONTableAdapter.Update(gridView1.GetRowCellValue(i, "MACHUYENMON").ToString(), mAUNGVIENTextEdit.Text);
                        }
                    }
                    else
                    {
                        try
                        {
                            //cHITIETCHUYENMONTableAdapter.Delete(gridView1.GetRowCellValue(i, "MACHUYENMON").ToString(), mAUNGVIENTextEdit.Text);
                        }
                        catch
                        {

                        }
                    }
                }
                //update ngoai ngu
                for (int i = 0; i < gridViewNN.RowCount; i++)
                {
                    if (gridViewNN.IsRowSelected(i))
                    {
                        try
                        {
                           // cHITIETNGOAINGUTableAdapter.Insert(gridView2.GetRowCellValue(i, "MANGOAINGU").ToString(), mAUNGVIENTextEdit.Text);
                        }
                        catch
                        {
                          //  cHITIETNGOAINGUTableAdapter.Update(gridView2.GetRowCellValue(i, "MANGOAINGU").ToString(), mAUNGVIENTextEdit.Text);
                        }
                    }
                    else
                    {
                        try
                        {
                           // cHITIETNGOAINGUTableAdapter.Delete(gridView2.GetRowCellValue(i, "MANGOAINGU").ToString(), mAUNGVIENTextEdit.Text);
                        }
                        catch
                        {

                        }
                    }
                }

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
                    //hINHANHTableAdapter.Update(pictureEdit_hinhUV.Name, mAUNGVIENTextEdit.Text, st.imageToByteArray(pictureEdit_hinhUV.Image), timhinhanh(mAUNGVIENTextEdit.Text), pictureEdit_hinhUV.Name, mAUNGVIENTextEdit.Text);
                    HINHANH ha = new HINHANH();
                    ha.MAHINHANH = bLL_NhanVien.BLL_FindHinhAnhByMANV(txt_MaNV.Text);
                    ha.TENHINHANH = bLL_NhanVien.BLL_FindHinhAnhByMANV(txt_MaNV.Text);
                    ha.URL = st.imageToByteArray(pictureEdit1.Image);
                    bLL_NhanVien.BLL_UpdateHinhAnh(ha);
                }
                catch
                {
                    try
                    {
                        //hINHANHTableAdapter.Insert(sinhtudongMaHA(0), pictureEdit_hinhUV.Name, mAUNGVIENTextEdit.Text, st.imageToByteArray(pictureEdit_hinhUV.Image));
                        HINHANH ha = new HINHANH();
                        ha.MAHINHANH = bLL_NhanVien.BLL_FindHinhAnhByMANV(txt_MaNV.Text);
                        ha.TENHINHANH = bLL_NhanVien.BLL_FindHinhAnhByMANV(txt_MaNV.Text);
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
                    //hINHANHTableAdapter.Update(pictureEdit_hinhUV.Name, mAUNGVIENTextEdit.Text, null, timhinhanh(mAUNGVIENTextEdit.Text), pictureEdit_hinhUV.Name, mAUNGVIENTextEdit.Text);
                    HINHANH ha = new HINHANH();
                    ha.MAHINHANH = bLL_NhanVien.BLL_FindHinhAnhByMANV(txt_MaNV.Text);
                    ha.TENHINHANH = bLL_NhanVien.BLL_FindHinhAnhByMANV(txt_MaNV.Text);
                    ha.URL = null;
                    bLL_NhanVien.BLL_UpdateHinhAnh(ha);
                }
                catch
                {
                    try
                    {
                        // hINHANHTableAdapter.Insert(sinhtudongMaHA(0), pictureEdit_hinhUV.Name, mAUNGVIENTextEdit.Text, null);
                        HINHANH ha = new HINHANH();
                        ha.MAHINHANH = bLL_NhanVien.BLL_FindHinhAnhByMANV(txt_MaNV.Text);
                        ha.TENHINHANH = bLL_NhanVien.BLL_FindHinhAnhByMANV(txt_MaNV.Text);
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
