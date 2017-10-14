namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.creature_onkill_reputation")]
    public partial class creature_onkill_reputation
    {
        [Key]
        [Column(TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int creature_id { get; set; }

        public short RewOnKillRepFaction1 { get; set; }

        public short RewOnKillRepFaction2 { get; set; }

        public sbyte MaxStanding1 { get; set; }

        public sbyte IsTeamAward1 { get; set; }

        [Column(TypeName = "mediumint")]
        public int RewOnKillRepValue1 { get; set; }

        public sbyte MaxStanding2 { get; set; }

        public sbyte IsTeamAward2 { get; set; }

        [Column(TypeName = "mediumint")]
        public int RewOnKillRepValue2 { get; set; }

        public byte TeamDependent { get; set; }
    }
}
