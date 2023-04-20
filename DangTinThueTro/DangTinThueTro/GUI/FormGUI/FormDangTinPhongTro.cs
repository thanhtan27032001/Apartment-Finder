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
    public partial class FormDangTinPhongTro : Form
    {
        private PhongTro phongTro;
        //private List<GoiQuangCao>? listGoiQuangCao = null;
        private bool isUpdated = false;
        public FormDangTinPhongTro(PhongTro phongTro)
        {
            InitializeComponent();
            //LoadCombobox();
            this.phongTro = phongTro;
        }
        //private void LoadCombobox()
        //{
        //    listGoiQuangCao = GoiQuangCaoDAO.Instance.GetDataGoiQuangCao();
        //    coboxGoiQuangCao.DataSource = listGoiQuangCao;
        //    coboxGoiQuangCao.DisplayMember = "maGoiQuangCao";
        //    coboxGoiQuangCao.ValueMember = null;
        //}
        private bool KiemTraTatCaInput()
        {
            return txtTieuDe.Text.Length > 0 && txtMoTa.Text.Length > 0;
        }
        private bool DangTin()
        {
            string maTin = phongTro.MaPhongTro;
            string ngayDang = MyFormat.FormatNgayThatSangDb(DateTime.Now);
            string tieuDe = txtTieuDe.Text;
            string moTa = txtMoTa.Text;
            TinDangQL tinDang = new TinDangQL(maTin, ngayDang, tieuDe, moTa);
            return TinDangDAO.Instance.ThemTinDang(tinDang);
        }
        //private void QuangCao()
        //{
        //    if (ckboxChonQuangCao.Checked)
        //    {
        //        string maTin = phongTro.MaPhongTro;
        //        string maGoiQc = (coboxGoiQuangCao.SelectedValue as GoiQuangCao).MaGoiQuangCao;
        //        int soNgayHieuLuc = (coboxGoiQuangCao.SelectedValue as GoiQuangCao).SoNgay;
        //        QuangCaoDAO.Instance.ThemQuangCao(new QuangCao(maTin, maGoiQc, soNgayHieuLuc));
        //    }
        //}
        private void btnDangBai_Click(object sender, EventArgs e)
        {
            if (KiemTraTatCaInput())
            {
                DialogResult dialogResult = MessageBox.Show(
                    "Bạn có thực sự muốn đăng tin với tiêu đề và mô tả như trên?\nQuản trị viên sẽ kiểm duyệt trước khi thực sự đăng lên bản tin chung", 
                    "Đăng tin phòng trọ", 
                    MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (DangTin())
                    {
                        //QuangCao();
                        phongTro.TrangThai = PhongTro.DANG_CHO_DUYET;
                        isUpdated = true;
                        MessageBox.Show("Đăng tin trọ thành công");
                        this.Dispose();
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn cần điền đủ tất cả thông tin");
            }
        }

        //private void coboxGoiQuangCao_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    GoiQuangCao goi = coboxGoiQuangCao.SelectedValue as GoiQuangCao;
        //    lbThongTinGoiQC.Text = "Giá gói: " + MyFormat.FormatMoney(goi.Gia) + " VNĐ - Thời gian: " + goi.SoNgay + " ngày";
        //}

        //private void ckboxChonQuangCao_CheckedChanged(object sender, EventArgs e)
        //{
        //    coboxGoiQuangCao.Enabled = ckboxChonQuangCao.Checked;
        //    lbThongTinGoiQC.Visible = ckboxChonQuangCao.Checked;
        //}
        public bool IsUpdated()
        {
            return isUpdated;
        }
    }
}
