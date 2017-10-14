namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.spell_linked_spell")]
    public partial class spell_linked_spell
    {
        [Key]
        [Column(Order = 0, TypeName = "mediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int spell_trigger { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "mediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int spell_effect { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte type { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "text")]
        [StringLength(65535)]
        public string comment { get; set; }
    }
}
