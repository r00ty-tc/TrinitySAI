namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.npc_vendor")]
    public partial class npc_vendor
    {
        [Key]
        [Column(Order = 0, TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int entry { get; set; }

        public short slot { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "mediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int item { get; set; }

        public byte maxcount { get; set; }

        [Column(TypeName = "uint")]
        public long incrtime { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ExtendedCost { get; set; }

        public short? VerifiedBuild { get; set; }
    }
}
