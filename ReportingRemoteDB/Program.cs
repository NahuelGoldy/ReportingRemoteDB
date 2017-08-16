using ReportingRemoteDB.Viewers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportingRemoteDB
{
	static class Program
	{
		/// <summary>
		/// Punto de entrada principal para la aplicación.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormCentAprReportViewer());
            Application.Run(new FormResumenCtaReportViewer());
        }
    }
}