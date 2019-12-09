using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_NhanSu
{
    public partial class frm_TT_UngVien : UserControl
    {
        List<UserControl_Dong_UngVien> listQLNS = new List<UserControl_Dong_UngVien>();
        List<UserControl_Dong_UngVien> listQLNSSearch = new List<UserControl_Dong_UngVien>();
        Trick st = new Trick();
        public frm_TT_UngVien()
        {
            InitializeComponent();
        }

        private void frm_TT_UngVien_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.controldongclick = null;

            kQ_TUYENDUNGTableAdapter.Fill(dataSetQLNS.KQ_TUYENDUNG);
            hOSOTUYENDUNGTableAdapter.Fill(dataSetQLNS.HOSOTUYENDUNG);
            hINHANHTableAdapter.Fill(dataSetQLNS.HINHANH);
            cHITIETNGOAINGUTableAdapter.Fill(dataSetQLNS.CHITIETNGOAINGU);
            cHITIETCHUYENMONTableAdapter.Fill(dataSetQLNS.CHITIETCHUYENMON);
            cHUYENMONTableAdapter.Fill(dataSetQLNS.CHUYENMON);
            nGOAINGUTableAdapter.Fill(dataSetQLNS.NGOAINGU);
            load();
        }

        private void loadctrldong()
        {
            listQLNS.Clear();

            
            foreach (DataRow dataRow in dataSetQLNS.HOSOTUYENDUNG)
            {
                if (kiemtratrungMaUngVien(dataRow["MAUNGVIEN"].ToString())==true)
                {
                    string pMaUV = dataRow["MAUNGVIEN"].ToString();
                    string pTenUV = dataRow["HOTEN"].ToString();
                    string pNgayUV = dataRow["NGAYSINH"].ToString().Split(' ')[0].ToString();
                    string pSDTUV = dataRow["DIENTHOAI"].ToString();
                    string pEMailUV = dataRow["EMAIL"].ToString();
                    string pChucVuUV = dataRow["VITRITUYENDUNG"].ToString();
                    
                    UserControl_Dong_UngVien usercotrol = new UserControl_Dong_UngVien(pMaUV, pTenUV, pNgayUV, pSDTUV, pEMailUV, pChucVuUV,loadhinh(pMaUV));

                    listQLNS.Add(usercotrol);
                }
            }
        }
        private Image loadhinh(string v)
        {
            try
            {
                DataSetQLNS.HINHANHDataTable data = dataSetQLNS.HINHANH;
                foreach (DataSetQLNS.HINHANHRow rows in data.Rows)
                {
                    if (rows.MAUNGVIEN.ToString() == v)
                    {
                        return st.byteArrayToImage(rows.URL.ToArray());
                    }
                }
                return null;

            }
            catch
            {
                return null;
            }
        }
      

        private bool kiemtratrungMaUngVien(string v)
        {
            DataSetQLNS.KQ_TUYENDUNGDataTable datatable = dataSetQLNS.KQ_TUYENDUNG;
            foreach(DataSetQLNS.KQ_TUYENDUNGRow rows in datatable)
            {
                if (rows.MAUNGVIEN.ToString() == v)
                    return false;
            }
            return true;
        }

        private void hOSOTUYENDUNGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hOSOTUYENDUNGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetQLNS);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void sapxep(List<UserControl_Dong_UngVien> lst)
        {
            int x = 1;
            int y = 1;
            panel_TT_UngVien.Controls.Clear();

            int bac =0;
     
            foreach (UserControl_Dong_UngVien control in lst)
            {
                if (control.GetType() == typeof(UserControl_Dong_UngVien))
                {

                    control.Location = new Point(x, y);
                    panel_TT_UngVien.Controls.Add(control);
                    x += 222;

                    if (bac >= 2)
                    {
                        y += 108;
                        x = 1;
                        bac = 0;
                        y--;
                        x--;
                    }
                    else
                    {
                        bac++;
                        x--;
                    }
                }
            }
        }

        private void txt_MaUV_TextChanged(object sender, EventArgs e)
        {
            if (txt_MaUV.Text.Trim().Length > 0 && txt_HoTenUV.Text.Trim().Length > 0 && txt_ChucVu.Text.Length > 0)
            {
                listQLNSSearch.Clear();

                foreach (DataRow dataRow in dataSetQLNS.HOSOTUYENDUNG)
                {
                    if (kiemtratrungMaUngVien(dataRow["MAUNGVIEN"].ToString()) == true)
                    {
                        string pMaUV = dataRow["MAUNGVIEN"].ToString();
                        string pTenUV = dataRow["HOTEN"].ToString();
                        string pNgayUV = dataRow["NGAYSINH"].ToString().Split(' ')[0].ToString();
                        string pSDTUV = dataRow["DIENTHOAI"].ToString();
                        string pEMailUV = dataRow["EMAIL"].ToString();
                        string pChucVuUV = dataRow["VITRITUYENDUNG"].ToString();
                        UserControl_Dong_UngVien usercotrol = new UserControl_Dong_UngVien(pMaUV, pTenUV, pNgayUV, pSDTUV, pEMailUV, pChucVuUV, loadhinh(pMaUV));
                        if (pMaUV.ToLower().ToString().Contains(txt_MaUV.Text.ToLower().ToString()) == true && pTenUV.ToLower().ToString().Contains(txt_HoTenUV.Text.ToLower().ToString()) == true && pChucVuUV.ToLower().ToString().Contains(txt_ChucVu.Text.ToLower().ToString()) == true)
                            listQLNSSearch.Add(usercotrol);
                    }
                }

                sapxep(listQLNSSearch);
            }
            else
            {
                if (txt_ChucVu.Text.Trim().Length > 0 && txt_HoTenUV.Text.Trim().Length > 0)
                {
                    listQLNSSearch.Clear();

                    foreach (DataRow dataRow in dataSetQLNS.HOSOTUYENDUNG)
                    {
                        if (kiemtratrungMaUngVien(dataRow["MAUNGVIEN"].ToString()) == true)
                        {
                            string pMaUV = dataRow["MAUNGVIEN"].ToString();
                            string pTenUV = dataRow["HOTEN"].ToString();
                            string pNgayUV = dataRow["NGAYSINH"].ToString().Split(' ')[0].ToString();
                            string pSDTUV = dataRow["DIENTHOAI"].ToString();
                            string pEMailUV = dataRow["EMAIL"].ToString();
                            string pChucVuUV = dataRow["VITRITUYENDUNG"].ToString();
                            UserControl_Dong_UngVien usercotrol = new UserControl_Dong_UngVien(pMaUV, pTenUV, pNgayUV, pSDTUV, pEMailUV, pChucVuUV, loadhinh(pMaUV));
                            if (pChucVuUV.ToLower().ToString().Contains(txt_ChucVu.Text.ToLower().ToString()) == true && pTenUV.ToLower().ToString().Contains(txt_HoTenUV.Text.ToLower().ToString()) == true)
                                listQLNSSearch.Add(usercotrol);
                        }
                    }

                    sapxep(listQLNSSearch);
                }
                else
                {
                    if (txt_MaUV.Text.Trim().Length > 0 && txt_ChucVu.Text.Trim().Length > 0)
                    {
                        listQLNSSearch.Clear();

                        foreach (DataRow dataRow in dataSetQLNS.HOSOTUYENDUNG)
                        {
                            if (kiemtratrungMaUngVien(dataRow["MAUNGVIEN"].ToString()) == true)
                            {
                                string pMaUV = dataRow["MAUNGVIEN"].ToString();
                                string pTenUV = dataRow["HOTEN"].ToString();
                                string pNgayUV = dataRow["NGAYSINH"].ToString().Split(' ')[0].ToString();
                                string pSDTUV = dataRow["DIENTHOAI"].ToString();
                                string pEMailUV = dataRow["EMAIL"].ToString();
                                string pChucVuUV = dataRow["VITRITUYENDUNG"].ToString();
                                UserControl_Dong_UngVien usercotrol = new UserControl_Dong_UngVien(pMaUV, pTenUV, pNgayUV, pSDTUV, pEMailUV, pChucVuUV, loadhinh(pMaUV));
                                if (pMaUV.ToLower().ToString().Contains(txt_MaUV.Text.ToLower().ToString()) == true && pChucVuUV.ToLower().ToString().Contains(txt_ChucVu.Text.ToLower().ToString()) == true)
                                    listQLNSSearch.Add(usercotrol);
                            }
                        }

                        sapxep(listQLNSSearch);
                    }
                    else
                    {
                        if (txt_MaUV.Text.Trim().Length > 0 && txt_HoTenUV.Text.Trim().Length > 0)
                        {
                            listQLNSSearch.Clear();

                            foreach (DataRow dataRow in dataSetQLNS.HOSOTUYENDUNG)
                            {
                                if (kiemtratrungMaUngVien(dataRow["MAUNGVIEN"].ToString()) == true)
                                {
                                    string pMaUV = dataRow["MAUNGVIEN"].ToString();
                                    string pTenUV = dataRow["HOTEN"].ToString();
                                    string pNgayUV = dataRow["NGAYSINH"].ToString().Split(' ')[0].ToString();
                                    string pSDTUV = dataRow["DIENTHOAI"].ToString();
                                    string pEMailUV = dataRow["EMAIL"].ToString();
                                    string pChucVuUV = dataRow["VITRITUYENDUNG"].ToString();
                                    UserControl_Dong_UngVien usercotrol = new UserControl_Dong_UngVien(pMaUV, pTenUV, pNgayUV, pSDTUV, pEMailUV, pChucVuUV, loadhinh(pMaUV));
                                    if (pMaUV.ToLower().ToString().Contains(txt_MaUV.Text.ToLower().ToString()) == true && pTenUV.ToLower().ToString().Contains(txt_HoTenUV.Text.ToLower().ToString()) == true)
                                        listQLNSSearch.Add(usercotrol);
                                }
                            }

                            sapxep(listQLNSSearch);
                        }
                        else
                        {
                            if (txt_MaUV.Text.Trim().Length > 0)
                            {
                                listQLNSSearch.Clear();

                                foreach (DataRow dataRow in dataSetQLNS.HOSOTUYENDUNG)
                                {
                                    if (kiemtratrungMaUngVien(dataRow["MAUNGVIEN"].ToString()) == true)
                                    {
                                        string pMaUV = dataRow["MAUNGVIEN"].ToString();
                                        string pTenUV = dataRow["HOTEN"].ToString();
                                        string pNgayUV = dataRow["NGAYSINH"].ToString().Split(' ')[0].ToString();
                                        string pSDTUV = dataRow["DIENTHOAI"].ToString();
                                        string pEMailUV = dataRow["EMAIL"].ToString();
                                        string pChucVuUV = dataRow["VITRITUYENDUNG"].ToString();
                                        UserControl_Dong_UngVien usercotrol = new UserControl_Dong_UngVien(pMaUV, pTenUV, pNgayUV, pSDTUV, pEMailUV, pChucVuUV, loadhinh(pMaUV));
                                        if (pMaUV.ToLower().ToString().Contains(txt_MaUV.Text.ToLower().ToString()) == true)
                                            listQLNSSearch.Add(usercotrol);
                                    }
                                }
                                sapxep(listQLNSSearch);
                            }
                            else
                            {

                                if (txt_HoTenUV.Text.Trim().Length > 0)
                                {
                                    listQLNSSearch.Clear();

                                    foreach (DataRow dataRow in dataSetQLNS.HOSOTUYENDUNG)
                                    {
                                        if (kiemtratrungMaUngVien(dataRow["MAUNGVIEN"].ToString()) == true)
                                        {
                                            string pMaUV = dataRow["MAUNGVIEN"].ToString();
                                            string pTenUV = dataRow["HOTEN"].ToString();
                                            string pNgayUV = dataRow["NGAYSINH"].ToString().Split(' ')[0].ToString();
                                            string pSDTUV = dataRow["DIENTHOAI"].ToString();
                                            string pEMailUV = dataRow["EMAIL"].ToString();
                                            string pChucVuUV = dataRow["VITRITUYENDUNG"].ToString();
                                            UserControl_Dong_UngVien usercotrol = new UserControl_Dong_UngVien(pMaUV, pTenUV, pNgayUV, pSDTUV, pEMailUV, pChucVuUV, loadhinh(pMaUV));
                                            if (pTenUV.ToLower().ToString().Contains(txt_HoTenUV.Text.ToLower().ToString()) == true)
                                                listQLNSSearch.Add(usercotrol);
                                        }
                                    }
                                    sapxep(listQLNSSearch);
                                }
                                else
                                {
                                    if (txt_ChucVu.Text.Trim().Length > 0)
                                    {
                                        listQLNSSearch.Clear();

                                        foreach (DataRow dataRow in dataSetQLNS.HOSOTUYENDUNG)
                                        {
                                            if (kiemtratrungMaUngVien(dataRow["MAUNGVIEN"].ToString()) == true)
                                            {
                                                string pMaUV = dataRow["MAUNGVIEN"].ToString();
                                                string pTenUV = dataRow["HOTEN"].ToString();
                                                string pNgayUV = dataRow["NGAYSINH"].ToString().Split(' ')[0].ToString();
                                                string pSDTUV = dataRow["DIENTHOAI"].ToString();
                                                string pEMailUV = dataRow["EMAIL"].ToString();
                                                string pChucVuUV = dataRow["VITRITUYENDUNG"].ToString();
                                                UserControl_Dong_UngVien usercotrol = new UserControl_Dong_UngVien(pMaUV, pTenUV, pNgayUV, pSDTUV, pEMailUV, pChucVuUV, loadhinh(pMaUV));
                                                if (pChucVuUV.ToLower().ToString().Contains(txt_ChucVu.Text.ToLower().ToString()) == true)
                                                    listQLNSSearch.Add(usercotrol);
                                            }
                                        }
                                        sapxep(listQLNSSearch);
                                    }
                                    else
                                    {
                                        sapxep(listQLNS);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btn_ThemUV_Click(object sender, EventArgs e)
        {
            frm_ThemUV frm = new frm_ThemUV();
            frm.ShowDialog();

            //load lại
            load();
         
        }

        private void load()
        {
            loadctrldong();
            sapxep(listQLNS);
        }

        private void btn_XoaUV_Click(object sender, EventArgs e)
        {
            foreach(Control userctrl in panel_TT_UngVien.Controls)
            {
                if(userctrl.GetType()==typeof(UserControl_Dong_UngVien))
                {
                    if(Properties.Settings.Default.controldongclick!=null)
                    {
                        xoaUV(Properties.Settings.Default.controldongclick);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Chọn UV mún xóa");
                    }
                }
            }
        }

        private void xoaUV(string pMaUV)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            DataSetQLNS.HOSOTUYENDUNGRow data = dataSetQLNS.HOSOTUYENDUNG.FindByMAUNGVIEN(pMaUV);

            //xoa chi tiet chuyen mon
            foreach(DataSetQLNS.CHUYENMONRow cm in dataSetQLNS.CHUYENMON)
            {
                try
                {
                    cHITIETCHUYENMONTableAdapter.Delete(cm.MACHUYENMON, pMaUV);
                }
                catch
                {    }
            }
            //xoa chi tiet ngoai ngu
            foreach (DataSetQLNS.NGOAINGURow nn in dataSetQLNS.NGOAINGU)
            {
                try
                {
                    cHITIETNGOAINGUTableAdapter.Delete(nn.MANGOAINGU, pMaUV);
                }
                catch
                { }
            }
            //xoa ung vien
            hOSOTUYENDUNGTableAdapter.Delete(pMaUV,data.MADANTOC, data.MATONGIAO, data.MAQUOCTICH, data.HOTEN, data.GIOITINH, data.NGAYSINH, data.NOISINH, data.CMND, data.NGAYCAP, data.NOICAP, data.QUEQUAN, data.DIACHITHUONGTRU, data.NOIOHIENTAI, data.DIENTHOAI, data.EMAIL, data.TINHTRANGHONNHAN, data.DIENUUTIEN, data.TINHTRANGSUCKHOE, data.NGAYTUYENDUNG, data.HINHTHUCTUYENDUNG, data.VITRITUYENDUNG, data.MATRINHDOHOCVAN, data.MATRINHDOTINHOC);
            load();
            Properties.Settings.Default.controldongclick = null;
        }

      
    }
}
