namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.gossip_menu_option")]
    public partial class gossip_menu_option
    {
        [Key]
        [Column(Order = 0, TypeName = "usmallint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MenuID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "usmallint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OptionID { get; set; }

        [Column(TypeName = "umediumint")]
        public int OptionIcon { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string OptionText { get; set; }

        [Column(TypeName = "mediumint")]
        public int OptionBroadcastTextID { get; set; }

        public byte OptionType { get; set; }

        [Column(TypeName = "uint")]
        public long OptionNpcFlag { get; set; }

        [Column(TypeName = "uint")]
        public long ActionMenuID { get; set; }

        [Column(TypeName = "umediumint")]
        public int ActionPoiID { get; set; }

        public byte BoxCoded { get; set; }

        [Column(TypeName = "uint")]
        public long BoxMoney { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string BoxText { get; set; }

        [Column(TypeName = "mediumint")]
        public int BoxBroadcastTextID { get; set; }

        public short VerifiedBuild { get; set; }
    }
}
