using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("TestStageMap", Schema = "MSPWIP")]
    public partial class TestStageMap
    {
        [Key]
        [Column("TestStageMapID")]
        public int TestStageMapId { get; set; }
        [Column("TestStageID")]
        public int TestStageId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string TestStage { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Acronym { get; set; } = null!;
        [Column("MSPStage")]
        [StringLength(30)]
        [Unicode(false)]
        public string Mspstage { get; set; } = null!;
    }
}
