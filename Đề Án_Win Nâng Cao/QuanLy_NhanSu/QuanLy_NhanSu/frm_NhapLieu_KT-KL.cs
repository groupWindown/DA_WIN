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
            // TODO: This line of code loads data into the 'dataSetQLNS.NGUOIDUNGNHOMNGUOIDUNG' table. You can move, or remove it, as needed.
            this.nGUOIDUNGNHOMNGUOIDUNGTableAdapter.Fill(this.dataSetQLNS.NGUOIDUNGNHOMNGUOIDUNG);
            // TODO: This line of code loads data into the 'dataSetQLNS.TAIKHOAN' table. You can move, or remove it, as needed.
            this.tAIKHOANTableAdapter.Fill(this.dataSetQLNS.TAIKHOAN);
            // TODO: This line of code loads data into the 'dataSetQLNS.MANHINH' table. You can move, or remove it, as needed.
            this.mANHINHTableAdapter.Fill(this.dataSetQLNS.MANHINH);
            // TODO: This line of code loads data into the 'dataSetQLNS.NHOMNGUOIDUNG' table. You can move, or remove it, as needed.
            this.nHOMNGUOIDUNGTableAdapter.Fill(this.dataSetQLNS.NHOMNGUOIDUNG);

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
            if (mALOAICATextEdit.Text.Length > 0 && tENLOAICATextEdit.Text.Length > 0 && hESOSpinEdit.Text.Length > 0 && sOGIOTANGCASpinEdit.Text.Length > 0)
            {
                //kiem tra khoa chinh
                if (KTKC_New(mALOAICATextEdit.Text.ToString(), dataSetQLNS.DANHMUCTANGCA) == false)
                {

                    dANHMUCTANGCATableAdapter.Insert(mALOAICATextEdit.Text, tENLOAICATextEdit.Text, Convert.ToInt32(hESOSpinEdit.Text), Convert.ToDouble(sOGIOTANGCASpinEdit.Text));

                    load_dataDMTangCa();
                    MessageBox.Show("Thêm thành công !!!");
                }
                else
                {
                    MessageBox.Show("Trùng khoá chính !!!");
                }
            }
            else
            {
                MessageBox.Show("Nhập thiếu dữ liệu !!!");
            }
        }

        private void btn_Xoa_DMTC_Click(object sender, EventArgs e)
        {
            if (gridView_DMTangCa.GetFocusedRow() != null)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            int cathu = gridView_DMTangCa.FocusedRowHandle;
            string sql_madmtc = gridView_DMTangCa.GetRowCellValue(cathu, "MALOAICA").ToString();
            string sql_tendmtc = gridView_DMTangCa.GetRowCellValue(cathu, "TENLOAICA").ToString();
            string sql_heso = gridView_DMTangCa.GetRowCellValue(cathu, "HESO").ToString();
            string sql_sogiotangca = Convert.ToDouble(gridView_DMTangCa.GetRowCellValue(cathu, "SOGIOTANGCA")).ToString();
            dANHMUCTANGCATableAdapter.Delete(sql_madmtc, sql_tendmtc, Convert.ToInt32(sql_heso), Convert.ToDouble(sql_sogiotangca));
            load_dataDMTangCa();
            }
            else
            {
                MessageBox.Show("chọn dữ liệu!!");
            }
        }

        private void btn_Sua_DMTC_Click(object sender, EventArgs e)
        {
            if (gridView_DMTangCa.GetFocusedRow() != null)
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
                MessageBox.Show("Thành công");
            }
            else
            {
                MessageBox.Show("chọn dữ liệu!!");
            }
        }


        //Kỷ luật
        public void load_dataKyLuat()
        {
            gridControl_KyLuat.DataSource = dS_KYLUATTableAdapter.Fill(this.dataSetQLNS.DS_KYLUAT);
        }
        private void btn_Them_KyLuat_Click(object sender, EventArgs e)
        {
            if (mAKYLUATComboBox.Text.Length>0&& tENKYLUATComboBox.Text.Length>0&& hINHTHUCTextEdit.Text.Length>0&& tIENKYLUATSpinEdit.Text.Length>0)
            {
                if (KTKC_New(mAKYLUATComboBox.Text.ToString(), dataSetQLNS.DS_KYLUAT) == false)
                {
                    dS_KYLUATTableAdapter.Insert(mAKYLUATComboBox.Text, tENKYLUATComboBox.Text, hINHTHUCTextEdit.Text, Convert.ToDecimal(tIENKYLUATSpinEdit.Text));

                    load_dataKyLuat();
                    MessageBox.Show("Thêm thành công !!!");
                }
                else
                {
                    MessageBox.Show("Trùng khoá chính !!!");
                }
            }
            else
            {
                MessageBox.Show("Nhập thiếu dữ liệu !!!");
            }
        }

        private void btn_Xoa_KyLuat_Click(object sender, EventArgs e)
        {
            if (gridView_KyLuat.GetFocusedRow() != null)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                int cathu = gridView_KyLuat.FocusedRowHandle;
                string sql_makl = gridView_KyLuat.GetRowCellValue(cathu, "MAKYLUAT").ToString();
                string sql_tenkl = gridView_KyLuat.GetRowCellValue(cathu, "TENKYLUAT").ToString();
                string sql_hinhthuc = gridView_KyLuat.GetRowCellValue(cathu, "HINHTHUC").ToString();
                string sql_tienkl = gridView_KyLuat.GetRowCellValue(cathu, "TIENKYLUAT").ToString();
                dS_KYLUATTableAdapter.Delete(sql_makl, sql_tenkl, sql_hinhthuc, Convert.ToDecimal(sql_tienkl));
                load_dataKyLuat();
            }
            else
            {
                MessageBox.Show("chọn dữ liệu đễ xóa !!!");
            }
        }

        private void btn_Sua_KyLuat_Click(object sender, EventArgs e)
        {
            if (gridView_KyLuat.GetFocusedRow() != null)
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
            else
            {
                MessageBox.Show("chọn dữ liệu đễ sửa !!!");
            }
        }


        ///Khen thưởng
        public void load_dataKhenThuong()
        {
            gridControl_KhenThuong.DataSource = lOAIKHENTHUONGTableAdapter.Fill(this.dataSetQLNS.LOAIKHENTHUONG);
        }
        private void btn_Them_KhenThuong_Click(object sender, EventArgs e)
        {
            if (mALOAIKHENTHUONGTextEdit.Text.Length > 0 && lOAITENKHENTHUONGTextEdit.Text.Length > 0 && tIENTHUONGSpinEdit.Text.Length > 0)
            {
                if (KTKC_New(mALOAIKHENTHUONGTextEdit.Text.ToString(), dataSetQLNS.LOAIKHENTHUONG) == false)
                {
                    lOAIKHENTHUONGTableAdapter.Insert(mALOAIKHENTHUONGTextEdit.Text, lOAITENKHENTHUONGTextEdit.Text, Convert.ToDecimal(tIENTHUONGSpinEdit.Text));

                    load_dataKhenThuong();
                    MessageBox.Show("Thêm thành công !!!");
                }
                else
                {
                    MessageBox.Show("Trùng khoá chính !!!");
                }
            }
            else
            {
                MessageBox.Show("Thiếu dữ liệu !!!");
            }

        }

        private void btn_Xoa_KhenThuong_Click(object sender, EventArgs e)
        {
            if (gridView_KhenThuong.GetFocusedRow() != null)
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
            else
            {
                MessageBox.Show("chọn để xóa ");
            }
        }

        private void btn_Sua_KhenThuong_Click(object sender, EventArgs e)
        {
            if (gridView_KhenThuong.GetFocusedRow() != null)
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
            else
            {
                MessageBox.Show("chọn để sửa ");
            }
        }

        private void txt_HeSo_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox_DanhMucTangCa_Enter(object sender, EventArgs e)
        {

        }

        private void txt_HeSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public void load_dataNhomNguoiDung()
        {
            gridControl_NhomNguoiDung.DataSource = nHOMNGUOIDUNGTableAdapter.Fill(this.dataSetQLNS.NHOMNGUOIDUNG);
        }
        private void btn_Them_NhomNguoiDung_Click(object sender, EventArgs e)
        {
            if (mANHOMComboBox.Text.Length > 0 && tENNHOMTextEdit.Text.Length > 0)
            {
                if (KTKC_New(mANHOMComboBox.Text.ToString(), dataSetQLNS.NHOMNGUOIDUNG) == false)
                {
                    nHOMNGUOIDUNGTableAdapter.Insert(mANHOMComboBox.Text, tENNHOMTextEdit.Text, gHICHUTextEdit.Text);
                    load_dataNhomNguoiDung();
                    MessageBox.Show("Thêm thành công !!!");
                }
                else
                {
                    MessageBox.Show("Trùng khoá chính !!!");
                }
            }
            else
            {
                MessageBox.Show("Nhập thiếu dữ liệu !!!");
            }
        }

        private void btn_Xoa_NhomNguoiDung_Click(object sender, EventArgs e)
        {
            if (gridView_NhomNguoiDung.GetFocusedDataRow() != null)
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
            if (mANHOMComboBox.Text.Length > 0 && tENNHOMTextEdit.Text.Length > 0)
            {
                int cathu = gridView_NhomNguoiDung.FocusedRowHandle;
                string sql_manhom = gridView_NhomNguoiDung.GetRowCellValue(cathu, "MANHOM").ToString();
                string sql_tennhom = gridView_NhomNguoiDung.GetRowCellValue(cathu, "TENNHOM").ToString();
                string sql_ghichu = gridView_NhomNguoiDung.GetRowCellValue(cathu, "GHICHU").ToString();

                DataSetQLNS.NHOMNGUOIDUNGRow data = dataSetQLNS.NHOMNGUOIDUNG.FindByMANHOM(sql_manhom);
                data.TENNHOM = sql_tennhom;
                nHOMNGUOIDUNGTableAdapter.Update(this.dataSetQLNS.NHOMNGUOIDUNG);

                load_dataNhomNguoiDung();
            }
            else
            {
                MessageBox.Show("Nhập thiếu dữ liệu !!!");
            }
        }

        private void btn_Them_ManHinh_Click(object sender, EventArgs e)
        {
            if (tENMANHINHTextEdit.Text.Length > 0 && mAMANHINHTextEdit.Text.Length > 0)
            {
                if (KTKC_New(mAMANHINHTextEdit.Text.ToString(), dataSetQLNS.MANHINH) == false)
                {
                    mANHINHTableAdapter.Insert(mAMANHINHTextEdit.Text, tENMANHINHTextEdit.Text);
                    load_dataManHinh();
                    MessageBox.Show("Thêm thành công !!!");
                }
                else
                {
                    MessageBox.Show("Trùng khoá chính !!!");
                }
            }
            else
            {
                MessageBox.Show("Nhập thiếu dữ liệu !!!");
            }
        }
        public void load_dataManHinh()
        {
            gridControl_ManHinh.DataSource = mANHINHTableAdapter.Fill(this.dataSetQLNS.MANHINH);
        }

        private void btn_Xoa_ManHinh_Click(object sender, EventArgs e)
        {
            if (gridView_ManHinh.GetFocusedDataRow() != null)
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
            else
            {
                MessageBox.Show("chọn dòng muốn xóa !!!");
            }
        }

        private void btn_Sua_ManHinh_Click(object sender, EventArgs e)
        {
            if (gridView_ManHinh.GetFocusedDataRow() != null)
            {
                int cathu = gridView_ManHinh.FocusedRowHandle;
                string sql_mamanhinh = gridView_ManHinh.GetRowCellValue(cathu, "MAMANHINH").ToString();
                string sql_tenmanhinh = gridView_ManHinh.GetRowCellValue(cathu, "TENMANHINH").ToString();

                DataSetQLNS.MANHINHRow data = dataSetQLNS.MANHINH.FindByMAMANHINH(sql_mamanhinh);
                data.TENMANHINH = sql_tenmanhinh;
                mANHINHTableAdapter.Update(this.dataSetQLNS.MANHINH);

                load_dataManHinh();
            }
            else
            {
                MessageBox.Show("Nhập thiếu dữ liệu !!!");
            }
        }

        private void gridViewNhomNguoiDung_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            loadgrid();
        }

        private void loadgrid()
        {
            if (gridViewNhomNguoiDung.GetFocusedDataRow() != null)
            {
                gridView_TaiKhoan.ClearSelection();
                gridViewManHinh.ClearSelection();
                //load các giá trị tài khoản
                for (int i = 0; i < gridView_TaiKhoan.DataRowCount; i++)
                {
                    nGUOIDUNGNHOMNGUOIDUNGTableAdapter.Fill(dataSetQLNS.NGUOIDUNGNHOMNGUOIDUNG);
                    DataSetQLNS.NGUOIDUNGNHOMNGUOIDUNGRow data = dataSetQLNS.NGUOIDUNGNHOMNGUOIDUNG.FindByMANVMANHOM(gridView_TaiKhoan.GetDataRow(i)["MANV"].ToString().Trim(), gridViewNhomNguoiDung.GetFocusedRowCellValue("MANHOM").ToString());
                    if (data != null)
                    {
                        gridView_TaiKhoan.SelectRow(i);
                    }

                }

                //load các giá trị màn hình
                for (int i = 0; i < gridViewManHinh.DataRowCount; i++)
                {
                    pHANQUYENTableAdapter.Fill(dataSetQLNS.PHANQUYEN);
                    DataSetQLNS.PHANQUYENRow data = dataSetQLNS.PHANQUYEN.FindByMAMANHINHMANHOM(gridViewManHinh.GetDataRow(i)["MAMANHINH"].ToString().Trim(), gridViewNhomNguoiDung.GetFocusedRowCellValue("MANHOM").ToString());
                    if (data != null)
                    {
                        gridViewManHinh.SelectRow(i);
                    }
                }
            }
        }

        private void gridViewManHinh_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            int i = gridViewManHinh.GetFocusedDataSourceRowIndex();
            //update ManHinh
            if (gridViewManHinh.IsRowSelected(i))//dang duoc click
            {
                try
                {
                    pHANQUYENTableAdapter.Delete(gridViewManHinh.GetRowCellValue(i, "MAMANHINH").ToString(), gridViewNhomNguoiDung.GetFocusedRowCellValue("MANHOM").ToString(), true);
                    //gridViewManHinh.CancelSelection();
                    
                }
                catch
                {

                }
            }
            else //dang khong duoc click
            {
                try
                {
                    pHANQUYENTableAdapter.Insert(gridViewManHinh.GetRowCellValue(i, "MAMANHINH").ToString(), gridViewNhomNguoiDung.GetFocusedRowCellValue("MANHOM").ToString(), true);
                    //gridViewManHinh.SelectRow(i);
                    //gridControlManHinh.Refresh();
                }
                catch
                {
                    pHANQUYENTableAdapter.Update(true, gridViewManHinh.GetRowCellValue(i, "MAMANHINH").ToString(), gridViewNhomNguoiDung.GetFocusedRowCellValue("MANHOM").ToString(), true);
                    //gridViewManHinh.SelectRow(i);
                   // gridControlManHinh.Refresh();
                }
            }
            loadgrid();
        }

        private void gridView_TaiKhoan_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            int i = gridView_TaiKhoan.GetFocusedDataSourceRowIndex();
            //update ManHinh
            if (gridView_TaiKhoan.IsRowSelected(i))
            {
                try
                {
                    nGUOIDUNGNHOMNGUOIDUNGTableAdapter.Delete(gridView_TaiKhoan.GetRowCellValue(i, "MANV").ToString(), gridViewNhomNguoiDung.GetFocusedRowCellValue("MANHOM").ToString(), "");
                    //gridView_TaiKhoan.CancelSelection();
                    //gridControl_TaiKhoan.Refresh();
                }
                catch
                {

                }
            }
            else
            {
              
                try
                {
                    nGUOIDUNGNHOMNGUOIDUNGTableAdapter.Insert(gridView_TaiKhoan.GetRowCellValue(i, "MANV").ToString(), gridViewNhomNguoiDung.GetFocusedRowCellValue("MANHOM").ToString(), "");
                    //gridView_TaiKhoan.SelectRow(i);
                    //gridControl_TaiKhoan.Refresh();
                }
                catch
                {
                    nGUOIDUNGNHOMNGUOIDUNGTableAdapter.Update("", gridView_TaiKhoan.GetRowCellValue(i, "MANV").ToString(), gridViewNhomNguoiDung.GetFocusedRowCellValue("MANHOM").ToString(), "");
                    //gridView_TaiKhoan.SelectRow(i);
                    //gridControl_TaiKhoan.Refresh();
                }
            }
            loadgrid();
        }
        public void load_dataChucVu()
        {
            gridControl_ChucVu.DataSource = cHUCVUTableAdapter.Fill(this.dataSetQLNS.CHUCVU);
        }
        private void btn_Them_ChucVu_Click(object sender, EventArgs e)
        {
            if (mACHUCVUTextEdit.Text.Length > 0 && tENCHUCVUTextEdit.Text.Length > 0)
            {
                //kiem tra khoa chinh
                if (KTKC_New(mACHUCVUTextEdit.Text.ToString(), dataSetQLNS.CHUCVU) == false)
                {
                    cHUCVUTableAdapter.Insert(mACHUCVUTextEdit.Text, tENCHUCVUTextEdit.Text);
                    load_dataChucVu();
                    MessageBox.Show("Thêm thành công !!!");
                }
                else
                {
                    MessageBox.Show("Trùng khoá chính !!!");
                }
            }
            else
            {
                MessageBox.Show("Nhập thiếu dữ liệu !!!");
            }
        }

        private void btn_Xoa_ChucVu_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRow() != null)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                int cathu = gridView1.FocusedRowHandle;
                string sql_macv = gridView1.GetRowCellValue(cathu, "MACHUCVU").ToString();
                string sql_tencv = gridView1.GetRowCellValue(cathu, "TENCHUCVU").ToString();
                
                cHUCVUTableAdapter.Delete(sql_macv, sql_tencv);
                load_dataChucVu();
            }
            else
            {
                MessageBox.Show("Chọn dữ liệu để xóa!!!");
            }
        }

        private void btn_Sua_ChucVu_Click(object sender, EventArgs e)
        {
            if (mACHUCVUTextEdit.Text.Length > 0 && tENCHUCVUTextEdit.Text.Length > 0)
            {
                
                DataSetQLNS.CHUCVURow data = dataSetQLNS.CHUCVU.FindByMACHUCVU(mACHUCVUTextEdit.Text);
                data.TENCHUCVU = tENCHUCVUTextEdit.Text;
                cHUCVUTableAdapter.Update(this.dataSetQLNS.CHUCVU);
                //cHUCVUTableAdapter
                load_dataChucVu();
            }
            else
            {
                MessageBox.Show("Nhập thiếu dữ liệu !!!");
            }
        }
        public void load_dataPhongBan()
        {
            gridControl_PhongBan.DataSource = pHONGBANTableAdapter.Fill(this.dataSetQLNS.PHONGBAN);
        }

        private void btn_Them_PhongBan_Click(object sender, EventArgs e)
        {
            if (KTKC_New(mAPHONGBANTextEdit.Text.ToString(), dataSetQLNS.PHONGBAN) == false)
            {
                pHONGBANTableAdapter.Insert(mAPHONGBANTextEdit.Text, tENPHONGBANTextEdit.Text, mATRUONGPHONGTextEdit.Text);
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
                if (gridView_PhongBan.GetFocusedRow() != null)
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
                else
                {
                    MessageBox.Show("Chọn dữ liệu để xóa");
                }
            }
            catch
            {
                MessageBox.Show("Không thành công");
            }
        }

        private void btn_Sua_PhongBan_Click(object sender, EventArgs e)
        {
            if (gridView_PhongBan.GetFocusedRow() != null)
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
            else
            {
                MessageBox.Show("Chọn dữ liệu để sửa");
            }
        }
        public void load_dataQuocTich()
        {
            gridControl_QuocTich.DataSource = qUOCTICHTableAdapter.Fill(this.dataSetQLNS.QUOCTICH);
        }
        private void btn_Them_QuocTich_Click(object sender, EventArgs e)
        {
            if (mAQUOCTICHTextEdit.Text.Length > 0 && tENQUOCTICHTextEdit.Text.Length > 0)
            {
                //kiem tra khoa chinh
                if (KTKC_New(mAQUOCTICHTextEdit.Text.ToString(), dataSetQLNS.QUOCTICH) == false)
                {
                    qUOCTICHTableAdapter.Insert(mAQUOCTICHTextEdit.Text, tENQUOCTICHTextEdit.Text);
                    load_dataQuocTich();
                    MessageBox.Show("Thêm thành công !!!");
                }
                else
                {
                    MessageBox.Show("Trùng khoá chính !!!");
                }
            }
            else
            {
                MessageBox.Show("Nhập thiếu dữ liệu !!!");
            }
        }

        private void btn_Xoa_QuocTich_Click(object sender, EventArgs e)
        {
            if (gridView_QuocTich.GetFocusedRow() != null)
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
            else
            {
                MessageBox.Show("Chọn dữ liệu để xóa");
            }
        }

        private void btn_Sua_QuocTich_Click(object sender, EventArgs e)
        {
            if (gridView_QuocTich.GetFocusedRow() != null)
            {
                int cathu = gridView_QuocTich.FocusedRowHandle;
                String sql_maqt = gridView_QuocTich.GetRowCellValue(cathu, "MAQUOCTICH").ToString();
                String sql_tenqt = gridView_QuocTich.GetRowCellValue(cathu, "TENQUOCTICH").ToString();
                DataSetQLNS.QUOCTICHRow data = dataSetQLNS.QUOCTICH.FindByMAQUOCTICH(sql_maqt);
                data.TENQUOCTICH = sql_tenqt;
                qUOCTICHTableAdapter.Update(this.dataSetQLNS.QUOCTICH);
                load_dataQuocTich();
            }
            else
            {
                MessageBox.Show("Chọn dữ liệu để sửa");
            }
        }
        public void load_dataDanToc()
        {
            gridControl_DanToc.DataSource = dANTOCTableAdapter.Fill(this.dataSetQLNS.DANTOC);
        }
        private void btn_Them_DanToc_Click(object sender, EventArgs e)
        {
            if (mADANTOCTextEdit.Text.Length>0&& tENDANTOCTextEdit.Text.Length>0)
            {
                //kiem tra khoa chinh
                if (KTKC_New(mADANTOCTextEdit.Text.ToString(), dataSetQLNS.DANTOC) == false)
                {
                    dANTOCTableAdapter.Insert(mADANTOCTextEdit.Text, tENDANTOCTextEdit.Text);
                    load_dataDanToc();
                    MessageBox.Show("Thêm thành công !!!");
                }
                else
                {
                    MessageBox.Show("Trùng khoá chính !!!");

                }
            }
            else
            {
                MessageBox.Show("Nhập thiếu dữ liệu !!!");
            }
        }

        private void btn_Xoa_DanToc_Click(object sender, EventArgs e)
        {
            if (gridView_DanToc.GetFocusedRow() != null)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                int cathu = gridView_DanToc.FocusedRowHandle;
                string sql_madt = gridView_DanToc.GetRowCellValue(cathu, "MADANTOC").ToString();
                string sql_tendt = gridView_DanToc.GetRowCellValue(cathu, "TENDANTOC").ToString();
                
                dANTOCTableAdapter.Delete(sql_madt, sql_tendt);
                MessageBox.Show("Thành công");
                load_dataDanToc();
            }
            else
            {
                MessageBox.Show("Chọn dữ liệu để xóa");
            }
        }

        private void btn_Sua_DanToc_Click(object sender, EventArgs e)
        {
            if (gridView_DanToc.GetFocusedRow()!=null)
            {
                int cathu = gridView_DanToc.FocusedRowHandle;
                String sql_madt = gridView_DanToc.GetRowCellValue(cathu, "MADANTOC").ToString();
                String sql_tendt = gridView_DanToc.GetRowCellValue(cathu, "TENDANTOC").ToString();
                DataSetQLNS.DANTOCRow data = dataSetQLNS.DANTOC.FindByMADANTOC(sql_madt);
                data.TENDANTOC = sql_tendt;
                dANTOCTableAdapter.Update(this.dataSetQLNS.DANTOC);
                load_dataDanToc();
            }
            else
            {
                MessageBox.Show("Chọn dữ liệu để sửa");
            }
        }
        public void load_dataTonGiao()
        {
            gridControl_TonGiao.DataSource = tONGIAOTableAdapter.Fill(this.dataSetQLNS.TONGIAO);
        }
        private void btn_Them_TonGiao_Click(object sender, EventArgs e)
        {
            //kiem tra khoa chinh
            if (KTKC_New(mATONGIAOTextEdit.Text.ToString(), dataSetQLNS.TONGIAO) == false)
            {
                tONGIAOTableAdapter.Insert(mATONGIAOTextEdit.Text, tENTONGIAOTextEdit.Text);
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
           
            tONGIAOTableAdapter.Delete(sql_matg, sql_tentg); MessageBox.Show("Thành công");
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
        public void load_dataChuyenMon()
        {
            gridControl_ChuyenMon.DataSource = cHUYENMONTableAdapter.Fill(this.dataSetQLNS.CHUYENMON);
        }
        private void btn_Them_ChuyenMon_Click(object sender, EventArgs e)
        {
            //kiem tra khoa chinh
            if (KTKC_New(mACHUYENMONTextEdit.Text.ToString(), dataSetQLNS.CHUYENMON) == false)
            {
                cHUYENMONTableAdapter.Insert(mACHUYENMONTextEdit.Text, tENCHUYENMONTextEdit.Text);
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
            
            cHUYENMONTableAdapter.Delete(sql_macm, sql_tencm);MessageBox.Show("Thành công");
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
        public void load_dataDaoTao()
        {
            gridControl_DaoTao.DataSource = dAOTAOTableAdapter.Fill(this.dataSetQLNS.DAOTAO);
        }
        private void btn_Them_DaoTao_Click(object sender, EventArgs e)
        {
            //kiem tra khoa chinh
            if (KTKC_New(mAKHOADAOTAOTextEdit.Text.ToString(), dataSetQLNS.DAOTAO) == false)
            {
                dAOTAOTableAdapter.Insert(mAKHOADAOTAOTextEdit.Text, tENKHOADAOTAOTextEdit.Text);
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
            
            dAOTAOTableAdapter.Delete(sql_madt, sql_tendt);MessageBox.Show("Thành công");
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
        public void load_dataTDTinHoc()
        {
            gridControl_TinHoc.DataSource = tRINHDOTINHOCTableAdapter.Fill(this.dataSetQLNS.TRINHDOTINHOC);
        }
        private void btn_Them_TinHoc_Click(object sender, EventArgs e)
        {
            if (KTKC_New(mATRINHDOTINHOCTextEdit.Text.ToString(), dataSetQLNS.TRINHDOTINHOC) == false)
            {
                tRINHDOTINHOCTableAdapter.Insert(mATRINHDOTINHOCTextEdit.Text, tENTRINHDOTINHOCTextEdit.Text);
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
            
            tRINHDOTINHOCTableAdapter.Delete(sql_matdth, sql_tentdth);MessageBox.Show("Thành công");
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
        public void load_dataTDNgoaiNgu()
        {
            gridControl_NgoaiNgu.DataSource = nGOAINGUTableAdapter.Fill(this.dataSetQLNS.NGOAINGU);
        }
        private void btn_Them_NgoaiNgu_Click(object sender, EventArgs e)
        {
            if (KTKC_New(mANGOAINGUTextEdit.Text.ToString(), dataSetQLNS.NGOAINGU) == false)
            {
                nGOAINGUTableAdapter.Insert(mANGOAINGUTextEdit.Text, tENNGOAINGUTextEdit.Text);
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
            string sql_tentdnn = gridView_NgoaiNgu.GetRowCellValue(cathu, "TENNGOAINGU").ToString();
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
        public void load_dataTDHocVan()
        {
            gridControl_TDHocVan.DataSource = tRINHDOHOCVANTableAdapter.Fill(this.dataSetQLNS.TRINHDOHOCVAN);
        }
        private void btn_Them_TDHocVan_Click(object sender, EventArgs e)
        {
            if (KTKC_New(mATRINHDOHOCVANTextEdit.Text.ToString(), dataSetQLNS.TRINHDOHOCVAN) == false)
            {
                tRINHDOHOCVANTableAdapter.Insert(mATRINHDOHOCVANTextEdit.Text, tENTRINHDOHOCVANTextEdit.Text);
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
    }
}
