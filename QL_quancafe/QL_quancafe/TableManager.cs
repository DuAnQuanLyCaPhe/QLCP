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
    public partial class TableManager : MaterialForm
    {
        public TableManager()
        {
            InitializeComponent();


            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountProfile f = new AccountProfile();
            f.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin f = new Admin();
            f.ShowDialog();
        }

        public void active_cbid_food()
        {
            cb_Category.DataSource = Cls_Food.Select_idfood();
            cb_Category.ValueMember = "id";
            cb_Category.DisplayMember = "id";
        }

        //public void gia()
        //{
        //    cb_Category.DataSource = Cls_Food.Select_food();
        //    cb_Category.ValueMember = "price";
        //    cb_Category.DisplayMember = "price";
        //}
        public void active_cb_food()
        {
            if (cb_Category.Text != "System.Data.DataRowView")
            {
                cb_Food.DataSource = Cls_Food.find_Food(cb_Category.Text);
                cb_Food.ValueMember = "name";
                cb_Food.DisplayMember = "name";
            }
        }

        private void TableManager_Load(object sender, EventArgs e)
        {
            active_cbid_food();
            active_cb_food(); 
        }

        private void cb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            active_cb_food();
        }

        private void cb_Food_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_AddFood_Click(object sender, EventArgs e)
        {
            int soluong = Convert.ToInt16(nmFoodCount.Value);
            int giathanh = Convert.ToInt32(Cls_Food.find_Food(cb_Category.Text).Rows[0]["price"]);
            //int giathanh = Convert.ToInt32(DataBindings.Add("text", Cls_Food.Select_food(), "price"));
            int thanhtien = soluong * giathanh;
            ListViewItem lvi = new ListViewItem();
            string[] row = { cb_Food.Text, soluong.ToString() ,giathanh.ToString(), thanhtien.ToString() };
            var listViewItem = new ListViewItem(row);
            lsv_Bill.Items.Add(listViewItem);
        }
    }
}
