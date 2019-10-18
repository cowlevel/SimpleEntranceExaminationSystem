using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using ValueObject;
using ValueObject.ViewModel;
using Utility;

namespace PresentationLayer
{
    public partial class UCtrlExam : UserControl
    {
        private SubjectBLL _subjectBLL;
        private List<Subject> _subjectList;
        private ExamBLL _examBLL;
        private List<ExamViewModel> _examViewModelList;

        FrmMultipleChoice _frmMultipleChoice;
        FrmTrueOrFalse _frmTrueOrFalse;
        FrmWriteTheAnswer _frmWriteTheAnswer;

        private ExamType _selectedExamType;
        private int _examId;
        
        
        public UCtrlExam()
        {
            InitializeComponent();

            _subjectBLL = new SubjectBLL();
            _subjectList = _subjectBLL.GetSubjectList();
            
            cboSubject.ValueMember = "SubjectId";
            cboSubject.DisplayMember = "SubjectName";
            cboSubject.DataSource = _subjectList;
            cboSubject.SelectedIndex = -1;

            List<KeyValuePair<ExamType, string>> kvp = new List<KeyValuePair<ExamType, string>>();
            kvp.Add(new KeyValuePair<ExamType, string>(ExamType.MultipleChoice, "Multiple Choice"));
            kvp.Add(new KeyValuePair<ExamType, string>(ExamType.TrueOrFalse, "True or False"));
            kvp.Add(new KeyValuePair<ExamType, string>(ExamType.TypeTheAnswer, "Type the Answer"));

            cboExamType.ValueMember = "Key";
            cboExamType.DisplayMember = "Value";
            cboExamType.DataSource = kvp;
            cboExamType.SelectedIndex = -1;

            _examBLL = new ExamBLL();

            dgvExam.AutoGenerateColumns = false;
            dgvTotal.AutoGenerateColumns = false;
        }

        private void UCtrlExam_Load(object sender, EventArgs e)
        {
            SetExamDatagridViewDataScource();
            SetExamTotalDataGridViewDataSource();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (cboSubject.SelectedIndex == -1)
            {
                lblStatus.Text = "  Please choose subject";
                cboSubject.Focus();
            }
            else if (cboExamType.SelectedIndex == -1)
            {
                lblStatus.Text = "  Please choose exam type";
                cboExamType.Focus();
            }
            else if (cboSubject.SelectedIndex > -1 && cboExamType.SelectedIndex > -1)
            {
                string subject = cboSubject.Text;
                string examType = cboExamType.Text;
                string timeLimit = lblOutputTimeLimit.Text;
                string items = numItems.Value.ToString();
                string dialogMessage = string.Format("Are you sure you want to create exam for \nSubject: {0}\nExam Type: {1}\nTime Limit: {2}\nItems: {3} ?", 
                    subject, examType, timeLimit, items);

                DialogResult result = MessageBox.Show(this, dialogMessage, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Exam exam = new Exam();
                    exam.UserId = UserInfo.UserId;
                    exam.SubjectId = (int)cboSubject.SelectedValue;
                    exam.ExaminationType = (int)cboExamType.SelectedValue;
                    exam.TimeLimit = (int)numTimeLimit.Value;
                    exam.ItemCount = (int)numItems.Value;
                    exam.Archived = false;
                    //exam.DateTimeAdded to DAL

                    for (int i = 1; i <= exam.ItemCount; i++)
                    {
                        exam.QuestionBank.Add(new QuestionBank { QuestionNumber = i });
                    }

                    _examBLL.InsertExam(exam);

                    _selectedExamType = SetExamType(cboExamType.Text);
                    cboSubject.SelectedIndex = -1;
                    cboExamType.SelectedIndex = -1;
                    numTimeLimit.Value = 60;
                    lblStatus.Text = "  Successfully created new exam";

                    SetExamDatagridViewDataScource();
                    SetExamTotalDataGridViewDataSource();
                    ShowQuestionFrom(exam.ExamId);
                }
            }
        }

        private void numTimeLimit_ValueChanged(object sender, EventArgs e)
        {
            lblOutputTimeLimit.Text = Conversions.TimeMinuteToString((int)numTimeLimit.Value);
        }

