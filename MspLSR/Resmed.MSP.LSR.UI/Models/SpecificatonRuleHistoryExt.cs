using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("SpecificatonRuleHistoryExt", Schema = "MSPWIP")]
    public partial class SpecificatonRuleHistoryExt
    {
        [Key]
        [Column("SpecificationRuleHistoryExtID")]
        public int SpecificationRuleHistoryExtId { get; set; }
        [Column("SpecificationRuleID")]
        public int SpecificationRuleId { get; set; }
        [Required]
        [StringLength(40)]
        public string Stage { get; set; }
        [Column("RefBOMStart")]
        [StringLength(30)]
        public string RefBomstart { get; set; }
        [Column("RefBOMEnd")]
        [StringLength(30)]
        public string RefBomend { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Multiplier { get; set; }
        public Guid Version { get; set; }
        [Required]
        [StringLength(30)]
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedOn { get; set; }
    }
}
