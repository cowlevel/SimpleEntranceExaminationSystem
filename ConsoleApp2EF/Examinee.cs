namespace ConsoleApp2EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Examinee")]
    public partial class Examinee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Examinee()
        {
            ExamTakes = new HashSet<ExamTake>();
        }

        public int ExamineeId { get; set; }

        [Required]
        [StringLength(40)]
        public string LastName { get; set; }

        [Required]
        [StringLength(40)]
        public string FirstName { get; set; }

        [StringLength(40)]
        public string MiddleName { get; set; }

        [Column(TypeName = "date")]
        public DateTime Birthdate { get; set; }

        [Required]
        [StringLength(150)]
        public string LastSchoolAttended { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExamTake> ExamTakes { get; set; }
    }
}
