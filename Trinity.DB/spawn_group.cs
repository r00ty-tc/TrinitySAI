namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.spawn_group")]
    public partial class spawn_group
    {
        [Key]
        [Column(Order = 0, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long groupId { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte spawnType { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long spawnId { get; set; }
    }
}
