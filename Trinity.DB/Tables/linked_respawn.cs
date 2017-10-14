namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.linked_respawn")]
    public partial class linked_respawn
    {
        [Key]
        [Column(Order = 0, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long guid { get; set; }

        [Column(TypeName = "uint")]
        public long linkedGuid { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte linkType { get; set; }
    }
}
