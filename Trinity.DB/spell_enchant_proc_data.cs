namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.spell_enchant_proc_data")]
    public partial class spell_enchant_proc_data
    {
        [Key]
        [Column(TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long EnchantID { get; set; }

        public float Chance { get; set; }

        public float ProcsPerMinute { get; set; }

        [Column(TypeName = "uint")]
        public long HitMask { get; set; }

        [Column(TypeName = "uint")]
        public long AttributesMask { get; set; }
    }
}
