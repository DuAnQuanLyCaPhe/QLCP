namespace QL_quancafe
{
    partial class AccountProfile
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txbDisplayName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txbPassWord = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txbNewPass = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txbReEnterPass = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(139, 10);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.ReadOnly = true;
            this.txbUserName.Size = new System.Drawing.Size(252, 20);
            this.txbUserName.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbUserName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(5, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 44);
            this.panel2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên hiển thị:";
            // 
            // txbDisplayName
            // 
            this.txbDisplayName.Location = new System.Drawing.Point(139, 10);
            this.txbDisplayName.Name = "txbDisplayName";
            this.txbDisplayName.Size = new System.Drawing.Size(252, 20);
            this.txbDisplayName.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbDisplayName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(5, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 44);
            this.panel1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật khẩu:";
            // 
            // txbPassWord
            // 
            this.txbPassWord.Location = new System.Drawing.Point(139, 10);
            this.txbPassWord.Name = "txbPassWord";
            this.txbPassWord.Size = new System.Drawing.Size(252, 20);
            this.txbPassWord.TabIndex = 1;
            this.txbPassWord.UseSystemPasswordChar = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbPassWord);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(5, 173);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(394, 44);
            this.panel3.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mật khẩu mới:";
            // 
            // txbNewPass
            // 
            this.txbNewPass.Location = new System.Drawing.Point(139, 10);
            this.txbNewPass.Name = "txbNewPass";
            this.txbNewPass.Size = new System.Drawing.Size(252, 20);
            this.txbNewPass.TabIndex = 1;
            this.txbNewPass.UseSystemPasswordChar = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txbNewPass);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(5, 223);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(394, 44);
            this.panel4.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nhập lại:";
            // 
            // txbReEnterPass
            // 
            this.txbReEnterPass.Location = new System.Drawing.Point(139, 10);
            this.txbReEnterPass.Name = "txbReEnterPass";
            this.txbReEnterPass.Size = new System.Drawing.Size(252, 20);
            this.txbReEnterPass.TabIndex = 1;
            this.txbReEnterPass.UseSystemPasswordChar = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txbReEnterPass);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(5, 273);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(394, 44);
            this.panel5.TabIndex = 12;
            // 
            // btn_Exit
            // 
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new System.Drawing.Point(321, 323);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 14;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(240, 323);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 13;
            this.btn_Update.Text = "Cập nhật";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // AccountProfile
            // 
            this.AcceptButton = this.btn_Update;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Exit;
            this.ClientSize = new System.Drawing.Size(502, 530);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AccountProfile";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.Text = "AccountProfile";
            this.Load += new System.EventHandler(this.AccountProfile_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbDisplayName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbPassWord;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbNewPass;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbReEnterPass;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Update;
    }
}