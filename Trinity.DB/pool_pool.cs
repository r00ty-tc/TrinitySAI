namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.pool_pool")]
    public partial class pool_pool
    {
        [Key]
        [Column(TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int pool_id { get; set; }

        [Column(TypeName = "umediumint")]
        public int mother_pool { get; set; }

        public float chance { get; set; }

        [StringLength(255)]
        public string description { get; set; }
    }
}
