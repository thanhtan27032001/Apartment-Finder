using DangTinThueTro.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangTinThueTro.DAO
{
    public class QuangCaoDAO
    {
        private static QuangCaoDAO instance;

        public static QuangCaoDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new QuangCaoDAO();
                }
                return instance;
            }
        }
        public void ThemQuangCao(QuangCao quangCao)
        {
            string query = "EXECUTE SP_THEM_QUANGCAO @MATIN , @MAGOIQC , @SONGAY";
            try
            {
                DataProvider.Instance.ExecuteNonQuerry(query, 
                    new object[] { quangCao.MaTin, quangCao.MaGoiQC, quangCao.SoNgayHieuLuc });
                MessageBox.Show("Quảng cáo cho tin thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public QuangCao GetQuangCao(string maTin)
        {
            string query = "EXECUTE SP_GET_QUANGCAO @MATIN";
            try
            {
                DataTable tb = DataProvider.Instance.ExecuteQuerry(query, new object[] { maTin });
                DataRow dr = tb.Rows[0];
                return new QuangCao((string)dr["MaTin"], (string)dr["MaGoiQC"],
                    MyFormat.FormatNgayDbSangNgayThat((DateTime)dr["NgayHieuLuc"]),
                    MyFormat.FormatNgayDbSangNgayThat((DateTime)dr["NgayKetThuc"]));
            }
            catch
            {
                return null;
            }
        }
    }
}
