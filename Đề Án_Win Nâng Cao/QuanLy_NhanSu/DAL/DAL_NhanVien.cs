using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_NhanVien
    {
        linQDataContext linq = new linQDataContext();
        public bool XoaNV(string pMaNV)
        {
            try
            {
                NHANVIEN nHANVIEN = linq.NHANVIENs.Where(t => t.MANV == pMaNV).FirstOrDefault();
                nHANVIEN.TINHTRANG = "Nghỉ làm";
                linq.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool KhoaTaiKhoan(string pMaNV)
        {
            try
            {
                TAIKHOAN tAIKHOAN = linq.TAIKHOANs.Where(t => t.MANV == pMaNV).FirstOrDefault();
                tAIKHOAN.HOATDONG = false;
                linq.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool ThemQuanLyNghiViec(QUANLYNGHIVIEC qUANLYNGHIVIEC)
        {
            try
            {
                linq.QUANLYNGHIVIECs.InsertOnSubmit(qUANLYNGHIVIEC);
                linq.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool SuaHinhAnh(HINHANH p)
        {
            HINHANH hinh = linq.HINHANHs.Where(t => t.MAHINHANH == p.MAHINHANH).FirstOrDefault();   
            hinh.TENHINHANH = p.TENHINHANH;
            hinh.URL = p.URL;
         
            linq.SubmitChanges();
            return true;
        }
        public bool ThemHinhAnh(HINHANH p)
        {
            linq.HINHANHs.InsertOnSubmit(p);
            linq.SubmitChanges();
            return true;
        }
        public string FindHinhAnhByMaNV(string p)
        {
            if (linq.NHANVIENs.Where(t => t.MANV == p).FirstOrDefault() == null)
                return null;
            string UV = linq.NHANVIENs.Where(t => t.MANV == p).FirstOrDefault().MAHOSO.ToString();

            if (linq.HINHANHs.Where(t => t.MAUNGVIEN == UV).FirstOrDefault() != null)
                return linq.HINHANHs.Where(t => t.MAUNGVIEN == UV).FirstOrDefault().MAHINHANH;
            else return null;
        }
        public bool SuaHoSoNV(HOSOTUYENDUNG p)
        {
            try
            {
                HOSOTUYENDUNG hOSOTUYENDUNG = linq.HOSOTUYENDUNGs.Where(t => t.MAUNGVIEN == p.MAUNGVIEN).FirstOrDefault();
                hOSOTUYENDUNG.HOTEN = p.HOTEN;
                hOSOTUYENDUNG.DIENTHOAI = p.DIENTHOAI;
                hOSOTUYENDUNG.EMAIL = p.EMAIL;
                hOSOTUYENDUNG.GIOITINH = p.GIOITINH;
                hOSOTUYENDUNG.NGAYSINH = p.NGAYSINH;
                hOSOTUYENDUNG.NGAYCAP = p.NGAYCAP;
                hOSOTUYENDUNG.NGAYTUYENDUNG = p.NGAYTUYENDUNG;
                hOSOTUYENDUNG.NOICAP = p.NOICAP;
                hOSOTUYENDUNG.NOIOHIENTAI = p.NOIOHIENTAI;
                hOSOTUYENDUNG.NOISINH = p.NOISINH;
                hOSOTUYENDUNG.QUEQUAN = p.QUEQUAN;
                hOSOTUYENDUNG.TINHTRANGHONNHAN = p.TINHTRANGHONNHAN;
                hOSOTUYENDUNG.TINHTRANGSUCKHOE = p.TINHTRANGSUCKHOE;
                hOSOTUYENDUNG.MATRINHDOHOCVAN = p.MATRINHDOHOCVAN;
                hOSOTUYENDUNG.MATRINHDOTINHOC = p.MATRINHDOTINHOC;
                hOSOTUYENDUNG.MADANTOC = p.MADANTOC;
                hOSOTUYENDUNG.MAQUOCTICH = p.MAQUOCTICH;
                hOSOTUYENDUNG.MATONGIAO = p.MATONGIAO;
                hOSOTUYENDUNG.DIENUUTIEN = p.DIENUUTIEN;
                hOSOTUYENDUNG.CMND = p.CMND;
                hOSOTUYENDUNG.DIACHITHUONGTRU = p.DIACHITHUONGTRU;


                linq.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool ThemChiTietChuyenMon(CHITIETCHUYENMON p)
        {
            linQDataContext chitiet = new linQDataContext();
            chitiet.CHITIETCHUYENMONs.InsertOnSubmit(p);
            chitiet.SubmitChanges();
            return true;
        }

        public bool XoaChiTietChuyenMon(CHITIETCHUYENMON pchitiet)
        {
            linQDataContext chitiet = new linQDataContext();
            chitiet.CHITIETCHUYENMONs.Attach(pchitiet);
            chitiet.CHITIETCHUYENMONs.DeleteOnSubmit(pchitiet);
            chitiet.SubmitChanges();
            return true;
        }
        public bool ThemChiTietNgoaiNgu(CHITIETNGOAINGU p)
        {
            linQDataContext chitiet1 = new linQDataContext();
            chitiet1.CHITIETNGOAINGUs.InsertOnSubmit(p);
            chitiet1.SubmitChanges();
            return true;
        }

        public bool XoaChiTietNgoaiNgu(CHITIETNGOAINGU p)
        {
            linQDataContext chitiet1 = new linQDataContext();
            chitiet1.CHITIETNGOAINGUs.Attach(p);
            chitiet1.CHITIETNGOAINGUs.DeleteOnSubmit(p);
            chitiet1.SubmitChanges();
            return true;
        }
        public bool SuaNhanVien(NHANVIEN pNhanVien)
        {
            try
            {
                NHANVIEN nHANVIEN= linq.NHANVIENs.Where(t=>t.MANV==pNhanVien.MANV).FirstOrDefault();
                nHANVIEN.HOTEN = pNhanVien.HOTEN;
                nHANVIEN.MACHUCVU = pNhanVien.MACHUCVU;
                nHANVIEN.MAPHONGBAN = pNhanVien.MAPHONGBAN;
                nHANVIEN.NGAYVAOLAM = pNhanVien.NGAYVAOLAM;
                linq.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
