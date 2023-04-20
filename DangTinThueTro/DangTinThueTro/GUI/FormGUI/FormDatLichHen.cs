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
    public partial class FormDatLichHen : Form
    {
        private string maPhongTro;
        public FormDatLichHen(string maPhongTro)
        {
            InitializeComponent();
            this.maPhongTro = maPhongTro;
            SetMinDateTimePicker();
        }
        private void SetMinDateTimePicker()
        {
            DateTime today = DateTime.Now;
            dateTimePickerNgayGioHen.MinDate = today.AddDays(1);
        }

        private void btnDatLichHen_Click(object sender, EventArgs e)
        {
            int maNguoiDung = AccountDAO.Instance.MaNguoiDung;
            string maPhongTro = this.maPhongTro;
            string ngayHen = MyFormat.FormatNgayThatSangDb(dateTimePickerNgayGioHen.Value);
            string gioHen = MyFormat.FormatNgayGioSangGio(dateTimePickerNgayGioHen.Value);
            string ghiChu = richTxtGhiChu.Text;
            LichHen lichHen = new LichHen(maNguoiDung, maPhongTro, ngayHen, gioHen, ghiChu);
            if (LichHenDAO.Instance.DatLichHen(lichHen))
            {
                MessageBox.Show("Đặt lịch hẹn thành công");
                this.Dispose();
            }
            else
                MessageBox.Show("Đặt lịch hẹn thất bại");
        }
    }
}
