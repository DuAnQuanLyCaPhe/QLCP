using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using System.Data.SqlClient;
using TasmaControl;

namespace QL_quancafe
{
    public partial class pn : Form
    {
        public pn()
        {
            InitializeComponent();
        }
        public void luu()
        {
            Dictionary<string, object> dl = new Dictionary<string, object>();
            TasmaMain.ThemDuLieu("PHIEUNHAP", dl, TasmaMain.kn);
            for (int i = 0; i < dgv_chitiet.RowCount - 1; i++)
            {
                string mahang, mancc;
                int dongia, soluong, thanhtien;
                mahang = Convert.ToString(dgv_chitiet.Rows[i].Cells[0].Value.ToString());
                mancc = Convert.ToString(dgv_chitiet.Rows[i].Cells[2].Value.ToString());
                soluong = Convert.ToInt32(dgv_chitiet.Rows[i].Cells[3].Value);
                dongia = Convert.ToInt32(dgv_chitiet.Rows[i].Cells[4].Value);
                thanhtien = Convert.ToInt32(dgv_chitiet.Rows[i].Cells[5].Value);
                Cls_CTPN.Insert_CTPN(txt_sopn.Text, mahang, mancc, soluong, dongia, thanhtien);
            }
            try
            {
                MessageBox.Show("Lưu thông tin phiếu thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void xoa_dong()
        {
            foreach (DataGridViewRow item in this.dgv_chitiet.SelectedRows)
            {
                dgv_chitiet.Rows.RemoveAt(item.Index);
            }
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void pn_Load(object sender, EventArgs e)
        {
            // wtf?? nhập hàng cà phê mà cũng có nhà cung cấp luôn? thuế luôn? kéo qua chưa có sửa
        }
    }
}
