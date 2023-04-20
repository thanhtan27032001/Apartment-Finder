using DangTinThueTro.CustomComponent;
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

namespace DangTinThueTro
{
    public partial class FormMainUser : Form
    {
        private FormDangNhap formDangNhap;
        private bool dangXuat = false;
        // UI
        private PanelHome panelHome;
        private PanelYeuThich panelYeuThich;
        private PanelLichHen panelLichHen;
        private PanelQLTro panelQLTro;
        private PanelQLTin panelQLTin;
        private PanelQLLichHen panelQLLichHen;
        private PanelQLTaiKhoan panelQLTaiKhoan;

        private int disabledButton = -1;
        private const int HOME = 0;
        private const int YEU_THICH = 1;
        private const int LICH_HEN = 2;
        private const int QL_TRO = 3;
        private const int QL_TIN = 4;
        private const int QL_LICHHEN = 5;
        private const int QL_TAIKHOAN = 6;

        public FormMainUser(FormDangNhap formDangNhap)
        {
            InitializeComponent();
            this.formDangNhap = formDangNhap;
            Init();
            LoadUI(panelHome, HOME);

        }
        private void Init()
        {
            panelHome = new PanelHome();
            panelYeuThich = new PanelYeuThich();
            panelLichHen = new PanelLichHen();
            panelQLTaiKhoan = new PanelQLTaiKhoan(this);
            if (AccountDAO.Instance.TrangThai.Equals(AccountDAO.TT_DADUYET)) // Kiểm tra tài khoản đã được xác thực
            {
                panelQLTro = new PanelQLTro();
                panelQLTin = new PanelQLTin();
                panelQLLichHen = new PanelQLLichHen();
            }
            else
            {
                splitter1.Visible = false;
                btnQLTro.Visible = false;
                btnQLTin.Visible = false;
                btnQLLichHen.Visible = false;
            }
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
                case HOME:
                    btnHome.BackColor = enableColor;
                    break;
                case YEU_THICH:
                    btnYeuThich.BackColor = enableColor;
                    break;
                case LICH_HEN:
                    btnLichHen.BackColor = enableColor;
                    break;
                case QL_TRO:
                    btnQLTro.BackColor = enableColor;
                    break;
                case QL_TIN:
                    btnQLTin.BackColor = enableColor;
                    break;
                case QL_LICHHEN:
                    btnQLLichHen.BackColor = enableColor;
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
                case HOME:
                    btnHome.BackColor = disabledColor;
                    break;
                case YEU_THICH:
                    btnYeuThich.BackColor = disabledColor;
                    break;
                case LICH_HEN:
                    btnLichHen.BackColor = disabledColor;
                    break;
                case QL_TRO:
                    btnQLTro.BackColor = disabledColor;
                    break;
                case QL_TIN:
                    btnQLTin.BackColor = disabledColor;
                    break;
                case QL_LICHHEN:
                    btnQLLichHen.BackColor = disabledColor;
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
        private void btnHome_Click(object sender, EventArgs e)
        {
            LoadUI(panelHome, HOME);
        }
        private void btnYeuThich_Click(object sender, EventArgs e)
        {
            LoadUI(panelYeuThich, YEU_THICH);
        }
        private void btnLichHen_Click(object sender, EventArgs e)
        {
            LoadUI(panelLichHen, LICH_HEN);
        }
        private void btnQLTro_Click(object sender, EventArgs e)
        {
            LoadUI(panelQLTro, QL_TRO);
        }
        private void btnQLTin_Click(object sender, EventArgs e)
        {
            LoadUI(panelQLTin, QL_TIN);
        }
        private void btnQLLichHen_Click(object sender, EventArgs e)
        {
            LoadUI(panelQLLichHen, QL_LICHHEN);
        }
        private void btnQLTaiKhoan_Click(object sender, EventArgs e)
        {
            LoadUI(panelQLTaiKhoan, QL_TAIKHOAN);
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if(dangXuat)
            {
                formDangNhap.Visible = true;
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
