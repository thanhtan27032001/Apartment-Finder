using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DangTinThueTro.DTO;

namespace DangTinThueTro.DAO
{
    public class GoiQuangCaoDAO
    {
        private static GoiQuangCaoDAO instance = null;
        private static List<GoiQuangCao>? listGoiQuangCao = null;

        public static GoiQuangCaoDAO Instance
        { 
            get
            {
                if(instance == null)
                {
                    instance = new GoiQuangCaoDAO();
                }
                return instance;
            }
        }

        public List<GoiQuangCao> GetDataGoiQuangCao()
        {
            if(listGoiQuangCao == null)
            {
                listGoiQuangCao = new List<GoiQuangCao>();
                string query = "EXECUTE SP_GET_GOIQUANGCAO";
                DataTable dt = DataProvider.Instance.ExecuteQuerry(query);
                foreach(DataRow dr in dt.Rows)
                {
                    listGoiQuangCao.Add(new GoiQuangCao((string)dr["MaGoiQC"], (int)dr["SoNgay"], (int)dr["Gia"]));
                }
            }
            return listGoiQuangCao;
        }
    }
}
