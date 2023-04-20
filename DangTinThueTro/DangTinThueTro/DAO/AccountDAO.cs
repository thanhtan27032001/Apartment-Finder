using DangTinThueTro.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DangTinThueTro.DAO
{
    public class AccountDAO
    {
        // Chung
        private static AccountDAO? instance = null;
        private int maNguoiDung = 0;
        private string sdt = "";
        private string hoTen = "";
        private string taiKhoan = "";
        private string loaiTK = "user";
        // Người dùng thường
        private string trangThai = "";
        // QTV
        private string ngaySinh = "";
        private string diaChi = "";
        // Loại tài khoản
        public const string TK_USER = "user";
        public const string TK_ADMIN = "admin";
        // Trạng thái tài khoản
        public const string TT_DADUYET = "daduyet";
        public const string TT_CHUADUYET = "chuaduyet";
        public const string TT_CHODUYET = "choduyet";

        public static AccountDAO Instance {
            get
            {
                if (instance == null)
                {
                    instance = new AccountDAO();
                }
                return instance;
            }
        }
        #region Quản lý tài khoản
        public bool DangNhap(string userName, string password)
        {
            string query = "EXECUTE SP_LOGIN @username , @password";
            try
            {
                DataTable dt = DataProvider.Instance.ExecuteQuerry(query, 
                    new object[] { userName, password });
                DataRow dr = dt.Rows[0];
                maNguoiDung = (int)dr["MaNguoiDung"];
                sdt = (string)dr["SDT"];
                hoTen = (string)dr["HoTen"];
                taiKhoan = userName;
                loaiTK = (string)dr["LOAITK"];
                if (loaiTK.Equals(TK_USER))
                {
                    trangThai = (string)dr["TrangThai"];
                }
                else if (loaiTK.Equals(TK_ADMIN))
                {
                    ngaySinh = MyFormat.FormatNgayDbSangNgayThat((DateTime)dr["NgaySinh"]);
                    diaChi = (string)dr["DiaChi"];
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool DangKy(string username, string password, string sdt)
        {
            string query = "EXECUTE SP_SIGNUP @username , @password , @sdt";
            try
            {
                DataProvider.Instance.ExecuteNonQuerry(query, new object[] { username, password, sdt });
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool DoiSDT(int maNguoiDung, string sdtMoi)
        {
            string query = "EXEC SP_CAPNHAT_SDT @MANGUOIDUNG , @SDT";
            try
            {
                DataProvider.Instance.ExecuteNonQuerry(query, new object[] { maNguoiDung, sdtMoi });
                sdt = sdtMoi;
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool DoiTen(int maNguoiDung, string tenMoi)
        {
            string query = "EXEC SP_CAPNHAT_HOTEN @MANGUOIDUNG , @TEN";
            try
            {
                DataProvider.Instance.ExecuteNonQuerry(query, new object[] { MaNguoiDung, tenMoi });
                hoTen = tenMoi;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DoiMatKhau(string taiKhoan, string matKhauCu, string matKhauMoi)
        {
            string query = "EXEC SP_CAPNHAT_MATKHAU @TAIKHOAN , @MATKHAUCU , @MATKHAUMOI";
            try
            {
                DataProvider.Instance.ExecuteNonQuerry(query, new object[] { taiKhoan, matKhauCu, matKhauMoi });
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool YeuCauDuyet(int maNguoiDung)
        {
            string query = "EXEC SP_YEUCAU_DUYET_TAIKHOAN @MANGUOIDUNG";
            try
            {
                DataProvider.Instance.ExecuteNonQuerry(query, new object[] { maNguoiDung });
                trangThai = TT_CHODUYET;
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
        #region Xác thực người dùng
        public List<DuyetNguoiDung> GetListNguoiDungDuyet()
        {
            string query = "EXEC SP_GET_NGUOIDUNG_DUYET";
            List<DuyetNguoiDung> list = null;
            int maNguoiDung;
            string hoTen;
            string soDT;
            try
            {
                DataTable dt = DataProvider.Instance.ExecuteQuerry(query);
                list = new List<DuyetNguoiDung>();
                foreach(DataRow dr in dt.Rows)
                {
                    maNguoiDung = (int)dr["MaNguoiDung"];
                    hoTen = (string)dr["HoTen"];
                    soDT = (string)dr["SDT"];
                    list.Add(new DuyetNguoiDung(maNguoiDung, hoTen, soDT));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: Có lỗi khi lấy danh sách người dùng chờ duyệt. " + ex.Message);
            }
            return list;
        }
        public bool XacThucNguoiDung(int maNguoiDung, int? maQTV)
        {
            if(maQTV != null)
            {
                string query = "EXEC SP_CAPNHAT_NGUOIDUNG_CHAPNHAN @MANGUOIDUNG , @MAQTV";
                try
                {
                    DataProvider.Instance.ExecuteNonQuerry(query, new object[] { maNguoiDung, maQTV });
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                string query = "EXEC SP_CAPNHAT_NGUOIDUNG_TUCHOI @MANGUOIDUNG";
                try
                {
                    DataProvider.Instance.ExecuteNonQuerry(query, new object[] { maNguoiDung });
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        #endregion
        public int MaNguoiDung { get => maNguoiDung;}
        public string Sdt { get => sdt; set => sdt = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string TaiKhoan { get => taiKhoan;}
        public string TrangThai { get => trangThai;}
        public string LoaiTK { get => loaiTK;}
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
    }
}
