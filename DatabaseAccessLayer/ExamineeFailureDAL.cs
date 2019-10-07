using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;
using ValueObject.ViewModel;
using System.Data.Entity;

namespace DatabaseAccessLayer
{
    public class ExamineeFailureDAL
    {
        private ExaminationContext _context;

        public ExamineeFailureDAL()
        {

        }

        public int GetCurrentWaitDays()
        {
            int currentWaitDays = 0;

            using (_context = new ExaminationContext())
            {
                ExamineeFailure examineeFailure = _context.ExamineeFailure.OrderByDescending(e => e.ExamineeFailureId).FirstOrDefault();

                if (examineeFailure != null)
                {
                    currentWaitDays = examineeFailure.WaitDays;
                }
            }

            return currentWaitDays;
        }

        public void SetWaitDays(ExamineeFailure examineeFailure)
        {
            using (_context = new ExaminationContext())
            {
                examineeFailure.DateTimeModified = GetServerDateTime(_context);
                _context.ExamineeFailure.Add(examineeFailure);
                _context.SaveChanges();
            }
        }

        public List<ExamineeFailureViewModel> GetWaitDaysHistory()
        {
            List<ExamineeFailureViewModel> history;

            using (_context = new ExaminationContext())
            {
                history = _context.ExamineeFailure.Include(u => u.SystemUser)
                    .OrderByDescending(o => o.ExamineeFailureId)
                    .Select(p => new ExamineeFailureViewModel
                    {
                        WaitDays = p.WaitDays,
                        DateTimeModified = p.DateTimeModified,
                        ModifiedBy = string.Concat("[", p.SystemUser.Username, "] - ", p.SystemUser.FirstName, " ", p.SystemUser.LastName)
                    })
                    .ToList();
            }

            return history;
        }

        private DateTime GetServerDateTime(ExaminationContext context)
        {
            return context.Database.SqlQuery<DateTime>("Select GETDATE();").FirstOrDefault();
        }
    }
}
