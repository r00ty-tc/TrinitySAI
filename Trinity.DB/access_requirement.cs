namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.access_requirement")]
    public partial class access_requirement
    {
        [Key]
        [Column(Order = 0, TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int mapId { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte difficulty { get; set; }

        public byte level_min { get; set; }

        public byte level_max { get; set; }

        [Column(TypeName = "usmallint")]
        public int item_level { get; set; }

        [Column(TypeName = "umediumint")]
        public int item { get; set; }

        [Column(TypeName = "umediumint")]
        public int item2 { get; set; }

        [Column(TypeName = "umediumint")]
        public int quest_done_A { get; set; }

        [Column(TypeName = "umediumint")]
        public int quest_done_H { get; set; }

        [Column(TypeName = "umediumint")]
        public int completed_achievement { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string quest_failed_text { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string comment { get; set; }
    }
}
