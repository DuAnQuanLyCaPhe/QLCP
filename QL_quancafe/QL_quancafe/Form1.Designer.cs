
namespace QL_quancafe
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_xembill = new System.Windows.Forms.Button();
            this.dtp_bill_toi = new System.Windows.Forms.DateTimePicker();
            this.dtp_bill_tu = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dgv_blii = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.nup_gia_food = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.cb_danhmuc_food = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txt_tenmon_food = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_id_food = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_tim_food = new System.Windows.Forms.TextBox();
            this.btn_tim_food = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_xem_food = new System.Windows.Forms.Button();
            this.btn_sua_food = new System.Windows.Forms.Button();
            this.btn_xoa_food = new System.Windows.Forms.Button();
            this.btn_them_food = new System.Windows.Forms.Button();
            this.dgv_food = new System.Windows.Forms.DataGridView();
            this.materialTabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_blii)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_gia_food)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_food)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "guest.png");
            this.imageList1.Images.SetKeyName(1, "coffee.png");
            this.imageList1.Images.SetKeyName(2, "Icon-clock.png");
            this.imageList1.Images.SetKeyName(3, "Icon-Kho.png");
            this.imageList1.Images.SetKeyName(4, "dorla-icon.png");
            this.imageList1.Images.SetKeyName(5, "user-icon.png");
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Controls.Add(this.tabPage5);
            this.materialTabControl1.Controls.Add(this.tabPage6);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(8, 82);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1051, 609);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.ImageKey = "guest.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1043, 566);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thành Viên";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.dgv_food);
            this.tabPage2.ImageKey = "coffee.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1043, 566);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Món";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.ImageKey = "Icon-clock.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1043, 566);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ca Làm Việc";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.ImageKey = "Icon-Kho.png";
            this.tabPage4.Location = new System.Drawing.Point(4, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1043, 566);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Kho";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.flowLayoutPanel1);
            this.tabPage5.Controls.Add(this.panel1);
            this.tabPage5.ImageKey = "dorla-icon.png";
            this.tabPage5.Location = new System.Drawing.Point(4, 39);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1043, 566);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Doanh Thu";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.ImageKey = "user-icon.png";
            this.tabPage6.Location = new System.Drawing.Point(4, 39);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1043, 566);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Nhân Viên";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_xembill);
            this.panel1.Controls.Add(this.dtp_bill_toi);
            this.panel1.Controls.Add(this.dtp_bill_tu);
            this.panel1.Location = new System.Drawing.Point(6, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 30);
            this.panel1.TabIndex = 1;
            // 
            // btn_xembill
            // 
            this.btn_xembill.Location = new System.Drawing.Point(405, 4);
            this.btn_xembill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xembill.Name = "btn_xembill";
            this.btn_xembill.Size = new System.Drawing.Size(194, 23);
            this.btn_xembill.TabIndex = 1;
            this.btn_xembill.Text = "Thống kê";
            this.btn_xembill.UseVisualStyleBackColor = true;
            // 
            // dtp_bill_toi
            // 
            this.dtp_bill_toi.Location = new System.Drawing.Point(795, 3);
            this.dtp_bill_toi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_bill_toi.Name = "dtp_bill_toi";
            this.dtp_bill_toi.Size = new System.Drawing.Size(233, 22);
            this.dtp_bill_toi.TabIndex = 1;
            // 
            // dtp_bill_tu
            // 
            this.dtp_bill_tu.Location = new System.Drawing.Point(3, 4);
            this.dtp_bill_tu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_bill_tu.Name = "dtp_bill_tu";
            this.dtp_bill_tu.Size = new System.Drawing.Size(229, 22);
            this.dtp_bill_tu.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dgv_blii);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 39);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1025, 522);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // dgv_blii
            // 
            this.dgv_blii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_blii.Location = new System.Drawing.Point(3, 2);
            this.dgv_blii.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_blii.Name = "dgv_blii";
            this.dgv_blii.RowHeadersWidth = 51;
            this.dgv_blii.RowTemplate.Height = 24;
            this.dgv_blii.Size = new System.Drawing.Size(1022, 520);
            this.dgv_blii.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Location = new System.Drawing.Point(524, 112);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(512, 448);
            this.panel4.TabIndex = 7;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.nup_gia_food);
            this.panel9.Controls.Add(this.label4);
            this.panel9.Location = new System.Drawing.Point(3, 146);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(504, 42);
            this.panel9.TabIndex = 9;
            // 
            // nup_gia_food
            // 
            this.nup_gia_food.Location = new System.Drawing.Point(147, 11);
            this.nup_gia_food.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nup_gia_food.Name = "nup_gia_food";
            this.nup_gia_food.Size = new System.Drawing.Size(305, 22);
            this.nup_gia_food.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá :";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.cb_danhmuc_food);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Location = new System.Drawing.Point(3, 98);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(504, 42);
            this.panel8.TabIndex = 8;
            // 
            // cb_danhmuc_food
            // 
            this.cb_danhmuc_food.FormattingEnabled = true;
            this.cb_danhmuc_food.Location = new System.Drawing.Point(147, 9);
            this.cb_danhmuc_food.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_danhmuc_food.Name = "cb_danhmuc_food";
            this.cb_danhmuc_food.Size = new System.Drawing.Size(305, 24);
            this.cb_danhmuc_food.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh mục:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txt_tenmon_food);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Location = new System.Drawing.Point(3, 50);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(504, 42);
            this.panel7.TabIndex = 7;
            // 
            // txt_tenmon_food
            // 
            this.txt_tenmon_food.Location = new System.Drawing.Point(147, 10);
            this.txt_tenmon_food.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tenmon_food.Name = "txt_tenmon_food";
            this.txt_tenmon_food.ReadOnly = true;
            this.txt_tenmon_food.Size = new System.Drawing.Size(305, 22);
            this.txt_tenmon_food.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên món :";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txt_id_food);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Location = new System.Drawing.Point(3, 2);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(504, 42);
            this.panel6.TabIndex = 6;
            // 
            // txt_id_food
            // 
            this.txt_id_food.Location = new System.Drawing.Point(147, 10);
            this.txt_id_food.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_id_food.Name = "txt_id_food";
            this.txt_id_food.ReadOnly = true;
            this.txt_id_food.Size = new System.Drawing.Size(305, 22);
            this.txt_id_food.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_tim_food);
            this.panel3.Controls.Add(this.btn_tim_food);
            this.panel3.Location = new System.Drawing.Point(527, 6);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(504, 100);
            this.panel3.TabIndex = 6;
            // 
            // txt_tim_food
            // 
            this.txt_tim_food.Location = new System.Drawing.Point(12, 13);
            this.txt_tim_food.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tim_food.Multiline = true;
            this.txt_tim_food.Name = "txt_tim_food";
            this.txt_tim_food.Size = new System.Drawing.Size(383, 72);
            this.txt_tim_food.TabIndex = 5;
            // 
            // btn_tim_food
            // 
            this.btn_tim_food.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tim_food.Location = new System.Drawing.Point(401, 2);
            this.btn_tim_food.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_tim_food.Name = "btn_tim_food";
            this.btn_tim_food.Size = new System.Drawing.Size(100, 94);
            this.btn_tim_food.TabIndex = 4;
            this.btn_tim_food.Text = "Tìm";
            this.btn_tim_food.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_xem_food);
            this.panel2.Controls.Add(this.btn_sua_food);
            this.panel2.Controls.Add(this.btn_xoa_food);
            this.panel2.Controls.Add(this.btn_them_food);
            this.panel2.Location = new System.Drawing.Point(7, 6);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(511, 100);
            this.panel2.TabIndex = 4;
            // 
            // btn_xem_food
            // 
            this.btn_xem_food.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xem_food.Location = new System.Drawing.Point(408, 2);
            this.btn_xem_food.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xem_food.Name = "btn_xem_food";
            this.btn_xem_food.Size = new System.Drawing.Size(100, 94);
            this.btn_xem_food.TabIndex = 3;
            this.btn_xem_food.Text = "Xem";
            this.btn_xem_food.UseVisualStyleBackColor = true;
            // 
            // btn_sua_food
            // 
            this.btn_sua_food.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua_food.Location = new System.Drawing.Point(268, 0);
            this.btn_sua_food.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sua_food.Name = "btn_sua_food";
            this.btn_sua_food.Size = new System.Drawing.Size(100, 94);
            this.btn_sua_food.TabIndex = 2;
            this.btn_sua_food.Text = "Sửa";
            this.btn_sua_food.UseVisualStyleBackColor = true;
            // 
            // btn_xoa_food
            // 
            this.btn_xoa_food.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa_food.Location = new System.Drawing.Point(132, 2);
            this.btn_xoa_food.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa_food.Name = "btn_xoa_food";
            this.btn_xoa_food.Size = new System.Drawing.Size(100, 94);
            this.btn_xoa_food.TabIndex = 1;
            this.btn_xoa_food.Text = "Xóa";
            this.btn_xoa_food.UseVisualStyleBackColor = true;
            // 
            // btn_them_food
            // 
            this.btn_them_food.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them_food.Location = new System.Drawing.Point(3, 2);
            this.btn_them_food.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them_food.Name = "btn_them_food";
            this.btn_them_food.Size = new System.Drawing.Size(100, 94);
            this.btn_them_food.TabIndex = 0;
            this.btn_them_food.Text = "Thêm";
            this.btn_them_food.UseVisualStyleBackColor = true;
            // 
            // dgv_food
            // 
            this.dgv_food.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_food.Location = new System.Drawing.Point(5, 112);
            this.dgv_food.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_food.Name = "dgv_food";
            this.dgv_food.RowHeadersWidth = 51;
            this.dgv_food.RowTemplate.Height = 24;
            this.dgv_food.Size = new System.Drawing.Size(513, 448);
            this.dgv_food.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 699);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_blii)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_gia_food)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_food)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_xembill;
        private System.Windows.Forms.DateTimePicker dtp_bill_toi;
        private System.Windows.Forms.DateTimePicker dtp_bill_tu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dgv_blii;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.NumericUpDown nup_gia_food;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ComboBox cb_danhmuc_food;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txt_tenmon_food;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txt_id_food;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_tim_food;
        private System.Windows.Forms.Button btn_tim_food;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_xem_food;
        private System.Windows.Forms.Button btn_sua_food;
        private System.Windows.Forms.Button btn_xoa_food;
        private System.Windows.Forms.Button btn_them_food;
        private System.Windows.Forms.DataGridView dgv_food;
    }
}