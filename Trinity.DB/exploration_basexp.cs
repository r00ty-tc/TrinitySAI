namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.exploration_basexp")]
    public partial class exploration_basexp
    {
        [Key]
        public byte level { get; set; }

        [Column(TypeName = "mediumint")]
        public int basexp { get; set; }
    }
}
