using DatabaseAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility;
using ValueObject;
using ValueObject.ViewModel;

namespace BusinessLogicLayer
{
    public class ExamineeTakeBLL
    {
        private ExamineeTakeDAL _examineeTakeDAL;

        public ExamineeTakeBLL()
        {
            _examineeTakeDAL = new ExamineeTakeDAL();
        }

        public void UpdateExamineeTake(ExamineeTake examineeTake)
        {
            _examineeTakeDAL.UpdateExamineeTake(examineeTake);
        }

        public void InsertExamineeExam(List<ExamineeExam> examineeExamList)
        {
            _examineeTakeDAL.InsertExamineeExam(examineeExamList);
        }

        public ExamineeTake GetExamineeTakeInfo(string examCode)
        {
            return _examineeTakeDAL.GetExamineeTakeInfo(examCode);
        }

        public void UpdateOne(ExamineeTake examineeTake)
        {
            _examineeTakeDAL.UpdateOne(examineeTake);
        }

        public void SetExamineeTakeChildInfo(ExamineeTake examineeTake)
        {
            ExamBLL examBLL = new ExamBLL();
            List<Exam> examList = examBLL.GetActiveExamList();
            List<Exam> newExamList = new List<Exam>();
            List<QuestionBank> questionBankList;
            string[] subjects;

            subjects = examList.Select(s => s.Subject.SubjectName).Distinct().ToArray();
            subjects.Shuffle();

            foreach (var subj in subjects)
            {
                newExamList.AddRange(examList.Where(ex => ex.Subject.SubjectName == subj));
            }

            foreach (var exam in newExamList)
            {
                //Console.WriteLine(exam.Subject.SubjectName);
                examineeTake.ExamineeExam.Add(new ExamineeExam
                {
                    ExamineeTakeId = examineeTake.ExamineeTakeId,
                    ExamId = exam.ExamId,
                    Score = 0
                    //Exam = exam
                });

                questionBankList = exam.QuestionBank.ToList();
                questionBankList.Shuffle();

                foreach (var question in questionBankList)
                //foreach (var question in exam.QuestionBank)
                {
                    examineeTake.ExamineeExam.Single(s => s.ExamineeTakeId == examineeTake.ExamineeTakeId && s.ExamId == exam.ExamId)
                        .ExamineeAnswer.Add(new ExamineeAnswer
                        {
                            QuestionId = question.QuestionId,
                            IsCorrect = false
                            //QuestionBank = question
                        });
                }
            }
        }

        public string InsertExamineeTake(ExamineeTake examineeTake)
        {
            bool doLoop = true;
            string examCode = string.Empty;

            while (doLoop)
            {
                examCode = CreateExamCode();
                doLoop = _examineeTakeDAL.IsUniqueExamCode(examCode) == true ? false : true;
            }

            examineeTake.ExamCode = examCode;

            return _examineeTakeDAL.InsertExamineeTake(examineeTake);
        }

        public List<ExamineeTakeStatusViewModel> GetExamineeTakeStatusViewModel(int currentDaysToWait, string nameOrEmail)
        {
            return _examineeTakeDAL.GetExamineeTakeStatusViewModel(currentDaysToWait, nameOrEmail);
        }

        private string CreateExamCode()
        {
            Random random = new Random();
            StringBuilder sb = new StringBuilder();
            int choice = 0;
            int codeChar = 0;

            for (int i = 0; i < 8; i++)
            {
                choice = random.Next(0, 2);
                //Console.WriteLine(choice);
                if (choice == 0)
                {
                    codeChar = random.Next(65, 90); //  Upper case letters
                }
                else
                {
                    codeChar = random.Next(48, 57); //  Numbers
                }

                sb.Append((char)codeChar);
            }

            return sb.ToString();
        }
    }
}