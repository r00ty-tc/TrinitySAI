namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.creature_text_locale")]
    public partial class creature_text_locale
    {
        [Key]
        [Column(Order = 0, TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CreatureID { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte GroupID { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte ID { get; set; }

        [Required]
        [StringLength(4)]
        public string Locale { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string Text { get; set; }
    }
}
