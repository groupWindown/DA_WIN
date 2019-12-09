using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DAL
{
    public class DAL_Load
    {
        linQDataContext linQ = new linQDataContext();
        public List<TONGIAO> loadTonGiao()
        {
            return linQ.TONGIAOs.Select(t => t).ToList<TONGIAO>();
        }
        public List<DANTOC> loadDanToc()
        {
            return linQ.DANTOCs.Select(t => t).ToList<DANTOC>();
        }
        public List<TRINHDOHOCVAN> loadTrinhDoHocVan()
        {
            return linQ.TRINHDOHOCVANs.Select(t => t).ToList<TRINHDOHOCVAN>();
        }
        public List<TRINHDOTINHOC> loadTrinhDoTinHoc()
        {
            return linQ.TRINHDOTINHOCs.Select(t => t).ToList<TRINHDOTINHOC>();
        }
        public List<QUOCTICH> loadQuocTich()
        {
            return linQ.QUOCTICHes.Select(t => t).ToList<QUOCTICH>();
        }
        public List<PHONGBAN> loadPhongBan()
        {
            return linQ.PHONGBANs.Select(t => t).ToList<PHONGBAN>();
        }
        public List<CHUCVU> loadChucVu()
        {
            return linQ.CHUCVUs.Select(t => t).ToList<CHUCVU>();
        }
        public NHANVIEN loadThongTinNhanVien(string p)
        {
            return linQ.NHANVIENs.Where(t => t.MANV == p).FirstOrDefault();
        }
        public List<CHUYENMON> loadChuyenMon()
        {
            return linQ.CHUYENMONs.Select(t => t).ToList<CHUYENMON>();
        }
        public List<NGOAINGU> loadNgoaiNgu()
        {
            return linQ.NGOAINGUs.Select(t => t).ToList<NGOAINGU>();
        }
        public CHITIETNGOAINGU loadChiTietNgoaiNgu(string pMaNV, string pMaNN)
        {
            if (linQ.NHANVIENs.Where(t => t.MANV == pMaNV).FirstOrDefault() == null)
                return null;
            string UV = linQ.NHANVIENs.Where(t => t.MANV == pMaNV).FirstOrDefault().MAHOSO.ToString();
            return linQ.CHITIETNGOAINGUs.Where(t => t.MAUNGVIEN == UV && t.MANGOAINGU == pMaNN).FirstOrDefault();
        }
        public CHITIETCHUYENMON loadChiTietChuyenMon(string pMaNV, string pMaCM)
        {
            if (linQ.NHANVIENs.Where(t => t.MANV == pMaNV).FirstOrDefault() == null)
                return null;
            string UV = linQ.NHANVIENs.Where(t => t.MANV == pMaNV).FirstOrDefault().MAHOSO.ToString();
            return linQ.CHITIETCHUYENMONs.Where(t => t.MAUNGVIEN == UV && t.MACHUYENMON == pMaCM).FirstOrDefault();
        }
        public List<HOSOTUYENDUNG> loadHoSoTuyenDung()
        {
            return linQ.HOSOTUYENDUNGs.Select(t => t).ToList<HOSOTUYENDUNG>();
        }
        public HOSOTUYENDUNG loadHoSoTuyenDungUngVien(string p)
        {
            return linQ.HOSOTUYENDUNGs.Where(t => t.MAUNGVIEN == p).FirstOrDefault();
        }
        public List<NHANVIEN> loadNhanVien()
        {
            return linQ.NHANVIENs.Select(t => t).ToList<NHANVIEN>();
        }
        public List<HINHANH> loadHinhAnh()
        {
            return linQ.HINHANHs.Select(t => t).ToList<HINHANH>();
        }
        public string loadTenChucVu(string pMaCV)
        {
            if (linQ.CHUCVUs.Where(t => t.MACHUCVU == pMaCV).FirstOrDefault() != null)
            {
                return linQ.CHUCVUs.Where(t => t.MACHUCVU == pMaCV).FirstOrDefault().TENCHUCVU.ToString();
            }
            else
            {
                return null;
            }
        }
        public string loadTenPhongBan(string pMaPB)
        {
            if (linQ.PHONGBANs.Where(t => t.MAPHONGBAN == pMaPB).FirstOrDefault() != null)
            {
                return linQ.PHONGBANs.Where(t => t.MAPHONGBAN == pMaPB).FirstOrDefault().TENPHONGBAN.ToString();
            }
            else
            {
                return null;
            }
        }
        public byte[] loadURLHinhAnh(string pMaNV)
        {
            if (linQ.NHANVIENs.Where(t => t.MANV == pMaNV).FirstOrDefault() == null)
                return null;
            string UV = linQ.NHANVIENs.Where(t => t.MANV == pMaNV).FirstOrDefault().MAHOSO.ToString();
            string s = linQ.HINHANHs.Where(t => t.MAUNGVIEN == UV).FirstOrDefault().URL.ToString();
            byte[] s1 = linQ.HINHANHs.Where(t => t.MAUNGVIEN == UV).FirstOrDefault().URL.ToArray();
            return s1;
        }
        public List<QUANLYNGHIVIEC> loadQuanLyNghiViec()
        {
            return linQ.QUANLYNGHIVIECs.Select(t => t).ToList<QUANLYNGHIVIEC>();
        }
        public List<QUANLYKYLUAT> loadQuanLyKyLuat()
        {
            return linQ.QUANLYKYLUATs.Select(t => t).ToList<QUANLYKYLUAT>();
        }
        public List<QUANLYTHAISAN> loadQuanLyThaiSan()
        {
            return linQ.QUANLYTHAISANs.Select(t => t).ToList<QUANLYTHAISAN>();
        }
        public string FindUngVienByMaNV(string pMaNV)
        {
            if (linQ.NHANVIENs.Where(t => t.MANV == pMaNV).FirstOrDefault() == null)
                return null;
            return linQ.NHANVIENs.Where(t => t.MANV == pMaNV).FirstOrDefault().MAHOSO.ToString();
        }
        public List<BangGhepHopDongLaoDong> loadHopDongNhanVien(string pMaNhanVien)
        {
            var temp = (from mh in linQ.HOPDONGLAODONGs
                        join lmh in linQ.CHITIETHOPDONGs on mh.MAHOPDONG
                        equals lmh.MAHOPDONG
                        where pMaNhanVien==lmh.MANV
                        select new
                        {
                            MaHopdong = mh.MAHOPDONG,
                            TenHopdong = mh.TENHOPDONG,
                            KyLanThu = lmh.KYLANTHU,
                            NgayBD = lmh.NGAYBD,
                            NgayKT = lmh.NGAYKT,
                            NgayKy = lmh.NGAYKY,
                            LuongThoaThuan = lmh.LUONGTHOATHUAN,

                        }).AsEnumerable().Select(x => new BangGhepHopDongLaoDong
                        {
                            MaHopDong = x.MaHopdong,
                            TenHopDong = x.TenHopdong,
                            KyLanThu = x.KyLanThu,
                            NgayBatDau = x.NgayBD,
                            NgayKetThuc = x.NgayKT,
                            NgayKy = x.NgayKy,
                            LuongThoaThuan = x.LuongThoaThuan,

                        }).ToList<BangGhepHopDongLaoDong>(); 
            
            return temp;
         }
    }
}
