using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace ReportingRemoteDB.Viewers
{
    public partial class FormResumenCtaReportViewer : Form
    {
        public FormResumenCtaReportViewer()
        {
            InitializeComponent();
        }

        private void FormResumenCtaReportViewer_Load(object sender, EventArgs e)
        {
            this.oLAPCONTABLEBindingSource.DataSource = this.generate_report();

            ReportParameter[] pars = new ReportParameter[]
            {
                new ReportParameter("strEmpresa", "Arteco S.A."),
                new ReportParameter("flagMostrarCaratula", "true")
            };
            this.reportViewer1.LocalReport.SetParameters(pars);

            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

        private DataTable generate_report()
        {
            DataTable dt = new DataTable("OLAPcontable");
            string conStr = ConfigurationManager.ConnectionStrings["ReportingRemoteDB.Properties.Settings.BASCSConnectionString"].ConnectionString;
            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand("SELECT [fecha],[Cuenta],[Subcuenta],[NombreSubcuenta],[debe],[Haber],[Importe] FROM[BASCS].[dbo].[OLAP_CONTABLE] WHERE[Subcuenta] = '1004' AND[Cuenta] in (1260, 1270) ORDER BY[Cuenta], [fecha] ASC", sqlcon);
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
            }

            return dt;
        }
    }
}
