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
    public partial class FrmExamResultDetails : Form
    {
        private ExamineeTakeBLL _examineeTakeBLL;
        private List<ExamResultDetailsViewModel> _examResultDetailsViewModel;

        private int _examineeId;
        private int _examineeTakeId;
        private string _subjectName;

        public FrmExamResultDetails()
        {
            InitializeComponent();

            _examineeTakeBLL = new ExamineeTakeBLL();
        }

        public void ShowExamAnswer(int examineeId, int examineeTakeId, string subjectName)
        {
            dgvDetails.Rows.Clear();

            _examineeId = examineeId;
            _examineeTakeId = examineeTakeId;
            _subjectName = subjectName;

            _examResultDetailsViewModel = _examineeTakeBLL.GetExamResultDetailsViewModel(_examineeId, _examineeTakeId, _subjectName);

            if (_examResultDetailsViewModel.Count > 0)
            {
                foreach (var item in _examResultDetailsViewModel)
                {
                    dgvDetails.Rows.Add("[ Type: " + SetExaminationType(item.ExaminationType) + " ]     [ Score: " + item.Score + " ]");
                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[0].Style.BackColor = Color.LightYellow;
                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[1].Style.BackColor = Color.LightYellow;
                    dgvDetails.Rows.Add("Question", "Answer");
                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[0].Style.BackColor = Color.LightYellow;
                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[0].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[1].Style.BackColor = Color.LightYellow;
                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[1].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    foreach (var i in item.ExamDetails)
                    {
                        dgvDetails.Rows.Add(i.Quest, i.Answer);

                        if (i.IsCorrect == false)
                        {
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[1].Style.BackColor = Color.LightCoral;
                        }
                    }
                }

                dgvDetails.ClearSelection();
            }
        }

        private string SetExaminationType(int examinationType)
        {
            if (examinationType == 0)
            {
                return "Multiple Choice";
            }
            else if (examinationType == 1)
            {
                return "True or False";
            }

            return "Type the Answer";
        }
    }
}
