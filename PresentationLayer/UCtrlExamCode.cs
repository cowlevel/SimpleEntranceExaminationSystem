using BusinessLogicLayer;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using ValueObject;
using ValueObject.Report;
using ValueObject.ViewModel;

namespace PresentationLayer
{
    public partial class UCtrlExamCode : UserControl
    {
        private ExamineeFailureBLL _examineeFailureBLL;
        private ExamineeTakeBLL _examineeTakeBLL;
        private List<ExamineeTakeStatusViewModel> _examineeTakeStatusViewModelList;

        private string _nameOrEmail;
        private int _currentWaitDays;
        private int _index;

        public UCtrlExamCode()
        {
            InitializeComponent();

            dgvExaminee.AutoGenerateColumns = false;

            _examineeFailureBLL = new ExamineeFailureBLL();
            _examineeTakeBLL = new ExamineeTakeBLL();
        }

        private void UCtrlExamCode_Load(object sender, EventArgs e)
        {
            _currentWaitDays = _examineeFailureBLL.GetCurrentWaitDays();
            lblCurrentDaysToWait.Text = string.Format("Days To Wait If Examinee Failed: {0} days", _currentWaitDays);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                _nameOrEmail = txtSearch.Text;

                PopulateDataGridView(_nameOrEmail);

                if (_examineeTakeStatusViewModelList != null)
                {
                    lblSearchResult.Text = string.Format("Search result: found {0}", _examineeTakeStatusViewModelList.Count);
                }

                lblName.Text = "Name: ";
                lblEmail.Text = "Email: ";
                lblDateExamCode.Text = "Date Last Exam Code Issued: ";
                lblExamCode.Text = "Exam Code:";
                lblExamCode.ForeColor = Color.Teal;
                lblExamCode.BackColor = Color.Cornsilk;
                btnGenerate.Enabled = false;
            }
            else
            {
                lblStatus.Text = "  Please enter name/email to search";
            }
        }

        private void dgvExaminee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _index = e.RowIndex;

            if (_index >= 0)
            {
                //_examineeTake = examineeTakeStatusViewModelList[index];
                lblName.Text = string.Format("Name: {0}", _examineeTakeStatusViewModelList[_index].FullName);
                lblEmail.Text = string.Format("Email: {0}", _examineeTakeStatusViewModelList[_index].Email);

                if (_examineeTakeStatusViewModelList[_index].CodeIssuedDateTime == null)
                {
                    lblDateExamCode.Text = "Date Last Exam Code Issued: ";
                }
                else
                {
                    lblDateExamCode.Text = string.Format("Date Last Exam Code Issued: {0}", _examineeTakeStatusViewModelList[_index].CodeIssuedDateTime.Value.ToShortDateString());
                }

                if (_examineeTakeStatusViewModelList[_index].IsAllowedToGetExam)
                {
                    lblExamCode.Text = "Exam Code:";
                    lblExamCode.ForeColor = Color.Teal;
                    lblExamCode.BackColor = Color.Cornsilk;
                    btnGenerate.Enabled = true;
                }
                else
                {
                    lblExamCode.Text = string.Format("Examinee must wait for {0} onwards to take another exam", _examineeTakeStatusViewModelList[_index].AllowExamAfterDateTime.Value.ToShortDateString());
                    lblExamCode.ForeColor = Color.White;
                    lblExamCode.BackColor = Color.LightCoral;
                    btnGenerate.Enabled = false;
                }
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(string.Format("Generate exam code for\nName: {0}\nEmail: {1} ?",
                _examineeTakeStatusViewModelList[_index].FullName, 
                _examineeTakeStatusViewModelList[_index].Email), "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //Console.WriteLine("CREATE EXAM CODE!");
                ExamineeTake examineeTake = new ExamineeTake();
                examineeTake.ExamineeId = _examineeTakeStatusViewModelList[_index].ExamineeId;

                string examCode = _examineeTakeBLL.InsertExamineeTake(examineeTake);

                lblExamCode.Text = string.Format("Exam Code: {0}", examCode);
                lblStatus.Text = "  Successfully created exam code for examinee";
                btnGenerate.Enabled = false;

                PopulateDataGridView(_nameOrEmail);
            }
        }

        private void PopulateDataGridView(string nameOrEmail)
        {
            _examineeTakeStatusViewModelList = _examineeTakeBLL.GetExamineeTakeStatusViewModel(_currentWaitDays, _nameOrEmail);

            dgvExaminee.DataSource = null;

            if (_examineeTakeStatusViewModelList.Count > 0)
            {
                dgvExaminee.DataSource = _examineeTakeStatusViewModelList;
                dgvExaminee.ClearSelection();
            }
        }

        private void rdbIn_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbIn.Checked)
            {
                dtpIn.Enabled = true;
                dtpFrom.Enabled = false;
                dtpTo.Enabled = false;
            }
        }

        private void rdbFrom_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFrom.Checked)
            {
                dtpIn.Enabled = false;
                dtpFrom.Enabled = true;
                dtpTo.Enabled = true;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (!rdbIn.Checked && !rdbFrom.Checked)
            {
                lblPrintStatus.Text = "  Please choose date.";
            }
            else
            {
                lblPrintStatus.Text = string.Empty;

                //string exeFolder = Application.StartupPath;
                //string reportPath = Path.Combine(exeFolder, @"Reports\ExamineeCodeReport.rdlc");

                IList<ExamineeCodeReport> codeReports;
                ReportParameter[] reportParameters = new ReportParameter[1];

                FrmReport frmReport = new FrmReport();

                if (rdbIn.Checked)
                {
                    //reportParameters[0] = new ReportParameter("ExamCodeDate", "Exam codes issued in " + dtpIn.Value.Date.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
                    reportParameters[0] = new ReportParameter("ExamCodeDate", "Exam codes issued in " + dtpIn.Value.ToShortDateString());
                    codeReports = _examineeTakeBLL.GetExamineeCodeReport(dtpIn.Value, null);

                    frmReport.LoadReport("ExamineeCodeReport", codeReports, "PresentationLayer.Reports.ExamineeCodeReport.rdlc", reportParameters);
                    frmReport.ShowDialog(this);
                }
                else
                {
                    if (dtpFrom.Value.Date >= dtpTo.Value.Date)
                    {
                        lblPrintStatus.Text = "  Invalid start date/end date.";
                    }
                    else
                    {
                        //reportParameters[0] =  new ReportParameter("ExamCodeDate", "Exam codes issued in " + dtpFrom.Value.Date.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture) + " to " + dtpTo.Value.Date.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
                        reportParameters[0] = new ReportParameter("ExamCodeDate", "Exam codes issued from " + dtpFrom.Value.ToShortDateString() + " to " + dtpTo.Value.Date.ToShortDateString());
                        codeReports = _examineeTakeBLL.GetExamineeCodeReport(dtpFrom.Value, dtpTo.Value);

                        frmReport.LoadReport("ExamineeCodeReport", codeReports, "PresentationLayer.Reports.ExamineeCodeReport.rdlc", reportParameters);
                        frmReport.ShowDialog(this);
                    }
                }
            }
        }
    }
}