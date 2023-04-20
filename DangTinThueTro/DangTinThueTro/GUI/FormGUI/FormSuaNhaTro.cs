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

namespace DangTinThueTro.GUI.FormGUI
{
    public partial class FormSuaNhaTro : Form
    {
        private NhaTro nhaTro;

        private int giaDienTemp;
        private int giaNuocTemp;
        private bool isUpdated = false;
        public FormSuaNhaTro(NhaTro nhaTro)
        {
            InitializeComponent();
            this.nhaTro = nhaTro;
            LoadData();
        }
        private void LoadData()
        {
            txtGiaDien.Text = nhaTro.GiaDien.ToString();
            txtGiaNuoc.Text = nhaTro.GiaNuoc.ToString();
            txtDiaChi.Text = nhaTro.SoNha + ", " + XaPhuongThiTran.GetDiaChi(nhaTro.MaXaPhuong);
        }
        private bool SuaNhaTro()
        {
            giaDienTemp = nhaTro.GiaDien;
            giaNuocTemp = nhaTro.GiaNuoc;
            nhaTro.GiaDien = int.Parse(txtGiaDien.Text);
            nhaTro.GiaNuoc = int.Parse(txtGiaNuoc.Text);
            isUpdated = NhaTroDAO.Instance.SuaNhaTro(nhaTro);
            if (isUpdated)
            {
                MessageBox.Show("Chỉnh sửa thông tin nhà trọ thành công");
            }
            else
            {
                MessageBox.Show("Chỉnh sửa thông tin nhà trọ thất bại");
                Rollback();
            }
            return isUpdated;
        }
        private void Rollback()
        {
            nhaTro.GiaDien = giaDienTemp;
            nhaTro.GiaNuoc = giaNuocTemp;
        }

        public bool IsUpdated()
        {
            return isUpdated;
        }

        private void txtGiaDien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGiaNuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (SuaNhaTro())
            {
                this.Close();
            }
        }
    }
}
