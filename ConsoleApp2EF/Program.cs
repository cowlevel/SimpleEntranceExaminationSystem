using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2EF
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (var model = new Model1())
            //{
            //    var users = model.User.Select(s => s.UserId).Count();

            //    Console.WriteLine(users.ToString());
            //}
            List<Person> names = new List<Person>
            {
                new Person { FullName="Canon1"},
                new Person { FullName="Canon2"},
                new Person { FullName="Canon3"},
                new Person { FullName="Canon4"},
                new Person { FullName="Canon5"},
                new Person { FullName="Canon6"},
                new Person { FullName="Canon7"},
                new Person { FullName="Canon8"},
                new Person { FullName="Canon9"},
                new Person { FullName="Canon10"},
                new Person { FullName="Canon11"},
            };

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write("Enter page: ");
            //    int num = Convert.ToInt32(Console.ReadLine());

            //    var result = names.ToPagedQuery(3, num);

            //    foreach (var n in result)
            //    {
            //        Console.WriteLine(n.FullName);
            //    }
            //}

            using (var model = new Model1())
            {
                
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
