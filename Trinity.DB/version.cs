namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.version")]
    public partial class version
    {
        [Key]
        [StringLength(120)]
        public string core_version { get; set; }

        [StringLength(120)]
        public string core_revision { get; set; }

        [StringLength(120)]
        public string db_version { get; set; }

        public int? cache_id { get; set; }
    }
}
