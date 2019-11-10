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
    public partial class frm_NhapLieu_TrinhDo : UserControl
    {
        public frm_NhapLieu_TrinhDo()
        {
            InitializeComponent();
        }

        private void frm_NhapLieu_TrinhDo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetQLNS.DAOTAO' table. You can move, or remove it, as needed.
            this.dAOTAOTableAdapter.Fill(this.dataSetQLNS.DAOTAO);
            // TODO: This line of code loads data into the 'dataSetQLNS.CHUONGTRINHDAOTAO' table. You can move, or remove it, as needed.
            this.cHUONGTRINHDAOTAOTableAdapter.Fill(this.dataSetQLNS.CHUONGTRINHDAOTAO);
            // TODO: This line of code loads data into the 'dataSetQLNS.CHUYENMON' table. You can move, or remove it, as needed.
            this.cHUYENMONTableAdapter.Fill(this.dataSetQLNS.CHUYENMON);
            // TODO: This line of code loads data into the 'dataSetQLNS.TRINHDOTINHOC' table. You can move, or remove it, as needed.
            this.tRINHDOTINHOCTableAdapter.Fill(this.dataSetQLNS.TRINHDOTINHOC);
            // TODO: This line of code loads data into the 'dataSetQLNS.NGOAINGU' table. You can move, or remove it, as needed.
            this.nGOAINGUTableAdapter.Fill(this.dataSetQLNS.NGOAINGU);
            // TODO: This line of code loads data into the 'dataSetQLNS.TRINHDOHOCVAN' table. You can move, or remove it, as needed.
            this.tRINHDOHOCVANTableAdapter.Fill(this.dataSetQLNS.TRINHDOHOCVAN);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void gridControl5_Click(object sender, EventArgs e)
        {

        }
        ///kiem gtra khoa chinh
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

        ////trinh do chuyen mon
        public void load_dataChuyenMon()
        {
            gridControl_ChuyenMon.DataSource = cHUYENMONTableAdapter.Fill(this.dataSetQLNS.CHUYENMON);
        }

        private void btn_Them_ChuyenMon_Click(object sender, EventArgs e)
        {
            //kiem tra khoa chinh
            if (KTKC_New(txt__MaChuyenMon.Text.ToString(), dataSetQLNS.CHUYENMON) == false)
            {
                cHUYENMONTableAdapter.Insert(txt__MaChuyenMon.Text, txt_TenChuyenMon.Text);
                load_dataChuyenMon();
                MessageBox.Show("Thêm thành công !!!");
            }
            else
            {
                MessageBox.Show("Trùng khoá chính !!!");
            }
        }

        private void btn_Xoa_ChuyenMon_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            int cathu = gridView_ChuyenMon.FocusedRowHandle;
            string sql_macm = gridView_ChuyenMon.GetRowCellValue(cathu, "MACHUYENMON").ToString();
            string sql_tencm = gridView_ChuyenMon.GetRowCellValue(cathu, "TENCHUYENMON").ToString();
            MessageBox.Show("Thành công");
            cHUYENMONTableAdapter.Delete(sql_macm, sql_tencm);
            load_dataChuyenMon();
        }

        private void btn_Sua_ChuyenMon_Click(object sender, EventArgs e)
        {
            int cathu = gridView_ChuyenMon.FocusedRowHandle;
            string sql_macm = gridView_ChuyenMon.GetRowCellValue(cathu, "MACHUYENMON").ToString();
            string sql_tencm = gridView_ChuyenMon.GetRowCellValue(cathu, "TENCHUYENMON").ToString();
            DataSetQLNS.CHUYENMONRow data = dataSetQLNS.CHUYENMON.FindByMACHUYENMON(sql_macm);
            data.TENCHUYENMON = sql_tencm;
            cHUYENMONTableAdapter.Update(this.dataSetQLNS.CHUYENMON);
            //cHUCVUTableAdapter
            load_dataChuyenMon();
        }


        //Chương trinh dao tao
        public void load_dataDaoTao()
        {
            gridControl_DaoTao.DataSource = dAOTAOTableAdapter.Fill(this.dataSetQLNS.DAOTAO);
        }
        private void btn_Them_DaoTao_Click(object sender, EventArgs e)
        {
            //kiem tra khoa chinh
            if (KTKC_New(txt_MaDaoTao.Text.ToString(), dataSetQLNS.DAOTAO) == false)
            {
                dAOTAOTableAdapter.Insert(txt_MaDaoTao.Text, txt_TenDaoTao.Text);
                load_dataDaoTao();
                MessageBox.Show("Thêm thành công !!!");
            }
            else
            {
                MessageBox.Show("Trùng khoá chính !!!");
            }
        }

        private void btn_Xoa_DaoTao_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            int cathu = gridView_DaoTao.FocusedRowHandle;
            string sql_madt = gridView_DaoTao.GetRowCellValue(cathu, "MAKHOADAOTAO").ToString();
            string sql_tendt = gridView_DaoTao.GetRowCellValue(cathu, "TENKHOADAOTAO").ToString();
            MessageBox.Show("Thành công");
            dAOTAOTableAdapter.Delete(sql_madt, sql_tendt);
            load_dataDaoTao();
        }

        private void btn_Sua_DaoTao_Click(object sender, EventArgs e)
        {
            int cathu = gridView_DaoTao.FocusedRowHandle;
            string sql_madt = gridView_DaoTao.GetRowCellValue(cathu, "MAKHOADAOTAO").ToString();
            string sql_tendt = gridView_DaoTao.GetRowCellValue(cathu, "TENKHOADAOTAO").ToString();
            DataSetQLNS.DAOTAORow data = dataSetQLNS.DAOTAO.FindByMAKHOADAOTAO(sql_madt);
            data.TENKHOADAOTAO = sql_tendt;
            dAOTAOTableAdapter.Update(this.dataSetQLNS.DAOTAO);
            //cHUCVUTableAdapter
            load_dataDaoTao();
        }


        //trinh do học van

        public void load_dataTDHocVan()
        {
            gridControl_TDHocVan.DataSource = tRINHDOHOCVANTableAdapter.Fill(this.dataSetQLNS.TRINHDOHOCVAN);
        }
        private void btn_Them_TDHocVan_Click(object sender, EventArgs e)
        {
            if (KTKC_New(txt_MaTDHocVan.Text.ToString(), dataSetQLNS.TRINHDOHOCVAN) == false)
            {
                tRINHDOHOCVANTableAdapter.Insert(txt_MaTDHocVan.Text, txt_tenTDHocVan.Text);
                load_dataTDHocVan();
                MessageBox.Show("Thêm thành công !!!");
            }
            else
            {
                MessageBox.Show("Trùng khoá chính !!!");
            }
        }

        private void btn_Xoa_TDHocVan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            int cathu = gridView_TDHocVan.FocusedRowHandle;
            string sql_matdhv = gridView_TDHocVan.GetRowCellValue(cathu, "MATRINHDOHOCVAN").ToString();
            string sql_tentdhv = gridView_TDHocVan.GetRowCellValue(cathu, "TENTRINHDOHOCVAN").ToString();
            MessageBox.Show("Thành công");
            tRINHDOHOCVANTableAdapter.Delete(sql_matdhv, sql_tentdhv);
            load_dataTDHocVan();
        }

        private void btn_Sua_TDHocVan_Click(object sender, EventArgs e)
        {
            int cathu = gridView_TDHocVan.FocusedRowHandle;
            string sql_matdhv = gridView_TDHocVan.GetRowCellValue(cathu, "MATRINHDOHOCVAN").ToString();
            string sql_tentdhv = gridView_TDHocVan.GetRowCellValue(cathu, "TENTRINHDOHOCVAN").ToString();
            DataSetQLNS.TRINHDOHOCVANRow data = dataSetQLNS.TRINHDOHOCVAN.FindByMATRINHDOHOCVAN(sql_matdhv);
            data.TENTRINHDOHOCVAN = sql_tentdhv;
            tRINHDOHOCVANTableAdapter.Update(this.dataSetQLNS.TRINHDOHOCVAN);
            //cHUCVUTableAdapter
            load_dataTDHocVan();
        }


        // trình độc ngoại ngữ
        public void load_dataTDNgoaiNgu()
        {
            gridControl_NgoaiNgu.DataSource = nGOAINGUTableAdapter.Fill(this.dataSetQLNS.NGOAINGU);
        }
        private void btn_Them_NgoaiNgu_Click(object sender, EventArgs e)
        {
            if (KTKC_New(txt_MaNgoaiNgu.Text.ToString(), dataSetQLNS.NGOAINGU) == false)
            {
                nGOAINGUTableAdapter.Insert(txt_MaNgoaiNgu.Text, txt_TenNgoaiNgu.Text);
                load_dataTDNgoaiNgu();
                MessageBox.Show("Thêm thành công !!!");
            }
            else
            {
                MessageBox.Show("Trùng khoá chính !!!");
            }
        }

        private void btn_Xoa_NgoaiNgu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            int cathu = gridView_NgoaiNgu.FocusedRowHandle;
            string sql_matdnn = gridView_NgoaiNgu.GetRowCellValue(cathu, "MANGOAINGU").ToString();
            string sql_tentdnn= gridView_NgoaiNgu.GetRowCellValue(cathu, "TENNGOAINGU").ToString();
            MessageBox.Show("Thành công");
            nGOAINGUTableAdapter.Delete(sql_matdnn, sql_tentdnn);
            load_dataTDNgoaiNgu();
        }

        private void btn_Sua_NgoaiNgu_Click(object sender, EventArgs e)
        {
            int cathu = gridView_NgoaiNgu.FocusedRowHandle;
            string sql_matdnn = gridView_NgoaiNgu.GetRowCellValue(cathu, "MANGOAINGU").ToString();
            string sql_tentdnn = gridView_NgoaiNgu.GetRowCellValue(cathu, "TENNGOAINGU").ToString();
            DataSetQLNS.NGOAINGURow data = dataSetQLNS.NGOAINGU.FindByMANGOAINGU(sql_matdnn);
            data.TENNGOAINGU = sql_tentdnn;
            nGOAINGUTableAdapter.Update(this.dataSetQLNS.NGOAINGU);
            //cHUCVUTableAdapter
            load_dataTDNgoaiNgu();
        }

        // trình độc tin học

        public void load_dataTDTinHoc()
        {
            gridControl_TinHoc.DataSource = tRINHDOTINHOCTableAdapter.Fill(this.dataSetQLNS.TRINHDOTINHOC);
        }
        private void btn_Them_TinHoc_Click(object sender, EventArgs e)
        {
            if (KTKC_New(txt_MaTinHoc.Text.ToString(), dataSetQLNS.TRINHDOTINHOC) == false)
            {
                tRINHDOTINHOCTableAdapter.Insert(txt_MaTinHoc.Text, txt_TenTinHoc.Text);
                load_dataTDTinHoc();
                MessageBox.Show("Thêm thành công !!!");
            }
            else
            {
                MessageBox.Show("Trùng khoá chính !!!");
            }
        }

        private void btn_Xoa_TinHoc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            int cathu = gridView_TinHoc.FocusedRowHandle;
            string sql_matdth = gridView_TinHoc.GetRowCellValue(cathu, "MATRINHDOTINHOC").ToString();
            string sql_tentdth = gridView_TinHoc.GetRowCellValue(cathu, "TENTRINHDOTINHOC").ToString();
            MessageBox.Show("Thành công");
            tRINHDOTINHOCTableAdapter.Delete(sql_matdth, sql_tentdth);
            load_dataTDTinHoc();
        }

        private void btn_Sua_TinHoc_Click(object sender, EventArgs e)
        {
            int cathu = gridView_TinHoc.FocusedRowHandle;
            string sql_matdth = gridView_TinHoc.GetRowCellValue(cathu, "MATRINHDOTINHOC").ToString();
            string sql_tentdth = gridView_TinHoc.GetRowCellValue(cathu, "TENTRINHDOTINHOC").ToString();
            DataSetQLNS.TRINHDOTINHOCRow data = dataSetQLNS.TRINHDOTINHOC.FindByMATRINHDOTINHOC(sql_matdth);
            data.TENTRINHDOTINHOC = sql_tentdth;
            tRINHDOTINHOCTableAdapter.Update(this.dataSetQLNS.TRINHDOTINHOC);
            //cHUCVUTableAdapter
            load_dataTDTinHoc();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
