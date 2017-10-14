namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.reputation_spillover_template")]
    public partial class reputation_spillover_template
    {
        [Key]
        [Column(TypeName = "usmallint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int faction { get; set; }

        [Column(TypeName = "usmallint")]
        public int faction1 { get; set; }

        public float rate_1 { get; set; }

        public byte rank_1 { get; set; }

        [Column(TypeName = "usmallint")]
        public int faction2 { get; set; }

        public float rate_2 { get; set; }

        public byte rank_2 { get; set; }

        [Column(TypeName = "usmallint")]
        public int faction3 { get; set; }

        public float rate_3 { get; set; }

        public byte rank_3 { get; set; }

        [Column(TypeName = "usmallint")]
        public int faction4 { get; set; }

        public float rate_4 { get; set; }

        public byte rank_4 { get; set; }
    }
}
