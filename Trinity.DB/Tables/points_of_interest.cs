namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.points_of_interest")]
    public partial class points_of_interest
    {
        [Column(TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public float PositionX { get; set; }

        public float PositionY { get; set; }

        [Column(TypeName = "umediumint")]
        public int Icon { get; set; }

        [Column(TypeName = "umediumint")]
        public int Flags { get; set; }

        [Column(TypeName = "umediumint")]
        public int Importance { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string Name { get; set; }

        public short? VerifiedBuild { get; set; }
    }
}
