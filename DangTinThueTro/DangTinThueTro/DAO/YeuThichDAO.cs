using DangTinThueTro.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangTinThueTro.DAO
{
    public class YeuThichDAO
    {
        private static YeuThichDAO? instance;

        public static YeuThichDAO Instance 
        {
            get
            {
                if (instance == null)
                {
                    instance = new YeuThichDAO();
                }
                return instance;
            }
        }
        public bool ThemYeuThich(int maNguoiDung, string maTin)
        {
            string query = "EXECUTE SP_THEM_YEUTHICH @MANGUOIDUNG , @MATIN";
            try
            {
                DataProvider.Instance.ExecuteNonQuerry(query, new object[] {maNguoiDung, maTin });
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: Có lỗi khi thêm tin vào mục yêu thích. " + ex.Message);
                return false;
            }
        }
        public bool XoaYeuThich(int maNguoiDung, string maTin)
        {
            string query = "EXECUTE SP_XOA_YEUTHICH @MANGUOIDUNG , @MATIN";
            try
            {
                DataProvider.Instance.ExecuteNonQuerry(query, new object[] {maNguoiDung, maTin});
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: Có lỗi khi xóa tin khỏi mục yêu thích. " + ex.Message);
                return false;
            }
        }
        public List<TinDang> GetTinYeuThich(int maNguoiDung)
        {
            List<TinDang> listYeuThich = new List<TinDang>();
            string query = "EXECUTE SP_GET_TIN_YEUTHICH @MANGUOIDUNG";
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
                DataTable dt =  DataProvider.Instance.ExecuteQuerry(query, new object[] { maNguoiDung });
                foreach(DataRow dr in dt.Rows)
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
                    listYeuThich.Add(new TinDang(maTin, ngayDang, tieuDe, moTa, chieuDai, chieuRong, soPhongTrong, giaDien, giaNuoc, giaPhong, anhThamKhao, soNha, maXaPhuong, daThich));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: Có lỗi khi lấy tin yêu thích. " + ex.Message);
            }
            return listYeuThich;
        }
    }
}
