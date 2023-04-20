using DangTinThueTro.DAO;
using DangTinThueTro.DTO;
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
    public partial class ItemDuyetTinDang : UserControl
    {
        private DuyetTinDang tinDang;
        public ItemDuyetTinDang(DuyetTinDang tinDang)
        {
            InitializeComponent();
            this.tinDang = tinDang;
            LoadUI();
        }
        private void LoadUI()
        {
            lbTieuDe.Text = "Tiêu đề: " + tinDang.TieuDe;
            lbNguoiDang.Text = "Người đăng: " + tinDang.HoTenNguoiDang;
            lbMoTa.Text = tinDang.MoTa;
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (TinDangDAO.Instance.DuyetTin(tinDang.MaTin, AccountDAO.Instance.MaNguoiDung))
            {
                MessageBox.Show("Duyệt tin đăng thành công");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Duyệt tin đăng thất bại");
            }
        }

        private void btnTuChoi_Click(object sender, EventArgs e)
        {
            if (TinDangDAO.Instance.DuyetTin(tinDang.MaTin, null))
            {
                MessageBox.Show("Duyệt tin đăng thành công");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Duyệt tin đăng thất bại");
            }
        }
    }
}
