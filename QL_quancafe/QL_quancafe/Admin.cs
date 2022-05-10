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
using System.Data.SqlClient;
namespace QL_quancafe
{
    public partial class Admin : MaterialForm
    {
        SqlConnection kn = TasmaMain.ketnoi(@"DESKTOP-MC\SQLEXPRESS", "QL_COFFEE");
        readonly MaterialSkin.MaterialSkinManager materialSkin;
        public Admin()
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
        // Phần Sử Dụng Chung
        // ==========================================================
        public void clearText()
        {
            txt_maTV.Text = "";
            txt_tenTV.Text = "";
            nup_diemtl.Value = 0;
            nup_slmh.Value = 0;
            txt_dgg.Text = "0%";
        }
        public void unableText(bool check)
        {
            txt_tenTV.Enabled = check;
            nup_slmh.Enabled = check;
        }
        // ===========================================================
        // Phần Thẻ Thành Viên
        // ===========================================================
        public void DataGV_ThanhVien()
        {
            DataTable dt = TasmaMain.LietKeDuLieu("THANHVIEN", kn);
            dataGV_TV.DataSource = dt;
            Infor_ThanhVien();
        }
        public void Infor_ThanhVien()
        {
            DataTable dt = TasmaMain.LietKeDuLieu("THANHVIEN", "MaTV", dataGV_TV.CurrentRow.Cells[0].Value,
              kn);
            txt_maTV.DataBindings.Clear();
            txt_tenTV.DataBindings.Clear();
            nup_diemtl.DataBindings.Clear();
            nup_slmh.DataBindings.Clear();
            txt_dgg.DataBindings.Clear();
            txt_maTV.DataBindings.Add("Text", dt, "MaTV");
            txt_tenTV.DataBindings.Add("Text", dt, "TenTV");
            nup_diemtl.DataBindings.Add("Value", dt, "DiemTichLuy");
            nup_slmh.DataBindings.Add("Value", dt, "SoLanMuaHang");
            txt_dgg.DataBindings.Add("Text", dt, "DiemGiamGia");
            txt_dgg.Text += "%";
        }
        private void dataGV_TV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Infor_ThanhVien();
            unableText(false);
            btn_sua_tv.Enabled = true;
            btn_xoa_tv.Enabled = true;
        }
        private void nup_slmh_ValueChanged(object sender, EventArgs e)
        {
            nup_diemtl.Value = nup_slmh.Value * 10;
            txt_dgg.Text = nup_diemtl.Value / 100 + "%";
        }
        private void btn_them_tv_Click(object sender, EventArgs e)
        {
            clearText();
            btn_luu.Text = "Thêm";
            unableText(true);
            string idst = TasmaMain.LietKeTuDo(
                "SELECT TOP 1 MaTV FROM THANHVIEN ORDER BY MaTV DESC", kn).Rows[0]["MaTV"].ToString();

            txt_maTV.Text = TasmaMain.IDSinhTruong(idst.Trim());
            btn_luu.Visible = true;
        }
        private void btn_sua_tv_Click(object sender, EventArgs e)
        {
            btn_luu.Text = "Lưu";
            unableText(true);
            btn_luu.Visible = true;
        }
        private void btn_xoa_tv_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                String.Format("Xác Nhận Xóa Thành Viên {0}", dataGV_TV.CurrentRow.Cells[1].Value),
                "Xóa Thành Viên", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string mess = (TasmaMain.XoaDuLieu("THANHVIEN", "MaTV",
                    dataGV_TV.CurrentRow.Cells[0].Value, kn)) ?
                    "Đã Xóa Thành Công " + txt_tenTV.Text : "Có Lỗi Xảy Ra Khi Xóa";
                MessageBox.Show(mess);
                DataGV_ThanhVien();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Đã Hủy Thành Công");
            }
        }
        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (txt_tenTV.Text != "")
            {
                Dictionary<string, object> dl = new Dictionary<string, object>();
                dl.Add("MaTV", txt_maTV.Text);
                dl.Add("TenTV", txt_tenTV.Text);
                dl.Add("DiemTichLuy", nup_diemtl.Value);
                dl.Add("SoLanMuaHang", nup_slmh.Value);
                dl.Add("DiemGiamGia", txt_dgg.Text.Substring(0, txt_dgg.Text.Length - 1));
                if (btn_luu.Text == "Thêm")
                {
                    if (TasmaMain.ThemDuLieu("THANHVIEN", dl, kn))
                        MessageBox.Show("Đã Thêm Thành Công Thành Viên " + txt_tenTV.Text);
                    else MessageBox.Show("Đã có lỗi xảy ra trong quá trình thêm");
                    clearText();
                    DataGV_ThanhVien();
                    unableText(false);
                }
                else
                {
                    if (TasmaMain.SuaDuLieu("THANHVIEN", dl, "MaTV", txt_maTV.Text, kn))
                    {
                        MessageBox.Show("Đã Sửa Thành Công Thông Tin Của " + txt_tenTV.Text);
                    }
                    else MessageBox.Show("Đã có lỗi xảy ra trong quá trình sửa");
                    DataGV_ThanhVien();
                    unableText(false);
                }
            }
            else MessageBox.Show("Vui Lòng Nhập Tên Thành Viên");
            btn_luu.Visible = false;
        }
        //======================================================
        // Phần Món
        public void CB_LOAIMON()
        {
            DataTable dt = TasmaMain.LietKeDuLieu("LOAIMON", kn);
            cb_loaimon.DataSource = dt;
            cb_loaimon.DisplayMember = "TENLOAIMON";
            cb_loaimon.ValueMember = "MALOAIMON";
            CB_MON();
        }
        public void CB_MON()
        {
            DataTable dt = TasmaMain.LietKeDuLieu("MON", "MaLoaiMon", cb_loaimon.SelectedValue, kn);
            cb_tenmon.DataSource = dt;
            cb_tenmon.DisplayMember = "TENMON";
            cb_tenmon.ValueMember = "ID";
        }
        public int getBill()
        {
            if (cb_tenmon.Items.Count > 0)
            {
                DataTable dt_c = TasmaMain.LietKeDuLieu("MON", "ID", cb_tenmon.SelectedValue, kn);
                return Convert.ToInt32(dt_c.Rows[0]["DonGia"]);
            }
            else return 0;
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            DataGV_ThanhVien();
            CB_LOAIMON();
        }

        private void rad_nam_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_datm_Click(object sender, EventArgs e)
        {
            int tongtien = 0;
            int tongsl = 0;
            Dictionary<string, object> DO = new Dictionary<string, object>();
            DO.Add("TENMON", cb_tenmon.Text);
            DO.Add("DONGIA", txt_giatien.Text);
            DO.Add("SOLUONG", nup_slmon.Value);
            DO.Add("LOAIMON", cb_loaimon.Text);
            dataGV_cmon.Rows.Add(DO["TENMON"], DO["LOAIMON"], DO["SOLUONG"], DO["DONGIA"]);
            for (int i = 0; i < dataGV_cmon.Rows.Count - 1; i++)
            {
                tongtien += Convert.ToInt32(dataGV_cmon.Rows[i].Cells["DONGIA"].Value);
                tongsl += Convert.ToInt32(dataGV_cmon.Rows[i].Cells["SOLUONG"].Value);
            }
            txt_ttm.Text = tongtien.ToString();
            nup_tslm.Value = tongsl;
        }

        private void txt_ttmon_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_tenmon_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_giatien.Text = Convert.ToInt32(nup_slmon.Value) * getBill() + "";
        }

        private void cb_loaimon_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_MON();
        }

        private void nup_slmon_ValueChanged(object sender, EventArgs e)
        {
            txt_giatien.Text = Convert.ToInt32(nup_slmon.Value) * getBill() + "";
        }
    }
}
