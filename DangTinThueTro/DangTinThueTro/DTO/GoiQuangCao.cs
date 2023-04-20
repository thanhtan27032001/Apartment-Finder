using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangTinThueTro.DTO
{
    public class GoiQuangCao
    {
        private string maGoiQuangCao;
        private int soNgay;
        private int gia;

        public GoiQuangCao(string maGoiQuangCao, int soNgay, int gia)
        {
            this.maGoiQuangCao = maGoiQuangCao;
            this.soNgay = soNgay;
            this.gia = gia;
        }

        public string MaGoiQuangCao { get => maGoiQuangCao; }
        public int SoNgay { get => soNgay; }
        public int Gia { get => gia; }
    }
}
