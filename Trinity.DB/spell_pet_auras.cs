namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.spell_pet_auras")]
    public partial class spell_pet_auras
    {
        [Key]
        [Column(Order = 0, TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int spell { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte effectId { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int pet { get; set; }

        [Column(TypeName = "umediumint")]
        public int aura { get; set; }
    }
}
