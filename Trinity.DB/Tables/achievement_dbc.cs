namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.achievement_dbc")]
    public partial class achievement_dbc
    {
        [Column(TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        public int requiredFaction { get; set; }

        public int mapID { get; set; }

        [Column(TypeName = "uint")]
        public long points { get; set; }

        [Column(TypeName = "uint")]
        public long flags { get; set; }

        [Column(TypeName = "uint")]
        public long count { get; set; }

        [Column(TypeName = "uint")]
        public long refAchievement { get; set; }
    }
}
