namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.instance_encounters")]
    public partial class instance_encounters
    {
        [Key]
        [Column(TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long entry { get; set; }

        public byte creditType { get; set; }

        [Column(TypeName = "uint")]
        public long creditEntry { get; set; }

        [Column(TypeName = "usmallint")]
        public int lastEncounterDungeon { get; set; }

        [Required]
        [StringLength(255)]
        public string comment { get; set; }
    }
}
