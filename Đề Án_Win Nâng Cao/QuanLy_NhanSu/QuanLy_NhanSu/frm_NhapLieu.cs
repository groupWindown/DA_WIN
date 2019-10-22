using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_NhanSu
{
    public partial class frm_NhapLieu : UserControl
        
    {
       
        public frm_NhapLieu()
        {
            
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void frm_NhapLieu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetQLNS.QUOCTICH' table. You can move, or remove it, as needed.
            this.qUOCTICHTableAdapter.Fill(this.dataSetQLNS.QUOCTICH);
            // TODO: This line of code loads data into the 'dataSetQLNS.TONGIAO' table. You can move, or remove it, as needed.
            this.tONGIAOTableAdapter.Fill(this.dataSetQLNS.TONGIAO);
            // TODO: This line of code loads data into the 'dataSetQLNS.DANTOC' table. You can move, or remove it, as needed.
            this.dANTOCTableAdapter.Fill(this.dataSetQLNS.DANTOC);
            // TODO: This line of code loads data into the 'dataSetQLNS.PHONGBAN' table. You can move, or remove it, as needed.
            this.pHONGBANTableAdapter.Fill(this.dataSetQLNS.PHONGBAN);
            // TODO: This line of code loads data into the 'dataSetQLNS.CHUCVU' table. You can move, or remove it, as needed.
            this.cHUCVUTableAdapter.Fill(this.dataSetQLNS.CHUCVU);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void load_dataChucVu()
        {
            gridControl_ChucVu.DataSource = cHUCVUTableAdapter.Fill(this.dataSetQLNS.CHUCVU);
        }


        public bool KTKC_New(string pKhoaChinh, DataTable pdt)
        {
            DataRow dtKiemTra = pdt.Rows.Find(pKhoaChinh);
            if (dtKiemTra != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        private void btn_Them_ChucVu_Click(object sender, EventArgs e)
        {
            //kiem tra khoa chinh
            if (KTKC_New(txt_MaCV.Text.ToString(), dataSetQLNS.CHUCVU) == false)
            {
                cHUCVUTableAdapter.Insert(txt_MaCV.Text, txt_TenCV.Text);
                load_dataChucVu();
                MessageBox.Show("Thêm thành công !!!");
            }
            else
            {
                MessageBox.Show("Trùng khoá chính !!!");
            }
        }

        private void btn_Xoa_ChucVu_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            int cathu = gridView1.FocusedRowHandle;
            string sql_macv = gridView1.GetRowCellValue(cathu, "MACHUCVU").ToString();
            string sql_tencv = gridView1.GetRowCellValue(cathu, "TENCHUCVU").ToString();
            MessageBox.Show(sql_macv);
            cHUCVUTableAdapter.Delete (sql_macv,sql_tencv);
            load_dataChucVu();
        }

        private void btn_Sua_ChucVu_Click(object sender, EventArgs e)
        {
            int cathu = gridView1.FocusedRowHandle;
            String sql_macv = gridView1.GetRowCellValue(cathu, "MACHUCVU").ToString();
            String sql_tencv = gridView1.GetRowCellValue(cathu, "TENCHUCVU").ToString();

            MessageBox.Show(sql_macv+".............."+sql_tencv);
            DataSetQLNS.CHUCVURow data= dataSetQLNS.CHUCVU.FindByMACHUCVU(sql_macv);
            data.TENCHUCVU = sql_tencv;
            cHUCVUTableAdapter.Update(this.dataSetQLNS.CHUCVU);
            //cHUCVUTableAdapter
            load_dataChucVu();
        }
        
        private void btn_Them_PhongBan_Click(object sender, EventArgs e)
        {
            if (KTKC_New(txt_MaPhongBan.Text.ToString(), dataSetQLNS.PHONGBAN) == false)
            {
                pHONGBANTableAdapter.Insert(txt_MaPhongBan.Text, txt_TenPhongBan.Text,txt_MaTruongPhong.Text);
                load_dataChucVu();
                MessageBox.Show("Thêm thành công !!!");
            }
            else
            {
                MessageBox.Show("Trùng khoá chính !!!");
            }
        }

        private void btn_Them_DanToc_Click(object sender, EventArgs e)
        {

        }
    }
}
