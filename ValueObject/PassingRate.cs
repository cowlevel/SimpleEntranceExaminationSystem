namespace ValueObject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("PassingRate")]
    public partial class PassingRate
    {
        public int PassingRateId { get; set; }

        public int UserId { get; set; }

        public int Rate { get; set; }

        public DateTime? DateTimeModified { get; set; }

        public virtual SystemUser SystemUser { get; set; }
    }
}
