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
        DAL_KiemTra dAL_KiemTra = new DAL_KiemTra();
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

        public string sinhtudongMaQLNV(int v)
        {
            int number = dAL_Load.loadQuanLyNghiViec().Count + 1 + v;
            int value = number;
            int strick = 1;
            while (number < 9999)
            {
                number = value + strick;
                strick *= 10;
            }
            string str = "QLNV" + number.ToString().Substring(1, 4);
            if (!dAL_KiemTra.kiemTraTrungMaQLNV(str))
            {
                return sinhtudongMaQLNV(++v);
            }
            else
            {
                return str;
            }

        }
        public bool BLL_UpdateHinhAnh(HINHANH p)
        {
            return dAL_NhanVien.UpdateHinhAnh(p);
        }
        public bool BLL_InsertHinhAnh(HINHANH p)
        {
            return dAL_NhanVien.InsertHinhAnh(p);
        }
        public string BLL_FindHinhAnhByMANV(string p)
        {
            return dAL_NhanVien.FindHinhAnhByMaNV(p);
        }
        public string sinhtudongMaHinhAnh(int v)
        {
            int number = dAL_Load.loadHinhAnh().Count + 1 + v;
            int value = number;
            int strick = 1;
            while (number < 999999)
            {
                number = value + strick;
                strick *= 10;
            }
            string str = "HA" + number.ToString().Substring(1, 6);
            if (!dAL_KiemTra.kiemTraTrungMaQLNV(str))
            {
                return sinhtudongMaHinhAnh(++v);
            }
            else
            {
                return str;
            }

        }
    }
}
