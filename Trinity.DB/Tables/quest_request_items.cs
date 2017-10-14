namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.quest_request_items")]
    public partial class quest_request_items
    {
        [Column(TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Column(TypeName = "usmallint")]
        public int EmoteOnComplete { get; set; }

        [Column(TypeName = "usmallint")]
        public int EmoteOnIncomplete { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string CompletionText { get; set; }

        public short VerifiedBuild { get; set; }
    }
}
