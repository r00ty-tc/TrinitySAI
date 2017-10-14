namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.gameobject")]
    public partial class gameobject
    {
        [Key]
        [Column(TypeName = "uint")]
        public long guid { get; set; }

        [Column(TypeName = "umediumint")]
        public int id { get; set; }

        [Column(TypeName = "usmallint")]
        public int map { get; set; }

        [Column(TypeName = "usmallint")]
        public int zoneId { get; set; }

        [Column(TypeName = "usmallint")]
        public int areaId { get; set; }

        public byte spawnMask { get; set; }

        [Column(TypeName = "uint")]
        public long phaseMask { get; set; }

        public float position_x { get; set; }

        public float position_y { get; set; }

        public float position_z { get; set; }

        public float orientation { get; set; }

        public float rotation0 { get; set; }

        public float rotation1 { get; set; }

        public float rotation2 { get; set; }

        public float rotation3 { get; set; }

        public int spawntimesecs { get; set; }

        public byte animprogress { get; set; }

        public byte state { get; set; }

        [Column(TypeName = "char")]
        [StringLength(64)]
        public string ScriptName { get; set; }

        public short? VerifiedBuild { get; set; }
    }
}
