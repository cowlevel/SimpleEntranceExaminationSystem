using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject.Report
{
    public class ExamineeCodeReport
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string ExamCode { get; set; }
        public DateTime? CodeDateTimeIssued { get; set; }
        public string IssuedBy { get; set; }
    }
}