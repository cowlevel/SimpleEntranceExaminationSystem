namespace ValueObject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("ExamineeFailure")]
    public partial class ExamineeFailure
    {
        public int ExamineeFailureId { get; set; }

        public int UserId { get; set; }

        public int WaitDays { get; set; }

        public DateTime? DateTimeModified { get; set; }

        public virtual SystemUser SystemUser { get; set; }
    }
}
