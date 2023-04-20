using DangTinThueTro.DAO;
using DangTinThueTro.DTO;
using DangTinThueTro.GUI.FormGUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangTinThueTro.GUI.CustomComponent
{
    public partial class ItemTinDangQL : UserControl
    {
        private TinDangQL tinDang;
        private PhongTro phongTro;
        private NhaTro nhaTro;
        private QuangCao quangCao;
        public ItemTinDangQL(TinDangQL tinDang, PhongTro phongTro, NhaTro nhaTro, QuangCao quangCao)
        {
            InitializeComponent();
            this.tinDang = tinDang;
            this.phongTro = phongTro;
            this.nhaTro = nhaTro;
            this.quangCao = quangCao;
            LoadUI();
        }
        private void LoadUI()
        {
            lbTieuDe.Text = tinDang.TieuDe;
            lbIdTro.Text = "ID phòng trọ: " + tinDang.MaTin;
            lbGiaPhong.Text = "Giá phòng: " + MyFormat.FormatMoney(phongTro.GiaPhong) + " VNĐ/tháng";
            lbDienTich.Text = "Diện tích: " + (phongTro.ChieuDai * phongTro.ChieuRong) + " m2";
            lbGiaDien.Text = "Tiền điện 1kw: " + MyFormat.FormatMoney(nhaTro.GiaDien) + " VNĐ";
            lbGiaNuoc.Text = "Tiền nước 1 khối: " + MyFormat.FormatMoney(nhaTro.GiaNuoc) + " VNĐ";
            lbDiaChi.Text = "Địa chỉ: " + XaPhuongThiTran.GetDiaChi(nhaTro.MaXaPhuong);
            lbThongTinQC.Text = "Gói QC: " + ((quangCao != null) ? quangCao.MaGoiQC + " - HSD: " + quangCao.NgayKetThuc : "Không");
            lbTrangThai.Text = "Trạng thái: " + (tinDang.DaDuyet ? "Đã duyệt" : "Đang chờ duyệt");
            LoadAnHien();
            try
            {
                picDemo.Image = Image.FromFile(MyFormat.GetFilePath(phongTro.AnhThamKhao));
            }
            catch(Exception ex)
            {
                MessageBox.Show("Không tìm thấy file \"" + phongTro.AnhThamKhao + "\"");
            }
        }
        private void LoadAnHien()
        {
            lbAnHien.Text = "Ẩn/Hiện trên bảng tin: ";
            if (!tinDang.DaAn)
            {
                lbAnHien.Text += "Hiển thị";
                btnAnHienTin.Text = "Ẩn tin";
            }
            else
            {
                lbAnHien.Text += "Đã ẩn";
                btnAnHienTin.Text = "Hiển thị tin";
            }
        }
        private void AnHienTinDang()
        {
            if(TinDangDAO.Instance.AnHienTinDang(tinDang.MaTin, tinDang.DaAn))
            {
                LoadAnHien();
            }
        }

        private void buttonDetail_Click(object sender, EventArgs e)
        {
            new FormSuaTin(tinDang, quangCao).ShowDialog();
        }

        private void btnAnHienTin_Click(object sender, EventArgs e)
        {
            tinDang.DaAn = !tinDang.DaAn;
            AnHienTinDang();
        }
    }
}
