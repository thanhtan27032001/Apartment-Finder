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
    public partial class ItemPhongTro : UserControl
    {
        private PhongTro phongTro;
        public ItemPhongTro(PhongTro phongTro)
        {
            InitializeComponent();
            this.phongTro = phongTro;
            LoadUI();
        }
        private void LoadUI()
        {
            // Các label thông tin
            lbTieuDe.Text = "#Id: " + phongTro.MaPhongTro;
            lbTienPhong.Text = "Tiền phòng 1 tháng: " + MyFormat.FormatMoney(phongTro.GiaPhong) + " VNĐ";
            lbChieuDai.Text = "Chiều dài: " + phongTro.ChieuDai + "m";
            lbChieuRong.Text = "Chiều rộng: " + phongTro.ChieuRong + "m";
            lbConTrong.Text = "Số phòng trống: " + phongTro.SoPhongTrong;
            // Trạng thái
            if (phongTro.TrangThai.Equals(PhongTro.DA_DANG_TIN))
            {
                lbTrangThai.Text = "Trạng thái: Đã đăng tin";
                btnDangTin.Enabled = false;
            }
            else if (phongTro.TrangThai.Equals(PhongTro.CHUA_DANG_TIN))
            {
                lbTrangThai.Text = "Trạng thái: Chưa đăng tin";
            }
            else
            {
                lbTrangThai.Text = "Trạng thái: Đang chờ duyệt tin";
                btnDangTin.Enabled = false;
            }
            // Hình tham khảo
            try
            {
                picDemo.Image = Image.FromFile(MyFormat.GetFilePath(phongTro.AnhThamKhao));
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: Có lỗi khi load hình. " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có thực sự muốn ẩn phòng trọ này?", "Xóa phòng trọ", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (PhongTroDAO.Instance.XoaPhongTro(phongTro.MaPhongTro))
                {
                    MessageBox.Show("Ẩn phòng trọ thành công");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Ẩn nhà trọ thất bại");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            FormSuaPhongTro form = new FormSuaPhongTro(phongTro);
            form.ShowDialog();
            if (form.IsUpdated())
            {
                LoadUI();
            }
        }

        private void btnDangTin_Click(object sender, EventArgs e)
        {
            FormDangTinPhongTro form = new FormDangTinPhongTro(phongTro);
            form.ShowDialog();
            if (form.IsUpdated())
            {
                LoadUI();
            }
        }

        private void linkLabelXemAnh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new FormXemAnh(phongTro).ShowDialog();
        }
    }
}
