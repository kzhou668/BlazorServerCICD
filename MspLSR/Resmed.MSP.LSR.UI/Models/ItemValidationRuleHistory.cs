using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("ItemValidationRuleHistory", Schema = "MSPWIP")]
    [Index(nameof(ItemId), Name = "nc_ItemValidationRuleHistory_ItemId")]
    public partial class ItemValidationRuleHistory
    {
        [Key]
        public int ItemValidationRuleHistoryId { get; set; }
        public int ItemId { get; set; }
        public Guid Version { get; set; }
        [Required]
        [StringLength(20)]
        public string RuleType { get; set; }
        [StringLength(10)]
        public string Rule { get; set; }
        [Required]
        [StringLength(200)]
        public string RuleValue { get; set; }
        [Required]
        [StringLength(50)]
        public string UpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedOn { get; set; }

        [ForeignKey(nameof(ItemId))]
        [InverseProperty("ItemValidationRuleHistories")]
        public virtual Item Item { get; set; }
    }
}
