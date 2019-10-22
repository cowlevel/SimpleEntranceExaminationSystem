using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Timers;
using System.Windows.Forms;
using Utility;
using ValueObject;

namespace PresentationLayer.Client
{
    public partial class FrmExam : Form
    {
        private System.Timers.Timer _timer;
        private List<SubjectScore> _subjectScoreList;
        private ExamineeTake _examineeTakeInfo;

        private ExamBLL _examBLL;
        private ExamineeTakeBLL _examineeTakeBLL;
        private PassingRateBLL _passingRateBLL;
        private ExamineeBLL _examineeBLL;

        private List<Exam> _examList;
        private List<ExamineeExam> _examineeExamList;
        private List<QuestionBank> _questionBankList;
        private QuestionBank _questionBank;
        private ExamineeAnswer _examAnswer;

        private DateTime _dateTime;
        private TimeSpan _timeSpan;
        
        private int _index;
        private int _questionNumber;
        private int _examScore;
        private int _examId;
        private int _minutes;
        private int _examItemCount;
        private int _counter;
        private int _millisecond;
        private string _correctAnswer;
        private string _examineeAnswer;
        private bool _doLoop;

        public readonly TimeSpan ONE_SECOND = new TimeSpan(0, 0, 1);

        public FrmExam(ExamineeTake examineeTake)
        {
            InitializeComponent();

            _examineeTakeInfo = examineeTake;

            _examBLL = new ExamBLL();
            _examList = _examBLL.GetActiveExamList();

            _minutes = _examList.Sum(e => e.TimeLimit);

            _timeSpan = new TimeSpan(0, _minutes, 0);
            //_oneSecond = new TimeSpan(0, 0, 1);

            _subjectScoreList = new List<SubjectScore>();
            _questionBankList = new List<QuestionBank>();

            foreach (var question in _examList)
            {
                _questionBankList.AddRange(question.QuestionBank);
            }

            _examScore = 0;
            _index = 0;
            _questionNumber = 0;
            _counter = 0;
            _millisecond = 0;
            _doLoop = true;

            _examineeExamList = _examineeTakeInfo.ExamineeExam.ToList();
            _examId = _examineeExamList[_index].ExamId;
            
            SetQuestion();  //  set the first question
        }

        private void FrmExam_Load(object sender, EventArgs e)
        {
            FrmCounter frmCounter = new FrmCounter("Your Exam Starts In...");
            frmCounter.ShowDialog(this);

            _dateTime = _examBLL.GetDateTime(); //  set exam taken date and time
            
            _timer = new System.Timers.Timer(50);
            _timer.SynchronizingObject = lblTimeLimit;
            _timer.SynchronizingObject = this;
            _timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            _timer.Enabled = true;

            _examineeTakeInfo.ExamDateTimeTaken = _dateTime;// _examBLL.GetDateTime(); //  set exam taken date and time
            //timer1.Enabled = true;
            lblTimeLimit.Text = _timeSpan.ToString("g");
        }

        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            _millisecond += 50;
            _dateTime = _dateTime.AddMilliseconds(50);

            if (_millisecond == 1000)
            {
                _millisecond = 0;
                _timeSpan = _timeSpan.Subtract(ONE_SECOND);
                lblTimeLimit.Text = _timeSpan.ToString("g");
            }

