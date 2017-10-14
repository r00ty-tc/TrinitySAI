namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.skill_perfect_item_template")]
    public partial class skill_perfect_item_template
    {
        [Key]
        [Column(TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int spellId { get; set; }

        [Column(TypeName = "umediumint")]
        public int requiredSpecialization { get; set; }

        public float perfectCreateChance { get; set; }

        [Column(TypeName = "umediumint")]
        public int perfectItemType { get; set; }
    }
}
