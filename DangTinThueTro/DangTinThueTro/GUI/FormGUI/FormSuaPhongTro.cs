using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DangTinThueTro.DTO;
using DangTinThueTro.DAO;

namespace DangTinThueTro.GUI.FormGUI
{
    public partial class FormSuaPhongTro : Form
    {
        private PhongTro phongTro;
        private bool isUpdated = false;
        public FormSuaPhongTro(PhongTro phongTro)
        {
            InitializeComponent();
            this.phongTro = phongTro;
            LoadUI();
        }
        private void LoadUI()
        {
            txtChieuDai.Text = phongTro.ChieuDai.ToString();
            txtChieuRong.Text = phongTro.ChieuRong.ToString();
            txtGiaPhong.Text = phongTro.GiaPhong.ToString();
            numericUpDownSoPhongTrong.Value = phongTro.SoPhongTrong;
        }
        private bool KiemTraTatCaInput()
        {
            return
                (txtChieuDai.Text.Length > 0) &&
                (txtChieuRong.Text.Length > 0) &&
                (txtGiaPhong.Text.Length > 0);
        }

        private void ChinhSuaTro()
        {
            int giaPhongTemp = phongTro.GiaPhong;
            int soPhongTrongTemp = phongTro.SoPhongTrong;
            // Thay đổi thông tin đối tượng trọ
            phongTro.GiaPhong = Convert.ToInt32(txtGiaPhong.Text);
            phongTro.SoPhongTrong = (int)numericUpDownSoPhongTrong.Value;
            // Cập nhật trong Database
            if (PhongTroDAO.Instance.CapNhatPhongTro(phongTro))
            {
                isUpdated = true;
                MessageBox.Show("Chỉnh sửa phòng trọ thành công");
            }
            else
            {
                // Roll back
                phongTro.GiaPhong = giaPhongTemp;
                phongTro.SoPhongTrong = soPhongTrongTemp;
            }
        }

        public bool IsUpdated()
        {
            return isUpdated;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (KiemTraTatCaInput())
            {
                ChinhSuaTro();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Bạn cần điền đầy đủ thông tin");
            }
        }
        private void txtGiaPhong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
