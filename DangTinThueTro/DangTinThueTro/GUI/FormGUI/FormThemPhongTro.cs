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
using DangTinThueTro.DAO;

namespace DangTinThueTro.GUI.FormGUI
{
    public partial class FormThemPhongTro : Form
    {
        private int maNhaTro;
        private bool isAdded = false;

        private List<string> listAnhThamKhao = new List<string>();
        private string desDir = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Resources\\";

        public bool IsAdded { get => isAdded;}

        public FormThemPhongTro(int maNhaTro)
        {
            InitializeComponent();
            this.maNhaTro = maNhaTro;
        }
        #region Phương thức
        private void ThemPhongTro() 
        {
            CopyAnhThamKhaoDenProject();
            // Tạo mã phòng trọ
            string maPhongTro = maNhaTro + "_" + MyFormat.FormatDateTime(DateTime.Now); 
            // Lấy thông tin phòng trọ từ input
            double chieuDai = Convert.ToDouble(txtChieuDai.Text);
            double chieuRong = Convert.ToDouble(txtChieuRong.Text);
            int soPhongTrong = (int)numericUpDownSoPhongTrong.Value;
            int giaPhong = Convert.ToInt32(txtGiaPhong.Text);
            string anhThamKhao = listAnhThamKhao[0];
            // Tạo đối tượng phòng trọ
            PhongTro phongTro = new PhongTro(maPhongTro, chieuDai, chieuRong, soPhongTrong, giaPhong, anhThamKhao);
            // Thêm phòng trọ
            if (PhongTroDAO.Instance.ThemPhongTro(phongTro, maNhaTro))
            {
                ThemAnhThamKhao(maPhongTro);
                MessageBox.Show("Thêm phòng trọ thành công");
                isAdded = true;
                this.Dispose();
            }
            else
                MessageBox.Show("Thêm phòng trọ thất bại");
        }
        private void CopyAnhThamKhaoDenProject()
        {
            string sourcePath, desPath;
            for (int i = 0; i < listAnhThamKhao.Count; i++)
            {
                try
                {
                    sourcePath = listAnhThamKhao[i];
                    listAnhThamKhao[i] = MyFormat.FormatDateTime(DateTime.Now) + Path.GetFileName(listAnhThamKhao[i]);
                    desPath = desDir + listAnhThamKhao[i];
                    File.Copy(sourcePath, desPath);
                    //MessageBox.Show("s: " + sourcePath + "\nd: " + desPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void ThemAnhThamKhao(string maPhongTro) 
        {
            HinhThamKhaoDAO.Instance.ThemHinhThamKhao(listAnhThamKhao, maPhongTro);
        }

        private bool InputHopLe()
        {
            if (txtChieuDai.Text.Equals(""))
            {
                MessageBox.Show("Chiều dài không được trống");
                return false;
            }
            if (txtChieuRong.Text.Equals(""))
            {
                MessageBox.Show("Chiều rộng không được trống");
                return false;
            }
            if(txtChieuDai.Text.Equals("0") || txtChieuRong.Text.Equals("0"))
            {
                MessageBox.Show("Chiều dài và chiều rộng phải lớn hơn không");
                return false;
            }
            if (txtGiaPhong.Text.Equals(""))
            {
                MessageBox.Show("Giá phòng không được trống");
                return false;
            }
            if(listAnhThamKhao.Count < 1)
            {
                MessageBox.Show("Ảnh tham khảo không được trống");
                return false;
            }
            return true;
        }
        #endregion

        #region Sự kiện
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (InputHopLe())
            {
                ThemPhongTro();
            }
        }
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            if (openFileDialogChonAnh.ShowDialog() == DialogResult.OK)
            {
                // Reset danh sách ảnh tham khảo
                listAnhThamKhao.Clear();
                foreach (string s in openFileDialogChonAnh.FileNames)
                {
                    listAnhThamKhao.Add(s);
                }
                // Thêm tất cả path ảnh tham khảo vào rich text box
                richTextBoxAnhThamKhao.Text = "";
                foreach (string s in listAnhThamKhao)
                {
                    richTextBoxAnhThamKhao.Text += s + "\n";
                }
            }
        }

        private void txtChieuDai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void txtChieuRong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
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
        private void txtGiaPhong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtConTrong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}
