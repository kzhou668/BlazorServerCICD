using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("ProductCategorySet", Schema = "MSPWIP")]
    [Index(nameof(WipworkOrderId), Name = "nc_ProductCategorySet_WIPWorkOrderID")]
    public partial class ProductCategorySet
    {
        [Key]
        [Column("ProductCategoryID")]
        public int ProductCategoryId { get; set; }
        [Column("WIPWorkOrderID")]
        public int WipworkOrderId { get; set; }
        [Required]
        [StringLength(50)]
        public string ProductCategoryName { get; set; }
        [Required]
        [StringLength(50)]
        public string ProductCategoryValue { get; set; }
        public int ProductCategorySequence { get; set; }

        [ForeignKey(nameof(WipworkOrderId))]
        [InverseProperty(nameof(WorkOrder.ProductCategorySets))]
        public virtual WorkOrder WipworkOrder { get; set; }
    }
}
