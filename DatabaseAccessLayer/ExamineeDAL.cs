using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;
using ValueObject;
using ValueObject.ViewModel;

namespace DatabaseAccessLayer
{
    public class ExamineeDAL
    {
        private ExaminationContext _context;

        public ExamineeDAL()
        {

        }

        public void InsertExaminee(Examinee examinee)
        {
            using (_context = new ExaminationContext())
            {
                _context.Examinee.Add(examinee); //_context.Entry(examinee).State = EntityState.Added;
                _context.SaveChanges();
            }
        }

        public void UpdateExaminee(Examinee examinee)
        {
            using (_context = new ExaminationContext())
            {
                _context.Entry(examinee).State = EntityState.Modified;
                _context.Entry(examinee).Property(p => p.DateTimeAdded).IsModified = false;
                _context.SaveChanges();
            }
        }

        public void DeleteExaminee(int examineeId)
        {
            using (_context = new ExaminationContext())
            {
                //Examinee examinee = new Examinee { ExamineeId = examineeId };
                //_context.Entry(examinee).State = EntityState.Deleted;
                _context.Examinee.Remove(_context.Examinee
                    //.Single(e => e.ExamineeId == examineeId));
                    .SingleOrDefault(e => e.ExamineeId == examineeId
                              && e.ExamTakes == 0));
                _context.SaveChanges();
            }
        }

        public PagedResult<ExamineeViewModel> GetExamineeListByNameOrEmailViewModel(int pageNumber, int pageSize, string nameOrEmail)
        {
            PagedResult<ExamineeViewModel> examineeListViewModel;

            using (_context = new ExaminationContext())
            {
                examineeListViewModel = _context.Examinee.OrderBy(e => e.ExamineeId)
                    .Where(e => (e.LastName.Contains(nameOrEmail) ||
                                e.FirstName.Contains(nameOrEmail) ||
                                e.MiddleName.Contains(nameOrEmail)) ||
                                e.Email.Contains(nameOrEmail))
                        .Select(e => new ExamineeViewModel
                        {
                            ExamineeId = e.ExamineeId,
                            LastName = e.LastName,
                            FirstName = e.FirstName,
                            MiddleName = e.MiddleName,
                            Address = e.Address,
                            City = e.City,
                            ContactNo = e.ContactNo,
                            Email = e.Email,
                            LastSchoolAttended = e.LastSchoolAttended,
                            YearGraduated = e.YearGraduated,
                            ExamTakes = e.ExamTakes,
                            DateTimeAdded = e.DateTimeAdded
                        })
                        .GetPaged(pageNumber, pageSize);
            }

            return examineeListViewModel;
        }

        public PagedResult<ExamineeViewModel> GetExamineeListViewModel(int pageNumber, int pageSize)
        {
            PagedResult<ExamineeViewModel> examineeListViewModel;

            using (_context = new ExaminationContext())
            {
                examineeListViewModel = _context.Examinee.OrderBy(e => e.ExamineeId)
                    .Select(e => new ExamineeViewModel
                    {
                        ExamineeId = e.ExamineeId,
                        LastName = e.LastName,
                        FirstName = e.FirstName,
                        MiddleName = e.MiddleName,
                        Address = e.Address,
                        City = e.City,
                        ContactNo = e.ContactNo,
                        Email = e.Email,
                        LastSchoolAttended = e.LastSchoolAttended,
                        YearGraduated = e.YearGraduated,
                        ExamTakes = e.ExamTakes,
                        DateTimeAdded = e.DateTimeAdded
                    })
                    .GetPaged(pageNumber, pageSize);


                //var ex = _context.Examinee.Where(e => e.DateTimeAdded.Value.Year == 2019)
                //    .ToList();

                //foreach (var e in ex)
                //{
                //    Console.WriteLine(e.LastName);
                //}

                //Console.WriteLine("First Row On Page: " + examineeListViewModel.FirstRowOnPage);
                //Console.WriteLine("Last Row On Page: " + examineeListViewModel.LastRowOnPage);

                //Console.WriteLine("Page Size: " + examineeListViewModel.PageSize);
                //Console.WriteLine("Current Page: " + examineeListViewModel.CurrentPage);
                //Console.WriteLine("Row Count: " + examineeListViewModel.RowCount);
                //Console.WriteLine("Page Count: " + examineeListViewModel.PageCount);
                //Console.WriteLine("List Row Count: " + examineeListViewModel.Results.Count);

                //DateTime dbServerTime = GetServerDateTime(_context);
                //Console.WriteLine("Database date and time: " + dbServerTime);
            }


            return examineeListViewModel;
        }

        /// <summary>
        /// Get database server current date and time.
        /// </summary>
        /// <param name="context">DBContext</param>
        /// <returns></returns>
        public DateTime GetServerDateTime()
        {
            //DateTime dbServerDateTime = _context.Database.SqlQuery<DateTime>("Select GETDATE();").FirstOrDefault();
            //return dbServerDateTime;
            using (_context = new ExaminationContext())
            {
                return _context.Database.SqlQuery<DateTime>("Select GETDATE();").FirstOrDefault();
            }
        }

        public int GetExamineeCount()
        {
            int examineeCount;

            using (_context = new ExaminationContext())
            {
                examineeCount = _context.Examinee.Count();
            }

            return examineeCount;
        }
    }
}