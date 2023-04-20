using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangTinThueTro.DTO
{
    public class YeuThich
    {
        private int maNguoiDung;
        private string maTin;

        // Constructor Insert db
        public YeuThich(int maNguoiDung, string maTin)
        {
            this.maNguoiDung = maNguoiDung;
            this.maTin = maTin;
        }

        public int MaNguoiDung { get => maNguoiDung; set => maNguoiDung = value; }
        public string MaTin { get => maTin; set => maTin = value; }
    }
}
