namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.creature_summon_groups")]
    public partial class creature_summon_groups
    {
        [Key]
        [Column(Order = 0, TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int summonerId { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte summonerType { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte groupId { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int entry { get; set; }

        [Key]
        [Column(Order = 4)]
        public float position_x { get; set; }

        [Key]
        [Column(Order = 5)]
        public float position_y { get; set; }

        [Key]
        [Column(Order = 6)]
        public float position_z { get; set; }

        [Key]
        [Column(Order = 7)]
        public float orientation { get; set; }

        [Key]
        [Column(Order = 8)]
        public byte summonType { get; set; }

        [Key]
        [Column(Order = 9, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long summonTime { get; set; }
    }
}
