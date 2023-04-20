using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangTinThueTro.DAO
{
    public class HinhThamKhaoDAO
    {
        private static HinhThamKhaoDAO? instance = null;

        public static HinhThamKhaoDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new HinhThamKhaoDAO();
                return instance;
            }
        }
        public void ThemHinhThamKhao(List<string> listHinhThamKhao, string maPhongTro)
        {
            string query = "EXECUTE SP_THEM_HINHTHAMKHAO @HINH , @MAPHONGTRO";
            foreach(string hinhThamKhao in listHinhThamKhao)
            {
                try
                {
                    DataProvider.Instance.ExecuteNonQuerry(query, new object[] { hinhThamKhao, maPhongTro });
                }
                catch(Exception ex)
                {
                    MessageBox.Show("ERROR: Thêm hình \"" + hinhThamKhao + "\" thất bại. " + ex.Message);
                }
            }
        }
        public List<string> GetListHinhThamKhao(string maPhongTro)
        {
            List<string> listHinhThamKhao = new List<string>();
            string query = "EXECUTE SP_GET_HINHTHAMKHAO @MAPHONGTRO";
            try
            {
                DataTable dt = DataProvider.Instance.ExecuteQuerry(query, new object[] { maPhongTro });
                foreach(DataRow dr in dt.Rows)
                {
                    listHinhThamKhao.Add((string)dr["Hinh"]);
                }
                return listHinhThamKhao;
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: Lấy hình thất bại. " + ex.Message);
            }
            return listHinhThamKhao;
        }
    }
}
