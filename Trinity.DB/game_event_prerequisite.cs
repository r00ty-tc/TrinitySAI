namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.game_event_prerequisite")]
    public partial class game_event_prerequisite
    {
        [Key]
        [Column(Order = 0)]
        public byte eventEntry { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int prerequisite_event { get; set; }
    }
}
