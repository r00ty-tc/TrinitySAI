namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.spell_ranks")]
    public partial class spell_ranks
    {
        [Key]
        [Column(Order = 0, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long first_spell_id { get; set; }

        [Column(TypeName = "uint")]
        public long spell_id { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte rank { get; set; }
    }
}
