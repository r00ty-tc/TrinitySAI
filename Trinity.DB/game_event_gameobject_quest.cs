namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.game_event_gameobject_quest")]
    public partial class game_event_gameobject_quest
    {
        [Key]
        [Column(Order = 0)]
        public byte eventEntry { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int quest { get; set; }
    }
}
