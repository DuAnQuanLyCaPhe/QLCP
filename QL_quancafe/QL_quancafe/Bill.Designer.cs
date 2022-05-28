
namespace QL_quancafe
{
    partial class Bill
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.btn_huy = new MaterialSkin.Controls.MaterialButton();
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.btn_inhd = new MaterialSkin.Controls.MaterialButton();
            this.reportV = new Microsoft.Reporting.WinForms.ReportViewer();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard5.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialCard2);
            this.materialCard1.Controls.Add(this.materialCard5);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(662, 64);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(189, 461);
            this.materialCard1.TabIndex = 1;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.btn_huy);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(14, 89);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(0);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(5);
            this.materialCard2.Size = new System.Drawing.Size(161, 52);
            this.materialCard2.TabIndex = 11;
            // 
            // btn_huy
            // 
            this.btn_huy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_huy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_huy.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_huy.Depth = 0;
            this.btn_huy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_huy.HighEmphasis = true;
            this.btn_huy.Icon = null;
            this.btn_huy.Location = new System.Drawing.Point(5, 5);
            this.btn_huy.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_huy.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_huy.Size = new System.Drawing.Size(151, 42);
            this.btn_huy.TabIndex = 2;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_huy.UseAccentColor = false;
            this.btn_huy.UseVisualStyleBackColor = true;
            // 
            // materialCard5
            // 
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.Controls.Add(this.btn_inhd);
            this.materialCard5.Depth = 0;
            this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard5.Location = new System.Drawing.Point(14, 14);
            this.materialCard5.Margin = new System.Windows.Forms.Padding(0);
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            this.materialCard5.Padding = new System.Windows.Forms.Padding(5);
            this.materialCard5.Size = new System.Drawing.Size(161, 52);
            this.materialCard5.TabIndex = 10;
            // 
            // btn_inhd
            // 
            this.btn_inhd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_inhd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inhd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_inhd.Depth = 0;
            this.btn_inhd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_inhd.HighEmphasis = true;
            this.btn_inhd.Icon = null;
            this.btn_inhd.Location = new System.Drawing.Point(5, 5);
            this.btn_inhd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_inhd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_inhd.Name = "btn_inhd";
            this.btn_inhd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_inhd.Size = new System.Drawing.Size(151, 42);
            this.btn_inhd.TabIndex = 2;
            this.btn_inhd.Text = "In Hóa Đơn";
            this.btn_inhd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_inhd.UseAccentColor = false;
            this.btn_inhd.UseVisualStyleBackColor = true;
            this.btn_inhd.Click += new System.EventHandler(this.btn_inhd_Click);
            // 
            // reportV
            // 
            this.reportV.Dock = System.Windows.Forms.DockStyle.Left;
            reportDataSource1.Name = "DataBill";
            reportDataSource1.Value = null;
            this.reportV.LocalReport.DataSources.Add(reportDataSource1);
            this.reportV.Location = new System.Drawing.Point(3, 64);
            this.reportV.Name = "reportV";
            this.reportV.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.reportV.ServerReport.BearerToken = null;
            this.reportV.Size = new System.Drawing.Size(659, 461);
            this.reportV.TabIndex = 0;
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 528);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.reportV);
            this.Name = "Bill";
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.Bill_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialCard5.ResumeLayout(false);
            this.materialCard5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialButton btn_huy;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialButton btn_inhd;
        private Microsoft.Reporting.WinForms.ReportViewer reportV;
    }
}