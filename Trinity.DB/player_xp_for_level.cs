namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.player_xp_for_level")]
    public partial class player_xp_for_level
    {
        [Key]
        public byte Level { get; set; }

        [Column(TypeName = "uint")]
        public long Experience { get; set; }
    }
}
