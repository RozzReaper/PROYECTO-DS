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

namespace Ejemplo2
{

    public partial class Report : Form
    {
        public List<Reporteandro> report = new List<Reporteandro>();
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", report));
            this.reportViewer1.RefreshReport();
        }
    }
}
