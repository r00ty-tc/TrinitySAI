namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.areatrigger_teleport")]
    public partial class areatrigger_teleport
    {
        [Column(TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string Name { get; set; }

        [Column(TypeName = "usmallint")]
        public int target_map { get; set; }

        public float target_position_x { get; set; }

        public float target_position_y { get; set; }

        public float target_position_z { get; set; }

        public float target_orientation { get; set; }

        public short? VerifiedBuild { get; set; }
    }
}
