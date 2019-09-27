using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject.ViewModel
{
    public class ExamViewModel
    {
        public ExamViewModel()
        {

        }

        public int UserId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Username { get; set; }

        public int ExamId { get; set; }
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public int ItemCount { get; set; }
        public int ExamType { get; set; }
        public DateTime? DateTimeAdded { get; set; }

        

        public string FullName
        {
            get
            {
                if (MiddleName == string.Empty)
                {
                    return string.Format("{0}, {1}", LastName, FirstName);
                }

                return string.Format("{0}, {1} {2}", LastName, FirstName, MiddleName);
            }

            //private set { }
        }

        public string CreatedBy
        {
            get
            {
                if (MiddleName == string.Empty)
                {
                    return string.Format("[{0}] - {1}, {2}", Username, LastName, FirstName);
                }

                return string.Format("[{0}] - {1}, {2} {3}", Username, LastName, FirstName, MiddleName);
            }
            //set;
        }

        public string ExamTypeDescription
        {
            get
            {
                if (ExamType == 0)
                {
                    return "Multiple Choice";
                }
                else if (ExamType == 1)
                {
                    return "True or False";
                }

                return "Fill in the Blank";
            }
        }
    }
}