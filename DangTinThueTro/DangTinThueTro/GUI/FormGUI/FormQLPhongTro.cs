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

namespace DangTinThueTro.GUI.FormGUI
{
    public partial class FormQLPhongTro : Form
    {
        private NhaTro nhaTro;
        public FormQLPhongTro(NhaTro nhaTro)
        {
            InitializeComponent();
            this.nhaTro = nhaTro;
            LoadUI();
        }
        private void LoadUI()
        {
            flowLayoutPanelMain.Controls.Clear();
            foreach(PhongTro phongTro in nhaTro.PhongTroList)
            {
                flowLayoutPanelMain.Controls.Add(new ItemPhongTro(phongTro));
            }
        }
        private void btnThemTro_Click(object sender, EventArgs e)
        {
            FormThemPhongTro form = new FormThemPhongTro(nhaTro.MaNhaTro);
            form.ShowDialog();
            if (form.IsAdded)
            {
                nhaTro.LoadListPhongTro();
                LoadUI();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            nhaTro.LoadListPhongTro();
            LoadUI();
        }
    }
}
