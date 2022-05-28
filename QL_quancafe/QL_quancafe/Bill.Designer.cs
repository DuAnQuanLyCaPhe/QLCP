
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QL_COFFEEDataSet = new QL_quancafe.QL_COFFEEDataSet();
            this.DOUONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DOUONGTableAdapter = new QL_quancafe.QL_COFFEEDataSetTableAdapters.DOUONGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QL_COFFEEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DOUONGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataBill";
            reportDataSource1.Value = this.DOUONGBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QL_quancafe.reportB.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(483, 392);
            this.reportViewer1.TabIndex = 0;
            // 
            // QL_COFFEEDataSet
            // 
            this.QL_COFFEEDataSet.DataSetName = "QL_COFFEEDataSet";
            this.QL_COFFEEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DOUONGBindingSource
            // 
            this.DOUONGBindingSource.DataMember = "DOUONG";
            this.DOUONGBindingSource.DataSource = this.QL_COFFEEDataSet;
            // 
            // DOUONGTableAdapter
            // 
            this.DOUONGTableAdapter.ClearBeforeFill = true;
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Bill";
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.Bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QL_COFFEEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DOUONGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DOUONGBindingSource;
        private QL_COFFEEDataSet QL_COFFEEDataSet;
        private QL_COFFEEDataSetTableAdapters.DOUONGTableAdapter DOUONGTableAdapter;
    }
}