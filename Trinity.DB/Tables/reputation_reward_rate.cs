namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.reputation_reward_rate")]
    public partial class reputation_reward_rate
    {
        [Key]
        [Column(TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int faction { get; set; }

        public float quest_rate { get; set; }

        public float quest_daily_rate { get; set; }

        public float quest_weekly_rate { get; set; }

        public float quest_monthly_rate { get; set; }

        public float quest_repeatable_rate { get; set; }

        public float creature_rate { get; set; }

        public float spell_rate { get; set; }
    }
}
