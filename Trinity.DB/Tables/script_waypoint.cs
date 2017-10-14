namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.script_waypoint")]
    public partial class script_waypoint
    {
        [Key]
        [Column(Order = 0, TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int entry { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int pointid { get; set; }

        public float location_x { get; set; }

        public float location_y { get; set; }

        public float location_z { get; set; }

        [Column(TypeName = "uint")]
        public long waittime { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string point_comment { get; set; }
    }
}
