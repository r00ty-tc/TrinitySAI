namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.conditions")]
    public partial class condition
    {
        [Key]
        [Column(Order = 0, TypeName = "mediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SourceTypeOrReferenceId { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SourceGroup { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "mediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SourceEntry { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SourceId { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ElseGroup { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "mediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ConditionTypeOrReference { get; set; }

        [Key]
        [Column(Order = 6)]
        public byte ConditionTarget { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ConditionValue1 { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ConditionValue2 { get; set; }

        [Key]
        [Column(Order = 9, TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ConditionValue3 { get; set; }

        public byte NegativeCondition { get; set; }

        [Column(TypeName = "umediumint")]
        public int ErrorType { get; set; }

        [Column(TypeName = "umediumint")]
        public int ErrorTextId { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(64)]
        public string ScriptName { get; set; }

        [StringLength(255)]
        public string Comment { get; set; }
    }
}
