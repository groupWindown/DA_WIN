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
            NHANVIEN nHANVIEN = linq.NHANVIENs.Where(t=>t.MANV==pMaNV).FirstOrDefault();
            nHANVIEN.TINHTRANG = "Nghỉ làm";
            linq.SubmitChanges();
            return true;
        }
        public bool KhoaTaiKhoan(string pMaNV)
        {
            TAIKHOAN tAIKHOAN = linq.TAIKHOANs.Where(t => t.MANV == pMaNV).FirstOrDefault();
            tAIKHOAN.HOATDONG = false;
            linq.SubmitChanges();
            return true;
        }
        public bool ThemQuanLyNghiViec(QUANLYNGHIVIEC qUANLYNGHIVIEC)
        {
            linq.QUANLYNGHIVIECs.InsertOnSubmit(qUANLYNGHIVIEC);
            linq.SubmitChanges();
            return true;
        }
    }
}
