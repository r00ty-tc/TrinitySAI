namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.quest_template_addon")]
    public partial class quest_template_addon
    {
        [Column(TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public byte MaxLevel { get; set; }

        [Column(TypeName = "uint")]
        public long AllowableClasses { get; set; }

        [Column(TypeName = "umediumint")]
        public int SourceSpellID { get; set; }

        [Column(TypeName = "mediumint")]
        public int PrevQuestID { get; set; }

        [Column(TypeName = "umediumint")]
        public int NextQuestID { get; set; }

        [Column(TypeName = "mediumint")]
        public int ExclusiveGroup { get; set; }

        [Column(TypeName = "umediumint")]
        public int RewardMailTemplateID { get; set; }

        [Column(TypeName = "uint")]
        public long RewardMailDelay { get; set; }

        [Column(TypeName = "usmallint")]
        public int RequiredSkillID { get; set; }

        [Column(TypeName = "usmallint")]
        public int RequiredSkillPoints { get; set; }

        [Column(TypeName = "usmallint")]
        public int RequiredMinRepFaction { get; set; }

        [Column(TypeName = "usmallint")]
        public int RequiredMaxRepFaction { get; set; }

        [Column(TypeName = "mediumint")]
        public int RequiredMinRepValue { get; set; }

        [Column(TypeName = "mediumint")]
        public int RequiredMaxRepValue { get; set; }

        public byte ProvidedItemCount { get; set; }

        public byte SpecialFlags { get; set; }
    }
}
