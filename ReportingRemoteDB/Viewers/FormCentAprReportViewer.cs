using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportingRemoteDB.Viewers
{
    public partial class FormCentAprReportViewer : Form
    {
        public FormCentAprReportViewer()
        {
            InitializeComponent();
        }

        private void FormCentAprReportViewer_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bASCSDataSet.CENTROSAP' Puede moverla o quitarla según sea necesario.
            this.cENTROSAPTableAdapter.Fill(this.bASCSDataSet.CENTROSAP);

            ReportParameter[] pars = new ReportParameter[]
            {
                new ReportParameter("strEmpresa", "Arteco S.A."),
                new ReportParameter("flagMostrarCaratula", "true")
            };
            this.reportViewer1.LocalReport.SetParameters(pars);

            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
