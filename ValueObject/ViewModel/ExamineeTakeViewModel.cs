using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject.ViewModel
{
    public class ExamineeTakeViewModel
    {
        public int ExamineeTakeId { get; set; }

        public int ExamineeId { get; set; }

        public string ExamCode { get; set; }

        public int UserId { get; set; }

        public DateTime? CodeDateTimeIssued { get; set; }

        public DateTime? ExamDateTimeTaken { get; set; }

        public int? PassingRate { get; set; }

        public bool? Result { get; set; }
    }
}