namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.spell_script_names")]
    public partial class spell_script_names
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int spell_id { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "char")]
        [StringLength(64)]
        public string ScriptName { get; set; }
    }
}
