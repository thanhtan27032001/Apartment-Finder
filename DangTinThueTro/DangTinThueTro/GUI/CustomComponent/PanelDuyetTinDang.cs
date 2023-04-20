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
    public partial class PanelDuyetTinDang : UserControl
    {
        private List<DuyetTinDang> listTinDang;
        public PanelDuyetTinDang()
        {
            InitializeComponent();
            LoadData();
            LoadUI();
        }
        private void LoadData()
        {
            listTinDang = TinDangDAO.Instance.GetListTinDangDuyet();
        }
        private void LoadUI()
        {
            flowLayoutPanelMain.Controls.Clear();
            foreach (DuyetTinDang t in listTinDang)
            {
                flowLayoutPanelMain.Controls.Add(new ItemDuyetTinDang(t));
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
            LoadUI();
        }
    }
}
