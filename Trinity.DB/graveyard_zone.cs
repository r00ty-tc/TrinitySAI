namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.graveyard_zone")]
    public partial class graveyard_zone
    {
        [Key]
        [Column(Order = 0, TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GhostZone { get; set; }

        [Column(TypeName = "usmallint")]
        public int Faction { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string Comment { get; set; }
    }
}
