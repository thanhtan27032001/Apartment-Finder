using DangTinThueTro.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangTinThueTro.DTO
{
    public class PhongTro
    {
        private string maPhongTro;
        private double chieuDai;
        private double chieuRong;
        private int soPhongTrong;
        private int giaPhong;
        private string anhThamKhao;
        private string? trangThai;
        private int maNhaTro;
        public const string DA_DANG_TIN = "dadangtin";
        public const string CHUA_DANG_TIN = "chuadangtin";
        public const string DANG_CHO_DUYET = "dangchoduyet";


        // Constructer để Insert db
        public PhongTro(string maPhongTro, double chieuDai, double chieuRong, int soPhongTrong, int giaPhong, string anhThamKhao)
        {
            this.maPhongTro = maPhongTro;
            this.chieuDai = chieuDai;
            this.chieuRong = chieuRong;
            this.soPhongTrong = soPhongTrong;
            this.giaPhong = giaPhong;
            this.anhThamKhao = anhThamKhao;
        }
        // Constructor để Select từ db -> quản lý trọ
        public PhongTro(string maPhongTro, double chieuDai, double chieuRong, int soPhongTrong, int giaPhong, string anhThamKhao, string trangThai)
        {
            this.maPhongTro = maPhongTro;
            this.chieuDai = chieuDai;
            this.chieuRong = chieuRong;
            this.soPhongTrong = soPhongTrong;
            this.giaPhong = giaPhong;
            this.anhThamKhao = anhThamKhao;
            this.trangThai = trangThai;
        }
        // Constructor để Select db thông tin cơ bản -> tin đăng
        public PhongTro(double chieuDai, double chieuRong, int soPhongTrong, int giaPhong, string anhThamKhao, int maNhaTro)
        {
            this.chieuDai = chieuDai;
            this.chieuRong = chieuRong;
            this.soPhongTrong = soPhongTrong;
            this.giaPhong = giaPhong;
            this.anhThamKhao = anhThamKhao;
            this.maNhaTro = maNhaTro;
        }
        // Kiểm tra xem phòng trọ này có phải của người dùng không
        public static bool LaPhongTroCuaToi(string maPhongTro)
        {
            int maChuPhongTro = PhongTroDAO.Instance.GetMaChuPhongTro(maPhongTro);
            return AccountDAO.Instance.MaNguoiDung.Equals(maChuPhongTro);
        }

        public string MaPhongTro { get => maPhongTro; }
        public double ChieuDai { get => chieuDai; }
        public double ChieuRong { get => chieuRong; }
        public int SoPhongTrong { get => soPhongTrong; set => soPhongTrong = value; }
        public int GiaPhong { get => giaPhong; set => giaPhong = value; }
        public string AnhThamKhao { get => anhThamKhao; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public int MaNhaTro { get => maNhaTro; set => maNhaTro = value; }
    }
}
