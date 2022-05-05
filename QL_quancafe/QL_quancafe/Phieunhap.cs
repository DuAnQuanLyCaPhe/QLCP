using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;

namespace QL_quancafe
{
    public partial class Phieunhap : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkin;
        public Phieunhap()
        {
            InitializeComponent();
            materialSkin = MaterialSkin.MaterialSkinManager.Instance;
            materialSkin.AddFormToManage(this);
            materialSkin.EnforceBackcolorOnAllComponents = true;
            materialSkin.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkin.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey800,
                MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500,
                MaterialSkin.Accent.Red400, MaterialSkin.TextShade.WHITE);
        }

        private void Phieunhap_Load(object sender, EventArgs e)
        {

        }

        private void materialTextBox23_Click(object sender, EventArgs e)
        {

        }

        private void materialComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
