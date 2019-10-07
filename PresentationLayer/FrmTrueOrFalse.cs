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
using ValueObject;

namespace PresentationLayer
{
    public partial class FrmTrueOrFalse : Form
    {
        public int ExamId { get; set; }

        private QuestionBankBLL _questionBankBLL;
        private List<QuestionBank> _questionBankList;
        private QuestionBank _question;
        private FrmTOFWTAHistory _frmHistory;

        public FrmTrueOrFalse()
        {
            InitializeComponent();
        }

        private void FrmTrueOrFalse_Load(object sender, EventArgs e)
        {
            int itemCount;

            _questionBankBLL = new QuestionBankBLL();
            _questionBankList = _questionBankBLL.GetQuestionBankList(this.ExamId);
            itemCount = _questionBankList.Count;
            numItemNo.Maximum = itemCount;
            _question = _questionBankList.OrderBy(q => q.QuestionNumber).Where(q => q.Question == null).FirstOrDefault();

            if (_question != null)
            {
                numItemNo.Value = _question.QuestionNumber;
            }
            else
            {
                numItemNo.Value = 1;
            }

            lblTotalItemCount.Text = string.Format("Total Item Count: {0}", itemCount);
        }

        private void FrmTrueOrFalse_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((FrmMain)Owner).SetCtrlExamDataSource();
        }

        private void numItemNo_ValueChanged(object sender, EventArgs e)
        {
            rdbTrue.Checked = false;
            rdbFalse.Checked = false;

            int questionNumber = (int)numItemNo.Value;
            _question = _questionBankList.Where(q => q.QuestionNumber == questionNumber)
                .SingleOrDefault();

            lblStatus.Text = string.Empty;

            if (string.IsNullOrWhiteSpace(_question.Question))
            {
                lblStatus.Text = "  Please complete this item no.";
            }

            txtQuestion.Text = _question.Question;

            if (_question.CorrectAnswer == "True")
            {
                rdbTrue.Checked = true;
            }
            else if (_question.CorrectAnswer == "False")
            {
                rdbFalse.Checked = true;
            }

            if (_frmHistory != null && _frmHistory.Visible == true)
            {
                SetItemHistory();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (InputsAreValid())
            {
                _question.Question = txtQuestion.Text;

                if (rdbTrue.Checked)
                {
                    _question.CorrectAnswer = "True";
                }

                if (rdbFalse.Checked)
                {
                    _question.CorrectAnswer = "False";
                }
                
                _questionBankBLL.UpdateQuestion(_question);

                lblStatus.Text = string.Format("  Successfully updated Item No. {0}", numItemNo.Value);

                if (_frmHistory != null && _frmHistory.Visible == true)
                {
                    SetItemHistory();
                }
            }
        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {
            txtQuestion.Focus();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            SetItemHistory();
        }

        private void SetItemHistory()
        {
            if (_frmHistory == null || _frmHistory.IsDisposed)
            {
                _frmHistory = new FrmTOFWTAHistory();
                _frmHistory.Show(this);
                _frmHistory.SetItemNo(_question.QuestionNumber);
                _frmHistory.SetHistory(_question.QuestionId);
            }
            else
            {
                _frmHistory.SetItemNo(_question.QuestionNumber);
                _frmHistory.SetHistory(_question.QuestionId);
            }
        }

        private bool InputsAreValid()
        {
            if (string.IsNullOrWhiteSpace(txtQuestion.Text))
            {
                lblStatus.Text = "  Please enter question";
                txtQuestion.Focus();
                return false;
            }
            else if (!rdbTrue.Checked && !rdbFalse.Checked)
            {
                lblStatus.Text = "  Please choose an answer";
                return false;
            }

            return true;
        }
    }
}