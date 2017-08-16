namespace ReportingRemoteDB.Viewers
{
    partial class FormCentAprReportViewer
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
            this.cENTROSAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bASCSDataSet = new ReportingRemoteDB.BASCSDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cENTROSAPTableAdapter = new ReportingRemoteDB.BASCSDataSetTableAdapters.CENTROSAPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cENTROSAPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bASCSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cENTROSAPBindingSource
            // 
            this.cENTROSAPBindingSource.DataMember = "CENTROSAP";
            this.cENTROSAPBindingSource.DataSource = this.bASCSDataSet;
            // 
            // bASCSDataSet
            // 
            this.bASCSDataSet.DataSetName = "BASCSDataSet";
            this.bASCSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "CentrosApDataSet";
            reportDataSource1.Value = this.cENTROSAPBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportingRemoteDB.Reports.CentrosApReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(284, 261);
            this.reportViewer1.TabIndex = 0;
            // 
            // cENTROSAPTableAdapter
            // 
            this.cENTROSAPTableAdapter.ClearBeforeFill = true;
            // 
            // FormCentAprReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormCentAprReportViewer";
            this.Text = "FormCentAprReportViewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCentAprReportViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cENTROSAPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bASCSDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BASCSDataSet bASCSDataSet;
        private System.Windows.Forms.BindingSource cENTROSAPBindingSource;
        private BASCSDataSetTableAdapters.CENTROSAPTableAdapter cENTROSAPTableAdapter;
    }
}