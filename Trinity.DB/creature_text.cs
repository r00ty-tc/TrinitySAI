namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.creature_text")]
    public partial class creature_text
    {
        [Key]
        [Column(Order = 0, TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CreatureID { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte GroupID { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte ID { get; set; }

        [StringLength(1073741823)]
        public string Text { get; set; }

        public byte Type { get; set; }

        public sbyte Language { get; set; }

        [Column(TypeName = "umediumint")]
        public int Emote { get; set; }

        [Column(TypeName = "umediumint")]
        public int Duration { get; set; }

        [Column(TypeName = "umediumint")]
        public int Sound { get; set; }

        [Column(TypeName = "mediumint")]
        public int BroadcastTextId { get; set; }

        public byte TextRange { get; set; }

        [StringLength(255)]
        public string comment { get; set; }
    }
}
