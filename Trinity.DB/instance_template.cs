namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.instance_template")]
    public partial class instance_template
    {
        [Key]
        [Column(TypeName = "usmallint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int map { get; set; }

        [Column(TypeName = "usmallint")]
        public int parent { get; set; }

        [Required]
        [StringLength(128)]
        public string script { get; set; }

        public byte allowMount { get; set; }
    }
}
