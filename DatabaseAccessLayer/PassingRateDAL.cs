using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ValueObject;
using ValueObject.ViewModel;

namespace DatabaseAccessLayer
{
    public class PassingRateDAL
    {
        private ExaminationContext _context;

        public PassingRateDAL()
        {

        }

        public int GetCurrentPassingRate()
        {
            int currentPassingRate = 0;

            using (_context = new ExaminationContext())
            {
                PassingRate lastPassingRate = _context.PassingRate.OrderByDescending(p => p.PassingRateId).FirstOrDefault();

                if (lastPassingRate != null)
                {
                    currentPassingRate = lastPassingRate.Rate;
                }
            }

            return currentPassingRate;
        }

        public List<PassingRateViewModel> GetPassingRateHistory()
        {
            List<PassingRateViewModel> history;

            using (_context = new ExaminationContext())
            {
                history = _context.PassingRate.Include(u => u.SystemUser)
                    .OrderByDescending(o => o.PassingRateId)
                    .Select(p => new PassingRateViewModel
                    {
                        Rate = string.Concat(p.Rate, "%"),
                        DateTimeModified = p.DateTimeModified,
                        ModifiedBy = string.Concat("[", p.SystemUser.Username, "] - ", p.SystemUser.FirstName, " ", p.SystemUser.LastName)
                    })
                    .ToList();
            }

            return history;
        }

        public void SetPassingRate(PassingRate passingRate)
        {
            using (_context = new ExaminationContext())
            {
                passingRate.DateTimeModified = GetServerDateTime(_context);
                _context.PassingRate.Add(passingRate);
                _context.SaveChanges();
            }
        }

        private DateTime GetServerDateTime(ExaminationContext context)
        {
            return context.Database.SqlQuery<DateTime>("Select GETDATE();").FirstOrDefault();
        }
    }
}