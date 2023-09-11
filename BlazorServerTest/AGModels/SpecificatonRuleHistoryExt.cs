using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("SpecificatonRuleHistoryExt", Schema = "MSPWIP")]
    public partial class SpecificatonRuleHistoryExt
    {
        [Key]
        [Column("SpecificationRuleHistoryExtID")]
        public int SpecificationRuleHistoryExtId { get; set; }
        [Column("SpecificationRuleID")]
        public int SpecificationRuleId { get; set; }
        [StringLength(40)]
        [Unicode(false)]
        public string Stage { get; set; } = null!;
        [Column("RefBOMStart")]
        [StringLength(30)]
        [Unicode(false)]
        public string? RefBomstart { get; set; }
        [Column("RefBOMEnd")]
        [StringLength(30)]
        [Unicode(false)]
        public string? RefBomend { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Multiplier { get; set; }
        public Guid Version { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string CreatedBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreatedOn { get; set; }
    }
}
