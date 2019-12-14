using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraScheduler;
using BLL;
using DAL;

namespace QuanLy_NhanSu
{

    public partial class frm_TT_NhanVien : UserControl
    {
        List<UserControl_Dong_NhanVien> listQLNS = new List<UserControl_Dong_NhanVien>();
        List<UserControl_Dong_NhanVien> listQLNSSearch = new List<UserControl_Dong_NhanVien>();
        BLL_Load bLL_Load = new BLL_Load();
        BLL_NhanVien bLL_NhanVien = new BLL_NhanVien();
        Trick st = new Trick();
        public frm_TT_NhanVien()
        {
            InitializeComponent();
        }

        private void from_TT_NhanVien_Load(object sender, EventArgs e)
        {
          
            cbo_ChucVu.DataSource = bLL_Load.BLL_loadChucVu();
            cbo_PhongBan.DataSource = bLL_Load.BLL_loadPhongBan();
            cbo_ChucVu.ValueMember = "MACHUCVU";
            cbo_PhongBan.ValueMember = "MAPHONGBAN";
            cbo_ChucVu.DisplayMember = "TENCHUCVU";
            cbo_PhongBan.DisplayMember = "TENPHONGBAN";

            cbo_ChucVu.Text = "";
            cbo_PhongBan.Text = "";
            load();
        }

