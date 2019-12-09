using System;
using System.Collections.Generic;
using System.Data;
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
        public CHITIETNGOAINGU BLL_loadChiTietNgoaiNgu(string p, string q)
        {
            return dal.loadChiTietNgoaiNgu(p,q);
        }
        public CHITIETCHUYENMON BLL_loadChiTietChuyenMon(string p, string q)
        {
            return dal.loadChiTietChuyenMon(p,q);
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

        public object BLL_loadChiTietChuyenMon(string v, DataRow dataRow)
        {
            throw new NotImplementedException();
        }
        public string BLL_FindUngVienByMaNV(string p)
        {
            return dal.FindUngVienByMaNV(p);
        }
    }
}
