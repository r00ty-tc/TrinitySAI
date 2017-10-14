namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.gameobject_addon")]
    public partial class gameobject_addon
    {
        [Key]
        [Column(TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long guid { get; set; }

        public float parent_rotation0 { get; set; }

        public float parent_rotation1 { get; set; }

        public float parent_rotation2 { get; set; }

        public float parent_rotation3 { get; set; }

        public byte invisibilityType { get; set; }

        [Column(TypeName = "uint")]
        public long invisibilityValue { get; set; }
    }
}
