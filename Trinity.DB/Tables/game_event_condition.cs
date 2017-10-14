namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.game_event_condition")]
    public partial class game_event_condition
    {
        [Key]
        [Column(Order = 0)]
        public byte eventEntry { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int condition_id { get; set; }

        public float? req_num { get; set; }

        [Column(TypeName = "usmallint")]
        public int max_world_state_field { get; set; }

        [Column(TypeName = "usmallint")]
        public int done_world_state_field { get; set; }

        [Required]
        [StringLength(25)]
        public string description { get; set; }
    }
}
