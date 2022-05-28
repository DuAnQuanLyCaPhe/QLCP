using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
namespace QL_quancafe
{
    public partial class Bill : MaterialForm
    {
        public Bill()
        {
            InitializeComponent();
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            this.reportV.RefreshReport();
        }

        private void btn_inhd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Không có máy in để thực hiện.");
        }
    }
}
