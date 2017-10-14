namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.item_set_names")]
    public partial class item_set_names
    {
        [Key]
        [Column(TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int entry { get; set; }

        [Required]
        [StringLength(255)]
        public string name { get; set; }

        public byte InventoryType { get; set; }

        public short? VerifiedBuild { get; set; }
    }
}
