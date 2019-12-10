using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_KiemTra
    {
        linQDataContext linQ = new linQDataContext();
    
        public bool kiemTraTrungMaQLNV(string p)
        {
            if(linQ.QUANLYNGHIVIECs.Where(t => t.MAQUANLYNGHIVIEC == p).FirstOrDefault()!=null)
                return false;
            return true;
        }
        public bool kiemTraTrungMaQLTS(string p)
        {
            if (linQ.QUANLYTHAISANs.Where(t => t.MAQUANLYTHAISAN == p).FirstOrDefault()!=null)
                 return false;
            return true;
        }
        public bool kiemTraTrungMaQLKL(string p)
        {
            if(linQ.QUANLYKYLUATs.Where(t => t.MAQUANLYKYLUAT == p).FirstOrDefault()!=null)
                return false;
            return true;
        }
        public bool kiemTraTrungMaHinhAnh(string p)
        {
            if (linQ.HINHANHs.Where(t => t.MAHINHANH == p).FirstOrDefault() != null)
                return false;
            return true;
        }
        public bool kiemTraTrungMaHopDong(string p)
        {
            if (linQ.CHITIETHOPDONGs.Where(t => t.MACTHD == p).FirstOrDefault() != null)
                return false;
            return true;
        }
    }
}
