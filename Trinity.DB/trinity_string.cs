namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.trinity_string")]
    public partial class trinity_string
    {
        [Key]
        [Column(TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int entry { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string content_default { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string content_loc1 { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string content_loc2 { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string content_loc3 { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string content_loc4 { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string content_loc5 { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string content_loc6 { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string content_loc7 { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string content_loc8 { get; set; }
    }
}
