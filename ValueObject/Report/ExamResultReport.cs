using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject.Report
{
    public class ExamResultReport
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public DateTime? ExamDateTimeTaken { get; set; }
        public string Result { get; set; }
    }
}
