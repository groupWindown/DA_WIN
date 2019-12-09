using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BangGhepHopDongLaoDong
    {
        private string maHopDong;
        private string tenHopDong;
        private int? kyLanThu;
        private DateTime? ngayKy;
        private DateTime? ngayBatDau;
        private DateTime? ngayKetThuc;
        private decimal? luongThoaThuan;

        public string MaHopDong { get => maHopDong; set => maHopDong = value; }
        public string TenHopDong { get => tenHopDong; set => tenHopDong = value; }
        public int? KyLanThu { get => kyLanThu; set => kyLanThu = value; }
        public DateTime? NgayKy { get => ngayKy; set => ngayKy = value; }
        public DateTime? NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public DateTime? NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }
        public decimal? LuongThoaThuan { get => luongThoaThuan; set => luongThoaThuan = value; }
    }
}
