using DangTinThueTro.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangTinThueTro.DTO
{
    public class QuanHuyenThiXa
    {
        private string maQuanHuyenThiXa;
        private string tenQuanHuyenThiXa;
        private string maTinhThanhPho;

        public QuanHuyenThiXa(string maQuanHuyenThiXa, string tenQuanHuyenThiXa, string maTinhThanhPho)
        {
            this.maQuanHuyenThiXa = maQuanHuyenThiXa;
            this.tenQuanHuyenThiXa = tenQuanHuyenThiXa;
            this.maTinhThanhPho = maTinhThanhPho;
        }

        public string MaQuanHuyenThiXa { get => maQuanHuyenThiXa; }
        public string TenQuanHuyenThiXa { get => tenQuanHuyenThiXa; }
        public string MaTinhThanhPho { get => maTinhThanhPho; }

        public static string GetTenQuanHuyen(string maQuanHuyen)
        {
            foreach(QuanHuyenThiXa quanHuyen in DiaChiDAO.Instance.GetListQuanHuyenThiXa())
            {
                if (quanHuyen.maQuanHuyenThiXa.Equals(maQuanHuyen))
                {
                    return quanHuyen.tenQuanHuyenThiXa;
                }
            }
            return "";
        }
    }
}
