namespace ConsoleApp2EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PassingRate")]
    public partial class PassingRate
    {
        [Key]
        [Column(Order = 0)]
        public int PassingRateId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [Key]
        [Column("PassingRate", Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PassingRate1 { get; set; }

        public DateTime? DateTimeModified { get; set; }

        public virtual SystemUser SystemUser { get; set; }
    }
}
