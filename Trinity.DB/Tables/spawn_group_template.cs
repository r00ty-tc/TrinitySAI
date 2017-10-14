namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.spawn_group_template")]
    public partial class spawn_group_template
    {
        [Key]
        [Column(TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long groupId { get; set; }

        [Required]
        [StringLength(100)]
        public string groupName { get; set; }

        [Column(TypeName = "uint")]
        public long groupFlags { get; set; }
    }
}
