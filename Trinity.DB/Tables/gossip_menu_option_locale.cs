namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.gossip_menu_option_locale")]
    public partial class gossip_menu_option_locale
    {
        [Key]
        [Column(Order = 0, TypeName = "usmallint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MenuID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "usmallint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OptionID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(4)]
        public string Locale { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string OptionText { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string BoxText { get; set; }
    }
}
