using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

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
        public int ExaminationType { get; set; }
        public int ItemCount { get; set; }
        public int TimeLimit { get; set; }
        public DateTime? DateTimeAdded { get; set; }

        public int IncompleteQuestionCount { get; set; }

        public string FullQuestionCount
        {
            get
            {
                return string.Format("{0}/{1}", IncompleteQuestionCount, ItemCount);
            }
        }

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

        public string TimeLimitString
        {
            get
            {
                return Conversions.TimeMinuteToString(this.TimeLimit);
            }
        }

        public string ExaminationTypeString
        {
            get
            {
                string output = null;

                if (ExaminationType == (int)ExamType.MultipleChoice)
                {
                    output = "Multiple Choice";
                }
                else if (ExaminationType == (int)ExamType.TrueOrFalse)
                {
                    output = "True or False";
                }
                else if (ExaminationType == (int)ExamType.TypeTheAnswer)
                {
                    output = "Write the Answer";
                }

                return output;
            }
        }
    }
}