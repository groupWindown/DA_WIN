﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Load
    {
        linQDataContext linQ = new linQDataContext();
        public List<TONGIAO> loadTonGiao()
        {
            return linQ.TONGIAOs.Select(t=>t).ToList<TONGIAO>();
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
        public List<CHUYENMON> loadChuyenMon()
        {
            return linQ.CHUYENMONs.Select(t => t).ToList<CHUYENMON>();
        }
        public List<NGOAINGU> loadNgoaiNgu()
        {
            return linQ.NGOAINGUs.Select(t => t).ToList<NGOAINGU>();
        }
        public string loadChiTietNgoaiNgu(string pMaNN)
        {
            if(linQ.CHITIETNGOAINGUs.Where(t => t.MANGOAINGU == pMaNN).FirstOrDefault()!=null)
            {
                return linQ.CHITIETNGOAINGUs.Where(t => t.MANGOAINGU == pMaNN).FirstOrDefault().ToString();
            }
            return null;
        }
        public string loadChiTietChuyenMon(string pMaCM)
        {
            if( linQ.CHITIETCHUYENMONs.Where(t => t.MACHUYENMON== pMaCM).FirstOrDefault()!=null)
            {
                return linQ.CHITIETCHUYENMONs.Where(t => t.MACHUYENMON == pMaCM).FirstOrDefault().ToString();
            }
            return null;
        }




    }
}
