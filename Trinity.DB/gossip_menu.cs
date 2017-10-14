namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.gossip_menu")]
    public partial class gossip_menu
    {
        [Key]
        [Column(Order = 0, TypeName = "usmallint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MenuID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TextID { get; set; }

        public short VerifiedBuild { get; set; }
    }
}
