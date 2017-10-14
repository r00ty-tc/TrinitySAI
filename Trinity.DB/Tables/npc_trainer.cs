namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.npc_trainer")]
    public partial class npc_trainer
    {
        [Key]
        [Column(Order = 0, TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "mediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SpellID { get; set; }

        [Column(TypeName = "uint")]
        public long MoneyCost { get; set; }

        [Column(TypeName = "usmallint")]
        public int ReqSkillLine { get; set; }

        [Column(TypeName = "usmallint")]
        public int ReqSkillRank { get; set; }

        public byte ReqLevel { get; set; }
    }
}
