namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.player_classlevelstats")]
    public partial class player_classlevelstats
    {
        [Key]
        [Column("class", Order = 0)]
        public byte _class { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte level { get; set; }

        [Column(TypeName = "usmallint")]
        public int basehp { get; set; }

        [Column(TypeName = "usmallint")]
        public int basemana { get; set; }
    }
}
