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
    public partial class QLDU : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkin;
        public QLDU()
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
        private void QLDU_Load(object sender, EventArgs e)
        {
            activeDataCBDU();
            activeDataGVDU();
            activeDataGVL();
        }
        // Phần Đồ Uống 
        // =========================================================
        public void activeDataCBDU()
        {
            DataTable cbdu = TasmaMain.LietKeDuLieu("LOAIDOUONG", TasmaMain.kn);
            cb_gv.DataSource = cbdu;
            cb_gv.DisplayMember = "TenLoaiDoUong";
            cb_gv.ValueMember = "MaLoaiDoUong";
        }
        public void activeDataGVDU()
        {
            DataTable dt = TasmaMain.LietKeDuLieu(
                String.Format("dbo.LK_DOUONG('{0}')", cb_gv.SelectedValue), TasmaMain.kn);
            dataGV.DataSource = dt;
            activeInforDU();
        }
        public void activeInforDU()
        {
            DataGridViewCellCollection dataInfo = dataGV.CurrentRow.Cells;
            txt_tendu.Text = dataInfo["TenDoUong"].Value.ToString();
            DataTable cbdu = TasmaMain.LietKeDuLieu("LOAIDOUONG", TasmaMain.kn);
            cb_loaidu.DataSource = cbdu;
            cb_loaidu.DisplayMember = "TenLoaiDoUong";
            cb_loaidu.ValueMember = "MaLoaiDoUong";
            cb_loaidu.SelectedIndex = cb_loaidu.FindStringExact(
                dataInfo["LoaiDoUong"].Value.ToString());
            txt_diemtich.Text = dataInfo["DiemTich"].Value.ToString();
            txt_giaban.Text = dataInfo["GiaBan"].Value.ToString();
            unableObj(false);
        }
        public void clearText()
        {
            txt_tendu.Text = "";
            txt_giaban.Text = "";
            txt_diemtich.Text = "";
            txt_tenloaidu.Text = "";
        }
        public void unableObj(bool check)
        {
            txt_tendu.Enabled = check;
            txt_giaban.Enabled = check;
            txt_diemtich.Enabled = check;
            cb_loaidu.Enabled = check;
        }
        public void unableButn(bool check)
        {
            btn_themdu.Enabled = check;
            btn_suadu.Enabled = check;
            btn_xoadu.Enabled = check;
            dataGV.Enabled = check;
        }
        public void visibleObj(bool check)
        {
            btn_luu.Visible = check;
            btn_huy.Visible = check;
        }
        private void btn_huy_Click(object sender, EventArgs e)
        {
            visibleObj(false);
            unableButn(true);
            unableObj(false);
        }
        private void btn_luu_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> dl = new Dictionary<string, object>();
            dl.Add("TenDoUong", txt_tendu.Text);
            dl.Add("MaLoaiDoUong", cb_loaidu.SelectedValue);
            dl.Add("DonGia", txt_giaban.Text);
            dl.Add("DiemTich", txt_diemtich.Text);

            if (btn_luu.Text == "Thêm")
            {
                bool res = TasmaMain.ThemDuLieu("DOUONG", dl, TasmaMain.kn);
                if (res)
                {
                    MessageBox.Show("Đã thêm thành công " + txt_tendu.Text);
                    unableObj(false);
                    visibleObj(false);
                    unableButn(true);
                    activeDataGVDU();
                }
                else MessageBox.Show("Vui lòng kiểm tra lại thông tin vừa nhập");
            }
            else
            {
                bool res = TasmaMain.SuaDuLieu("DOUONG", dl, "ID", 
                    dataGV.CurrentRow.Cells["ID"].Value, TasmaMain.kn);
                if (res)
                {
                    MessageBox.Show("Đã sửa thành công " + txt_tendu.Text);
                    unableObj(false);
                    visibleObj(false);
                    unableButn(true);
                    activeDataGVDU();
                }
                else MessageBox.Show("Vui lòng kiểm tra lại thông tin vừa nhập");
            }
        }
        private void btn_themdu_Click(object sender, EventArgs e)
        {
            visibleObj(true);
            unableButn(false);
            unableObj(true);
            clearText();
            btn_luu.Text = "Thêm";
        }
        private void btn_suadu_Click(object sender, EventArgs e)
        {
            visibleObj(true);
            unableButn(false);
            unableObj(true);
        }
        private void btn_xoadu_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                String.Format("Xác nhận xóa đồ uống {0}?", 
                dataGV.CurrentRow.Cells["TenDoUong"].Value), "Xóa Đồ Uống", 
                MessageBoxButtons.YesNo);
               
            if (dialogResult == DialogResult.Yes)
            {
                bool res = TasmaMain.XoaDuLieu("DOUONG", "ID",
                    dataGV.CurrentRow.Cells["ID"].Value, TasmaMain.kn);
                if (res)
                {
                    MessageBox.Show(res ? "Đã Xóa Thành Công" : "Có lỗi xảy ra");
                    activeDataGVDU();   
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Đã Hủy Thành Công");
            }
        }
        private void dataGV_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            activeInforDU();
        }
        private void cb_gv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_gv.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                activeDataGVDU();
            }
        }
        // ==================================================================

        public void clearTextL()
        {
            txt_tenloaidu.Text = "";
            txt_maloaidu.Text = "";
        }
        public void unableObjL(bool check)
        {
            txt_tenloaidu.Enabled = check;
            txt_maloaidu.Enabled = check;
        }
        public void unableButnL(bool check)
        {
            btn_them.Enabled = check;
            btn_sua.Enabled = check;
            btn_xoa.Enabled = check;
        }
        public void visibleObjL(bool check)
        {
            btn_luuL.Visible = check;
            btn_huyL.Visible = check;
        }
        public void activeDataGVL()
        {
            dataGV_ldu.DataSource = TasmaMain.LietKeDuLieu("LOAIDOUONG", TasmaMain.kn);

        }
        public void activeInforL()
        {
            if (dataGV_ldu.Rows.Count > 0)
            {
                DataGridViewCellCollection info = dataGV_ldu.CurrentRow.Cells;
                //MessageBox.Show(info["MaLoaiDU"].Value.ToString());
                txt_tenloaidu.Text = info["TenLoaiDoUong"].Value.ToString();
                txt_maloaidu.Text = info["MaLoaiDU"].Value.ToString();
            }
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            unableButnL(false);
            visibleObjL(true);
            unableObjL(true);
            clearTextL();
            btn_luuL.Text = "Thêm";
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            unableButn(false);
            visibleObjL(true);
            unableObjL(true);
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
               String.Format("Xác nhận xóa loại đồ uống {0}?",
               dataGV_ldu.CurrentRow.Cells["TenLoaiDoUong"].Value), "Xóa Loại Đồ Uống",
               MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                if (TasmaMain.LenhTuDo(
                    String.Format("ACTIVE_XLDU '{0}'", txt_maloaidu.Text), TasmaMain.kn))
                {
                    MessageBox.Show("Đã Xóa Thành Công");
                    activeDataCBDU();
                    activeDataGVDU();
                    activeDataGVL();
                }
                else MessageBox.Show("Có lỗi xảy ra");
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Đã Hủy Thành Công");
            }
        }
        private void btn_luuL_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> dl = new Dictionary<string, object>();
            dl.Add("TenLoaiDoUong", txt_tenloaidu.Text);
            dl.Add("MaLoaiDoUong", txt_maloaidu.Text);
            if (btn_luuL.Text == "Thêm")
            {  
                bool res = TasmaMain.ThemDuLieu("LOAIDOUONG", dl, TasmaMain.kn);
                if (res)
                {
                    MessageBox.Show("Đã thêm thành công " + txt_tenloaidu.Text);
                    unableObjL(false);
                    visibleObjL(false);
                    unableButnL(true);
                    activeDataGVL();
                }
                else MessageBox.Show("Vui lòng kiểm tra lại thông tin vừa nhập");
            }
            else
            {
                bool res = TasmaMain.LenhTuDo(
                    String.Format("ACTIVE_LDU '{0}', '{1}'",
                    dataGV_ldu.CurrentRow.Cells["MaLoaiDU"].Value, txt_maloaidu.Text), 
                    TasmaMain.kn);
                if (res)
                {
                    MessageBox.Show("Đã sửa thành công " + txt_tenloaidu.Text);
                    unableObjL(false);
                    visibleObjL(false);
                    unableButnL(true);
                    activeDataGVL();
                    activeDataCBDU();
                    activeDataGVDU();
                }
                else MessageBox.Show("Vui lòng kiểm tra lại thông tin vừa nhập");
            }
        }

        private void btn_huyL_Click(object sender, EventArgs e)
        {

        }

        private void cb_loaidu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGV_ldu_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            activeInforL();
        }
    }
}
