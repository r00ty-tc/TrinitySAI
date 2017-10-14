namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.creature_formations")]
    public partial class creature_formations
    {
        [Column(TypeName = "uint")]
        public long leaderGUID { get; set; }

        [Key]
        [Column(TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long memberGUID { get; set; }

        [Column(TypeName = "uint")]
        public long groupAI { get; set; }

        [Column(TypeName = "usmallint")]
        public int point_1 { get; set; }

        [Column(TypeName = "usmallint")]
        public int point_2 { get; set; }
    }
}
