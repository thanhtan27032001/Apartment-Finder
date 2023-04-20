using DangTinThueTro.DAO;
using DangTinThueTro.GUI.FormGUI;

namespace DangTinThueTro
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }
        private bool InputHopLe()
        {
            if (txtTaiKhoan.Text.Equals(""))
            {
                MessageBox.Show("Tài khoản không được trống");
                return false;
            }
            if (txtMatKhau.Text.Equals(""))
            {
                MessageBox.Show("Mật khẩu không được trống");
                return false;
            }
            return true;
        }
        private void label3_Click(object sender, EventArgs e)
        {
            FormDangKy form = new FormDangKy();
            form.ShowDialog();
            if (form.IsAdded)
            {
                txtTaiKhoan.Text = form.TaiKhoan;
                txtMatKhau.Text = form.MatKhau;
            }
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (InputHopLe())
            {
                string userName = txtTaiKhoan.Text;
                string password = txtMatKhau.Text;
                if (AccountDAO.Instance.DangNhap(userName, password))
                {
                    MessageBox.Show("Đăng nhập thành công");
                    this.Hide();
                    if (AccountDAO.Instance.LoaiTK.Equals(AccountDAO.TK_USER))
                    {
                        new FormMainUser(this).ShowDialog();
                    }
                    else if (AccountDAO.Instance.LoaiTK.Equals(AccountDAO.TK_ADMIN))
                    {
                        new FormMainAdmin(this).ShowDialog();
                    }
                }
            }
        }

        private void txtTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}