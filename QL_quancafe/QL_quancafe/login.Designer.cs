namespace QL_quancafe
{
    partial class login
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
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_password = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_user = new MaterialSkin.Controls.MaterialTextBox();
            this.btn_thoat = new MaterialSkin.Controls.MaterialButton();
            this.btn_login = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(25, 178);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(70, 19);
            this.materialLabel2.TabIndex = 25;
            this.materialLabel2.Text = "Mật Khẩu";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(25, 79);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(105, 19);
            this.materialLabel1.TabIndex = 24;
            this.materialLabel1.Text = "Tên Tài Khoản";
            // 
            // txt_password
            // 
            this.txt_password.AnimateReadOnly = false;
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Depth = 0;
            this.txt_password.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_password.LeadingIcon = null;
            this.txt_password.Location = new System.Drawing.Point(30, 209);
            this.txt_password.Margin = new System.Windows.Forms.Padding(2);
            this.txt_password.MaxLength = 50;
            this.txt_password.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_password.Multiline = false;
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(387, 50);
            this.txt_password.TabIndex = 23;
            this.txt_password.Text = "";
            this.txt_password.TrailingIcon = null;
            // 
            // txt_user
            // 
            this.txt_user.AnimateReadOnly = false;
            this.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_user.Depth = 0;
            this.txt_user.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_user.LeadingIcon = null;
            this.txt_user.Location = new System.Drawing.Point(28, 112);
            this.txt_user.Margin = new System.Windows.Forms.Padding(2);
            this.txt_user.MaxLength = 50;
            this.txt_user.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_user.Multiline = false;
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(387, 50);
            this.txt_user.TabIndex = 22;
            this.txt_user.Text = "";
            this.txt_user.TrailingIcon = null;
            // 
            // btn_thoat
            // 
            this.btn_thoat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_thoat.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_thoat.Depth = 0;
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.HighEmphasis = true;
            this.btn_thoat.Icon = null;
            this.btn_thoat.Location = new System.Drawing.Point(348, 282);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_thoat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_thoat.Size = new System.Drawing.Size(69, 36);
            this.btn_thoat.TabIndex = 21;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_thoat.UseAccentColor = false;
            this.btn_thoat.UseVisualStyleBackColor = true;
            // 
            // btn_login
            // 
            this.btn_login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_login.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_login.Depth = 0;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.HighEmphasis = true;
            this.btn_login.Icon = null;
            this.btn_login.Location = new System.Drawing.Point(213, 282);
            this.btn_login.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_login.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_login.Name = "btn_login";
            this.btn_login.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_login.Size = new System.Drawing.Size(105, 36);
            this.btn_login.TabIndex = 20;
            this.btn_login.Text = "Đăng nhập";
            this.btn_login.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_login.UseAccentColor = false;
            this.btn_login.UseVisualStyleBackColor = true;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 339);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_login);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "login";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txt_password;
        private MaterialSkin.Controls.MaterialTextBox txt_user;
        private MaterialSkin.Controls.MaterialButton btn_thoat;
        private MaterialSkin.Controls.MaterialButton btn_login;
    }
}