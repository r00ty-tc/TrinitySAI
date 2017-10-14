namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.spell_required")]
    public partial class spell_required
    {
        [Key]
        [Column(Order = 0, TypeName = "mediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int spell_id { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "mediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int req_spell { get; set; }
    }
}
