namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.gameobject_template")]
    public partial class gameobject_template
    {
        [Key]
        [Column(TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int entry { get; set; }

        public byte type { get; set; }

        [Column(TypeName = "umediumint")]
        public int displayId { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; }

        [Required]
        [StringLength(100)]
        public string IconName { get; set; }

        [Required]
        [StringLength(100)]
        public string castBarCaption { get; set; }

        [Required]
        [StringLength(100)]
        public string unk1 { get; set; }

        public float size { get; set; }

        [Column(TypeName = "uint")]
        public long Data0 { get; set; }

        public int Data1 { get; set; }

        [Column(TypeName = "uint")]
        public long Data2 { get; set; }

        [Column(TypeName = "uint")]
        public long Data3 { get; set; }

        [Column(TypeName = "uint")]
        public long Data4 { get; set; }

        [Column(TypeName = "uint")]
        public long Data5 { get; set; }

        public int Data6 { get; set; }

        [Column(TypeName = "uint")]
        public long Data7 { get; set; }

        [Column(TypeName = "uint")]
        public long Data8 { get; set; }

        [Column(TypeName = "uint")]
        public long Data9 { get; set; }

        [Column(TypeName = "uint")]
        public long Data10 { get; set; }

        [Column(TypeName = "uint")]
        public long Data11 { get; set; }

        [Column(TypeName = "uint")]
        public long Data12 { get; set; }

        [Column(TypeName = "uint")]
        public long Data13 { get; set; }

        [Column(TypeName = "uint")]
        public long Data14 { get; set; }

        [Column(TypeName = "uint")]
        public long Data15 { get; set; }

        [Column(TypeName = "uint")]
        public long Data16 { get; set; }

        [Column(TypeName = "uint")]
        public long Data17 { get; set; }

        [Column(TypeName = "uint")]
        public long Data18 { get; set; }

        [Column(TypeName = "uint")]
        public long Data19 { get; set; }

        [Column(TypeName = "uint")]
        public long Data20 { get; set; }

        [Column(TypeName = "uint")]
        public long Data21 { get; set; }

        [Column(TypeName = "uint")]
        public long Data22 { get; set; }

        [Column(TypeName = "uint")]
        public long Data23 { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(64)]
        public string AIName { get; set; }

        [Required]
        [StringLength(64)]
        public string ScriptName { get; set; }

        public short? VerifiedBuild { get; set; }
    }
}
