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
    public partial class FormThemNhaTro : Form
    {
        private bool isAdded = false;

        public bool IsAdded { get => isAdded;}

        public FormThemNhaTro()
        {
            InitializeComponent();
            LoadUI();
        }
        private void LoadUI()
        {
            SetDataComboboxTinhThanh();
        }
        private void SetDataComboboxTinhThanh()
        {
            cboxTinhThanh.DataSource = DiaChiDAO.Instance.GetListTinhThanhPho();
            cboxTinhThanh.DisplayMember = "tenTinhThanh";
            cboxTinhThanh.ValueMember = null;
        }
        private void SetDataComboboxQuanHuyen(string filterTinhThanh)
        {
            List<QuanHuyenThiXa> listQuanHuyen = new List<QuanHuyenThiXa>();
            foreach (QuanHuyenThiXa quanHuyen in DiaChiDAO.Instance.GetListQuanHuyenThiXa())
            {
                if (quanHuyen.MaTinhThanhPho.Equals(filterTinhThanh))
                {
                    listQuanHuyen.Add(quanHuyen);
                }
            }

            cboxQuanHuyen.DataSource = listQuanHuyen;
            cboxQuanHuyen.DisplayMember = "tenQuanHuyenThiXa";
            cboxQuanHuyen.ValueMember = null;
        }
        private void SetDataComboboxXaPhuong(string filerQuanHuyen)
        {
            List<XaPhuongThiTran> listXaPhuong = new List<XaPhuongThiTran>();
            foreach (XaPhuongThiTran xaPhuong in DiaChiDAO.Instance.GetListXaPhuongThiTran())
            {
                if (xaPhuong.MaQuanHuyenThiXa.Equals(filerQuanHuyen))
                {
                    listXaPhuong.Add(xaPhuong);
                }
            }

            cboxXaPhuong.DataSource = listXaPhuong;
            cboxXaPhuong.DisplayMember = "tenXaPhuongThiTran";
            cboxXaPhuong.ValueMember = null;
        }
        private bool InputHopLe()
        {
            if (txtGiaDien.Text.Equals(""))
            {
                MessageBox.Show("Giá điện không được trống");
                return false;
            }
            if (txtGiaNuoc.Text.Equals(""))
            {
                MessageBox.Show("Giá nước không được trống");
                return false;
            }
            if (txtDiaChi.Text.Equals(""))
            {
                MessageBox.Show("Địa chỉ không được trống");
                return false;
            }
            return true;
        }
        private void cboxTinhThanhPho_SelectedValueChanged(object sender, EventArgs e)
        {
            TinhThanhPho? tinhThanh = cboxTinhThanh.SelectedValue as TinhThanhPho;
            SetDataComboboxQuanHuyen(tinhThanh.MaTinhThanh);
        }
        private void cboxQuanHuyen_SelectedValueChanged(object sender, EventArgs e)
        {
            QuanHuyenThiXa? quanHuyen = cboxQuanHuyen.SelectedValue as QuanHuyenThiXa;
            SetDataComboboxXaPhuong(quanHuyen.MaQuanHuyenThiXa);
        }
        private void cboxXaPhuong_SelectedValueChanged(object sender, EventArgs e)
        {

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
        private void btnThemTro_Click(object sender, EventArgs e)
        {
            if (InputHopLe())
            {
                int giaDien = Convert.ToInt32(txtGiaDien.Text);
                int giaNuoc = Convert.ToInt32(txtGiaNuoc.Text);
                string maXaPhuong = (cboxXaPhuong.SelectedValue as XaPhuongThiTran).MaXaPhuongThiTran;
                string soNha = txtDiaChi.Text;
                NhaTro nhaTro = new NhaTro(giaDien, giaNuoc, soNha, maXaPhuong);
                if (NhaTroDAO.Instance.ThemNhaTro(nhaTro, AccountDAO.Instance.MaNguoiDung))
                {
                    MessageBox.Show("Thêm nhà trọ thành công");
                    isAdded = true;
                    this.Dispose();
                }
                else
                    MessageBox.Show("Thêm nhà trọ thất bại");
            }
        }
    }
}
