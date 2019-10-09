using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject.ViewModel;
using System.Data.Entity;

namespace DatabaseAccessLayer
{
    public class ExamineeTakeDAL
    {
        private ExaminationContext _context;

        public ExamineeTakeDAL()
        {

        }

        private DateTime GetServerDateTime(ExaminationContext context)
        {
            //DateTime dbServerDateTime = _context.Database.SqlQuery<DateTime>("Select GETDATE();").FirstOrDefault();
            //return dbServerDateTime;
            return context.Database.SqlQuery<DateTime>("Select GETDATE();").FirstOrDefault();
        }

        public List<ExamineeTakeStatusViewModel> GetExamineeTakeStatusViewModel(int currentDaysToWait)
        {
            List<ExamineeTakeStatusViewModel> examineeTakeStatus;

            using (_context = new ExaminationContext())
            {
                DateTime currentDateTime = GetServerDateTime(_context);

                examineeTakeStatus = _context.Examinee.Include(e => e.ExamineeTake)
                    .GroupBy(g => new
                    {
                        g.ExamineeId,
                        CurrentDateTime = currentDateTime,
                        FullName = string.Concat(g.LastName + ", " + g.FirstName + " " + (string.IsNullOrEmpty(g.MiddleName) ? "" : g.MiddleName)),
                        g.Email,
                        g.ExamineeTake.OrderByDescending(o => o.CodeDateTimeIssued).FirstOrDefault().CodeDateTimeIssued
                    })
                    .Select(e => new ExamineeTakeStatusViewModel
                    {
                        ExamineeId = e.Key.ExamineeId,
                        FullName = e.Key.FullName,
                        Email = e.Key.Email,
                        CurrentDateTime = e.Key.CurrentDateTime,
                        CodeIssuedDateTime = e.Key.CodeDateTimeIssued,
                        AllowExamAfterDateTime = e.Key.CodeDateTimeIssued == null ? null : DbFunctions.AddDays(e.Key.CodeDateTimeIssued, currentDaysToWait)
                    })
                    .ToList();
            }

            return examineeTakeStatus;
        }
    }
}
