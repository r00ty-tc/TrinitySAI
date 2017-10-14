namespace Trinity.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("world_saieditor.npc_text")]
    public partial class npc_text
    {
        [Column(TypeName = "umediumint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(1073741823)]
        public string text0_0 { get; set; }

        [StringLength(1073741823)]
        public string text0_1 { get; set; }

        [Column(TypeName = "mediumint")]
        public int BroadcastTextID0 { get; set; }

        public byte lang0 { get; set; }

        public float Probability0 { get; set; }

        [Column(TypeName = "usmallint")]
        public int em0_0 { get; set; }

        [Column(TypeName = "usmallint")]
        public int em0_1 { get; set; }

        [Column(TypeName = "usmallint")]
        public int em0_2 { get; set; }

        [Column(TypeName = "usmallint")]
        public int em0_3 { get; set; }

        [Column(TypeName = "usmallint")]
        public int em0_4 { get; set; }

        [Column(TypeName = "usmallint")]
        public int em0_5 { get; set; }

        [StringLength(1073741823)]
        public string text1_0 { get; set; }

        [StringLength(1073741823)]
        public string text1_1 { get; set; }

        [Column(TypeName = "mediumint")]
        public int BroadcastTextID1 { get; set; }

        public byte lang1 { get; set; }

        public float Probability1 { get; set; }

        [Column(TypeName = "usmallint")]
        public int em1_0 { get; set; }

        [Column(TypeName = "usmallint")]
        public int em1_1 { get; set; }

        [Column(TypeName = "usmallint")]
        public int em1_2 { get; set; }

        [Column(TypeName = "usmallint")]
        public int em1_3 { get; set; }

        [Column(TypeName = "usmallint")]
        public int em1_4 { get; set; }

        [Column(TypeName = "usmallint")]
        public int em1_5 { get; set; }

        [StringLength(1073741823)]
        public string text2_0 { get; set; }

        [StringLength(1073741823)]
        public string text2_1 { get; set; }

        [Column(TypeName = "mediumint")]
        public int BroadcastTextID2 { get; set; }

        public byte lang2 { get; set; }

        public float Probability2 { get; set; }

        [Column(TypeName = "usmallint")]
        public int em2_0 { get; set; }

        [Column(TypeName = "usmallint")]
        public int em2_1 { get; set; }

        [Column(TypeName = "usmallint")]
        public int em2_2 { get; set; }

        [Column(TypeName = "usmallint")]
        public int em2_3 { get; set; }

        [Column(TypeName = "usmallint")]
        public int em2_4 { get; set; }

        [Column(TypeName = "usmallint")]
        public int em2_5 { get; set; }

        [StringLength(1073741823)]
        public string text3_0 { get; set; }

        [StringLength(1073741823)]
        public string text3_1 { get; set; }

        [Column(TypeName = "mediumint")]
        public int BroadcastTextID3 { get; set; }

        public byte lang3 { get; set; }

        public float Probability3 { get; set; }

        [Column(TypeName = "usmallint")]
        public int em3_0 { get; set; }

        [Column(TypeName = "usmallint")]
        public int em3_1 { get; set; }

        [Column(TypeName = "usmallint")]
        public int em3_2 { get; set; }

        [Column(TypeName = "usmallint")]
        public int em3_3 { get; set; }

        [Column(TypeName = "usmallint")]
        public int em3_4 { get; set; }

        [Column(TypeName = "usmallint")]
        public int em3_5 { get; set; }

        [StringLength(1073741823)]
        public string text4_0 { get; set; }

        [StringLength(1073741823)]
        public string text4_1 { get; set; }

        [Column(TypeName = "mediumint")]
        public int BroadcastTextID4 { get; set; }

        public byte lang4 { get; set; }

        public float Probability4 { get; set; }

        [Column(TypeName = "usmallint")]
        public int em4_0 { get; set; }

        [Column(TypeName = "usmallint")]
        public int em4_1 { get; set; }

        [Column(TypeName = "usmallint")]
        public int em4_2 { get; set; }

        [Column(TypeName = "usmallint")]
        public int em4_3 { get; set; }

        [Column(TypeName = "usmallint")]
        public int em4_4 { get; set; }

        [Column(TypeName = "usmallint")]
        public int em4_5 { get; set; }

        [StringLength(1073741823)]
        public string text5_0 { get; set; }

        [StringLength(1073741823)]
        public string text5_1 { get; set; }

        [Column(TypeName = "mediumint")]
        public int BroadcastTextID5 { get; set; }

        public byte lang5 { get; set; }

        public float Probability5 { get; set; }

        [Column(TypeName = "usmallint")]
        public int em5_0 { get; set; }

        [Column(TypeName = "usmallint")]
        public int em5_1 { get; set; }

        [Column(TypeName = "usmallint")]
        public int em5_2 { get; set; }

        [Column(TypeName = "usmallint")]
        public int em5_3 { get; set; }

        [Column(TypeName = "usmallint")]
        public int em5_4 { get; set; }

        [Column(TypeName = "usmallint")]
        public int em5_5 { get; set; }

        [StringLength(1073741823)]
        public string text6_0 { get; set; }

        [StringLength(1073741823)]
        public string text6_1 { get; set; }

        [Column(TypeName = "mediumint")]
        public int BroadcastTextID6 { get; set; }

        public byte lang6 { get; set; }

        public float Probability6 { get; set; }

        [Column(TypeName = "usmallint")]
        public int em6_0 { get; set; }

        [Column(TypeName = "usmallint")]
        public int em6_1 { get; set; }

        [Column(TypeName = "usmallint")]
        public int em6_2 { get; set; }

        [Column(TypeName = "usmallint")]
        public int em6_3 { get; set; }

        [Column(TypeName = "usmallint")]
        public int em6_4 { get; set; }

        [Column(TypeName = "usmallint")]
        public int em6_5 { get; set; }

        [StringLength(1073741823)]
        public string text7_0 { get; set; }

        [StringLength(1073741823)]
        public string text7_1 { get; set; }

        [Column(TypeName = "mediumint")]
        public int BroadcastTextID7 { get; set; }

        public byte lang7 { get; set; }

        public float Probability7 { get; set; }

        [Column(TypeName = "usmallint")]
        public int em7_0 { get; set; }

        [Column(TypeName = "usmallint")]
        public int em7_1 { get; set; }

        [Column(TypeName = "usmallint")]
        public int em7_2 { get; set; }

        [Column(TypeName = "usmallint")]
        public int em7_3 { get; set; }

        [Column(TypeName = "usmallint")]
        public int em7_4 { get; set; }

        [Column(TypeName = "usmallint")]
        public int em7_5 { get; set; }

        public short? VerifiedBuild { get; set; }
    }
}
