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
    public partial class PanelQLTaiKhoan : UserControl
    {
        private FormMainUser? formMainUser;
        private FormMainAdmin? formMainAdmin;
        public PanelQLTaiKhoan(FormMainUser formMainUser)
        {
            InitializeComponent();
            this.formMainUser = formMainUser;
            LoadUI();
        }
        public PanelQLTaiKhoan(FormMainAdmin formMainAdmin)
        {
            InitializeComponent();
            this.formMainAdmin = formMainAdmin;
            LoadUI();
        }
        private void LoadUI()
        {
            if (AccountDAO.Instance.LoaiTK.Equals(AccountDAO.TK_USER))
            {
                lbHoTen.Text = AccountDAO.Instance.HoTen;
                lbTaiKhoan.Text = AccountDAO.Instance.TaiKhoan;
                lbLoaiTK.Text = "Người dùng thường";
                btnDoiSDT.Text = "Số điện thoại: " + AccountDAO.Instance.Sdt;
                LoadUIButtonDuyet();
                // Ẩn các thông tin không cần thiết
                splitter5.Visible = false;
                btnNgaySinh.Visible = false;
                splitter6.Visible = false;
                btnDiaChi.Visible = false;
            }
            else if (AccountDAO.Instance.LoaiTK.Equals(AccountDAO.TK_ADMIN))
            {
                lbHoTen.Text = AccountDAO.Instance.HoTen;
                lbTaiKhoan.Text = AccountDAO.Instance.TaiKhoan;
                lbLoaiTK.Text = "Người dùng quản trị viên";
                btnDoiSDT.Text = "Số điện thoại: " + AccountDAO.Instance.Sdt;
                btnNgaySinh.Text = "Ngày sinh: " + AccountDAO.Instance.NgaySinh;
                btnDiaChi.Text = "Địa chỉ: " + AccountDAO.Instance.DiaChi;
                // Ẩn các thông tin không cần thiết
                splitter2.Visible = false;
                btnYeuCauDuyet.Visible = false;
                splitter3.Visible = false;
                btnDoiHoTen.Visible = false;
                splitter4.Visible = false;
                btnDoiMatKhau.Visible = false;
            }
        }
        private void LoadUIButtonDuyet()
        {
            if (AccountDAO.Instance.TrangThai.Equals(AccountDAO.TT_DADUYET))
            {
                btnYeuCauDuyet.Text = "Đã được xác thực";
                btnYeuCauDuyet.Image = Image.FromFile(MyFormat.GetFilePath("check_mark_green_24px.png"));
            }
            else if (AccountDAO.Instance.TrangThai.Equals(AccountDAO.TT_CHUADUYET))
            {
                btnYeuCauDuyet.Text = "Gửi yêu cầu xác thực tài khoản để mở chức năng đăng tin";
            }
            else
            {
                btnYeuCauDuyet.Text = "Đang chờ xác thực";
                btnYeuCauDuyet.Image = Image.FromFile(MyFormat.GetFilePath("time_left_orange_24px.png"));
            }
        }
        private void btnDoiSDT_Click(object sender, EventArgs e)
        {
            if (AccountDAO.Instance.LoaiTK.Equals(AccountDAO.TK_USER))
            {
                FormDoiSDT form = new FormDoiSDT();
                form.ShowDialog();
                if (form.IsUpdated)
                {
                    btnDoiSDT.Text = "Số điện thoại: " + AccountDAO.Instance.Sdt;
                }
            }
        }

        private void btnYeuCauDuyet_Click(object sender, EventArgs e)
        {
            if (AccountDAO.Instance.TrangThai.Equals(AccountDAO.TT_CHUADUYET)) // Trạng thái chưa duyệt mới được yêu cầu
            {
                if (AccountDAO.Instance.HoTen.Equals(AccountDAO.Instance.TaiKhoan)) // Kiểm tra họ tên đã cung cấp hay chưa
                {
                    MessageBox.Show("Bạn phải cung cấp họ tên trước khi yêu cầu xác thực");
                }
                else
                {
                    DialogResult result = MessageBox.Show(
                        "Bạn có thực sự muốn xác thực tài khoản này?\nQuản trị viên sẽ liên hệ bạn trực tiếp để kiểm tra thông tin bạn cung cấp.",
                        "Yêu cầu xác thực tài khoản",
                        MessageBoxButtons.YesNoCancel);
                    if(result == DialogResult.Yes)
                    {
                        if (AccountDAO.Instance.YeuCauDuyet(AccountDAO.Instance.MaNguoiDung))
                        {
                            MessageBox.Show("Yêu cầu xác thực tài khoản thành công");
                            LoadUIButtonDuyet();
                        }
                        else
                        {
                            MessageBox.Show("Yêu cầu xác thực tài khoản thất bại");
                        }
                    }
                }
            }
        }

        private void btnDoiHoTen_Click(object sender, EventArgs e)
        {
            FormDoiTen form = new FormDoiTen();
            form.ShowDialog();
            if (form.IsUpdated)
            {
                lbHoTen.Text = AccountDAO.Instance.HoTen;
            }
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            FormDoiMatKhau form = new FormDoiMatKhau();
            form.ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (AccountDAO.Instance.LoaiTK.Equals(AccountDAO.TK_USER))
            {
                formMainUser.DangXuat();
            }
            else if (AccountDAO.Instance.LoaiTK.Equals(AccountDAO.TK_ADMIN))
            {
                formMainAdmin.DangXuat();
            }
        }
    }
}
