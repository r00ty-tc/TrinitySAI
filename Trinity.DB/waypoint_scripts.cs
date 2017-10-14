namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.waypoint_scripts")]
    public partial class waypoint_scripts
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        [Column(TypeName = "uint")]
        public long delay { get; set; }

        [Column(TypeName = "uint")]
        public long command { get; set; }

        [Column(TypeName = "uint")]
        public long datalong { get; set; }

        [Column(TypeName = "uint")]
        public long datalong2 { get; set; }

        [Column(TypeName = "uint")]
        public long dataint { get; set; }

        public float x { get; set; }

        public float y { get; set; }

        public float z { get; set; }

        public float o { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int guid { get; set; }
    }
}
