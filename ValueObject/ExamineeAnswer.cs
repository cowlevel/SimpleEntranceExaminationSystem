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
        public int ExamineeAnswerId { get; set; }

        public int ExamineeExamId { get; set; }

        public int QuestionId { get; set; }

        [Column("ExamineeAnswer")]
        [Required]
        [StringLength(150)]
        public string ExamineeAnswer1 { get; set; }

        public bool CorrectAnswer { get; set; }

        public virtual ExamineeExam ExamineeExam { get; set; }

        public virtual QuestionBank QuestionBank { get; set; }
    }
}
