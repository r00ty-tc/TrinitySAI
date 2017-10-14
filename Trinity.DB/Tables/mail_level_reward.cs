namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.mail_level_reward")]
    public partial class mail_level_reward
    {
        [Key]
        [Column(Order = 0)]
        public byte level { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int raceMask { get; set; }

        [Column(TypeName = "umediumint")]
        public int mailTemplateId { get; set; }

        [Column(TypeName = "umediumint")]
        public int senderEntry { get; set; }
    }
}
