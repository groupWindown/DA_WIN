using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class BLL_NhanVien
    {
        DAL_Load dAL_Load = new DAL_Load();
        DAL_NhanVien dAL_NhanVien = new DAL_NhanVien();

        public bool BLL_XoaNV(string pMaNV)
        {
            return dAL_NhanVien.XoaNV(pMaNV);
        }
        public bool BLL_KhoaTaiKhoan(string pMaNV)
        {
            return dAL_NhanVien.KhoaTaiKhoan(pMaNV);
        }
        public bool ThemQuanLyNghiViec(QUANLYNGHIVIEC qUANLYNGHIVIEC)
        {
            return dAL_NhanVien.ThemQuanLyNghiViec(qUANLYNGHIVIEC);
        }
    }
}
