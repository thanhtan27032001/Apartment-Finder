using DangTinThueTro.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangTinThueTro.DTO
{
    public class TinDang
    {
        private string maTin;
        private string ngayDang;
        private string tieuDe;
        private string moTa;
        private double chieuDai;
        private double chieuRong;
        private int soPhongTrong;
        private int giaDien;
        private int giaNuoc;
        private int giaPhong;
        private string anhThamKhao;
        private string soNha;
        private string maXaPhuong;
        private bool daThich;

        public TinDang(string maTin, string ngayDang, string tieuDe, string moTa, double chieuDai, double chieuRong, int soPhongTrong, int giaDien, int giaNuoc, int giaPhong, string anhThamKhao, string soNha, string maXaPhuong, bool daThich)
        {
            this.maTin = maTin;
            this.ngayDang = ngayDang;
            this.tieuDe = tieuDe;
            this.moTa = moTa;
            this.chieuDai = chieuDai;
            this.chieuRong = chieuRong;
            this.soPhongTrong = soPhongTrong;
            this.giaDien = giaDien;
            this.giaNuoc = giaNuoc;
            this.giaPhong = giaPhong;
            this.anhThamKhao = anhThamKhao;
            this.soNha = soNha;
            this.maXaPhuong = maXaPhuong;
            this.daThich = daThich;
        }

        public string MaTin { get => maTin; set => maTin = value; }
        public string NgayDang { get => ngayDang; set => ngayDang = value; }
        public string TieuDe { get => tieuDe; set => tieuDe = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public double ChieuDai { get => chieuDai; set => chieuDai = value; }
        public double ChieuRong { get => chieuRong; set => chieuRong = value; }
        public int SoPhongTrong { get => soPhongTrong; set => soPhongTrong = value; }
        public int GiaDien { get => giaDien; set => giaDien = value; }
        public int GiaNuoc { get => giaNuoc; set => giaNuoc = value; }
        public int GiaPhong { get => giaPhong; set => giaPhong = value; }
        public string AnhThamKhao { get => anhThamKhao; set => anhThamKhao = value; }
        public string SoNha { get => soNha; set => soNha = value; }
        public string MaXaPhuong { get => maXaPhuong; set => maXaPhuong = value; }
        public bool DaThich { get => daThich; set => daThich = value; }
    }
}
