namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.game_event_arena_seasons")]
    public partial class game_event_arena_seasons
    {
        [Key]
        [Column(Order = 0)]
        public byte eventEntry { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte season { get; set; }
    }
}
