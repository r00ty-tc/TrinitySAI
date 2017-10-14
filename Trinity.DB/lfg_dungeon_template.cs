namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.lfg_dungeon_template")]
    public partial class lfg_dungeon_template
    {
        [Key]
        [Column(TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long dungeonId { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        public float position_x { get; set; }

        public float position_y { get; set; }

        public float position_z { get; set; }

        public float orientation { get; set; }

        public short? VerifiedBuild { get; set; }
    }
}
