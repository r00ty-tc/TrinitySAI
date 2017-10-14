namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.game_event_model_equip")]
    public partial class game_event_model_equip
    {
        public sbyte eventEntry { get; set; }

        [Key]
        [Column(TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long guid { get; set; }

        [Column(TypeName = "umediumint")]
        public int modelid { get; set; }

        public byte equipment_id { get; set; }
    }
}
