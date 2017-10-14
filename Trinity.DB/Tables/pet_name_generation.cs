namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.pet_name_generation")]
    public partial class pet_name_generation
    {
        [Column(TypeName = "umediumint")]
        public int id { get; set; }

        [Column(TypeName = "tinytext")]
        [Required]
        [StringLength(255)]
        public string word { get; set; }

        [Column(TypeName = "umediumint")]
        public int entry { get; set; }

        public byte half { get; set; }
    }
}
