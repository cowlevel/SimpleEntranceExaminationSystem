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
                _context.Exam.Add(exam);
                _context.SaveChanges();
            }
        }

        public void DeleteExaminee(int examId)
        {
            using (_context = new ExaminationContext())
            {
                //Examinee examinee = new Examinee { ExamineeId = examineeId };
                //_context.Entry(examinee).State = EntityState.Deleted;
                _context.Exam.Remove(_context.Exam.SingleOrDefault(e => e.ExamId == examId));
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
                        ItemCount = e.ItemCount,
                        ExamType = e.ExamType,
                        DateTimeAdded = e.DateTimeAdded
                    })
                    .ToList();
            }

            return examViewModelList;
        }
    }
}