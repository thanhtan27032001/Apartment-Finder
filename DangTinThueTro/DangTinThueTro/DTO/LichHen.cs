using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangTinThueTro.DTO
{
    public class LichHen
    {
        private string? tenNguoiDungDat;
        private int maNguoiDung;
        private string maPhongTro;
        private string ngayHen;
        private string gioHen;
        private string ghiChu;
        private string? ngayLap;
        private string? trangThai;

        public const string DONG_Y = "DY";
        public const string TU_CHOI = "TC";
        public const string DOI_PHAN_HOI = "DPH";
        public const string HUY = "H";

        // Contructor thêm lịch hẹn vào db
        public LichHen(int maNguoiDung, string maPhongTro, string ngayHen, string gioHen, string ghiChu)
        {
            this.maNguoiDung = maNguoiDung;
            this.maPhongTro = maPhongTro;
            this.ngayHen = ngayHen;
            this.gioHen = gioHen;
            this.ghiChu = ghiChu;
        }
        // Contructor select lịch hẹn đã đặt từ db
        public LichHen(int maNguoiDung, string maPhongTro, string ngayHen, string gioHen, string ghiChu, string ngayLap, string trangThai)
        {
            this.maNguoiDung = maNguoiDung;
            this.maPhongTro = maPhongTro;
            this.ngayHen = ngayHen;
            this.gioHen = gioHen;
            this.ghiChu = ghiChu;
            this.ngayLap = ngayLap;
            this.trangThai = trangThai;
        }
        // Contructor select lịch hẹn đã đặt từ db
        public LichHen(string tenNguoiDungDat, int maNguoiDung, string maPhongTro, string ngayHen, string gioHen, string ghiChu, string ngayLap, string trangThai)
        {
            this.tenNguoiDungDat = tenNguoiDungDat;
            this.maNguoiDung = maNguoiDung;
            this.maPhongTro = maPhongTro;
            this.ngayHen = ngayHen;
            this.gioHen = gioHen;
            this.ghiChu = ghiChu;
            this.ngayLap = ngayLap;
            this.trangThai = trangThai;
        }
        // Lấy trạng thái
        public string GetTrangThai()
        {
            switch (trangThai)
            {
                case DONG_Y:
                    return "Đồng ý";
                case TU_CHOI:
                    return "Từ chối";
                case HUY:
                    return "Đã hủy";
                default:
                    return "Đợi phản hồi";
            }
        }

        public int MaNguoiDung { get => maNguoiDung; set => maNguoiDung = value; }
        public string MaPhongTro { get => maPhongTro; set => maPhongTro = value; }
        public string NgayHen { get => ngayHen; set => ngayHen = value; }
        public string GioHen { get => gioHen; set => gioHen = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public string NgayLap { get => ngayLap; set => ngayLap = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public string TenNguoiDungDat { get => tenNguoiDungDat; set => tenNguoiDungDat = value; }
    }
}
