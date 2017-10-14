namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.waypoints")]
    public partial class waypoint
    {
        [Key]
        [Column(Order = 0, TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int entry { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int pointid { get; set; }

        public float position_x { get; set; }

        public float position_y { get; set; }

        public float position_z { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string point_comment { get; set; }
    }
}
