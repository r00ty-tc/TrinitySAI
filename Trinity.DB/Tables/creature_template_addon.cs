namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.creature_template_addon")]
    public partial class creature_template_addon
    {
        [Key]
        [Column(TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int entry { get; set; }

        [Column(TypeName = "uint")]
        public long path_id { get; set; }

        [Column(TypeName = "umediumint")]
        public int mount { get; set; }

        [Column(TypeName = "uint")]
        public long bytes1 { get; set; }

        [Column(TypeName = "uint")]
        public long bytes2 { get; set; }

        [Column(TypeName = "umediumint")]
        public int emote { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string auras { get; set; }
    }
}
