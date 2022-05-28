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
using TasmaControl;
namespace QL_quancafe
{
    public partial class login : MaterialForm
    {
        public login()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        public void DangNhap()
        {
            Dictionary<string, object> dl = new Dictionary<string, object>();
            dl.Add("NAME_USER", txt_tentk.Text);
            dl.Add("PASS_USER", txt_mk.Text);
            bool checkDN = TasmaMain.XLDangNhap("QUANLY", dl, TasmaMain.kn);
            if (checkDN)
            {
                MessageBox.Show("Đăng Nhập Thành Công");
                this.Hide();
                Admin main = new Admin();
                main.Show();
            }
            else MessageBox.Show("Sai Tên Đăng Nhập Hoặc Mật Khẩu");
        }
        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_tentk.Text != "" || txt_mk.Text != "")
                DangNhap();
            else MessageBox.Show("Không được để trống");
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
