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
    public partial class PanelQLLichHen : UserControl
    {
        private List<LichHen>? listLichHen;
        public PanelQLLichHen()
        {
            InitializeComponent();
            LoadData();
            LoadUI();
        }
        private void LoadData()
        {
            listLichHen = LichHenDAO.Instance.GetListLichHenDaNhan(AccountDAO.Instance.MaNguoiDung);
        }
        private void LoadUI()
        {
            flowLayoutPanelMain.Controls.Clear();
            if (listLichHen != null)
            {
                foreach (LichHen lichHen in listLichHen)
                {
                    flowLayoutPanelMain.Controls.Add(new ItemLichHenNhan(lichHen));
                }
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
            LoadUI();
        }
    }
}
