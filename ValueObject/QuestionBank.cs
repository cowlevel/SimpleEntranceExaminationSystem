namespace ValueObject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("QuestionBank")]
    public partial class QuestionBank
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QuestionBank()
        {
            ExamineeAnswer = new HashSet<ExamineeAnswer>();
            QuestionBankHistory = new HashSet<QuestionBankHistory>();
        }

        public int ExamId { get; set; }

        [Key]
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

        public virtual Exam Exam { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExamineeAnswer> ExamineeAnswer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuestionBankHistory> QuestionBankHistory { get; set; }
    }
}
