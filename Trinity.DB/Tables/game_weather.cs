namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.game_weather")]
    public partial class game_weather
    {
        [Key]
        [Column(TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int zone { get; set; }

        public byte spring_rain_chance { get; set; }

        public byte spring_snow_chance { get; set; }

        public byte spring_storm_chance { get; set; }

        public byte summer_rain_chance { get; set; }

        public byte summer_snow_chance { get; set; }

        public byte summer_storm_chance { get; set; }

        public byte fall_rain_chance { get; set; }

        public byte fall_snow_chance { get; set; }

        public byte fall_storm_chance { get; set; }

        public byte winter_rain_chance { get; set; }

        public byte winter_snow_chance { get; set; }

        public byte winter_storm_chance { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(64)]
        public string ScriptName { get; set; }
    }
}