            if (_timeSpan.Ticks == 0)
            {
                this.Visible = false;
                _timer.Enabled = false;

                while (_doLoop)
                {
                    Invoke(new Action(() => 
                    {
                        SetScore();
                        _questionNumber++;
                        SetQuestion();
                    }));
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (IsBlankAnswer())
            {
                lblSelect.Visible = true;
            }
            else
            {
                lblSelect.Visible = false;

                SetScore();
                _questionNumber++;
                SetQuestion();
            }
        }

        private bool IsBlankAnswer()
        {
            ExamType examinationType = (ExamType)_examList.Single(e => e.ExamId == _examId).ExaminationType;

            if (examinationType == ExamType.MultipleChoice)
            {
                if (chkChoice1.Checked == false && chkChoice2.Checked == false
                    && chkChoice3.Checked == false && chkChoice4.Checked == false)
                {
                    return true;
                }
            }
            else if (examinationType == ExamType.TrueOrFalse)
            {
                if (chkTrue.Checked == false && chkFalse.Checked == false)
                {
                    return true;
                }
            }
            else if (examinationType == ExamType.TypeTheAnswer)
            {
                if (string.IsNullOrWhiteSpace(txtAnswer.Text))
                {
                    txtAnswer.Focus();
                    return true;
                }
            }

            return false;
        }

        private void SetScore()
        {
            ExamType examinationType = (ExamType)_examList.Single(e => e.ExamId == _examId).ExaminationType;

            if (examinationType == ExamType.MultipleChoice)
            {
                if (chkChoice1.Checked == false && chkChoice2.Checked == false
                    && chkChoice3.Checked == false && chkChoice4.Checked == false)
                {
                    _examineeAnswer = null;
                }
            }
            else if (examinationType == ExamType.TrueOrFalse)
            {
                if (chkTrue.Checked == false && chkFalse.Checked == false)
                {
                    _examineeAnswer = null;
                }
            }
            else if (examinationType == ExamType.TypeTheAnswer)
            {
                _examineeAnswer = string.IsNullOrWhiteSpace(txtAnswer.Text) == true ? null : txtAnswer.Text;
            }

            _examAnswer = _examineeExamList[_index].ExamineeAnswer.Single(e => e.QuestionId == _questionBank.QuestionId);
            _examAnswer.Answer = _examineeAnswer;
            _examAnswer.DateTimeAnswered = _dateTime;

            if (string.Compare(_correctAnswer, _examineeAnswer, false) == 0)
            {
                _examScore++;
                _examAnswer.IsCorrect = true;
            }
        }

        private void SetQuestion()
        {
            _examItemCount = _examList.Single(e => e.ExamId == _examId).ItemCount;
            int examCount = _examList.Count;
            
            if (_questionNumber < _examItemCount)
            {
                _counter++;
                SetExaminationInfo();
                SetQuestionLabelText();
                SetChoice();
            }
            else
            {
                _subjectScoreList.Add(new SubjectScore
                {
                    SubjectName = _examList.Single(e => e.ExamId == _examId).Subject.SubjectName,
                    Score = _examScore,
                    ItemCount = _examItemCount
                });

                _examineeExamList[_index].Score = _examScore;   //  set score in exam taken
                _questionNumber = 0;
                _index++;
                _examScore = 0; //  reset score
                _counter = 1;   //  reset counter

                if (_index < examCount)
                {
                    _examId = _examineeExamList[_index].ExamId;

                    SetExaminationInfo();
                    SetQuestionLabelText();
                    SetChoice();
                }
                else
                {
                    _doLoop = false;
                    _timer.Enabled = false;

                    this.Visible = false;

                    _passingRateBLL = new PassingRateBLL();
                    _examineeTakeInfo.PassingRate = _passingRateBLL.GetCurrentPassingRate();

                    var examScoreSummary = _subjectScoreList
                        .GroupBy(g => new
                        {
                            g.SubjectName,
                        })
                        .Select(s => new
                        {
                            s.Key.SubjectName,
                            ItemCount = s.Sum(ic => ic.ItemCount),
                            TotalScore = s.Sum(ts => ts.Score),
                            Result = s.Sum(ts => ts.Score) >= Math.Ceiling(Compute.GetPercentage((double)_examineeTakeInfo.PassingRate, s.Sum(ic => ic.ItemCount))) ? true : false
                            //,View = s.Sum(ts => ts.Score) + " >= " + Math.Ceiling(Compute.GetPercentage((double)_examineeTakeInfo.PassingRate, s.Sum(ic => ic.ItemCount)))
                        });

                    //foreach (var item in examScoreSummary)
                    //{
                    //    Console.WriteLine("Items: " + item.ItemCount + "     Score:" + item.TotalScore + "   |View:" + item.View);
                    //}

                    bool passedExam = examScoreSummary.Where(e => e.Result == false).Count() == 0;   //  if list got no failed(false) exam score
                    _examineeTakeInfo.Result = passedExam;

                    _examineeTakeBLL = new ExamineeTakeBLL();
                    _examineeTakeBLL.UpdateExamineeTake(_examineeTakeInfo);

                    _examineeBLL = new ExamineeBLL();
                    _examineeBLL.IncreaseExamineeExamTaken(_examineeTakeInfo.ExamineeId);

                    FrmCounter frmCounter = new FrmCounter("Your Exam Ends In...");
                    frmCounter.ShowDialog(this);
                    this.Close();
                }
            }
        }

        private void SetExaminationInfo()
        {
            lblCounter.Text = string.Format("Item No. {0} of {1}", _counter, _examItemCount);
            lblSubject.Text = string.Format("Subject: {0}", _examList.Single(e => e.ExamId == _examId).Subject.SubjectName); // _examList[_index].Subject.SubjectName
            lblExamType.Text = string.Format("Examination Type: {0}", SetExaminationType((ExamType)_examList.Single(e => e.ExamId == _examId).ExaminationType));//_examList[_index].ExaminationType
            lblItems.Text = string.Format("Items: {0}", _examList.Single(e => e.ExamId == _examId).ItemCount);//_examList[_index].ItemCount
        }

        private void SetQuestionLabelText()
        {
            int questionId = _examineeExamList[_index].ExamineeAnswer.Skip(_questionNumber).Take(1).Single().QuestionId;
            _questionBank = _questionBankList.Single(q => q.QuestionId == questionId);
            lblQuestion.Text = _questionBank.Question;
        }

        private void SetChoice()
        {
            ExamType examinationType = (ExamType)_examList.Single(e => e.ExamId == _examId).ExaminationType;

            _correctAnswer = _questionBank.CorrectAnswer;   //  get correct answer for reference

            if (examinationType == ExamType.MultipleChoice)
            {
                chkTrue.Visible = false;
                chkFalse.Visible = false;

                lblType.Visible = false;
                txtAnswer.Visible = false;

                rectChoice.Height = 290;

                string[] choice = ShuffleStringArray(new string[]
                {
                    _questionBank.CorrectAnswer,
                    _questionBank.WrongAnswer1,
                    _questionBank.WrongAnswer2,
                    _questionBank.WrongAnswer3
                });

                chkChoice1.Text = choice[0];
                chkChoice1.Checked = false;
                chkChoice1.Visible = true;
                chkChoice2.Text = choice[1];
                chkChoice2.Checked = false;
                chkChoice2.Visible = true;
                chkChoice3.Text = choice[2];
                chkChoice3.Checked = false;
                chkChoice3.Visible = true;
                chkChoice4.Text = choice[3];
                chkChoice4.Checked = false;
                chkChoice4.Visible = true;
            }
            else if (examinationType == ExamType.TrueOrFalse)
            {
                chkChoice1.Visible = false;
                chkChoice2.Visible = false;
                chkChoice3.Visible = false;
                chkChoice4.Visible = false;

                lblType.Visible = false;
                txtAnswer.Visible = false;

                rectChoice.Height = 110;

                chkTrue.Left = 13;
                chkTrue.Top = 402;
                chkTrue.Checked = false;
                chkTrue.Visible = true;
                chkFalse.Left = 515;
                chkFalse.Top = 402;
                chkFalse.Checked = false;
                chkFalse.Visible = true;
            }
            else if (examinationType == ExamType.TypeTheAnswer)
            {
                chkChoice1.Visible = false;
                chkChoice2.Visible = false;
                chkChoice3.Visible = false;
                chkChoice4.Visible = false;

                chkTrue.Visible = false;
                chkFalse.Visible = false;

                rectChoice.Height = 125;

                lblType.Left = 25;
                lblType.Top = 412;
                lblType.Visible = true;
                txtAnswer.Left = 28;
                txtAnswer.Top = 442;
                txtAnswer.Text = string.Empty;
                txtAnswer.Visible = true;

                txtAnswer.Focus();
            }
        }

        private string[] ShuffleStringArray(string[] arrayOfString)
        {
            Random random = new Random();

            return arrayOfString = arrayOfString.OrderBy(r => random.Next()).ToArray();
        }

        private string SetExaminationType(ExamType examType)
        {
            if (examType == ExamType.MultipleChoice)
            {
                return "Multiple Choice";
            }
            else if (examType == ExamType.TrueOrFalse)
            {
                return "True Or False";
            }
            else
            {
                return "Type The Answer";
            }
        }

        private void SetCheckBoxColor(CheckBox checkBox, Color foreColor, Color backColor)
        {
            checkBox.ForeColor = foreColor;
            checkBox.BackColor = backColor;
        }
        
        private void chkTrue_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTrue.Checked)
            {
                chkFalse.Checked = false;
                _examineeAnswer = chkTrue.Text;
                SetCheckBoxColor(chkTrue, Color.White, Color.FromArgb(67, 166, 235));
            }
            else
            {
                SetCheckBoxColor(chkTrue, Color.Black, Color.White);
            }
        }
        private void chkTrue_MouseEnter(object sender, EventArgs e)
        {
            if (!chkTrue.Checked)
            {
                SetCheckBoxColor(chkTrue, Color.Black, Color.LightYellow);
            }
        }
        private void chkTrue_MouseLeave(object sender, EventArgs e)
        {
            if (!chkTrue.Checked)
            {
                SetCheckBoxColor(chkTrue, Color.Black, Color.White);
            }
        }

