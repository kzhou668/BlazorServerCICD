using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
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
        [Required]
        [StringLength(30)]
        public string ValidationType { get; set; }
        [StringLength(40)]
        public string RuleDefinition { get; set; }
        [StringLength(50)]
        public string RegexPattern { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? LowerLimit { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? UpperLimit { get; set; }
        [Column("UOM")]
        [StringLength(10)]
        public string Uom { get; set; }
        public int? NoEntry { get; set; }
        [Required]
        [StringLength(30)]
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedOn { get; set; }
        [Column("RefBOM")]
        [StringLength(40)]
        public string RefBom { get; set; }
        public int? RefDays { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? RefK { get; set; }
        [Column("RequiredTTF", TypeName = "decimal(18, 2)")]
        public decimal? RequiredTtf { get; set; }

        [ForeignKey(nameof(SpecificationId))]
        [InverseProperty("SpecificationRuleHistories")]
        public virtual Specification Specification { get; set; }
    }
}
