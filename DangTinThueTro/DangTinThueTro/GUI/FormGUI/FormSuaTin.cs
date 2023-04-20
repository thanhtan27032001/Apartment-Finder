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
    public partial class FormSuaTin : Form
    {
        private TinDangQL? tinDang = null;
        private QuangCao? quangCao = null;
        private List<GoiQuangCao>? listGoiQuangCao = null;
        public FormSuaTin(TinDangQL tinDang, QuangCao quangCao)
        {
            InitializeComponent();
            this.tinDang = tinDang;
            this.quangCao = quangCao;
            //LoadDataCombobox();
            LoadUI();
        }
        public void LoadDataCombobox()
        {
            listGoiQuangCao = GoiQuangCaoDAO.Instance.GetDataGoiQuangCao();
            coboxGoiQuangCao.DataSource = listGoiQuangCao;
            coboxGoiQuangCao.DisplayMember = "maGoiQuangCao";
            coboxGoiQuangCao.ValueMember = null;
        }
        private void LoadUI()
        {
            txtTieuDe.Text = tinDang.TieuDe;
            txtMoTa.Text = tinDang.MoTa;
            lbThongTinGoiQCKhaDung.Text = (quangCao != null) ? quangCao.MaGoiQC + " - HSD: " + quangCao.NgayKetThuc : "Không"; 
            if(quangCao != null || !tinDang.DaDuyet)
            {
                ckboxChonQuangCao.Enabled = false;
            }
            else
            {
                ckboxChonQuangCao.Enabled = true;
                LoadDataCombobox();
            }
        }
        private void ChinhSuaTin()
        {
            string tieuDe = tinDang.TieuDe;
            string moTa = tinDang.MoTa;
            tinDang.TieuDe = txtTieuDe.Text;
            tinDang.MoTa = txtMoTa.Text;
            if (TinDangDAO.Instance.CapNhatTinDang(tinDang))
            {
                MessageBox.Show("Chỉnh sửa tin đăng thành công, đang đợi quản trị viên duyệt");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Chỉnh sửa tin đăng thất bại");
                tinDang.TieuDe = tieuDe;
                tinDang.MoTa = moTa;
            }
        }
        private void ThemQuangCao()
        {
            GoiQuangCao goiQuangCao = coboxGoiQuangCao.SelectedValue as GoiQuangCao;
            QuangCao quangCao = new QuangCao(tinDang.MaTin, goiQuangCao.MaGoiQuangCao, goiQuangCao.SoNgay);
            QuangCaoDAO.Instance.ThemQuangCao(quangCao);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!tinDang.TieuDe.Equals(txtTieuDe.Text) || !tinDang.MoTa.Equals(txtMoTa.Text))
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có thực sự muốn sửa tin?\nNếu tin không hợp lệ sẽ bị xóa vĩnh viễn",
                    "Cập nhật tin",
                    MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    ChinhSuaTin();
                }
                else
                {
                    return;
                }
            }
            if (ckboxChonQuangCao.Checked)
            {
                ThemQuangCao();
            }
        }

        private void ckboxChonQuangCao_CheckedChanged(object sender, EventArgs e)
        {
            coboxGoiQuangCao.Enabled = ckboxChonQuangCao.Checked;
            lbThongTinGoiQC.Visible = ckboxChonQuangCao.Checked;
        }

        private void coboxGoiQuangCao_SelectedValueChanged(object sender, EventArgs e)
        {
            GoiQuangCao goi = coboxGoiQuangCao.SelectedValue as GoiQuangCao;
            lbThongTinGoiQC.Text = "Giá gói: " + MyFormat.FormatMoney(goi.Gia) + " VNĐ - Thời gian: " + goi.SoNgay + " ngày";
        }
    }
}
