namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.game_event_npc_vendor")]
    public partial class game_event_npc_vendor
    {
        public sbyte eventEntry { get; set; }

        [Key]
        [Column(Order = 0, TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int guid { get; set; }

        public short slot { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int item { get; set; }

        [Column(TypeName = "umediumint")]
        public int maxcount { get; set; }

        [Column(TypeName = "umediumint")]
        public int incrtime { get; set; }

        [Column(TypeName = "umediumint")]
        public int ExtendedCost { get; set; }
    }
}
