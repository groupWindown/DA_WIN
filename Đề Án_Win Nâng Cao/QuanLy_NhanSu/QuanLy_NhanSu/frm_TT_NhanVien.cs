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
        Strick st = new Strick();
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
            //update tai khoan

            //update nhan vien


        }
    }
}
