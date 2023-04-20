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
    public partial class FormMainAdmin : Form
    {
        private FormDangNhap formDangNhap;
        private bool dangXuat = false;

        private PanelXacThucNguoiDung panelXacThucNguoiDung;
        private PanelDuyetTinDang panelDuyetTinDang;
        private PanelQLTaiKhoan panelQLTaiKhoan;

        private int disabledButton = -1;
        private const int XACTHUC_NGUOIDUNG = 0;
        private const int DUYET_TINDANG = 1;
        private const int QL_TAIKHOAN = 2;
        public FormMainAdmin(FormDangNhap formDangNhap)
        {
            InitializeComponent();
            this.formDangNhap = formDangNhap;
            Init();
        }
        private void Init()
        {
            panelXacThucNguoiDung = new PanelXacThucNguoiDung(); 
            panelDuyetTinDang = new PanelDuyetTinDang();
            panelQLTaiKhoan = new PanelQLTaiKhoan(this);
        }
        private void LoadUI(UserControl panel, int name)
        {
            if (!panelContainer.Contains(panel))
            {
                panelContainer.Controls.Clear();
                panelContainer.Controls.Add(panel);
                EnableButton();
                DisableButton(name);
            }
        }
        private void EnableButton()
        {
            Color enableColor = Color.FromArgb(0, 109, 119);
            switch (disabledButton)
            {
                case XACTHUC_NGUOIDUNG:
                    btnXacThucNguoiDung.BackColor = enableColor;
                    break;
                case DUYET_TINDANG:
                    btnDuyetTinDang.BackColor = enableColor;
                    break;
                case QL_TAIKHOAN:
                    btnQLTaiKhoan.BackColor = enableColor;
                    break;
            }
        }
        private void DisableButton(int btnName)
        {
            disabledButton = btnName;
            Color disabledColor = Color.FromArgb(20, 33, 61);
            switch (btnName)
            {
                case XACTHUC_NGUOIDUNG:
                    btnXacThucNguoiDung.BackColor = disabledColor;
                    break;
                case DUYET_TINDANG:
                    btnDuyetTinDang.BackColor = disabledColor;
                    break;
                case QL_TAIKHOAN:
                    btnQLTaiKhoan.BackColor = disabledColor;
                    break;
            }
        }
        public void DangXuat()
        {
            dangXuat = true;
            this.Close();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (dangXuat)
            {
                formDangNhap.Visible = true;
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private void btnXacThucNguoiDung_Click(object sender, EventArgs e)
        {
            LoadUI(panelXacThucNguoiDung, XACTHUC_NGUOIDUNG);
        }

        private void btnDuyetTinDang_Click(object sender, EventArgs e)
        {
            LoadUI(panelDuyetTinDang, DUYET_TINDANG);
        }

        private void btnQLTaiKhoan_Click(object sender, EventArgs e)
        {
            LoadUI(panelQLTaiKhoan, QL_TAIKHOAN);
        }
    }
}
