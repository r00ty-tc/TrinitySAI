namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.npc_text_locale")]
    public partial class npc_text_locale
    {
        [Key]
        [Column(Order = 0, TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string Locale { get; set; }

        [StringLength(1073741823)]
        public string Text0_0 { get; set; }

        [StringLength(1073741823)]
        public string Text0_1 { get; set; }

        [StringLength(1073741823)]
        public string Text1_0 { get; set; }

        [StringLength(1073741823)]
        public string Text1_1 { get; set; }

        [StringLength(1073741823)]
        public string Text2_0 { get; set; }

        [StringLength(1073741823)]
        public string Text2_1 { get; set; }

        [StringLength(1073741823)]
        public string Text3_0 { get; set; }

        [StringLength(1073741823)]
        public string Text3_1 { get; set; }

        [StringLength(1073741823)]
        public string Text4_0 { get; set; }

        [StringLength(1073741823)]
        public string Text4_1 { get; set; }

        [StringLength(1073741823)]
        public string Text5_0 { get; set; }

        [StringLength(1073741823)]
        public string Text5_1 { get; set; }

        [StringLength(1073741823)]
        public string Text6_0 { get; set; }

        [StringLength(1073741823)]
        public string Text6_1 { get; set; }

        [StringLength(1073741823)]
        public string Text7_0 { get; set; }

        [StringLength(1073741823)]
        public string Text7_1 { get; set; }
    }
}
