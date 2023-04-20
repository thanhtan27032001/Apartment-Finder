using DangTinThueTro.DAO;
using DangTinThueTro.DTO;
using DangTinThueTro.GUI.CustomComponent;
using DangTinThueTro.GUI.FormGUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangTinThueTro.CustomComponent
{
    public partial class ItemNhaTro : UserControl
    {
        private NhaTro? nhaTro = null;
        
        public ItemNhaTro(NhaTro nhaTro)
        {
            InitializeComponent();
            this.nhaTro = nhaTro;
            LoadData();
        }

        private void LoadData()
        {
            lbTieuDe.Text = "Id nhà trọ: " + nhaTro.MaNhaTro;
            lbTienDien.Text = "Tiền điện 1kW: " + MyFormat.FormatMoney(nhaTro.GiaDien) + " VNĐ";
            lbTienNuoc.Text = "Tiền nước 1 khối: " + MyFormat.FormatMoney(nhaTro.GiaNuoc) + " VNĐ";
            lbDiaChi.Text = "Địa chỉ: " + nhaTro.SoNha + ", " + XaPhuongThiTran.GetDiaChi(nhaTro.MaXaPhuong);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Bạn có thực sự muốn ẩn nhà trọ này?", 
                "Ẩn trọ", 
                MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                if (NhaTroDAO.Instance.XoaNhaTro(nhaTro.MaNhaTro)){
                    MessageBox.Show("Ẩn nhà trọ thành công");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Ẩn nhà trọ thất bại");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            FormSuaNhaTro formSuaNhaTro = new FormSuaNhaTro(nhaTro);
            formSuaNhaTro.ShowDialog();
            if (formSuaNhaTro.IsUpdated())
            {
                LoadData();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnQLPhongTro_Click(object sender, EventArgs e)
        {
            new FormQLPhongTro(nhaTro).ShowDialog();
        }
    }
}


