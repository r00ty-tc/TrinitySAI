namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.spell_proc")]
    public partial class spell_proc
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SpellId { get; set; }

        public byte SchoolMask { get; set; }

        [Column(TypeName = "usmallint")]
        public int SpellFamilyName { get; set; }

        [Column(TypeName = "uint")]
        public long SpellFamilyMask0 { get; set; }

        [Column(TypeName = "uint")]
        public long SpellFamilyMask1 { get; set; }

        [Column(TypeName = "uint")]
        public long SpellFamilyMask2 { get; set; }

        [Column(TypeName = "uint")]
        public long ProcFlags { get; set; }

        [Column(TypeName = "uint")]
        public long SpellTypeMask { get; set; }

        [Column(TypeName = "uint")]
        public long SpellPhaseMask { get; set; }

        [Column(TypeName = "uint")]
        public long HitMask { get; set; }

        [Column(TypeName = "uint")]
        public long AttributesMask { get; set; }

        public float ProcsPerMinute { get; set; }

        public float Chance { get; set; }

        [Column(TypeName = "uint")]
        public long Cooldown { get; set; }

        public byte Charges { get; set; }
    }
}
