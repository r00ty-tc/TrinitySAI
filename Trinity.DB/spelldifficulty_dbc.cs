namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.spelldifficulty_dbc")]
    public partial class spelldifficulty_dbc
    {
        [Column(TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }

        [Column(TypeName = "uint")]
        public long spellid0 { get; set; }

        [Column(TypeName = "uint")]
        public long spellid1 { get; set; }

        [Column(TypeName = "uint")]
        public long spellid2 { get; set; }

        [Column(TypeName = "uint")]
        public long spellid3 { get; set; }
    }
}
