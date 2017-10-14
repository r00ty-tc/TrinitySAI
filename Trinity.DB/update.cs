namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.updates")]
    public partial class update
    {
        [Key]
        [StringLength(200)]
        public string name { get; set; }

        [Column(TypeName = "char")]
        [StringLength(40)]
        public string hash { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string state { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime timestamp { get; set; }

        [Column(TypeName = "uint")]
        public long speed { get; set; }
    }
}
