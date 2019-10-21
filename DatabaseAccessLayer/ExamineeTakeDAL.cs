﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ValueObject;
using ValueObject.Report;
using ValueObject.ViewModel;

namespace DatabaseAccessLayer
{
    public class ExamineeTakeDAL
    {
        private ExaminationContext _context;

        public ExamineeTakeDAL()
        {

        }

        public void UpdateExamineeTake(ExamineeTake examineeTake)
        {
            using (_context = new ExaminationContext())
            {
                //_context.ExamineeTake.Attach(examineeTake);
                //_context.ExamineeAnswer.AddRange(examineeTake.ExamineeExam.(s => s.ExamineeAnswer));

                //_context.Entry(examineeTake).State = EntityState.Modified;
                _context.ExamineeExam.AddRange(examineeTake.ExamineeExam);
                _context.Entry(examineeTake).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }

        public void UpdateOne(ExamineeTake examineeTake)
        {
            using (_context = new ExaminationContext())
            {
                //examineeTake.ExamDateTimeTaken = DateTime.Now.Date;
                _context.ExamineeExam.AddRange(examineeTake.ExamineeExam);
                //_context.ExamineeTake.Attach(examineeTake);
                _context.Entry(examineeTake).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }

        //public void InsertExamineeExam(List<ExamineeExam> examineeExamList)
        //{
        //    using (_context = new ExaminationContext())
        //    {
        //        _context.ExamineeExam.AddRange(examineeExamList);
        //        _context.SaveChanges();
        //    }
        //}

        public ExamineeTake GetExamineeTakeInfo(string examCode)
        {
            ExamineeTake examineeTake;

            using (_context = new ExaminationContext())
            {
                examineeTake = _context.ExamineeTake.Where(e => e.ExamCode == examCode && e.ExamDateTimeTaken == null)
                    .Include(s => s.ExamineeExam)
                    .Include(s => s.ExamineeExam.Select(e => e.Exam))
                    .Include(s => s.ExamineeExam.Select(e => e.ExamineeAnswer))
                    //.Include(s => s.ExamineeExam.Select(e => e.ExamineeAnswer.Select(q => q.QuestionBank)))
                    .SingleOrDefault();

                if (examineeTake != null)   //  if not null then set passing rate
                {
                    examineeTake.PassingRate = _context.PassingRate.OrderByDescending(o => o.PassingRateId).FirstOrDefault().Rate;
                }
            }

            return examineeTake;
        }
        
        public string InsertExamineeTake(ExamineeTake examineeTake)
        {
            using (_context = new ExaminationContext())
            {
                examineeTake.CodeDateTimeIssued = GetServerDateTime(_context);
                examineeTake.UserId = UserInfo.UserId;
                _context.ExamineeTake.Add(examineeTake);
                _context.SaveChanges();
            }

            return examineeTake.ExamCode;
        }

        public string[] GetExamineeCodesByExamineeId(int examineeId)
        {
            using (_context = new ExaminationContext())
            {
                return _context.ExamineeTake.Where(e => e.ExamineeId == examineeId)
                    .OrderBy(e => e.CodeDateTimeIssued)
                    .Select(e => e.ExamCode)
                    .ToArray();
            }
        }

        public bool IsUniqueExamCode(string examCode)
        {
            bool isUnique;

            using (_context = new ExaminationContext())
            {
                isUnique = _context.ExamineeTake.Where(e => e.ExamCode == examCode).Count() == 0;
            }

            return isUnique;
        }

        public List<ExamineeTakeStatusViewModel> GetExamineeTakeStatusViewModel(int currentDaysToWait, string nameOrEmail)
        {
            List<ExamineeTakeStatusViewModel> examineeTakeStatus;

            using (_context = new ExaminationContext())
            {
                DateTime currentDateTime = GetServerDateTime(_context);

                examineeTakeStatus = _context.Examinee.Include(e => e.ExamineeTake)
                    .Where(e => (e.LastName.Contains(nameOrEmail) ||
                                e.FirstName.Contains(nameOrEmail) ||
                                e.MiddleName.Contains(nameOrEmail)) ||
                                e.Email.Contains(nameOrEmail))
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

        public IList<ExamineeCodeReport> GetExamineeCodeReport(DateTime startDate, DateTime? endDate = null)
        {
            IList<ExamineeCodeReport> report;

            using (_context = new ExaminationContext())
            {
                if (endDate == null)
                {
                    report = _context.ExamineeTake.Include(e => e.Examinee).Include(e => e.SystemUser)
                        .Where(e => DbFunctions.TruncateTime(e.CodeDateTimeIssued) == DbFunctions.TruncateTime(startDate))
                        .Select(s => new ExamineeCodeReport
                        {
                            FullName = string.Concat(s.Examinee.LastName + ", " + s.Examinee.FirstName + " " + s.Examinee.MiddleName),
                            Email = s.Examinee.Email,
                            ExamCode = s.ExamCode,
                            CodeDateTimeIssued = s.CodeDateTimeIssued,
                            IssuedBy = string.Concat("[" + s.SystemUser.Username + "] - " + s.SystemUser.LastName + ", " + s.SystemUser.FirstName)
                        })
                        .ToList();
                }
                else
                {
                    report = _context.ExamineeTake.Include(e => e.Examinee).Include(e => e.SystemUser)
                        .Where(e => DbFunctions.TruncateTime(e.CodeDateTimeIssued) >= DbFunctions.TruncateTime(startDate)
                                    && DbFunctions.TruncateTime(e.CodeDateTimeIssued) <= DbFunctions.TruncateTime(endDate))
                        .Select(s => new ExamineeCodeReport
                        {
                            FullName = string.Concat(s.Examinee.LastName + ", " + s.Examinee.FirstName + " " + s.Examinee.MiddleName),
                            Email = s.Examinee.Email,
                            ExamCode = s.ExamCode,
                            CodeDateTimeIssued = s.CodeDateTimeIssued,
                            IssuedBy = string.Concat("[" + s.SystemUser.Username + "] - " + s.SystemUser.LastName + ", " + s.SystemUser.FirstName)
                        })
                        .ToList();
                }
            }

            return report;
        }

        private DateTime GetServerDateTime(ExaminationContext context)
        {
            //DateTime dbServerDateTime = _context.Database.SqlQuery<DateTime>("Select GETDATE();").FirstOrDefault();
            //return dbServerDateTime;
            return context.Database.SqlQuery<DateTime>("Select GETDATE();").FirstOrDefault();
        }
    }
}