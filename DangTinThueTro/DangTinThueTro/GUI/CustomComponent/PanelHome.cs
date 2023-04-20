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
    public partial class PanelHome : UserControl
    {
        private List<TinDang> listTinDang;
        private List<TinDang>? listTinDangFilted = null;
        // Dữ liệu giả
        TinhThanhPho tatCaTinhThanh = new TinhThanhPho("00", "Tất cả tỉnh thành");
        QuanHuyenThiXa tatCaQuanHuyen = new QuanHuyenThiXa("0000", "Tất cả quận huyện", "00");
        XaPhuongThiTran tatCaXaPhuong = new XaPhuongThiTran("000000", "Tất cả xã phường", "0000");
        public PanelHome()
        {
            InitializeComponent();
            LoadData();
            LoadUI(listTinDang);
            SetDataComboboxTinhThanh();
        }
        private void LoadData()
        {
            listTinDang = TinDangDAO.Instance.GetListTinDangTimTro(AccountDAO.Instance.MaNguoiDung);
        }
        private void LoadUI(List<TinDang> listTinDang)
        {
            if(listTinDang != null)
            {
                flowLayoutPanelMain.Controls.Clear();
                foreach (TinDang t in listTinDang)
                {
                    flowLayoutPanelMain.Controls.Add(new ItemTinDang(t));
                }
            }
        }
        private void LocTro()
        {
            // Địa chỉ
            string maTinhThanh = (cboxTinhThanh.SelectedValue as TinhThanhPho).MaTinhThanh;
            string maQuanHuyen = (cboxQuanHuyen.SelectedValue as QuanHuyenThiXa).MaQuanHuyenThiXa;
            string maXaPhuong = (cboxXaPhuong.SelectedValue as XaPhuongThiTran).MaXaPhuongThiTran;
            // Giá phòng
            int giaTu = txtGiaTu.Text.Equals("") ? 0 : int.Parse(txtGiaTu.Text);
            int giaDen = txtGiaDen.Text.Equals("") ? int.MaxValue : int.Parse(txtGiaDen.Text);
            // Diện tích
            double dienTich;
            double dienTichTu = txtDienTichTu.Text.Equals("") ? 0 : double.Parse(txtDienTichTu.Text);
            double dienTichDen = txtDienTichDen.Text.Equals("") ? double.MaxValue : double.Parse(txtDienTichDen.Text);
            // Lọc:
            if(listTinDangFilted != null)
            {
                listTinDangFilted.Clear();
            }
            else
            {
                listTinDangFilted = new List<TinDang>();
            }
            if (maTinhThanh.Equals(tatCaTinhThanh.MaTinhThanh))
            {
                foreach (TinDang tinDang in listTinDang)
                {
                    dienTich = tinDang.ChieuDai * tinDang.ChieuRong;
                    if (tinDang.GiaPhong >= giaTu && tinDang.GiaPhong <= giaDen &&
                        dienTich >= dienTichTu && dienTich <= dienTichDen)
                    {
                        
                        listTinDangFilted.Add(tinDang);
                    }
                }
            }
            else if (maQuanHuyen.Equals(tatCaQuanHuyen.MaQuanHuyenThiXa))
            {
                foreach (TinDang tinDang in listTinDang)
                {
                    dienTich = tinDang.ChieuDai * tinDang.ChieuRong;
                    if (tinDang.MaXaPhuong.StartsWith(maTinhThanh) &&
                        tinDang.GiaPhong >= giaTu && tinDang.GiaPhong <= giaDen &&
                        dienTich >= dienTichTu && dienTich <= dienTichDen)
                    {
                        listTinDangFilted.Add(tinDang);
                    }
                }
            }
            else if (maXaPhuong.Equals(tatCaXaPhuong.MaXaPhuongThiTran))
            {
                foreach (TinDang tinDang in listTinDang)
                {
                    dienTich = tinDang.ChieuDai * tinDang.ChieuRong;
                    if (tinDang.MaXaPhuong.StartsWith(maQuanHuyen) &&
                        tinDang.GiaPhong >= giaTu && tinDang.GiaPhong <= giaDen &&
                        dienTich >= dienTichTu && dienTich <= dienTichDen)
                    {
                        listTinDangFilted.Add(tinDang);
                    }
                }
            }
            else
            {
                foreach (TinDang tinDang in listTinDang)
                {
                    dienTich = tinDang.ChieuDai * tinDang.ChieuRong;
                    if (tinDang.MaXaPhuong.Equals(maXaPhuong) &&
                        tinDang.GiaPhong >= giaTu && tinDang.GiaPhong <= giaDen &&
                        dienTich >= dienTichTu && dienTich <= dienTichDen)
                    {
                        listTinDangFilted.Add(tinDang);
                    }
                }
            }
        }
        private void SetDataComboboxTinhThanh()
        {
            List<TinhThanhPho> listTinhThanhPho = new List<TinhThanhPho>();
            listTinhThanhPho.Add(tatCaTinhThanh);
            foreach (TinhThanhPho t in DiaChiDAO.Instance.GetListTinhThanhPho())
            {
                listTinhThanhPho.Add(t);
            }
            cboxTinhThanh.DataSource = listTinhThanhPho;
            cboxTinhThanh.DisplayMember = "tenTinhThanh";
            cboxTinhThanh.ValueMember = null;
        }
        private void SetDataComboboxQuanHuyen(string filterTinhThanh)
        {

            List<QuanHuyenThiXa> listQuanHuyen = new List<QuanHuyenThiXa>();
            listQuanHuyen.Add(tatCaQuanHuyen);
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
            listXaPhuong.Add(tatCaXaPhuong);
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
        private void btnFilter_Click(object sender, EventArgs e)
        {
            panelFilter.Visible = !panelFilter.Visible;
        }

        private void btnTimTro_Click(object sender, EventArgs e)
        {
            if (ckboxDungLoc.Checked)
            {
                LocTro();
                LoadUI(listTinDangFilted);
            }
            else
            {
                LoadData();
                LoadUI(listTinDang);
            }
        }
    }
}
