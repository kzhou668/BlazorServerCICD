using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("Item", Schema = "MSPWIP")]
    [Index(nameof(ItemCode), Name = "ncu_Item_Item", IsUnique = true)]
    public partial class Item
    {
        public Item()
        {
            ItemValidationRuleHistories = new HashSet<ItemValidationRuleHistory>();
            ItemValidationRules = new HashSet<ItemValidationRule>();
        }

        [Key]
        public int ItemId { get; set; }
        [Required]
        [StringLength(30)]
        public string ItemCode { get; set; }
        [Required]
        [StringLength(50)]
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedOn { get; set; }
        [StringLength(50)]
        public string UpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        public Guid Version { get; set; }

        [InverseProperty(nameof(ItemValidationRuleHistory.Item))]
        public virtual ICollection<ItemValidationRuleHistory> ItemValidationRuleHistories { get; set; }
        [InverseProperty(nameof(ItemValidationRule.Item))]
        public virtual ICollection<ItemValidationRule> ItemValidationRules { get; set; }
    }
}
