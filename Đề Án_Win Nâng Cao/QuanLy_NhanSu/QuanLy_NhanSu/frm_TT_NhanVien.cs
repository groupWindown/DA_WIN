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

           // DataGridView dtr = bLL_Load.BLL_loadNhanVien();
            dataGridView2.DataSource = bLL_Load.BLL_loadNhanVien();
            for (int i=0;i< dataGridView2.Rows.Count;i++)
            {
                DataGridViewRow dataRow = new DataGridViewRow();
                dataRow = dataGridView2.Rows[i];
                if (dataRow.Cells["TINHTRANG"].Value != null)
                {
                    if (dataRow.Cells["TINHTRANG"].Value.ToString() == "Đang làm")
                    {
                        string pMaUV = dataRow.Cells["MANV"].Value.ToString();
                        string pTenUV = dataRow.Cells["HOTEN"].Value.ToString();
                        string pNgayUV = dataRow.Cells["NGAYVAOLAM"].Value.ToString().Split(' ')[0].ToString();
                        string pSDTUV = bLL_Load.BLL_loadTenPhongBan( dataRow.Cells["MAPHONGBAN"].Value.ToString().Trim());
                        string pEMailUV = dataRow.Cells["MAHOSO"].Value.ToString();
                        string pChucVuUV = bLL_Load.BLL_loadTenChucVu( dataRow.Cells["MACHUCVU"].Value.ToString().Trim());

                        UserControl_Dong_NhanVien usercotrol = new UserControl_Dong_NhanVien(pMaUV, pTenUV, pNgayUV, pSDTUV, pEMailUV, pChucVuUV, loadhinh(pMaUV));
                       
                        listQLNS.Add(usercotrol);
                    }
                }
            }
        }
        private Image loadhinh(string v)
        {
            try
            {
                //DataSetQLNS.HINHANHDataTable data = dataSetQLNS.HINHANH;
                //foreach (DataSetQLNS.HINHANHRow rows in data.Rows)
                //{
                //    if (rows.MAUNGVIEN.ToString() == v)
                //    {
                //        return byteArrayToImage(rows.URL.ToArray());
                //    }
                //}
                return null;

            }
            catch
            {
                return null;
            }
        }

        private void txt_HoTen_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}
