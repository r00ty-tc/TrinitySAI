namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.spell_learn_spell")]
    public partial class spell_learn_spell
    {
        [Key]
        [Column(Order = 0, TypeName = "usmallint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int entry { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "usmallint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SpellID { get; set; }

        public byte Active { get; set; }
    }
}
