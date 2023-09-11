using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("SpecificationRuleExt", Schema = "MSPWIP")]
    public partial class SpecificationRuleExt
    {
        [Key]
        [Column("SpecificationRuleExtID")]
        public int SpecificationRuleExtId { get; set; }
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

        [ForeignKey("SpecificationRuleId")]
        [InverseProperty("SpecificationRuleExts")]
        public virtual SpecificationRule SpecificationRule { get; set; } = null!;
    }
}
