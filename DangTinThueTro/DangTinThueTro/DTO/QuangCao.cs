using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangTinThueTro.DTO
{
    public class QuangCao
    {
        private string maTin;
        private string maGoiQC;
        private string ngayHieuLuc;
        private string ngayKetThuc;
        private int soNgayHieuLuc;

        // Constructor để Select từ db
        public QuangCao(string maTin, string maGoiQC, string ngayHieuLuc, string ngayKetThuc)
        {
            this.maTin = maTin;
            this.maGoiQC = maGoiQC;
            this.ngayHieuLuc = ngayHieuLuc;
            this.ngayKetThuc = ngayKetThuc;
        }
        // Constructor tạo quảng cáo upload db
        public QuangCao(string maTin, string maGoiQC, int soNgayHieuLuc)
        {
            this.maTin = maTin;
            this.maGoiQC = maGoiQC;
            this.soNgayHieuLuc = soNgayHieuLuc;
        }
        public string MaTin { get => maTin; }
        public string MaGoiQC { get => maGoiQC; }
        public string NgayHieuLuc { get => ngayHieuLuc; }
        public int SoNgayHieuLuc { get => soNgayHieuLuc;}
        public string NgayKetThuc { get => ngayKetThuc; }
    }
}
