namespace ConsoleApp2EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExamineeTake")]
    public partial class ExamineeTake
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ExamineeTake()
        {
            ExamineeExam = new HashSet<ExamineeExam>();
        }

        public int ExamineeTakeId { get; set; }

        public int ExamineeId { get; set; }

        [Required]
        [StringLength(8)]
        public string ExamCode { get; set; }

        public DateTime? DateTimeTaken { get; set; }

        public int? PassingRate { get; set; }

        public virtual Examinee Examinee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExamineeExam> ExamineeExam { get; set; }
    }
}
