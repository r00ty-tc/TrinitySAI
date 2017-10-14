namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.page_text")]
    public partial class page_text
    {
        [Column(TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(1073741823)]
        public string Text { get; set; }

        [Column(TypeName = "umediumint")]
        public int NextPageID { get; set; }

        public short? VerifiedBuild { get; set; }
    }
}
