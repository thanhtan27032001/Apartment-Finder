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
    public partial class ItemLichHenNhan : UserControl
    {
        private LichHen lichHen;
        public ItemLichHenNhan(LichHen lichHen)
        {
            InitializeComponent();
            this.lichHen = lichHen;
            LoadUI();
        }
        private void LoadUI()
        {
            lbMaPhongTro.Text = "Lịch hẹn phòng trọ #Id: " + lichHen.MaPhongTro;
            lbNguoiHen.Text = "Người hẹn: " + lichHen.TenNguoiDungDat;
            lbNgayGioHen.Text = "Ngày giờ hẹn: " + lichHen.NgayHen + " - " + lichHen.GioHen;
            lbGhiChu.Text = "Ghi chú: " + lichHen.GhiChu;
            lbTrạngThai.Text = "Trạng thái: " + lichHen.GetTrangThai();
            SetTrangThaiButton();
        }
        private void SetTrangThaiButton()
        {
            switch (lichHen.TrangThai)
            {
                case LichHen.DOI_PHAN_HOI:
                    btnDongY.Enabled = true;
                    btnTuChoi.Enabled = true;
                    btnHuy.Enabled = false;
                    break;
                case LichHen.HUY:
                    btnDongY.Enabled = false;
                    btnTuChoi.Enabled = false;
                    btnHuy.Enabled = false;
                    break;
                default:
                    btnDongY.Enabled = false;
                    btnTuChoi.Enabled = false;
                    btnHuy.Enabled = true;
                    break;
            }
            
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Bạn có thực sự muốn đồng ý lịch hẹn này?",
                "Đồng ý hẹn",
                MessageBoxButtons.YesNoCancel);
            if (dialogResult == DialogResult.Yes)
            {
                if (LichHenDAO.Instance.DoiTranThaiLichHen(lichHen, LichHen.DONG_Y))
                {
                    MessageBox.Show("Đồng ý hẹn thành công");
                    lichHen.TrangThai = LichHen.DONG_Y;
                    this.LoadUI();
                }
            }
        }

        private void btnTuChoi_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Bạn có thực sự muốn từ chối lịch hẹn này?\nSau khi từ chối sẽ không thể hoàn tác!",
                "Từ chối hẹn",
                MessageBoxButtons.YesNoCancel);
            if (dialogResult == DialogResult.Yes)
            {
                if (LichHenDAO.Instance.DoiTranThaiLichHen(lichHen, LichHen.TU_CHOI))
                {
                    MessageBox.Show("Từ chối hẹn thành công");
                    lichHen.TrangThai = LichHen.TU_CHOI;
                    this.LoadUI();
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Bạn có thực sự muốn hủy lịch hẹn này?\nSau khi hủy sẽ không thể hoàn tác!",
                "Hủy hẹn",
                MessageBoxButtons.YesNoCancel);
            if (dialogResult == DialogResult.Yes)
            {
                if (LichHenDAO.Instance.DoiTranThaiLichHen(lichHen, LichHen.HUY))
                {
                    MessageBox.Show("Hủy hẹn thành công");
                    lichHen.TrangThai = LichHen.HUY;
                    this.LoadUI();
                }
            }
        }

        private void btnXemPhongTro_Click(object sender, EventArgs e)
        {
            new FormChiTietTin(lichHen.MaPhongTro).Show();
        }
    }
}
