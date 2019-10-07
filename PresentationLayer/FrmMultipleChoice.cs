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
    public partial class FrmMultipleChoice : Form
    {
        public int ExamId { get; set; }

        private QuestionBankBLL _questionBankBLL;
        private List<QuestionBank> _questionBankList;
        private QuestionBank _question;
        private FrmMultipleChoiceHistory _frmHistory;


        public FrmMultipleChoice()
        {
            InitializeComponent();
        }

        private void FrmMultipleChoice_Load(object sender, EventArgs e)
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

        private void FrmMultipleChoice_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((FrmMain)Owner).SetCtrlExamDataSource();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (InputsAreValid())
            {
                _question.Question = txtQuestion.Text;
                _question.CorrectAnswer = txtCorrectAnswer.Text;
                _question.WrongAnswer1 = txtWrongAnswer1.Text;
                _question.WrongAnswer2 = txtWrongAnswer2.Text;
                _question.WrongAnswer3 = txtWrongAnswer3.Text;

                _questionBankBLL.UpdateQuestion(_question);

                lblStatus.Text = string.Format("  Successfully updated Item No. {0}", numItemNo.Value);

                if (_frmHistory != null && _frmHistory.Visible == true)
                {
                    SetItemHistory();
                }
            }
        }

        private void numItemNo_ValueChanged(object sender, EventArgs e)
        {
            int questionNo = (int)numItemNo.Value;
            _question = _questionBankList.Where(q => q.QuestionNumber == questionNo)
                .SingleOrDefault();

            lblStatus.Text = string.Empty;

            if (string.IsNullOrWhiteSpace(_question.Question))
            {
                lblStatus.Text = "  Please complete this item no.";
            }

            txtQuestion.Text = _question.Question;
            txtCorrectAnswer.Text = _question.CorrectAnswer;
            txtWrongAnswer1.Text = _question.WrongAnswer1;
            txtWrongAnswer2.Text = _question.WrongAnswer1;
            txtWrongAnswer3.Text = _question.WrongAnswer1;

            if (_frmHistory != null && _frmHistory.Visible == true)
            {
                SetItemHistory();
            }
        }

        private void lblItemNo_Click(object sender, EventArgs e)
        {
            numItemNo.Focus();
        }
        private void lblQuestion_Click(object sender, EventArgs e)
        {
            txtQuestion.Focus();
        }

        private void lblCorrectAnswer_Click(object sender, EventArgs e)
        {
            txtCorrectAnswer.Focus();
        }

        private void lblWrongAnswer1_Click(object sender, EventArgs e)
        {
            txtWrongAnswer1.Focus();
        }

        private void lblWrongAnswer2_Click(object sender, EventArgs e)
        {
            txtWrongAnswer2.Focus();
        }

        private void lblWrongAnswer3_Click(object sender, EventArgs e)
        {
            txtWrongAnswer3.Focus();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            SetItemHistory();
        }

        private void SetItemHistory()
        {
            if (_frmHistory == null || _frmHistory.IsDisposed)
            {
                _frmHistory = new FrmMultipleChoiceHistory();
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
            else if (string.IsNullOrWhiteSpace(txtCorrectAnswer.Text))
            {
                lblStatus.Text = "  Please enter correct answer";
                txtCorrectAnswer.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtWrongAnswer1.Text))
            {
                lblStatus.Text = "  Please enter wrong answer 1";
                txtWrongAnswer1.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtWrongAnswer2.Text))
            {
                lblStatus.Text = "  Please enter wrong answer 2";
                txtWrongAnswer2.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtWrongAnswer3.Text))
            {
                lblStatus.Text = "  Please enter wrong answer 3";
                txtWrongAnswer3.Focus();
                return false;
            }
            else if (string.Equals(txtCorrectAnswer.Text, txtWrongAnswer1.Text, StringComparison.CurrentCultureIgnoreCase)
                     || string.Equals(txtCorrectAnswer.Text, txtWrongAnswer2.Text, StringComparison.CurrentCultureIgnoreCase)
                     || string.Equals(txtCorrectAnswer.Text, txtWrongAnswer3.Text, StringComparison.CurrentCultureIgnoreCase))
            {
                lblStatus.Text = "  Correct answer must be unique";
                return false;
            }

            return true;
        }

        
    }
}