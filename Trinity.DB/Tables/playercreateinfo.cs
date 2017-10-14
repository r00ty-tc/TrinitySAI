namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.playercreateinfo")]
    public partial class playercreateinfo
    {
        [Key]
        [Column(Order = 0)]
        public byte race { get; set; }

        [Key]
        [Column("class", Order = 1)]
        public byte _class { get; set; }

        [Column(TypeName = "usmallint")]
        public int map { get; set; }

        [Column(TypeName = "umediumint")]
        public int zone { get; set; }

        public float position_x { get; set; }

        public float position_y { get; set; }

        public float position_z { get; set; }

        public float orientation { get; set; }
    }
}
