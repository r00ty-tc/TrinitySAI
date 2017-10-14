namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.waypoint_data")]
    public partial class waypoint_data
    {
        [Key]
        [Column(Order = 0, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int point { get; set; }

        public float position_x { get; set; }

        public float position_y { get; set; }

        public float position_z { get; set; }

        public float orientation { get; set; }

        [Column(TypeName = "uint")]
        public long delay { get; set; }

        public int move_type { get; set; }

        public int action { get; set; }

        public short action_chance { get; set; }

        [Column(TypeName = "uint")]
        public long wpguid { get; set; }
    }
}
