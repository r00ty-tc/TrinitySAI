namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.pool_creature")]
    public partial class pool_creature
    {
        [Key]
        [Column(TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long guid { get; set; }

        [Column(TypeName = "umediumint")]
        public int pool_entry { get; set; }

        [StringLength(255)]
        public string description { get; set; }
    }
}
