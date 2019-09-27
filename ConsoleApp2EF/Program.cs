using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ConsoleApp2EF
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Model1())
            {
                var ctx = context.Exam.Include(u => u.SystemUser)
                                      .Include(u => u.QuestionBank)
                                      .Where(u => u.UserId == 1)
                                      .ToList();

                foreach (var item in ctx)
                {
                    Console.WriteLine("Exam Id: " + item.ExamId);
                    Console.WriteLine("Created by: " + item.SystemUser.LastName);
                }
            }

            Console.WriteLine("press any key to close.");
            Console.ReadKey();
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
