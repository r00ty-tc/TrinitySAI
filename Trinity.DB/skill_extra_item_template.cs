namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.skill_extra_item_template")]
    public partial class skill_extra_item_template
    {
        [Key]
        [Column(TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int spellId { get; set; }

        [Column(TypeName = "umediumint")]
        public int requiredSpecialization { get; set; }

        public float additionalCreateChance { get; set; }

        public byte additionalMaxNum { get; set; }
    }
}
