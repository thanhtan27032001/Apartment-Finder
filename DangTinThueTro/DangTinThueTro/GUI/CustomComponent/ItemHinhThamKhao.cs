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
    public partial class ItemHinhThamKhao : UserControl
    {
        private string hinh;
        public ItemHinhThamKhao(string hinh)
        {
            InitializeComponent();
            this.hinh = hinh;
            
        }
    }
}
