using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("SpecificationRuleHistory", Schema = "MSPWIP")]
    public partial class SpecificationRuleHistory
    {
        [Key]
        [Column("SpecificationRuleHistoryID")]
        public int SpecificationRuleHistoryId { get; set; }
        [Column("SpecificationID")]
        public int SpecificationId { get; set; }
        public Guid Version { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string ValidationType { get; set; } = null!;
        [StringLength(40)]
        [Unicode(false)]
        public string? RuleDefinition { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? RegexPattern { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? LowerLimit { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? UpperLimit { get; set; }
        [Column("UOM")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Uom { get; set; }
        public int? NoEntry { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string CreatedBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreatedOn { get; set; }
        [Column("RefBOM")]
        [StringLength(40)]
        [Unicode(false)]
        public string? RefBom { get; set; }
        public int? RefDays { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? RefK { get; set; }
        [Column("RequiredTTF", TypeName = "decimal(18, 2)")]
        public decimal? RequiredTtf { get; set; }

        [ForeignKey("SpecificationId")]
        [InverseProperty("SpecificationRuleHistories")]
        public virtual Specification Specification { get; set; } = null!;
    }
}
