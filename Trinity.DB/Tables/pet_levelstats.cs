namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.pet_levelstats")]
    public partial class pet_levelstats
    {
        [Key]
        [Column(Order = 0, TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int creature_entry { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte level { get; set; }

        [Column(TypeName = "usmallint")]
        public int hp { get; set; }

        [Column(TypeName = "usmallint")]
        public int mana { get; set; }

        [Column(TypeName = "uint")]
        public long armor { get; set; }

        [Column(TypeName = "usmallint")]
        public int str { get; set; }

        [Column(TypeName = "usmallint")]
        public int agi { get; set; }

        [Column(TypeName = "usmallint")]
        public int sta { get; set; }

        [Column(TypeName = "usmallint")]
        public int inte { get; set; }

        [Column(TypeName = "usmallint")]
        public int spi { get; set; }
    }
}
