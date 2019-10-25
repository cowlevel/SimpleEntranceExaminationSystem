using BusinessLogicLayer;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ValueObject.Report;

namespace PresentationLayer
{
    public partial class UCtrlReport : UserControl
    {
        public UCtrlReport()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            FrmReport frmReport = new FrmReport();

            if (cboReport.SelectedIndex == 0)   //  exam result
            {
                
                ExamineeTakeBLL examineeTakeBLL = new ExamineeTakeBLL();
                List<ExamResultReport> examResult = new List<ExamResultReport>();
                ReportParameter[] reportParameters = new ReportParameter[1];

                if (rdbIn.Checked)
                {
                    examResult = examineeTakeBLL.GetExamResultList(chkInclude.Checked, dtpIn.Value, null);
                    reportParameters[0] = new ReportParameter("ExamResultDate", "Exam result in " + dtpIn.Value.ToShortDateString());
                }
                else if (rdbFrom.Checked)
                {
                    examResult = examineeTakeBLL.GetExamResultList(chkInclude.Checked, dtpFrom.Value, dtpTo.Value);
                    reportParameters[0] = new ReportParameter("ExamResultDate", "Exam result from " + dtpFrom.Value.ToShortDateString() + " to " + dtpTo.Value.Date.ToShortDateString());
                }

                frmReport.LoadReport("ExamResultDS", examResult, "PresentationLayer.Reports.ExamResultReport.rdlc", reportParameters);
                
            }
            else if (cboReport.SelectedIndex == 1)  //  examinee list
            {
                ExamineeBLL examineeBLL = new ExamineeBLL();
                List<ExamineeReport> examineeReport = new List<ExamineeReport>();
                ReportParameter[] reportParameters = new ReportParameter[1];

                if (rdbIn.Checked)
                {
                    examineeReport = examineeBLL.GetExamineeList(dtpIn.Value, null);
                    reportParameters[0] = new ReportParameter("ExamineeDate", "Examinees registered/added in " + dtpIn.Value.ToShortDateString());
                }
                else if (rdbFrom.Checked)
                {
                    examineeReport = examineeBLL.GetExamineeList(dtpFrom.Value, dtpTo.Value);
                    reportParameters[0] = new ReportParameter("ExamineeDate", "Examinees registered/added from " + dtpFrom.Value.ToShortDateString() + " to " + dtpTo.Value.Date.ToShortDateString());
                }

                frmReport.LoadReport("ExamineeDS", examineeReport, "PresentationLayer.Reports.ExamineeReport.rdlc", reportParameters);
            }

            frmReport.ShowDialog(this);
        }

        private void rdbIn_CheckedChanged(object sender, EventArgs e)
        {
            dtpIn.Enabled = true;
            dtpFrom.Enabled = false;
            dtpTo.Enabled = false;
        }

        private void rdbFrom_CheckedChanged(object sender, EventArgs e)
        {
            dtpIn.Enabled = false;
            dtpFrom.Enabled = true;
            dtpTo.Enabled = true;
        }

        private void cboReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboReport.SelectedIndex == 0)
            {
                chkInclude.Visible = true;
            }
            else if (cboReport.SelectedIndex == 1)
            {
                chkInclude.Visible = false;
            }
        }
    }
}