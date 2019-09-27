namespace ConsoleApp2EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Exam")]
    public partial class Exam
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Exam()
        {
            ExamineeTake = new HashSet<ExamineeTake>();
            QuestionBank = new HashSet<QuestionBank>();
        }

        public int ExamId { get; set; }

        public int UserId { get; set; }

        public int SubjectId { get; set; }

        public int ItemCount { get; set; }

        public bool ExamStatus { get; set; }

        public DateTime? DateTimeAdded { get; set; }

        public virtual Subject Subject { get; set; }

        public virtual SystemUser SystemUser { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExamineeTake> ExamineeTake { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuestionBank> QuestionBank { get; set; }
    }
}
