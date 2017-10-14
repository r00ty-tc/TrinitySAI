namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.battleground_template")]
    public partial class battleground_template
    {
        [Column(TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Column(TypeName = "usmallint")]
        public int MinPlayersPerTeam { get; set; }

        [Column(TypeName = "usmallint")]
        public int MaxPlayersPerTeam { get; set; }

        public byte MinLvl { get; set; }

        public byte MaxLvl { get; set; }

        [Column(TypeName = "umediumint")]
        public int AllianceStartLoc { get; set; }

        public float AllianceStartO { get; set; }

        [Column(TypeName = "umediumint")]
        public int HordeStartLoc { get; set; }

        public float HordeStartO { get; set; }

        public float StartMaxDist { get; set; }

        public byte Weight { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(64)]
        public string ScriptName { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(32)]
        public string Comment { get; set; }
    }
}