        private void load()
        {
            loadctrldong();
            sapxep(listQLNS);
        }
        private void sapxep(List<UserControl_Dong_NhanVien> lst)
        {
            int x = 1;
            int y = 1;
            panel_TT_NhanVien.Controls.Clear();

            int bac = 0;

            foreach (UserControl_Dong_NhanVien control in lst)
            {
                if (control.GetType() == typeof(UserControl_Dong_NhanVien))
                {

                    control.Location = new Point(x, y);
                    panel_TT_NhanVien.Controls.Add(control);
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
        private void loadctrldong()
        {
            listQLNS.Clear();
     
     
            dataGridView_gerSRC.DataSource = bLL_Load.BLL_loadNhanVien();
            for (int i=0;i< dataGridView_gerSRC.Rows.Count;i++)
            {
                DataGridViewRow dataRow = new DataGridViewRow();
                dataRow = dataGridView_gerSRC.Rows[i];
                if (dataRow.Cells["TINHTRANG"].Value != null)
                {
                    if (dataRow.Cells["TINHTRANG"].Value.ToString() == "Đang làm")
                    {
                        string pMaUV = dataRow.Cells["MANV"].Value.ToString();
                        string pTenUV = dataRow.Cells["HOTEN"].Value.ToString();
                        string pNgayUV = dataRow.Cells["NGAYVAOLAM"].Value.ToString().Split(' ')[0].ToString();
                        string pPhongBan = bLL_Load.BLL_loadTenPhongBan( dataRow.Cells["MAPHONGBAN"].Value.ToString().Trim());
                        string pHoSo = dataRow.Cells["MAHOSO"].Value.ToString();
                        string pChucVuUV = bLL_Load.BLL_loadTenChucVu( dataRow.Cells["MACHUCVU"].Value.ToString().Trim());

                        UserControl_Dong_NhanVien usercotrol = new UserControl_Dong_NhanVien(pMaUV, pTenUV, pNgayUV, pPhongBan, pHoSo, pChucVuUV, loadhinh(pMaUV));
                       
                        listQLNS.Add(usercotrol);
                    }
                }
            }
        }
        private Image loadhinh(string v)
        {
            try
            {
                byte[] kq=bLL_Load.BLL_loadURLHinhAnh(v);
                if (kq!=null)
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

        private void txt_HoTen_TextChanged(object sender, EventArgs e)
        {

            if (txt_HoTen.Text.Trim().Length > 0 && cbo_ChucVu.Text.Trim().Length > 0 && cbo_PhongBan.Text.Length > 0)
            {
                listQLNSSearch.Clear();

                dataGridView_gerSRC.DataSource = bLL_Load.BLL_loadNhanVien();
                for (int i = 0; i < dataGridView_gerSRC.Rows.Count; i++)
                {
                    DataGridViewRow dataRow = new DataGridViewRow();
                    dataRow = dataGridView_gerSRC.Rows[i];
                    if (dataRow.Cells["TINHTRANG"].Value != null)
                    {
                        if (dataRow.Cells["TINHTRANG"].Value.ToString() == "Đang làm")
                        {
                            string pMaUV = dataRow.Cells["MANV"].Value.ToString();
                            string pTenUV = dataRow.Cells["HOTEN"].Value.ToString();
                            string pNgayUV = dataRow.Cells["NGAYVAOLAM"].Value.ToString().Split(' ')[0].ToString();
                            string pPhongBan = bLL_Load.BLL_loadTenPhongBan(dataRow.Cells["MAPHONGBAN"].Value.ToString().Trim());
                            string pHoSo = dataRow.Cells["MAHOSO"].Value.ToString();
                            string pChucVuUV = bLL_Load.BLL_loadTenChucVu(dataRow.Cells["MACHUCVU"].Value.ToString().Trim());

                            UserControl_Dong_NhanVien usercotrol = new UserControl_Dong_NhanVien(pMaUV, pTenUV, pNgayUV, pPhongBan, pHoSo, pChucVuUV, loadhinh(pMaUV));
                            if (pTenUV.ToLower().ToString().Contains(txt_HoTen.Text.ToLower().ToString()) == true && pPhongBan.ToLower().ToString().Contains(cbo_PhongBan.Text.ToLower().ToString()) == true && pChucVuUV.ToLower().ToString().Contains(cbo_ChucVu.Text.ToLower().ToString()) == true)
                                listQLNSSearch.Add(usercotrol);
                        }
                    }
                }

                sapxep(listQLNSSearch);
            }
            else
            {
                if (txt_HoTen.Text.Trim().Length > 0 && cbo_ChucVu.Text.Trim().Length > 0)
                {
                    listQLNSSearch.Clear();

                    dataGridView_gerSRC.DataSource = bLL_Load.BLL_loadNhanVien();
                    for (int i = 0; i < dataGridView_gerSRC.Rows.Count; i++)
                    {
                        DataGridViewRow dataRow = new DataGridViewRow();
                        dataRow = dataGridView_gerSRC.Rows[i];
                        if (dataRow.Cells["TINHTRANG"].Value != null)
                        {
                            if (dataRow.Cells["TINHTRANG"].Value.ToString() == "Đang làm")
                            {
                                string pMaUV = dataRow.Cells["MANV"].Value.ToString();
                                string pTenUV = dataRow.Cells["HOTEN"].Value.ToString();
                                string pNgayUV = dataRow.Cells["NGAYVAOLAM"].Value.ToString().Split(' ')[0].ToString();
                                string pPhongBan = bLL_Load.BLL_loadTenPhongBan(dataRow.Cells["MAPHONGBAN"].Value.ToString().Trim());
                                string pHoSo = dataRow.Cells["MAHOSO"].Value.ToString();
                                string pChucVuUV = bLL_Load.BLL_loadTenChucVu(dataRow.Cells["MACHUCVU"].Value.ToString().Trim());

                                UserControl_Dong_NhanVien usercotrol = new UserControl_Dong_NhanVien(pMaUV, pTenUV, pNgayUV, pPhongBan, pHoSo, pChucVuUV, loadhinh(pMaUV));
                                if (pTenUV.ToLower().ToString().Contains(txt_HoTen.Text.ToLower().ToString()) == true && pChucVuUV.ToLower().ToString().Contains(cbo_ChucVu.Text.ToLower().ToString()) == true)
                                    listQLNSSearch.Add(usercotrol);
                            }
                        }
                    }

                    sapxep(listQLNSSearch);
                }
                else
                {
                    if (txt_HoTen.Text.Trim().Length > 0 && cbo_PhongBan.Text.Length > 0)
                    {
                        listQLNSSearch.Clear();

                        dataGridView_gerSRC.DataSource = bLL_Load.BLL_loadNhanVien();
                        for (int i = 0; i < dataGridView_gerSRC.Rows.Count; i++)
                        {
                            DataGridViewRow dataRow = new DataGridViewRow();
                            dataRow = dataGridView_gerSRC.Rows[i];
                            if (dataRow.Cells["TINHTRANG"].Value != null)
                            {
                                if (dataRow.Cells["TINHTRANG"].Value.ToString() == "Đang làm")
                                {
                                    string pMaUV = dataRow.Cells["MANV"].Value.ToString();
                                    string pTenUV = dataRow.Cells["HOTEN"].Value.ToString();
                                    string pNgayUV = dataRow.Cells["NGAYVAOLAM"].Value.ToString().Split(' ')[0].ToString();
                                    string pPhongBan = bLL_Load.BLL_loadTenPhongBan(dataRow.Cells["MAPHONGBAN"].Value.ToString().Trim());
                                    string pHoSo = dataRow.Cells["MAHOSO"].Value.ToString();
                                    string pChucVuUV = bLL_Load.BLL_loadTenChucVu(dataRow.Cells["MACHUCVU"].Value.ToString().Trim());

                                    UserControl_Dong_NhanVien usercotrol = new UserControl_Dong_NhanVien(pMaUV, pTenUV, pNgayUV, pPhongBan, pHoSo, pChucVuUV, loadhinh(pMaUV));
                                    if (pTenUV.ToLower().ToString().Contains(txt_HoTen.Text.ToLower().ToString()) == true && pPhongBan.ToLower().ToString().Contains(cbo_PhongBan.Text.ToLower().ToString()) == true)
                                        listQLNSSearch.Add(usercotrol);
                                }
                            }
                        }

                        sapxep(listQLNSSearch);
                    }
                    else
                    {
                        if (cbo_ChucVu.Text.Trim().Length > 0 && cbo_PhongBan.Text.Length > 0)
                        {
                            listQLNSSearch.Clear();

                            dataGridView_gerSRC.DataSource = bLL_Load.BLL_loadNhanVien();
                            for (int i = 0; i < dataGridView_gerSRC.Rows.Count; i++)
                            {
                                DataGridViewRow dataRow = new DataGridViewRow();
                                dataRow = dataGridView_gerSRC.Rows[i];
                                if (dataRow.Cells["TINHTRANG"].Value != null)
                                {
                                    if (dataRow.Cells["TINHTRANG"].Value.ToString() == "Đang làm")
                                    {
                                        string pMaUV = dataRow.Cells["MANV"].Value.ToString();
                                        string pTenUV = dataRow.Cells["HOTEN"].Value.ToString();
                                        string pNgayUV = dataRow.Cells["NGAYVAOLAM"].Value.ToString().Split(' ')[0].ToString();
                                        string pPhongBan = bLL_Load.BLL_loadTenPhongBan(dataRow.Cells["MAPHONGBAN"].Value.ToString().Trim());
                                        string pHoSo = dataRow.Cells["MAHOSO"].Value.ToString();
                                        string pChucVuUV = bLL_Load.BLL_loadTenChucVu(dataRow.Cells["MACHUCVU"].Value.ToString().Trim());

                                        UserControl_Dong_NhanVien usercotrol = new UserControl_Dong_NhanVien(pMaUV, pTenUV, pNgayUV, pPhongBan, pHoSo, pChucVuUV, loadhinh(pMaUV));
                                        if (pPhongBan.ToLower().ToString().Contains(cbo_PhongBan.Text.ToLower().ToString()) == true && pChucVuUV.ToLower().ToString().Contains(cbo_ChucVu.Text.ToLower().ToString()) == true)
                                            listQLNSSearch.Add(usercotrol);
                                    }
                                }
                            }

                            sapxep(listQLNSSearch);
                        }
                        else
                        {
                            if (txt_HoTen.Text.Trim().Length > 0)
                            {
                                listQLNSSearch.Clear();

                                dataGridView_gerSRC.DataSource = bLL_Load.BLL_loadNhanVien();
                                for (int i = 0; i < dataGridView_gerSRC.Rows.Count; i++)
                                {
                                    DataGridViewRow dataRow = new DataGridViewRow();
                                    dataRow = dataGridView_gerSRC.Rows[i];
                                    if (dataRow.Cells["TINHTRANG"].Value != null)
                                    {
                                        if (dataRow.Cells["TINHTRANG"].Value.ToString() == "Đang làm")
                                        {
                                            string pMaUV = dataRow.Cells["MANV"].Value.ToString();
                                            string pTenUV = dataRow.Cells["HOTEN"].Value.ToString();
                                            string pNgayUV = dataRow.Cells["NGAYVAOLAM"].Value.ToString().Split(' ')[0].ToString();
                                            string pPhongBan = bLL_Load.BLL_loadTenPhongBan(dataRow.Cells["MAPHONGBAN"].Value.ToString().Trim());
                                            string pHoSo = dataRow.Cells["MAHOSO"].Value.ToString();
                                            string pChucVuUV = bLL_Load.BLL_loadTenChucVu(dataRow.Cells["MACHUCVU"].Value.ToString().Trim());

                                            UserControl_Dong_NhanVien usercotrol = new UserControl_Dong_NhanVien(pMaUV, pTenUV, pNgayUV, pPhongBan, pHoSo, pChucVuUV, loadhinh(pMaUV));
                                            if (pTenUV.ToLower().ToString().Contains(txt_HoTen.Text.ToLower().ToString()) == true)
                                                listQLNSSearch.Add(usercotrol);
                                        }
                                    }
                                }

                                sapxep(listQLNSSearch);
                            }
                            else
                            {
                                if (cbo_ChucVu.Text.Trim().Length > 0)
                                {
                                    listQLNSSearch.Clear();

                                    dataGridView_gerSRC.DataSource = bLL_Load.BLL_loadNhanVien();
                                    for (int i = 0; i < dataGridView_gerSRC.Rows.Count; i++)
                                    {
                                        DataGridViewRow dataRow = new DataGridViewRow();
                                        dataRow = dataGridView_gerSRC.Rows[i];
                                        if (dataRow.Cells["TINHTRANG"].Value != null)
                                        {
                                            if (dataRow.Cells["TINHTRANG"].Value.ToString() == "Đang làm")
                                            {
                                                string pMaUV = dataRow.Cells["MANV"].Value.ToString();
                                                string pTenUV = dataRow.Cells["HOTEN"].Value.ToString();
                                                string pNgayUV = dataRow.Cells["NGAYVAOLAM"].Value.ToString().Split(' ')[0].ToString();
                                                string pPhongBan = bLL_Load.BLL_loadTenPhongBan(dataRow.Cells["MAPHONGBAN"].Value.ToString().Trim());
                                                string pHoSo = dataRow.Cells["MAHOSO"].Value.ToString();
                                                string pChucVuUV = bLL_Load.BLL_loadTenChucVu(dataRow.Cells["MACHUCVU"].Value.ToString().Trim());

                                                UserControl_Dong_NhanVien usercotrol = new UserControl_Dong_NhanVien(pMaUV, pTenUV, pNgayUV, pPhongBan, pHoSo, pChucVuUV, loadhinh(pMaUV));
                                                if (pChucVuUV.ToLower().ToString().Contains(cbo_ChucVu.Text.ToLower().ToString()) == true)
                                                    listQLNSSearch.Add(usercotrol);
                                            }
                                        }
                                    }

                                    sapxep(listQLNSSearch);
                                }
                                else
                                {

                                    if (cbo_PhongBan.Text.Length > 0)
                                    {
                                        listQLNSSearch.Clear();

                                        dataGridView_gerSRC.DataSource = bLL_Load.BLL_loadNhanVien();
                                        for (int i = 0; i < dataGridView_gerSRC.Rows.Count; i++)
                                        {
                                            DataGridViewRow dataRow = new DataGridViewRow();
                                            dataRow = dataGridView_gerSRC.Rows[i];
                                            if (dataRow.Cells["TINHTRANG"].Value != null)
                                            {
                                                if (dataRow.Cells["TINHTRANG"].Value.ToString() == "Đang làm")
                                                {
                                                    string pMaUV = dataRow.Cells["MANV"].Value.ToString();
                                                    string pTenUV = dataRow.Cells["HOTEN"].Value.ToString();
                                                    string pNgayUV = dataRow.Cells["NGAYVAOLAM"].Value.ToString().Split(' ')[0].ToString();
                                                    string pPhongBan = bLL_Load.BLL_loadTenPhongBan(dataRow.Cells["MAPHONGBAN"].Value.ToString().Trim());
                                                    string pHoSo = dataRow.Cells["MAHOSO"].Value.ToString();
                                                    string pChucVuUV = bLL_Load.BLL_loadTenChucVu(dataRow.Cells["MACHUCVU"].Value.ToString().Trim());

                                                    UserControl_Dong_NhanVien usercotrol = new UserControl_Dong_NhanVien(pMaUV, pTenUV, pNgayUV, pPhongBan, pHoSo, pChucVuUV, loadhinh(pMaUV));
                                                    if (pPhongBan.ToLower().ToString().Contains(cbo_PhongBan.Text.ToLower().ToString()) == true)

                                                        listQLNSSearch.Add(usercotrol);
                                                }
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

        private void btn_SaThai_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.controldongclickmaNV != null)
            {
                if (Properties.Settings.Default.controldongclickmaNV.ToString().Trim().Length > 0)
                {
                    frm_QuanLyNghiViec frm = new frm_QuanLyNghiViec();
                    frm.ShowDialog();
                }
                else
                    MessageBox.Show("Vui lòng chọn nhân viên để xóa");
            }
            else
                MessageBox.Show("Vui lòng chọn nhân viên để xóa");
        }

        private void txtLuongThoaThuan_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.controldongclickmaNV != "")
            {
                frm_GiaHanHopDong frm = new frm_GiaHanHopDong(Properties.Settings.Default.controldongclickmaNV, gridViewThongtinHD.RowCount + 1);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên để tiếp tục");
                tabNavigationPage6.Select();
            }
        }

        private void tabNavigationPage4_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tabPane1_TabIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        
        }

        private void tabPane1_Click(object sender, EventArgs e)
        {

        }

        private void tabNavigationPage4_SizeChanged(object sender, EventArgs e)
        {
            
        }

        private void tabNavigationPage6_Leave(object sender, EventArgs e)
        {
           
        }

        private void tabNavigationPage4_Enter(object sender, EventArgs e)
        {
           
        }

        private void tabNavigationPage4_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void tabNavigationPage4_RegionChanged(object sender, EventArgs e)
        {
           
        }

        private void tabPane1_StateChanged(object sender, DevExpress.XtraBars.Navigation.StateChangedEventArgs e)
        {
            
        }

        private void tabPane1_SelectedPageIndexChanged(object sender, EventArgs e)
        {
            gridControlThongtinHD.DataSource=null;
            gridControlBaoHiem.DataSource=null;
            gridControlThongtinHD.DataSource = bLL_Load.BLL_loadHopDongNhanVien(Properties.Settings.Default.controldongclickmaNV);
            gridControlBaoHiem.DataSource= bLL_Load.BLL_loadBaoHiemNV(Properties.Settings.Default.controldongclickmaNV);
        }

        private void gridViewThongtinHD_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
        }

        private void gridViewThongtinHD_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridViewThongtinHD.DataRowCount > 0)
            {
                txtHoTenThongtin.Text = bLL_Load.BLL_loadThongTinNhanVien(Properties.Settings.Default.controldongclickmaNV).HOTEN.ToString();
                txtMaHopDong.Text = gridViewThongtinHD.GetFocusedRowCellValue("MaHopDong").ToString();
                txtKyLanThu.Text = gridViewThongtinHD.GetFocusedRowCellValue("KyLanThu").ToString();
                txtLuongThoaThuan.Text = gridViewThongtinHD.GetFocusedRowCellValue("LuongThoaThuan").ToString();
                cboChucVuThongtin.Text = bLL_Load.BLL_loadTenChucVu(bLL_Load.BLL_loadThongTinNhanVien(Properties.Settings.Default.controldongclickmaNV).MACHUCVU.ToString());
                cboPhongbanThongtiin.Text = bLL_Load.BLL_loadTenPhongBan(bLL_Load.BLL_loadThongTinNhanVien(Properties.Settings.Default.controldongclickmaNV).MAPHONGBAN.ToString());
                cboLoaiHopDong.Text = gridViewThongtinHD.GetFocusedRowCellValue("TenHopDong").ToString();
                dateEditNgayBatDau.Text = gridViewThongtinHD.GetFocusedRowCellValue("NgayBatDau").ToString().Split(' ')[0].ToString();
                dateEditNgayKy.Text = gridViewThongtinHD.GetFocusedRowCellValue("NgayKy").ToString().Split(' ')[0].ToString();
                dateEditNgayKetThuc.Text = gridViewThongtinHD.GetFocusedRowCellValue("NgayKetThuc").ToString().Split(' ')[0].ToString();

            }
        }

        private void btnInHopDong_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.controldongclickmaNV != "")
            {
            //    Word word = new Word();
            //    string HoTen=txtHoTenThongtin.Text;
            //    string MaNV= Properties.Settings.Default.controldongclickmaNV;
            //    string ChucVu=cboChucVuThongtin.Text;
            //    string PhongBan=cboPhongbanThongtiin.Text;
            //    string MaHopDong=txtMaHopDong.Text;
            //    string NgayKy=dateEditNgayKy.DateTime.ToString().Split('/')[1].ToString();
            //    string ThangKy = dateEditNgayKy.DateTime.ToString().Split('/')[0].ToString();
            //    string NamKy=dateEditNgayKy.DateTime.ToString().Split('/')[2].ToString();
            //    string NgayBD=dateEditNgayBatDau.DateTime.ToString();
            //    string NgayKT=dateEditNgayKetThuc.DateTime.ToString();
            //    string LoaiHopDong=cboLoaiHopDong.Text;
            //    string KyLanThu=txtKyLanThu.Text;
            //    string LuongThoaThuan=txtLuongThoaThuan.Text;
            //    word.W_HopDongLaoDong( HoTen, ChucVu,  MaHopDong,  NgayKy,ThangKy,NamKy,  NgayBD,  NgayKT,  LoaiHopDong,  LuongThoaThuan);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xuất hợp đồng mới");
            }
        }

        private void gridViewBaoHiem_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridViewBaoHiem.DataRowCount > 0)
            {
                txtHoTenBaoHiem.Text = bLL_Load.BLL_loadThongTinNhanVien(Properties.Settings.Default.controldongclickmaNV).HOTEN.ToString();
                txtMaBaoHiem.Text = gridViewBaoHiem.GetFocusedRowCellValue("MABAOHIEM").ToString();
                cboLoaiBaoHiem.Text = gridViewBaoHiem.GetFocusedRowCellValue("LOAIBAOHIEM").ToString();
                txtNoiCapBaoHiem.Text = gridViewBaoHiem.GetFocusedRowCellValue("NOICAP").ToString();
                cboChucVuBaoHiem.Text = bLL_Load.BLL_loadTenChucVu(bLL_Load.BLL_loadThongTinNhanVien(Properties.Settings.Default.controldongclickmaNV).MACHUCVU.ToString());
                cboPhongbanbaohiem.Text = bLL_Load.BLL_loadTenPhongBan(bLL_Load.BLL_loadThongTinNhanVien(Properties.Settings.Default.controldongclickmaNV).MAPHONGBAN.ToString());
                txtNoiKham.Text = gridViewBaoHiem.GetFocusedRowCellValue("NOIKHAM").ToString();
                dateEditNGayHetHan.Text = gridViewBaoHiem.GetFocusedRowCellValue("NGAYHH").ToString();
                dateEditNgayDangKy.Text = gridViewBaoHiem.GetFocusedRowCellValue("NGAYDK").ToString();

            }
            else
            {
                txtHoTenBaoHiem.Text = bLL_Load.BLL_loadThongTinNhanVien(Properties.Settings.Default.controldongclickmaNV).HOTEN.ToString();
                txtMaBaoHiem.Text = "";
                cboLoaiBaoHiem.Text = "";
                txtNoiCapBaoHiem.Text = "";
                cboChucVuBaoHiem.Text = bLL_Load.BLL_loadTenChucVu(bLL_Load.BLL_loadThongTinNhanVien(Properties.Settings.Default.controldongclickmaNV).MACHUCVU.ToString());
                cboPhongbanbaohiem.Text = bLL_Load.BLL_loadTenPhongBan(bLL_Load.BLL_loadThongTinNhanVien(Properties.Settings.Default.controldongclickmaNV).MAPHONGBAN.ToString());
                txtNoiKham.Text = "";
                dateEditNGayHetHan.Text = "";
                dateEditNgayDangKy.Text = "";
            }
        }

        private void btnDangKyBaoHiem_Click(object sender, EventArgs e)
        {
            if ( Properties.Settings.Default.controldongclickmaNV != "")
            {
                string a = Properties.Settings.Default.controldongclickmaNV;
                if (gridViewBaoHiem.DataRowCount > 0)
                {
                    frm_DangKyBaoHiem frm_DangKyBaoHiem = new frm_DangKyBaoHiem(Properties.Settings.Default.controldongclickmaNV);
                    frm_DangKyBaoHiem.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên để thêm bảo hiểm");
                tabNavigationPage6.Select();
            }
        }
    }
}
