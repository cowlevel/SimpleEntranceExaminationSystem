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

        private FrmCreateQuestion _frmCreateQuestion;
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
            kvp.Add(new KeyValuePair<ExamType, string>(ExamType.FillInTheBlank, "Fill in the Blank"));

            cboExamType.ValueMember = "Key";
            cboExamType.DisplayMember = "Value";
            cboExamType.DataSource = kvp;
            cboExamType.SelectedIndex = -1;

            _examBLL = new ExamBLL();
            dgvExam.AutoGenerateColumns = false;
            dgvExam.DataSource = _examBLL.GetExamViewModelList();
        }

        private void cboSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSubject.SelectedIndex > -1)
            {
                Console.WriteLine(cboSubject.SelectedValue);
                Console.WriteLine(cboSubject.Text);
            }
            
        }

        private void cboExamType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboExamType.SelectedIndex > -1)
            {
                Console.WriteLine((int)cboExamType.SelectedValue);
                Console.WriteLine(cboExamType.Text);
            }
        }

        private void SetUIProperty(Operation operation)
        {
            switch (operation)
            {
                case Operation.Adding:
                    lblStatus.Text = "        You are currently adding new exam.";


                    cboSubject.Focus();
                    break;
                case Operation.Editing:
                    lblStatus.Text = "        You are currently editing exam.";


                    break;
                case Operation.Clear:
                    lblStatus.Text = string.Empty;


                    break;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(this, "Are you sure you want to create exam for ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //  get subject id to insert in new exam
                //  insert new exam in db and open frmcreatequestion form to add questions


                dgvExam.DataSource = null;
                dgvExam.DataSource = _examBLL.GetExamViewModelList();
            }
        }

        private void dgvExam_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7 && e.RowIndex >= 0)
            {
                _examId = (int)dgvExam.Rows[e.RowIndex].Cells[0].Value;

                _frmCreateQuestion = new FrmCreateQuestion();
                _frmCreateQuestion.ShowDialog(this);
                _frmCreateQuestion.SetExamId(_examId);
            }
        }


    }
}