using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_quancafe
{
    public partial class AccountProfile : MaterialForm
    {
        public AccountProfile()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AccountProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
