namespace ReportingRemoteDB.Viewers
{
    partial class FormResumenCtaReportViewer
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.oLAPcontableDataSet = new ReportingRemoteDB.OLAPcontableDataSet();
            this.oLAPCONTABLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oLAP_CONTABLETableAdapter = new ReportingRemoteDB.OLAPcontableDataSetTableAdapters.OLAP_CONTABLETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.oLAPcontableDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oLAPCONTABLEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "OLAPcontable";
            reportDataSource2.Value = this.oLAPCONTABLEBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportingRemoteDB.Reports.ResumenCuentaReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(284, 261);
            this.reportViewer1.TabIndex = 0;
            // 
            // oLAPcontableDataSet
            // 
            this.oLAPcontableDataSet.DataSetName = "OLAPcontableDataSet";
            this.oLAPcontableDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oLAPCONTABLEBindingSource
            // 
            this.oLAPCONTABLEBindingSource.DataMember = "OLAP_CONTABLE";
            this.oLAPCONTABLEBindingSource.DataSource = this.oLAPcontableDataSet;
            // 
            // oLAP_CONTABLETableAdapter
            // 
            this.oLAP_CONTABLETableAdapter.ClearBeforeFill = true;
            // 
            // FormResumenCtaReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormResumenCtaReportViewer";
            this.Text = "FormResumenCtaReportViewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormResumenCtaReportViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oLAPcontableDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oLAPCONTABLEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private OLAPcontableDataSet oLAPcontableDataSet;
        private System.Windows.Forms.BindingSource oLAPCONTABLEBindingSource;
        private OLAPcontableDataSetTableAdapters.OLAP_CONTABLETableAdapter oLAP_CONTABLETableAdapter;
    }
}