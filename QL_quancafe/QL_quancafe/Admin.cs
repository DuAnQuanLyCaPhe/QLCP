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
using Class_QLcafe;

namespace QL_quancafe
{
    public partial class Admin : MaterialForm
    {


        public Admin()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void tp_banan_Click(object sender, EventArgs e)
        {

        }

        private void dgv_taikhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void active_dgv_acc()
        {
            dgv_taikhoan.DataSource = Cls_acc.Select_acc();
            
        }
        private void tp_Acc_Click(object sender, EventArgs e)
        {
                active_dgv_acc();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            active_dgv_acc();
        }

        private void btn_setpassword_Click(object sender, EventArgs e)
        {

        }
    }
}
