namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.achievement_reward")]
    public partial class achievement_reward
    {
        [Column(TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Column(TypeName = "umediumint")]
        public int TitleA { get; set; }

        [Column(TypeName = "umediumint")]
        public int TitleH { get; set; }

        [Column(TypeName = "umediumint")]
        public int ItemID { get; set; }

        [Column(TypeName = "umediumint")]
        public int Sender { get; set; }

        [StringLength(255)]
        public string Subject { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string Text { get; set; }

        [Column(TypeName = "umediumint")]
        public int? MailTemplateID { get; set; }
    }
}
