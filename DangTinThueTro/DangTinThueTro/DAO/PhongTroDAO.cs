using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DangTinThueTro.DTO;
using DangTinThueTro.DAO;
using System.Data;

namespace DangTinThueTro.DAO
{
    public class PhongTroDAO
    {
        private static PhongTroDAO? instance = null;

        public static PhongTroDAO Instance { 
            get 
            { 
                if (instance == null)
                {
                    instance = new PhongTroDAO();
                }
                return instance;
            }
        }
        public List<PhongTro> GetListPhongTro(int maNhaTro)
        {
            List<PhongTro> list = new List<PhongTro>();
            string maPhongTro;
            double chieuDai;
            double chieuRong;
            int soPhongTrong;
            int giaPhong;
            string anhThamKhao;
            string trangThai;

            string query = "EXECUTE SP_GET_PHONGTRO @MANHATRO";
            DataTable dt = DataProvider.Instance.ExecuteQuerry(query, new object[] { maNhaTro });
            foreach (DataRow dr in dt.Rows)
            {
                maPhongTro = (string)dr["MaPhongTro"];
                chieuDai = (double)dr["ChieuDai"];
                chieuRong = (double)dr["ChieuRong"];
                soPhongTrong = (int)dr["SoPhongTrong"];
                giaPhong = (int)dr["GiaPhong"];
                anhThamKhao = (string)dr["HinhDaiDien"];
                trangThai = (string)dr["TrangThai"];

                list.Add(new PhongTro(maPhongTro, chieuDai, chieuRong, soPhongTrong, giaPhong, anhThamKhao, trangThai));
            }
            return list;
        }
        public PhongTro GetPhongTro(string maPhongTro)
        {
            string query = "EXECUTE SP_GET_1_PHONGTRO @MAPHONGTRO";
            try
            {
                DataTable dt = DataProvider.Instance.ExecuteQuerry(query, new object[] { maPhongTro });
                DataRow dr = dt.Rows[0];
               
                double chieuDai = (double)dr["ChieuDai"];
                double chieuRong = (double)dr["ChieuRong"];
                int soPhongTrong = (int)dr["SoPhongTrong"];
                int giaPhong = (int)dr["GiaPhong"];
                string anhThamKhao = (string)dr["HinhDaiDien"];
                int maNhaTro = (int)dr["MaNhaTro"];
                return new PhongTro(chieuDai, chieuRong, soPhongTrong, giaPhong, anhThamKhao, maNhaTro);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: Lấy thông tin trọ thất bại. " + ex.Message);
            }
            return null;
        }
        public bool ThemPhongTro(PhongTro phongTro, int maNhaTro)
        {
            string query = "EXECUTE SP_THEM_PHONGTRO @MAPHONGTRO , @CHIEUDAI , @CHIEURONG , @SOPHONGTRONG  , @GIAPHONG , @HINH , @MANHATRO";
            try
            {
                DataProvider.Instance.ExecuteNonQuerry(query, new object[] {
                    phongTro.MaPhongTro,
                    phongTro.ChieuDai,
                    phongTro.ChieuRong,
                    phongTro.SoPhongTrong,
                    phongTro.GiaPhong,
                    phongTro.AnhThamKhao,
                    maNhaTro
                });
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: Lỗi thêm phòng trọ. " + ex.Message);
                return false;
            }
        }

        public bool XoaPhongTro(string maPhongTro)
        {
            string query = "EXECUTE SP_XOA_PHONGTRO @MAPHONGTRO";
            try 
            {
                DataProvider.Instance.ExecuteNonQuerry(query, new object[] { maPhongTro });
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: Có lỗi khi xóa phòng trọ. " + ex.Message);
                return false;
            }
        }

        public bool CapNhatPhongTro(PhongTro phongTro)
        {
            string query = "EXECUTE SP_CAPNHAT_PHONGTRO @MAPHONGTRO , @GIAPHONG , @SOPHONGTRONG";
            try
            {
                DataProvider.Instance.ExecuteNonQuerry(query, new object[] {phongTro.MaPhongTro, phongTro.GiaPhong, phongTro.SoPhongTrong });
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: Cập nhật phòng trọ thất bại. " + ex.Message);
                return false;
            }
        }
        // Lấy mã người dùng của chủ phòng trọ
        public int GetMaChuPhongTro(string maPhongTro)
        {
            string query = "EXEC SP_GET_ID_CHUPHONGTRO @MAPHONGTRO";
            try
            {
                DataTable dt = DataProvider.Instance.ExecuteQuerry(query, new object[] { maPhongTro });
                return (int)dt.Rows[0]["MaNguoiDung"];
            }
            catch
            {
                return 0;
            }
        }
    }
}
