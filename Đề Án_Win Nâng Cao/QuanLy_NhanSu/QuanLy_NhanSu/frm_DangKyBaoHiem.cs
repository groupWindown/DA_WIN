using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
namespace QuanLy_NhanSu
{
    public partial class frm_DangKyBaoHiem : Form
    {
        BLL_Load bLL_Load = new BLL_Load();
        BLL_NhanVien bLL_NhanVien = new BLL_NhanVien();
        public frm_DangKyBaoHiem()
        {
            InitializeComponent();
        }
        string NV;
        public frm_DangKyBaoHiem(string pMaNV)
        {
            InitializeComponent();

            txtMaNv.Text = pMaNV;
            txtHoTen.Text = bLL_Load.BLL_loadThongTinNhanVien(pMaNV).HOTEN.ToString();
            cboChucVu.Text = bLL_Load.BLL_loadTenChucVu(bLL_Load.BLL_loadThongTinNhanVien(pMaNV).MACHUCVU.ToString());
            cboPhongBan.Text = bLL_Load.BLL_loadTenPhongBan(bLL_Load.BLL_loadThongTinNhanVien(pMaNV).MAPHONGBAN.ToString());
            NV = pMaNV;


        }
        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text.Length > 0 && txtMaBH.Text.Length > 0 && txtNoiCap.Text.Length > 0 && cboLoaiBH.Text.Length > 0 && dateEditNgayDK.DateTime.ToString() != "1/1/0001 12:00:00 AM" && dateEditNgayHH.DateTime.ToString() != "1/1/0001 12:00:00 AM")
            {
                BAOHIEM bAOHIEM = new BAOHIEM();
                bAOHIEM.LOAIBAOHIEM =cboLoaiBH.Text;
                bAOHIEM.MABAOHIEM = txtMaBH.Text ;
                bAOHIEM.MANV =NV;
                bAOHIEM.NGAYDK =dateEditNgayDK.DateTime;
                bAOHIEM.NGAYHH =dateEditNgayHH.DateTime;
                bAOHIEM.NOICAP =txtNoiCap.Text;
                bAOHIEM.NOIKHAM =txtnoikhams.Text;
                if (bLL_NhanVien.BLL_ThemBaoHiem(bAOHIEM))
                {MessageBox.Show("Thành công"); return; }
                MessageBox.Show("Trùng khóa");
                    
            }
            else
                MessageBox.Show("Vui lòng nhập đủ dữ liệu"); 
        }


        private void frm_DangKyBaoHiem_Load(object sender, EventArgs e)
        {
            cboLoaiBH.Items.Add("Y tế");
            cboLoaiBH.Items.Add("Lao động");
            cboLoaiBH.SelectedIndex = 0;
        }
    }
}
