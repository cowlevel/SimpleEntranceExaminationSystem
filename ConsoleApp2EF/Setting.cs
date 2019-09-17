namespace ConsoleApp2EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Setting
    {
        [Key]
        public int SettingsId { get; set; }

        public int PassingRate { get; set; }

        public int TimeLimit { get; set; }
    }
}
