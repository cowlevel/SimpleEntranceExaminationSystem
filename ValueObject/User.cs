namespace ValueObject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Exam = new HashSet<Exam>();
        }

        public int UserId { get; set; }

        [Required]
        [StringLength(60)]
        public string LastName { get; set; }

        [Required]
        [StringLength(60)]
        public string FirstName { get; set; }

        [StringLength(60)]
        public string MiddleName { get; set; }

        [Required]
        [StringLength(64)]
        public string Username { get; set; }

        //[Required]
        [StringLength(250)]
        public string Pword { get; set; }

        [Required]
        [StringLength(20)]
        public string UserLevel { get; set; }

        public bool AccountStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Exam> Exam { get; set; }
    }
}
