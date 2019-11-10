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
    public partial class frm_NhapLieu_KT_KL : UserControl
    {
        public frm_NhapLieu_KT_KL()
        {
            InitializeComponent();
        }

        private void frm_NhapLieu_KT_KL_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetQLNS.DANHMUCTANGCA' table. You can move, or remove it, as needed.
            this.dANHMUCTANGCATableAdapter.Fill(this.dataSetQLNS.DANHMUCTANGCA);
            // TODO: This line of code loads data into the 'dataSetQLNS.DAOTAO' table. You can move, or remove it, as needed.
            this.dAOTAOTableAdapter.Fill(this.dataSetQLNS.DAOTAO);
            // TODO: This line of code loads data into the 'dataSetQLNS.DS_KYLUAT' table. You can move, or remove it, as needed.
            this.dS_KYLUATTableAdapter.Fill(this.dataSetQLNS.DS_KYLUAT);
            // TODO: This line of code loads data into the 'dataSetQLNS.LOAIKHENTHUONG' table. You can move, or remove it, as needed.
            this.lOAIKHENTHUONGTableAdapter.Fill(this.dataSetQLNS.LOAIKHENTHUONG);

        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }

        ///////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////
        
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

        //// danh mục tăng ca
        public void load_dataDMTangCa()
        {
            gridControl_DMTangCa.DataSource = dANHMUCTANGCATableAdapter.Fill(this.dataSetQLNS.DANHMUCTANGCA);
        }
        private void btn_Them_DMTC_Click(object sender, EventArgs e)
        {
            //kiem tra khoa chinh
            if (KTKC_New(txt_MaLoaiCa.Text.ToString(), dataSetQLNS.DANHMUCTANGCA) == false)
            {
               
                dANHMUCTANGCATableAdapter.Insert(txt_MaLoaiCa.Text, txt_TenLoaiCa.Text, Convert.ToInt32 (txt_HeSo.Text),Convert.ToDouble (txt_SoGioTangCa.Text)) ;
                  
                load_dataDMTangCa();
                MessageBox.Show("Thêm thành công !!!");
            }
            else
            {
                MessageBox.Show("Trùng khoá chính !!!");
            }
        }

        private void btn_Xoa_DMTC_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            int cathu = gridView_DMTangCa.FocusedRowHandle;
            string sql_madmtc = gridView_DMTangCa.GetRowCellValue(cathu, "MALOAICA").ToString();
            string sql_tendmtc = gridView_DMTangCa.GetRowCellValue(cathu, "TENLOAICA").ToString();
            string sql_heso =gridView_DMTangCa.GetRowCellValue(cathu, "HESO").ToString();
            string sql_sogiotangca =Convert.ToDouble( gridView_DMTangCa.GetRowCellValue(cathu, "SOGIOTANGCA")).ToString();
            dANHMUCTANGCATableAdapter.Delete(sql_madmtc, sql_tendmtc,Convert.ToInt32(sql_heso), Convert.ToDouble(sql_sogiotangca));
            load_dataDMTangCa();
        }

        private void btn_Sua_DMTC_Click(object sender, EventArgs e)
        {
            int cathu = gridView_DMTangCa.FocusedRowHandle;
            string sql_madmtc = gridView_DMTangCa.GetRowCellValue(cathu, "MALOAICA").ToString();
            string sql_tendmtc = gridView_DMTangCa.GetRowCellValue(cathu, "TENLOAICA").ToString();
            string sql_heso = gridView_DMTangCa.GetRowCellValue(cathu, "HESO").ToString();
            string sql_sogiotangca = gridView_DMTangCa.GetRowCellValue(cathu, "SOGIOTANGCA").ToString();
            DataSetQLNS.DANHMUCTANGCARow data = dataSetQLNS.DANHMUCTANGCA.FindByMALOAICA(sql_madmtc);
            data.TENLOAICA = sql_tendmtc;
            data.HESO = Convert.ToInt32(sql_heso);
            data.SOGIOTANGCA = Convert.ToDouble(sql_sogiotangca);
            dANHMUCTANGCATableAdapter.Update(this.dataSetQLNS.DANHMUCTANGCA);
            load_dataDMTangCa();
        }


        //Kỷ luật
        public void load_dataKyLuat()
        {
            gridControl_KyLuat.DataSource = dS_KYLUATTableAdapter.Fill(this.dataSetQLNS.DS_KYLUAT);
        }
        private void btn_Them_KyLuat_Click(object sender, EventArgs e)
        {
            if (KTKC_New(txt_MaKyLuat.Text.ToString(), dataSetQLNS.DS_KYLUAT) == false)
            {
                dS_KYLUATTableAdapter.Insert(txt_MaKyLuat.Text, txt_TenKyLuat.Text,txt_HinhThuc.Text, Convert.ToDecimal (txt_TienKyLuat.Text));
                
                load_dataKyLuat();
                MessageBox.Show("Thêm thành công !!!");
            }
            else
            {
                MessageBox.Show("Trùng khoá chính !!!");
            }
        }

        private void btn_Xoa_KyLuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            int cathu = gridView_KyLuat.FocusedRowHandle;
            string sql_makl = gridView_KyLuat.GetRowCellValue(cathu, "MAKYLUAT").ToString();
            string sql_tenkl = gridView_KyLuat.GetRowCellValue(cathu, "TENKYLUAT").ToString();
            string sql_hinhthuc= gridView_KyLuat.GetRowCellValue(cathu, "HINHTHUC").ToString();
            string sql_tienkl = gridView_KyLuat.GetRowCellValue(cathu, "TIENKYLUAT").ToString();
            dS_KYLUATTableAdapter.Delete(sql_makl, sql_tenkl,sql_hinhthuc, Convert.ToDecimal(sql_tienkl));
            load_dataKyLuat();
        }

        private void btn_Sua_KyLuat_Click(object sender, EventArgs e)
        {
            int cathu = gridView_KyLuat.FocusedRowHandle;
            string sql_makl = gridView_KyLuat.GetRowCellValue(cathu, "MAKYLUAT").ToString();
            string sql_tenkl = gridView_KyLuat.GetRowCellValue(cathu, "TENKYLUAT").ToString();
            string sql_hinhthuc = gridView_KyLuat.GetRowCellValue(cathu, "HINHTHUC").ToString();
            string sql_tienkl = gridView_KyLuat.GetRowCellValue(cathu, "TIENKYLUAT").ToString();
            DataSetQLNS.DS_KYLUATRow data = dataSetQLNS.DS_KYLUAT.FindByMAKYLUAT(sql_makl);
            data.TENKYLUAT = sql_tenkl;
            data.HINHTHUC = sql_hinhthuc;
            data.TIENKYLUAT = Convert.ToDecimal(sql_tienkl);
            dS_KYLUATTableAdapter.Update(this.dataSetQLNS.DS_KYLUAT);
            load_dataKyLuat();
        }


        ///Khen thưởng
        public void load_dataKhenThuong()
        {
            gridControl_KhenThuong.DataSource = lOAIKHENTHUONGTableAdapter.Fill(this.dataSetQLNS.LOAIKHENTHUONG);
        }
        private void btn_Them_KhenThuong_Click(object sender, EventArgs e)
        {
            if (KTKC_New(txt_MaKhenThuong.Text.ToString(), dataSetQLNS.LOAIKHENTHUONG) == false)
            {
                lOAIKHENTHUONGTableAdapter.Insert(txt_MaKhenThuong.Text, txt_LoaiKhenThuong.Text,Convert.ToDecimal( txt_TienThuong.Text));

                load_dataKhenThuong();
                MessageBox.Show("Thêm thành công !!!");
            }
            else
            {
                MessageBox.Show("Trùng khoá chính !!!");
            }
        }

        private void btn_Xoa_KhenThuong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            int cathu = gridView_KhenThuong.FocusedRowHandle;
            string sql_makt = gridView_KhenThuong.GetRowCellValue(cathu, "MALOAIKHENTHUONG").ToString();
            string sql_tenkt = gridView_KhenThuong.GetRowCellValue(cathu, "LOAITENKHENTHUONG").ToString();
            string sql_tienkt = gridView_KhenThuong.GetRowCellValue(cathu, "TIENTHUONG").ToString();
            lOAIKHENTHUONGTableAdapter.Delete(sql_makt, sql_tenkt, Convert.ToDecimal(sql_tienkt));
            load_dataKhenThuong();
        }

        private void btn_Sua_KhenThuong_Click(object sender, EventArgs e)
        {
            int cathu = gridView_KhenThuong.FocusedRowHandle;
            string sql_makt = gridView_KhenThuong.GetRowCellValue(cathu, "MALOAIKHENTHUONG").ToString();
            string sql_tenkt = gridView_KhenThuong.GetRowCellValue(cathu, "LOAITENKHENTHUONG").ToString();
            string sql_tienkt = gridView_KhenThuong.GetRowCellValue(cathu, "TIENTHUONG").ToString();
            DataSetQLNS.LOAIKHENTHUONGRow data = dataSetQLNS.LOAIKHENTHUONG.FindByMALOAIKHENTHUONG(sql_makt);
            data.LOAITENKHENTHUONG = sql_tenkt;
            data.TIENTHUONG = Convert.ToDecimal(sql_tienkt);
            lOAIKHENTHUONGTableAdapter.Update(this.dataSetQLNS.LOAIKHENTHUONG);
            load_dataKhenThuong();
        }

        private void txt_HeSo_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox_DanhMucTangCa_Enter(object sender, EventArgs e)
        {

        }

        private void txt_HeSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
