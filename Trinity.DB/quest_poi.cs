namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.quest_poi")]
    public partial class quest_poi
    {
        [Key]
        [Column(Order = 0, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long QuestID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }

        public int ObjectiveIndex { get; set; }

        [Column(TypeName = "uint")]
        public long MapID { get; set; }

        [Column(TypeName = "uint")]
        public long WorldMapAreaId { get; set; }

        [Column(TypeName = "uint")]
        public long Floor { get; set; }

        [Column(TypeName = "uint")]
        public long Priority { get; set; }

        [Column(TypeName = "uint")]
        public long Flags { get; set; }

        public short? VerifiedBuild { get; set; }
    }
}
