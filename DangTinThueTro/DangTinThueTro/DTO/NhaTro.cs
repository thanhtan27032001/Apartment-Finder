using DangTinThueTro.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangTinThueTro.DTO
{
    public class NhaTro
    {
        private int maNhaTro;
        private int giaDien;
        private int giaNuoc;
        private string soNha;
        private string maXaPhuong;
        private List<PhongTro>? phongTroList;

        // Contructor select từ db
        public NhaTro(int maNhaTro, int giaDien, int giaNuoc, string soNha, string maXaPhuong)
        {
            this.maNhaTro = maNhaTro;
            this.giaDien = giaDien;
            this.giaNuoc = giaNuoc;
            this.soNha = soNha;
            this.maXaPhuong = maXaPhuong;
            LoadListPhongTro();
        }
        // Constructor thêm nhà trọ
        public NhaTro(int giaDien, int giaNuoc, string soNha, string maXaPhuong)
        {
            this.giaDien = giaDien;
            this.giaNuoc = giaNuoc;
            this.soNha = soNha;
            this.maXaPhuong = maXaPhuong;
        }
        public void LoadListPhongTro()
        {
            this.phongTroList = PhongTroDAO.Instance.GetListPhongTro(maNhaTro);
        }
        public int MaNhaTro { get => maNhaTro; }
        public int GiaDien { get => giaDien; set => giaDien = value; }
        public int GiaNuoc { get => giaNuoc; set => giaNuoc = value; }
        public string SoNha { get => soNha; set => soNha = value; }
        public string MaXaPhuong { get => maXaPhuong; set => maXaPhuong = value; }
        public List<PhongTro> PhongTroList { get => phongTroList; set => phongTroList = value; }
    }
}
