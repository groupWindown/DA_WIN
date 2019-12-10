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
    public partial class frm_NhapLieu_PhanQuyen : UserControl
    {
        public frm_NhapLieu_PhanQuyen()
        {
            InitializeComponent();
        }

        private void frm_NhaLieu_PhanQuyen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetQLNS.NGUOIDUNGNHOMNGUOIDUNG' table. You can move, or remove it, as needed.
            this.nGUOIDUNGNHOMNGUOIDUNGTableAdapter.Fill(this.dataSetQLNS.NGUOIDUNGNHOMNGUOIDUNG);
            // TODO: This line of code loads data into the 'dataSetQLNS.TAIKHOAN' table. You can move, or remove it, as needed.
            this.tAIKHOANTableAdapter.Fill(this.dataSetQLNS.TAIKHOAN);
            // TODO: This line of code loads data into the 'dataSetQLNS.MANHINH' table. You can move, or remove it, as needed.
            this.mANHINHTableAdapter.Fill(this.dataSetQLNS.MANHINH);
            // TODO: This line of code loads data into the 'dataSetQLNS.NHOMNGUOIDUNG' table. You can move, or remove it, as needed.
            this.nHOMNGUOIDUNGTableAdapter.Fill(this.dataSetQLNS.NHOMNGUOIDUNG);

        }


        public void Load_dl()
        {
            if(nHOMNGUOIDUNGComboBox.SelectedValue != null)
            {
               
                 gridControl_NDNND.DataSource = nGUOIDUNGNHOMNGUOIDUNGTableAdapter.Fill(this.dataSetQLNS.NGUOIDUNGNHOMNGUOIDUNG);
                
            }
        }

        private void nHOMNGUOIDUNGComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_dl();
        }
        private void btn_Them_NDNND_Click(object sender, EventArgs e)
        {
            int cathu = gridView_TaiKhoan.FocusedRowHandle;
            string sql_manv = gridView_TaiKhoan.GetRowCellValue(cathu, "MANV").ToString();
          
           string sql_manhom = nHOMNGUOIDUNGComboBox.SelectedValue.ToString();
            nGUOIDUNGNHOMNGUOIDUNGTableAdapter.Insert(sql_manv, sql_manhom,string.Empty);
            Load_dl();
            MessageBox.Show("Thành công");
        }

        private void mANHOMComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
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


        // NHÓM NGƯỜI DÙNG
        public void load_dataNhomNguoiDung()
        {
            gridControl_NhomNguoiDung.DataSource = nHOMNGUOIDUNGTableAdapter.Fill(this.dataSetQLNS.NHOMNGUOIDUNG);
        }
        private void btn_Them_NhomNguoiDung_Click(object sender, EventArgs e)
        {
            if (KTKC_New(txt_MaNhom.Text.ToString(), dataSetQLNS.NHOMNGUOIDUNG) == false)
            {
                nHOMNGUOIDUNGTableAdapter.Insert(txt_MaNhom.Text,txt_TenNhom.Text,txt_GhiChu.Text);
                load_dataNhomNguoiDung();
                MessageBox.Show("Thêm thành công !!!");
            }
            else
            {
                MessageBox.Show("Trùng khoá chính !!!");
            }
        }

        private void btn_Xoa_NhomNguoiDung_Click(object sender, EventArgs e)
        {
            if (gridView_NhomNguoiDung.FocusedRowHandle != null)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                int cathu = gridView_NhomNguoiDung.FocusedRowHandle;
                string sql_manhom = gridView_NhomNguoiDung.GetRowCellValue(cathu, "MANHOM").ToString();
                string sql_tennhom = gridView_NhomNguoiDung.GetRowCellValue(cathu, "TENNHOM").ToString();
                string sql_ghichu = gridView_NhomNguoiDung.GetRowCellValue(cathu, "GHICHU").ToString();
                MessageBox.Show(sql_manhom);
                nHOMNGUOIDUNGTableAdapter.Delete(sql_manhom, sql_tennhom, sql_ghichu);
                load_dataNhomNguoiDung();
            }
            else
            {
                MessageBox.Show("chọn dòng muốn xóa !!!");
            }
}

        private void btn_Sua_NhomNguoiDung_Click(object sender, EventArgs e)
        {
            int cathu = gridView_NhomNguoiDung.FocusedRowHandle;
            string sql_manhom = gridView_NhomNguoiDung.GetRowCellValue(cathu, "MANHOM").ToString();
            string sql_tennhom = gridView_NhomNguoiDung.GetRowCellValue(cathu, "TENNHOM").ToString();
            string sql_ghichu = gridView_NhomNguoiDung.GetRowCellValue(cathu, "GHICHU").ToString();
            
            DataSetQLNS.NHOMNGUOIDUNGRow data = dataSetQLNS.NHOMNGUOIDUNG.FindByMANHOM(sql_manhom);
            data.TENNHOM = sql_tennhom;
            nHOMNGUOIDUNGTableAdapter.Update(this.dataSetQLNS.NHOMNGUOIDUNG);
            //cHUCVUTableAdapter
            load_dataNhomNguoiDung();
        }


        // MÀN HÌNH

        public void load_dataManHinh()
        {
            gridControl_ManHinh.DataSource = mANHINHTableAdapter.Fill(this.dataSetQLNS.MANHINH);
        }
        private void btn_Them_ManHinh_Click(object sender, EventArgs e)
        {
            if (KTKC_New(txt_MaManhinh.Text.ToString(), dataSetQLNS.MANHINH) == false)
            {
                mANHINHTableAdapter.Insert(txt_MaManhinh.Text, txt_TenManHinh.Text);
                load_dataManHinh();
                MessageBox.Show("Thêm thành công !!!");
            }
            else
            {
                MessageBox.Show("Trùng khoá chính !!!");
            }
        }

        private void btn_Xoa_ManHinh_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            int cathu = gridView_ManHinh.FocusedRowHandle;
            string sql_mamanhinh = gridView_ManHinh.GetRowCellValue(cathu, "MAMANHINH").ToString();
            string sql_tenmanhinh = gridView_ManHinh.GetRowCellValue(cathu, "TENMANHINH").ToString();
            
            MessageBox.Show(sql_mamanhinh);
            mANHINHTableAdapter.Delete(sql_mamanhinh, sql_tenmanhinh);
            load_dataManHinh();
        }

        private void btn_Sua_ManHinh_Click(object sender, EventArgs e)
        {
            int cathu = gridView_ManHinh.FocusedRowHandle;
            string sql_mamanhinh = gridView_ManHinh.GetRowCellValue(cathu, "MAMANHINH").ToString();
            string sql_tenmanhinh = gridView_ManHinh.GetRowCellValue(cathu, "TENMANHINH").ToString();

            DataSetQLNS.MANHINHRow data = dataSetQLNS.MANHINH.FindByMAMANHINH(sql_mamanhinh);
            data.TENMANHINH = sql_tenmanhinh;
            mANHINHTableAdapter.Update(this.dataSetQLNS.MANHINH);
            //cHUCVUTableAdapter
            load_dataManHinh();
        }

        private void groupBox_NguoiDungNhomNguoiDun_Enter(object sender, EventArgs e)
        {

        }
    }
}
