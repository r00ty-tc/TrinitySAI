namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.outdoorpvp_template")]
    public partial class outdoorpvp_template
    {
        [Key]
        public byte TypeId { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(64)]
        public string ScriptName { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string comment { get; set; }
    }
}
