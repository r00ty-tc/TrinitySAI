namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.playercreateinfo_skills")]
    public partial class playercreateinfo_skills
    {
        [Key]
        [Column(Order = 0, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long raceMask { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long classMask { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "usmallint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int skill { get; set; }

        [Column(TypeName = "usmallint")]
        public int rank { get; set; }

        [StringLength(255)]
        public string comment { get; set; }
    }
}
