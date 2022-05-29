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
using TasmaControl;
namespace QL_quancafe
{
    public partial class MATHANG : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkin;
        public MATHANG()
        {
            InitializeComponent();
            InitializeComponent();
            materialSkin = MaterialSkin.MaterialSkinManager.Instance;
            materialSkin.AddFormToManage(this);
            materialSkin.EnforceBackcolorOnAllComponents = true;
            materialSkin.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkin.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey800,
                MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500,
                MaterialSkin.Accent.Red400, MaterialSkin.TextShade.WHITE);
        }

        //public void infoMH()
        //{
        //    if(dataGV.Rows.Count > 0)
        //    {
        //        DataGridViewCellCollection data = dataGV.CurrentRow.Cells;
        //        txt_mahang.Text = data["MaHang"].Value.ToString();
        //        txt_tenhang.Text = data["TenHang"].Value.ToString();
        //        nup_soluong.Value = Convert.ToInt32(data["SoLuong"].Value);
        //        txt_dongia.Text = data["DonGia"].Value.ToString();
        //    }
        //}
    
        private void MATHANG_Load(object sender, EventArgs e)
        {
            //MATHANG.ActiveForm.Text = "Mặt Hàng Thuộc Kho " + TasmaMain.SK;
            //DataGV_MH();
            //dataGV.DataSource = TasmaMain.LietKeDuLieu("KHO", TasmaMain.kn);
        }

        private void dataGVMH_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //infoMH();
        }
        //private void btn_luu_Click(object sender, EventArgs e)
        //{
        //    Dictionary<string, object> dl = new Dictionary<string, object>();
        //    dl.Add("MaHang", txt_mahang.Text);
        //    dl.Add("TenHang", txt_tenhang.Text);
        //    dl.Add("SoLuong", nup_soluong.Value);
        //    dl.Add("DonGia", txt_dongia.Text);
        //    if(btn_luu.Text == "Thêm")
        //    {
        //        bool res = TasmaMain.ThemDuLieu("MATHANG", dl, TasmaMain.kn);
        //        MessageBox.Show(res ? "Đã thêm thành công " + txt_tenhang.Text
        //            : "Có lỗi xảy ra trong quá trình thêm");
        //    }
        //    else
        //    {
        //        bool res = TasmaMain.SuaDuLieu("MATHANG", dl, 
        //            "MaHang", txt_mahang.Text, TasmaMain.kn);
        //        MessageBox.Show(res ? "Đã sửa thành công " + txt_tenhang.Text
        //            : "Có lỗi xảy ra trong quá trình sửa");
        //    }
        //    unableText(false);
        //    unableBTN(true);
        //    visibleBTN(true);
        //    DataGV_MH();
        //}
        //private void btn_them_Click(object sender, EventArgs e)
        //{
        //    clearText();
        //    unableBTN(false);
        //    visibleBTN(true);
        //    unableText(true);
        //    btn_luu.Text = "Thêm";
        //}

        //private void btn_sua_Click(object sender, EventArgs e)
        //{
        //    unableBTN(false);
        //    visibleBTN(true);
        //    unableText(true);
        //}

        //private void btn_xoa_Click(object sender, EventArgs e)
        //{
        //    DialogResult dialogResult = MessageBox.Show(
        //      String.Format("Xác Nhận Xóa {0}", txt_tenhang.Text),
        //      "Xóa Thành Viên", MessageBoxButtons.YesNo);
        //    if (dialogResult == DialogResult.Yes)
        //    {
        //        bool res = TasmaMain.XoaDuLieu("MATHANG", "MaHang",
        //            txt_mahang.Text, TasmaMain.kn);
        //        MessageBox.Show(res ? "Đã xóa thành công " + txt_tenhang.Text
        //            : "Có lỗi xảy ra trong quá trình xóa");
        //    }
        //    else if (dialogResult == DialogResult.No)
        //    {
        //        MessageBox.Show("Đã Hủy Thành Công");
        //    }
        //}

        //private void dataGVMH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}
    }
}
