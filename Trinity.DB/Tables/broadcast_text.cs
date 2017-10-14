namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.broadcast_text")]
    public partial class broadcast_text
    {
        [Column(TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Column(TypeName = "umediumint")]
        public int Language { get; set; }

        [StringLength(1073741823)]
        public string MaleText { get; set; }

        [StringLength(1073741823)]
        public string FemaleText { get; set; }

        [Column(TypeName = "umediumint")]
        public int EmoteID0 { get; set; }

        [Column(TypeName = "umediumint")]
        public int EmoteID1 { get; set; }

        [Column(TypeName = "umediumint")]
        public int EmoteID2 { get; set; }

        [Column(TypeName = "umediumint")]
        public int EmoteDelay0 { get; set; }

        [Column(TypeName = "umediumint")]
        public int EmoteDelay1 { get; set; }

        [Column(TypeName = "umediumint")]
        public int EmoteDelay2 { get; set; }

        [Column(TypeName = "umediumint")]
        public int SoundId { get; set; }

        [Column(TypeName = "umediumint")]
        public int Unk1 { get; set; }

        [Column(TypeName = "umediumint")]
        public int Unk2 { get; set; }

        public short? VerifiedBuild { get; set; }
    }
}
