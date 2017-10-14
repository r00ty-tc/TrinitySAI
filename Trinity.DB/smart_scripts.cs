namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.smart_scripts")]
    public partial class smart_scripts
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int entryorguid { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte source_type { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "usmallint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "usmallint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int link { get; set; }

        public byte event_type { get; set; }

        [Column(TypeName = "usmallint")]
        public int event_phase_mask { get; set; }

        public byte event_chance { get; set; }

        [Column(TypeName = "usmallint")]
        public int event_flags { get; set; }

        [Column(TypeName = "uint")]
        public long event_param1 { get; set; }

        [Column(TypeName = "uint")]
        public long event_param2 { get; set; }

        [Column(TypeName = "uint")]
        public long event_param3 { get; set; }

        [Column(TypeName = "uint")]
        public long event_param4 { get; set; }

        public byte action_type { get; set; }

        [Column(TypeName = "uint")]
        public long action_param1 { get; set; }

        [Column(TypeName = "uint")]
        public long action_param2 { get; set; }

        [Column(TypeName = "uint")]
        public long action_param3 { get; set; }

        [Column(TypeName = "uint")]
        public long action_param4 { get; set; }

        [Column(TypeName = "uint")]
        public long action_param5 { get; set; }

        [Column(TypeName = "uint")]
        public long action_param6 { get; set; }

        public byte target_type { get; set; }

        [Column(TypeName = "uint")]
        public long target_param1 { get; set; }

        [Column(TypeName = "uint")]
        public long target_param2 { get; set; }

        [Column(TypeName = "uint")]
        public long target_param3 { get; set; }

        public float target_x { get; set; }

        public float target_y { get; set; }

        public float target_z { get; set; }

        public float target_o { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string comment { get; set; }
    }
}
