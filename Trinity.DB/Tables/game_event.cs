namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.game_event")]
    public partial class game_event
    {
        [Key]
        public byte eventEntry { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime start_time { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime end_time { get; set; }

        [Column(TypeName = "ubigint")]
        public decimal occurence { get; set; }

        [Column(TypeName = "ubigint")]
        public decimal length { get; set; }

        [Column(TypeName = "umediumint")]
        public int holiday { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        public byte world_event { get; set; }

        public byte? announce { get; set; }
    }
}
