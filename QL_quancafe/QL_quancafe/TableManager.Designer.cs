namespace QL_quancafe
{
    partial class TableManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.nmFoodCount = new System.Windows.Forms.NumericUpDown();
            this.btn_AddFood = new System.Windows.Forms.Button();
            this.cb_Food = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cb_Category = new System.Windows.Forms.ComboBox();
            this.txb_TotalPrice = new System.Windows.Forms.TextBox();
            this.cb_SwitchTable = new System.Windows.Forms.ComboBox();
            this.btn_SwitchTable = new System.Windows.Forms.Button();
            this.nm_DisCount = new System.Windows.Forms.NumericUpDown();
            this.btn_CheckOut = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsv_Bill = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.thêmMónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.flpTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_DisCount)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.Controls.Add(this.flowLayoutPanel1);
            this.flpTable.Location = new System.Drawing.Point(7, 96);
            this.flpTable.Margin = new System.Windows.Forms.Padding(4);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(572, 533);
            this.flpTable.TabIndex = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(411, 0);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // nmFoodCount
            // 
            this.nmFoodCount.Location = new System.Drawing.Point(395, 23);
            this.nmFoodCount.Margin = new System.Windows.Forms.Padding(4);
            this.nmFoodCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmFoodCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmFoodCount.Name = "nmFoodCount";
            this.nmFoodCount.Size = new System.Drawing.Size(52, 22);
            this.nmFoodCount.TabIndex = 3;
            this.nmFoodCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_AddFood
            // 
            this.btn_AddFood.Location = new System.Drawing.Point(285, 4);
            this.btn_AddFood.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AddFood.Name = "btn_AddFood";
            this.btn_AddFood.Size = new System.Drawing.Size(100, 57);
            this.btn_AddFood.TabIndex = 2;
            this.btn_AddFood.Text = "Thêm món";
            this.btn_AddFood.UseVisualStyleBackColor = true;
            this.btn_AddFood.Click += new System.EventHandler(this.btn_AddFood_Click);
            // 
            // cb_Food
            // 
            this.cb_Food.FormattingEnabled = true;
            this.cb_Food.Location = new System.Drawing.Point(4, 34);
            this.cb_Food.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Food.Name = "cb_Food";
            this.cb_Food.Size = new System.Drawing.Size(272, 24);
            this.cb_Food.TabIndex = 1;
            this.cb_Food.SelectedIndexChanged += new System.EventHandler(this.cb_Food_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nmFoodCount);
            this.panel4.Controls.Add(this.btn_AddFood);
            this.panel4.Controls.Add(this.cb_Food);
            this.panel4.Controls.Add(this.cb_Category);
            this.panel4.Location = new System.Drawing.Point(586, 497);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(451, 64);
            this.panel4.TabIndex = 9;
            // 
            // cb_Category
            // 
            this.cb_Category.FormattingEnabled = true;
            this.cb_Category.Location = new System.Drawing.Point(4, 4);
            this.cb_Category.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Category.Name = "cb_Category";
            this.cb_Category.Size = new System.Drawing.Size(272, 24);
            this.cb_Category.TabIndex = 0;
            this.cb_Category.SelectedIndexChanged += new System.EventHandler(this.cb_Category_SelectedIndexChanged);
            // 
            // txb_TotalPrice
            // 
            this.txb_TotalPrice.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txb_TotalPrice.ForeColor = System.Drawing.Color.OrangeRed;
            this.txb_TotalPrice.Location = new System.Drawing.Point(219, 4);
            this.txb_TotalPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txb_TotalPrice.Name = "txb_TotalPrice";
            this.txb_TotalPrice.ReadOnly = true;
            this.txb_TotalPrice.Size = new System.Drawing.Size(119, 29);
            this.txb_TotalPrice.TabIndex = 7;
            this.txb_TotalPrice.Text = "0";
            this.txb_TotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cb_SwitchTable
            // 
            this.cb_SwitchTable.FormattingEnabled = true;
            this.cb_SwitchTable.Location = new System.Drawing.Point(4, 34);
            this.cb_SwitchTable.Margin = new System.Windows.Forms.Padding(4);
            this.cb_SwitchTable.Name = "cb_SwitchTable";
            this.cb_SwitchTable.Size = new System.Drawing.Size(99, 24);
            this.cb_SwitchTable.TabIndex = 6;
            // 
            // btn_SwitchTable
            // 
            this.btn_SwitchTable.Location = new System.Drawing.Point(4, 4);
            this.btn_SwitchTable.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SwitchTable.Name = "btn_SwitchTable";
            this.btn_SwitchTable.Size = new System.Drawing.Size(100, 32);
            this.btn_SwitchTable.TabIndex = 5;
            this.btn_SwitchTable.Text = "Chuyển bàn";
            this.btn_SwitchTable.UseVisualStyleBackColor = true;
            // 
            // nm_DisCount
            // 
            this.nm_DisCount.Location = new System.Drawing.Point(219, 36);
            this.nm_DisCount.Margin = new System.Windows.Forms.Padding(4);
            this.nm_DisCount.Name = "nm_DisCount";
            this.nm_DisCount.Size = new System.Drawing.Size(120, 22);
            this.nm_DisCount.TabIndex = 4;
            this.nm_DisCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_CheckOut
            // 
            this.btn_CheckOut.Location = new System.Drawing.Point(347, 4);
            this.btn_CheckOut.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CheckOut.Name = "btn_CheckOut";
            this.btn_CheckOut.Size = new System.Drawing.Size(100, 57);
            this.btn_CheckOut.TabIndex = 3;
            this.btn_CheckOut.Text = "Thanh toán";
            this.btn_CheckOut.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txb_TotalPrice);
            this.panel3.Controls.Add(this.cb_SwitchTable);
            this.panel3.Controls.Add(this.btn_SwitchTable);
            this.panel3.Controls.Add(this.nm_DisCount);
            this.panel3.Controls.Add(this.btn_CheckOut);
            this.panel3.Location = new System.Drawing.Point(582, 565);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(455, 64);
            this.panel3.TabIndex = 8;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 81;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 54;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 133;
            // 
            // lsv_Bill
            // 
            this.lsv_Bill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsv_Bill.GridLines = true;
            this.lsv_Bill.HideSelection = false;
            this.lsv_Bill.Location = new System.Drawing.Point(4, 4);
            this.lsv_Bill.Margin = new System.Windows.Forms.Padding(4);
            this.lsv_Bill.Name = "lsv_Bill";
            this.lsv_Bill.Size = new System.Drawing.Size(441, 379);
            this.lsv_Bill.TabIndex = 0;
            this.lsv_Bill.UseCompatibleStateImageBehavior = false;
            this.lsv_Bill.View = System.Windows.Forms.View.Details;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsv_Bill);
            this.panel2.Location = new System.Drawing.Point(586, 102);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(451, 388);
            this.panel2.TabIndex = 7;
            // 
            // thêmMónToolStripMenuItem
            // 
            this.thêmMónToolStripMenuItem.Name = "thêmMónToolStripMenuItem";
            this.thêmMónToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.thêmMónToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.thêmMónToolStripMenuItem.Text = "Thêm món";
            // 
            // thanhToánToolStripMenuItem
            // 
            this.thanhToánToolStripMenuItem.Name = "thanhToánToolStripMenuItem";
            this.thanhToánToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.thanhToánToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.thanhToánToolStripMenuItem.Text = "Thanh toán";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thanhToánToolStripMenuItem,
            this.thêmMónToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 64);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1038, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 635);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Name = "TableManager";
            this.Text = "TableManager";
            this.Load += new System.EventHandler(this.TableManager_Load);
            this.flpTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nm_DisCount)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.NumericUpDown nmFoodCount;
        private System.Windows.Forms.Button btn_AddFood;
        private System.Windows.Forms.ComboBox cb_Food;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cb_Category;
        private System.Windows.Forms.TextBox txb_TotalPrice;
        private System.Windows.Forms.ComboBox cb_SwitchTable;
        private System.Windows.Forms.Button btn_SwitchTable;
        private System.Windows.Forms.NumericUpDown nm_DisCount;
        private System.Windows.Forms.Button btn_CheckOut;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView lsv_Bill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem thêmMónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thanhToánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}