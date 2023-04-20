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
    public partial class FormChiTietTin : Form
    {
        private TinDang tinDang;
        private List<string> listHinhThamKhao;
        public FormChiTietTin(TinDang tinDang, List<string> listHinhThamKhao)
        {
            InitializeComponent();
            this.tinDang = tinDang;
            this.listHinhThamKhao = listHinhThamKhao;
            LoadUI();
            if (PhongTro.LaPhongTroCuaToi(tinDang.MaTin))
            {
                btnDatLichHen.Visible = false;
            }
        }
        public FormChiTietTin(string maPhongTro)
        {
            InitializeComponent();
            LoadData(maPhongTro);
            LoadUI();
            btnDatLichHen.Visible = false;
        }
        private void LoadData(string maPhongTro)
        {
            this.tinDang = TinDangDAO.Instance.Get1TinDang(maPhongTro);
            if(tinDang != null)
            {
                this.listHinhThamKhao = HinhThamKhaoDAO.Instance.GetListHinhThamKhao(tinDang.MaTin);
            }
        }
        private void LoadUI()
        {
            // Load thông tin
            string space = "    ";
            lbTieuDe.Text = tinDang.TieuDe;
            lbGiaPhong.Text = space + "Tiền phòng 1 tháng: " + MyFormat.FormatMoney(tinDang.GiaPhong) + " VNĐ";
            lbDienTich.Text = space + "Diện tích: " + tinDang.ChieuDai + "x" + tinDang.ChieuRong + " m2";
            lbGiaDien.Text = space + "Tiền điện 1kW: " + MyFormat.FormatMoney(tinDang.GiaDien) + " VNĐ";
            lbGiaNuoc.Text = space + "Tiền nước 1 khối: " + MyFormat.FormatMoney(tinDang.GiaNuoc) + " VNĐ";
            lbNgayDang.Text = space + "Ngày đăng: " + tinDang.NgayDang;
            lbDiaChi.Text = "Địa chỉ: " + tinDang.SoNha + ", " + XaPhuongThiTran.GetDiaChi(tinDang.MaXaPhuong);
            lbMoTa.Text = tinDang.MoTa;
            // Load hình tham khảo
            PictureBox pictureBox;
            foreach (string hinh in listHinhThamKhao)
            {
                try
                {
                    pictureBox = new PictureBox();
                    pictureBox.Size = new Size(1029, 500);
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Image = Image.FromFile(MyFormat.GetFilePath(hinh));
                    flowLayoutPanelHinhThamKhao.Controls.Add(pictureBox);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("ERROR: Không tìm thấy hình " + hinh);
                }
            }
        }
        private void btnDatLichHen_Click(object sender, EventArgs e)
        {
            new FormDatLichHen(tinDang.MaTin).ShowDialog();
        }
    }
}
