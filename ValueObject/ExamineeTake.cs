namespace ValueObject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("ExamineeTake")]
    public partial class ExamineeTake
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ExamineeTake()
        {
            ExamineeResult = new HashSet<ExamineeResult>();
        }

        [Key]
        public int ExamineeTakeId { get; set; }

        public int ExamId { get; set; }

        public int ExamineeId { get; set; }

        [StringLength(10)]
        public string ExamCode { get; set; }

        public int? TimeLimit { get; set; }

        public DateTime? DateTimeTaken { get; set; }

        public DateTime? DateTimeEnded { get; set; }

        public int? Score { get; set; }

        public int? PassingRate { get; set; }

        public bool? ExamPasser { get; set; }

        public virtual Exam Exam { get; set; }

        public virtual Examinee Examinee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExamineeResult> ExamineeResult { get; set; }
    }
}
