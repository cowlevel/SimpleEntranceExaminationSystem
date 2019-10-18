using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject.ViewModel
{
    public class ExamineeTakeStatusViewModel
    {
        public int ExamineeId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime CurrentDateTime { get; set; }
        public DateTime? CodeIssuedDateTime { get; set; }
        public DateTime? AllowExamAfterDateTime { get; set; }

        public bool IsAllowedToGetExam
        {
            get
            {
                if (AllowExamAfterDateTime == null)
                {
                    return true;
                }

                return CurrentDateTime.Date >= AllowExamAfterDateTime.Value.Date ? true : false;
            }

            private set { }
        }
    }
}