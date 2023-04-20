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
    public partial class PanelQLTin : UserControl
    {
        private List<TinDangQL> listTin;
        public PanelQLTin()
        {
            InitializeComponent();
            LoadDataTinDang();
            LoadUITinDang();
        }
        private void LoadDataTinDang()
        {
            listTin = new List<TinDangQL>();
            listTin = TinDangDAO.Instance.GetListTinDangQL(AccountDAO.Instance.MaNguoiDung);
        }
        private void LoadUITinDang()
        {
            flowLayoutPanelMain.Controls.Clear();
            foreach (TinDangQL tinDang in listTin)
            {
                PhongTro phongTro = PhongTroDAO.Instance.GetPhongTro(tinDang.MaTin);
                NhaTro nhaTro = NhaTroDAO.Instance.GetNhaTro(phongTro.MaNhaTro);
                QuangCao quangCao = QuangCaoDAO.Instance.GetQuangCao(tinDang.MaTin);
                flowLayoutPanelMain.Controls.Add(new ItemTinDangQL(tinDang, phongTro, nhaTro, quangCao));
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadDataTinDang();
            LoadUITinDang();
        }
    }
}
