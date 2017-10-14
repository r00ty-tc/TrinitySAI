namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.gameobject_loot_template")]
    public partial class gameobject_loot_template
    {
        [Key]
        [Column(Order = 0, TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Entry { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Item { get; set; }

        [Column(TypeName = "umediumint")]
        public int Reference { get; set; }

        public float Chance { get; set; }

        public bool QuestRequired { get; set; }

        [Column(TypeName = "usmallint")]
        public int LootMode { get; set; }

        public byte GroupId { get; set; }

        public byte MinCount { get; set; }

        public byte MaxCount { get; set; }

        [StringLength(255)]
        public string Comment { get; set; }
    }
}
