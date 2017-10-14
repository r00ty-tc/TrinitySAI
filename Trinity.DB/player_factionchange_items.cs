namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.player_factionchange_items")]
    public partial class player_factionchange_items
    {
        [Column(TypeName = "uint")]
        public long race_A { get; set; }

        [Key]
        [Column(Order = 0, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long alliance_id { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string commentA { get; set; }

        [Column(TypeName = "uint")]
        public long race_H { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long horde_id { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string commentH { get; set; }
    }
}
