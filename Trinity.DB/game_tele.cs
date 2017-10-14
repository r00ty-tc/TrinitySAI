namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.game_tele")]
    public partial class game_tele
    {
        [Column(TypeName = "umediumint")]
        public int id { get; set; }

        public float position_x { get; set; }

        public float position_y { get; set; }

        public float position_z { get; set; }

        public float orientation { get; set; }

        [Column(TypeName = "usmallint")]
        public int map { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; }
    }
}
