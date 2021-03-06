namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.quest_details")]
    public partial class quest_details
    {
        [Column(TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Column(TypeName = "usmallint")]
        public int Emote1 { get; set; }

        [Column(TypeName = "usmallint")]
        public int Emote2 { get; set; }

        [Column(TypeName = "usmallint")]
        public int Emote3 { get; set; }

        [Column(TypeName = "usmallint")]
        public int Emote4 { get; set; }

        [Column(TypeName = "uint")]
        public long EmoteDelay1 { get; set; }

        [Column(TypeName = "uint")]
        public long EmoteDelay2 { get; set; }

        [Column(TypeName = "uint")]
        public long EmoteDelay3 { get; set; }

        [Column(TypeName = "uint")]
        public long EmoteDelay4 { get; set; }

        public short VerifiedBuild { get; set; }
    }
}
