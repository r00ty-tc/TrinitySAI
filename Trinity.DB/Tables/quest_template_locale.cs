namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.quest_template_locale")]
    public partial class quest_template_locale
    {
        [Key]
        [Column(Order = 0, TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string locale { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string Title { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string Details { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string Objectives { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string OfferRewardText { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string RequestItemsText { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string EndText { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string CompletedText { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string ObjectiveText1 { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string ObjectiveText2 { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string ObjectiveText3 { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string ObjectiveText4 { get; set; }

        public short? VerifiedBuild { get; set; }
    }
}
