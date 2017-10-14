namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.warden_checks")]
    public partial class warden_checks
    {
        [Column(TypeName = "usmallint")]
        public int id { get; set; }

        public byte? type { get; set; }

        [StringLength(48)]
        public string data { get; set; }

        [StringLength(20)]
        public string str { get; set; }

        [Column(TypeName = "uint")]
        public long? address { get; set; }

        public byte? length { get; set; }

        [StringLength(24)]
        public string result { get; set; }

        [StringLength(50)]
        public string comment { get; set; }
    }
}
