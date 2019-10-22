using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject.ViewModel
{
    public class ExamResultViewModel
    {
        //public ExamResultViewModel()
        //{
        //    ExamSubjectResult = new HashSet<ExamSubjectResult>();
        //}
        public int ExamineeTakeId { get; set; }
        public string ExamCode { get; set; }
        public string IssuedBy { get; set; }
        public DateTime? CodeDateTimeIssued { get; set; }
        public DateTime? ExamDateTimeTaken { get; set; }
        public int? PassingRate { get; set; }
        public string Result { get; set; }

        public IEnumerable<ExamSubjectResult> ExamSubjectResult { get; set; }

        //public virtual ICollection<ExamSubjectResult> ExamSubjectResult { get; set; }
    }

    public class ExamSubjectResult
    {
        public int ExamId { get; set; }
        public string SubjectName { get; set; }
        public int Items { get; set; }
        public int PassingScore { get; set; }
        public int Score { get; set; }
        public string Result { get; set; }
    }


    public class ExamResultDetailsViewModel
    {
        public int ExamId { get; set; }
        public string SubjectName { get; set; }
        public int ExaminationType { get; set; }
        public int Score { get; set; }
        public int ItemCount { get; set; }
        public IEnumerable<ExamDetails> ExamDetails { get; set; }
    }

    public class ExamDetails
    {
        public int ExamineeAnswerId { get; set; }
        public string Answer { get; set; }
        public bool IsCorrect { get; set; }
        public DateTime? DateTimeAnswered { get; set; }
        public int QuestionId { get; set; }
        public string Quest { get; set; }
    }
}