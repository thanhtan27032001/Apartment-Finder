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

namespace DangTinThueTro.GUI.FormGUI
{
    public partial class FormDoiSDT : Form
    {
        private bool isUpdated = false;
        public FormDoiSDT()
        {
            InitializeComponent();
        }
        public bool IsUpdated { get => isUpdated;}

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sdtMoi = txtSdtMoi.Text;
            if (InputHopLe())
            {
                if (AccountDAO.Instance.DoiSDT(AccountDAO.Instance.MaNguoiDung, sdtMoi))
                {
                    MessageBox.Show("Cập nhật số điện thoại thành công");
                    isUpdated = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật số điện thoại thất bại");
                }
            }
        }
        private bool InputHopLe()
        {
            if(txtSdtMoi.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải có đúng 10 ký số");
                return false;
            }
            return true;
        }
        private void txtSdtMoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
