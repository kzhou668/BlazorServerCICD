using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("TestStageMap", Schema = "MSPWIP")]
    public partial class TestStageMap
    {
        [Key]
        [Column("TestStageMapID")]
        public int TestStageMapId { get; set; }
        [Column("TestStageID")]
        public int TestStageId { get; set; }
        [Required]
        [StringLength(50)]
        public string TestStage { get; set; }
        [Required]
        [StringLength(50)]
        public string Acronym { get; set; }
        [Required]
        [Column("MSPStage")]
        [StringLength(30)]
        public string Mspstage { get; set; }
    }
}
