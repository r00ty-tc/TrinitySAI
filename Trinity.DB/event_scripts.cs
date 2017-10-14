namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.event_scripts")]
    public partial class event_scripts
    {
        [Key]
        [Column(Order = 0, TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long delay { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int command { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int datalong { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long datalong2 { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int dataint { get; set; }

        [Key]
        [Column(Order = 6)]
        public float x { get; set; }

        [Key]
        [Column(Order = 7)]
        public float y { get; set; }

        [Key]
        [Column(Order = 8)]
        public float z { get; set; }

        [Key]
        [Column(Order = 9)]
        public float o { get; set; }
    }
}
