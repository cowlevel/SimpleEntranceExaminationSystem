using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Globalization;
using System.Diagnostics;
using System.Timers;

namespace ConsoleApp2EF
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (var context = new Model1())
            //{
            //    var ctx = context.Exam.Include(u => u.SystemUser)
            //                          .Include(u => u.QuestionBank)
            //                          .Where(u => u.UserId == 1)
            //                          .ToList();

            //    foreach (var item in ctx)
            //    {
            //        Console.WriteLine("Exam Id: " + item.ExamId);
            //        Console.WriteLine("Created by: " + item.SystemUser.LastName);
            //    }
            //}

            //using (var context = new Model1())
            //{
            //    var ctx = context.Exam.Include(e => e.QuestionBank)
            //        .Where(e => e.ExamId == 1)
            //        .Select(e => new
            //        {
            //            ExamId = e.ExamId,
            //            QuestionCount = e.QuestionBank.Where(x=>x.Question!=string.Empty).Count()
            //        })
            //        .ToList();



            //    foreach (var c in ctx)
            //    {
            //        Console.WriteLine("ID: " + c.ExamId);
            //        Console.WriteLine("Count: " + c.QuestionCount);
            //    }
            //}



            using (var context = new Model1())
            {
                //var examResult = context.ExamineeTake
                //    .GroupBy(g => new
                //    {
                //        g.Examinee.ExamineeId,
                //        g.Examinee.LastName,
                //        g.Exam.Subject.SubjectName
                //    })
                //    .Select(x => new
                //    {
                //        //Id= x.Key,
                //        ExamineeId = x.Key.ExamineeId,
                //        ExamineeName = x.Key.LastName,
                //        ExamCode = x.FirstOrDefault().ExamCode,
                //        Subject = x.FirstOrDefault().Exam.Subject.SubjectName,
                //        Score = x.Sum(s => s.Score)

                //    })
                //    .Distinct()
                //    .ToList();
                //var examResult = context.ExamineeTake
                //    .GroupBy(g => new
                //    {
                //        g.Examinee.ExamineeId,
                //        //g.Examinee.LastName,
                //        g.Exam.Subject.SubjectName
                //    })
                //    .Select(x => new
                //    {
                //        //Id= x.Key,
                //        ExamineeId = x.Key.ExamineeId
                //        //ExamineeName = x.Key.LastName,
                //        //xamineeName = x.FirstOrDefault().Examinee.LastName
                //        //ExamCode = x.FirstOrDefault().ExamCode,
                //        //Subject = x.FirstOrDefault().Exam.Subject.SubjectName,
                //        //Score = x.Sum(s => s.Score)

                //    })
                //    //.Distinct()
                //    .ToList();

                //int totalItem = 15;
                //int score = 4;

                //double mark = score * 100.0 / totalItem;

                //Console.WriteLine("Mark: " + mark.ToString());
                //Console.WriteLine(string.Format("{0}%", Math.Round(mark)));
                //Console.WriteLine("{0:F}%", 51 / 100.00 * 100);


                /*
                 * QUERY FOR EXAM TAKEN, PASS OR FAIL - add more code
                 * 
                 * 
                 */


                //var examResult = context.ExamineeTake
                //    //.OrderBy(o=>o.Score)
                //    .GroupBy(g => new
                //    {
                //        g.ExamineeId,
                //        FullName = g.Examinee.FirstName + " " + g.Examinee.LastName,
                //        g.Exam.Subject,
                //        g.ExamCode,
                //        g.DateTimeTaken
                //    })
                //    .Select(s => new
                //    {
                //        ExamineeId = s.Key.ExamineeId,
                //        FullName = s.Key.FullName,
                //        SubjectName = s.Key.Subject.SubjectName,
                //        ExamCode = s.Key.ExamCode,
                //        ItemCount = s.Sum(x => x.Exam.ItemCount),
                //        TotalScore = s.Sum(x => x.Score),
                //        Percentage = Math.Round((double)s.Sum(x => x.Score) * 100.0 / s.Sum(x => x.Exam.ItemCount)),
                //        s.Key.DateTimeTaken,
                //        PassOrFailed = Math.Round((double)s.Sum(x => x.Score) * 100.0 / s.Sum(x => x.Exam.ItemCount)) >= 50 ? "PASS" : "FAILED"
                //    })
                //    //.Where(x=>x.Percentage>=50)
                //    //.Where(x=>x.DateTimeTaken.Value.Year==2019)
                //    .ToList();

                //foreach (var ex in examResult)
                //{
                //    Console.WriteLine("Examinee ID: " + ex.ExamineeId + " | Name: " + ex.FullName);
                //    Console.WriteLine("Exam Code: " + ex.ExamCode + " | Subject: " + ex.SubjectName + " | Item Count: " + ex.ItemCount + " | Total Score: " + ex.TotalScore + " | Percentage: " + string.Format("{0}%", ex.Percentage));
                //    Console.WriteLine("Date Time Taken: " + ex.DateTimeTaken + "| Exam Result: " + ex.PassOrFailed);
                //    Console.WriteLine("-----------------------------------------------");
                //    //Console.WriteLine();
                //    //Console.WriteLine("Examinee Id:" + ex.ExamineeId + "|Examinee Name:" + ex.ExamineeName + "|Exam Code:" + ex.ExamCode + "|Subject:" + ex.Subject + "|Score   :" + ex.Score);
                //    //Console.WriteLine(ex.Score);
                //}


                /* ====QUERY FOR LIST OF EXAM MADE IN A YEAR
                var examList = context.Exam
                    .GroupBy(g => new
                    {
                        g.DateTimeAdded.Value.Year,
                        g.Subject.SubjectId,
                        g.Subject.SubjectName//,
                        //g.DateTimeAdded
                    })
                    .Select(s => new
                    {
                        
                        s.Key.SubjectId,
                        s.Key.SubjectName,
                        //s.Key.DateTimeAdded//,
                        TotalItemCount = s.Sum(t=>t.ItemCount),
                        TotalTimeLimit = s.Sum(x=>x.TimeLimit) ,
                        YearAdded = s.Key.Year
                    })
                    //.Distinct()
                    .ToList();

                foreach (var ex in examList)
                {
                    Console.WriteLine("Subject Id: " + ex.SubjectId + "|Subject Name: " + ex.SubjectName);
                    Console.WriteLine("Year Added: " + ex.YearAdded + "|Total Item: " + ex.TotalItemCount + "|Total Time Limit: " + Conversions.TimeMinuteToString(ex.TotalTimeLimit));
                }*/



                //==============TESTING IENUMERABLE VS IQUERYABLE

                //var users = context.SystemUser;

                //IEnumerable<SystemUser> asEnumerable = users.Where(u => u.AccountStatus == true && u.UserId < 20)
                //    .AsEnumerable()
                //    .Select(u => new SystemUser
                //    {
                //        UserId = u.UserId,
                //        LastName = Conversions.TimeMinuteToString(u.UserId)
                //    }).ToList();



                ////var asQueryable = users.Where(u => u.AccountStatus == true && u.UserId < 20)

                ////    .Select(u => new 
                ////    {
                ////        UserId = u.UserId,
                ////        LastName =u.LastName// Conversions.TimeMinuteToString(u.UserId)
                ////    });

                ////var userResult = asQueryable.ToList();

                //foreach (var item in asEnumerable)
                //{
                //    Console.WriteLine(item.LastName);
                //}


                //var subjects = context.Subject.Include(x => x.Exam)
                //    .Select(s => new
                //    {
                //        s.SubjectId,
                //        s.SubjectName,
                //        s.Description,
                //        ExamCount = s.Exam.Count()
                //    })
                //    .ToList();

                //foreach (var s in subjects)
                //{
                //    Console.WriteLine(s.SubjectName + " " + s.ExamCount);
                //}

                //  DAYS TO WAIT
                ////var getDaysToWait = context.Examinee.Include(e => e.ExamineeTake)

                ////    //.OrderByDescending(o => o.ExamineeTake.)
                ////    .Select(e => new GetDaysToWait
                ////    {
                ////        ExamineeId = e.ExamineeId,
                ////        FullName = e.LastName + ", " + e.FirstName,
                ////        GG = e.ExamineeTake.OrderByDescending(o => o.CodeDateTimeIssued).FirstOrDefault().CodeDateTimeIssued,
                ////        WaitDays = e.ExamineeTake.OrderByDescending(o => o.CodeDateTimeIssued).FirstOrDefault().CodeDateTimeIssued == null ?
                ////                    null : DbFunctions.AddDays(e.ExamineeTake.OrderByDescending(o => o.CodeDateTimeIssued).FirstOrDefault().CodeDateTimeIssued, 60)

                ////    })
                ////    .ToList();

                //DateTime dt = context.Database.SqlQuery< DateTime>("SELECT GETDATE()").First();

                //var getDaysToWait = context.Examinee.Include(e => e.ExamineeTake)
                //    .GroupBy(g => new
                //    {
                //        g.ExamineeId,
                //        CurrentDateTime = dt,
                //        FullName = string.Concat(g.LastName + ", " + g.FirstName + " " + (string.IsNullOrEmpty(g.MiddleName) ? "" : g.MiddleName)),
                //        g.Email,
                //        WaitDays = g.ExamineeTake.OrderByDescending(o => o.CodeDateTimeIssued).FirstOrDefault().CodeDateTimeIssued
                //    })
                //    .Select(e => new GetDaysToWait
                //    {
                //        ExamineeId = e.Key.ExamineeId,
                //        FullName = e.Key.FullName,
                //        EmailX = e.Key.Email,
                //        CurrentDateTime = e.Key.CurrentDateTime,
                //        WaitDays = e.Key.WaitDays == null ? null : DbFunctions.AddDays(e.Key.WaitDays, 60)
                //    })
                //    .ToList();

                //foreach (var examinee in getDaysToWait)
                //{
                //    Console.WriteLine(examinee.ExamineeId + "|" + examinee.FullName + "|" + examinee.CurrentDateTime + "|" + examinee.WaitDays);
                //}






                //var examList = context.Exam.Include(q => q.QuestionBank)
                //    .Where(q => q.Archived == false && q.QuestionBank.Any(z => z.Question != null))
                //    //.GroupBy(g => new
                //    //{
                //    //    g.ExamId,
                //    //    g.Subject.SubjectName,
                //    //    QuestionNumber = g.QuestionBank.Where(q => q.Question != null && q.ExamId == g.ExamId).FirstOrDefault().QuestionNumber,
                //    //    Question = g.QuestionBank.Where(q => q.Question != null && q.ExamId == g.ExamId).FirstOrDefault().Question
                //    //})
                //    //.Select(s => new
                //    //{
                //    //    s.ExamId,
                //    //    s.Subject.SubjectName,
                //    //    s.QuestionBank.FirstOrDefault().QuestionNumber,
                //    //    s.QuestionBank.FirstOrDefault().Question
                //    //})
                //    .ToList();

                //Console.WriteLine("LIST COUNT " + examList.Count);
                //Console.WriteLine("LIST[0] QUESTION COUNT " + examList[0].QuestionBank.Count);
                //foreach (var ex in examList)
                //{
                //    //Console.WriteLine(ex.ExamId + "| "+ ex.Subject.SubjectName + "|" + ex.QuestionBank.FirstOrDefault().QuestionNumber+ ". " + ex.QuestionBank.FirstOrDefault().Question);
                //    Console.WriteLine("ID:" + ex.ExamId + "|" + ex.Subject.SubjectName);

                //    foreach (var x in ex.QuestionBank)
                //    {
                //        Console.WriteLine("-----" + x.QuestionNumber + ". " + x.Question);
                //    }
                //}
            }


            //Random random = new Random();
            //int choice = 0;
            //int codeChar = 0;
            //StringBuilder sb = new StringBuilder();

            //for (int i = 0; i < 8; i++)
            //{
            //    choice = random.Next(0, 2);
            //    Console.WriteLine(choice);
            //    if (choice == 0)
            //    {
            //        codeChar = random.Next(65, 90);
            //    }
            //    else
            //    {
            //        codeChar = random.Next(48, 57);
            //    }

            //    sb.Append((char)codeChar);
            //}

            //Console.WriteLine(sb.ToString());

            // Create a 1 min timer 
            var timer = new System.Timers.Timer(60000);

            // Hook up the Elapsed event for the timer.
            timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);

            timer.Enabled = true;

            Console.WriteLine("press any key to close.");
            Console.ReadKey();
        }

        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            Console.WriteLine("wow");
            // Your code
        }

        public class GetDaysToWait
        {
            public int ExamineeId { get; set; }
            public string FullName { get; set; }
            public DateTime? WaitDays { get; set; }
            public DateTime? CurrentDateTime { get; set; }
            public string EmailX { get; set; }
        }

        public static class Conversions
        {

            public static string TimeMinuteToString(int totalMinutes)
            {
                int hour = totalMinutes / 60;
                int minute = totalMinutes % 60;
                string output;

                if (hour == 0)
                {
                    output = string.Format("{0} minutes", minute);
                    return output;
                }

                if (hour == 1)
                {
                    if (minute == 0)
                    {
                        output = string.Format("{0} hour", hour);
                    }
                    else if (minute == 1)
                    {
                        output = string.Format("{0} hour & {1} minute", hour, minute);
                    }
                    else
                    {
                        output = string.Format("{0} hour & {1} minutes", hour, minute);
                    }
                }
                else
                {
                    if (minute == 0)
                    {
                        output = string.Format("{0} hours", hour);
                    }
                    else if (minute == 1)
                    {
                        output = string.Format("{0} hours & {1} minute", hour, minute);
                    }
                    else
                    {
                        output = string.Format("{0} hours & {1} minutes", hour, minute);
                    }
                }

                return output;
            }
        }

        public class Person
        {
            public Person()
            {

            }

            public string FullName { get; set; }
        }
    }
}
