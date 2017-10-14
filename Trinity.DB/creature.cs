namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.creature")]
    public partial class creature
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

        [Column(TypeName = "umediumint")]
        public int modelid { get; set; }

        public sbyte equipment_id { get; set; }

        public float position_x { get; set; }

        public float position_y { get; set; }

        public float position_z { get; set; }

        public float orientation { get; set; }

        [Column(TypeName = "uint")]
        public long spawntimesecs { get; set; }

        public float spawndist { get; set; }

        [Column(TypeName = "umediumint")]
        public int currentwaypoint { get; set; }

        [Column(TypeName = "uint")]
        public long curhealth { get; set; }

        [Column(TypeName = "uint")]
        public long curmana { get; set; }

        public byte MovementType { get; set; }

        [Column(TypeName = "uint")]
        public long npcflag { get; set; }

        [Column(TypeName = "uint")]
        public long unit_flags { get; set; }

        [Column(TypeName = "uint")]
        public long dynamicflags { get; set; }

        [Column(TypeName = "char")]
        [StringLength(64)]
        public string ScriptName { get; set; }

        public short? VerifiedBuild { get; set; }
    }
}
