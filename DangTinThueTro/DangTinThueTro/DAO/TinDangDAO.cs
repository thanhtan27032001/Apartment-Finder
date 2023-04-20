using DangTinThueTro.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangTinThueTro.DAO
{
    public class TinDangDAO
    {
        private static TinDangDAO instance;

        public static TinDangDAO Instance 
        {
            get
            {
                if (instance == null)
                {
                    instance = new TinDangDAO();
                }
                return instance;
            }
        }
        #region Quản lý tin
        // Lấy danh sách tin đăng của người dùng
        public List<TinDangQL> GetListTinDangQL(int maNguoiDung)
        {
            List<TinDangQL> listTinDang = new List<TinDangQL>();
            string query = "EXECUTE SP_GET_TINDANG @MANGUOIDUNG";
            try
            {
                string maTin;
                string ngayDang;
                string tieuDe;
                string moTa;
                bool daDuyet;
                bool daAn;
                DataTable dt = DataProvider.Instance.ExecuteQuerry(query, new object[] {maNguoiDung});
                foreach(DataRow dr in dt.Rows)
                {
                    maTin = (string)dr["MaTinDang"];
                    ngayDang = MyFormat.FormatNgayDbSangNgayThat((DateTime)dr["NgayDang"]);
                    tieuDe = (string)dr["TieuDe"];
                    moTa = (string)dr["MoTa"];
                    daDuyet = (dr["MaQTVDuyet"] != DBNull.Value) ? true : false;
                    daAn = (bool)dr["DaAn"];
                    listTinDang.Add(new TinDangQL(maTin, ngayDang, tieuDe, moTa, daDuyet, daAn));
                }
                return listTinDang;
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: Lỗi lấy tin đăng. " + ex.Message);
            }
            return listTinDang;
        }
        // Thêm tin trọ
        public bool ThemTinDang(TinDangQL tin)
        {
            string query = "EXECUTE SP_THEM_TINDANG @MATIN , @NGAYDANG , @TIEUDE , @MOTA";
            try
            {
                DataProvider.Instance.ExecuteNonQuerry(query, new object[] { tin.MaTin, tin.NgayDang, tin.TieuDe, tin.MoTa });
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: Thêm tin đăng thất bại. " + ex.Message);
                return false;
            }
        }
        // Cập nhật tin
        public bool CapNhatTinDang(TinDangQL tin)
        {
            string query = "EXECUTE SP_CAPNHAT_TINDANG @MATIN , @TIEUDE , @MOTA";
            try
            {
                DataProvider.Instance.ExecuteNonQuerry(query, new object[] { tin.MaTin, tin.TieuDe, tin.MoTa });
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR: Chỉnh sửa trọ thất bại. " + e.Message);
                return false;
            }
        }
        // Ẩn hiện tin đăng
        public bool AnHienTinDang(string maTin, bool daAn)
        {
            string query = "EXEC SP_CAPNHAT_ANHIEN_TINDANG @MATIN , @DAAN";
            try
            {
                DataProvider.Instance.ExecuteNonQuerry(query, new object[] { maTin, daAn });
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show("ERROR: Có lỗi khi ẩn/hiện tin. " + e.Message);
                return false;
            }
        }
        #endregion
        #region Tìm trọ
        // Cho hiển thị tin -> tìm trọ
        public List<TinDang> GetListTinDangTimTro(int maNguoiDung)
        {
            List<TinDang> listTinDang = new List<TinDang>();
            string query = "EXECUTE SP_GET_ALL_TINDANG @MANGUOIDUNG";
            try
            {
                string maTin;
                string ngayDang;
                string tieuDe;
                string moTa;
                double chieuDai;
                double chieuRong;
                int soPhongTrong;
                int giaDien;
                int giaNuoc;
                int giaPhong;
                string anhThamKhao;
                string soNha;
                string maXaPhuong;
                bool daThich;
                DataTable dt = DataProvider.Instance.ExecuteQuerry(query, new object[] {maNguoiDung});
                foreach (DataRow dr in dt.Rows)
                {
                    maTin = (string)dr["MaTinDang"];
                    ngayDang = MyFormat.FormatNgayDbSangNgayThat((DateTime)dr["NgayDang"]);
                    tieuDe = (string)dr["TieuDe"];
                    moTa = (string)dr["MoTa"];
                    chieuDai = (double)dr["ChieuDai"];
                    chieuRong = (double)dr["ChieuRong"];
                    soPhongTrong = (int)dr["SoPhongTrong"];
                    giaDien = (int)dr["GiaDien"];
                    giaNuoc = (int)dr["GiaNuoc"];
                    giaPhong = (int)dr["GiaPhong"];
                    anhThamKhao = (string)dr["HinhDaiDien"];
                    soNha = (string)dr["SoNha"];
                    maXaPhuong = (string)dr["MaX_P_TT"];
                    daThich = ((string)dr["DaThich"]).ToLower().Equals("true") ? true : false;
                    listTinDang.Add(new TinDang(maTin, ngayDang, tieuDe, moTa, chieuDai, chieuRong, soPhongTrong, giaDien, giaNuoc, giaPhong, anhThamKhao, soNha, maXaPhuong, daThich));
                }
                return listTinDang;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: Lỗi lấy tin đăng. " + ex.Message);
            }
            return listTinDang;
        }
        public TinDang? Get1TinDang(string maTin)
        {
            string query = "EXEC SP_GET_1_TINDANG @MATIN";
            try
            {
                DataTable dt = DataProvider.Instance.ExecuteQuerry(query, new object[] { maTin });
                DataRow dr = dt.Rows[0];
                maTin = (string)dr["MaTinDang"];
                string ngayDang = MyFormat.FormatNgayDbSangNgayThat((DateTime)dr["NgayDang"]);
                string tieuDe = (string)dr["TieuDe"];
                string moTa = (string)dr["MoTa"];
                double chieuDai = (double)dr["ChieuDai"];
                double chieuRong = (double)dr["ChieuRong"];
                int soPhongTrong = (int)dr["SoPhongTrong"];
                int giaDien = (int)dr["GiaDien"];
                int giaNuoc = (int)dr["GiaNuoc"];
                int giaPhong = (int)dr["GiaPhong"];
                string anhThamKhao = (string)dr["HinhDaiDien"];
                string soNha = (string)dr["SoNha"];
                string maXaPhuong = (string)dr["MaX_P_TT"];
                bool daThich = false;
                return new TinDang(maTin, ngayDang, tieuDe, moTa, chieuDai, chieuRong, soPhongTrong, giaDien, giaNuoc, giaPhong, anhThamKhao, soNha, maXaPhuong, daThich);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
                return null;
            }
        }
        #endregion
        #region Duyệt tin
        public List<DuyetTinDang> GetListTinDangDuyet()
        {
            string query = "EXEC SP_GET_TINDANG_DUYET";
            List<DuyetTinDang> list = null;
            string maTin;
            string hoTenNguoiDang;
            string tieuDe;
            string moTa;
            try
            {
                DataTable dt = DataProvider.Instance.ExecuteQuerry(query);
                list = new List<DuyetTinDang>();
                foreach (DataRow dr in dt.Rows)
                {
                    maTin = (string)dr["MaTinDang"];
                    hoTenNguoiDang = (string)dr["HoTen"];
                    tieuDe = (string)dr["TieuDe"];
                    moTa = (string)dr["MoTa"];
                    list.Add(new DuyetTinDang(maTin, hoTenNguoiDang, tieuDe, moTa));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: Có lỗi khi lấy danh sách tin đăng. " + ex.Message);
            }
            return list;
        }
        public bool DuyetTin(string maTin, int? maQTV)
        {
            string query;
            if(maQTV != null)
            {
                query = "EXEC SP_CAPNHAT_TINDANG_CHAPNHAN @MATINDANG , @MAQTV";
                try
                {
                    DataProvider.Instance.ExecuteNonQuerry(query, new object[] { maTin, maQTV });
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                query = "EXEC SP_CAPNHAT_TINDANG_TUCHOI @MATINDANG";
                try
                {
                    DataProvider.Instance.ExecuteNonQuerry(query, new object[] {maTin});
                    return true;
                }
                catch(Exception e)
                {
                    MessageBox.Show("ERROR: Có lỗi khi cập nhật tin đăng. " + e.Message);
                    return false;
                }
            }
        }
        #endregion
    }
}
