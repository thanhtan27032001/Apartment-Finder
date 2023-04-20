using DangTinThueTro.DAO;
using DangTinThueTro.GUI.CustomComponent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangTinThueTro.GUI.FormGUI
{
    public partial class FormDoiMatKhau : Form
    {
        public FormDoiMatKhau()
        {
            InitializeComponent();
            txtTaiKhoan.Text = AccountDAO.Instance.TaiKhoan;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (InputHopLe())
            {
                if (AccountDAO.Instance.DoiMatKhau(txtTaiKhoan.Text, txtMkCu.Text, txtMkMoi.Text))
                {
                    MessageBox.Show("Cập nhật mật khẩu thành công");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Cập nhật mật khẩu thất bại");
                }
            }
        }
        private bool InputHopLe()
        {
            if (!txtXacNhanMkMoi.Text.Equals(txtMkMoi.Text))
            {
                MessageBox.Show("Nhập lại mật khẩu không khớp");
                return false;
            }
            if (txtMkCu.Text.Trim().Equals("") &&
                txtMkMoi.Text.Trim().Equals("") &&
                txtXacNhanMkMoi.Text.Trim().Equals(""))
            {
                MessageBox.Show("Các input không được trống");
                return false;
            }
            return true;
        }

        private void txtMkCu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
