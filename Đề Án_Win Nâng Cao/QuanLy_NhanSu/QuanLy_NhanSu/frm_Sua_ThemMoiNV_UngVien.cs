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
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;

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
            // TODO: This line of code loads data into the 'dataSetQLNS.PHONGBAN' table. You can move, or remove it, as needed.
            this.pHONGBANTableAdapter.Fill(this.dataSetQLNS.PHONGBAN);
            // TODO: This line of code loads data into the 'dataSetQLNS.CHUCVU' table. You can move, or remove it, as needed.
            this.cHUCVUTableAdapter.Fill(this.dataSetQLNS.CHUCVU);
            // TODO: This line of code loads data into the 'dataSetQLNS.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.dataSetQLNS.NHANVIEN);
            // TODO: This line of code loads data into the 'dataSetQLNS.CHITIETHOPDONG' table. You can move, or remove it, as needed.
            this.cHITIETHOPDONGTableAdapter.Fill(this.dataSetQLNS.CHITIETHOPDONG);
            // TODO: This line of code loads data into the 'dataSetQLNS.HOPDONGLAODONG' table. You can move, or remove it, as needed.
            this.hOPDONGLAODONGTableAdapter.Fill(this.dataSetQLNS.HOPDONGLAODONG);
            // TODO: This line of code loads data into the 'dataSetQLNS.KQ_TUYENDUNG' table. You can move, or remove it, as needed.
            this.kQ_TUYENDUNGTableAdapter.Fill(this.dataSetQLNS.KQ_TUYENDUNG);
            // TODO: This line of code loads data into the 'dataSetQLNS.CHITIETNGOAINGU' table. You can move, or remove it, as needed.
            this.cHITIETNGOAINGUTableAdapter.Fill(this.dataSetQLNS.CHITIETNGOAINGU);
            // TODO: This line of code loads data into the 'dataSetQLNS.CHITIETCHUYENMON' table. You can move, or remove it, as needed.
            this.cHITIETCHUYENMONTableAdapter.Fill(this.dataSetQLNS.CHITIETCHUYENMON);
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

            hOPDONGLAODONGTableAdapter.Fill(dataSetQLNS.HOPDONGLAODONG);
            hOPDONGLAODONGComboBox.DisplayMember = "TENHOPDONG";
           
            cHITIETHOPDONGTableAdapter.Fill(dataSetQLNS.CHITIETHOPDONG);
            cHUCVUTableAdapter.Fill(dataSetQLNS.CHUCVU);
            pHONGBANTableAdapter.Fill(dataSetQLNS.PHONGBAN);
            try
            {
                hOPDONGLAODONGComboBox.SelectedIndex = 0;
                cHUCVUComboBox.SelectedIndex = 0;
                pHONGBANComboBox.SelectedIndex = 0;
            }
            catch
            {

            }
            

            LoadUV();
            Load_CM_NN();
        }
        private void Load_CM_NN()
        {
            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                cHITIETCHUYENMONTableAdapter.Fill(dataSetQLNS.CHITIETCHUYENMON);
                DataSetQLNS.CHITIETCHUYENMONRow data = dataSetQLNS.CHITIETCHUYENMON.FindByMACHUYENMONMAUNGVIEN(gridView1.GetDataRow(i)["MACHUYENMON"].ToString().Trim(), mAUNGVIENTextEdit.Text.Trim());
                if(data!=null)
                {
                    gridView1.SelectRow(i);
                }
                       
       
            }
            for (int i = 0; i < gridView2.DataRowCount; i++)
            {
                cHITIETNGOAINGUTableAdapter.Fill(dataSetQLNS.CHITIETNGOAINGU);
                DataSetQLNS.CHITIETNGOAINGURow data = dataSetQLNS.CHITIETNGOAINGU.FindByMANGOAINGUMAUNGVIEN(gridView2.GetDataRow(i)["MANGOAINGU"].ToString(), mAUNGVIENTextEdit.Text);
                if (data != null)
                {
                    gridView2.SelectRow(i);
                }
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
            dANTOCComboBox.Text= dataSetQLNS.DANTOC.FindByMADANTOC( data.MADANTOC).TENDANTOC.ToString();  
            tONGIAOComboBox.Text= dataSetQLNS.TONGIAO.FindByMATONGIAO(data.MATONGIAO).TENTONGIAO.ToString();
            nGAYCAPDateEdit.Text= data.NGAYCAP.ToString().Split(' ')[0].ToString();  
            qUOCTICHComboBox.Text = dataSetQLNS.QUOCTICH.FindByMAQUOCTICH(data.MAQUOCTICH).TENQUOCTICH.ToString();
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

        private void btn_ThemNV_Click(object sender, EventArgs e)
        {
            kQ_TUYENDUNGTableAdapter.Fill(dataSetQLNS.KQ_TUYENDUNG);

            if (cbo_KetQuaTuyenDung.Text == "Đậu")
            {
                try
                {
                    if (txt_LuongThoaThuan.Text.Length > 0 && dateEdit_NgayBatDau.Text.Length > 0 && cHUCVUComboBox.Text.Length > 0 && pHONGBANComboBox.Text.Length > 0 && hOPDONGLAODONGComboBox.Text.Length > 0)
                    {

                        //thêm KQTD
                        insertKQTD();
                        //thêm Nhân Viên
                        string nhanvien = sinhtudongMaNV();
                        insertNhanVien(nhanvien);
                        //thêm Hợp Đồng
                        insertHDLD(nhanvien);




                        MessageBox.Show("Nhân viên " + nhanvien + " vừa được tạo thành công");
                    }
                    else
                    {
                        MessageBox.Show("vui long điền đủ dữ liệu");
                    }
                }
                catch
                {
                }
            }
            else
            {
                try
                {
                    insertKQTD();
                    MessageBox.Show("Lưu thành công");
                }
                catch
                {
                }
            }
        }

        private void insertHinhAnh()
        {
            if (pictureEdit_hinhUV.Image != null)
            {
                try
                {
                    hINHANHTableAdapter.Insert(sinhtudongMaHA(), pictureEdit_hinhUV.Name, mAUNGVIENTextEdit.Text, imageToByteArray(pictureEdit_hinhUV.Image));
                }
                catch
                {
                    try
                    {
                        hINHANHTableAdapter.Update(pictureEdit_hinhUV.Name, mAUNGVIENTextEdit.Text, imageToByteArray(pictureEdit_hinhUV.Image), timhinhanh(mAUNGVIENTextEdit.Text), pictureEdit_hinhUV.Name, mAUNGVIENTextEdit.Text);
                    }
                    catch
                    {

                    }
                }
            }
        }
        //tìm hình ảnh bằng mã ứng viên
        private string timhinhanh(string text)
        {
            foreach (DataSetQLNS.HINHANHRow kq in dataSetQLNS.HINHANH)
            {
                if (kq.MAUNGVIEN.ToString() == text)
                {
                    return kq.MAHINHANH.ToString();
                }
            }
            return null;
        }
        //tự sinh Mã Hình ảnh
        private string sinhtudongMaHA()
        {
            int number = dataSetQLNS.HINHANH.Count + 1;
            int value = number;
            int strick = 1;
            while (number < 999999)
            {
                number = value + strick;
                strick *= 10;
            }
            return "HA" + number.ToString().Substring(1, 6);
        }

        private void insertNhanVien(string nhanvien)
        {
            
            nHANVIENTableAdapter.Fill(dataSetQLNS.NHANVIEN);
            nHANVIENTableAdapter.Insert(nhanvien,dataSetQLNS.HOSOTUYENDUNG.FindByMAUNGVIEN(mAUNGVIENTextEdit.Text).HOTEN.ToString(),pHONGBANComboBox.SelectedValue.ToString(),cHUCVUComboBox.SelectedValue.ToString(), DateTime.Now,"Đang làm",mAUNGVIENTextEdit.Text);
        }
        //tự sinh Mã Nhân viên
        private string sinhtudongMaNV()
        {
            int number = dataSetQLNS.NHANVIEN.Count + 1;
            int value = number;
            int strick = 1;
            while(number<999999)
            {
                number =value+strick;
                strick *= 10;
            }
            return "NV" + number.ToString().Substring(1, 6);
        }
        //tự sinh Mã ChiTietHopDong
        private string sinhtudongCTHD()
        {
            int number = dataSetQLNS.CHITIETHOPDONG.Count + 1;
            int value = number;
            int strick = 1;
            while (number < 9999)
            {
                number = value + strick;
                strick *= 10;
            }
            return "CTHD" + number.ToString().Substring(1, 4);
        }
        private void insertHDLD(string nhanvien)
        {
            cHITIETHOPDONGTableAdapter.Insert(sinhtudongCTHD(), hOPDONGLAODONGComboBox.SelectedValue.ToString(), nhanvien,0, DateTime.Now, DateTime.Parse( dateEdit_NgayBatDau.Text),getNgayKT(),decimal.Parse(txt_LuongThoaThuan.Text.Trim()));
        }

        private DateTime? getNgayKT()
        {
            try
            {
                if(hOPDONGLAODONGComboBox.Text== "Không thời hạn")
                {
                    return null;
                }
                string[] lst = dateEdit_NgayBatDau.Text.Split('/');
                string ngay = lst[1];
                int thang = (Convert.ToInt32 (lst[0]) + Convert.ToInt32 (hOPDONGLAODONGComboBox.Text.ToString().Trim()));
                int nam = Convert.ToInt32 (lst[2]);
                while(thang >12)
                {
                    thang -= 12;
                    nam++;
                }
                 return DateTime.Parse(ngay + "/" + thang.ToString() + "/" + nam.ToString());
            }catch
            {
                return null;
            }
        }

        private void insertKQTD()
        {
            //unique ma ung vien chi co 1
            kQ_TUYENDUNGTableAdapter.Insert("KQTD00" +  (dataSetQLNS.KQ_TUYENDUNG.Count + 1).ToString(), mAUNGVIENTextEdit.Text, cbo_KetQuaTuyenDung.Text);
        }

        //private void UpdateKQTD()
        //{
        //    kQ_TUYENDUNGTableAdapter.Update(cbo_KetQuaTuyenDung.Text, loadMaKQ(mAUNGVIENTextEdit.Text), mAUNGVIENTextEdit.Text, cbo_KetQuaTuyenDung.Text);
        //}

        private string loadMaKQ(string text)
        {
            foreach(DataSetQLNS.KQ_TUYENDUNGRow kq in dataSetQLNS.KQ_TUYENDUNG)
            {
                if(kq.MAUNGVIEN.ToString()==text)
                {
                    return kq.MAKQ.ToString();
                }
            }
            return null;
        }

        private void gridView1_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            if (e.RowHandle!=-1){
                //DataRow data = dataTable.NewRow();
                //data["Ten"] = gridView1.GetRowCellValue(e.RowHandle, "colCoChuyenMon").ToString();
                //data["Ma"] = gridView1.GetRowCellValue(e.RowHandle, "colCoChuyenMon").ToString();
                //data["Ckeck"] = ""+gridView1.GetRowCellValue(e.RowHandle, "colCoChuyenMon").ToString();
                //dataTable.Rows.RemoveAt(e.RowHandle);
                //dataTable.Rows.Add(data);

                //gridControlCM.DataSource = dataTable;
            }
        }

        private void txt_LuongThoaThuan_TextChanged(object sender, EventArgs e)
        {
            if(txt_LuongThoaThuan.Text.Length>15)
            {
                MessageBox.Show("Vượt tầm kiểm soát số liệu (max 15 số)");
                txt_LuongThoaThuan.Text=txt_LuongThoaThuan.Text.Substring(0, 15);
            }
        }

        private void txt_LuongThoaThuan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (qUOCTICHComboBox.SelectedValue != null && dANTOCComboBox.SelectedValue != null && tONGIAOComboBox.SelectedValue != null)
            {
                //luu hinh anh
                insertHinhAnh();
                //update du lieu cua ung vien
                hOSOTUYENDUNGTableAdapter.Update(mAUNGVIENTextEdit.Text, dANTOCComboBox.SelectedValue.ToString(), tONGIAOComboBox.SelectedValue.ToString(), qUOCTICHComboBox.SelectedValue.ToString(), hOTENTextEdit.Text, cbo_GioiTinh.Text, nGAYSINHDateEdit.DateTime, nOISINHTextEdit.Text, cMNDTextEdit.Text, nGAYCAPDateEdit.DateTime, nOICAPTextEdit.Text, qUEQUANTextEdit.Text, dIACHITHUONGTRUTextEdit.Text, nOIOHIENTAITextEdit.Text, dIENTHOAITextEdit.Text, eMAILTextEdit.Text, tINHTRANGHONNHANTextEdit.Text, dIENUUTIENTextEdit.Text, tINHTRANGSUCKHOETextEdit.Text, nGAYTUYENDUNGDateEdit.DateTime, hINHTHUCTUYENDUNGTextEdit.Text, vITRITUYENDUNGTextEdit.Text, mATRINHDOHOCVANTextEdit.Text, mATRINHDOTINHOCTextEdit.Text, mAUNGVIENTextEdit.Text, dANTOCComboBox.SelectedValue.ToString(), tONGIAOComboBox.SelectedValue.ToString(), qUOCTICHComboBox.SelectedValue.ToString(), hOTENTextEdit.Text, cbo_GioiTinh.Text, nGAYSINHDateEdit.DateTime, nOISINHTextEdit.Text, cMNDTextEdit.Text, nGAYCAPDateEdit.DateTime, nOICAPTextEdit.Text, qUEQUANTextEdit.Text, dIACHITHUONGTRUTextEdit.Text, nOIOHIENTAITextEdit.Text, dIENTHOAITextEdit.Text, eMAILTextEdit.Text, tINHTRANGHONNHANTextEdit.Text, dIENUUTIENTextEdit.Text, tINHTRANGSUCKHOETextEdit.Text, nGAYTUYENDUNGDateEdit.DateTime, hINHTHUCTUYENDUNGTextEdit.Text, vITRITUYENDUNGTextEdit.Text, mATRINHDOHOCVANTextEdit.Text, mATRINHDOTINHOCTextEdit.Text);
                //update chuyen mon
                for(int i=0;i<gridView1.RowCount;i++)
                {
                    if (gridView1.IsRowSelected(i))
                    {
                        try
                        {
                            cHITIETCHUYENMONTableAdapter.Insert(gridView1.GetRowCellValue(i,"MACHUYENMON").ToString(), mAUNGVIENTextEdit.Text);
                        }
                        catch
                        {
                            cHITIETCHUYENMONTableAdapter.Update(gridView1.GetRowCellValue(i, "MACHUYENMON").ToString(), mAUNGVIENTextEdit.Text);
                        }
                    }
                    else
                    {
                        try
                        {
                            cHITIETCHUYENMONTableAdapter.Delete(gridView1.GetRowCellValue(i, "MACHUYENMON").ToString(), mAUNGVIENTextEdit.Text);
                        }
                        catch
                        {

                        }
                    }
                }
                //update ngoai ngu
                for (int i = 0; i < gridView2.RowCount; i++)
                {
                    if (gridView2.IsRowSelected(i))
                    {
                        try
                        {
                            cHITIETNGOAINGUTableAdapter.Insert(gridView2.GetRowCellValue(i, "MANGOAINGU").ToString(), mAUNGVIENTextEdit.Text);
                        }
                        catch
                        {
                            cHITIETNGOAINGUTableAdapter.Update(gridView2.GetRowCellValue(i, "MANGOAINGU").ToString(), mAUNGVIENTextEdit.Text);
                        }
                    }
                    else
                    {
                        try
                        {
                             cHITIETNGOAINGUTableAdapter.Delete(gridView2.GetRowCellValue(i, "MANGOAINGU").ToString(), mAUNGVIENTextEdit.Text);
                        }
                        catch
                        {

                        }
                    }
                }

                MessageBox.Show("Sửa thành công");
            }
        }
        //DataRow row = dataTable.NewRow();
        //row["Ten"] = gridView1.GetRowCellValue(i, colMACHUYENMON).ToString();
        //row["Ma"] = gridView1.GetRowCellValue(i, colMACHUYENMON).ToString();
        //row["Ckeck"] = DefaultValue.False;
        //dataTable.Rows.Add(row);
        // int[] u = gridView1.GetSelectedRows();
        //foreach(int y in u) {
        //    ...Inssert(gridView1.GetRowCellValue(y, colCoChuyenMon),...,);

        //int tt = gridView1.FocusedRowHandle;

        ////gridView1.SetRowCellValue(i, "colCoChuyenMon", 1);//"True");
    }
}
