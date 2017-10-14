namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.creature_classlevelstats")]
    public partial class creature_classlevelstats
    {
        [Key]
        [Column(Order = 0)]
        public byte level { get; set; }

        [Key]
        [Column("class", Order = 1)]
        public byte _class { get; set; }

        [Column(TypeName = "usmallint")]
        public int basehp0 { get; set; }

        [Column(TypeName = "usmallint")]
        public int basehp1 { get; set; }

        [Column(TypeName = "usmallint")]
        public int basehp2 { get; set; }

        [Column(TypeName = "usmallint")]
        public int basemana { get; set; }

        [Column(TypeName = "usmallint")]
        public int basearmor { get; set; }

        [Column(TypeName = "usmallint")]
        public int attackpower { get; set; }

        [Column(TypeName = "usmallint")]
        public int rangedattackpower { get; set; }

        public float damage_base { get; set; }

        public float damage_exp1 { get; set; }

        public float damage_exp2 { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string comment { get; set; }
    }
}
