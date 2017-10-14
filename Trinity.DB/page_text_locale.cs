namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.page_text_locale")]
    public partial class page_text_locale
    {
        [Key]
        [Column(Order = 0, TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string locale { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string Text { get; set; }

        public short? VerifiedBuild { get; set; }
    }
}
