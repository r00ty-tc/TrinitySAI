namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.quest_template")]
    public partial class quest_template
    {
        [Column(TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public byte QuestType { get; set; }

        public short QuestLevel { get; set; }

        public byte MinLevel { get; set; }

        public short QuestSortID { get; set; }

        [Column(TypeName = "usmallint")]
        public int QuestInfoID { get; set; }

        public byte SuggestedGroupNum { get; set; }

        [Column(TypeName = "usmallint")]
        public int RequiredFactionId1 { get; set; }

        [Column(TypeName = "usmallint")]
        public int RequiredFactionId2 { get; set; }

        [Column(TypeName = "mediumint")]
        public int RequiredFactionValue1 { get; set; }

        [Column(TypeName = "mediumint")]
        public int RequiredFactionValue2 { get; set; }

        [Column(TypeName = "umediumint")]
        public int RewardNextQuest { get; set; }

        public byte RewardXPDifficulty { get; set; }

        public int RewardMoney { get; set; }

        [Column(TypeName = "uint")]
        public long RewardBonusMoney { get; set; }

        [Column(TypeName = "umediumint")]
        public int RewardDisplaySpell { get; set; }

        public int RewardSpell { get; set; }

        public int RewardHonor { get; set; }

        public float RewardKillHonor { get; set; }

        [Column(TypeName = "umediumint")]
        public int StartItem { get; set; }

        [Column(TypeName = "uint")]
        public long Flags { get; set; }

        public byte RequiredPlayerKills { get; set; }

        [Column(TypeName = "umediumint")]
        public int RewardItem1 { get; set; }

        [Column(TypeName = "usmallint")]
        public int RewardAmount1 { get; set; }

        [Column(TypeName = "umediumint")]
        public int RewardItem2 { get; set; }

        [Column(TypeName = "usmallint")]
        public int RewardAmount2 { get; set; }

        [Column(TypeName = "umediumint")]
        public int RewardItem3 { get; set; }

        [Column(TypeName = "usmallint")]
        public int RewardAmount3 { get; set; }

        [Column(TypeName = "umediumint")]
        public int RewardItem4 { get; set; }

        [Column(TypeName = "usmallint")]
        public int RewardAmount4 { get; set; }

        [Column(TypeName = "umediumint")]
        public int ItemDrop1 { get; set; }

        [Column(TypeName = "usmallint")]
        public int ItemDropQuantity1 { get; set; }

        [Column(TypeName = "umediumint")]
        public int ItemDrop2 { get; set; }

        [Column(TypeName = "usmallint")]
        public int ItemDropQuantity2 { get; set; }

        [Column(TypeName = "umediumint")]
        public int ItemDrop3 { get; set; }

        [Column(TypeName = "usmallint")]
        public int ItemDropQuantity3 { get; set; }

        [Column(TypeName = "umediumint")]
        public int ItemDrop4 { get; set; }

        [Column(TypeName = "usmallint")]
        public int ItemDropQuantity4 { get; set; }

        [Column(TypeName = "umediumint")]
        public int RewardChoiceItemID1 { get; set; }

        [Column(TypeName = "usmallint")]
        public int RewardChoiceItemQuantity1 { get; set; }

        [Column(TypeName = "umediumint")]
        public int RewardChoiceItemID2 { get; set; }

        [Column(TypeName = "usmallint")]
        public int RewardChoiceItemQuantity2 { get; set; }

        [Column(TypeName = "umediumint")]
        public int RewardChoiceItemID3 { get; set; }

        [Column(TypeName = "usmallint")]
        public int RewardChoiceItemQuantity3 { get; set; }

        [Column(TypeName = "umediumint")]
        public int RewardChoiceItemID4 { get; set; }

        [Column(TypeName = "usmallint")]
        public int RewardChoiceItemQuantity4 { get; set; }

        [Column(TypeName = "umediumint")]
        public int RewardChoiceItemID5 { get; set; }

        [Column(TypeName = "usmallint")]
        public int RewardChoiceItemQuantity5 { get; set; }

        [Column(TypeName = "umediumint")]
        public int RewardChoiceItemID6 { get; set; }

        [Column(TypeName = "usmallint")]
        public int RewardChoiceItemQuantity6 { get; set; }

        [Column(TypeName = "usmallint")]
        public int POIContinent { get; set; }

        public float POIx { get; set; }

        public float POIy { get; set; }

        [Column(TypeName = "umediumint")]
        public int POIPriority { get; set; }

        public byte RewardTitle { get; set; }

        public byte RewardTalents { get; set; }

        [Column(TypeName = "usmallint")]
        public int RewardArenaPoints { get; set; }

        [Column(TypeName = "usmallint")]
        public int RewardFactionID1 { get; set; }

        [Column(TypeName = "mediumint")]
        public int RewardFactionValue1 { get; set; }

        [Column(TypeName = "mediumint")]
        public int RewardFactionOverride1 { get; set; }

        [Column(TypeName = "usmallint")]
        public int RewardFactionID2 { get; set; }

        [Column(TypeName = "mediumint")]
        public int RewardFactionValue2 { get; set; }

        [Column(TypeName = "mediumint")]
        public int RewardFactionOverride2 { get; set; }

        [Column(TypeName = "usmallint")]
        public int RewardFactionID3 { get; set; }

        [Column(TypeName = "mediumint")]
        public int RewardFactionValue3 { get; set; }

        [Column(TypeName = "mediumint")]
        public int RewardFactionOverride3 { get; set; }

        [Column(TypeName = "usmallint")]
        public int RewardFactionID4 { get; set; }

        [Column(TypeName = "mediumint")]
        public int RewardFactionValue4 { get; set; }

        [Column(TypeName = "mediumint")]
        public int RewardFactionOverride4 { get; set; }

        [Column(TypeName = "usmallint")]
        public int RewardFactionID5 { get; set; }

        [Column(TypeName = "mediumint")]
        public int RewardFactionValue5 { get; set; }

        [Column(TypeName = "mediumint")]
        public int RewardFactionOverride5 { get; set; }

        [Column(TypeName = "uint")]
        public long TimeAllowed { get; set; }

        [Column(TypeName = "usmallint")]
        public int AllowableRaces { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string LogTitle { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string LogDescription { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string QuestDescription { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string AreaDescription { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string QuestCompletionLog { get; set; }

        [Column(TypeName = "mediumint")]
        public int RequiredNpcOrGo1 { get; set; }

        [Column(TypeName = "mediumint")]
        public int RequiredNpcOrGo2 { get; set; }

        [Column(TypeName = "mediumint")]
        public int RequiredNpcOrGo3 { get; set; }

        [Column(TypeName = "mediumint")]
        public int RequiredNpcOrGo4 { get; set; }

        [Column(TypeName = "usmallint")]
        public int RequiredNpcOrGoCount1 { get; set; }

        [Column(TypeName = "usmallint")]
        public int RequiredNpcOrGoCount2 { get; set; }

        [Column(TypeName = "usmallint")]
        public int RequiredNpcOrGoCount3 { get; set; }

        [Column(TypeName = "usmallint")]
        public int RequiredNpcOrGoCount4 { get; set; }

        [Column(TypeName = "umediumint")]
        public int RequiredItemId1 { get; set; }

        [Column(TypeName = "umediumint")]
        public int RequiredItemId2 { get; set; }

        [Column(TypeName = "umediumint")]
        public int RequiredItemId3 { get; set; }

        [Column(TypeName = "umediumint")]
        public int RequiredItemId4 { get; set; }

        [Column(TypeName = "umediumint")]
        public int RequiredItemId5 { get; set; }

        [Column(TypeName = "umediumint")]
        public int RequiredItemId6 { get; set; }

        [Column(TypeName = "usmallint")]
        public int RequiredItemCount1 { get; set; }

        [Column(TypeName = "usmallint")]
        public int RequiredItemCount2 { get; set; }

        [Column(TypeName = "usmallint")]
        public int RequiredItemCount3 { get; set; }

        [Column(TypeName = "usmallint")]
        public int RequiredItemCount4 { get; set; }

        [Column(TypeName = "usmallint")]
        public int RequiredItemCount5 { get; set; }

        [Column(TypeName = "usmallint")]
        public int RequiredItemCount6 { get; set; }

        public byte Unknown0 { get; set; }

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
