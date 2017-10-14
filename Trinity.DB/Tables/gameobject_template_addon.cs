namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.gameobject_template_addon")]
    public partial class gameobject_template_addon
    {
        [Key]
        [Column(TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int entry { get; set; }

        [Column(TypeName = "usmallint")]
        public int faction { get; set; }

        [Column(TypeName = "uint")]
        public long flags { get; set; }

        [Column(TypeName = "umediumint")]
        public int mingold { get; set; }

        [Column(TypeName = "umediumint")]
        public int maxgold { get; set; }
    }
}
