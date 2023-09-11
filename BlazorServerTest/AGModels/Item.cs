using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("Item", Schema = "MSPWIP")]
    [Index("ItemCode", Name = "ncu_Item_Item", IsUnique = true)]
    public partial class Item
    {
        public Item()
        {
            ItemValidationRuleHistories = new HashSet<ItemValidationRuleHistory>();
            ItemValidationRules = new HashSet<ItemValidationRule>();
        }

        [Key]
        public int ItemId { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string ItemCode { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string CreatedBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreatedOn { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? UpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        public Guid Version { get; set; }

        [InverseProperty("Item")]
        public virtual ICollection<ItemValidationRuleHistory> ItemValidationRuleHistories { get; set; }
        [InverseProperty("Item")]
        public virtual ICollection<ItemValidationRule> ItemValidationRules { get; set; }
    }
}
