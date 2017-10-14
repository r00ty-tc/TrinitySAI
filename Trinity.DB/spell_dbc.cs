namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.spell_dbc")]
    public partial class spell_dbc
    {
        [Column(TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [Column(TypeName = "uint")]
        public long Dispel { get; set; }

        [Column(TypeName = "uint")]
        public long Mechanic { get; set; }

        [Column(TypeName = "uint")]
        public long Attributes { get; set; }

        [Column(TypeName = "uint")]
        public long AttributesEx { get; set; }

        [Column(TypeName = "uint")]
        public long AttributesEx2 { get; set; }

        [Column(TypeName = "uint")]
        public long AttributesEx3 { get; set; }

        [Column(TypeName = "uint")]
        public long AttributesEx4 { get; set; }

        [Column(TypeName = "uint")]
        public long AttributesEx5 { get; set; }

        [Column(TypeName = "uint")]
        public long AttributesEx6 { get; set; }

        [Column(TypeName = "uint")]
        public long AttributesEx7 { get; set; }

        [Column(TypeName = "uint")]
        public long Stances { get; set; }

        [Column(TypeName = "uint")]
        public long StancesNot { get; set; }

        [Column(TypeName = "uint")]
        public long Targets { get; set; }

        [Column(TypeName = "uint")]
        public long CastingTimeIndex { get; set; }

        [Column(TypeName = "uint")]
        public long AuraInterruptFlags { get; set; }

        [Column(TypeName = "uint")]
        public long ProcFlags { get; set; }

        [Column(TypeName = "uint")]
        public long ProcChance { get; set; }

        [Column(TypeName = "uint")]
        public long ProcCharges { get; set; }

        [Column(TypeName = "uint")]
        public long MaxLevel { get; set; }

        [Column(TypeName = "uint")]
        public long BaseLevel { get; set; }

        [Column(TypeName = "uint")]
        public long SpellLevel { get; set; }

        [Column(TypeName = "uint")]
        public long DurationIndex { get; set; }

        [Column(TypeName = "uint")]
        public long RangeIndex { get; set; }

        [Column(TypeName = "uint")]
        public long StackAmount { get; set; }

        public int EquippedItemClass { get; set; }

        public int EquippedItemSubClassMask { get; set; }

        public int EquippedItemInventoryTypeMask { get; set; }

        [Column(TypeName = "uint")]
        public long Effect1 { get; set; }

        [Column(TypeName = "uint")]
        public long Effect2 { get; set; }

        [Column(TypeName = "uint")]
        public long Effect3 { get; set; }

        public int EffectDieSides1 { get; set; }

        public int EffectDieSides2 { get; set; }

        public int EffectDieSides3 { get; set; }

        public float EffectRealPointsPerLevel1 { get; set; }

        public float EffectRealPointsPerLevel2 { get; set; }

        public float EffectRealPointsPerLevel3 { get; set; }

        public int EffectBasePoints1 { get; set; }

        public int EffectBasePoints2 { get; set; }

        public int EffectBasePoints3 { get; set; }

        [Column(TypeName = "uint")]
        public long EffectMechanic1 { get; set; }

        [Column(TypeName = "uint")]
        public long EffectMechanic2 { get; set; }

        [Column(TypeName = "uint")]
        public long EffectMechanic3 { get; set; }

        [Column(TypeName = "uint")]
        public long EffectImplicitTargetA1 { get; set; }

        [Column(TypeName = "uint")]
        public long EffectImplicitTargetA2 { get; set; }

        [Column(TypeName = "uint")]
        public long EffectImplicitTargetA3 { get; set; }

        [Column(TypeName = "uint")]
        public long EffectImplicitTargetB1 { get; set; }

        [Column(TypeName = "uint")]
        public long EffectImplicitTargetB2 { get; set; }

        [Column(TypeName = "uint")]
        public long EffectImplicitTargetB3 { get; set; }

        [Column(TypeName = "uint")]
        public long EffectRadiusIndex1 { get; set; }

        [Column(TypeName = "uint")]
        public long EffectRadiusIndex2 { get; set; }

        [Column(TypeName = "uint")]
        public long EffectRadiusIndex3 { get; set; }

        [Column(TypeName = "uint")]
        public long EffectApplyAuraName1 { get; set; }

        [Column(TypeName = "uint")]
        public long EffectApplyAuraName2 { get; set; }

        [Column(TypeName = "uint")]
        public long EffectApplyAuraName3 { get; set; }

        public int EffectAmplitude1 { get; set; }

        public int EffectAmplitude2 { get; set; }

        public int EffectAmplitude3 { get; set; }

        public float EffectMultipleValue1 { get; set; }

        public float EffectMultipleValue2 { get; set; }

        public float EffectMultipleValue3 { get; set; }

        [Column(TypeName = "uint")]
        public long EffectItemType1 { get; set; }

        [Column(TypeName = "uint")]
        public long EffectItemType2 { get; set; }

        [Column(TypeName = "uint")]
        public long EffectItemType3 { get; set; }

        public int EffectMiscValue1 { get; set; }

        public int EffectMiscValue2 { get; set; }

        public int EffectMiscValue3 { get; set; }

        public int EffectMiscValueB1 { get; set; }

        public int EffectMiscValueB2 { get; set; }

        public int EffectMiscValueB3 { get; set; }

        [Column(TypeName = "uint")]
        public long EffectTriggerSpell1 { get; set; }

        [Column(TypeName = "uint")]
        public long EffectTriggerSpell2 { get; set; }

        [Column(TypeName = "uint")]
        public long EffectTriggerSpell3 { get; set; }

        [Column(TypeName = "uint")]
        public long EffectSpellClassMaskA1 { get; set; }

        [Column(TypeName = "uint")]
        public long EffectSpellClassMaskA2 { get; set; }

        [Column(TypeName = "uint")]
        public long EffectSpellClassMaskA3 { get; set; }

        [Column(TypeName = "uint")]
        public long EffectSpellClassMaskB1 { get; set; }

        [Column(TypeName = "uint")]
        public long EffectSpellClassMaskB2 { get; set; }

        [Column(TypeName = "uint")]
        public long EffectSpellClassMaskB3 { get; set; }

        [Column(TypeName = "uint")]
        public long EffectSpellClassMaskC1 { get; set; }

        [Column(TypeName = "uint")]
        public long EffectSpellClassMaskC2 { get; set; }

        [Column(TypeName = "uint")]
        public long EffectSpellClassMaskC3 { get; set; }

        [Column(TypeName = "uint")]
        public long MaxTargetLevel { get; set; }

        [Column(TypeName = "uint")]
        public long SpellFamilyName { get; set; }

        [Column(TypeName = "uint")]
        public long SpellFamilyFlags1 { get; set; }

        [Column(TypeName = "uint")]
        public long SpellFamilyFlags2 { get; set; }

        [Column(TypeName = "uint")]
        public long SpellFamilyFlags3 { get; set; }

        [Column(TypeName = "uint")]
        public long MaxAffectedTargets { get; set; }

        [Column(TypeName = "uint")]
        public long DmgClass { get; set; }

        [Column(TypeName = "uint")]
        public long PreventionType { get; set; }

        public float DmgMultiplier1 { get; set; }

        public float DmgMultiplier2 { get; set; }

        public float DmgMultiplier3 { get; set; }

        public int AreaGroupId { get; set; }

        [Column(TypeName = "uint")]
        public long SchoolMask { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string Comment { get; set; }
    }
}
