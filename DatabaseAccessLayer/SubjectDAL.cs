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
    public class SubjectDAL
    {
        private ExaminationContext _context;

        public SubjectDAL()
        {

        }

        public void InsertSubject(Subject subject)
        {
            using (_context = new ExaminationContext())
            {
                _context.Subject.Add(subject); //_context.Entry(subject).State = EntityState.Added;
                _context.SaveChanges();
            }
        }

        public void UpdateSubject(Subject subject)
        {
            using (_context = new ExaminationContext())
            {
                _context.Entry(subject).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }

        public void DeleteSubject(int subjectId)
        {
            using (_context = new ExaminationContext())
            {
                //Subject subject = new Subject { SubjectId = subjectId };
                //_context.Entry(subject).State = EntityState.Deleted;
                _context.Subject.Remove(_context.Subject.Single(s => s.SubjectId == subjectId));
                _context.SaveChanges();
            }
        }

        public bool IsSubjectDuplicate(Subject subject)
        {
            bool exists;

            using (_context = new ExaminationContext())
            {
                if (subject.SubjectId == 0)
                {
                    exists = _context.Subject.Where(s => s.SubjectName == subject.SubjectName)
                                .SingleOrDefault() == null;
                }
                else
                {
                    exists = _context.Subject.Where(s => s.SubjectName == subject.SubjectName
                                && s.SubjectId != subject.SubjectId)
                                .SingleOrDefault() == null;
                }
            }

            return exists;
        }

        public List<Subject> GetSubjectList()
        {
            List<Subject> subjectList;

            using (_context = new ExaminationContext())
            {
                subjectList = _context.Subject.OrderBy(s => s.SubjectId)
                    .ToList();
            }

            return subjectList;
        }

        public List<SubjectViewModel> GetSubjectViewModelList()
        {
            List<SubjectViewModel> subjectViewModelList;

            using (_context = new ExaminationContext())
            {
                subjectViewModelList = _context.Subject.OrderBy(s => s.SubjectId).Include(x => x.Exam)
                    .Select(s => new SubjectViewModel
                    {
                        SubjectId = s.SubjectId,
                        SubjectName = s.SubjectName,
                        Description = s.Description,
                        InExam = s.Exam.Count() > 0
                    })
                    .ToList();

                //  SUBJECTVIEWMODEL!
                //var ss = _context.Subject.Include(x => x.Exam).OrderBy(x => x.SubjectId)
                //    .Select(x => new { SubjectName = x.SubjectName,
                //        SubjectId = x.SubjectId,
                //        Description = x.Description,
                //        ExamCount = x.Exam.Count()
                //    }).ToList();

                //foreach (var z in ss)
                //{
                //    Console.WriteLine(z.SubjectName + " => " + z.ExamCount);
                //}
            }

            return subjectViewModelList;
        }
    }
}