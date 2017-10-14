namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.playercreateinfo_action")]
    public partial class playercreateinfo_action
    {
        [Key]
        [Column(Order = 0)]
        public byte race { get; set; }

        [Key]
        [Column("class", Order = 1)]
        public byte _class { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "usmallint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int button { get; set; }

        [Column(TypeName = "uint")]
        public long action { get; set; }

        [Column(TypeName = "usmallint")]
        public int type { get; set; }
    }
}
