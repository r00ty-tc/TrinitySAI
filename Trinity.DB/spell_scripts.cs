namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.spell_scripts")]
    public partial class spell_scripts
    {
        [Key]
        [Column(Order = 0, TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte effIndex { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long delay { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int command { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int datalong { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long datalong2 { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int dataint { get; set; }

        [Key]
        [Column(Order = 7)]
        public float x { get; set; }

        [Key]
        [Column(Order = 8)]
        public float y { get; set; }

        [Key]
        [Column(Order = 9)]
        public float z { get; set; }

        [Key]
        [Column(Order = 10)]
        public float o { get; set; }
    }
}
