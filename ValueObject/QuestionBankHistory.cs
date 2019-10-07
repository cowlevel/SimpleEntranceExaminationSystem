namespace ValueObject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("QuestionBankHistory")]
    public partial class QuestionBankHistory
    {
        public int QuestionBankHistoryId { get; set; }

        public int QuestionId { get; set; }

        public int QuestionNumber { get; set; }

        [StringLength(350)]
        public string Question { get; set; }

        [StringLength(200)]
        public string CorrectAnswer { get; set; }

        [StringLength(200)]
        public string WrongAnswer1 { get; set; }

        [StringLength(200)]
        public string WrongAnswer2 { get; set; }

        [StringLength(200)]
        public string WrongAnswer3 { get; set; }

        public int? UserId { get; set; }

        public DateTime? DateTimeModified { get; set; }

        public virtual QuestionBank QuestionBank { get; set; }

        public virtual SystemUser SystemUser { get; set; }
    }
}