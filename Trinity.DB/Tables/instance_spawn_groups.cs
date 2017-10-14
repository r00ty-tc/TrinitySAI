namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.instance_spawn_groups")]
    public partial class instance_spawn_groups
    {
        [Key]
        [Column(Order = 0, TypeName = "usmallint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int instanceMapId { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte bossStateId { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte bossStates { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long spawnGroupId { get; set; }

        public byte flags { get; set; }
    }
}
