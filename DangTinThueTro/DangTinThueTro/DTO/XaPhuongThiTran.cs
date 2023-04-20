using DangTinThueTro.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangTinThueTro.DTO
{
    public class XaPhuongThiTran
    {
        private string maXaPhuongThiTran;
        private string tenXaPhuongThiTran;
        private string maQuanHuyenThiXa;
        public XaPhuongThiTran() { }

        public XaPhuongThiTran(string maXaPhuongThiTran, string tenXaPhuongThiTran, string maQuanHuyenThiXa)
        {
            this.maXaPhuongThiTran = maXaPhuongThiTran;
            this.tenXaPhuongThiTran = tenXaPhuongThiTran;
            this.maQuanHuyenThiXa = maQuanHuyenThiXa;
        }

        public string MaXaPhuongThiTran { get => maXaPhuongThiTran; }
        public string TenXaPhuongThiTran { get => tenXaPhuongThiTran; }
        public string MaQuanHuyenThiXa { get => maQuanHuyenThiXa; }
        public static string GetTenXaPhuong(string maXaPhuong)
        {
            foreach (XaPhuongThiTran xaPhuong in DiaChiDAO.Instance.GetListXaPhuongThiTran())
            {
                if (xaPhuong.maXaPhuongThiTran.Equals(maXaPhuong))
                {
                    return xaPhuong.tenXaPhuongThiTran;
                }
            }
            return "";
        }
        public static string GetDiaChi(string maXaPhuong)
        {
            string maQuanHuyen = maXaPhuong.Substring(0, 4);
            string maTinhThanh = maXaPhuong.Substring(0, 2);
            return GetTenXaPhuong(maXaPhuong) + ", " + QuanHuyenThiXa.GetTenQuanHuyen(maQuanHuyen) + ", " + TinhThanhPho.GetTenTinhThanh(maTinhThanh);
        }
    }
}
