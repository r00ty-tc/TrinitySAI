namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.quest_mail_sender")]
    public partial class quest_mail_sender
    {
        [Key]
        [Column(TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long QuestId { get; set; }

        [Column(TypeName = "uint")]
        public long RewardMailSenderEntry { get; set; }
    }
}
