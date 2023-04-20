using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DangTinThueTro.DTO;

namespace DangTinThueTro.DAO
{
    public class DiaChiDAO
    {
        private static DiaChiDAO? instance = null;
        private static List<TinhThanhPho>? listTinhThanhPho = null;
        private static List<QuanHuyenThiXa>? listQuanHuyenThiXa = null;
        private static List<XaPhuongThiTran>? listXaPhuongThiTran = null;
        
        // Lấy intance
        public static DiaChiDAO Instance {
            get
            { 
                if(instance == null)
                {
                    instance = new DiaChiDAO();
                }
                return instance;
            }
        }

        #region Lấy danh sách địa chỉ
        public List<TinhThanhPho> GetListTinhThanhPho()
        {
            if (listTinhThanhPho == null)
            {
                listTinhThanhPho= new List<TinhThanhPho>();
                DataTable dt = GetDataTinhThanhPho();
                foreach (DataRow dr in dt.Rows)
                {
                    listTinhThanhPho.Add(new TinhThanhPho((string) dr["MaT_TP"],(string) dr["TenT_TP"]));
                }
            }
            return listTinhThanhPho;
        }
        public List<QuanHuyenThiXa> GetListQuanHuyenThiXa()
        {
            if (listQuanHuyenThiXa == null)
            {
                listQuanHuyenThiXa = new List<QuanHuyenThiXa>();
                DataTable dt = GetDataQuanHuyenThiXa();
                foreach(DataRow dr in dt.Rows)
                {
                    listQuanHuyenThiXa.Add(new QuanHuyenThiXa((string) dr["MaQ_H_TX"], (string)dr["TenQ_H_TX"], (string)dr["MaT_TP"]));
                }
            }
            return listQuanHuyenThiXa;
        }
        public List<XaPhuongThiTran> GetListXaPhuongThiTran()
        {
            if (listXaPhuongThiTran == null)
            {
                listXaPhuongThiTran = new List<XaPhuongThiTran>();
                DataTable dt = GetDataXaPhuongThiTran();
                foreach(DataRow dr in dt.Rows)
                {
                    listXaPhuongThiTran.Add(new XaPhuongThiTran((string)dr["MaX_P_TT"], (string)dr["TenX_P_TT"], (string)dr["MaQ_H_TX"]));
                }
            }
            return listXaPhuongThiTran;
        }
        #endregion

        #region Lấy địa chỉ từ Database
        private DataTable GetDataTinhThanhPho()
        {
            string query = "EXECUTE SP_GET_TINH_THANHPHO";
            return DataProvider.Instance.ExecuteQuerry(query);
        }
        private DataTable GetDataQuanHuyenThiXa()
        {
            string query = "EXECUTE SP_GET_QUAN_HUYEN_THIXA";
            return DataProvider.Instance.ExecuteQuerry(query);
        }
        private DataTable GetDataXaPhuongThiTran()
        {
            string query = "EXECUTE SP_GET_XA_PHUONG_TRITRAN";
            return DataProvider.Instance.ExecuteQuerry(query);
        }
        #endregion
    }
}
