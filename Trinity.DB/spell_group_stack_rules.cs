namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.spell_group_stack_rules")]
    public partial class spell_group_stack_rules
    {
        [Key]
        [Column(TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long group_id { get; set; }

        public sbyte stack_rule { get; set; }
    }
}
