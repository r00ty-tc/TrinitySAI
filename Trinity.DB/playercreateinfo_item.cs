namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.playercreateinfo_item")]
    public partial class playercreateinfo_item
    {
        [Key]
        [Column(Order = 0)]
        public byte race { get; set; }

        [Key]
        [Column("class", Order = 1)]
        public byte _class { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int itemid { get; set; }

        public sbyte amount { get; set; }
    }
}
