using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_NhanSu
{
    public partial class frm_TT_UngVien : UserControl
    {
        List<UserControl_Dong_UngVien> listQLNS = new List<UserControl_Dong_UngVien>();
        public frm_TT_UngVien()
        {
            InitializeComponent();
        }

        private void frm_TT_UngVien_Load(object sender, EventArgs e)
        {
            loadctrldong();

            sapxep(listQLNS);
        }

        private void loadctrldong()
        {
            listQLNS.Clear();

            hOSOTUYENDUNGTableAdapter.Fill(dataSetQLNS.HOSOTUYENDUNG);
            foreach (DataRow dataRow in dataSetQLNS.HOSOTUYENDUNG)
            {
                string pMaUV = dataRow["MAUNGVIEN"].ToString();
                string pTenUV = dataRow["HOTEN"].ToString();
                string pNgayUV = dataRow["NGAYSINH"].ToString().Split(' ')[0].ToString();
                string pSDTUV = dataRow["DIENTHOAI"].ToString();
                string pEMailUV = dataRow["EMAIL"].ToString();
                string pChucVuUV = dataRow["VITRITUYENDUNG"].ToString();
                UserControl_Dong_UngVien usercotrol = new UserControl_Dong_UngVien(pMaUV, pTenUV, pNgayUV, pSDTUV, pEMailUV, pChucVuUV);

                listQLNS.Add(usercotrol);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

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
            //foreach (UserControl_Dong_UngVien control in lst)
            //{
            //    if (control.GetType() == typeof(UserControl_Dong_UngVien))
            //    {

            //        control.Location = new Point(x, y);
            //        panel_TT_UngVien.Controls.Add(control);
            //        x += 323;

            //        if (bac >= 1)
            //        {
            //            y += 150;
            //            x = 10;
            //            bac = 0;
            //        }
            //        else
            //        {
            //            bac++;
            //        }
            //    }
            //}
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
                    }
                    else
                    {
                        bac++;
                        x--;
                        y--;
                    }
                }
            }
        }
    }
}
