namespace ValueObject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("ExamineeAnswer")]
    public partial class ExamineeAnswer
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ExamineeAnswerId { get; set; }

        public int ExamineeExamId { get; set; }

        public int QuestionId { get; set; }

        [StringLength(150)]
        public string Answer { get; set; }

        public bool IsCorrect { get; set; }

        public DateTime? DateTimeAnswered { get; set; }

        public virtual ExamineeExam ExamineeExam { get; set; }

        public virtual QuestionBank QuestionBank { get; set; }
    }
}
