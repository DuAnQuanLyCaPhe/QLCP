
namespace QL_quancafe
{
    partial class MATHANG
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_mahang = new System.Windows.Forms.TextBox();
            this.txt_tenhang = new System.Windows.Forms.TextBox();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.nup_soluong = new System.Windows.Forms.NumericUpDown();
            this.dataGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nup_soluong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(19, 87);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(66, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Mã Hàng";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(19, 122);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(70, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Tên Hàng";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(19, 157);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(70, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Số Lượng";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(19, 191);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(58, 19);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Đơn Giá";
            // 
            // txt_mahang
            // 
            this.txt_mahang.Enabled = false;
            this.txt_mahang.Location = new System.Drawing.Point(122, 87);
            this.txt_mahang.Name = "txt_mahang";
            this.txt_mahang.Size = new System.Drawing.Size(257, 20);
            this.txt_mahang.TabIndex = 4;
            // 
            // txt_tenhang
            // 
            this.txt_tenhang.Enabled = false;
            this.txt_tenhang.Location = new System.Drawing.Point(122, 122);
            this.txt_tenhang.Name = "txt_tenhang";
            this.txt_tenhang.Size = new System.Drawing.Size(257, 20);
            this.txt_tenhang.TabIndex = 5;
            // 
            // txt_dongia
            // 
            this.txt_dongia.Enabled = false;
            this.txt_dongia.Location = new System.Drawing.Point(122, 191);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(257, 20);
            this.txt_dongia.TabIndex = 7;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(391, 85);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 9;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(391, 122);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 10;
            this.btn_sua.Text = "Sửa ";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(391, 157);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 11;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Enabled = false;
            this.btn_luu.Location = new System.Drawing.Point(22, 229);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(75, 23);
            this.btn_luu.TabIndex = 12;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Visible = false;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.Enabled = false;
            this.btn_huy.Location = new System.Drawing.Point(122, 229);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(75, 23);
            this.btn_huy.TabIndex = 13;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Visible = false;
            // 
            // nup_soluong
            // 
            this.nup_soluong.Enabled = false;
            this.nup_soluong.Location = new System.Drawing.Point(122, 157);
            this.nup_soluong.Name = "nup_soluong";
            this.nup_soluong.ReadOnly = true;
            this.nup_soluong.Size = new System.Drawing.Size(98, 20);
            this.nup_soluong.TabIndex = 14;
            // 
            // dataGV
            // 
            this.dataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV.Location = new System.Drawing.Point(22, 280);
            this.dataGV.Name = "dataGV";
            this.dataGV.Size = new System.Drawing.Size(240, 150);
            this.dataGV.TabIndex = 15;
            // 
            // MATHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 527);
            this.Controls.Add(this.dataGV);
            this.Controls.Add(this.nup_soluong);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.txt_dongia);
            this.Controls.Add(this.txt_tenhang);
            this.Controls.Add(this.txt_mahang);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "MATHANG";
            this.Text = "Mặt Hàng Thuộc Kho";
            this.Load += new System.EventHandler(this.MATHANG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nup_soluong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.TextBox txt_mahang;
        private System.Windows.Forms.TextBox txt_tenhang;
        private System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.NumericUpDown nup_soluong;
        private System.Windows.Forms.DataGridView dataGV;
    }
}