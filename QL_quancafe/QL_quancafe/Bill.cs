using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_quancafe
{
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QL_COFFEEDataSet.DOUONG' table. You can move, or remove it, as needed.
            this.DOUONGTableAdapter.Fill(this.QL_COFFEEDataSet.DOUONG);


            this.reportViewer1.RefreshReport();
        }
    }
}