        private void chkFalse_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFalse.Checked)
            {
                chkTrue.Checked = false;
                _examineeAnswer = chkFalse.Text;
                SetCheckBoxColor(chkFalse, Color.White, Color.FromArgb(67, 166, 235));
            }
            else
            {
                SetCheckBoxColor(chkFalse, Color.Black, Color.White);
            }
        }
        private void chkFalse_MouseEnter(object sender, EventArgs e)
        {
            if (!chkFalse.Checked)
            {
                SetCheckBoxColor(chkFalse, Color.Black, Color.LightYellow);
            }
        }
        private void chkFalse_MouseLeave(object sender, EventArgs e)
        {
            if (!chkFalse.Checked)
            {
                SetCheckBoxColor(chkFalse, Color.Black, Color.White);
            }
        }

        private void chkChoice1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChoice1.Checked)
            {
                chkChoice2.Checked = false;
                chkChoice3.Checked = false;
                chkChoice4.Checked = false;
                _examineeAnswer = chkChoice1.Text;
                SetCheckBoxColor(chkChoice1, Color.White, Color.FromArgb(67, 166, 235));
            }
            else
            {
                SetCheckBoxColor(chkChoice1, Color.Black, Color.White);
            }
        }
        private void chkChoice1_MouseEnter(object sender, EventArgs e)
        {
            if (!chkChoice1.Checked)
            {
                SetCheckBoxColor(chkChoice1, Color.Black, Color.LightYellow);
            }
        }
        private void chkChoice1_MouseLeave(object sender, EventArgs e)
        {
            if (!chkChoice1.Checked)
            {
                SetCheckBoxColor(chkChoice1, Color.Black, Color.White);
            }
        }

        private void chkChoice2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChoice2.Checked)
            {
                chkChoice1.Checked = false;
                chkChoice3.Checked = false;
                chkChoice4.Checked = false;
                _examineeAnswer = chkChoice2.Text;
                SetCheckBoxColor(chkChoice2, Color.White, Color.FromArgb(67, 166, 235));
            }
            else
            {
                SetCheckBoxColor(chkChoice2, Color.Black, Color.White);
            }

        }
        private void chkChoice2_MouseEnter(object sender, EventArgs e)
        {
            if (!chkChoice2.Checked)
            {
                SetCheckBoxColor(chkChoice2, Color.Black, Color.LightYellow);
            }
        }
        private void chkChoice2_MouseLeave(object sender, EventArgs e)
        {
            if (!chkChoice2.Checked)
            {
                SetCheckBoxColor(chkChoice2, Color.Black, Color.White);
            }
        }

        private void chkChoice3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChoice3.Checked)
            {
                chkChoice1.Checked = false;
                chkChoice2.Checked = false;
                chkChoice4.Checked = false;
                _examineeAnswer = chkChoice3.Text;
                SetCheckBoxColor(chkChoice3, Color.White, Color.FromArgb(67, 166, 235));
            }
            else
            {
                SetCheckBoxColor(chkChoice3, Color.Black, Color.White);
            }
        }
        private void chkChoice3_MouseEnter(object sender, EventArgs e)
        {
            if (!chkChoice3.Checked)
            {
                SetCheckBoxColor(chkChoice3, Color.Black, Color.LightYellow);
            }
        }
        private void chkChoice3_MouseLeave(object sender, EventArgs e)
        {
            if (!chkChoice3.Checked)
            {
                SetCheckBoxColor(chkChoice3, Color.Black, Color.White);
            }
        }

        private void chkChoice4_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChoice4.Checked)
            {
                chkChoice1.Checked = false;
                chkChoice2.Checked = false;
                chkChoice3.Checked = false;
                _examineeAnswer = chkChoice4.Text;
                SetCheckBoxColor(chkChoice4, Color.White, Color.FromArgb(67, 166, 235));
            }
            else
            {
                SetCheckBoxColor(chkChoice4, Color.Black, Color.White);
            }
        }
        private void chkChoice4_MouseEnter(object sender, EventArgs e)
        {
            if (!chkChoice4.Checked)
            {
                SetCheckBoxColor(chkChoice4, Color.Black, Color.LightYellow);
            }
        }
        private void chkChoice4_MouseLeave(object sender, EventArgs e)
        {
            if (!chkChoice4.Checked)
            {
                SetCheckBoxColor(chkChoice4, Color.Black, Color.White);
            }
        }
    }
}