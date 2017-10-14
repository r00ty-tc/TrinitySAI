namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.creature_equip_template")]
    public partial class creature_equip_template
    {
        [Key]
        [Column(Order = 0, TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CreatureID { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte ID { get; set; }

        [Column(TypeName = "umediumint")]
        public int ItemID1 { get; set; }

        [Column(TypeName = "umediumint")]
        public int ItemID2 { get; set; }

        [Column(TypeName = "umediumint")]
        public int ItemID3 { get; set; }

        public short? VerifiedBuild { get; set; }
    }
}
