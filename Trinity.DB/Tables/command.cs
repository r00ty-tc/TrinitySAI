namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.command")]
    public partial class command
    {
        [Key]
        [StringLength(50)]
        public string name { get; set; }

        [Column(TypeName = "usmallint")]
        public int permission { get; set; }

        [StringLength(1073741823)]
        public string help { get; set; }
    }
}
