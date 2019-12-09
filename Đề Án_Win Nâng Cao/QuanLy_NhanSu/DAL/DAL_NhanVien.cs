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
        public bool UpdateHinhAnh(HINHANH p)
        {
            HINHANH hinh = linq.HINHANHs.Where(t => t.MAHINHANH == p.MAHINHANH).FirstOrDefault();
            hinh.MAUNGVIEN = p.MAUNGVIEN;
            hinh.TENHINHANH = p.TENHINHANH;
            hinh.URL = p.URL;
         
            linq.SubmitChanges();
            return true;
        }
        public bool InsertHinhAnh(HINHANH p)
        {
            linq.HINHANHs.InsertOnSubmit(p);
            linq.SubmitChanges();
            return true;
        }
        public string FindHinhAnhByMaNV(string p)
        {
            if (linq.HINHANHs.Where(t => t.MAUNGVIEN == p).FirstOrDefault() != null)
                return linq.HINHANHs.Where(t => t.MAUNGVIEN == p).FirstOrDefault().MAHINHANH;
            else return null;
        }
    }
}
