namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.lfg_dungeon_rewards")]
    public partial class lfg_dungeon_rewards
    {
        [Key]
        [Column(Order = 0, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long dungeonId { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte maxLevel { get; set; }

        [Column(TypeName = "uint")]
        public long firstQuestId { get; set; }

        [Column(TypeName = "uint")]
        public long otherQuestId { get; set; }
    }
}
