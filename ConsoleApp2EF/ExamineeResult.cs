namespace ConsoleApp2EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExamineeResult")]
    public partial class ExamineeResult
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ExamTakeId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int QuestionId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(150)]
        public string ExamineeAnswer { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool CorrectAnswer { get; set; }

        public virtual ExamTake ExamTake { get; set; }

        public virtual QuestionBank QuestionBank { get; set; }
    }
}
