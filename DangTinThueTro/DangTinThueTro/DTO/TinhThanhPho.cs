using DangTinThueTro.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangTinThueTro.DTO
{
    public class TinhThanhPho
    {
        private string maTinhThanh;
        private string tenTinhThanh;

        public TinhThanhPho() { }
        public TinhThanhPho(string maTinhThanh, string tenTinhThanh)
        {
            this.maTinhThanh = maTinhThanh;
            this.tenTinhThanh = tenTinhThanh;
        }

        public string MaTinhThanh { get => maTinhThanh; }
        public string TenTinhThanh { get => tenTinhThanh; }
        public static string GetTenTinhThanh(string maTinhThanh)
        {
            foreach (TinhThanhPho tinhThanh in DiaChiDAO.Instance.GetListTinhThanhPho())
            {
                if (tinhThanh.maTinhThanh.Equals(maTinhThanh))
                {
                    return tinhThanh.tenTinhThanh;
                }
            }
            return "";
        }
    }
}
