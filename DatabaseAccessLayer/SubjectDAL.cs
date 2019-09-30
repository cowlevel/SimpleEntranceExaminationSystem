using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

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
    }
}