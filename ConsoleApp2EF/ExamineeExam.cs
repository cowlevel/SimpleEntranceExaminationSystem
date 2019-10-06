namespace ConsoleApp2EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExamineeExam")]
    public partial class ExamineeExam
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ExamineeExam()
        {
            ExamineeAnswer = new HashSet<ExamineeAnswer>();
        }

        public int ExamineeExamId { get; set; }

        public int ExamineeTakeId { get; set; }

        public int ExamId { get; set; }

        public int Score { get; set; }

        public virtual Exam Exam { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExamineeAnswer> ExamineeAnswer { get; set; }

        public virtual ExamineeTake ExamineeTake { get; set; }
    }
}
