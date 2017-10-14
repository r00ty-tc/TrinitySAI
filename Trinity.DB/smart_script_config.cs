namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.smart_script_config")]
    public partial class smart_script_config
    {
        [Key]
        [Column(Order = 0)]
        public byte config_type { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long config_key { get; set; }

        [Required]
        [StringLength(100)]
        public string config_name { get; set; }

        [Required]
        [StringLength(100)]
        public string param1_name { get; set; }

        [StringLength(100)]
        public string param2_name { get; set; }

        [Required]
        [StringLength(100)]
        public string param3_name { get; set; }

        [Required]
        [StringLength(100)]
        public string param4_name { get; set; }

        [Required]
        [StringLength(100)]
        public string param5_name { get; set; }

        [Required]
        [StringLength(100)]
        public string param6_name { get; set; }

        [Column(TypeName = "uint")]
        public long valid_flags { get; set; }

        [Column(TypeName = "bit")]
        public bool hidden { get; set; }

        [Required]
        [StringLength(250)]
        public string comment { get; set; }
    }
}
