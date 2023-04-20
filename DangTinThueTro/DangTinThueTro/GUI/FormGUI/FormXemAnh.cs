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
    public partial class FormXemAnh : Form
    {
        private PhongTro phongTro;
        public FormXemAnh(PhongTro phongTro)
        {
            InitializeComponent();
            this.phongTro = phongTro;
            LoadAnh();
        }
        private void LoadAnh()
        {
            List<string> listAnhThanhKhao = HinhThamKhaoDAO.Instance.GetListHinhThamKhao(phongTro.MaPhongTro);
            PictureBox pictureBox;
            foreach (string tenAnh in listAnhThanhKhao)
            {
                pictureBox = new PictureBox();
                pictureBox.Size = new Size(960, 525);
                pictureBox.BackColor = Color.FromArgb(20, 33, 61);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                try
                {
                    pictureBox.Image = Image.FromFile(MyFormat.GetFilePath(tenAnh));
                    //MessageBox.Show("Đã mở ảnh: " + MyFormat.GetFilePath(tenAnh));
                }
                catch (Exception ex)
                {
                    pictureBox.Image = null;
                    MessageBox.Show("Không thể mở ảnh: " + MyFormat.GetFilePath(tenAnh));
                }
                flowLayoutPanelContainer.Controls.Add(pictureBox);
            }
        }
    }
}
