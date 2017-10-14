namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.creature_model_info")]
    public partial class creature_model_info
    {
        [Key]
        [Column(TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DisplayID { get; set; }

        public float BoundingRadius { get; set; }

        public float CombatReach { get; set; }

        public byte Gender { get; set; }

        [Column(TypeName = "umediumint")]
        public int DisplayID_Other_Gender { get; set; }
    }
}
