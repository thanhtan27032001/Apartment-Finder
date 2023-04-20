using DangTinThueTro.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangTinThueTro
{
    public partial class DataTableGUI : Form
    {
        public DataTableGUI()
        {
            InitializeComponent();
            LoadUser();
        }
        private void LoadUser()
        {
            //// Thực thi SP lấy tất cả thông tin tài khoản
            //DataProvider data = new DataProvider();
            //DataTable dt = data.ExecuteQuerry("EXECUTE SP_GET_ALL_ACCOUNT");
            //dataGridView1.DataSource = dt;

            // Thực thi SP lấy thông tin các dịch vụ có icon @Icon
            DataTable dt = DataProvider.Instance.ExecuteQuerry("EXECUTE SP_GET_SERVICE @Icon", new object[] {"aaa"});
            dataGridView1.DataSource = dt;
        }

        private void btnShowCount_Click(object sender, EventArgs e)
        {
            int count = DataProvider.Instance.ExecuteNonQuerry("EXECUTE SP_GET_SERVICE @Icon", new object[] { "aaa" });
            MessageBox.Show(Convert.ToString(count));
        }
    }
}
