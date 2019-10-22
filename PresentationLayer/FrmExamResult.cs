using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValueObject.ViewModel;

namespace PresentationLayer
{
    public partial class FrmExamResult : Form
    {

        private ExamineeTakeBLL _examineeTakeBLL;
        private List<ExamResultViewModel> _examResultViewModelList;
        private ExamResultViewModel examResultViewModel;
        private FrmExamResultDetails _frmExamResultDetails;

        private int _examineeId;
        private int _examineeTakeId;
        private string _subjectName;

        public FrmExamResult(int examineeId)
        {
            InitializeComponent();

            dgvSubjResult.AutoGenerateColumns = false;

            _examineeId = examineeId;

            _examineeTakeBLL = new ExamineeTakeBLL();
            _examResultViewModelList = _examineeTakeBLL.GetExamResultByExamineeId(_examineeId);

            foreach (var codes in _examResultViewModelList)
            {
                cboExamCode.Items.Add(codes.ExamCode);
            }
        }

        private void cboExamCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboExamCode.SelectedIndex > -1)
            {
                examResultViewModel = _examResultViewModelList.Where(ex => ex.ExamCode == cboExamCode.Text).Single();

                _examineeTakeId = examResultViewModel.ExamineeTakeId;

                if (examResultViewModel.Result == "PASSED")
                {
                    lblResult.BackColor = Color.FromArgb(92, 184, 92);
                    lblResult.ForeColor = Color.White;
                }
                else
                {
                    lblResult.BackColor = Color.LightCoral;
                    lblResult.ForeColor = Color.White;
                }

                lblResult.Text = examResultViewModel.Result;
                lblPassingRate.Text = string.Format("Passing Rate: {0} % of items", examResultViewModel.PassingRate);


                lblDateTimeIssued.Text = string.Format("Issued On: {0}", examResultViewModel.CodeDateTimeIssued.Value);
                lblIssuedBy.Text = string.Format("Issued By: {0}", examResultViewModel.IssuedBy);
                lblExamDateTime.Text = string.Format("Exam Taken On: {0}", examResultViewModel.ExamDateTimeTaken.Value);
                
                dgvSubjResult.DataSource = null;
                dgvSubjResult.DataSource = examResultViewModel.ExamSubjectResult;
            }
        }

        private void dgvSubjResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0)
            {
                _subjectName = examResultViewModel.ExamSubjectResult.ElementAt(rowIndex).SubjectName;

                int columnIndex = e.ColumnIndex;

                if (columnIndex == 5)
                {
                    if (_frmExamResultDetails == null || _frmExamResultDetails.IsDisposed)
                    {
                        _frmExamResultDetails = new FrmExamResultDetails();
                        _frmExamResultDetails.ShowExamAnswer(_examineeId, _examineeTakeId, _subjectName);
                        _frmExamResultDetails.Text = _subjectName;
                        _frmExamResultDetails.Show(this);
                    }
                    else
                    {
                        _frmExamResultDetails.ShowExamAnswer(_examineeId, _examineeTakeId, _subjectName);
                        _frmExamResultDetails.Text = _subjectName;
                    }
                }
            }
        }
    }
}
