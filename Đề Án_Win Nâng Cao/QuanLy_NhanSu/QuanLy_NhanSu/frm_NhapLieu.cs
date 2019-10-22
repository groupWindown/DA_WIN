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

        ///kiểm tra khóa chính
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
        
        //Chức vụ
        public void load_dataChucVu()
        {
            gridControl_ChucVu.DataSource = cHUCVUTableAdapter.Fill(this.dataSetQLNS.CHUCVU);
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


        ///Phòng ban
        public void load_dataPhongBan()
        {
            gridControl_PhongBan.DataSource = pHONGBANTableAdapter.Fill(this.dataSetQLNS.PHONGBAN);
        }

        private void btn_Them_PhongBan_Click(object sender, EventArgs e)
        {
            if (KTKC_New(txt_MaPhongBan.Text.ToString(), dataSetQLNS.PHONGBAN) == false)
            {
                pHONGBANTableAdapter.Insert(txt_MaPhongBan.Text, txt_TenPhongBan.Text, txt_MaTruongPhong.Text);
                load_dataPhongBan();
                MessageBox.Show("Thêm thành công !!!");
            }
            else
            {
                MessageBox.Show("Trùng khoá chính !!!");
            }
        }

        private void btn_Xoa_PhongBan_Click(object sender, EventArgs e)
        {
            try
            {


                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                int dd = gridView_PhongBan.FocusedRowHandle;
                string sql_mapb = gridView_PhongBan.GetRowCellValue(dd, "MAPHONGBAN").ToString();
                string sql_tenpb = gridView_PhongBan.GetRowCellValue(dd, "TENPHONGBAN").ToString();
                string sql_matp = gridView_PhongBan.GetRowCellValue(dd, "MATRUONGPHONG").ToString();
                //nếu là rỗng thì chuyển sang null
                if (sql_matp.Length <= 0)
                {
                    sql_matp = null;
                }

                pHONGBANTableAdapter.Delete(sql_mapb, sql_tenpb, sql_matp);
                MessageBox.Show(sql_mapb);

                load_dataPhongBan();
                MessageBox.Show("Thành công");
            }
            catch
            {
                MessageBox.Show("Không thành công");
            }
        }

        private void btn_Sua_PhongBan_Click(object sender, EventArgs e)
        {
            int dd = gridView_PhongBan.FocusedRowHandle;
            string sql_mapb = gridView_PhongBan.GetRowCellValue(dd, "MAPHONGBAN").ToString();
            string sql_tenpb = gridView_PhongBan.GetRowCellValue(dd, "TENPHONGBAN").ToString();
            string sql_matp = gridView_PhongBan.GetRowCellValue(dd, "MATRUONGPHONG").ToString();

            
            DataSetQLNS.PHONGBANRow data = dataSetQLNS.PHONGBAN.FindByMAPHONGBAN(sql_mapb);
            data.TENPHONGBAN = sql_tenpb;
            data.MATRUONGPHONG = sql_matp;
            pHONGBANTableAdapter.Update(this.dataSetQLNS.PHONGBAN);
            //cHUCVUTableAdapter
            load_dataPhongBan();
        }


        //Dân tộc
        public void load_dataDanToc()
        {
            gridControl_DanToc.DataSource = dANTOCTableAdapter.Fill(this.dataSetQLNS.DANTOC);
        }
        private void btn_Them_DanToc_Click(object sender, EventArgs e)
        {
            //kiem tra khoa chinh
            if (KTKC_New(txt_MaDanToc.Text.ToString(), dataSetQLNS.DANTOC) == false)
            {
                dANTOCTableAdapter.Insert(txt_MaDanToc.Text, txt_TenDanToc.Text);
                load_dataDanToc();
                MessageBox.Show("Thêm thành công !!!");
            }
            else
            {
                MessageBox.Show("Trùng khoá chính !!!");
            }
        }

        private void btn_Xoa_DanToc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            int cathu = gridView_DanToc.FocusedRowHandle;
            string sql_madt = gridView_DanToc.GetRowCellValue(cathu, "MADANTOC").ToString();
            string sql_tendt = gridView_DanToc.GetRowCellValue(cathu, "TENDANTOC").ToString();
            MessageBox.Show("Thành công");
            dANTOCTableAdapter.Delete(sql_madt, sql_tendt);
            load_dataDanToc();
        }

        private void btn_Sua_DanToc_Click(object sender, EventArgs e)
        {
            int cathu = gridView_DanToc.FocusedRowHandle;
            String sql_madt = gridView_DanToc.GetRowCellValue(cathu, "MADANTOC").ToString();
            String sql_tendt = gridView_DanToc.GetRowCellValue(cathu, "TENDANTOC").ToString();
            DataSetQLNS.DANTOCRow data = dataSetQLNS.DANTOC.FindByMADANTOC(sql_madt);
            data.TENDANTOC = sql_tendt;
            dANTOCTableAdapter.Update(this.dataSetQLNS.DANTOC);
            load_dataDanToc();
        }


       //Quốc tịch
        public void load_dataQuocTich()
        {
            gridControl_QuocTich.DataSource = qUOCTICHTableAdapter.Fill(this.dataSetQLNS.QUOCTICH);
        }
        private void btn_Them_QuocTich_Click(object sender, EventArgs e)
        {
            //kiem tra khoa chinh
            if (KTKC_New(txt_MaQuocTich.Text.ToString(), dataSetQLNS.QUOCTICH) == false)
            {
                qUOCTICHTableAdapter.Insert(txt_MaQuocTich.Text, txt_TenQuocTich.Text);
                load_dataQuocTich();
                MessageBox.Show("Thêm thành công !!!");
            }
            else
            {
                MessageBox.Show("Trùng khoá chính !!!");
            }
        }

        private void btn_Xoa_QuocTich_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            int cathu = gridView_QuocTich.FocusedRowHandle;
            string sql_maqt = gridView_QuocTich.GetRowCellValue(cathu, "MAQUOCTICH").ToString();
            string sql_tenqt = gridView_QuocTich.GetRowCellValue(cathu, "TENQUOCTICH").ToString();
            MessageBox.Show("Thành công");
            qUOCTICHTableAdapter.Delete(sql_maqt, sql_tenqt);
            load_dataQuocTich();
        }

        private void btn_Sua_QuocTich_Click(object sender, EventArgs e)
        {
            int cathu = gridView_QuocTich.FocusedRowHandle;
            String sql_maqt = gridView_QuocTich.GetRowCellValue(cathu, "MAQUOCTICH").ToString();
            String sql_tenqt = gridView_QuocTich.GetRowCellValue(cathu, "TENQUOCTICH").ToString();
            DataSetQLNS.QUOCTICHRow data = dataSetQLNS.QUOCTICH.FindByMAQUOCTICH(sql_maqt);
            data.TENQUOCTICH = sql_tenqt;
            qUOCTICHTableAdapter.Update(this.dataSetQLNS.QUOCTICH);
            load_dataQuocTich();
        }


        //Tôn giáo
        public void load_dataTonGiao()
        {
            gridControl_TonGiao.DataSource = tONGIAOTableAdapter.Fill(this.dataSetQLNS.TONGIAO);
        }
        private void btn_Them_TonGiao_Click(object sender, EventArgs e)
        {
            //kiem tra khoa chinh
            if (KTKC_New(txt_MaTonGiao.Text.ToString(), dataSetQLNS.TONGIAO) == false)
            {
                tONGIAOTableAdapter.Insert(txt_MaTonGiao.Text, txt_TenTonGiao.Text);
                load_dataTonGiao();
                MessageBox.Show("Thêm thành công !!!");
            }
            else
            {
                MessageBox.Show("Trùng khoá chính !!!");
            }
        }

        private void btn_Xoa_TonGiao_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            int cathu = gridView_TonGiao.FocusedRowHandle;
            string sql_matg = gridView_TonGiao.GetRowCellValue(cathu, "MATONGIAO").ToString();
            string sql_tentg = gridView_TonGiao.GetRowCellValue(cathu, "TENTONGIAO").ToString();
            MessageBox.Show("Thành công");
            tONGIAOTableAdapter.Delete(sql_matg, sql_tentg);
            load_dataTonGiao();
        }

        private void btn_Sua_TonGiao_Click(object sender, EventArgs e)
        {
            int cathu = gridView_TonGiao.FocusedRowHandle;
            string sql_matg = gridView_TonGiao.GetRowCellValue(cathu, "MATONGIAO").ToString();
            string sql_tentg = gridView_TonGiao.GetRowCellValue(cathu, "TENTONGIAO").ToString();
            DataSetQLNS.TONGIAORow data = dataSetQLNS.TONGIAO.FindByMATONGIAO(sql_matg);
            data.TENTONGIAO = sql_tentg;
            tONGIAOTableAdapter.Update(this.dataSetQLNS.TONGIAO);
            load_dataTonGiao();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_TenQuocTich_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_MaQuocTich_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
