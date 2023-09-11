using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("ItemValidationRuleHistory", Schema = "MSPWIP")]
    [Index("ItemId", Name = "nc_ItemValidationRuleHistory_ItemId")]
    public partial class ItemValidationRuleHistory
    {
        [Key]
        public int ItemValidationRuleHistoryId { get; set; }
        public int ItemId { get; set; }
        public Guid Version { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string RuleType { get; set; } = null!;
        [StringLength(10)]
        [Unicode(false)]
        public string? Rule { get; set; }
        [StringLength(200)]
        [Unicode(false)]
        public string RuleValue { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string UpdatedBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime UpdatedOn { get; set; }

        [ForeignKey("ItemId")]
        [InverseProperty("ItemValidationRuleHistories")]
        public virtual Item Item { get; set; } = null!;
    }
}
