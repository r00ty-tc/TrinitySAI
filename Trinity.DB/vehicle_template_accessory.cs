namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.vehicle_template_accessory")]
    public partial class vehicle_template_accessory
    {
        [Key]
        [Column(Order = 0, TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int entry { get; set; }

        [Column(TypeName = "umediumint")]
        public int accessory_entry { get; set; }

        [Key]
        [Column(Order = 1)]
        public sbyte seat_id { get; set; }

        public byte minion { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string description { get; set; }

        public byte summontype { get; set; }

        [Column(TypeName = "uint")]
        public long summontimer { get; set; }
    }
}
