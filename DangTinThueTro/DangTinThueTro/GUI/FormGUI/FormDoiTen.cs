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
    public partial class FormDoiTen : Form
    {
        private bool isUpdated;
        public FormDoiTen()
        {
            InitializeComponent();
        }

        public bool IsUpdated { get => isUpdated;}

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (InputHopLe())
            {
                if(AccountDAO.Instance.DoiTen(AccountDAO.Instance.MaNguoiDung, txtTenMoi.Text))
                {
                    isUpdated = true;
                    MessageBox.Show("Cập nhật tên thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật tên thất bại");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền tên mới");
            }
        }
        private bool InputHopLe()
        {
            return !txtTenMoi.Text.Trim().Equals("");
        }
    }
}
