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
    public partial class ItemLichHenDat : UserControl
    {
        private LichHen lichHen;
        public ItemLichHenDat(LichHen lichHen)
        {
            InitializeComponent();
            this.lichHen = lichHen;
            LoadUI();
        }
        private void LoadUI()
        {
            string space = "    ";
            lbMaPhongTro.Text = "Lịch hẹn phòng trọ #Id: " + lichHen.MaPhongTro;
            lbNgayGioHen.Text = space + "Ngày giờ hẹn: " + lichHen.NgayHen + " - " + lichHen.GioHen;
            lbGhiChu.Text = space + "Ghi chú: " + lichHen.GhiChu;
            lbTrạngThai.Text = space + "Trạng thái: " + lichHen.GetTrangThai();
            btnHuy.Enabled = !lichHen.TrangThai.Equals(LichHen.HUY) ? true : false; 
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
