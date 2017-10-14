namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.item_template")]
    public partial class item_template
    {
        [Key]
        [Column(TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int entry { get; set; }

        [Column("class")]
        public byte _class { get; set; }

        public byte subclass { get; set; }

        public sbyte SoundOverrideSubclass { get; set; }

        [Required]
        [StringLength(255)]
        public string name { get; set; }

        [Column(TypeName = "umediumint")]
        public int displayid { get; set; }

        public byte Quality { get; set; }

        [Column(TypeName = "uint")]
        public long Flags { get; set; }

        [Column(TypeName = "uint")]
        public long FlagsExtra { get; set; }

        public byte BuyCount { get; set; }

        public long BuyPrice { get; set; }

        [Column(TypeName = "uint")]
        public long SellPrice { get; set; }

        public byte InventoryType { get; set; }

        public int AllowableClass { get; set; }

        public int AllowableRace { get; set; }

        [Column(TypeName = "usmallint")]
        public int ItemLevel { get; set; }

        public byte RequiredLevel { get; set; }

        [Column(TypeName = "usmallint")]
        public int RequiredSkill { get; set; }

        [Column(TypeName = "usmallint")]
        public int RequiredSkillRank { get; set; }

        [Column(TypeName = "umediumint")]
        public int requiredspell { get; set; }

        [Column(TypeName = "umediumint")]
        public int requiredhonorrank { get; set; }

        [Column(TypeName = "umediumint")]
        public int RequiredCityRank { get; set; }

        [Column(TypeName = "usmallint")]
        public int RequiredReputationFaction { get; set; }

        [Column(TypeName = "usmallint")]
        public int RequiredReputationRank { get; set; }

        public int maxcount { get; set; }

        public int? stackable { get; set; }

        public byte ContainerSlots { get; set; }

        public byte StatsCount { get; set; }

        public byte stat_type1 { get; set; }

        public short stat_value1 { get; set; }

        public byte stat_type2 { get; set; }

        public short stat_value2 { get; set; }

        public byte stat_type3 { get; set; }

        public short stat_value3 { get; set; }

        public byte stat_type4 { get; set; }

        public short stat_value4 { get; set; }

        public byte stat_type5 { get; set; }

        public short stat_value5 { get; set; }

        public byte stat_type6 { get; set; }

        public short stat_value6 { get; set; }

        public byte stat_type7 { get; set; }

        public short stat_value7 { get; set; }

        public byte stat_type8 { get; set; }

        public short stat_value8 { get; set; }

        public byte stat_type9 { get; set; }

        public short stat_value9 { get; set; }

        public byte stat_type10 { get; set; }

        public short stat_value10 { get; set; }

        public short ScalingStatDistribution { get; set; }

        [Column(TypeName = "uint")]
        public long ScalingStatValue { get; set; }

        public float dmg_min1 { get; set; }

        public float dmg_max1 { get; set; }

        public byte dmg_type1 { get; set; }

        public float dmg_min2 { get; set; }

        public float dmg_max2 { get; set; }

        public byte dmg_type2 { get; set; }

        [Column(TypeName = "usmallint")]
        public int armor { get; set; }

        public byte holy_res { get; set; }

        public byte fire_res { get; set; }

        public byte nature_res { get; set; }

        public byte frost_res { get; set; }

        public byte shadow_res { get; set; }

        public byte arcane_res { get; set; }

        [Column(TypeName = "usmallint")]
        public int delay { get; set; }

        public byte ammo_type { get; set; }

        public float RangedModRange { get; set; }

        [Column(TypeName = "mediumint")]
        public int spellid_1 { get; set; }

        public byte spelltrigger_1 { get; set; }

        public short spellcharges_1 { get; set; }

        public float spellppmRate_1 { get; set; }

        public int spellcooldown_1 { get; set; }

        [Column(TypeName = "usmallint")]
        public int spellcategory_1 { get; set; }

        public int spellcategorycooldown_1 { get; set; }

        [Column(TypeName = "mediumint")]
        public int spellid_2 { get; set; }

        public byte spelltrigger_2 { get; set; }

        public short spellcharges_2 { get; set; }

        public float spellppmRate_2 { get; set; }

        public int spellcooldown_2 { get; set; }

        [Column(TypeName = "usmallint")]
        public int spellcategory_2 { get; set; }

        public int spellcategorycooldown_2 { get; set; }

        [Column(TypeName = "mediumint")]
        public int spellid_3 { get; set; }

        public byte spelltrigger_3 { get; set; }

        public short spellcharges_3 { get; set; }

        public float spellppmRate_3 { get; set; }

        public int spellcooldown_3 { get; set; }

        [Column(TypeName = "usmallint")]
        public int spellcategory_3 { get; set; }

        public int spellcategorycooldown_3 { get; set; }

        [Column(TypeName = "mediumint")]
        public int spellid_4 { get; set; }

        public byte spelltrigger_4 { get; set; }

        public short spellcharges_4 { get; set; }

        public float spellppmRate_4 { get; set; }

        public int spellcooldown_4 { get; set; }

        [Column(TypeName = "usmallint")]
        public int spellcategory_4 { get; set; }

        public int spellcategorycooldown_4 { get; set; }

        [Column(TypeName = "mediumint")]
        public int spellid_5 { get; set; }

        public byte spelltrigger_5 { get; set; }

        public short spellcharges_5 { get; set; }

        public float spellppmRate_5 { get; set; }

        public int spellcooldown_5 { get; set; }

        [Column(TypeName = "usmallint")]
        public int spellcategory_5 { get; set; }

        public int spellcategorycooldown_5 { get; set; }

        public byte bonding { get; set; }

        [Required]
        [StringLength(255)]
        public string description { get; set; }

        [Column(TypeName = "umediumint")]
        public int PageText { get; set; }

        public byte LanguageID { get; set; }

        public byte PageMaterial { get; set; }

        [Column(TypeName = "umediumint")]
        public int startquest { get; set; }

        [Column(TypeName = "umediumint")]
        public int lockid { get; set; }

        public sbyte Material { get; set; }

        public byte sheath { get; set; }

        [Column(TypeName = "mediumint")]
        public int RandomProperty { get; set; }

        [Column(TypeName = "umediumint")]
        public int RandomSuffix { get; set; }

        [Column(TypeName = "umediumint")]
        public int block { get; set; }

        [Column(TypeName = "umediumint")]
        public int itemset { get; set; }

        [Column(TypeName = "usmallint")]
        public int MaxDurability { get; set; }

        [Column(TypeName = "umediumint")]
        public int area { get; set; }

        public short Map { get; set; }

        [Column(TypeName = "mediumint")]
        public int BagFamily { get; set; }

        [Column(TypeName = "mediumint")]
        public int TotemCategory { get; set; }

        public sbyte socketColor_1 { get; set; }

        [Column(TypeName = "mediumint")]
        public int socketContent_1 { get; set; }

        public sbyte socketColor_2 { get; set; }

        [Column(TypeName = "mediumint")]
        public int socketContent_2 { get; set; }

        public sbyte socketColor_3 { get; set; }

        [Column(TypeName = "mediumint")]
        public int socketContent_3 { get; set; }

        [Column(TypeName = "mediumint")]
        public int socketBonus { get; set; }

        [Column(TypeName = "mediumint")]
        public int GemProperties { get; set; }

        public short RequiredDisenchantSkill { get; set; }

        public float ArmorDamageModifier { get; set; }

        [Column(TypeName = "uint")]
        public long duration { get; set; }

        public short ItemLimitCategory { get; set; }

        [Column(TypeName = "uint")]
        public long HolidayId { get; set; }

        [Required]
        [StringLength(64)]
        public string ScriptName { get; set; }

        [Column(TypeName = "umediumint")]
        public int DisenchantID { get; set; }

        public byte FoodType { get; set; }

        [Column(TypeName = "uint")]
        public long minMoneyLoot { get; set; }

        [Column(TypeName = "uint")]
        public long maxMoneyLoot { get; set; }

        [Column(TypeName = "uint")]
        public long flagsCustom { get; set; }

        public short? VerifiedBuild { get; set; }
    }
}
