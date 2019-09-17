using BusinessLogicLayer;
using DatabaseAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace ConsoleAppTester1
{
    class Program
    {
        static void Main(string[] args)
        {
            var examinee = GetExaminee();

            //ValidationContext context = new ValidationContext(examinee);
            //List<ValidationResult> results = new List<ValidationResult>();

            //bool valid = Validator.TryValidateObject(examinee, context, results, true);

            //foreach (var validation in results)
            //{
            //    Console.WriteLine(validation.ErrorMessage);
            //}



            //ValidationContext context = new ValidationContext(examinee);
            //List<ValidationResult> results = new List<ValidationResult>();
            //var isValid = TryValidate(examinee, out results);

            //Console.WriteLine(isValid);

            //foreach (var validation in results)
            //{
            //    Console.WriteLine(validation.ErrorMessage);

            //}

            Console.WriteLine(SetHashText("Administrator"));

            Console.WriteLine("\nPress any key to close.");
            Console.ReadKey();
        }

        private static string SetHashText(string text)
        {
            StringBuilder sb;
            byte[] result;

            using (SHA256 sha256 = SHA256.Create())
            {
                sb = new StringBuilder();
                result = sha256.ComputeHash(Encoding.UTF8.GetBytes(text));

                for (int i = 0; i < result.Length; i++)
                {
                    sb.Append(result[i].ToString("x2"));
                }
            }

            return sb.ToString();
        }

        public static Examinee GetExaminee()
        {
            Examinee _examinee = new Examinee();
            _examinee.ExamineeId = 1;
            _examinee.LastName = "Canon";
            //_examinee.FirstName = "Zergjill";
            //_examinee.Birthdate = new DateTime(1989, 9, 1);
            _examinee.LastSchoolAttended = "STI";

            return _examinee;
        }

        //public static void DoTryValidate(Examinee examinee, out List<ValidationResult> results)
        //{
        //    ValidationContext validationContext = new ValidationContext(examinee);
        //    List<ValidationResult> results = new List<ValidationResult>();
        //    bool isValid = Validator.TryValidateObject(examinee, validationContext, results, validateAllProperties: true);


        //}

        public static bool TryValidate(object @object, out List<ValidationResult> results)
        {
            var context = new ValidationContext(@object, serviceProvider: null, items: null);
            results = new List<ValidationResult>();
            return Validator.TryValidateObject(
                @object, context, results,
                validateAllProperties: true
            );
        }
    }
}
