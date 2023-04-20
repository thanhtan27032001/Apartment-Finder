using DangTinThueTro.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangTinThueTro
{
    public partial class FormDangKy : Form
    {
        private bool isAdded = false;
        private string taiKhoan = "";
        private string matKhau = "";

        public bool IsAdded { get => isAdded; }
        public string TaiKhoan { get => taiKhoan; }
        public string MatKhau { get => matKhau; }

        public FormDangKy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            xoaTatCaCanhBao();
            if (InputHopLe())
            {
                SignUp();
            }
        }

        // Đăng ký tài khoản
        private void SignUp()
        {
            taiKhoan = txtTaiKhoan.Text;
            matKhau = txtMatKhau.Text;
            string sdt = txtSoDienThoai.Text;
            if(AccountDAO.Instance.DangKy(taiKhoan, matKhau, sdt))
            {
                MessageBox.Show("Đăng ký tài khoản thành công");
                isAdded = true;
                this.Dispose();
            }
            else
                MessageBox.Show("Đăng ký tài khoản thất bại");
        }

        // Kiểm tra input hợp lệ
        private bool InputHopLe()
        {
            if(txtTaiKhoan.Text.Length == 0)
            {
                picWarnTaiKhoan.Visible = true;
                return false;
            }

            if(txtMatKhau.Text.Length == 0)
            {
                picWarnMatKhau.Visible = true;
                return false;
            }
            
            if(!txtXacNhanMatKhau.Text.Equals(txtMatKhau.Text))
            {
                picWarnMatKhau2.Visible = true;
                return false;
            }

            if(txtSoDienThoai.Text.Length != 10)
            {
                picWarnSDT.Visible = true;
                return false;
            }

            return true;
        }

        // Xóa tất cả cảnh báo input
        private void xoaTatCaCanhBao()
        {
            picWarnTaiKhoan.Visible = false;
            picWarnMatKhau.Visible = false;
            picWarnMatKhau2.Visible = false;
            picWarnSDT.Visible = false;
        }
        // Kiểm tra chỉ cho nhập số
        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void lbQuayLai_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
