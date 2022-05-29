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
    public partial class MH : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkin;
        public MH()
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
        public void infoMH()
        {
            if (dataGV.Rows.Count > 0)
            {
                DataGridViewCellCollection data = dataGV.CurrentRow.Cells;
                txt_mahang.Text = data["MaHang"].Value.ToString();
                txt_tenhang.Text = data["TenHang"].Value.ToString();
                nup_soluong.Value = Convert.ToInt32(data["SoLuong"].Value);
                txt_dvt.Text = data["DVT"].Value.ToString();
                txt_dongia.Text = data["DonGia"].Value.ToString();
            }
        }
        public void clearText()
        {
            DataTable HH = TasmaMain.LietKeTuDo(
                "SELECT TOP 1 MaHang FROM MATHANG ORDER BY MaHang DESC", TasmaMain.kn);
            txt_mahang.Text = TasmaMain.IDSinhTruong(
                (HH.Rows.Count > 0) ? HH.Rows[0]["MaHang"].ToString().Trim() : "HH000");
            txt_tenhang.Text = "";
            txt_dvt.Text = "";
            txt_dongia.Text = "";
            nup_soluong.Value = 0;
        }
        public void unableText(bool check)
        {
            txt_tenhang.Enabled = check;
            nup_soluong.Enabled = check;
            txt_dvt.Enabled = check;
            txt_dongia.Enabled = check;
        }
        public void unableBTN(bool check)
        {
            btn_them.Enabled = check;
            btn_sua.Enabled = check;
            btn_xoa.Enabled = check;
        }
        public void visibleBTN(bool check)
        {
            btn_luu.Visible = check;
            btn_huy.Visible = check;
        }
        public void DataGV_MH()
        {
            DataTable MH = TasmaMain.LietKeDuLieu("MATHANG", "SoKho", TasmaMain.SK, TasmaMain.kn);
            dataGV.DataSource = MH;
        }
        private void MH_Load(object sender, EventArgs e)
        {
            //MH.ActiveForm.Text = "Mặt Hàng Thuộc Kho " + TasmaMain.SK;
            DataGV_MH();
        }
        private void btn_luu_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> dl = new Dictionary<string, object>();
            dl.Add("MaHang", txt_mahang.Text);
            dl.Add("TenHang", txt_tenhang.Text);
            dl.Add("SoLuong", nup_soluong.Value);
            dl.Add("Gia", txt_dongia.Text);
            dl.Add("DVT", txt_dvt.Text);
            dl.Add("SoKho", TasmaMain.SK);
            
            if (btn_luu.Text == "Thêm")
            {
                //MessageBox.Show(TasmaMain.KT_ThemDuLieu("MATHANG", dl));
                bool res = TasmaMain.ThemDuLieu("MATHANG", dl, TasmaMain.kn);
                MessageBox.Show(res ? "Đã thêm thành công " + txt_tenhang.Text
                    : "Có lỗi xảy ra trong quá trình thêm");
            }
            else
            {
                bool res = TasmaMain.SuaDuLieu("MATHANG", dl,
                    "MaHang", txt_mahang.Text, TasmaMain.kn);
                MessageBox.Show(res ? "Đã sửa thành công " + txt_tenhang.Text
                    : "Có lỗi xảy ra trong quá trình sửa");
            }
            unableText(false);
            unableBTN(true);
            visibleBTN(false);
            DataGV_MH();
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            unableBTN(false);
            visibleBTN(true);
            unableText(true);
            clearText();
            btn_luu.Text = "Thêm";
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            btn_luu.Text = "Lưu";
            unableBTN(false);
            visibleBTN(true);
            unableText(true);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
              String.Format("Xác Nhận Xóa {0}?", txt_tenhang.Text),
              "Xóa Thành Viên", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bool res = TasmaMain.XoaDuLieu("MATHANG", "MaHang",
                    txt_mahang.Text, TasmaMain.kn);
                MessageBox.Show(res ? "Đã xóa thành công " + txt_tenhang.Text
                    : "Có lỗi xảy ra trong quá trình xóa");
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Đã Hủy Thành Công");
            }
            DataGV_MH();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            unableBTN(true);
            visibleBTN(false);
            unableText(false);
            DataGV_MH();
        }

        private void dataGV_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            infoMH();
        }
    }
}
