using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangTinThueTro.DTO
{
    public class DuyetNguoiDung
    {
        private int maNguoiDung;
        private string hoTen;
        private string soDT;

        public DuyetNguoiDung(int maNguoiDung, string hoTen, string soDT)
        {
            this.maNguoiDung = maNguoiDung;
            this.hoTen = hoTen;
            this.soDT = soDT;
        }

        public int MaNguoiDung { get => maNguoiDung;}
        public string HoTen { get => hoTen; }
        public string SoDT { get => soDT; }
    }
}
