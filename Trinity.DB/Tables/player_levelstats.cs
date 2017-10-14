namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.player_levelstats")]
    public partial class player_levelstats
    {
        [Key]
        [Column(Order = 0)]
        public byte race { get; set; }

        [Key]
        [Column("class", Order = 1)]
        public byte _class { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte level { get; set; }

        public byte str { get; set; }

        public byte agi { get; set; }

        public byte sta { get; set; }

        public byte inte { get; set; }

        public byte spi { get; set; }
    }
}
