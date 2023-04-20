using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangTinThueTro.DTO
{
    public class TinDangQL
    {
        private string maTin;
        private string ngayDang;
        private string tieuDe;
        private string moTa;
        private bool daDuyet;
        private bool daAn;

        // Constructor để Select từ db -> Quản lý tin
        public TinDangQL(string maTin, string ngayDang, string tieuDe, string moTa, bool daDuyet, bool daAn)
        {
            this.maTin = maTin;
            this.ngayDang = ngayDang;
            this.tieuDe = tieuDe;
            this.moTa = moTa;
            this.daDuyet = daDuyet;
            this.daAn = daAn;
        }
        // Constructor để Insert db
        public TinDangQL(string maTin, string ngayDang, string tieuDe, string moTa)
        {
            this.maTin = maTin;
            this.ngayDang = ngayDang;
            this.tieuDe = tieuDe;
            this.moTa = moTa;
        }

        public string MaTin { get => maTin; set => maTin = value; }
        public string NgayDang { get => ngayDang; set => ngayDang = value; }
        public string TieuDe { get => tieuDe; set => tieuDe = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public bool DaAn { get => daAn; set => daAn = value; }
        public bool DaDuyet { get => daDuyet; set => daDuyet = value; }
    }
}
