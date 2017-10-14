namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.disables")]
    public partial class disable
    {
        [Key]
        [Column(Order = 0, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long sourceType { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long entry { get; set; }

        public byte flags { get; set; }

        [Required]
        [StringLength(255)]
        public string params_0 { get; set; }

        [Required]
        [StringLength(255)]
        public string params_1 { get; set; }

        [Required]
        [StringLength(255)]
        public string comment { get; set; }
    }
}
