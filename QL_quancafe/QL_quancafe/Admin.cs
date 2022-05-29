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
        // ===========================================================
        // Phần Thẻ Thành Viên
        // ===========================================================
        public void clearText()
        {
            txt_maTV.Text = "";
            txt_tenTV.Text = "";
            txt_diemtl.Text = "0";
            nup_slmh.Value = 0;
            txt_dgg.Text = "0%";
        }
        public void unableText(bool check)
        {
            txt_tenTV.Enabled = check;
            nup_slmh.Enabled = check;
            txt_diemtl.Enabled = check;
        }
        public void XoaHD_ThanhVien()
        {
            DataTable hd = TasmaMain.LietKeDuLieu("HOADON", "MaTV", txt_maTV.Text.Trim(), TasmaMain.kn);
            for (int i = 0; i < hd.Rows.Count; i++)
            {
                TasmaMain.XoaDuLieu("CTHD", "MaHoaDon",
                    hd.Rows[i]["MaHoaDon"].ToString().Trim(), TasmaMain.kn);
                DataTable tk = TasmaMain.LietKeDuLieu("CTTK", "MAHOADON",
                    hd.Rows[i]["MaHoaDon"].ToString().Trim(), TasmaMain.kn);
                for (int j = 0; j < tk.Rows.Count; j++)
                {
                    TasmaMain.XoaDuLieu("CTTK", "MaHoaDon", tk.Rows[j]["MaHoaDon"], TasmaMain.kn);
                }
            }
            TasmaMain.XoaDuLieu("HOADON", "MaTV", txt_maTV.Text.Trim(), TasmaMain.kn);
        }
        public void DataGV_ThanhVien()
        {
            DataTable dt = TasmaMain.LietKeDuLieu("THANHVIEN", TasmaMain.kn);
            dataGV_TV.DataSource = dt;
            currentChoice();
        }
        public void Infor_ThanhVien()
        {
            if(dataGV_TV.Rows.Count > 0)
            {
                DataTable dt = TasmaMain.LietKeDuLieu("THANHVIEN", "MaTV", dataGV_TV.CurrentRow.Cells[0].Value,
                TasmaMain.kn);
                txt_maTV.DataBindings.Clear();
                txt_tenTV.DataBindings.Clear();
                txt_diemtl.DataBindings.Clear();
                nup_slmh.DataBindings.Clear();
                txt_dgg.DataBindings.Clear();
                txt_maTV.DataBindings.Add("Text", dt, "MaTV");
                txt_tenTV.DataBindings.Add("Text", dt, "TenTV");
                txt_diemtl.DataBindings.Add("Text", dt, "DiemTichLuy");
                nup_slmh.DataBindings.Add("Value", dt, "SoLanMuaHang");
                txt_dgg.DataBindings.Add("Text", dt, "DiemGiamGia");
                txt_dgg.Text += "%";
            }
        }
        public void unableButn(bool check)
        {
            btn_them_tv.Enabled = check;
            btn_sua_tv.Enabled = check;
            btn_xoa_tv.Enabled = check;
            dataGV_TV.Enabled = check;
        }
        public void visibleButn(bool check)
        {
            btn_luu.Visible = check;
            btn_huy.Visible = check;
        }
        public void currentChoice()
        {
            if(dataGV_TV.Rows.Count > 0)
            {
                Infor_ThanhVien();
                btn_sua_tv.Enabled = true;
                btn_xoa_tv.Enabled = true;
            } else
            {
                btn_sua_tv.Enabled = false;
                btn_xoa_tv.Enabled = false;
            }
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
            //txt_diemtl.Text = nup_slmh.Value * 10 + "";
            //txt_dgg.Text = Convert.ToInt32(txt_diemtl.Text) / 100 + "%";
        }
        private void btn_them_tv_Click(object sender, EventArgs e)
        {
            DataTable TV = TasmaMain.LietKeTuDo(
                "SELECT TOP 1 MaTV FROM THANHVIEN ORDER BY MaTV DESC", TasmaMain.kn);
            clearText();
            btn_luu.Text = "Thêm";
            unableText(true);
            visibleButn(true);
            unableButn(false);
            string idst = (TV.Rows.Count > 0) ? TV.Rows[0]["MaTV"].ToString() : "TV000";
            txt_maTV.Text = TasmaMain.IDSinhTruong(idst.Trim());
        }
        private void btn_sua_tv_Click(object sender, EventArgs e)
        {
            btn_luu.Text = "Lưu";
            visibleButn(true);
            unableText(true);
            unableButn(false);
        }
        private void btn_xoa_tv_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                String.Format("Xác Nhận Xóa Thành Viên {0}", dataGV_TV.CurrentRow.Cells[1].Value),
                "Xóa Thành Viên", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                XoaHD_ThanhVien();
                string mess = (TasmaMain.XoaDuLieu("THANHVIEN", "MaTV",
                    dataGV_TV.CurrentRow.Cells[0].Value, TasmaMain.kn)) ?
                    "Đã Xóa Thành Công " + txt_tenTV.Text : "Có Lỗi Xảy Ra Khi Xóa";
                MessageBox.Show(mess);
                DataGV_ThanhVien();
                clearText();
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
                dl.Add("DiemTichLuy", txt_diemtl.Text);
                dl.Add("SoLanMuaHang", nup_slmh.Value);
                dl.Add("DiemGiamGia", txt_dgg.Text.Substring(0, txt_dgg.Text.Length - 1));
                if (btn_luu.Text == "Thêm")
                {
                    if (TasmaMain.ThemDuLieu("THANHVIEN", dl, TasmaMain.kn))
                        MessageBox.Show("Đã Thêm Thành Công Thành Viên " + txt_tenTV.Text);
                    else MessageBox.Show("Đã có lỗi xảy ra trong quá trình thêm");
                    clearText();
                    DataGV_ThanhVien();
                    unableText(false);
                }
                else
                {
                    if (TasmaMain.SuaDuLieu("THANHVIEN", dl, "MaTV", txt_maTV.Text, TasmaMain.kn))
                    {
                        MessageBox.Show("Đã Sửa Thành Công Thông Tin Của " + txt_tenTV.Text);
                    }
                    else MessageBox.Show("Đã có lỗi xảy ra trong quá trình sửa");
                    DataGV_ThanhVien();
                    unableText(false);
                }
            }
            else MessageBox.Show("Vui Lòng Nhập Tên Thành Viên");
            visibleButn(false);
            unableButn(true);
        }
        //======================================================
        // Phần Món
        public void CB_LOAIMON()
        {
            DataTable dt = TasmaMain.LietKeDuLieu("LOAIDOUONG", TasmaMain.kn);
            cb_loaidouong.DataSource = dt;
            cb_loaidouong.DisplayMember = "TENLOAIDOUONG";
            cb_loaidouong.ValueMember = "MALOAIDOUONG";
            CB_MON();
            cb_thetv.DataSource = TasmaMain.LietKeDuLieu("THANHVIEN", TasmaMain.kn);
            cb_thetv.DisplayMember = "TenTV";
            cb_thetv.ValueMember = "MaTV";
        }
        public void CB_MON()
        {
            DataTable dt = TasmaMain.LietKeDuLieu("DOUONG", "MALOAIDOUONG", cb_loaidouong.SelectedValue, TasmaMain.kn);
            cb_tendouong.DataSource = dt;
            cb_tendouong.DisplayMember = "TENDOUONG";
            cb_tendouong.ValueMember = "ID";
        }
        public int getBill()
        {
            if (cb_tendouong.Items.Count > 0)
            {
                DataTable dt_c = TasmaMain.LietKeDuLieu("DOUONG", "ID", cb_tendouong.SelectedValue, TasmaMain.kn);
                return Convert.ToInt32(dt_c.Rows[0]["DonGia"]);
            }
            else return 0;
        }
        public int checkDupli(string id)
        {
            int flag = -1;
                for (int i = 0; i < dataGV_cmon.RowCount; i++)
                {
                    if (id == dataGV_cmon.Rows[i].
                            Cells["TenDoUong"].Value.ToString().Trim())
                        flag = i;
                }
            return flag;
        }
        private void btn_datm_Click(object sender, EventArgs e)
        {
            int tongtien = 0;
            int tongsl = 0;
            Dictionary<string, object> DO = new Dictionary<string, object>();
            DO.Add("ID", cb_tendouong.SelectedValue);
            DO.Add("TENDOUONG", cb_tendouong.Text);
            DO.Add("DONGIA", txt_giatien.Text);
            DO.Add("SOLUONG", nup_slmon.Value);
            DO.Add("LOAIDOUONG", cb_loaidouong.Text);
            if (checkDupli(DO["TENDOUONG"].ToString()) == -1)
            {
                dataGV_cmon.Rows.Add(DO["ID"], DO["TENDOUONG"],
                  DO["LOAIDOUONG"], DO["SOLUONG"], DO["DONGIA"]);
            }
            else
            {
                int pos = checkDupli(DO["TENDOUONG"].ToString());
                DataGridViewCellCollection data = dataGV_cmon.Rows[pos].Cells;
                data["SoLuong"].Value = Convert.ToInt32(data["SoLuong"].Value) +
                    Convert.ToInt32(DO["SOLUONG"]);
                data["DonGia"].Value = Convert.ToInt32(data["DonGia"].Value) +
                   Convert.ToInt32(DO["DONGIA"]);
            }
            for (int i = 0; i < dataGV_cmon.Rows.Count; i++)
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
            if (nup_slmon.Value > 0)
            {
                btn_datm.Enabled = true;
            }
            else btn_datm.Enabled = false;
        }
        private void check_thetv_CheckedChanged(object sender, EventArgs e)
        {
            cb_thetv.Enabled = check_thetv.Checked;
        }

        private void cb_thetv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btn_ttmon_Click(object sender, EventArgs e)
        {
            if (txt_ttm.Text != "" && nup_tslm.Value > 0)
            {
                string date = DateTime.Now.ToShortDateString();
                DataTable hd = TasmaMain.LietKeTuDo(
                "SELECT TOP 1 MaHoaDon FROM HOADON ORDER BY MaHoaDon DESC",
                TasmaMain.kn);
                Dictionary<string, object> dl = new Dictionary<string, object>();
                string mahd = (hd.Rows.Count > 0) ? 
                    hd.Rows[0]["MaHoaDon"].ToString().Trim() : "HD000";
                dl.Add("MAHOADON", TasmaMain.IDSinhTruong(mahd));
                dl.Add("NGAYLAPHD", TasmaMain.StrangeDate(date));
                dl.Add("MATV", (check_thetv.Checked) ? cb_thetv.SelectedValue : "NULL");
                dl.Add("TONGTIEN", txt_ttm.Text);
                //MessageBox.Show(TasmaMain.KT_ThemDuLieu("HOADON", dl));
                bool res = TasmaMain.ThemDuLieu("HOADON", dl, TasmaMain.kn);
                if (res)
                {
                    for (int i = 0; i < dataGV_cmon.RowCount; i++)
                    {
                        Dictionary<string, object> dlhd = new Dictionary<string, object>();
                        DataGridViewCellCollection data = dataGV_cmon.Rows[i].Cells;
                        dlhd.Add("MaHoaDon", dl["MAHOADON"]);
                        dlhd.Add("ID_DOUONG", data["ID"].Value);
                        dlhd.Add("DONGIA", data["DONGIA"].Value);
                        dlhd.Add("SOLUONG", data["SOLUONG"].Value);
                        TasmaMain.ThemDuLieu("CTHD", dlhd, TasmaMain.kn);
                    }
                    TasmaMain.HD = dl["MAHOADON"].ToString();
                    HD hoadon = new HD();
                    hoadon.Show();
                }
                else MessageBox.Show("Có lỗi xảy ra trong quá trình");
            }
            else MessageBox.Show("Bạn chưa đặt gì cả");
        }

        private void btn_qldu_Click(object sender, EventArgs e)
        {
            QLDU qldu = new QLDU();
            qldu.Show();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            unableText(false);
            DataGV_ThanhVien();
            btn_luu.Visible = false;
            btn_huy.Visible = false;
            btn_them_tv.Enabled = true;
        }

        // ========================================================
        private void Admin_Load(object sender, EventArgs e)
        {
            DataGV_ThanhVien();
            CB_LOAIMON();
            DataGV_NV();
            DataGV_Kho();
            cb_chucvu.Items.Add("Sáng");
            cb_chucvu.Items.Add("Chiều");
            cb_chucvu.Items.Add("Tối");
        }
        // Phần Nhân Viên
        // ========================================================
        public static bool gt;
        public void clearTextNV()
        {
            string nv = TasmaMain.LietKeTuDo(
                "SELECT TOP 1 MaNV FROM NHANVIEN ORDER BY MaNV DESC", 
                TasmaMain.kn).Rows[0]["MaNV"].ToString().Trim();
            txt_manv.Text = TasmaMain.IDSinhTruong(
                (dataGV_NV.Rows.Count > 0) ? nv : "NV000");
            txt_tennv.Text = "";
            dtp_ngaysinh.Text = "";
            dtp_giolv.Text = "";
            rad_nam.Checked = true;
        }
        public void visibleBtnNV(bool check)
        {
            btn_luunv.Visible = check;
            btn_huynv.Visible = check;
        }
        public void unableTextNV(bool check)
        {
            txt_tennv.Enabled = check;
            dtp_ngaysinh.Enabled = check;
            dtp_giolv.Enabled = check;
            cb_calv.Enabled = check;
            cb_chucvu.Enabled = check;
            gr_gioitinh.Enabled = check;
        }
        public void unableCBTN_NV(bool check)
        {
            btn_themnv.Enabled = check;
            btn_suanv.Enabled = check;
            btn_xoanv.Enabled = check;
            dataGV_NV.Enabled = check;
        }
        public void DataGV_NV()
        {
            DataTable dt = TasmaMain.LietKeDuLieu("dbo.LK_NHANVIEN()", TasmaMain.kn);
            dataGV_NV.DataSource = dt;
            cb_calv.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public void Info_NV()
        {
            if(dataGV_NV.Rows.Count > 0)
            {
                DataGridViewCellCollection info = dataGV_NV.CurrentRow.Cells;
                txt_manv.Text = info["MaNV"].Value.ToString();
                txt_tennv.Text = info["TenNV"].Value.ToString();
                cb_chucvu.DataSource = TasmaMain.LietKeDuLieu("CHUCVU", TasmaMain.kn);
                cb_chucvu.DisplayMember = "TenCV";
                cb_chucvu.ValueMember = "MaCV";
                cb_chucvu.SelectedItem = cb_chucvu.FindStringExact(
                    info["ChucVu"].Value.ToString());
                if (info["GioiTinh"].Value.ToString() == "Nam")
                    rad_nam.Checked = true;
                else rad_nu.Checked = true;
                dtp_ngaysinh.Value = DateTime.Parse(info["NgaySinh"].Value.ToString());
                dtp_giolv.Value = DateTime.Parse(info["GioLV"].Value.ToString());
                cb_calv.SelectedItem = info["CaLV"].Value.ToString();
            }
        }
    

        private void dataGV_NV_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Info_NV();
        }

        private void cb_calv_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cb_calv_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_themnv_Click(object sender, EventArgs e)
        {
            unableTextNV(true);
            clearTextNV();
            visibleBtnNV(true);
            unableCBTN_NV(false);
            btn_luunv.Text = "Thêm";
        }

        private void btn_luunv_Click(object sender, EventArgs e)
        {
            if(btn_luunv.Text == "Thêm")
            {
                Dictionary<string, object> dl = new Dictionary<string, object>();
                dl.Add("MaNV", txt_manv.Text);
                dl.Add("TenNV", txt_tennv.Text);
                dl.Add("GioiTinh", gt ? 1 : 0);
                dl.Add("NgaySinh", TasmaMain.StrangeDate(dtp_ngaysinh.Text));
                dl.Add("MaCV", cb_chucvu.SelectedValue);
                dl.Add("GioLV", dtp_giolv.Text);
                dl.Add("CaLV", cb_calv.Text);
                bool res = TasmaMain.ThemDuLieu("NHANVIEN", dl, TasmaMain.kn);
                if (res)
                {
                    MessageBox.Show("Đã thêm thành công nhân viên " + txt_tennv.Text);
                    DataGV_NV();
                    unableCBTN_NV(true);
                    visibleBtnNV(false);
                    unableTextNV(false);
                }
                else MessageBox.Show("Vui lòng kiểm tra lại dữ liệu vừa nhập");
            }
            else
            {
                Dictionary<string, object> dl = new Dictionary<string, object>();
                dl.Add("TenNV", txt_tennv.Text);
                dl.Add("GioiTinh", gt ? 1 : 0);
                dl.Add("NgaySinh", TasmaMain.StrangeDate(dtp_ngaysinh.Text));
                dl.Add("MaCV", cb_chucvu.SelectedValue);
                dl.Add("GioLV", dtp_giolv.Text);
                dl.Add("CaLV", cb_calv.Text);
                bool res = TasmaMain.SuaDuLieu("NHANVIEN", dl, 
                    "MaNV", txt_manv.Text.Trim(), TasmaMain.kn);
                if (res)
                {
                    MessageBox.Show("Đã sửa thành công thông tin nhân viên " +
                        txt_tennv.Text);
                    DataGV_NV();
                    unableCBTN_NV(true);
                    visibleBtnNV(false);
                    unableTextNV(false);
                }
                else MessageBox.Show("Vui lòng kiểm tra lại dữ liệu vừa nhập");
            }
        }

        private void rad_nam_CheckedChanged(object sender, EventArgs e)
        {
            gt = true;
        }

        private void rad_nu_CheckedChanged(object sender, EventArgs e)
        {
            gt = false;
        }

        private void btn_suanv_Click(object sender, EventArgs e)
        {
            btn_luunv.Text = "Lưu";
            visibleBtnNV(true);
            unableCBTN_NV(false);
            unableTextNV(true);
        }

        private void btn_huynv_Click(object sender, EventArgs e)
        {
            visibleBtnNV(false);
            unableCBTN_NV(true);
            unableTextNV(false);
            DataGV_NV();
            Info_NV();
        }

        private void btn_xoanv_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
             String.Format("Xác nhận xóa nhân viên {0}?", txt_tennv.Text), 
             "Xóa Nhân Viên", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bool res = TasmaMain.XoaDuLieu("NHANVIEN", "manv", txt_manv.Text,
                    TasmaMain.kn);
                if (res)
                {
                    MessageBox.Show("Đã xóa thành công nhân viên " + txt_tennv.Text);
                    DataGV_NV();
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Đã Hủy Thành Công");
            }
        }

        //======================================================================
        //Phần Kho
        public void DataGV_Kho()
        {
            dataGV_khoo.DataSource = TasmaMain.LietKeDuLieu("KHO", TasmaMain.kn);
        }
        public void infoKho()
        {
            if(dataGV_khoo.Rows.Count > 0)
            {
                DataGridViewCellCollection data = dataGV_khoo.CurrentRow.Cells;
                txt_sokho.Text = data["SoKho"].Value.ToString();
                txt_tenkho.Text = data["TenKho"].Value.ToString();
            }
        }
        public void unableTextKho(bool check)
        {
            txt_tenkho.Enabled = check;
        }
        public void clearTextKho()
        {
            DataTable Kh = TasmaMain.LietKeTuDo(
               "SELECT TOP 1 SoKho FROM KHO ORDER BY SoKho DESC", TasmaMain.kn);
            txt_sokho.Text = TasmaMain.IDSinhTruong(
                (Kh.Rows.Count > 0) ? Kh.Rows[0]["SoKho"].ToString().Trim() : "K000");
            txt_tenkho.Text = "";
        }
        public void unableButnKho(bool check)
        {
            btn_themkho.Enabled = check;
            btn_suakho.Enabled = check;
            btn_xoakho.Enabled = check;
            btn_xemkho.Enabled = check;
            dataGV_khoo.Enabled = check;
        }
        public void visibleButnKho(bool check)
        {
            btn_luukho.Visible = check;
            btn_huykho.Visible = check;
        }

        private void dataGV_khoo_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            infoKho();
        }

        private void btn_themkho_Click(object sender, EventArgs e)
        {
            clearTextKho();
            unableButnKho(false);
            visibleButnKho(true);
            unableTextKho(true);
            btn_luukho.Text = "Thêm";
        }

        private void btn_suakho_Click(object sender, EventArgs e)
        {
            btn_suakho.Text = "Lưu";
            unableButnKho(false);
            visibleButnKho(true);
            unableTextKho(true);
        }
        public bool destroyKho()
        {
            DataTable dt = TasmaMain.LietKeDuLieu("MATHANG", 
                "SoKho", txt_sokho.Text, TasmaMain.kn);
            bool res;
            if (dt.Rows.Count > 0)
            {
                res = TasmaMain.XoaDuLieu("MATHANG", "SoKho", txt_sokho.Text, TasmaMain.kn);
            }
            else res = true;
            return res;
        }
        private void btn_xoakho_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
           String.Format("Xác nhận xóa kho {0}?", txt_tenkho.Text),
           "Xóa Nhân Viên", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if(destroyKho())
                {
                    bool res = TasmaMain.XoaDuLieu("KHO", "SoKho", txt_sokho.Text,
                    TasmaMain.kn);
                    if (res)
                    {
                        MessageBox.Show("Đã xóa thành công kho " + txt_tenkho.Text);
                        DataGV_Kho();
                    }
                    else MessageBox.Show("Có lỗi xảy ra trong quá trình");
                } 
                else MessageBox.Show("Có lỗi xảy ra trong quá trình 1");
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Đã Hủy Thành Công");
            }
        }

        private void btn_luukho_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> dl = new Dictionary<string, object>();
            dl.Add("SoKho", txt_sokho.Text);
            dl.Add("TenKho", txt_tenkho.Text);
            if (btn_luukho.Text == "Thêm")
            {
                bool res = TasmaMain.ThemDuLieu("KHO", dl, TasmaMain.kn);
                if (res)
                {
                    MessageBox.Show("Đã thêm thành công kho " + txt_tenkho.Text);
                }
                else MessageBox.Show("Có lỗi gì đó đã xảy ra khi thêm");
            }
            else
            {
                bool res = TasmaMain.SuaDuLieu("KHO", dl, "SoKho", 
                    txt_sokho.Text, TasmaMain.kn);
                if (res)
                {
                    MessageBox.Show("Đã sửa thành công kho " + txt_tenkho.Text);
                }
                else MessageBox.Show("Có lỗi gì đó đã xảy ra khi sửa");
            }
            unableButnKho(true);
            visibleButnKho(false);
            unableTextKho(false);
            DataGV_Kho();
        }

        private void btn_huykho_Click(object sender, EventArgs e)
        {
            unableButnKho(true);
            visibleButnKho(false);
            unableTextKho(false);
            infoKho();
        }

        private void btn_xemkho_Click(object sender, EventArgs e)
        {
            TasmaMain.SK = txt_sokho.Text;
            MH mh = new MH();
            mh.Show();
        }

      
    }
}
