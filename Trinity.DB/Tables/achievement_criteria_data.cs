namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.achievement_criteria_data")]
    public partial class achievement_criteria_data
    {
        [Key]
        [Column(Order = 0, TypeName = "mediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int criteria_id { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte type { get; set; }

        [Column(TypeName = "umediumint")]
        public int value1 { get; set; }

        [Column(TypeName = "umediumint")]
        public int value2 { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(64)]
        public string ScriptName { get; set; }
    }
}
