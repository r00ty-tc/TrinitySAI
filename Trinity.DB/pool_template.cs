namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.pool_template")]
    public partial class pool_template
    {
        [Key]
        [Column(TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int entry { get; set; }

        [Column(TypeName = "uint")]
        public long max_limit { get; set; }

        [StringLength(255)]
        public string description { get; set; }
    }
}
