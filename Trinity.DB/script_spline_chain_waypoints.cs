namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.script_spline_chain_waypoints")]
    public partial class script_spline_chain_waypoints
    {
        [Key]
        [Column(Order = 0, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long entry { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "usmallint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int chainId { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte splineId { get; set; }

        [Key]
        [Column(Order = 3)]
        public byte wpId { get; set; }

        public float x { get; set; }

        public float y { get; set; }

        public float z { get; set; }
    }
}
