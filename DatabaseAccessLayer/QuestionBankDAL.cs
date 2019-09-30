using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;
using ValueObject.ViewModel;

namespace DatabaseAccessLayer
{
    public class QuestionBankDAL
    {
        private ExaminationContext _context;

        public QuestionBankDAL()
        {

        }

        public void InsertQuestion(QuestionBank question)
        {
            using (_context = new ExaminationContext())
            {
                _context.QuestionBank.Add(question); //_context.Entry(question).State = EntityState.Added;
                _context.SaveChanges();
            }
        }

        public void UpdateQuestion(QuestionBank question)
        {
            using (_context = new ExaminationContext())
            {
                _context.Entry(question).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }

        //public void DeleteQuestion(QuestionBank question)
        //{
        //    using (_context = new ExaminationContext())
        //    {
        //        //QuestionBank question = new QuestionBank { QuestionId = questionId };
        //        //_context.Entry(question).State = EntityState.Deleted;
        //        //_context.QuestionBank.Remove(question);
        //        _context.Entry(question).State = EntityState.Deleted;

        //        Exam exam = _context.Exam.Where(e => e.ExamId == question.ExamId).Single();
        //        exam.ItemCount = exam.ItemCount - 1;

        //        _context.SaveChanges();
        //    }
        //}

        public List<QuestionBank> GetQuestionBankList(int examId)
        {
            List<QuestionBank> questionBankList;

            using (_context = new ExaminationContext())
            {
                questionBankList = _context.QuestionBank
                    .Where(q => q.ExamId == examId)
                    .OrderBy(q => q.QuestionNumber)
                    //.Select(q => new QuestionBankViewModel
                    //{
                    //    ExamId = q.ExamId,
                    //    QuestionId = q.QuestionId,
                    //    Question = q.Question,
                    //    CorrectAnswer = q.CorrectAnswer,
                    //    WrongAnswer1 = q.WrongAnswer1,
                    //    WrongAnswer2 = q.WrongAnswer2,
                    //    WrongAnswer3 = q.WrongAnswer3,
                    //    DateTimeAdded = q.DateTimeAdded
                    //})
                    .ToList();
            }

            return questionBankList;
        }

        public DateTime GetServerDateTime()
        {
            //DateTime dbServerDateTime = _context.Database.SqlQuery<DateTime>("Select GETDATE();").FirstOrDefault();
            //return dbServerDateTime;
            using (_context = new ExaminationContext())
            {
                return _context.Database.SqlQuery<DateTime>("Select GETDATE();").FirstOrDefault();
            }
        }
    }
}