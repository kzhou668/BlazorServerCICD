using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("ItemValidationRule", Schema = "MSPWIP")]
    [Index("ItemId", Name = "nc_ItemCodeValidationRule_ItemId")]
    public partial class ItemValidationRule
    {
        [Key]
        public int ItemValidationRuleId { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string RuleType { get; set; } = null!;
        [StringLength(10)]
        [Unicode(false)]
        public string? Rule { get; set; }
        [StringLength(200)]
        [Unicode(false)]
        public string RuleValue { get; set; } = null!;
        public int ItemId { get; set; }

        [ForeignKey("ItemId")]
        [InverseProperty("ItemValidationRules")]
        public virtual Item Item { get; set; } = null!;
    }
}
