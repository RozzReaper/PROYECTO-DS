﻿using Microsoft.Reporting.WinForms;
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
            report_viewer.LocalReport.DataSources.Clear();
            report_viewer.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", report));
            this.report_viewer.RefreshReport();
        }
    }
}
