using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ValueObject.ViewModel;
using ValueObject;

namespace DatabaseAccessLayer
{
    public class ExamDAL
    {
        private ExaminationContext _context;

        public ExamDAL()
        {

        }

        public void InsertExam(Exam exam)
        {
            using (_context = new ExaminationContext())
            {
                exam.DateTimeAdded = GetServerDateTime(_context);
                _context.Exam.Add(exam);
                _context.SaveChanges();
            }
        }

        public void DeleteExam(int examId)
        {
            using (_context = new ExaminationContext())
            {
                //Examinee examinee = new Examinee { ExamineeId = examineeId };
                //_context.Entry(examinee).State = EntityState.Deleted;
                _context.Exam.Remove(_context.Exam.SingleOrDefault(e => e.ExamId == examId));
                _context.SaveChanges();
            }
        }

        public void SendExamToArchieve(int examId)
        {
            using (_context = new ExaminationContext())
            {
                _context.Exam.Where(e => e.ExamId == examId).Single().Archived = true;
                _context.SaveChanges();
            }
        }
        
        public List<ExamViewModel> GetExamViewModelList()
        {
            List<ExamViewModel> examViewModelList;

            using (_context = new ExaminationContext())
            {
                examViewModelList = _context.Exam.Include(u => u.SystemUser)
                    .Include(s => s.Subject)
                    .Include(q => q.QuestionBank)
                    .Where(e => e.Archived == false)
                    .OrderBy(e => e.ExamId)
                    .Select(e => new ExamViewModel
                    {
                        UserId = e.UserId,
                        LastName = e.SystemUser.LastName,
                        FirstName = e.SystemUser.FirstName,
                        MiddleName = e.SystemUser.MiddleName,
                        Username = e.SystemUser.Username,
                        ExamId = e.ExamId,
                        SubjectId = e.SubjectId,
                        SubjectName = e.Subject.SubjectName,
                        ExaminationType = e.ExaminationType,
                        ItemCount = e.ItemCount,
                        TimeLimit = e.TimeLimit,
                        DateTimeAdded = e.DateTimeAdded,
                        IncompleteQuestionCount = e.QuestionBank.Where(q => q.Question != null && q.Question != string.Empty).Count()
                    })
                    .ToList();
            }

            return examViewModelList;
        }

        public List<Exam> GetActiveExamList()
        {
            List<Exam> examList;

            using (_context = new ExaminationContext())
            {
                examList = _context.Exam.Include(q => q.QuestionBank).Include(s => s.Subject).Include(s => s.QuestionBank)
                    .Where(q => q.Archived == false && q.QuestionBank.Any(z => z.Question != null))
                    .ToList();
            }

            return examList;
        }

        public DateTime GetDateTime()
        {
            using (_context = new ExaminationContext())
            {
                return _context.Database.SqlQuery<DateTime>("Select GETDATE();").FirstOrDefault();
            }
        }

        private DateTime GetServerDateTime(ExaminationContext context)
        {
            //DateTime dbServerDateTime = _context.Database.SqlQuery<DateTime>("Select GETDATE();").FirstOrDefault();
            //return dbServerDateTime;
            return context.Database.SqlQuery<DateTime>("Select GETDATE();").FirstOrDefault();
        }
    }
}