        private void dgvExam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0)
            {
                string examType = dgvExam.Rows[rowIndex].Cells[2].Value.ToString();
                _selectedExamType = SetExamType(examType);
                _examId = (int)dgvExam.Rows[rowIndex].Cells[0].Value;
                
                ExamViewModel examVM = _examViewModelList.Where(ex => ex.ExamId == _examId).Single();   //  select exam from list using _examId
                lblAddedBy.Text = string.Format("Created By: {0}", examVM.CreatedBy);
                lblDateTimeAdded.Text = string.Format("Date and Time Created: {0}", examVM.DateTimeAdded);

                int columnIndex = e.ColumnIndex;

                if (columnIndex == 5)   //  if user clicked QUESTION button in DataGridView
                {
                    ShowQuestionFrom(_examId);
                }

                if (columnIndex == 6)   //  if user clicked ARCHIEVE button in DataGridView
                {
                    DialogResult result = MessageBox.Show(this, "Are you sure you want send this exam to archieve?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        _examBLL.SendExamToArchieve(_examId);
                        lblStatus.Text = "  Successfully sent exam to archieve";

                        SetExamDatagridViewDataScource();
                        SetExamTotalDataGridViewDataSource();
                    }
                }
            }
        }

        private ExamType SetExamType(string examType)
        {
            if (examType == "Multiple Choice")
            {
                return ExamType.MultipleChoice;
            }
            else if (examType == "True or False")
            {
                return ExamType.TrueOrFalse;
            }

            return ExamType.TypeTheAnswer;
        }

        private void ShowQuestionFrom(int examId)
        {
            if (_selectedExamType == ExamType.MultipleChoice)
            {
                _frmMultipleChoice = new FrmMultipleChoice();
                _frmMultipleChoice.ExamId = examId;
                _frmMultipleChoice.ShowDialog(this);
            }
            else if (_selectedExamType == ExamType.TrueOrFalse)
            {
                _frmTrueOrFalse = new FrmTrueOrFalse();
                _frmTrueOrFalse.ExamId = examId;
                _frmTrueOrFalse.ShowDialog(this);
            }
            else if (_selectedExamType == ExamType.TypeTheAnswer)
            {
                _frmWriteTheAnswer = new FrmWriteTheAnswer();
                _frmWriteTheAnswer.ExamId = examId;
                _frmWriteTheAnswer.ShowDialog(this);
            }
        }

        private void SetItemCountWarning()
        {
            int listCount = _examViewModelList.Count;

            if (listCount > 0)
            {
                for (int i = 0; i < listCount; i++)
                {
                    if (_examViewModelList[i].ItemCount != _examViewModelList[i].IncompleteQuestionCount)
                    {
                        dgvExam.Rows[i].Cells[4].Style.BackColor = Color.LightCoral;
                    }
                }
            }
        }

        public void SetExamDatagridViewDataScource()
        {
            _examViewModelList = _examBLL.GetExamViewModelList();
            dgvExam.DataSource = null;

            if (_examViewModelList.Count > 0)
            {
                dgvExam.DataSource = _examViewModelList;
                dgvExam.ClearSelection();
            }

            SetItemCountWarning();
        }

        public void SetExamTotalDataGridViewDataSource()
        {
            var examTotal = _examViewModelList
                .GroupBy(g => new
                {
                    g.SubjectId,
                    g.SubjectName
                })
                .Select(s => new
                {
                    s.Key.SubjectId,
                    s.Key.SubjectName,
                    TimeLimit = s.Sum(t => t.TimeLimit),
                    TotalTimeLimit = Conversions.TimeMinuteToString(s.Sum(t => t.TimeLimit)),
                    TotalIncompleteItem = s.Sum(t => t.ItemCount - t.IncompleteQuestionCount),
                    TotalItem = s.Sum(t => t.ItemCount)
                })
                .ToList();

            dgvTotal.DataSource = null;

            if (examTotal.Count > 0)
            {
                dgvTotal.DataSource = examTotal;
                dgvTotal.ClearSelection();
                lblTotalExam.Text = string.Format("No. Of Subject With Exam: {0}", examTotal.Count);
                lblTotalTimeLimit.Text = string.Format("Total Time Limit: {0}", Conversions.TimeMinuteToString(examTotal.Sum(e => e.TimeLimit)));
                lblTotalItem.Text = string.Format("Total No. Of Item: {0}", examTotal.Sum(e => e.TotalItem));
            }
        }
    }
}