using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("ItemValidationRule", Schema = "MSPWIP")]
    [Index(nameof(ItemId), Name = "nc_ItemCodeValidationRule_ItemId")]
    public partial class ItemValidationRule
    {
        [Key]
        public int ItemValidationRuleId { get; set; }
        [Required]
        [StringLength(20)]
        public string RuleType { get; set; }
        [StringLength(10)]
        public string Rule { get; set; }
        [Required]
        [StringLength(200)]
        public string RuleValue { get; set; }
        public int ItemId { get; set; }

        [ForeignKey(nameof(ItemId))]
        [InverseProperty("ItemValidationRules")]
        public virtual Item Item { get; set; }
    }
}
