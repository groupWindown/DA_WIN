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
    public partial class frm_GiaHanHopDong : Form
    {
        BLL_Load bLL_Load = new BLL_Load();
        BLL_NhanVien bLL_nhanvien = new BLL_NhanVien();
        string NV;
        public frm_GiaHanHopDong(string pManv,int num)
        {
            InitializeComponent();
            txtMaNV.Text = pManv;
            txtHoTen.Text = bLL_Load.BLL_loadThongTinNhanVien(pManv).HOTEN.ToString();
            cboChucVu.Text = bLL_Load.BLL_loadTenChucVu(bLL_Load.BLL_loadThongTinNhanVien(pManv).MACHUCVU.ToString());
            cboPhongBan.Text = bLL_Load.BLL_loadTenPhongBan(bLL_Load.BLL_loadThongTinNhanVien(pManv).MAPHONGBAN.ToString());
            NV = pManv;
            txtMaHopDong.Text = bLL_nhanvien.sinhtudongMaHopDong(0);
            spinEditKyLanThu.Text = num.ToString();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frm_GiaHanHopDong_Load(object sender, EventArgs e)
        {
            cboLoaiHopDong.DataSource = bLL_Load.BLL_loadHopDong();
            cboLoaiHopDong.DisplayMember = "TENHOPDONG";
            cboLoaiHopDong.ValueMember = "MAHOPDONG";
            cboLoaiHopDong.SelectedIndex = 0;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text.Length > 0 && txtMaHopDong.Text.Length > 0 && spinEditKyLanThu.Text.Length > 0 && txtMaNV.Text.Length > 0 && dateEditNgayBatDau.DateTime.ToString() != "1/1/0001 12:00:00 AM" && dateEditNgayKetThuc.DateTime.ToString() != "1/1/0001 12:00:00 AM" && dateEditNgayKy.DateTime.ToString() != "1/1/0001 12:00:00 AM")
            {
                CHITIETHOPDONG cHITIETHOPDONG = new CHITIETHOPDONG();
                cHITIETHOPDONG.MACTHD = txtMaHopDong.Text;
                cHITIETHOPDONG.MAHOPDONG = cboLoaiHopDong.SelectedValue.ToString();
                cHITIETHOPDONG.MANV = NV;
                cHITIETHOPDONG.NGAYKY = dateEditNgayKy.DateTime;
                cHITIETHOPDONG.NGAYBD = dateEditNgayBatDau.DateTime;
                cHITIETHOPDONG.NGAYKT = dateEditNgayKetThuc.DateTime;
                cHITIETHOPDONG.LUONGTHOATHUAN = decimal.Parse( txtLuong.Text);
                cHITIETHOPDONG.KYLANTHU = int.Parse(spinEditKyLanThu.Text);
                if (bLL_nhanvien.BLL_ThemChiTietHopDong(cHITIETHOPDONG))
                { MessageBox.Show("Thành công"); return; }
                MessageBox.Show("Trùng khóa");

            }
            else
                MessageBox.Show("Vui lòng nhập đủ dữ liệu");
        }

        private void txtLuong_TextChanged(object sender, EventArgs e)
        {
            if (txtLuong.Text.Length > 15)
            {
                MessageBox.Show("Vượt tầm kiểm soát số liệu (max 15 số)");
                txtLuong.Text = txtLuong.Text.Substring(0, 15);
            }
        }

        private void txtLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
