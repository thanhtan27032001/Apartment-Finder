using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangTinThueTro.DTO
{
    public class DuyetTinDang
    {
        private string maTin;
        private string hoTenNguoiDang;
        private string tieuDe;
        private string moTa;
        public DuyetTinDang(string maTin, string hoTenNguoiDang, string tieuDe, string moTa)
        {
            this.maTin = maTin;
            this.hoTenNguoiDang = hoTenNguoiDang;
            this.tieuDe = tieuDe;
            this.moTa = moTa;
        }
        public string MaTin { get => maTin;}
        public string HoTenNguoiDang { get => hoTenNguoiDang;}
        public string TieuDe { get => tieuDe;}
        public string MoTa { get => moTa;}
    }
}
