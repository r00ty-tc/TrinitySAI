namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.achievement_reward_locale")]
    public partial class achievement_reward_locale
    {
        [Key]
        [Column(Order = 0, TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string Locale { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string Subject { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string Text { get; set; }
    }
}
