namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.spell_bonus_data")]
    public partial class spell_bonus_data
    {
        [Key]
        [Column(TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int entry { get; set; }

        public float direct_bonus { get; set; }

        public float dot_bonus { get; set; }

        public float ap_bonus { get; set; }

        public float ap_dot_bonus { get; set; }

        [StringLength(255)]
        public string comments { get; set; }
    }
}
