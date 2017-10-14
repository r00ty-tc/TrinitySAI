namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.game_event_battleground_holiday")]
    public partial class game_event_battleground_holiday
    {
        [Key]
        public byte eventEntry { get; set; }

        [Column(TypeName = "uint")]
        public long bgflag { get; set; }
    }
}
