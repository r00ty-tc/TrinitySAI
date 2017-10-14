namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.creature_template")]
    public partial class creature_template
    {
        [Key]
        [Column(TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int entry { get; set; }

        [Column(TypeName = "umediumint")]
        public int difficulty_entry_1 { get; set; }

        [Column(TypeName = "umediumint")]
        public int difficulty_entry_2 { get; set; }

        [Column(TypeName = "umediumint")]
        public int difficulty_entry_3 { get; set; }

        [Column(TypeName = "uint")]
        public long KillCredit1 { get; set; }

        [Column(TypeName = "uint")]
        public long KillCredit2 { get; set; }

        [Column(TypeName = "umediumint")]
        public int modelid1 { get; set; }

        [Column(TypeName = "umediumint")]
        public int modelid2 { get; set; }

        [Column(TypeName = "umediumint")]
        public int modelid3 { get; set; }

        [Column(TypeName = "umediumint")]
        public int modelid4 { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(100)]
        public string name { get; set; }

        [Column(TypeName = "char")]
        [StringLength(100)]
        public string subname { get; set; }

        [Column(TypeName = "char")]
        [StringLength(100)]
        public string IconName { get; set; }

        [Column(TypeName = "umediumint")]
        public int gossip_menu_id { get; set; }

        public byte minlevel { get; set; }

        public byte maxlevel { get; set; }

        public short exp { get; set; }

        [Column(TypeName = "usmallint")]
        public int faction { get; set; }

        [Column(TypeName = "uint")]
        public long npcflag { get; set; }

        public float speed_walk { get; set; }

        public float speed_run { get; set; }

        public float scale { get; set; }

        public byte rank { get; set; }

        public sbyte dmgschool { get; set; }

        [Column(TypeName = "uint")]
        public long BaseAttackTime { get; set; }

        [Column(TypeName = "uint")]
        public long RangeAttackTime { get; set; }

        public float BaseVariance { get; set; }

        public float RangeVariance { get; set; }

        public byte unit_class { get; set; }

        [Column(TypeName = "uint")]
        public long unit_flags { get; set; }

        [Column(TypeName = "uint")]
        public long unit_flags2 { get; set; }

        [Column(TypeName = "uint")]
        public long dynamicflags { get; set; }

        public sbyte family { get; set; }

        public sbyte trainer_type { get; set; }

        [Column(TypeName = "umediumint")]
        public int trainer_spell { get; set; }

        public byte trainer_class { get; set; }

        public byte trainer_race { get; set; }

        public byte type { get; set; }

        [Column(TypeName = "uint")]
        public long type_flags { get; set; }

        [Column(TypeName = "umediumint")]
        public int lootid { get; set; }

        [Column(TypeName = "umediumint")]
        public int pickpocketloot { get; set; }

        [Column(TypeName = "umediumint")]
        public int skinloot { get; set; }

        public short resistance1 { get; set; }

        public short resistance2 { get; set; }

        public short resistance3 { get; set; }

        public short resistance4 { get; set; }

        public short resistance5 { get; set; }

        public short resistance6 { get; set; }

        [Column(TypeName = "umediumint")]
        public int spell1 { get; set; }

        [Column(TypeName = "umediumint")]
        public int spell2 { get; set; }

        [Column(TypeName = "umediumint")]
        public int spell3 { get; set; }

        [Column(TypeName = "umediumint")]
        public int spell4 { get; set; }

        [Column(TypeName = "umediumint")]
        public int spell5 { get; set; }

        [Column(TypeName = "umediumint")]
        public int spell6 { get; set; }

        [Column(TypeName = "umediumint")]
        public int spell7 { get; set; }

        [Column(TypeName = "umediumint")]
        public int spell8 { get; set; }

        [Column(TypeName = "umediumint")]
        public int PetSpellDataId { get; set; }

        [Column(TypeName = "umediumint")]
        public int VehicleId { get; set; }

        [Column(TypeName = "umediumint")]
        public int mingold { get; set; }

        [Column(TypeName = "umediumint")]
        public int maxgold { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(64)]
        public string AIName { get; set; }

        public byte MovementType { get; set; }

        public byte InhabitType { get; set; }

        public float HoverHeight { get; set; }

        public float HealthModifier { get; set; }

        public float ManaModifier { get; set; }

        public float ArmorModifier { get; set; }

        public float DamageModifier { get; set; }

        public float ExperienceModifier { get; set; }

        public byte RacialLeader { get; set; }

        [Column(TypeName = "uint")]
        public long movementId { get; set; }

        public byte RegenHealth { get; set; }

        [Column(TypeName = "uint")]
        public long mechanic_immune_mask { get; set; }

        [Column(TypeName = "uint")]
        public long flags_extra { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(64)]
        public string ScriptName { get; set; }

        public short? VerifiedBuild { get; set; }
    }
}
