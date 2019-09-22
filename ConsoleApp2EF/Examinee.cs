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
            ExamineeTake = new HashSet<ExamineeTake>();
        }

        public int ExamineeId { get; set; }

        [Required]
        [StringLength(60)]
        public string LastName { get; set; }

        [Required]
        [StringLength(60)]
        public string FirstName { get; set; }

        [StringLength(60)]
        public string MiddleName { get; set; }

        [Required]
        [StringLength(150)]
        public string Address { get; set; }

        [Required]
        [StringLength(60)]
        public string City { get; set; }

        [Required]
        [StringLength(15)]
        public string ContactNo { get; set; }

        [Required]
        [StringLength(60)]
        public string Email { get; set; }

        [Required]
        [StringLength(150)]
        public string LastSchoolAttended { get; set; }

        public int YearGraduated { get; set; }

        public int ExamTakes { get; set; }

        public DateTime? DateTimeAdded { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExamineeTake> ExamineeTake { get; set; }
    }
}
