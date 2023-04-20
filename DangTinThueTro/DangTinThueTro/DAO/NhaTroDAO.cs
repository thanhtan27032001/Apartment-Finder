using DangTinThueTro.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangTinThueTro.DAO
{
    public class NhaTroDAO
    {
        private static NhaTroDAO instance;
        public static NhaTroDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NhaTroDAO();
                }
                return instance;
            }
        }
        public List<NhaTro> GetListNhaTro(int maNguoiDung)
        {
            List<NhaTro> list = new List<NhaTro>();
            string query = "EXECUTE SP_GET_NHATRO @MANGUOIDUNG";
            try
            {
                int maNhaTro;
                int giaDien;
                int giaNuoc;
                string soNha;
                string maXaPhuong;
                NhaTro nhaTro;
                DataTable dt = DataProvider.Instance.ExecuteQuerry(query, new object[] { maNguoiDung });
                foreach(DataRow dr in dt.Rows)
                {
                    maNhaTro = (int)dr["MaNhaTro"];
                    giaDien = (int)dr["GiaDien"];
                    giaNuoc = (int)dr["GiaNuoc"];
                    soNha = (string)dr["SoNha"];
                    maXaPhuong = (string)dr["MaX_P_TT"];
                    nhaTro = new NhaTro(maNhaTro, giaDien, giaNuoc, soNha, maXaPhuong);
                    list.Add(nhaTro);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: Có lỗi khi lấy danh sách nhà trọ. " + ex.Message);
            }
            return list;
        }
        public NhaTro GetNhaTro(int maNhaTro)
        {
            string query = "EXECUTE SP_GET_1_NHATRO @MANHATRO";
            try
            {
                DataTable dt = DataProvider.Instance.ExecuteQuerry(query, new object[] { maNhaTro });
                int giaDien = (int)dt.Rows[0]["GiaDien"];
                int giaNuoc = (int)dt.Rows[0]["GiaNuoc"];
                string soNha = (string)dt.Rows[0]["SoNha"]; ;
                string maXaPhuong = (string)dt.Rows[0]["MaX_P_TT"]; ;
                NhaTro nhaTro = new NhaTro(giaDien, giaNuoc, soNha, maXaPhuong);
                return nhaTro;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: Có lỗi khi lấy thông tin nhà trọ. " + ex.Message);
                return null;
            }
        }
        public bool ThemNhaTro(NhaTro nhaTro, int maNguoiDung)
        {
            string query = "EXECUTE SP_THEM_NHATRO @GIADIEN , @GIANUOC , @SONHA , @MAX_P_TT , @MANGUOIDUNG";
            try
            {
                DataProvider.Instance.ExecuteNonQuerry(query,
                new object[] { nhaTro.GiaDien, nhaTro.GiaNuoc, nhaTro.SoNha, nhaTro.MaXaPhuong, maNguoiDung });
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR: Có lỗi khi thêm nhà trọ. " + e.Message);
                return false;
            }
        }
        public bool SuaNhaTro(NhaTro nhaTro)
        {
            string query = "EXECUTE SP_SUA_NHATRO @MANHATRO , @GIADIEN , @GIANUOC";
            try
            {
                DataProvider.Instance.ExecuteNonQuerry(query, 
                    new object[] { nhaTro.MaNhaTro, nhaTro.GiaDien, nhaTro.GiaNuoc });
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show("ERROR: " + e.Message);
                return false;
            }
        }
        public bool XoaNhaTro(int maNhaTro)
        {
            string query = "EXEC SP_XOA_NHATRO @MANHATRO";
            try
            {
                DataProvider.Instance.ExecuteNonQuerry(query, new object[] { maNhaTro });
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
                return false;
            }
        }
    }
}
