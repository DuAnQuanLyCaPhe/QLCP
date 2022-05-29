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
    public partial class HD : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkin;
        public HD()
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

        private void HD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QL_COFFEEDataSet.LK_BILL' table. You can move, or remove it, as needed.
            this.LK_BILLTableAdapter.Fill(this.QL_COFFEEDataSet.LK_BILL, TasmaMain.HD);

            this.reportViewer1.RefreshReport();
        }

        private void btn_inhd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Không có máy in để thực hiện");
        }

        private void btn_bangyc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Không có máy in để thực hiện");
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
             String.Format("Xác nhận hủy hóa đơn {0}?", TasmaMain.HD),
             "Xóa Nhân Viên", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int length = TasmaMain.LietKeDuLieu("HOADON", TasmaMain.kn).Rows.Count;
                for (int i = 0; i < length; i++)
                {
                    TasmaMain.XoaDuLieu("CTHD", "MaHoaDon",
                        TasmaMain.HD, TasmaMain.kn);
                    DataTable tk = TasmaMain.LietKeDuLieu("CTTK", "MAHOADON",
                        TasmaMain.HD, TasmaMain.kn);
                    for (int j = 0; j < tk.Rows.Count; j++)
                    {
                        TasmaMain.XoaDuLieu("CTTK", "MaHoaDon", tk.Rows[j]["MaHoaDon"], TasmaMain.kn);
                    }
                }
                bool res = TasmaMain.XoaDuLieu("HOADON", "MaHoaDon", TasmaMain.HD,
                    TasmaMain.kn);
                if (res)
                {
                    MessageBox.Show("Đã hủy thành công hóa đơn");
                    this.Hide();
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("OKE");
            }
        }
    }
}
