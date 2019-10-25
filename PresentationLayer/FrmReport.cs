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
using ValueObject.Report;

namespace PresentationLayer
{
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
            //List<ExamineeCodeReport> list = new List<ExamineeCodeReport>();
            //list.Add(new ExamineeCodeReport { FullName = "NONE" });
            //list.Add(new ExamineeCodeReport { FullName = "NONE" });
            //list.Add(new ExamineeCodeReport { FullName = "NONE" });
            //LoadReport("ExamineeCodeReport", list, "PresentationLayer.Reports.ExamineeCodeReport.rdlc");
            //this.reportViewer1.RefreshReport();
        }

        /// <summary>
        /// How to use this public method?
        /// </summary>
        /// <typeparam name="T">Needs a class.</typeparam>
        /// <param name="dataSetName">Name of DataSet you entered when creating the rdlc report file</param>
        /// <param name="dataSource">Data source like IEnumerables/list/binding source etc.</param>
        /// <param name="reportFilePath">Report file path. Ex. ProjectName/ReportsFolder/MyReport.rdlc then ProjectName.ReportsFolder.MyReport.rdlc should be the value of the reportFilePath</param>
        public void LoadReport<T>(string dataSetName, T dataSource, string reportFilePath, ReportParameter[] reportParameters = null)
        {
            ReportDataSource rds = new ReportDataSource(dataSetName, dataSource);

            reportViewer1.Reset();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            //reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.ReportEmbeddedResource = reportFilePath;

            if (reportParameters != null)
            {
                reportViewer1.LocalReport.SetParameters(reportParameters);
            }

            reportViewer1.RefreshReport();
        }

        public void LoadReport<T>(string dataSetName, T dataSource, string reportFilePath, ReportParameterCollection reportParameters = null)
        {
            ReportDataSource rds = new ReportDataSource(dataSetName, dataSource);

            reportViewer1.Reset();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            //reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.ReportEmbeddedResource = reportFilePath;

            if (reportParameters != null)
            {
                reportViewer1.LocalReport.SetParameters(reportParameters);
            }

            reportViewer1.RefreshReport();
        }
    }
}