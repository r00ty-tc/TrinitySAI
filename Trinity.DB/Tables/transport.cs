namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.transports")]
    public partial class transport
    {
        [Key]
        [Column(TypeName = "uint")]
        public long guid { get; set; }

        [Column(TypeName = "umediumint")]
        public int entry { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string name { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(64)]
        public string ScriptName { get; set; }
    }
}
