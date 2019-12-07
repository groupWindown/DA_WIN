using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
     public class BLL_Load
    {
        DAL_Load dal = new DAL_Load();
        public List<TONGIAO> BLL_loadTonGiao()
        {
            return dal.loadTonGiao();
        }
        public List<DANTOC> BLL_loadDanToc()
        {
            return dal.loadDanToc();
        }
        public List<TRINHDOHOCVAN> BLL_loadTrinhDoHocVan()
        {
            return dal.loadTrinhDoHocVan();
        }
        public List<TRINHDOTINHOC> BLL_loadTrinhDoTinHoc()
        {
            return dal.loadTrinhDoTinHoc();
        }
        public List<QUOCTICH> BLL_loadQuocTich()
        {
            return dal.loadQuocTich();
        }
        public List<PHONGBAN> BLL_loadPhongBan()
        {
            return dal.loadPhongBan();
        }
        public List<CHUCVU> BLL_loadChucVu()
        {
            return dal.loadChucVu();
        }
        public List<CHUYENMON> BLL_loadChuyenMon()
        {
            return dal.loadChuyenMon();
        }
        public List<NGOAINGU> BLL_loadNgoaiNgu()
        {
            return dal.loadNgoaiNgu();
        }
        public List<CHITIETNGOAINGU> BLL_loadChiTietNgoaiNgu(string p)
        {
            return dal.loadChiTietNgoaiNgu(p);
        }
        public List<CHITIETCHUYENMON> BLL_loadChiTietChuyenMon(string p)
        {
            return dal.loadChiTietChuyenMon(p);
        }
        public List<HOSOTUYENDUNG> BLL_loadHoSoTuyenDung()
        {
            return dal.loadHoSoTuyenDung();
        }
        public List<NHANVIEN> BLL_loadNhanVien()
        {
            return dal.loadNhanVien();
        }
        public List<HINHANH> BLL_loadHinhAnh()
        {
            return dal.loadHinhAnh();
        }
        public string BLL_loadTenChucVu(string p)
        {
            return dal.loadTenChucVu(p);
        }
        public string BLL_loadTenPhongBan(string p)
        {
            return dal.loadTenPhongBan(p);
        }
        public byte[] BLL_loadURLHinhAnh(string p)
        {
            return dal.loadURLHinhAnh(p);
        }
    }
}
