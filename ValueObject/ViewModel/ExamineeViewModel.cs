using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject.ViewModel
{
    public class ExamineeViewModel
    {
        public ExamineeViewModel()
        {

        }

        public int ExamineeId { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }
                
        public string Address { get; set; }

        public string City { get; set; }

        public string ContactNo { get; set; }

        public string Email { get; set; }

        public string LastSchoolAttended { get; set; }

        public int YearGraduated { get; set; }

        public int ExamTakes { get; set; }

        public DateTime? DateTimeAdded { get; set; }

        public string FullName
        {
            get
            {
                return string.Format("{0}, {1} {2}", LastName, FirstName, MiddleName);
            }
        }
    }
}
