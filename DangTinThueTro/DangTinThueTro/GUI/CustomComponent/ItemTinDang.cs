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
    public partial class ItemTinDang : UserControl
    {
        private TinDang tinDang;
        private Image imgDaThich = Properties.Resources.star_gold_24px;
        private Image imgChuaThich = Properties.Resources.star_gold_border_24px;
        public ItemTinDang(TinDang tinDang)
        {
            InitializeComponent();
            this.tinDang = tinDang;
            LoadUI();
        }
        private void LoadUI()
        {
            string space = "    ";
            lbTieuDe.Text = tinDang.TieuDe;
            lbGiaPhong.Text = space + "Tiền phòng 1 tháng: " + MyFormat.FormatMoney(tinDang.GiaPhong) + " VNĐ";
            lbDienTich.Text = space + "Diện tích: " + (tinDang.ChieuDai * tinDang.ChieuRong) + " m2";
            lbGiaDien.Text = space + "Tiền điện 1kW: " + MyFormat.FormatMoney(tinDang.GiaDien) + " VNĐ";
            lbGiaNuoc.Text = space + "Tiền nước 1 khối: " + MyFormat.FormatMoney(tinDang.GiaNuoc) + " VNĐ";
            lbNgayDang.Text = space + "Ngày đăng: " + tinDang.NgayDang;
            lbDiaChi.Text = "Địa chỉ: " + tinDang.SoNha + ", " + XaPhuongThiTran.GetDiaChi(tinDang.MaXaPhuong);
            LoadYeuThichImg();
            try
            {
                picDemo.Image = Image.FromFile(MyFormat.GetFilePath(tinDang.AnhThamKhao));
            }
            catch
            {
                picDemo.Image = picDemo.ErrorImage;
            }
        }
        private void LoadYeuThichImg()
        {
            picYeuThich.Image = (tinDang.DaThich) ? imgDaThich : imgChuaThich;
        }
        private void picYeuThich_Click(object sender, EventArgs e)
        {
            tinDang.DaThich = !tinDang.DaThich;
            LoadYeuThichImg();
            if (tinDang.DaThich)
            {
                YeuThichDAO.Instance.ThemYeuThich(AccountDAO.Instance.MaNguoiDung, tinDang.MaTin);
            }
            else
            {
                YeuThichDAO.Instance.XoaYeuThich(AccountDAO.Instance.MaNguoiDung, tinDang.MaTin);
            }
        }

        private void lbChiTiet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new FormChiTietTin(tinDang, HinhThamKhaoDAO.Instance.GetListHinhThamKhao(tinDang.MaTin)).Show();
        }
    }
}
