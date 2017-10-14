namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.updates_include")]
    public partial class updates_include
    {
        [Key]
        [StringLength(200)]
        public string path { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string state { get; set; }
    }
}
