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
            return true;
        }
    }
}
