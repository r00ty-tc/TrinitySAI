namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.game_event_quest_condition")]
    public partial class game_event_quest_condition
    {
        public byte eventEntry { get; set; }

        [Key]
        [Column(TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int quest { get; set; }

        [Column(TypeName = "umediumint")]
        public int condition_id { get; set; }

        public float? num { get; set; }
    }
}
