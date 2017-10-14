namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.game_event_npcflag")]
    public partial class game_event_npcflag
    {
        [Key]
        [Column(Order = 0)]
        public byte eventEntry { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int guid { get; set; }

        [Column(TypeName = "uint")]
        public long npcflag { get; set; }
    }
}
