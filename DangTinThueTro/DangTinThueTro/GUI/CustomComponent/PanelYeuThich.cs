using DangTinThueTro.DAO;
using DangTinThueTro.DTO;
using DangTinThueTro.GUI.CustomComponent;
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
    public partial class PanelYeuThich : UserControl
    {
        List<TinDang>? listTinDangYeuThich = null;
        public PanelYeuThich()
        {
            InitializeComponent();
            LoadData();
            LoadUI();
        }
        private void LoadData()
        {
            listTinDangYeuThich = YeuThichDAO.Instance.GetTinYeuThich(AccountDAO.Instance.MaNguoiDung);
        }
        private void LoadUI()
        {
            flowLayoutPanelMain.Controls.Clear();
            foreach (TinDang t in listTinDangYeuThich)
            {
                flowLayoutPanelMain.Controls.Add(new ItemTinDang(t));
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
            LoadUI();
        }
    }
}
