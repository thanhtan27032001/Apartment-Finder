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

namespace DangTinThueTro.GUI.CustomComponent
{
    public partial class PanelXacThucNguoiDung : UserControl
    {
        private List<DuyetNguoiDung> listNguoiDung;
        public PanelXacThucNguoiDung()
        {
            InitializeComponent();
            LoadData();
            LoadUI();
        }
        private void LoadData()
        {
            listNguoiDung = AccountDAO.Instance.GetListNguoiDungDuyet();
        }
        private void LoadUI()
        {
            flowLayoutPanelMain.Controls.Clear();
            foreach(DuyetNguoiDung d in listNguoiDung)
            {
                flowLayoutPanelMain.Controls.Add(new ItemXacThucNguoiDung(d));
            }
        }
    }
}
