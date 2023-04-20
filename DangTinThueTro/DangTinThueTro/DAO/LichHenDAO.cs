using DangTinThueTro.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangTinThueTro.DAO
{
    public class LichHenDAO
    {
        private static LichHenDAO? instance;
        public static LichHenDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LichHenDAO();
                }
                return instance;
            }
        }
        // Đặt lịch hẹn
        public bool DatLichHen(LichHen lichHen)
        {
            string query = "EXEC SP_THEM_DATLICHHEN @MANGUOIDUNG , @MAPHONGTRO , @NGAYHEN , @GIOHEN , @GHICHU";
            try
            {
                DataProvider.Instance.ExecuteNonQuerry(query,
                    new object[] { lichHen.MaNguoiDung, lichHen.MaPhongTro, lichHen.NgayHen, lichHen.GioHen, lichHen.GhiChu });
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: Có lỗi khi đặt lịch hẹn. " + ex.Message);
                return false;
            }
        }
        // Lấy danh sách lịch hẹn đã đặt
        public List<LichHen>? GetListLichHenDaDat(int maNguoiDung)
        {
            List<LichHen>? listLichHen = null;
            string query = "EXEC SP_GET_LICHHEN_DADAT @MANGUOIDUNG";
            try
            {
                string maPhongTro;
                string ngayHen;
                string gioHen;
                string ghiChu;
                string ngayLap;
                string trangThai;
                DataTable dt = DataProvider.Instance.ExecuteQuerry(query, new object[] { maNguoiDung });
                listLichHen = new List<LichHen>();
                foreach (DataRow dr in dt.Rows)
                {
                    maPhongTro = (string)dr["MaPhongTro"];
                    ngayHen = MyFormat.FormatNgayDbSangNgayThat((DateTime)dr["NgayHen"]);
                    gioHen = ((TimeSpan)dr["GioHen"]).ToString();
                    ghiChu = (string)dr["GhiChu"];
                    ngayLap = MyFormat.FormatNgayDbSangNgayThat((DateTime)dr["NgayLap"]);
                    trangThai = (string)dr["TrangThai"];
                    listLichHen.Add(new LichHen(maNguoiDung, maPhongTro, ngayHen, gioHen, ghiChu, ngayLap, trangThai));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: Có lỗi khi lấy danh sách lịch hẹn đã đặt. " + ex.Message);
            }
            return listLichHen;
        }
        // Đổi trạng thái lịch hẹn
        public bool DoiTranThaiLichHen(LichHen lichHen, string trangThaiMoi)
        {
            string query = "EXEC SP_HUY_LICHHEN @MANGUOIDUNG , @MAPHONGTRO , @NGAYHEN , @TRANGTHAI";
            try
            {
                string ngayHen = MyFormat.FormatNgayThatSangDb(DateOnly.Parse(lichHen.NgayHen, new CultureInfo("de-DE")));
                DataProvider.Instance.ExecuteNonQuerry(query,
                    new object[] {lichHen.MaNguoiDung, lichHen.MaPhongTro, ngayHen, trangThaiMoi});
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: Hủy hẹn thất bại. " + ex.Message);
                return false;
            }
        }
        // Lấy danh sách lịch hẹn đã nhận
        public List<LichHen> GetListLichHenDaNhan(int maNguoiDung)
        {
            List<LichHen>? listLichHen = null;
            string query = "EXEC SP_GET_LICHHEN_DANHAN @MANGUOIDUNG";
            try
            {
                string tenNguoiDungDat;
                int maNguoiDungDat;
                string maPhongTro;
                string ngayHen;
                string gioHen;
                string ghiChu;
                string ngayLap;
                string trangThai;
                DataTable dt = DataProvider.Instance.ExecuteQuerry(query, new object[] { maNguoiDung });
                listLichHen = new List<LichHen>();
                foreach (DataRow dr in dt.Rows)
                {
                    tenNguoiDungDat = (string)dr["HoTen"];
                    maNguoiDungDat = (int)dr["MaNguoiDung"];
                    maPhongTro = (string)dr["MaPhongTro"];
                    ngayHen = MyFormat.FormatNgayDbSangNgayThat((DateTime)dr["NgayHen"]);
                    gioHen = ((TimeSpan)dr["GioHen"]).ToString();
                    ghiChu = (string)dr["GhiChu"];
                    ngayLap = MyFormat.FormatNgayDbSangNgayThat((DateTime)dr["NgayLap"]);
                    trangThai = (string)dr["TrangThai"];
                    listLichHen.Add(new LichHen(tenNguoiDungDat, maNguoiDungDat, maPhongTro, ngayHen, gioHen, ghiChu, ngayLap, trangThai));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: Có lỗi khi lấy danh sách lịch hẹn đã nhận. " + ex.Message);
            }
            return listLichHen;
        }
    }
}
