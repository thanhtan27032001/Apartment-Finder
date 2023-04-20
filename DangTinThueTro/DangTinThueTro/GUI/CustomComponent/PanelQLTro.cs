using DangTinThueTro.DAO;
using DangTinThueTro.DTO;
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
    public partial class PanelQLTro : UserControl
    {
        private static List<NhaTro>? listNhaTro;
        public PanelQLTro()
        {
            InitializeComponent();
            LoadUI();
        }

        #region Method

        private void LoadUI()
        {
            flowLayoutPanelMain.Controls.Clear();
            listNhaTro = NhaTroDAO.Instance.GetListNhaTro(AccountDAO.Instance.MaNguoiDung);
            foreach (NhaTro nhaTro in listNhaTro)
            {
                flowLayoutPanelMain.Controls.Add(new ItemNhaTro(nhaTro));
            }
        }
        #endregion
        
        private void btnThemTro_Click(object sender, EventArgs e)
        {
            FormThemNhaTro form = new FormThemNhaTro();
            form.ShowDialog();
            if (form.IsAdded)
            {
                LoadUI();
            }
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadUI();
        }
    }
}
