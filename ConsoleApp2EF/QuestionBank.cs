namespace ConsoleApp2EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QuestionBank")]
    public partial class QuestionBank
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QuestionBank()
        {
            ExamineeResult = new HashSet<ExamineeResult>();
        }

        public int ExamId { get; set; }

        [Key]
        public int QuestionId { get; set; }

        public int QuestionNumber { get; set; }

        [Required]
        [StringLength(350)]
        public string Question { get; set; }

        [Required]
        [StringLength(150)]
        public string CorrectAnswer { get; set; }

        [Required]
        [StringLength(150)]
        public string WrongAnswer1 { get; set; }

        [Required]
        [StringLength(150)]
        public string WrongAnswer2 { get; set; }

        [Required]
        [StringLength(150)]
        public string WrongAnswer3 { get; set; }

        public virtual Exam Exam { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExamineeResult> ExamineeResult { get; set; }
    }
}