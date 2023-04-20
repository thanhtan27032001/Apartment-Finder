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
    public partial class ItemXacThucNguoiDung : UserControl
    {
        private DuyetNguoiDung nguoiDung;
        public ItemXacThucNguoiDung(DuyetNguoiDung nguoiDung)
        {
            InitializeComponent();
            this.nguoiDung = nguoiDung;
            LoadUI();
        }
        private void LoadUI()
        {
            lbId.Text = "#Id: " + nguoiDung.MaNguoiDung;
            lbHoTen.Text = "Họ tên: " + nguoiDung.HoTen;
            lbSoDT.Text = "Số điện thoại: " + nguoiDung.SoDT;
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if(AccountDAO.Instance.XacThucNguoiDung(nguoiDung.MaNguoiDung, AccountDAO.Instance.MaNguoiDung))
            {
                MessageBox.Show("Xác thực người dùng thành công");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Xác thực người dùng thất bại");
            }
        }

        private void btnTuChoi_Click(object sender, EventArgs e)
        {
            if (AccountDAO.Instance.XacThucNguoiDung(nguoiDung.MaNguoiDung, null))
            {
                MessageBox.Show("Xác thực người dùng thành công");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Xác thực người dùng thất bại");
            }
        }
    }
}
