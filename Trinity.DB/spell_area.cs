namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.spell_area")]
    public partial class spell_area
    {
        [Key]
        [Column(Order = 0, TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int spell { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int area { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int quest_start { get; set; }

        [Column(TypeName = "umediumint")]
        public int quest_end { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "mediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int aura_spell { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int racemask { get; set; }

        [Key]
        [Column(Order = 5)]
        public byte gender { get; set; }

        public byte autocast { get; set; }

        public int quest_start_status { get; set; }

        public int quest_end_status { get; set; }
    }
}
